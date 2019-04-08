using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Attributes
    private Node currentNode;
    private float affectionBar;
    private string sceneName;
    public GameObject nextButton;
    public GameObject previousButton;
    public GameObject option1Button;
    public GameObject option2Button;
    public GameObject option3Button;
    public GameObject endButton;
    public GameObject startButton;

    // Start is called before the first frame update
    void Start()
    {
        affectionBar = 0.0f;
        createTree();  
    }

    // Getters and Setters
    public Node getCurrentNode()
    {
        return currentNode;
    }
    public void setCurrentNode(Node n)
    {
        currentNode = n;
    }
    public void decrementAffectionBar()
    {
        affectionBar -= 0.05f;
        if (affectionBar <= 0.05f) affectionBar = 0.0f;
    }
    public void incrementAffectionBar(float value)
    {
        affectionBar += value;
        if (affectionBar >= 0.95f) affectionBar = 1.0f;
    }
    public void disableOptionButtons()
    {
        option1Button.SetActive(false);
        option2Button.SetActive(false);
        option3Button.SetActive(false);
    }
    public void disableEndButton()
    {
        endButton.SetActive(false);
    }

    // Create the tree node by node
    public void createTree()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Onboarding") createOnboardingTree();
        if (sceneName == "Day1Part1") createPart1Tree();
        if (sceneName == "Day1Part2") createPart2Tree();
        if (sceneName == "Day1Part3") createPart3Tree();
    }

    // Create day 1 part 1 tree
    public void createPart1Tree()
    {
        Node n29 = new Node();
        n29.setText("'Oh shoot! I have to head out Tsath, I got a...thing I got to do!'. Tsathoggua looks at Cthulhu, sad that he has to leave, 'Oh, alright Cthulhu, go do your thing.'. Cthulhu heads for the exit, but turns around and says, 'I'll be sure to visit you again, Tsath. You aren't as lonely as you think, I'll always be here for you!'. Tsathoggua smiles as Cthulhu leaves for his next date.");
        Node n28 = new Node();
        n28.setText("Cthulhu holds onto Tsathoggua's jelly rolls and keeps the kiss going, but is rudely interrupted by his phone. He glances at it, it's a reminder for his next date!");
        n28.setNext(n29);
        Node n27 = new Node();
        n27.setText("Cthulhu breaks free and says nervously, 'Haha...thanks...'. 'Why did he kiss me', he thinks, uncomfortable about the situation. The sound of his phone breaks the uncomfortable silence, reminding him of his next date.");
        n27.setNext(n29);
        Node n26 = new Node();
        n26.setText("Cthulhu awakens soon after, resting on Tsathoggua's pot belly after he passed out. After realizing Tsathoggua is asleep as well, Cthulhu looks at his phone. 'My next date!', he thinks as he sees the reminder. He quickly wakes the jello-like husk that is Tsathoggua.");
        n26.setNext(n29);
        Node n25 = new Node();
        n25.setText("Sloppily kisses Tsathoggua back");
        n25.setRating("real good");
        n25.setNext(n28);
        Node n24 = new Node();
        n24.setText("Struggles and breaks free");
        n24.setRating("bad");
        n24.setNext(n27);
        Node n23 = new Node();
        n23.setText("Passes out from the overwhelming pressure of Tsathoggua's strength");
        n23.setRating("good");
        n23.setNext(n26);
        Node n22 = new Node();
        n22.setText("Before Cthulhu can say anything, he is attacked by an overwhelmingly sloppy kiss. His tentacles flail everywhere as Tsathoggua's brute strength lifts him off the ground. Cthulhu");
        n22.setOption1(n23);
        n22.setOption2(n24);
        n22.setOption3(n25);
        Node n21 = new Node();
        n21.setText("Cthulhu looks at Tsathoggua, 'The coffee was good, a little hot though...'. For the next hour, Tsathoggua and Cthulhu sit silently. Cthulhu pretends to sip the coffee, even though he isn't, while Tsathoggua happily gulps it all down. After a dreadful amount of time, Cthulhu says, 'Hey, want to do something? We can...uh...'. Cthulhu looks around as his eyes land on a rock, 'We can play catch!'. Tsathoggua makes a funny face, not liking the idea of movement and says, 'I'd rather do something else.'.");
        n21.setNext(n22);
        n22.setPrevious(n21);
        Node n20 = new Node();
        n20.setText("Cthulhu brushes off his tongue and pretends to smile about the situation.");
        n20.setNext(n21);
        Node n19 = new Node();
        n19.setText("'Oh I thought you liked it?', Tsathoggua says.");
        n19.setNext(n21);
        Node n18 = new Node();
        n18.setText("Spits the coffee out when Tsathoggua isn't looking");
        n18.setRating("good");
        n18.setNext(n20);
        Node n17 = new Node();
        n17.setText("Swallows the mouthful he has and sets the cup down");
        n17.setRating("real good");
        n17.setNext(n20);
        Node n16 = new Node();
        n16.setText("Spits the coffee out mid-sip");
        n16.setRating("bad");
        n16.setNext(n19);
        Node n15 = new Node();
        n15.setText("Cthulhu looks at Tsathoggua, 'No problem Tsath, I couldn't get ready for the apocalypse and not see the laziest monster I know first, what kind of monster would I be?'. Cthulhu sips the coffee, surprised by how good it actually is. 'Wow, what makes this coffee so good, the humans?', he says as he continues sipping. Tsathoggua smirks and says, 'The coffee these worshippers bring me is quite aweful, so I add a secret ingredient, excrement!'. Cthulhu's eyes widen and he");
        n15.setOption1(n16);
        n15.setOption2(n17);
        n15.setOption3(n18);
        Node n14 = new Node();
        n14.setText("Tsathoggua whines, 'Cthulhu, I've been so busy doing nothing that I haven't had time to invite anyone over. Thank you for coming!'.");
        n14.setNext(n15);
        Node n13 = new Node();
        n13.setText("Allow it to happen");
        n13.setRating("real good");
        n13.setNext(n14);
        Node n12 = new Node();
        n12.setText("Slightly move to assess the situation");
        n12.setRating("good");
        n12.setNext(n14);
        Node n11 = new Node();
        n11.setText("Quickly move away, disgusted");
        n11.setRating("bad");
        n11.setNext(n14);
        Node n10 = new Node();
        n10.setText("'Lately, all of these humans have been coming to worship me', Tsathoggua says. 'I told them I like coffee and they bought me some, but now they won't stop! At least they built the shack and put up signs like I asked!'. Cthulhu laughs at his friend's misfortune and is quickly surrounded by a gelatinous mountain of hairy fur as Tsathoggua embraces him. Cthulhu decides to");
        n10.setOption1(n11);
        n10.setOption2(n12);
        n10.setOption3(n13);
        Node n9 = new Node();
        n9.setText("Tsathoggua, with a great heave, lifts his large pot belly. Underneath lies a little shack with the same terribly constructed sign on top. 'Wow', Cthulhu thinks, wondering how the shack is still standing under Tsathoggua's large belly. 'Come on in and get some coffee!', Tsathoggua bellows. Cthulhu, unable to fit of course, slides close to Tsathoggua and grabs a coffee from the shack. 'Where did you get the idea to do all of this, I thought you were a lazy barnacle?', Cthulhu says snarkily.");
        n9.setNext(n10);
        n10.setPrevious(n9);
        Node n8 = new Node();
        n8.setText("Cthulhu makes his way across the room, still wondering about the sign outside. 'Tsath, what's up with that Cave of Coffee sign outside?'. Tsathoggua looks at Cthulhu and jiggles in place as he attempts to move, but to no prevail, 'I opened a coffee shop to the public', he said with a grunt. Cthulhu's tentabrow furrows, 'Well...where is it?'.");
        n8.setNext(n9);
        n9.setPrevious(n8);
        Node n7 = new Node();
        n7.setText("'Cthulhu! Do you know how hard I've worked to get this place smelling the way it does? I've done absolutely nothing...and it's been exhausting!'");
        n7.setNext(n8);
        Node n6 = new Node();
        n6.setText("'Thank you for noticing, Cthulhu, I've tried my best to do absolutely nothing these last 100 years!'");
        n6.setNext(n8);
        Node n5 = new Node();
        n5.setText("'Tsath, buddy, these last decades have treated you good!'");
        n5.setRating("good");
        n5.setNext(n6);
        Node n4 = new Node();
        n4.setText("'What's that smell? It smells like a dead sea fungus in here!'");
        n4.setRating("bad");
        n4.setNext(n7);
        Node n3 = new Node();
        n3.setText("'Hey Tsath, glad to see you bud, did you gain weight?'");
        n3.setRating("real good");
        n3.setNext(n6);
        Node n2 = new Node();
        n2.setText("Cthulhu entered the cave slowly, the smell of monster excrement and coffee beans filled the air. Following the smell led him directly to Tsathoggua. Tsathoggua was as huge, hairy, and pot-bellied as Cthulhu had remembered, the sight and smell of the room prompted him to say");
        n2.setOption1(n3);
        n2.setOption2(n4);
        n2.setOption3(n5);
        Node n1 = new Node();
        n1.setText("As Cthulhu walked through the woods towards his date, he quickly noticed a poorly built sign. The sign was written in crayon and was one nail away from falling apart. It read, 'Cave of Coffee, come one, come all!'. Still sluggish from his long sleep and craving coffee, he headed in the direction of the closest cave.");
        n1.setNext(n2);
        n2.setPrevious(n1);

        // set root node
        setCurrentNode(n1);
    }

    // Create day 1 part 2 tree
    public void createPart2Tree()
    {
        Node n1 = new Node();
        n1.setText("Insert date text");

        // set root node
        setCurrentNode(n1);
    }

    // Create day 1 part 3 tree
    public void createPart3Tree()
    {
        Node n1 = new Node();
        n1.setText("Insert date text");

        // set root node
        setCurrentNode(n1);
    }

    // Create tree for onboarding
    public void createOnboardingTree()
    {
        Node n8 = new Node();
        n8.setText("Notice how you gained affection from your choice? Each response will have either a positive or negative effect on your level of affection. Each monster prefers a particular mate, figure out their ideal monster to quickly win their hearts!");
        Node n7 = new Node();
        n7.setText("I'm the best choice!");
        n7.setNext(n8);
        Node n6 = new Node();
        n6.setText("No Pick me!");
        n6.setNext(n8);
        Node n5 = new Node();
        n5.setText("Pick me!");
        n5.setNext(n8);
        Node n4 = new Node();
        n4.setText("Every so often, dialog options will pop up below. Each option affects the level of affection the current monster has for you, try it out!");
        n4.setOption1(n5);
        n4.setOption2(n6);
        n4.setOption3(n7);
        Node n3 = new Node();
        n3.setText("In this game, you'll meet numerous Lovecraftian monsters in the hopes of soothing Cthulhu's lonely heart.");
        n3.setNext(n4);
        n4.setPrevious(n3);
        Node n2 = new Node();
        n2.setText("If you ever want to re-read previous dialog, press the previous button");
        n2.setNext(n3);
        n3.setPrevious(n2);
        Node n1 = new Node();
        n1.setText("Welcome to Date Or Die! This game is a dating sim that focuses on the dating life of our all powerful Cthulhu. Press the next button to see the next line of dialog.");
        n1.setNext(n2);
        n2.setPrevious(n1);

        // set root node
        setCurrentNode(n1);
    }

    // Display the current node
    public void displayCurrentNode()
    {
        // display text of current node
        GameObject.Find("DialogText").GetComponent<Text>().text = currentNode.getText();
        // display previous and next button (if previous and next node are not false)
        if (currentNode.getPrevious() != null) previousButton.SetActive(true);
        else previousButton.SetActive(false);
        if (currentNode.getNext() != null) nextButton.SetActive(true);
        // if next is null, display 3 buttons with text of options
        else if(currentNode.getNext() == null && (currentNode.getOption1()!=null && currentNode.getOption2() != null && currentNode.getOption3() != null))
        {
            nextButton.SetActive(false);
            option1Button.GetComponentInChildren<Text>().text = currentNode.getOption1().getText();
            option1Button.SetActive(true);
            option2Button.GetComponentInChildren<Text>().text = currentNode.getOption2().getText();
            option2Button.SetActive(true);
            option3Button.GetComponentInChildren<Text>().text = currentNode.getOption3().getText();
            option3Button.SetActive(true);
        }
        else // end condition
        {
            nextButton.SetActive(false);
            if (sceneName != "Onboarding") endButton.SetActive(true);
            else startButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        displayCurrentNode();
    }
}

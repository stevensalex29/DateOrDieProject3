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
    private string affectionBarName;
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
        PlayerPrefs.DeleteAll();
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
        affectionBar -= 0.10f;
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
        if (sceneName == "Onboarding")
        {
            createOnboardingTree();
            affectionBarName = "onboarding";
        }
        if (sceneName == "Day1Part1")
        {
            createPart1Tree();
            affectionBarName = "affection1";
        }
        if (sceneName == "Day1Part2")
        {
            createPart2Tree();
            affectionBarName = "affection2";
        }
        if (sceneName == "Day1Part3")
        {
            createPart3Tree();
            affectionBarName = "affection3";
        }
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
        n25.setStat("Choice4Option3");
        n25.setNext(n28);
        Node n24 = new Node();
        n24.setText("Struggles and breaks free");
        n24.setRating("bad");
        n24.setStat("Choice4Option2");
        n24.setNext(n27);
        Node n23 = new Node();
        n23.setText("Passes out from the overwhelming pressure of Tsathoggua's strength");
        n23.setRating("good");
        n23.setStat("Choice4Option1");
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
        n18.setStat("Choice3Option3");
        n18.setNext(n20);
        Node n17 = new Node();
        n17.setText("Swallows the mouthful he has and sets the cup down");
        n17.setRating("real good");
        n17.setStat("Choice3Option2");
        n17.setNext(n20);
        Node n16 = new Node();
        n16.setText("Spits the coffee out mid-sip");
        n16.setRating("bad");
        n16.setStat("Choice3Option1");
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
        n13.setStat("Choice2Option3");
        n13.setNext(n14);
        Node n12 = new Node();
        n12.setText("Slightly move to assess the situation");
        n12.setRating("good");
        n12.setStat("Choice2Option2");
        n12.setNext(n14);
        Node n11 = new Node();
        n11.setText("Quickly move away, disgusted");
        n11.setRating("bad");
        n11.setStat("Choice2Option1");
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
        n5.setStat("Choice1Option3");
        n5.setNext(n6);
        Node n4 = new Node();
        n4.setText("'What's that smell? It smells like a dead sea fungus in here!'");
        n4.setRating("bad");
        n4.setStat("Choice1Option2");
        n4.setNext(n7);
        Node n3 = new Node();
        n3.setText("'Hey Tsath, glad to see you bud, did you gain weight?'");
        n3.setRating("real good");
        n3.setStat("Choice1Option1");
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
        Node n25 = new Node();
        n25.setText("Cthulhu looked at his phone, seeing the reminder for his next date. 'Sorry, Nyarlathotep, we’ll just have to pick up where we left off next time.', Cthulhu said with an excited look as he walked back into the bay to leave. 'Just don’t make me wait too long. Or I'll find someone to replace those big shoes of yours.', Nyarlathotep slyly remarked, knowing no one could compare to Cthulhu.");

        Node n24 = new Node();
        n24.setText("Cthulhu nervously puts his cucumbers back on and explains, 'I'm ready for you, Nyarlathotep.' After uttering those words, Nyarlathotep kisses him on the cheek and says, 'I’m looking for someone more assertive and that just isn't you right now. Sorry, darling, I'm just not feeling it anymore. Maybe we can try this another time.' Cthulhu felt stung by his words, but knew there was truth in what he said. As cthulhu was contemplating what to say next, his phone alarm went off.");
        n24.setNext(n25);

        Node n23 = new Node();
        n23.setText("Cthulhu, knowing he had ruined the mood, said, ' I'm sorry, I just need some space. I wasn't ready for something like that.' Cthulhu hugs Nyarlathotep, apologizing for the slap. Just as the hug ends, Cthulhu’s phone alarm goes off.");
        n23.setNext(n25);

        Node n22 = new Node();
        n22.setText("Cthulhu embraced Nyarlathotep, his tentacles intermingling with Nyarlathotep’s hands. Both monsters were locked in place, wishing this moment could go on forever. Just when the tension was at its peak, they were interrupted by the sound of Cthulhu’s phone alarm.");
        n22.setNext(n25);

        Node n21 = new Node();
        n21.setText("Puts his cucumbers back on and goes with the flow");
        n21.setRating("good");
        n21.setStat("1Choice3Option3");
        n21.setNext(n24);

        Node n20 = new Node();
        n20.setText("Slaps Nyarlathotep, pushing him away");
        n20.setRating("bad");
        n20.setStat("1Choice3Option2");
        n20.setNext(n23);

        Node n19 = new Node();
        n19.setText("Sensually kisses Nyarlathotep back");
        n19.setRating("real good");
        n19.setStat("1Choice3Option1");
        n19.setNext(n22);

        Node n18 = new Node();
        n18.setText("As Nyarlathotep starts applying oil, he tells Cthulhu, 'To really get the full experience, you need to put these on. They really help with your complexion.' Nyarlathotep hands Cthulhu pieces of cucumber to place over each eye. Nyarlathotep then goes on to massage Cthulhu’s massive back. He feels Nyarlathotep’s gentle caress on each and every tentacle as he starts getting closer and closers to Cthulhu’s neck. Without warning, Nyarlathotep massage stops. Cthulhu, wondering why he stopped, says, 'Nyarlathotep are you still back there?'. As Cthulhu takes off his cucumber slices, Nyarlathotep silently goes in for a kiss. Before Cthulhu can realize what is happening, he");
        n18.setOption1(n19);
        n18.setOption2(n20);
        n18.setOption3(n21);
        

        Node n17 = new Node();
        n17.setText("After Cthulhu had finished applying oil to Nyarlathotep’s back, Nyarlathotep insisted it was Cthulhu’s turn next. 'No, no, I really don't tan, I burn and smell like calamari', Cthulhu blushingly admits. 'Oh I don't think so! I bet you would smell delicious', Nyarlathotep says while licking his lips. Begrudgingly, Cthulhu accepts the offer, knowing what Nyarlathotep would do if he was denied his fun.");
        n17.setNext(n18);
        n18.setPrevious(n17);

        Node n16 = new Node();
        n16.setText("'Those tentacles of yours are just Divine. If you weren't my friend I would hire you on the spot, darling.'");
        n16.setNext(n17);

        Node n15 = new Node();
        n15.setText("'Why do you even need to tan when you can change the color of your skin?', inquiries Cthulhu. This causes Nyarlathotep to start berating, 'I told you to apply the oil! I’m trying to go for a natural tan look, not a pale as a ghost look .You just don't understand the effort I put in to look this good every day.'");
        n15.setNext(n17);

        Node n14 = new Node();
        n14.setText("Start applying oil , then go in for the back rub");
        n14.setRating("real good");
        n14.setStat("1Choice2Option3");
        n14.setNext(n16);

        Node n13 = new Node();
        n13.setText("Start applying the oil");
        n13.setRating("good");
        n13.setStat("1Choice2Option2");
        n13.setNext(n16);

        Node n12 = new Node();
        n12.setText("Begrudgingly start applying sun tan lotion");
        n12.setRating("bad");
        n12.setStat("1Choice2Option1");
        n12.setNext(n15);

        Node n11 = new Node();
        n11.setText("Cthulhu smirked and said, 'Nice party trick. Where did you send them to?'. Nyarlathotep, giddy with excitement, tells Cthulhu, 'You'll find out soon, sweetie. In the meantime, why don't you help me rub some lotion on my back. I'm trying to tan the natural way, really get a feel for how the humans do it. They might not be good for much, but they sure do know how to make a fine tanning oil.'");
        n11.setOption1(n12);
        n11.setOption2(n13);
        n11.setOption3(n14);
       

        Node n10 = new Node();
        n10.setText("With a single snap from Nyarlathotep’s fingers, the entire crowd seems to shudder and freeze. Not a single sound could be heard, except for the crashing of the waves. Suddenly, every frozen paparazzi began sinking into the sand, leaving only three things left on the beach: Cthulhu, Nyarlathotep and a beach towel for two.");
        n10.setNext(n11);
        n11.setPrevious(n10);

        Node n9 = new Node();
        n9.setText("After greeting Cthulhu, Nyarlathotep asked with a smile, 'Why are you so nervous, haven’t you ever been to a photo shoot?'. Cthulhu looked at him, groaning as he said, 'You know I hate crowds'. Nyarlathotep shakes his head, reluctantly holding down a chuckle saying, 'Cthulhu, The Great Old One, can’t handle a small crowd. You sure know how to make me laugh, old pal.'");
        n9.setNext(n10);
        n10.setPrevious(n9);

        Node n8 = new Node();
        n8.setText("'I’ve worked very hard to get all 4 of my Instagram’s to the top of the charts? Oh wait, all you do is sleep all year, so what would you know…'");
        n8.setNext(n9);

        Node n7 = new Node();
        n7.setText("'As I like to say: nothing's worth doing if you're not doing it big.'");
        n7.setNext(n9);

        Node n6 = new Node();
        n6.setText("'Nyarl, buddy, you sure know how to throw a party!'");
        n6.setRating("good");
        n6.setStat("1Choice1Option3");
        n6.setNext(n7);

        Node n5 = new Node();
        n5.setText("'Why is it always crowds with you, we never get to talk one on one?'");
        n5.setRating("bad");
        n5.setStat("1Choice1Option2");
        n5.setNext(n8);

        Node n4 = new Node();
        n4.setText("'Hey Nyarl, glad to see your still creating crowds wherever you go.'");
        n4.setRating("real good");
        n4.setStat("1Choice1Option1");
        n4.setNext(n7);

        Node n3 = new Node();
        n3.setText("It is at this point that Cthulhu found the source of the photographers’ obsession. Standing in the center of this massive circle of monsters was an impossibly handsome man whose appearance seemed to get more beautiful the longer he stared at him. Cthulhu recognized this man as Nyarlathotep, The Crawling Chaos, a shape shifter with a pension towards narcissism. As Cthulhu walked up to greet him he said");
        n3.setOption1(n4);
        n3.setOption2(n5);
        n3.setOption3(n6);

        Node n2 = new Node();
        n2.setText("As he reached the shore, Cthulhu noticed something off about the people there. Each and every monster was huddled in a circle, surrounding one person as they tried taking pictures of them. Cthulhu, confused by the scene, asked one of the photographers what was happening, only for them to reply, ‘He’s gorgeous.’. Perplexed by this answer, he ask another photographer, then another, then another. Fed up from getting the same answer, Cthulhu forced his way into the center of the circle.");
        n2.setNext(n3);
        n3.setPrevious(n2);

        Node n1 = new Node();
        n1.setText("Cthulhu feels sand at his feet as he rises from the ocean to a luxurious beach filled to the brim with people. As he gets closer to the shoreline, he notices a sign with the words ‘Penumbra beach’ etched into the small wooden post. Cthulhu had always hated the beach, too much sand and too many people. However, not even he would not miss an invitation to spend time with Nyarlathotep.");
        n1.setNext(n2);
        n2.setPrevious(n1);
   

        // set root node
        setCurrentNode(n1);
    }

    // Create day 1 part 3 tree
    public void createPart3Tree()
    {
        Node n73 = new Node();
        n73.setText("Shub-Niggurath began ascending to space. Cthulhu waved her goodbye and began walking towards the ocean. He was almost startled by the sound of a building being crushed under his foot. “Wow”, he thought, “What a mess.”");

        Node n72 = new Node();
        n72.setText("“Perhaps.”, she said with a wink.");
        n72.setNext(n73);
        n73.setPrevious(n72);

        Node n71 = new Node();
        n71.setText("“Well, maybe next time I can invite you over.”, he said grinning back.");
        n71.setNext(n72);
        n72.setPrevious(n71);

        Node n70 = new Node();
        n70.setText("“I am”, she looked at him grinning. “I would love to invite you over, but I don’t think you are capable of following me.”");
        n70.setNext(n71);
        n71.setPrevious(n70);

        Node n69 = new Node();
        n69.setText("“Going home now?”, he inquired.");
        n69.setNext(n70);
        n70.setPrevious(n69);

        Node n68 = new Node();
        n68.setText("“It usually is”, she replied. A tentacle protruded from her side and grabbed the projector, bringing it inside her tendrils.");
        n68.setNext(n69);
        n69.setPrevious(n68);

        Node n67 = new Node();
        n67.setText("“Shub, it was great seeing you”, Cthulhu said, smiling.");
        n67.setNext(n68);
        n68.setPrevious(n67);

        Node n66 = new Node();
        n66.setText("Both creatures got up");
        n66.setNext(n67);

        Node n65 = new Node();
        n65.setText("“Yup. That it was.”, Shub replied dryly.");
        n65.setNext(n66);
        n66.setPrevious(n65);

        Node n64 = new Node();
        n64.setText("“Well”, Cthulhu began, “That was certainly something.”");
        n64.setNext(n65);
        n65.setPrevious(n64);

        Node n63 = new Node();
        n63.setText("Shub-Niggurath continued to lean against Cthulhu's shoulder. They continued watching the movie until the credits began to roll.");
        n63.setNext(n64);
        n64.setPrevious(n63);

        Node n62 = new Node();
        n62.setText("“Sure, whatever you want.”");
        n62.setNext(n63);
        n63.setPrevious(n62);

        Node n61 = new Node();
        n61.setText("“Yeah, but you kept saying it would get better, so I might as well keep watching, right?”");
        n61.setNext(n62);
        n62.setPrevious(n61);

        Node n60 = new Node();
        n60.setText("“I thought you were hating it.”");
        n60.setNext(n61);
        n61.setPrevious(n60);

        Node n59 = new Node();
        n59.setText("“I’m not shy, I just wanna keep watching the movie”, his lie was almost convincing.");
        n59.setNext(n60);
        n60.setPrevious(n59);

        Node n58 = new Node();
        n58.setText("“Wow. Who knew you’d be so shy.”");
        n58.setNext(n59);
        n59.setPrevious(n58);

        Node n57 = new Node();
        n57.setText("Shub smiled, surprised by his actions.");
        n57.setNext(n58);

        Node n56 = new Node();
        n56.setText("She smiled. “I would love to.”");
        n56.setNext(n67);

        Node n55 = new Node();
        n55.setText("“So did I. Wanna do this again some other day?”");
        n55.setNext(n56);
        n56.setPrevious(n55);

        Node n54 = new Node();
        n54.setText("“Cthulhu, I had a great time tonight.”");
        n54.setNext(n55);
        n55.setPrevious(n54);

        Node n53 = new Node();
        n53.setText("They stayed like that for a while, up until the credits stopped rolling. Eventually, she got up, and so did he. Staring at his eyes, she said:");
        n53.setNext(n54);
        n54.setPrevious(n53);

        Node n52 = new Node();
        n52.setText("Cthulhu leaned back, pulling her closer. The mass of tentacles now leaned on his arm and chest. Cthulhu began slowly caressing her - uhhhh - back? It was hard to tell.");
        n52.setNext(n53);
        n53.setPrevious(n52);

        Node n51 = new Node();
        n51.setText("Shub giggled. “No, but I’m happy you have now.”");
        n51.setNext(n52);
        n52.setPrevious(n51);

        Node n50 = new Node();
        n50.setText("“Have I ever told you that you have the most beautiful tentacles I have ever seen?”");
        n50.setNext(n51);

        Node n49 = new Node();
        n49.setText("“Yeah, you are.”");
        n49.setNext(n67);

        Node n48 = new Node();
        n48.setText("“I’m good at doing that.”");
        n48.setNext(n49);
        n49.setPrevious(n48);

        Node n47 = new Node();
        n47.setText("“I wasn’t at first, but you really changed my mind.”, he smiles.");
        n47.setNext(n48);
        n48.setPrevious(n47);

        Node n46 = new Node();
        n46.setText("“So, did you like the movie?”, she whispers while staring at Cthulhu’s eyes.");
        n46.setNext(n47);
        n47.setPrevious(n46);

        Node n45 = new Node();
        n45.setText("Before he can barely approach Shub’s face, her tentacles are already wrapping around his. The sight and sounds of the two sets of tentacles rubbing and twisting around each other is enough to break the minds of all surviving humans in an 8 mile radius. After a while, the credits begin rolling, and they let go of each other.");
        n45.setNext(n46);

        Node n44 = new Node();
        n44.setText("Shyly look back at the screen.");
        n44.setRating("bad");
        n44.setStat("2Choice3Option3");
        n44.setNext(n57);
        n57.setPrevious(n44);

        Node n43 = new Node();
        n43.setText("Give her a compliment.");
        n43.setRating("good");
        n43.setStat("2Choice3Option2");
        n43.setNext(n50);
        n50.setPrevious(n43);

        Node n42 = new Node();
        n42.setText("Go in for the kiss.");
        n42.setRating("real good");
        n42.setStat("2Choice3Option1");
        n42.setNext(n45);
        n45.setPrevious(n42);

        Node n41 = new Node();
        n41.setText("They locked (dozens of) eyes for a moment.");
        n41.setOption1(n42);
        n41.setOption2(n43);
        n41.setOption3(n44);
        n42.setPrevious(n41);
        n43.setPrevious(n41);
        n44.setPrevious(n41);
        n67.setPrevious(n41);

        Node n40 = new Node();
        n40.setText("Shub snorted as she laughed. “That’s sad.”");
        n40.setNext(n41);
        n41.setPrevious(n40);

        Node n39 = new Node();
        n39.setText("“I know. I’ve practiced this move to perfection in front of my mirror.”");
        n39.setNext(n40);
        n40.setPrevious(n39);

        Node n38 = new Node();
        n38.setText("“Smooth”, she said sarcastically.");
        n38.setNext(n39);
        n39.setPrevious(n38);

        Node n37 = new Node();
        n37.setText("Shub-Niggurath squeezed Cthulhu’s arm lightly with her tendrils as she leaned closer. With an exaggeratedly fake yawn and stretch, he wrapped his arm around her.");
        n37.setNext(n38);
        n38.setPrevious(n37);

        Node n36 = new Node();
        n36.setText("“Hey”, she said in a hushed tone. “It’s just a movie. Don’t be an ass.”");
        n36.setNext(n37);
        n37.setPrevious(n36);

        Node n35 = new Node();
        n35.setText("“Like, she could easily just destroy all the humans and ignore Godzilla completely!”");
        n35.setNext(n36);
        n36.setPrevious(n35);

        Node n34 = new Node();
        n34.setText("“Shhh. Just let it happen.” Shub didn’t look away from the screen.");
        n34.setNext(n35);
        n35.setPrevious(n34);

        Node n33 = new Node();
        n33.setText("“Why does the moth side with the humans? That seems counter intuitive.”, Cthulhu commented.");
        n33.setNext(n34);
        n34.setPrevious(n33);

        Node n32 = new Node();
        n32.setText("The movie was quite boring. Cthulhu had no interest in anything related to the humans, and the two monsters didn’t seem very realistic.");
        n32.setNext(n33);
        n33.setPrevious(n32);

        Node n31 = new Node();
        n31.setText("“We’ll see.”, he said groaning.");
        n31.setNext(n32);
        n32.setPrevious(n31);

        Node n30 = new Node();
        n30.setText("“It is! I promise it gets better.” She grabbed Cthulhu’s arm.");
        n30.setNext(n31);
        n31.setPrevious(n30);

        Node n29 = new Node();
        n29.setText("“I thought this was about Godzilla”, he told Shub, who was now sitting beside him.");
        n29.setNext(n30);
        n30.setPrevious(n29);

        Node fUp9 = new Node();
        fUp9.setText("Soon, the words “Mothra vs. Godzilla” appeared, and the movie started. Immediately, humans showed up on screen and Cthulhu lost all interest.");
        fUp9.setNext(n29);
        n29.setPrevious(fUp9);

        Node n28 = new Node();
        n28.setText("The projector produced a beam of light directed at the wall. The light was so powerful it immediately incinerated any buildings or vegetation that were still attached to the surface.");
        n28.setNext(fUp9);
        fUp9.setPrevious(n28);

        Node n27 = new Node();
        n27.setText("Shub gave him a playful smile. “Oh, is that so?”, she giggled again. “Well then, what if we watch this one?”");
        n27.setNext(n28);

        Node n26 = new Node();
        n26.setText("“What? Not a fan? Well too bad.”, somehow, she made a mocking face. “My projector, my movie. Here, let’s watch this one. I bet you'll like it.”");
        n26.setNext(n28);

        Node fUp8 = new Node();
        fUp8.setText("She kept going for a while after that. Eventually, she interrupted herself. “Oh, sorry! Sometimes I get too excited to talk about these movies! Let’s just watch this one.”");
        fUp8.setNext(n28);

        Node n25 = new Node();
        n25.setText("Shub’s eyes widened. “Oh, that’s a great question! I think it's between Son of Godzilla and Mothra vs. Godzilla, right? Mothra and Godzilla definitely have a lot of chemistry together, although some could argue…”");
        n25.setNext(n28);
        fUp8.setPrevious(n25);

        Node n24 = new Node();
        n24.setText("“Pick whichever you prefer. I don’t plan on looking at the screen for too long.”");
        n24.setRating("real good");
        n24.setStat("2Choice2Option3");
        n24.setNext(n27);
        n27.setPrevious(n24);

        Node n23 = new Node();
        n23.setText("“Ok, but what if we watched literally anything else?”");
        n23.setRating("bad");
        n23.setStat("2Choice2Option2");
        n23.setNext(n26);
        n26.setPrevious(n23);

        Node n22 = new Node();
        n22.setText("“I don’t know. Which one of these do you think is the most romantic?”");
        n22.setRating("good");
        n22.setStat("2Choice2Option1");
        n22.setNext(n25);
        n25.setPrevious(n22);

        Node n21 = new Node();
        n21.setText("The mass of tentacles produced a giggle. “Make your decision.”");
        n21.setOption1(n22);
        n21.setOption2(n23);
        n21.setOption3(n24);

        Node n20 = new Node();
        n20.setText("Cthulhu’s eyes widened. “Did you make some of these up?”");
        n20.setNext(n21);
        n21.setPrevious(n20);

        Node fUp7 = new Node();
        fUp7.setText("‘Godzilla: Tokyo S.O.S’, ‘Godzilla: Final Wars’, and ‘Shin Godzilla’.”");
        fUp7.setNext(n20);
        n20.setPrevious(fUp7);

        Node fUp6 = new Node();
        fUp6.setText("‘Godzilla vs. Biollante’, ‘Godzilla vs. King Ghidorah’, ‘Godzilla vs Mechagodzilla 2’, ‘Godzilla vs. SpaceGodzilla’, ‘Godzilla vs. Destroyah’, ‘Godzilla 2000’, ‘Godzilla vs. Megaguirus’");
        fUp6.setNext(fUp7);
        fUp7.setPrevious(fUp6);

        Node fUp5 = new Node();
        fUp5.setText("‘Son of Godzilla’, ‘Godzilla vs. Hedorah’, ‘Godzilla vs. Gigan’, ‘Godzilla vs. Megalon’, ‘Godzilla vs. Mechagodzilla’, ‘Terror of Mechagodzilla’, ‘The Return of Godzilla’");
        fUp5.setNext(fUp6);
        fUp6.setPrevious(fUp5);

        Node n19 = new Node();
        n19.setText("“Believe or not, we have options” Shub said playfully. “I have OG ‘Godzilla’, ‘Godzilla Raids Again’, ‘King Kong vs. Godzilla, ‘Mothra vs. Godzilla’, ‘Invasion of Astro-Monster’");
        n19.setNext(fUp5);
        fUp5.setPrevious(n19);

        Node n18 = new Node();
        n18.setText("“What are we watching?”, Cthulhu inquired.");
        n18.setNext(n19);
        n19.setPrevious(n18);

        Node n17 = new Node();
        n17.setText("Under his breath, Cthulhu muttered something, sad about his ARTICLE OF CLOTHING. He sat down on the ground slightly behind the projector, while Shub-Niggurath fiddled with it.");
        n17.setNext(n18);
        n18.setPrevious(n17);

        Node n16 = new Node();
        n16.setText("“But you know what, this is fine too.”, he said, quickly correcting himself.");
        n16.setNext(n17);
        n17.setPrevious(n16);

        Node n15 = new Node();
        n15.setText("Shub-Niggurath glanced at him sideways while she set up the projector on the ground.");
        n15.setNext(n16);
        n16.setPrevious(n15);

        Node n14 = new Node();
        n14.setText("“You know, I thought we were going to watch a movie in an actual movie theater…”, Cthulhu said, smirking through his tentacles.");
        n14.setNext(n15);
        n15.setPrevious(n14);

        Node n13 = new Node();
        n13.setText("Punching down, Cthulhu sank his hand into a nearby city block.With one movement, he raised a gigantic, flat wall of earth.Pieces of city rained down from the newly altered terrain.");
        n13.setNext(n14);
        n14.setPrevious(n13);

        Node n12 = new Node();
        n12.setText("“Can you go lift a wall for us real quick?”, she said with a smile.");
        n12.setNext(n13);
        n13.setPrevious(n12);

        Node n11 = new Node();
        n11.setText("Out of her tentacles emerged a golden, fleshy projector, about the size of the Colosseum.");
        n11.setNext(n12);
        n12.setPrevious(n11);

        Node n10 = new Node();
        n10.setText("“Oh stop being such a baby.” Shub said with a mocking tone. She began wriggling her tentacles around, searching for something within. “With what I got, we don’t need this stupid human theater.”");
        n10.setNext(n11);

        Node n9 = new Node();
        n9.setText("“Oh, there was a city here?” She looked around. “Don’t worry about it, cutie.” Somehow, she managed to wink with her tentacles. “I got something for us.”");
        n9.setNext(n11);

        Node n8 = new Node();
        n8.setText("Massive tentacles moved up to her - ehm - other tentacles as she giggled. “Oh Cthulhu, you really know how to make a girl blush.” She began wriggling her body, looking for something hidden within. “Here, I got something for us.”");
        n8.setNext(n11);

        Node n7 = new Node();
        n7.setText("“Damnit, Shub. You’re not only late, but you managed to destroy the movie theater I got reservations for!”");
        n7.setRating("bad");
        n7.setStat("2Choice1Option3");
        n7.setNext(n10);
        n10.setPrevious(n7);

        Node n6 = new Node();
        n6.setText("“You sure know how to make an entrance. We really didn’t have to destroy this city.”");
        n6.setRating("good");
        n6.setStat("2Choice1Option2");
        n6.setNext(n9);
        n9.setPrevious(n6);

        Node n5 = new Node();
        n5.setText("“I would have waited a thousand years more if that’s what it took for a glimpse of you.”");
        n5.setRating("real good");
        n5.setStat("2Choice1Option1");
        n5.setNext(n8);
        n8.setPrevious(n5);

        Node n4 = new Node();
        n4.setText("The mass of tentacles sank from the sky slowly. After a few seconds, Shub was in front of him. “Sorry I’m late!” she said, smiling. The entire district around them had been flattened.");
        n4.setOption1(n5);
        n4.setOption2(n6);
        n4.setOption3(n7);

        Node fUp4 = new Node();
        fUp4.setText("With a sigh, Cthulhu began growing back to his original size. His outfit exploded. The ground around him did the same. Soon, he towered above the entire city, his mere presence knocking down entire buildings.");
        fUp4.setNext(n4);
        n4.setPrevious(fUp4);

        Node n3 = new Node();
        n3.setText("From the sky, a massive blob of tentacles penetrated the atmosphere, becoming engulfed in a ball of fire. Earthquakes shattered the asphalt around him, while people’s skin melted off their faces around him.");
        n3.setNext(fUp4);
        fUp4.setPrevious(n3);

        Node fUp3 = new Node();
        fUp3.setText("DESCRIBE OUTFIT. He was perfectly disguised. It couldn’t be him. Upon closer inspection of the crowd, he saw a few were looking up.");
        fUp3.setNext(n3);
        n3.setPrevious(fUp3);

        Node fUp2 = new Node();
        fUp2.setText("Humans losing their minds upon witnessing something incomprehensibly frightening. Cthulhu quickly checked his outfit to see if he was the cause of this. His outfit was impeccable.");
        fUp2.setNext(fUp3);
        fUp3.setPrevious(fUp2);

        Node n2 = new Node();
        n2.setText("A ‘very hard’ game of minesweeper on his phone was interrupted by screams. Cthulhu looked around to see what the cause of the commotion was. He was surrounded by a scene he had seen many times.");
        n2.setNext(fUp2);
        fUp2.setPrevious(n2);

        Node fUp1 = new Node();
        fUp1.setText("“I can’t really expect anything else from her”, he thought, quickly hiding his monstrous features back in his outfit. He sat on a nearby bench to wait.");
        fUp1.setNext(n2);
        n2.setPrevious(fUp1);

        Node n1 = new Node();
        n1.setText("Cthulhu looked down at his phone. “8:00 pm at the Honeyview Movie Theater xoxoxo”. It was 8:15. His tentacles flailed out from underneath his CLOTHES as he sighed in exasperation.");
        n1.setNext(fUp1);
        fUp1.setPrevious(n1);

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
        n7.setRating("good");
        n7.setNext(n8);
        Node n6 = new Node();
        n6.setText("No Pick me!");
        n6.setRating("good");
        n6.setNext(n8);
        Node n5 = new Node();
        n5.setText("Pick me!");
        n5.setRating("good");
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

        // Update affection bar itself
        GameObject.Find("AffectionBar").GetComponent<Image>().fillAmount = affectionBar;
        GameObject.Find("AffectionBarValue").GetComponent<Text>().text = (int)(affectionBar * 100) + "%";
        // Update affection playerpref
        if (affectionBarName != "onboarding") PlayerPrefs.SetFloat(affectionBarName, affectionBar);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}

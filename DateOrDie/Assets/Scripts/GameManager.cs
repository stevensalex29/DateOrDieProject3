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
    public void incrementAffectionBar()
    {
        affectionBar += 0.05f;
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
    }

    // Create day 1 part 1 tree
    public void createPart1Tree()
    {
        Node n8 = new Node();
        n8.setText("Another end");
        Node n7 = new Node();
        n7.setText("More story");
        n7.setNext(n8);
        n8.setPrevious(n7);
        // end node (no next or options, previous depends on if last nodes were options or not)
        Node n6 = new Node();
        n6.setText("done");
        // option nodes (next is done node, no options or previous)
        Node n5 = new Node();
        n5.setText("Opt3");
        n5.setRating("good");
        n5.setNext(n7);
        Node n4 = new Node();
        n4.setText("Opt2");
        n4.setNext(n6);
        Node n3 = new Node();
        n3.setText("Opt1");
        n3.setNext(n6);
        // node with options (no next, option nodes, previous node)
        Node n2 = new Node();
        n2.setText("Choose an option");
        n2.setOption1(n3);
        n2.setOption2(n4);
        n2.setOption3(n5);
        // node without options (next, possible previous, no options)
        Node n1 = new Node();
        n1.setText("Start here");
        n1.setNext(n2);
        n2.setPrevious(n1);

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

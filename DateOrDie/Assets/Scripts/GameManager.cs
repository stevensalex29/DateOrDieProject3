using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Attributes
    private Node currentNode;
    private float affectionBar;
    public GameObject nextButton;
    public GameObject previousButton;
    public GameObject option1Button;
    public GameObject option2Button;
    public GameObject option3Button;
    public GameObject endButton;

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
        Node n8 = gameObject.AddComponent<Node>();
        n8.setText("Another end");
        Node n7 = gameObject.AddComponent<Node>();
        n7.setText("More story");
        n7.setNext(n8);
        n8.setPrevious(n7);
        // end node (no next or options, previous depends on if last nodes were options or not)
        Node n6 = gameObject.AddComponent<Node>();
        n6.setText("done");
        // option nodes (next is done node, no options or previous)
        Node n5 = gameObject.AddComponent<Node>();
        n5.setText("Opt3");
        n5.setRating("good");
        n5.setNext(n7);
        Node n4 = gameObject.AddComponent<Node>();
        n4.setText("Opt2");
        n4.setNext(n6);
        Node n3 = gameObject.AddComponent<Node>();
        n3.setText("Opt1");
        n3.setNext(n6);
        // node with options (no next, option nodes, previous node)
        Node n2 = gameObject.AddComponent<Node>();
        n2.setText("Choose an option");
        n2.setOption1(n3);
        n2.setOption2(n4);
        n2.setOption3(n5);
        // node without options (next, possible previous, no options)
        Node n1 = gameObject.AddComponent<Node>();
        n1.setText("Start Here");
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
            endButton.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        displayCurrentNode();
    }
}

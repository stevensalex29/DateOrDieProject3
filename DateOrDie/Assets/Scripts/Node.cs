using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Node : MonoBehaviour
{
    //Attributes
    string currentText;
    string choiceRating;
    Node previous;
    Node next;
    Node option1;
    Node option2;
    Node option3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Getters and Setters
    public Node getOption1()
    {
        return option1;
    }
    public void setOption1(Node n)
    {
        option1 = n;
    }
    public Node getOption2()
    {
        return option2;
    }
    public void setOption2(Node n)
    {
        option2 = n;
    }
    public Node getOption3()
    {
        return option3;
    }
    public void setOption3(Node n)
    {
        option3 = n;
    }
    public Node getNext()
    {
        return next;
    }
    public void setNext(Node n)
    {
        next = n;
    }
    public Node getPrevious()
    {
        return previous;
    }
    public void setPrevious(Node n)
    {
        previous = n;
    }
    public string getText()
    {
        return currentText;
    }
    public void setText(string t)
    {
        currentText = t;
    }
    public string getRating()
    {
        return choiceRating;
    }
    public void setRating(string r)
    {
        choiceRating = r;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

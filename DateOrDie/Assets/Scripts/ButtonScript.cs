﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public AudioClip s_Good;
    public AudioClip s_Bad;
    // Choose option1
    public void Option1()
    {
        Node current = GameObject.Find("GameManager").GetComponent<GameManager>().getCurrentNode();
        // Update stats based on option
        PlayerPrefs.SetInt(current.getOption1().getStat(), 1);
        // play sound effect if there is one
        if (current.getOption1().getSoundEffect() != null) GameObject.Find("GameManager").GetComponent<AudioSource>().PlayOneShot(current.getOption1().getSoundEffect());
        // Increment or decrement affection bar (will be changed probably)
        if (current.getOption1().getRating() == "good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.2f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else if (current.getOption1().getRating() == "real good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.33f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().decrementAffectionBar();
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Bad, 1.0f);
        }
        // Update new current node and no longer show options
        GameObject.Find("GameManager").GetComponent<GameManager>().setCurrentNode(current.getOption1().getNext());
        GameObject.Find("GameManager").GetComponent<GameManager>().disableOptionButtons();
    }

    // Choose option2
    public void Option2()
    {
        Node current = GameObject.Find("GameManager").GetComponent<GameManager>().getCurrentNode();
        // Update stats based on option
        PlayerPrefs.SetInt(current.getOption2().getStat(), 1);
        // play sound effect if there is one
        if (current.getOption2().getSoundEffect() != null) GameObject.Find("GameManager").GetComponent<AudioSource>().PlayOneShot(current.getOption2().getSoundEffect());
        // Increment or decrement affection bar (will be changed probably)
        if (current.getOption2().getRating() == "good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.2f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else if (current.getOption2().getRating() == "real good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.33f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().decrementAffectionBar();
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Bad, 1.0f);
        }
        // Update new current node and no longer show options
        GameObject.Find("GameManager").GetComponent<GameManager>().setCurrentNode(current.getOption2().getNext());
        GameObject.Find("GameManager").GetComponent<GameManager>().disableOptionButtons();
    }

    // Choose option3
    public void Option3()
    {
        Node current = GameObject.Find("GameManager").GetComponent<GameManager>().getCurrentNode();
        // Update stats based on option
        PlayerPrefs.SetInt(current.getOption3().getStat(), 1);
        // play sound effect if there is one
        if (current.getOption3().getSoundEffect() != null) GameObject.Find("GameManager").GetComponent<AudioSource>().PlayOneShot(current.getOption3().getSoundEffect());
        // Increment or decrement affection bar (will be changed probably)
        if (current.getOption3().getRating() == "good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.2f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else if (current.getOption3().getRating() == "real good")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().incrementAffectionBar(.33f);
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Good, 1.0f);
        }
        else
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().decrementAffectionBar();
            GameObject.Find("GameSound").GetComponent<AudioSource>().PlayOneShot(s_Bad, 1.0f);
        }
        // Update new current node and no longer show options
        GameObject.Find("GameManager").GetComponent<GameManager>().setCurrentNode(current.getOption3().getNext());
        GameObject.Find("GameManager").GetComponent<GameManager>().disableOptionButtons();
    }

    // Get next text dialog
    public void Next()
    {
        Node current = GameObject.Find("GameManager").GetComponent<GameManager>().getCurrentNode();
        GameObject.Find("GameManager").GetComponent<GameManager>().setCurrentNode(current.getNext());
    }

    // Get previous text dialog
    public void Previous()
    {
        Node current = GameObject.Find("GameManager").GetComponent<GameManager>().getCurrentNode();
        GameObject.Find("GameManager").GetComponent<GameManager>().setCurrentNode(current.getPrevious());
        GameObject.Find("GameManager").GetComponent<GameManager>().disableOptionButtons();
        GameObject.Find("GameManager").GetComponent<GameManager>().disableEndButton();
    }

    // End date
    public void EndDate()
    {
        SceneManager.LoadScene("StatScreen");
    }

    // Start game
    public void StartGame()
    {
        SceneManager.LoadScene("Day1Part1");
    }

    // Begin Onboarding
    public void Onboarding()
    {
        SceneManager.LoadScene("Onboarding");
    }

    // Begin game
    public void Intro()
    {
        SceneManager.LoadScene("IntroCutScene");
    }

    // Go to date 1
    public void Date1()
    {
        SceneManager.LoadScene("Day1Part1");
    }

    // Go to date 2
    public void Date2()
    {
        SceneManager.LoadScene("Day1Part2");
    }

    // Go to date 3
    public void Date3()
    {
        SceneManager.LoadScene("Day1Part3");
    }

    // Choose date screen
    public void ChooseDate()
    {
        SceneManager.LoadScene("ChooseDate");
    }

    // Quit game
    public void Quit()
    {
        Application.Quit();
    }

    // Credits
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    // Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

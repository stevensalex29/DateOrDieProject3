using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticManager : MonoBehaviour
{
    // Attributes
    public List<GameObject> choices;
    public GameObject affectionBar1;
    public GameObject affectionBar2;
    public GameObject affectionBar3;

    // Start is called before the first frame update
    void Start()
    {
        setAffectionBars();
        setStats();
    }

    // Set the affection bar values for each monster
    public void setAffectionBars()
    {
        float affection1 = PlayerPrefs.GetFloat("affection1");
        float affection2 = PlayerPrefs.GetFloat("affection2");
        float affection3 = PlayerPrefs.GetFloat("affection3");
        affectionBar1.GetComponent<Image>().fillAmount = affection1;
        GameObject.Find("AffectionBar1Text").GetComponent<Text>().text = (int)(affection1 * 100) + "%";
        affectionBar2.GetComponent<Image>().fillAmount = affection2;
        GameObject.Find("AffectionBar2Text").GetComponent<Text>().text = (int)(affection2 * 100) + "%";
        affectionBar3.GetComponent<Image>().fillAmount = affection3;
        GameObject.Find("AffectionBar3Text").GetComponent<Text>().text = (int)(affection3 * 100) + "%";
    }

    // Set stats for each date
    public void setStats()
    {
        for(int i = 0; i < choices.Count; i++)
        {
            if (PlayerPrefs.GetInt(choices[i].name) == 1) choices[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.DeleteAll();
    }
}

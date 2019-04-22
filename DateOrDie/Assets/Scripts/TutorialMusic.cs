using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMusic : MonoBehaviour
{
    // Awake is called first
    private void Awake()
    {
        GameObject pastMusic = GameObject.FindGameObjectWithTag("music");
        Destroy(pastMusic);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

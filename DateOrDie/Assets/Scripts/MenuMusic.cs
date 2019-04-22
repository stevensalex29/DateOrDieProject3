using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    // Awake is called first
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        GameObject dateMusic = GameObject.FindGameObjectWithTag("dateMusic");
        if (dateMusic != null) Destroy(dateMusic);
        GameObject dateScreenMusic = GameObject.FindGameObjectWithTag("dateScreenMusic");
        if (dateScreenMusic != null) Destroy(dateScreenMusic);
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class model : MonoBehaviour
{
    public GameObject[] cube;
    public GameObject[] models;
    public GameObject[] ui;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cube[0].GetComponent<MeshRenderer>().enabled == true)
        {
            models[0].SetActive(true);
            ui[0].SetActive(true);
        }
        else if (cube[0].GetComponent<MeshRenderer>().enabled == false)
        {
            models[0].SetActive(false);
            ui[0].SetActive(false);
        }

        if (cube[1].GetComponent<MeshRenderer>().enabled == true)
        {
            models[1].SetActive(true);
            ui[1].SetActive(true);
        }
        else if (cube[1].GetComponent<MeshRenderer>().enabled == false)
        {
            models[1].SetActive(false);
            ui[1].SetActive(false);
        }

        if (cube[2].GetComponent<MeshRenderer>().enabled == true)
        {
            models[2].SetActive(true);
            ui[2].SetActive(true);
        }
        else if (cube[2].GetComponent<MeshRenderer>().enabled == false)
        {
            models[2].SetActive(false);
            ui[2].SetActive(false);
        }

        if (cube[3].GetComponent<MeshRenderer>().enabled == true)
        {
            models[3].SetActive(true);
            ui[3].SetActive(true);
        }
        else if (cube[3].GetComponent<MeshRenderer>().enabled == false)
        {
            models[3].SetActive(false);
            ui[3].SetActive(false);
        }
    }
}

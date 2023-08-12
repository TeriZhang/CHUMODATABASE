using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSignInSlot : MonoBehaviour
{
    // Start is called before the first frame update
    public string currentSignIcon;
    public List<GameObject> allSignPrefabs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSign(string name)
    {
        if(name == "None")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[0].SetActive(true);
        }
        if (name == "GigglingG")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[1].SetActive(true);
        }
        if (name == "HowlingS")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[2].SetActive(true);
        }
        if (name == "ShiftingA")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[3].SetActive(true);
        }
        if (name == "LightningT")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[4].SetActive(true);
        }
        if (name == "CrackingW")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[5].SetActive(true);
        }
        if (name == "DrippinB")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[6].SetActive(true);
        }
        if (name == "FlickeringC")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[7].SetActive(true);
        }
        if (name == "RingingB")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[8].SetActive(true);
        }
        if (name == "FlashingP")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[9].SetActive(true);
        }
        if (name == "WhirlingF")
        {
            for (int i = 0; i < 11; i++)
            {
                allSignPrefabs[i].SetActive(false);
            }
            allSignPrefabs[10].SetActive(true);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SearchDaddy : MonoBehaviour
{
    //Four Sign Slots
    public int currentSlot;
    public GameObject slotButtons;
    public List<string> slots;
    public List<GameObject> slotObj;
    public GameObject selectSignUI;
    public bool nN, gG, hS, sA, lT, cW, dB, fC, rB, fP, wF;
    public List<GameObject> curses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //All Button Commands on Opening Sign selection for each Slot
    public void Slot_1()
    {
        currentSlot = 0;
        selectSignUI.SetActive(true);
        slotButtons.SetActive(false);
    }
    public void Slot_2()
    {
        currentSlot = 1;
        selectSignUI.SetActive(true);
        slotButtons.SetActive(false);
    }

    public void Slot_3()
    {
        currentSlot = 2;
        selectSignUI.SetActive(true);
        slotButtons.SetActive(false);
    }

    public void Slot_4()
    {
        currentSlot = 3;
        selectSignUI.SetActive(true);
        slotButtons.SetActive(false);
    }

    public void returnToSelect()
    {
        slotButtons.SetActive(true);
        selectSignUI.SetActive(false);
    }

    //Selecting Sign for certain Slot
    public void SetSign(string signName)
    {
        slots[currentSlot] = signName;
        slotObj[currentSlot].GetComponent<CurrentSignInSlot>().ChangeSign(signName);
        slotButtons.SetActive(true);
        selectSignUI.SetActive(false);
    }

    public void CheckSign()
    {
        //Turning everything off
        nN = false;
        gG = false;
        hS = false;
        sA = false;
        lT = false; 
        cW = false; 
        dB = false;
        fC = false;
        rB = false;
        fP = false;
        wF = false;

        //start everything
        for (int i = 0; i < 4; i++)
        {
            if (slots[i] == "None")
            {
                nN = true;
                
            }
            if (slots[i] == "GigglingG")
            {
                gG = true;
               
            }
            if (slots[i] == "HowlingS")
            {
                hS = true;
                
            }
            if (slots[i] == "ShiftingA")
            {
                sA = true;
                
            }
            if (slots[i] == "LightningT")
            {
                lT = true;
                
            }
            if (slots[i] == "CrackingW")
            {
                cW = true;
                
            }
            if (slots[i] == "DrippinB")
            {
                dB = true;
                
            }
            if (slots[i] == "FlickeringC")
            {
                fC = true;
                
            }
            if (slots[i] == "RingingB")
            {
                rB = true;
                
            }
            if (slots[i] == "FlashingP")
            {
                fP = true;
                
            }
            if (slots[i] == "WhirlingF")
            {
                wF = true;
                
            }
            if (string.IsNullOrEmpty(slots[i]))
            {
                Debug.Log("123321");
                nN = true;

            }
            else
            {
                //nN = true;
            }
        }
        if(fC == true && hS == true && cW == true && nN == true)
        {
            Debug.Log("Curse e1");
            for (int i = 0; i < 7; i++)
            {
                curses[i].SetActive(false);
            }
            curses[0].SetActive(true);
            curses[0].GetComponent<CurseController>().reloadPage();
            curses[0].GetComponent<CurseController>().ViewSolution();
            this.gameObject.SetActive(false);
            return;
        }

        //if (gG == true && rB == true && cW == true && nN == true)
        //{
        //    Debug.Log("Curse e2");
        //    for (int i = 0; i < 7; i++)
        //    {
        //        curses[i].SetActive(false);
        //    }
        //    curses[1].SetActive(true);
        //    curses[1].GetComponent<CurseController>().reloadPage();
        //    curses[1].GetComponent<CurseController>().ViewSolution();
        //    this.gameObject.SetActive(false);
        //    return;
        //}

        if (wF == true && lT == true && sA == true && nN == true)
        {
            Debug.Log("Curse e3");
            for (int i = 0; i < 7; i++)
            {
                curses[i].SetActive(false);
            }
            curses[2].SetActive(true);
            curses[2].GetComponent<CurseController>().reloadPage();
            curses[2].GetComponent<CurseController>().ViewSolution();
            this.gameObject.SetActive(false);
            return;
        }

        //if(gG == true && sA == true && rB == true && fP == true)
        //{
        //    Debug.Log("Curse m1");
        //    Debug.Log("Curse e3");
        //    for (int i = 0; i < 7; i++)
        //    {
        //        curses[i].SetActive(false);
        //    }
        //    curses[3].SetActive(true);
        //    curses[3].GetComponent<CurseController>().reloadPage();
        //    curses[3].GetComponent<CurseController>().ViewSolution();
        //    this.gameObject.SetActive(false);
        //    return;
        //}

        if(gG == true && dB == true && rB == true && fC == true)
        {
            Debug.Log("Curse m2");
            for (int i = 0; i < 7; i++)
            {
                curses[i].SetActive(false);
            }
            curses[4].SetActive(true);
            curses[4].GetComponent<CurseController>().reloadPage();
            curses[4].GetComponent<CurseController>().ViewSolution();
            this.gameObject.SetActive(false);
            return;
        }

        //if(wF == true && dB == true && fC == true && lT == true)
        //{
        //    Debug.Log("Curse h1");
        //    for (int i = 0; i < 7; i++)
        //    {
        //        curses[i].SetActive(false);
        //    }
        //    curses[5].SetActive(true);
        //    curses[5].GetComponent<CurseController>().reloadPage();
        //    curses[5].GetComponent<CurseController>().ViewSolution();
        //    this.gameObject.SetActive(false);
        //    return;
        //}

        else
        {
            Debug.Log("404");
            for (int i = 0; i < 7; i++)
            {
                curses[i].SetActive(false);
            }
            curses[6].SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    public void clear()
    {
        SceneManager.LoadScene(0);
    }
}

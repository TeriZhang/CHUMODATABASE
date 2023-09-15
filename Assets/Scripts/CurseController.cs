using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CurseController : MonoBehaviour
{
    public GameObject solutionHome;
    public GameObject solutionPage;
    public GameObject mainPage,drumPage,taliPage,relicPage;
    public bool is404;

    public GameObject solutionButton;
    public float solutionTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        solutionTimer = 0;
        solutionButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        solutionTimer += Time.deltaTime;
        if(solutionTimer >= 2)
        {
            solutionButton.SetActive(true);
        }
    }

    public void returnToMain()
    {
        SceneManager.LoadScene(0);
        mainPage.SetActive(true);
        this.gameObject.SetActive(false);
    }

    public void ViewSolution()
    {
        if (is404)
        {
            
        }
        else
        {
            solutionHome.SetActive(false);
            solutionPage.SetActive(true);
        }
    }

    public void returntoActi()
    {
        solutionHome.SetActive(true);
        solutionPage.SetActive(false);
    }

    public void ViewDrum()
    {
        taliPage.SetActive(false);
        relicPage.SetActive(false);
        drumPage.SetActive(true);
    }

    public void ViewTalis()
    {
        taliPage.SetActive(true);
        relicPage.SetActive(false);
        drumPage.SetActive(false);
    }

    public void ViewRelic()
    {
        taliPage.SetActive(false);
        relicPage.SetActive(true);
        drumPage.SetActive(false);
    }

    public void reloadPage()
    {
        solutionHome.SetActive(true);
        solutionPage.SetActive(false);
    }
}

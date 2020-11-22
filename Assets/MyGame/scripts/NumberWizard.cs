using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour                  
{

    public TextMeshProUGUI TextGuess;
    public GameObject ButtonOne;
    public GameObject ButtonTwo;
    public GameObject ButtonThree;
    public GameObject ButtonNew;




    int min = 1;
    int max = 200;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    // Update is called once per frame
   


    private void NextGuess()
    {
        guess = (min + max) / 2;
        TextGuess.text = guess.ToString();
        
    }

    public void LowerNumber()
    {
        max = guess - 1;
        NextGuess();
    }
    public void Equal()
    {
        ButtonOne.SetActive(false);
        ButtonTwo.SetActive(false);
        ButtonThree.SetActive(false);
        ButtonNew.SetActive(true);
    }

    public void HigherNumber()
    {
        min = guess + 1;
        NextGuess();
    }

    public void Restart()
    {
        min = 1;
        max = 200;
        NextGuess();
        ButtonOne.SetActive(true);
        ButtonTwo.SetActive(true);
        ButtonThree.SetActive(true);
        ButtonNew.SetActive(false);
    }

}

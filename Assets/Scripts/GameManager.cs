using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UnityEngine.UI.Text moneyValue;
    public UnityEngine.UI.RawImage FinalSlide;
    public UnityEngine.UI.Text WonText;
    public UnityEngine.UI.Text LoseText;
    public UnityEngine.UI.Button ReloadButton;

    public float moneyValueNumber;

    private Country[] AllCountries;
    private int countriesNumber;
    private bool won = false;
    private bool lose = false;

    void Start()
    {
        moneyValue.text = "0";
        AllCountries = FindObjectsOfType<Country>();
        countriesNumber = AllCountries.Length;
        FinalSlide.gameObject.SetActive(false);
        WonText.gameObject.SetActive(false);
        LoseText.gameObject.SetActive(false);
        ReloadButton.gameObject.SetActive(false);
    }

    void Update()
    {
        moneyValue.text = Mathf.Round(moneyValueNumber).ToString();
        if(!won && !lose)
        {
            CheckWin();
            CheckLose();
        }      
    }

    void CheckWin()
    {
        int successCountries = 0;
        foreach(Country country in AllCountries)
        {
            if (country.citizenInCountry)
                successCountries++;
        }
        if(successCountries == countriesNumber)
        {
            won = true;
            FinalSlide.gameObject.SetActive(true);
            WonText.gameObject.SetActive(true);
            ReloadButton.gameObject.SetActive(true);
        }
    }

    void CheckLose()
    {
        int bordersBuilt = 0;
        foreach(Country country in AllCountries)
        {
            if (country.border.percentageValue == 100.0f)
                bordersBuilt++;
        }
        if(bordersBuilt == 8)
        {
            lose = true;
            FinalSlide.gameObject.SetActive(true);
            LoseText.gameObject.SetActive(true);
            ReloadButton.gameObject.SetActive(true);
        }
    }
}
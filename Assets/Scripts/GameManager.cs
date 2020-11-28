using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UnityEngine.UI.Text moneyValue;

    public float moneyValueNumber;

    private string currency = " szekle";

    private Country[] AllCountries;
    private int countriesNumber;
    private bool won;

    void Start()
    {
        moneyValue.text = "0 szekli";
        AllCountries = FindObjectsOfType<Country>();
        countriesNumber = AllCountries.Length;
    }

    void Update()
    {
        moneyValue.text = Mathf.Round(moneyValueNumber) + currency;
        CheckWin();
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
        }
    }

    void CheckLose()
    {

    }
}
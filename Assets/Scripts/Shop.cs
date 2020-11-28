using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject traderPrefab;
    public GameObject negotiatorPrefab;
    public GameObject citizenPrefab;

    public float traderPrice = 100;
    public float negotiatorPrice = 300;
    public float citizenPrice = 150;

    private GameManager gm;
    private BordersController bc;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        bc = FindObjectOfType<BordersController>();
    }

    public void BuyTrader()
    {
        //if(gm.f_moneyValue >= traderPrice)
        //{
        //    gm.f_moneyValue -= traderPrice;
        //    Instantiate(traderPrefab, bc.allBorders[0].transform.position, Quaternion.identity);
        //}
    }
}

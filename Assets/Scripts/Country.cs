using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Country : MonoBehaviour
{
    public Border border;
    
    //Wartość na sekundę
    private int money = 10;

    private SpriteRenderer countryRender;

    private bool traderInCountry = false;
    private bool negotiatorInCountry = false;
    public bool citizenInCountry = false;

    private GameManager gm;
    private Shop shop;

    private IEnumerator coroutine;
    private GameObject negotiator;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        shop = FindObjectOfType<Shop>();
    }

    void Update()
    {
        gm.moneyValueNumber += Time.deltaTime * money * (100.0f - border.percentageValue) / 100;
    }

    public void BuyTrader()
    {
        if (gm.moneyValueNumber >= shop.traderPrice && !traderInCountry)
        {
            gm.moneyValueNumber -= shop.traderPrice;
            Instantiate(shop.traderPrefab, border.transform.position + new Vector3(0.2f, 0.0f), Quaternion.identity);
            traderInCountry = true;
            money *= 3;
        }
    }

    public void BuyNegotiator()
    {
        if(gm.moneyValueNumber >= shop.negotiatorPrice && !negotiatorInCountry && border.percentageValue == 100)
        {
            gm.moneyValueNumber -= shop.negotiatorPrice;
            negotiator = Instantiate(shop.negotiatorPrefab, border.transform.position + new Vector3(-0.2f, 0.0f), Quaternion.identity);
            negotiatorInCountry = true;
            float time = Random.Range(2.0f, 6.0f);
            StartCoroutine(RepairBorder(time));
        }
    }

    public void BuyCitizen()
    {
        if (gm.moneyValueNumber >= shop.citizenPrice && !citizenInCountry && border.percentageValue != 100 && traderInCountry)
        {
            gm.moneyValueNumber -= shop.citizenPrice;
            Instantiate(shop.citizenPrefab, border.transform.position, Quaternion.identity);
            citizenInCountry = true;
        }
    }

    IEnumerator RepairBorder(float time)
    {
        yield return new WaitForSeconds(time);
        int success = Random.Range(0, 5);
        if(success == 1 || success == 2 || success == 3)
        {
            border.percentageValue = 0;
            border.RefreshBorder();
            Destroy(negotiator.gameObject);
            negotiatorInCountry = false;
        }
        else
        {
            Destroy(negotiator.gameObject);
            negotiatorInCountry = false;
        }
    }
}

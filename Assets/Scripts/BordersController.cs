using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersController : MonoBehaviour
{
    public List<Border> allBorders;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2.0f)
        {
            RandomBordering();
            timer = 0;
        }
    }

    //Uruchamianie losowo co jakiś czas budowania granicy
    void RandomBordering()
    {
        float time = Random.Range(1.0f, 3.0f);
        StartCoroutine(BuildBorder(time));
    }

    IEnumerator BuildBorder(float time)
    {
        yield return new WaitForSeconds(time);
        int countryNumber = Random.Range(0, allBorders.Capacity);
        allBorders[countryNumber].SetBordering(true);
    }
}

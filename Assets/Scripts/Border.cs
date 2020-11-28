using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public UnityEngine.UI.Text percentage;
    public float percentageValue;

    private SpriteRenderer border;
    private float transparencyAddValue = 0.0f;
    private float transparencyTimeDivider = 10;
    private bool setBorder = false;

    void Start()
    {
        border = this.GetComponent<SpriteRenderer>();
        border.color = new Color(border.color.r, border.color.g, border.color.b, transparencyAddValue);
    }

    void Update()
    {
        //Jeśli transparency nie jest jeszcze równa 1.0f oraz jeśli jest ustawiona zmienna dotycząca powstawania granicy
        if (transparencyAddValue <= 1.0f && setBorder)
            transparencyAddValue += Time.deltaTime / transparencyTimeDivider;
        CalculatePercentageOfBorder(transparencyAddValue);
        border.color = new Color(border.color.r, border.color.g, border.color.b, transparencyAddValue);
    }

    public void SetBordering(bool value)
    {
        setBorder = value;
    }

    public void RefreshBorder()
    {
        transparencyAddValue = 0.0f;
        border.color = new Color(border.color.r, border.color.g, border.color.b, transparencyAddValue);
        CalculatePercentageOfBorder(0);
    }

    void CalculatePercentageOfBorder(float transparencyValue)
    {
        percentageValue = Mathf.Round(transparencyValue * 100);
        string percentageText = percentageValue + "%";
        percentage.text = percentageText;
    }
}

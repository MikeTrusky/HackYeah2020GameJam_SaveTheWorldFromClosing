using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public UnityEngine.UI.Button TraderButton;
    public UnityEngine.UI.Button NegotiatorButton;
    public UnityEngine.UI.Button CitizenButton;
    public SpriteRenderer ButtonsBackground;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowButtons()
    {
        TraderButton.gameObject.SetActive(true);
        NegotiatorButton.gameObject.SetActive(true);
        CitizenButton.gameObject.SetActive(true);
        ButtonsBackground.gameObject.SetActive(true);
    }

    public void UnshowButtons()
    {
        TraderButton.gameObject.SetActive(false);
        NegotiatorButton.gameObject.SetActive(false);
        CitizenButton.gameObject.SetActive(false);
        ButtonsBackground.gameObject.SetActive(false);
    }
}

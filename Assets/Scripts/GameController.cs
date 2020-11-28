using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    ButtonController[] AllButtonsController;

    void Start()
    {
        AllButtonsController = FindObjectsOfType<ButtonController>();    
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                if(hit.collider.gameObject.GetComponent<Border>() && hit.collider.gameObject.GetComponent<Border>().percentageValue < 100.0f)
                {
                    hit.collider.gameObject.GetComponent<Border>().SetBordering(false);
                    hit.collider.gameObject.GetComponent<Border>().RefreshBorder();
                }
            }
            else
            {
                foreach (ButtonController buttonsController in AllButtonsController)
                {
                    buttonsController.UnshowButtons();
                }
            }
        }
    }
}

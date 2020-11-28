using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject traderPrefab;
    public GameObject negotiatorPrefab;
    public GameObject citizenPrefab;

    public float traderPrice = 4000;
    public float negotiatorPrice = 5000;
    public float citizenPrice = 6000;

    private GameManager gm;
    private BordersController bc;

    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        bc = FindObjectOfType<BordersController>();
    }
}

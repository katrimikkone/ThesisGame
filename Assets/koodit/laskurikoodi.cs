using UnityEngine;
using TMPro;
using System;

public class laskurikoodi : MonoBehaviour
{
    public TMP_Text laskuriTeksti;
    private pelaajakoodi pelaaja; //viittaus pelaajakoodiin
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pelaaja = FindFirstObjectByType<pelaajakoodi>();
    }

    // Update is called once per frame
    void Update()
    {
        laskuriTeksti.text = "Kerätyt kookokset: " + pelaaja.kookoslkm + "/5";

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vardaparadisana : MonoBehaviour
{
    void Update()
    {
    }
    public string teksts;
    //Lauks kurā ierakstīs tekstu
    public GameObject ievadesLauks;
    //Kur attēlos tekstu
    public GameObject tekstaAttelosana;
    public void uzglabaTekstu()
    {
        //No komponentes Ievades Lauks1 iegūst pakārtoto Text komponenti un
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks " + teksts.ToUpper() + "!";
    }
}

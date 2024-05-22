using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Object mainigaisAttels;
    public Sprite[] atteluMasivs;
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            //Debug.Log("Milda");
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    }
}

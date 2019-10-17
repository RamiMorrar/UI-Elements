using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyDisplay : MonoBehaviour
{

    public int energy;
    public Text energytext;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        energytext.text = "ENERGY: " + energy;
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            energy--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{   
    [HideInInspector] public string input;

    public void ReadStringInput(string inputString)
    {
        input = inputString;        
    }
}

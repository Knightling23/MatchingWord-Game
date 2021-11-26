using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayLetter : MonoBehaviour
{

    [SerializeField] bool upperCase;
    internal void SetLetter(char letter)
    {
        if (upperCase)
        {
            GetComponent<TMP_Text>().text = letter.ToString().ToUpper();

        }

        else
        {
            GetComponent<TMP_Text>().text = letter.ToString().ToLower();

        }
        
    }


}

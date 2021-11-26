using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//01 
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using System;
using Random = UnityEngine.Random;

public class clickablebutton : MonoBehaviour, IPointerClickHandler
{
    char RandomLetter;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log($"Clicked on letter {RandomLetter}" );
        if (RandomLetter == Controller.Letter)
        {
            GetComponent<TMP_Text>().color =Color.green;
            enabled = false;
            Controller.HandleCorrectLetterClick();
            
        }
    }

    // Start is called before the first frame update
 /*   private void OnEnable()
    {
        int a = Random.Range(0, 26);
        RandomLetter = (char)('a' + a);
        if(Random.Range(0,100)>50)
            GetComponent<TMP_Text>().text = RandomLetter.ToString();
        else
            GetComponent<TMP_Text>().text = RandomLetter.ToString().ToUpper();

    }
    */
    internal void SetLetters(char letter)
    {
        enabled = true;
        GetComponent<TMP_Text>().color = Color.white;
        RandomLetter = letter;
        if (Random.Range(0, 100) > 50)
            GetComponent<TMP_Text>().text = RandomLetter.ToString();
        else
            GetComponent<TMP_Text>().text = RandomLetter.ToString().ToUpper();
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Controller : MonoBehaviour
{
        public static char Letter = 'a';
        static int _CorrectAnswers = 5;
        static int _correctClicks;

        private void OnEnable()
        {
            GenerateBoard();

        }


        private static void GenerateBoard()
        {
            var letters = FindObjectsOfType<clickablebutton>();
            

            List<char> lettersList = new List<char>();

        for (int i = 0; i < _CorrectAnswers; i++)
            {
                
                lettersList.Add(Letter);

            }

        for (int i = _CorrectAnswers; i < letters.Length; i++)
            {
                var chosenLetter = ChooseInvalidRandomLetter();
                lettersList.Add(chosenLetter);

            }


       lettersList = lettersList.OrderBy(t => UnityEngine.Random.Range(0,10000)).ToList();

        for(int i =0; i < letters.Length; i++)
              {
            letters[i].SetLetters(lettersList[i]);

               }

        }

    internal static void HandleCorrectLetterClick()
    {
        _correctClicks++;
        if (_correctClicks >= _CorrectAnswers)
        {
            Letter++;
            DisplayLetters();
            _correctClicks = 0;
            GenerateBoard();
        }

    }
    private static void DisplayLetters()
    {
        foreach (var displayletter in FindObjectsOfType<DisplayLetter>())
        {
            displayletter.SetLetter(Letter);

        }

    }

    private static char ChooseInvalidRandomLetter()
        {
            int a = UnityEngine.Random.Range(0, 26);
            var randomLetter = (char)('a' + a);
            if (randomLetter == Letter)
               return ChooseInvalidRandomLetter();

            return randomLetter;


        }


    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson01
{
    public class Variables : MonoBehaviour
    {
        private int integer = 1;
        private float number = 1.5f;
        private double bigNumber = 10000000;
        private byte smallNumber = 255;
        private sbyte smallNegativeNumber = -128;
        private short shortVariable = short.MaxValue;
        private bool isBool = true;
        private uint biggerNumber = 100_000_000;
        private long mustBiggerNumber = 100_000_000_000_000_000;
        const double PI = 3.14;
        private char letter = 'a';
        private string sentence = "Hello World!";

        private void Start()
        {
            var randomVariable = "Variable";
        }
    }
}
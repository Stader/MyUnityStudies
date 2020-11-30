using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcatenateAndStrings : MonoBehaviour
{
    void Start()
    {
        var integer = 5;
        print("Hello " + integer + " World!");
        System.Console.WriteLine(("I {0} love {1} C#.", integer, integer));
        Debug.Log($"Another way {integer} to concatenate {integer} string");

        Debug.Log("hello".ToUpper().Insert(5, " World!").Replace("World!", "Universe!!!"));

        var str = "New string";

        Debug.Log(str.Length);

        string nullString = null;

        print(nullString?.Length);

        double value = 40.175;
        print(value.ToString("F1"));
        print(value.ToString("C"));
        print(value.ToString("P"));
        print(value.ToString("#.###"));
    }
}

using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class trytest : MonoBehaviour
{

   
    public int[] woof = new int[5];

    public List<string> tutors;
    public List<string> students;
    public List<string> unknown;

    void Start()

    {
        tutors = new List<string> { "Alex", "Mishbau", "John" };
        students = new List<string>(50);
        foreach (var t in tutors)
        {
            Debug.Log(t);

        }
        tutors.Remove("Alex");
        PrintList(tutors);
        

        Debug.Log("first element" + woof[0]);
        Debug.Log("fifth element" + woof[4]);
        Debug.Log("sixth element" + woof[5]);
    }

    
    void Update()
    {
        
    }

    public int SumArray(int[] inputArr)

    {
        int dog = 0;
        foreach (int i in inputArr)
        {
            dog += i;
        }
        return dog;
    }

    void PrintList(List<string> inputlist)
    {
        foreach (string str in inputlist)
        {
            
        }
    }

    public static void RemoveName(string name, List<string> inputList)
    {



    }




}

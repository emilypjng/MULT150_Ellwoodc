using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    int sum = 22;
    int count = 2;
    void Start()
    {
        for (int i = 22; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                print(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*while (count <= 100)
        {
            sum += count;
            count++;
        }
        print(sum);*/
    }
}

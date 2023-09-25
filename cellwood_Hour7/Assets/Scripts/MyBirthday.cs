using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i <= 12; i++)
        {
            if (i == 1)
            {
                print("January");
            }
            else if (i == 2)
            {
                print("February");
            }
            else if (i == 3)
            {
                print("March");
            }
            else if (i == 4)
            {
                print("April");
            }
            else if (i == 5)
            {
                print("May");
            }
            else if (i == 6)
            {
                print("June");
            }
            else if (i == 7)
            {
                print("July");
            }
            else if (i == 8)
            {
                print("August");
            }
            else if (i == 9)
            {
                print("September");
            }
            else if (i == 10)
            {
                print("October");
            }
            else if (i == 11)
            {
                print("It's my birthday!");
                for (int j = 1; j <= 30; j++)
                {
                    if (j == 21)
                    {
                        print("It's my birthday!");
                    }
                    print(j);
                }

            }
            else if (i == 12)
            {
                print("December");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()

    {
        int[] array = new int[5];

        array[0] = 5;
        array[1] = 4;
        array[2] = 3;
        array[3] = 2;
        array[4] = 1;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        

        for (int i =4 ; i > -1; i--)

        {
            Debug.Log(array[i]);
        }
            }

            void Update()
            {

            }
    }

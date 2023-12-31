using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForStatementCheck : MonoBehaviour
{
    void Start()
    {
        // count0から10になるまで繰り返す
        for (var count = 0; count < 10; count++)
        {
            Debug.Log(count);// 0,1,2,3,4,5,6,7,8,9
        }

        for (var count = 10; count >= 0; count--)
        {
            Debug.Log(count);// 10,9,8,7,6,5,4,3,2,1,0
        }
        int fizzbuzzCount = 100;
        for (var count = 0;
            count < fizzbuzzCount;
        count++)
        {
            bool isPrime = true; // 素数かどうかを示すフラグ

            for (int i = 2; i * i <= count; i++)
            {
                if (count % i == 0)
                {
                    isPrime = false; // 素数ではない
                    break;
                }
            }

            if (isPrime)
            {
                Debug.Log($"{count}は素数");
            }

            Debug.Log(count);
            if (count % 15 == 0)
            {
                Debug.Log($"{count}:fizzbuzz");
                continue;
            }
            if (count % 3 == 0)
            {
                Debug.Log($"{count}:fizz");
            }
            if (count % 5 == 0)
            {
                Debug.Log($"{count}:buzz");
            }
        }





    }
    public bool IsPrime(int number)
    {
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;  // 約数が存在する場合は素数ではない
            }
        }

        return true;  // 2以上の数で、約数が存在しない場合は素数
    }
}

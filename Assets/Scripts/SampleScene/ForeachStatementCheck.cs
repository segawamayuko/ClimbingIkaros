using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //int型の変数20個分をintArrayとして定義する
    int[] intArray = new int[100];

    void Start()
    {
        // int型のListを作成する
        List<int> intList = new List<int>();

        // 0から100までの値でintArrayの各要素の値を代入する
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArrayのcount番目の値をcountとする
            // 例えばintArrayの2番目の要素を2とする
            intArray[count] = count;
            // intListの要素としてcountを追加
            intList.Add(count);
            // 素数じゃないフラグ
            bool isNotPrime = false;
            if (count <= 1)
            {
                continue;
            }
            for (int i = 2; i * i <= count; i++)
            {
                if (count % i == 0)
                {
                    Debug.Log($"{count}は{i}" +
                        "で割り切れるので素数ではない");
                    isNotPrime = true;
                    continue;
                }
            }
            if (isNotPrime)
            {
                continue;
            }
            Debug.Log($"{count}は素数");
        }

        // intListの中を捜査する
        // intArrayの要素数を100とする
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("このintListに19は含まれている");
            }
            if (intValue == 5)
            {
                Debug.Log($"{intValue}");
            }
            if (intValue == 90)
            {
                Debug.Log($"{intValue}");
            }
        }
    }
}



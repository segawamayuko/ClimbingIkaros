using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachStatementCheck : MonoBehaviour
{
    //int�^�̕ϐ�20����intArray�Ƃ��Ē�`����
    int[] intArray = new int[100];

    void Start()
    {
        // int�^��List���쐬����
        List<int> intList = new List<int>();

        // 0����100�܂ł̒l��intArray�̊e�v�f�̒l��������
        for (var count = 0;
            count < intArray.Length;
            count++)
        {
            // intArray��count�Ԗڂ̒l��count�Ƃ���
            // �Ⴆ��intArray��2�Ԗڂ̗v�f��2�Ƃ���
            intArray[count] = count;
            // intList�̗v�f�Ƃ���count��ǉ�
            intList.Add(count);
            // �f������Ȃ��t���O
            bool isNotPrime = false;
            if (count <= 1)
            {
                continue;
            }
            for (int i = 2; i * i <= count; i++)
            {
                if (count % i == 0)
                {
                    Debug.Log($"{count}��{i}" +
                        "�Ŋ���؂��̂őf���ł͂Ȃ�");
                    isNotPrime = true;
                    continue;
                }
            }
            if (isNotPrime)
            {
                continue;
            }
            Debug.Log($"{count}�͑f��");
        }

        // intList�̒���{������
        // intArray�̗v�f����100�Ƃ���
        foreach (var intValue in intList)
        {
            if (intValue == 19)
            {
                Debug.Log("����intList��19�͊܂܂�Ă���");
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



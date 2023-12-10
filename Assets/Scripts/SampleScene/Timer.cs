using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float gameTime = 0f;
    public float GetGameTime
    {
        get { return gameTime; }
    }

    public string GetGameTimeText
    {
        get { return gameTime.ToString("F2"); }
    }

    /// <summary>
    /// ��������
    /// </summary>
    private float limitTime = 30f;

    private void Start()
    {
        gameTime = limitTime;
        
    }
    void Update()
    {
        if (gameTime == 0)
        {
            Debug.LogError("�Q�[���I�[�o�[");
            return;
        }
        // ����gameTime��0���������΁A
        // ����if����艺�̏������s��Ȃ�
        if (gameTime <= 0)
        {
            gameTime = 0;
            return;
        }
        gameTime -= Time.deltaTime;
    }
}

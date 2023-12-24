using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

    /// <summary>
    /// soundManager���g����^�C�~���O�ŃV�[���ォ��T������
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        soundManager.PlayBGM();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer�̐������Ԃ�0����������Ƃ�
        if (Timer.GetGameTime < 0f)
        {
            // ResultCanvas�̃A�N�e�B�u���I���ɂ���
            ResultCanvas.gameObject.SetActive(true);
        }
    }
}

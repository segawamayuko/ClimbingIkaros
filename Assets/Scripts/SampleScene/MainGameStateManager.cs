using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameStateManager : MonoBehaviour
{
    public Canvas ResultCanvas;

    public Timer Timer;

    public Health PlayerHealth;

    bool gameEnd = false;

    //�O�������gameEnd���擾���邽�߂̃Q�b�^�[
    public bool GetGameEnd
    {
        get { return gameEnd;}
    }



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
        if (gameEnd)
        {
            return;
        }
        if (PlayerHealth.IsDead){

            //ResultCanvas�̃A�N�e�B�u���I���ɂ���
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;

        }

        // Timer�̐������Ԃ�0����������Ƃ�
        if (Timer.GetGameTime < 0f)
        {
            // ResultCanvas�̃A�N�e�B�u���I���ɂ���
            ResultCanvas.gameObject.SetActive(true);
            gameEnd = true;
        }
    }
}

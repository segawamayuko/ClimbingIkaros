using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManager���g����^�C�~���O�ŃV�[���ォ��T������
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    private void Start()
    {
        // soundManager��null����Ȃ����
        if (soundManager != null)
        {
            // BGM���Đ�����
            soundManager.PlayBGM();
        }
    }
    /// <summary>
    /// �C���Q�[���̃V�[���Ɉڍs����
    /// </summary>
    public void GotoInGameScene()
    {
        // SE��炷
        soundManager.PlaySE();
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
    }
}

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

    /// <summary>
    /// BGM���t�F�[�h�C�����鎞��
    /// </summary>
    public float FadeDuration = 2f;


    private void Start()
    {
        StartCoroutine(FadeInBGM());

    }
    /// <summary>
    /// �C���Q�[���̃V�[���Ɉڍs����
    /// </summary>
    public void GotoInGameScene()
    {
        // SE��炷
        // soundManager.PlaySE();
        // SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
        StartCoroutine(SceneTransition());

    }

    /// <summary>
    /// SE���Ȃ�I���̂��A�҂�����ɃV�[����J�ڂ�����
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        //SE��炷�������ɂ���̂͂��������Ȃ̂Ō�ŕς���
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1);
        //SE�����Ă���ԑ҂�
        yield return new WaitWhile(()=> soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);

    }
    /// <summary>
    /// �x���BGM�̍Đ�������
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        
        //soundManager��null����Ȃ����
        if(soundManager != null)
        {
            //BGM���Đ�����
            soundManager.PlayBGM();

            soundManager.GetBGMAudioSource.volume = 0;

            var elapsedTime = 0f;

            //�o�ߎ��Ԃ�FadeDuration�̒l�𒴂���܂�
            while(elapsedTime < FadeDuration)
            {
                //�t�F�[�h�C���̃{�����[�����v�Z
                //0��1�̊ԂŐ��`��Ԃ������Ȃ������ʂ��{�����[���̒l�ɑ������
                soundManager.GetBGMAudioSource.volume = Mathf.Lerp(0f, 1, elapsedTime / FadeDuration);

                //�o�ߎ��Ԃ��X�V����
                elapsedTime+= Time.deltaTime;

                //�P�t���[���ҋ@����
                yield return null;

            }

            soundManager.GetBGMAudioSource.volume = 1f;

        }
    }

}


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    /// <summary>
    /// BGM��SE��炷�X�s�[�J�[�̃R���|�[�l���g�̔z��
    /// ���v4�����A1�ڂ�BGM�A2~4�ڂ�SE�ŉ������Ԃ��Ă����v�Ȃ悤�ɂ���
    /// </summary>
    private AudioSource[] audioSources = new AudioSource[4];

    public AudioClip BGMClip;

    public AudioClip SEClip;

    private void Awake()
    {
        // audioSources�����̃R���|�[�l���g������GameObject�ɒǉ������
        // ���Ȃ��ꍇ�́AAddComponent���ĕ�[����
        if (audioSources[0] == null)
        {
            // 4��J��Ԃ�
            for (int i = 0; i < audioSources.Count(); i++)
            {
                //audioSources�ɒǉ������AudioSource����
                audioSources[i] = this.gameObject.AddComponent<AudioSource>();
            }
        }
    }

    /// <summary>
    /// BGM���Đ�����
    /// </summary>
    public void PlayBGM()
    {
        audioSources[0].clip = BGMClip;
        audioSources[0].Play();
    }

    /// <summary>
    /// SE���Đ�����
    /// </summary>
    public void PlaySE()
    {
        // �z���0�Ԗڂ�BGM���g���Ă���̂ŁA1�Ԗڂ���for������
        for (int i = 1; i < audioSources.Length; i++)
        {
            // audioSource���v���C������Ȃ�������
            if (!audioSources[i].isPlaying)
            {
                audioSources[i].clip = SEClip;
                // for���𔲂���
                break;
            }
        }
    }
}

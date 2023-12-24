using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// CreateAssetMenu�̑�����t���邱�Ƃ�UnityEditor��̉E�N���b�N����쐬���邱�Ƃ��\�ƂȂ�܂��B
/// </summary>
[CreateAssetMenu(menuName = "ScriptableObjects/ClimbingIkarosStage")]
public class ClimbingIkarosStage : ScriptableObject
{
    /// <summary>
    /// Stage�̖��O
    /// </summary>
    [SerializeField]
    public string StageName = "�n��";

    /// <summary>
    /// �Q�[�����N���A���邽�߂̍���
    /// </summary>
    [SerializeField]
    public float ClearHeight = 100;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbingIkarosStageDataManager : MonoBehaviour
{
    /// <summary>
    /// �X�e�[�W�̃f�[�^
    /// </summary>
    public ClimbingIkarosStage ClimbingIkarosStage;

    /// <summary>
    /// �N���A�p�̍������O������擾����悤�̃A�N�Z�T
    /// </summary>
    public float GetClearHeight
    {
        get { return ClimbingIkarosStage.ClearHeight; }
    }

}

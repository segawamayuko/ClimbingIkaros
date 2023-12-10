using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;
    public float StageMaxY = 0f;
    private void Update()
    {
        // �v���C���[�̍�����0�ȉ��Ȃ珈�������Ȃ�
        if (Player.transform.position.y < 0)
        {
            return;
        }

        //�����̍������J������ǂ���X�e�[�W�̍ő�̍�����
        //�������珈�������Ȃ�
        if(this.transform.position.y > StageMaxY)
        {
            return;
        }


        this.transform.position
      = new Vector3(0, Player.transform.position.y, -10);
    }
}

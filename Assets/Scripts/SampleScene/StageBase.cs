using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageBase : MonoBehaviour
{
    // �X�e�[�W�̃^�C�v��enum�ŊǗ�����
    public enum StageTypes
    {
        Invalide = -1,      // ����`
        Normal,             // �ʏ�
        Fall,               // ������
        TimeAcceleration,   // ���Ԃ�i�߂�
        Damage,             // �_���[�W��^����
        Move                // ������
    }
    /// <summary>
    /// �X�e�[�W�^�C�v��ʏ�ŏ�����
    /// </summary>
    public StageTypes StageType = StageTypes.Normal;

    /// <summary>
    /// �N������
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �������Ă����̂��v���C���[��������
        if (collision.gameObject.tag == GameSettingUtility.PlayerTagName)
        {
            if (collision.transform.position.y >
                this.transform.position.y)
            {
                // ������BoxCollider2D��IsTrigger���I�t�ɂ���
                this.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }




    public void OnCollisionEnter2DAction(GameObject player)
    {
        switch (StageType)
        {
           case StageTypes.Invalide:
                break;
            case StageTypes.Normal:
                Time.timeScale = 1F;

                break;
            case StageTypes.Fall:
                // Player�����������痎�Ƃ�����
               
                    if (this.gameObject.GetComponent<Rigidbody2D>() == null)
                    {
                        this.gameObject.AddComponent<Rigidbody2D>();
                    }
                

               
                    //this.gameObject.SetActive(false);
                break;

            case StageTypes.TimeAcceleration:
                
                    if (Time.timeScale < 2)
                    {
                        // ���Ԃ̏k�ڂ�ύX����B
                        Time.timeScale *= 1.2f;
                        
                    }
               
                break;

            case StageTypes.Damage:
                
                
                    // Health�R���|�[�l���g���Q�b�g���Ă���
                    var health = player.gameObject.
                        GetComponent<Health>();

                    if (health != null)
                    {
                        // Health�R���|�[�l���g��TakeDamage�𔭓�������B
                        health.TakeDamage(20f);
                    }
                
                break;
        }
        this.GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void Update()
    {
        // StageType�̒l��Move��������
        if (StageType == StageTypes.Move)
        {
            // �����Ɏ��Ԃ�˂�����Sin���擾����B
            // Sin(x)�̃O���t�̓���������̂�1����-1�̒l����������B
            var sin = Mathf.Sin(Time.time);
            // �ꎞ�ϐ���pos���쐬���A�R�[�h��ǂ݂₷������
            var pos = this.transform.position;
            // ������position��x�̒l��sin�𑫂�������
            this.transform.position =
                new Vector3(
                pos.x + sin * GameSettingUtility.MoveStageHorizontalFactor,
                pos.y,
                pos.z);
        }
    }
}

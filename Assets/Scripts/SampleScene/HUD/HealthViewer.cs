using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthViewer : MonoBehaviour
{
    /// <summary>
    /// �̗͊Ǘ��p�N���X
    /// </summary>
    public Health Health;

    /// <summary>
    /// �̗͔��f�p�̃X���C�_�[
    /// </summary>
    public Slider HealthSlider;

    private void Update()
    {
        // Slider��Position�ɃJ�����̍��W�ϊ����g���ăv���C���[�̃|�W�V�����{Y��������1�̒l������������
        this.HealthSlider.GetComponent<RectTransform>().position =
          Camera.main.WorldToScreenPoint(this.Health.gameObject.transform.position + Vector3.up);
        
        // ����ł�����Slider�ɒl�������Ȃ��悤�ɂ���
        if (Health.IsDead)
        {
            return;
        }
        // ���ݑ̗�/�ő�̗͂����邱�Ƃɂ���āA80/100�������ꍇ0.8�̒l��Slider�ɗ^���邱�Ƃ��ł���
        HealthSlider.value = Health.GetCurrentHealth / Health.MaxHealth;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// �ő�HitPoint
    /// </summary>
    public float MaxHealth = 100f;

    /// <summary>
    /// ���݂�HitPoint
    /// </summary>
    [SerializeField]
    private float currentHealth;

    /// <summary>
    /// currentHealth���Q�b�g���邽�߂̃A�N�Z�T
    /// </summary>
    public float GetCurrentHealth
    {
        get { return currentHealth; }
    }

    /// <summary>
    /// ���S����
    /// </summary>
    public bool IsDead = false;

    /// <summary>
    /// �ŏ��Ɉ�񂾂���������郁�\�b�h
    /// </summary>
    void Start()
    {
        // ���݂�Hitpoint�ɍő�Hitpoint����
        currentHealth = MaxHealth;
    }

    /// <summary>
    /// ���݂�hitPoint����damage���̒l������ 
    /// </summary>
    /// <param name="damage">hitPoint����������l</param>
    public void TakeDamage(float damage)
    {
        // HitPoint��0�Ȃ̂ł���if����艺�͏������s��Ȃ��悤�ɂ���
        if (currentHealth == 0)
        {
            return;
        }
        // ���݂�HP��0����Ȃ�
        if (currentHealth > 0)
        {
            currentHealth -= damage;
            Debug.Log($"���݂�Health��{currentHealth}");
        }

        // ����currentHealth��0����������Ƃ��A
        if (currentHealth <= 0)
        {
            // ���S�t���O�𗧂Ă�
            IsDead = true;
            Debug.LogError("�Q�[���I�[�o�[");
            // currentHealth��0�ɂ���B
            currentHealth = 0;
        }
    }
}

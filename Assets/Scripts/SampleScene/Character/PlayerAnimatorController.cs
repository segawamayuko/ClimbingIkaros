using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // playerAnimator��GameObject�������Ă���Animator����
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Animator��float�^�̃p�����[�^�[�AJumpPower��PlayerMovement��
        // jumpPower��������B
        playerAnimator.SetFloat("JumpPower",PlayerMovement.GetJumpPower);
        
        // Ainmator��IsRight��PlayerMovement�̉E�����t���O��������
        playerAnimator.SetBool("IsRight", PlayerMovement.GetIsRight);
    
    }
}

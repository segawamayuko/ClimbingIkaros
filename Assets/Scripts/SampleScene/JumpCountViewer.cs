using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpCountViewer : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    public TextMeshProUGUI JumpText;

    void Update()
    {
        // JumpTextにPlayerMovementのJumpCountを取得する
        JumpText.text =
            PlayerMovement.GetJumpCount.ToString();
    }
}

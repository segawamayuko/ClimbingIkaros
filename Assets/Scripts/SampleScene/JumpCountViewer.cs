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
        // JumpText��PlayerMovement��JumpCount���擾����
        JumpText.text =
            PlayerMovement.GetJumpCount.ToString();
    }
}

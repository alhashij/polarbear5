using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpbox : MonoBehaviour
{

    public GameObject PopupBox;
    public Animator animator;
    public TMP_Text popupText;

    // Start is called before the first frame update
    
    public void PopUp(string text)
    {
        PopupBox.SetActive(true);
        popupText.text = text;
        animator.SetTrigger("pop");
    }
}

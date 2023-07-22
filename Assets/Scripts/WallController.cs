using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour, IGCInteractable
{
    [SerializeField]
    private Selectables selectable;

    public void OnPointerEnter()
    {
        selectable._gameObject = this.gameObject;
    }

    public void OnPointerExit()
    {
        selectable._gameObject = null;
    }

    public void OnPointerClick()
    {
        selectable.ChangeMatOnMobileVR();
    }
}

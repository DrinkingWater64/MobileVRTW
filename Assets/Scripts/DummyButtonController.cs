using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyButtonController : MonoBehaviour
{
    [SerializeField]
    private Selectable button;

    //public void OnPointerClick()
    //{
    //    throw new System.NotImplementedException();
    //}

    //public void OnPointerEnter()
    //{

    //}

    //public void OnPointerExit()
    //{
    //    throw new System.NotImplementedException();
    //}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DebugButton()
    {
        Debug.LogWarning("Clicking button");
    }
}

public interface IGCInteractable
{
    public void OnPointerEnter();
    public void OnPointerExit();
    public void OnPointerClick();
}

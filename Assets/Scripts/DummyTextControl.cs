using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DummyTextControl : MonoBehaviour
{
    [SerializeField]
    private TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressedInVR()
    {
        text.text = "works";
    }

    public void ChangeText(string message)
    {
        text.text = message;
    }
}

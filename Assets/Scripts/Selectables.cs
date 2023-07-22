using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selectables : MonoBehaviour
{
    [SerializeField]
    private Material red;
    [SerializeField]
    private Material blue;
    [SerializeField]
    private List<Material> _matList = new List<Material>();
    private int count = 0;


    private RaycastHit _raycastHit;
    public GameObject _gameObject;
    void Update()
    {
        //    ClickObject();

        //    if (Input.GetKeyDown(KeyCode.R))
        //    {
        //        ChangeMat(red);
        //    }
        //    if (Input.GetKeyDown(KeyCode.B))
        //    {
        //        ChangeMat(blue);
        //    }
        if (Input.GetKeyDown(KeyCode.I))
        {
            IncreaseTiling();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            DecreaseTiling();
}
    }

    //void ClickObject()
    //{
    //    if (Input.GetKey(KeyCode.Mouse0) && !EventSystem.current.IsPointerOverGameObject())
    //    {
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        Physics.Raycast(ray, out _raycastHit);
    //        Debug.Log(_raycastHit.transform.gameObject.tag);
    //        if (_raycastHit.transform.CompareTag("Wall"))
    //        {
    //            _gameObject = _raycastHit.transform.gameObject;
    //        }
    //    }
    //}

    public void ChangeMat(GameObject gameObject, int serial)
    {
        if (serial == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = red;
        }
        else if (serial ==2)
        {
            gameObject.GetComponent<MeshRenderer>().material = blue;
        }
    }

    public void ChangeMatOnMobileVR()
    {
        count = count % _matList.Count;
        _gameObject.GetComponent<MeshRenderer>().material = _matList[count];
        count = count + 1;
    }

    public void IncreaseTiling()
    {
        if (_gameObject != null)
        {
            Material material = _gameObject.GetComponent<Renderer>().material;
            Vector2 currentScaale = new Vector2();
            currentScaale = material.GetTextureScale("_MainTex");
            currentScaale.x += 1;
            currentScaale.y += 1;
            material.SetTextureScale("_MainTex", currentScaale);
            Debug.Log("Working");
        }

    }

    public void DecreaseTiling()
    {
        if (_gameObject != null)
        {
            Material material = _gameObject.GetComponent<Renderer>().material;
            Vector2 currentScaale = new Vector2();
            currentScaale = material.GetTextureScale("_MainTex");
            currentScaale.x -= 1;
            currentScaale.y -= 1;
            material.SetTextureScale("_MainTex", currentScaale);
            Debug.Log("Working");
        }
    }
}


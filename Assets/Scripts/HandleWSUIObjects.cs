using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HandleWSUIObjects : MonoBehaviour
{

    private GraphicRaycaster raycaster;
    private PointerEventData pointerEventData;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        raycaster = GetComponent<GraphicRaycaster>();
        pointerEventData = new PointerEventData(EventSystem.current);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Transform reticle = GameObject.Find("CardboardReticlePointer").transform;
            Vector3 pos = Camera.main.WorldToScreenPoint(reticle.position);
            Debug.LogWarning(pos.ToString());
            Debug.LogWarning(Input.mousePosition.ToString());


            // Set the mouse position for raycasting
            pointerEventData.position = new Vector3(pos.x, pos.y, 0.0f);

            // Create a list to store raycast results
            var results = new List<RaycastResult>();

            // Raycast from the mouse position
            raycaster.Raycast(pointerEventData, results);

            // Check if any UI elements were hit
            if (results.Count > 0)
            {
                // Output the name of the first UI element hit
                foreach (var result in results)
                {
                    Debug.Log("Clicked on UI element: " + result.gameObject.name);
                }
            }
        }
    }
}

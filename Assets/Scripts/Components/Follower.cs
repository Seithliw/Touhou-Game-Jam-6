using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    private Camera cam;
    public RectTransform falseParent;
    void Start()
    {
        cam = Camera.main;
    }
    void Update() 
    {
        Vector2 screenPoint = RectTransformUtility.WorldToScreenPoint(cam, falseParent.transform.position);
        Vector3 newPoint = cam.ScreenToWorldPoint(screenPoint);
        transform.SetPositionAndRotation(newPoint, falseParent.rotation);
    }
}

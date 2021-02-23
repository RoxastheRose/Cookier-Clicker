using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPoint : MonoBehaviour
{
    [SerializeField] public GameObject m_touchTemplate;
    
    void Update()
    {
        Vector2 touchPos;
        bool aTouch = false;
        if (Application.platform != RuntimePlatform.Android)
        {
            aTouch = Input.GetMouseButtonUp(0);
            touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        } else {
            aTouch = Input.touchCount > 0;
            touchPos = Input.GetTouch(0).position;
        }

        if (aTouch) CreateTouch(touchPos);
    }

    void CreateTouch(Vector2 position)
    {
        Debug.Log("X: " + position.x + " / Y: " + position.y);
        GameObject toucher = Instantiate(m_touchTemplate);
        toucher.transform.position = position;
    }
}

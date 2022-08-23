using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customCursor : MonoBehaviour
{
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = targetPos;
    }
}

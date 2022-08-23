using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunAim2 : MonoBehaviour
{
    public float offset;

    private SpriteRenderer spriteRender;

    public Transform FirePoint;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if(rotZ < 89 && rotZ > -89)
        {
            spriteRender.flipY = false;
        }
        else
        {
            spriteRender.flipY = true;
        }

        //if(rotZ < - 88 && rotZ > 88)
        //{
            //FirePoint.transform.Rotate(0,180,0);
        //}
        //else
       // {
            FirePoint.transform.rotation = transform.rotation;
       // }

    }
}

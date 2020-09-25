using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class X_controll : MonoBehaviour
{
    public GameObject bullet;
    public Transform muzzleTransform;

    public Camera cam;
    private Vector3 mousePos;
    private Vector2 gunDirection;
    
    private GameObject gou_zhao;

    private Gou gou_contoll;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        gunDirection = (mousePos - transform.position).normalized;
        float angle = Mathf.Atan2(gunDirection.y, gunDirection.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
        if(Input.GetMouseButtonDown(0)&&!gou_zhao)
        {
            //左键按下
            //生成一个钩爪
          gou_zhao = Instantiate(bullet, muzzleTransform.position, Quaternion.Euler(muzzleTransform.eulerAngles));

          gou_contoll= gou_zhao.GetComponent<Gou>();
           // BirdController bird = other.GetComponent<BirdController>();
        }

        if(gou_zhao&&gou_contoll.is_tri(gameObject))
        {       
        }

       
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 用于控制
 * 陨石
 * 图形
 * 的移动
 */

public class Move_manager : MonoBehaviour
{
    private Rigidbody2D rg2d_a;
    private Rigidbody2D rg2d_b;
    public static Move_manager instance { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void X_move(GameObject a,GameObject b)
    {
        rg2d_a = a.GetComponent<Rigidbody2D>();
        rg2d_b = b.GetComponent<Rigidbody2D>();
        Vector2 Force_direction = (a.transform.position - b.transform.position).normalized;

        rg2d_a.AddForce(-Force_direction, ForceMode2D.Impulse);
        rg2d_b.AddForce(Force_direction, ForceMode2D.Impulse);



    }
}

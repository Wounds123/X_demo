using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Gou : MonoBehaviour
{

    public int damage;
    public float speed;
    public float arrawDistance;


    private Rigidbody2D rg2d;
    private Vector3 startPos;
    private bool is_gou = false;//是否勾中
    private GameObject a, b;//玩家与陨石
    // Start is called before the first frame update
    void Start()
    {
        rg2d = GetComponent<Rigidbody2D>();
        rg2d.velocity = transform.right * speed;
        startPos =transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (transform.position - startPos).sqrMagnitude;
        if(distance>arrawDistance)
        {
           Destroy(gameObject);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("can_take"))
        {
            is_gou = true;
            b = other.gameObject;
            Move_manager.instance.X_move(a, b);
            UnityEngine.Debug.Log("take");


        }
       else
        {
            //Destroy(gameObject);
        }
    }


    public bool is_tri(GameObject player)//获取player
    {
        a = player;
        return is_gou;
    }
}

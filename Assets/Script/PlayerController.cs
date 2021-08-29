using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] GameObject playerBang;
  
    [SerializeField] int playerHP;
    private Enemy2Health getDamageEnemy2;
    private BossHealth getDamageBoss1;


    public Action OnPlayerDied;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //MoveKey();
        MoveMouse();

    }

    void MoveMouse()
    {
        var overPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        overPoint.z = 0;
        overPoint.y += 0.5f;
        transform.position = Vector3.MoveTowards(transform.position, overPoint,speed*Time.deltaTime) ;

    }
    void MoveKey()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += Vector3.left * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.W))
            transform.position += Vector3.up * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.down * speed * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            getDamageEnemy2 = collision.gameObject.GetComponent<Enemy2Health>();
            playerHP -= getDamageEnemy2.Damage();
            if (playerHP <= 0)
            {
                var onPlayerBang = Instantiate(playerBang, transform.position, transform.rotation);
                Destroy(onPlayerBang, 0.71f);
                Destroy(gameObject);
                if(OnPlayerDied!=null)
                    OnPlayerDied();
            }
            
        }else if (collision.gameObject.CompareTag("Boss1"))
        {
            getDamageBoss1 = collision.gameObject.GetComponent<BossHealth>();
            playerHP -= getDamageBoss1.Damage();
            if (playerHP <= 0)
            {
                var onPlayerBang = Instantiate(playerBang, transform.position, transform.rotation);
                Destroy(onPlayerBang, 0.71f);
                Destroy(gameObject);
                if (OnPlayerDied != null)
                    OnPlayerDied();
            }

        }
    }
}

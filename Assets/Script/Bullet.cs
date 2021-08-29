using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 4.5f;
    [SerializeField] int getDamage;
    [SerializeField] GameObject bulletBang;
    public float lifeTime;
    private float counter;

  //////////////////////////////////////////////////
    void Start()
    {
       
    }

    void Update()
    {
        Move();
       
    }
    void Move()
    {
        transform.position += Vector3.up * speed* Time.deltaTime;
    }
    void Deactive()
    {
        this.gameObject.SetActive(false);
    }
    ////////////////////////////////////////////////////
    
    private  void OnEnable()
    {
        Invoke("Deactive", lifeTime);
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var onBulletBang = Instantiate(bulletBang, transform.position, transform.rotation);
        Destroy(onBulletBang, 2.6f);
 	    this.gameObject.SetActive(false);
    }
    
    public int Damage()
    {
        return getDamage;
    }

   
}

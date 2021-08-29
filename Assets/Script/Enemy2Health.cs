using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
    private Bullet damageBullet;
    [SerializeField] GameObject enemyBang;
    [SerializeField] int enemyHP;
    [SerializeField] int bodyDamage;
    [SerializeField] float speed;
    [SerializeField] ScoreController score;
    [SerializeField] int enemyScore;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed*Random.Range(0.1f,2.0f) * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            damageBullet = collision.gameObject.GetComponent<Bullet>();
            enemyHP -= damageBullet.Damage();
            if (enemyHP <= 0)
            {
                var onEnemyBang = Instantiate(enemyBang, transform.position, transform.rotation);
                Destroy(onEnemyBang, 0.554f);
                Destroy(gameObject);
                ScoreController.instant.AddScore(enemyScore);
            }
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            var onEnemyBang = Instantiate(enemyBang, transform.position, transform.rotation);
            Destroy(onEnemyBang, 0.554f);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

    public int Damage()
    {
        return bodyDamage;
    }
}

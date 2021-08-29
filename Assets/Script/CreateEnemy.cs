using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefabs;
  

    private BoxCollider2D boxEnemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
 
    }

    void Awake()
    {
        boxEnemy = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {

    }

   IEnumerator Create()
    {
        yield return new WaitForSeconds(Random.Range(1f, 5f));
        float minX = -boxEnemy.bounds.size.x / 2f;
        float maxX = boxEnemy.bounds.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        Instantiate(enemyPrefabs, temp,Quaternion.identity);

        StartCoroutine(Create());
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoss : MonoBehaviour
{

    [SerializeField] GameObject bossPrefabs;


    private BoxCollider2D boxBoss;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());

    }

    void Awake()
    {
        boxBoss = GetComponent<BoxCollider2D>();
    }
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Create()
    {
        yield return new WaitForSeconds(Random.Range(10f, 20f));
        float minX = -boxBoss.bounds.size.x / 2f;
        float maxX = boxBoss.bounds.size.x / 2f;
        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        Instantiate(bossPrefabs, temp, Quaternion.identity);

        StartCoroutine(Create());
    }
}

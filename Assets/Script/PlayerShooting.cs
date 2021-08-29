using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefabs;
    [SerializeField] float delayTime;
    private  float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {
        var gunPos = transform.position;
        gunPos.y += 0.5f;
        counter += Time.deltaTime;
        if (counter >= delayTime)
        {
            bulletPrefabs=BulletPooling.instant.GetBullet();
            bulletPrefabs.transform.position = gunPos;
            bulletPrefabs.gameObject.SetActive(true);
            counter = 0;
        }
    }
}

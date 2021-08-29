using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooling : ObjectPooling_base<BulletPooling>
{
    [SerializeField] float LifeTime_Bullet = 3;

    public GameObject GetBullet()
    {
        GameObject g = this.getObj();
        g.GetComponent<Bullet>().lifeTime= LifeTime_Bullet;
        return g;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.up * speed * Time.deltaTime;
        Vector3 temp = transform.position;
        if (temp.y <= -10)
            temp.y += 20;
        transform.position = temp;
    }
}

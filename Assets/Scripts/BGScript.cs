using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScript : MonoBehaviour
{
    [SerializeField]
    private float mSpeed;
    private SpriteRenderer mSpr;
    void Start()
    {
        mSpr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * mSpeed;
        Vector3 pos = transform.position;
        if(pos.x + mSpr.bounds.size.x / 2 <-8)
        {
            float size = mSpr.bounds.size.x * 2;
            pos.x += size;
            transform.position = pos;
        }
    }
}

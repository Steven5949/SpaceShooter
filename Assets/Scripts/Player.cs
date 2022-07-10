using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject playerShot;
    public Transform shotPos;
    BoxCollider2D col;
    Vector2 colSize;
    Vector2 halfSize;
    Vector3 min, max;
    [SerializeField]
    private float mSpeed;
    
    void Start()
    {
        Vector3 shotPos = new Vector3(0.6f, -0.9f, 0);
        Instantiate(playerShot, transform.position + shotPos.local, Quaternion.identity);
        //int c = ManagerScript.main.Add(10, 20);
        //Debug.Log(c);
        col = GetComponent<BoxCollider2D>();
        colSize = col.size;
        halfSize = new Vector2(colSize.x / 2, colSize.y / 2);
        min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, vertical, 0);
        transform.position = transform.position + dir * Time.deltaTime * mSpeed;
        float newX = transform.position.x;
        float newY = transform.position.y;
        if(newX < min.x + halfSize.x)
        {
            newX = min.x + halfSize.x;
        }
        if(newX > max.x - halfSize.x)
        {
            newX = max.x - halfSize.x;
        }
        if (newY < min.y + halfSize.y)
        {
            newY = min.y + halfSize.y;
        }
        if (newY > max.y - halfSize.y)
        {
            newY = max.y - halfSize.y;
        }
        transform.position = new Vector3(newX, newY, 0);
    }
}

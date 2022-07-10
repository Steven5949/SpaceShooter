using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public static ManagerScript main;
    private void Awake()
    {
        main = this;
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}

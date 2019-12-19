using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    private Transform target;
    [SerializeField] float speed = 4.0f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
        if (player != null) { 
        target = GameObject.Find("Player").transform; 

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}

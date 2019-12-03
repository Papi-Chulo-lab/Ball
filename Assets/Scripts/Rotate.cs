using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed = 180;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float x;
    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 50;
        transform.rotation = Quaternion.Euler(0, x, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Material material;
    public string laserName;
    public byte[] _myColor = new byte[3];

    LaserBeam beam;

    void Update()
    {
        Destroy(GameObject.Find(laserName));
        beam = new LaserBeam(laserName, _myColor, gameObject.transform.position, gameObject.transform.right, material);
    }
}

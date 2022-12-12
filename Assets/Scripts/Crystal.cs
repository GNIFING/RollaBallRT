using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public byte[] _myColor = new byte[3];
    public string targetLaserName;

    private bool isHit = false;

    Material m_Material;

    // // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
    }

    // // Update is called once per frame
    void Update()
    {
        if (!isHit)
        {
            Debug.Log("Update");
            m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 32 );
        }
        isHit = false;
    }

    public void UpdateColor(string laserName)
    {
        if (laserName == targetLaserName)
        {
            isHit = true;
            m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 255 );
        }
    }
}

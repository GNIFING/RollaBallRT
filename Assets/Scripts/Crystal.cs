using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public byte[] _myColor = new byte[3];
    public string targetLaserName;

    private bool useHitColor = false;

    Material m_Material;

    // // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        // m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 32 );
    }

    // // Update is called once per frame
    void Update()
    {
        if (!useHitColor)
        {
            m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 32 );
        }
        useHitColor = false;
    }

    public void UpdateColor(string laserName)
    {
        if (laserName == targetLaserName)
        {
            useHitColor = true;
            m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 255 );
        }
    }

    public bool GetIsHit() {
        return m_Material.color.a == 1;
    }
}

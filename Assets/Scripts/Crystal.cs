using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public byte[] _myColor = new byte[3];
    Material m_Material;
    // Start is called before the first frame update
    void Start()
    {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 50 );
    }

    // Update is called once per frame
    void Update()
    {
        m_Material = GetComponent<Renderer>().material;
        m_Material.color = new Color32( _myColor[0], _myColor[1], _myColor[2], 50 );
    }
}

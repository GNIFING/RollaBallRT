using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelManager : MonoBehaviour
{
    public GameObject nextSceneObj;
    public Crystal[] crystalScripts;

    // Update is called once per frame
    void Update()
    {
        nextSceneObj.SetActive(crystalScripts.Count(x => x.GetIsHit()) == crystalScripts.Length);
    }
}

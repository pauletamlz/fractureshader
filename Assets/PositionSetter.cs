using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSetter : MonoBehaviour
{
    public Material fractureMaterial;
    public Transform obj;

    void Update()
    {
        fractureMaterial.SetVector("CharacterPosition", obj.transform.position );
    }
}

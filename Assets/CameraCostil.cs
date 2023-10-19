using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCostil : MonoBehaviour
{
    public Transform hero;
    private void LateUpdate()
    {
        if (transform.position.y < hero.position.y) 
        {
            Vector3 Fixate = new Vector3 (transform.position.x, hero.position.y,transform.position.z);
            transform.position = Fixate;
        }
    }
}

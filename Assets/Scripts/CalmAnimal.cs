using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalmAnimal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            UI.instance.scorePoints += 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 moveVector;

    private void Update()
    {
        transform.Translate(moveVector * Time.deltaTime * speed);

        Destroy(this.gameObject, 5);
    }
}

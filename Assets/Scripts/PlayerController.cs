using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float boundriesX;
    [SerializeField] private float topBoundriesZ;
    [SerializeField] private float bottomBoundriesZ;
    [SerializeField] private GameObject projectilePrafab;

    private void Update()
    {
        //boundries
        if (transform.position.x < -boundriesX)
        {
            transform.position = new Vector3(-boundriesX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundriesX)
        {
            transform.position = new Vector3(boundriesX, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -bottomBoundriesZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -bottomBoundriesZ);
        }
        if (transform.position.z > topBoundriesZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, topBoundriesZ);
        }

        //movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(1, 0, 0) * horizontalInput * Time.deltaTime * Player.instance.speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, 1) * verticalInput * Time.deltaTime * Player.instance.speed);

        //shoot projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrafab, transform.position, projectilePrafab.transform.rotation);
        }
    }
}

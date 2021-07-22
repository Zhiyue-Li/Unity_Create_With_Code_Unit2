using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    Vector2 move;
    float speed = 15f;
    float xRange = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * move.x);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * move.y);
        
        transform.position = transform.position.x > xRange ?
            new Vector3(xRange, transform.position.y, transform.position.z) :
            transform.position.x < -xRange ?
                new Vector3(-xRange, transform.position.y, transform.position.z) :
                transform.position;
        
        transform.position = transform.position.z > 20f ?
            new Vector3(transform.position.x, transform.position.y, 20f) :
            transform.position.z < -10f ?
                new Vector3(transform.position.x, transform.position.y, -10f) :
                transform.position;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    
}

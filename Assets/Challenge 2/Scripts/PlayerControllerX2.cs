using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float lastTime = 0.0f;
    float timeInterval = 1.0f;

    public void OnFire(InputAction.CallbackContext context)
    {
        if(context.performed && (lastTime == 0.0f || Time.time - lastTime >= timeInterval))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastTime = Time.time;
        }
    }
}

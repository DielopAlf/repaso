using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    public float movementSpeed = 2.0f;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            float step = movementSpeed * Time.deltaTime;
            transform.position = Vector3.Lerp(startPosition.position, endPosition.position, step);

            if (transform.position == endPosition.position)
            {
                isMoving = false;
                // Aquí puedes agregar cualquier lógica adicional cuando llegue al punto final.
            }
        }
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void ResetPosition()
    {
        transform.position = startPosition.position;
        isMoving = false;
    }
}
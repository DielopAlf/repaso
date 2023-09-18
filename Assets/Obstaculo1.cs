using UnityEngine;

public class Obstaculo1 : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 5.0f;
    private bool haciaB = true;

    void Update()
    {
        if (haciaB)
        {
            // Mueve el objeto hacia el punto B
            transform.position = Vector2.MoveTowards(transform.position, puntoB.position, velocidad * Time.deltaTime);

            // Si el objeto llega al punto B, cambia de dirección
            if (Vector2.Distance(transform.position, puntoB.position) < 0.01f)
            {
                haciaB = false;
            }
        }
        else
        {
            // Mueve el objeto hacia el punto A
            transform.position = Vector2.MoveTowards(transform.position, puntoA.position, velocidad * Time.deltaTime);

            // Si el objeto llega al punto A, cambia de dirección
            if (Vector2.Distance(transform.position, puntoA.position) < 0.01f)
            {
                haciaB = true;
            }
        }
    }
}

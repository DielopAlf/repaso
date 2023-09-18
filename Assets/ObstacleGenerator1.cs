using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator1 : MonoBehaviour
{

    public obstacleGenerator obstacleGenerator;



    void Update()
    {
        transform.Translate(Vector2.left * obstacleGenerator.currentSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nextline"))
        {

            obstacleGenerator.generatePlatform();

        }
        if (collision.gameObject.CompareTag("Finish"))
        {

            Destroy(this.gameObject);

        }
    }
    



}

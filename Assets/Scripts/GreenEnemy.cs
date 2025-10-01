using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class GreenEnemy : MonoBehaviour
{
    string direction = "down";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if(direction == "down")
            transform.position -= new Vector3(0, 3f, 0) * Time.deltaTime;
        else if (direction == "right")
            transform.position += new Vector3(3f, 0, 0) * Time.deltaTime;
        else if (direction == "up")
            transform.position += new Vector3(0, 3f, 0) * Time.deltaTime;
        else if (direction == "left")
            transform.position -= new Vector3(3f, 0, 0) * Time.deltaTime;
  

    }
    void OnTriggerEnter2D(Collider2D other) {
        
        if (direction == "down") {
            Debug.Log(direction);
            direction = "right";
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 90);
        }
        else if (direction == "right")
        {
            Debug.Log(direction);
            direction = "up";
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 90);
        }
        else if (direction == "up")
        {
            Debug.Log(direction);
            direction = "left";
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 90);
        }
        else if (direction == "left")
        {
            Debug.Log(direction);
            direction = "down";
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, 90);
        }

    }
}

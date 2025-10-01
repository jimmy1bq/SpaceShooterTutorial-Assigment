using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    [SerializeField] GameObject enemyBlue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y)) {
            Instantiate(enemyBlue, transform.position, Quaternion.identity);
        }
    }
}

using UnityEngine;

public class meteor : MonoBehaviour
{
    [SerializeField] GameObject minimeteor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Boss")
        {
            print(collision.gameObject);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(minimeteor, new Vector3(transform.position.x + 0.5f, transform.position.y, 0), Quaternion.identity);
            Instantiate(minimeteor, new Vector3(transform.position.x - 0.5f, transform.position.y, 0), Quaternion.identity);
        }
    }
}

using UnityEngine;

public class minimeteor : MonoBehaviour

   {
    [SerializeField] GameObject laser;
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
        if (collision.gameObject.tag != "Boss") {
            Instantiate(laser, transform.position + new Vector3(0, -1.0f, 0), Quaternion.identity);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
}

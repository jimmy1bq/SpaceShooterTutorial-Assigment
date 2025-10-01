using UnityEngine;

public class LabP : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpforce;
    [SerializeField] Rigidbody2D rgd;
    [SerializeField] GameObject myCricle;
    [SerializeField] GameObject worldCricle;
    float normalspeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        normalspeed = speed;
    }

    // Update is called once per frame

    void DestroyThing(GameObject thing) {
        Destroy(thing);
    
    }
    void spawnThing(GameObject thing) { 
        Instantiate(thing, transform.position, Quaternion.identity);
    }
    void Update()
    {   if (Input.GetKeyDown(KeyCode.I)) {
            speed += 100;
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            speed=normalspeed;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            DestroyThing(worldCricle);
        }
        if (Input.GetKeyDown(KeyCode.T)) {
            spawnThing(myCricle);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rgd.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
        float x =  Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(x,0)*speed*Time.deltaTime;
        transform.Translate(movement);
    }
}

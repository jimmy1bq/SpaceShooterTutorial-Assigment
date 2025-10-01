using UnityEngine;
using UnityEngine.Windows;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Playerscript2 : MonoBehaviour
{
    float posY;
    [SerializeField] GameObject PlayerLaser1PreFab;
    [SerializeField] GameObject Explosion;
    [SerializeField] GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posY = transform.position.y;
    }
    // Update is called once per frame
    void Update()
    { 
        if (UnityEngine.Input.GetKey(KeyCode.A) && GameManager.instnace.GetBool() != true)
        {
            if (transform.position.x - 0.1f <= -4.9) {
                transform.position = new Vector3(-4.9f, posY, 0);
                }
            
            if (transform.position.x - 0.1f > -4.9) {
                transform.position += new Vector3(-0.1f, 0, 0);
            }
         }
        if (UnityEngine.Input.GetKey(KeyCode.D) && GameManager.instnace.GetBool() != true)
        {
          
            if (transform.position.x + 0.1f >= 4.9)
            {
                transform.position = new Vector3(4.9f, posY, 0);
            }
            if (transform.position.x - 0.1f < 4.9)
            {
                transform.position += new Vector3(0.1f, 0, 0);
            }
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.P) && GameManager.instnace.GetBool() != true)
        {
            if (GameManager.instnace.GetScore() >= 100)
            {
                Instantiate(PlayerLaser1PreFab, transform.position, Quaternion.identity);
                Instantiate(PlayerLaser1PreFab, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(PlayerLaser1PreFab, transform.position, Quaternion.identity);

            }
        }
    }
}

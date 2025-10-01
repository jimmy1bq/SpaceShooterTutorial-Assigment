using Unity.VisualScripting;
using UnityEngine;

public class cow : Animal
{
    [SerializeField] float moveSpeed;
    [SerializeField] string sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveSpeed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void MakeSound(string bsound)
    {
       base.MakeSound(bsound);
    }
    protected void Move(float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

using UnityEngine;

public class Animal : MonoBehaviour
{
    protected float moveSpeed;
    protected string sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void MakeSound(string bsound)
    {
        Debug.Log(bsound);
    }
    void Move(float speed)
    {
    }

}

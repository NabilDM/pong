using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        MoveObject(GetInput());
       
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }
    private void MoveObject(Vector2 movement)
    {
         transform.Translate(movement * Time.deltaTime);
    }
}
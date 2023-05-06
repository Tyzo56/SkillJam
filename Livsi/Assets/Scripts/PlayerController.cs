using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float inputX;
    Rigidbody rg;
    

    [SerializeField] private float movementSpeed;

    private void Start()
    {
        rg = transform.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        inputX = Input.GetAxis("Horizontal"); //получение ввода с клавиатуры

        Vector3 input2d = new Vector3(inputX, 0f, 0f); // значения в вектор

       Flip();
        Jump();
        Movement(input2d);
    }

    void Movement(Vector3 input)
    {
        transform.position += input * Time.deltaTime * movementSpeed; //перемещение
    }

   void Jump()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg.AddForce(transform.up, ForceMode.Impulse); //использует rigidbody чтобы добавить силу к объекту чтобы был прыжок
        }
    }
    void Flip()
    {

        if (inputX > 0)
        {
           // transform.localScale = new Vector3(-1f, 1.9f, 1f);
            transform.localRotation = Quaternion.Euler(0, 180f, 0);
        }
        else
        {
         //   transform.localScale = new Vector3(1f, 1.9f, 1f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

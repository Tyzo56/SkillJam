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
        inputX = Input.GetAxis("Horizontal"); //��������� ����� � ����������

        Vector3 input2d = new Vector3(inputX, 0f, 0f); // �������� � ������

        Jump();
        Movement(input2d);
    }

    void Movement(Vector3 input)
    {
        transform.position += input * Time.deltaTime * movementSpeed; //�����������
    }

   void Jump()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rg.AddForce(transform.up, ForceMode.Impulse); //���������� rigidbody ����� �������� ���� � ������� ����� ��� ������
        }
    }
}

using System.Collections;
using UnityEngine;
public class Mozog: MonoBehaviour
{
    public float rotationSpeed = 10;
    public float currentValue = Input.GetAxis("Horizontal");

    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.y += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; // Standart Left-/Right Arrows and A & D Keys

        if(Input.GetKeyUp(KeyCode.K))
        {
            rotation.y -= 90;
        }
        else if(Input.GetKeyUp(KeyCode.L))
        {
            rotation.y += 90;
        }

        transform.eulerAngles = rotation;
    }
}

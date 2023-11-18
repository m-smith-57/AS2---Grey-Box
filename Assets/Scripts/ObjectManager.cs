using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject Dog;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        Dog.transform.position = new Vector3(value, 1, 0);
    }

    public void MoveRight()
    {
        value = value + 0.1f;
        Dog.transform.position = new Vector3(value, 1, 0);
    }

    public void RotateLeft()
    {
        Dog.transform.Rotate(0f, 20f, 0f);
    }

    public void RotateRight()
    {
        Dog.transform.Rotate(0f, -20f, 0f);
    }

    public void Grow()
    {
        Dog.transform.localScale = Dog.transform.localScale + sizeChange;
    }

    public void Shirnk()
    {
        Dog.transform.localScale = Dog.transform.localScale - sizeChange;
    }

    public void ResetDog()
    {
        Dog.transform.position = new Vector3(0, 1, 0);
        Dog.transform.rotation = Quaternion.Euler(new Vector3(0, 168, 0));
        Dog.transform.localScale = new Vector3(1, 1, 1);
    }

}

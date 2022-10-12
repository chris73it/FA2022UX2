using UnityEngine;

public class WASD : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime), Space.Self);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime), Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
        }

    }
}

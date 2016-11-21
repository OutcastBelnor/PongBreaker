using UnityEngine;
using System.Collections;

public class PlayerTwo : MonoBehaviour
{
    private float moveSpeed;
    private float axis;
    private float movementValue;

    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            axis = Input.GetAxisRaw("Vertical");
            movementValue = moveSpeed * axis * Time.deltaTime;

            this.transform.Translate(0f, movementValue, 0f);
            this.transform.position = new Vector3(this.transform.position.x, Mathf.Clamp(this.transform.position.y, -4.4f, 4.4f), 0f);
        }
    }
}

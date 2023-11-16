using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;

    private void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        Vector3 moveDirection = new Vector3(xInput, yInput, 0f);

        transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime);
    }
}

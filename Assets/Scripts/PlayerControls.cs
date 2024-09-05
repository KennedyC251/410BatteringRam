using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using Unity.Mathematics;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControls : MonoBehaviour
{   
    public Rigidbody2D rb2D;
    public float speed;
    private float rotation;
    float speedX, speedY;
    public float rotationSpeed;
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * speed;
        speedY = Input.GetAxisRaw("Vertical") * speed;
        rb2D.velocity = new Vector2(speedX, speedY);
        if (Input.GetKey(KeyCode.Q))
        {
            rotation += Time.deltaTime * rotationSpeed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            rotation += -Time.deltaTime * rotationSpeed;
        }
        transform.rotation = Quaternion.Euler(0, 0, rotation);   
    }
}

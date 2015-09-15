using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

/// <summary>
/// Update is called before rendering a frame. This is where most game code goes.
/// FixedUpdate is called just before performing physics calculations. This is where our physics code goes.
/// </summary>
public class PlayerController : MonoBehaviour
{
    /// <remarks>
    /// Public member variables will show up as properties of the component (on the object, not the script itself)
    /// </remarks>
    public float speed;

    private Rigidbody _rb;

    /// <summary>
    /// Called on first frame script is active. Often the first frame of the game.
    /// </summary>
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.AddForce(movement * speed);
    }
}

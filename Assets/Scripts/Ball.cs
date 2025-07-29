using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;

    [SerializeField]
    Rigidbody rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var pos = (transform.forward + transform.right) * speed;
        rigidbody.AddForce(pos, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

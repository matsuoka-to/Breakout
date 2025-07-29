using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.position.x > -3.0f)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 3.0f)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
        }
    }
}

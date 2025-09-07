using UnityEngine;

public class simpleanimation : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.position += new Vector3(x, 0f, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Color newColor = new Color(Random.value, Random.value, Random.value);
            rend.material.color = newColor;
        }
    }
} 

using UnityEngine;
using UnityEngine.InputSystem;

public class KardInfoGet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 1.0f);
            if(hit.collider.tag == "Card")
            {
                Debug.Log("aaa");
            }
        }
    }
}

using UnityEngine;

public class Jump : MonoBehaviour
{

    public KeyCode key;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(key))
        {
            rb.velocity = new Vector2(0,5);
        }
        
    }
}

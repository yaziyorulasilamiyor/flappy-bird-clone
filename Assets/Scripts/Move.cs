using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    private void Start()
    {

        Destroy(gameObject, 8);
    }


    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}

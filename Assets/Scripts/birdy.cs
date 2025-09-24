using UnityEditor.Build.Content;
using UnityEngine;

public class birdy : MonoBehaviour
{
  public bool isDead;
  public float velocity = 1.0f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;
    public GameObject DeadScreen;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {   //tiklamay al
        if (Input.GetMouseButtonDown(0))
        {
            //hava kusu sicrat
            rb2D.linearVelocity = Vector2.up * velocity;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeadArea")
    isDead = true;
        Time.timeScale = 0;
        DeadScreen.SetActive(true);
     }
}

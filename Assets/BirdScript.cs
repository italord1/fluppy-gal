using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;

    public bool birdIsAlive = true; 
  
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;

        }
        if(transform.position.y > 17|| transform.position.y < -17)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}

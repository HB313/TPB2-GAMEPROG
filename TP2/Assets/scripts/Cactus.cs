using UnityEngine;

public class Cactus : MonoBehaviour
{   

    public CactusGenerator cactusGenerator;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * cactusGenerator.currentSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("spawner"))
        {
            cactusGenerator.GenerateRandomCactus();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Pour un clavier QWERTY, utilisez les touches WASD
        Vector3 movement = new Vector3(horizontal, vertical, 0f) * speed * Time.deltaTime;

        transform.Translate(movement);
    }
}

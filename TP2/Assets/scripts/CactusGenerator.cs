using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusGenerator : MonoBehaviour
{   
    public GameObject Cactus;

    public float MinSpeed;
    public float MaxSpeed;
    public float currentSpeed;

    public float SpeedMultiplier;
    
    // Start is called before the first frame update
    void Awake()
    {
        currentSpeed = MinSpeed;
        GenerateCactus();
    }

    public void GenerateRandomCactus()
    {
        float randomSpawn = Random.Range(0.1f, 1.2f);
        Invoke("GenerateCactus", randomSpawn);
    }
    void GenerateCactus()
    {
        GameObject CactusInstance = Instantiate(Cactus, transform.position, transform.rotation);
        CactusInstance.GetComponent<Cactus>().cactusGenerator = this;
    } 
    // Update is called once per frame
    void Update()
    {
        if (currentSpeed < MaxSpeed)
        {
            currentSpeed += SpeedMultiplier;
        }
    }
}

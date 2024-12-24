using UnityEngine;

public class ParticleManagement : MonoBehaviour
{
    public GameObject spawnGo;
    public GameObject circle1;
    public GameObject circle2;

    void Start()
    {
        float spreadBias = 400;

        for (int i = 0; i < 10; i++)
        {
            GameObject cir1 = Instantiate(circle1, spawnGo.transform);
            cir1.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
        }
        for (int i = 0; i < 500; i++)
        {
            GameObject cir1 = Instantiate(circle2, spawnGo.transform);
            cir1.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
        }
    }

    void Update()
    {
        
    }
}

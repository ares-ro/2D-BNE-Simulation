using UnityEngine;

public class ParticleManagement : MonoBehaviour
{
    public GameObject canvas;
    public GameObject circle1;
    public GameObject circle2;

    void Start()
    {
        float spreadBias = 400;

        for (int i = 0; i < 10; i++)
        {
            GameObject cir1 = Instantiate(circle1, canvas.transform);
            cir1.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
        }
        for (int i = 0; i < 1000; i++)
        {
            GameObject cir1 = Instantiate(circle2, canvas.transform);
            cir1.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
        }
    }

    void Update()
    {
        
    }
}

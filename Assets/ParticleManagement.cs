using System.Collections.Generic;
using UnityEngine;

public class ParticleManagement : MonoBehaviour
{
    static ParticleManagement instance;

    public GameObject spawnArea;
    public GameObject particle1;
    public GameObject particle2;

    List<GameObject> particles = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    public static void CreateParticle(float particle1Size, float particle1Mass, float particle2Size, float particle2Mass)
    {
        float spreadBias = 400;

        for (int i = 0; i < 10; i++)
        {
            GameObject particleBuffer = Instantiate(instance.particle1, instance.spawnArea.transform);
            instance.particles.Add(particleBuffer);
            particleBuffer.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
            particleBuffer.GetComponent<ParticleData>().Initialize(particle1Size, particle1Mass);
        }
        for (int i = 0; i < 1000; i++)
        {
            GameObject particleBuffer = Instantiate(instance.particle2, instance.spawnArea.transform);
            instance.particles.Add(particleBuffer);
            particleBuffer.transform.localPosition = new Vector2(Random.Range(-spreadBias, spreadBias), Random.Range(-spreadBias, spreadBias));
            particleBuffer.GetComponent<ParticleData>().Initialize(particle2Size, particle2Mass);
        }
    }

    public static void DestroyParticle()
    {
        foreach (GameObject particle in instance.particles)
        {
            Destroy(particle);
        }
    }
}

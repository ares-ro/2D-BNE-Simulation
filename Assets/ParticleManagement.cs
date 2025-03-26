using System.Collections.Generic;
using UnityEngine;

public class ParticleManagement : MonoBehaviour
{
    static ParticleManagement instance;

    public GameObject spawnArea;
    public GameObject shakeArea;
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

    public static void CreateParticle(float particle1Size, float particle1Mass, int particle1Count, float particle2Size, float particle2Mass, int particle2Count)
    {
        float randomSpawnWidth = instance.shakeArea.GetComponent<RectTransform>().rect.width / 2;
        float randomSpawnHeight = instance.shakeArea.GetComponent<RectTransform>().rect.height / 2;
        randomSpawnWidth -= (Mathf.Max(particle1Size, particle2Size) / 2) - 100;
        randomSpawnHeight -= (Mathf.Max(particle1Size, particle2Size) / 2) - 100;

        for (int i = 0; i < particle1Count; i++)
        {
            GameObject particleBuffer = Instantiate(instance.particle1, instance.spawnArea.transform);
            instance.particles.Add(particleBuffer);
            particleBuffer.transform.localPosition = new Vector2(Random.Range(-randomSpawnWidth, randomSpawnWidth), Random.Range(-randomSpawnHeight, randomSpawnHeight));
            particleBuffer.GetComponent<ParticleData>().Initialize(particle1Size, particle1Mass);
        }
        for (int i = 0; i < particle2Count; i++)
        {
            GameObject particleBuffer = Instantiate(instance.particle2, instance.spawnArea.transform);
            instance.particles.Add(particleBuffer);
            particleBuffer.transform.localPosition = new Vector2(Random.Range(-randomSpawnWidth, randomSpawnWidth), Random.Range(-randomSpawnHeight, randomSpawnHeight));
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

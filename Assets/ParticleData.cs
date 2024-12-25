using Unity.VisualScripting;
using UnityEngine;

public class ParticleData : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.localPosition.y < -1000)
        {
            Destroy(gameObject);
        }
    }

    public void Initialize(float size, float mass)
    {
        gameObject.GetComponent<CircleCollider2D>().radius = size / 2;
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(size, size);
        gameObject.GetComponent<Rigidbody2D>().mass = mass;
    }
}

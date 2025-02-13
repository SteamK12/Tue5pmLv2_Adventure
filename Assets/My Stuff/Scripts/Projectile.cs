using UnityEngine;

public class Projectile : MonoBehaviour
{
    int damage = 30;
    float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5)
        {
            Destroy(gameObject);
        }
    }

    public int DealDamage()
    {
        Destroy(gameObject);
        return damage;
    }
}

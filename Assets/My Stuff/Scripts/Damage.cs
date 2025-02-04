using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] Material damageMat;
    int health = 100;
    Material normalMat;
    MeshRenderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        normalMat = rend.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            print(other.name);
            health -= 10;
            StartCoroutine(DamageAnimation());
        }
    }

    IEnumerator DamageAnimation()
    {
        rend.material = damageMat;
        yield return new WaitForSeconds(0.1f);
        rend.material = normalMat;
    }
}

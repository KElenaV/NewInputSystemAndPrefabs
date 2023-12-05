using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ExplosionParticle : MonoBehaviour
{
    [SerializeField] private float _force = 300;
    [SerializeField] private float _lifeTime = 1f;

    private void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        float force = Random.Range(0, _force);
        Vector3 direction = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)).normalized;
        GetComponent<Rigidbody>().AddForce(direction * force);

        yield return new WaitForSeconds(_lifeTime);
        Destroy(gameObject);
    }
}

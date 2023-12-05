using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _shootForce = 100;
    [SerializeField] private Explosion _explosion;

    private float _lifeTime = 2f;

    private void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        Vector3 direction = new Vector3(Random.Range(-0.15f, 0.15f), Random.Range(-0.1f, 0.1f), 1).normalized;
        GetComponent<Rigidbody>().AddForce(direction * _shootForce, ForceMode.Impulse);

        yield return new WaitForSeconds(_lifeTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Wall wall))
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
        }
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ExplosionParticle[] _particles;
    [SerializeField] private int _amount;

    private float _offset = 0.4f;

    private void Start()
    {
        for (int i = 0; i < _amount; i++)
        {
            ExplosionParticle randomParticle = _particles[Random.Range(0, _particles.Length)];

            Vector3 randomPosition = new Vector3(
                Random.Range(-_offset, _offset),
                Random.Range(-_offset, _offset),
                Random.Range(-_offset, _offset));

            ExplosionParticle particle = Instantiate(randomParticle, transform.position + randomPosition, Quaternion.identity);
        }
    }

    //Method to invoke as InputAction Event
    //public void OnExplosion(InputAction.CallbackContext context)
    //{
    //    if (context.performed)
    //    {
    //        for (int i = 0; i < _amount; i++)
    //        {
    //            ExplosionParticle randomParticle = _particles[Random.Range(0, _particles.Length)];

    //            Vector3 randomPosition = new Vector3(
    //                Random.Range(-_offset, _offset), 
    //                Random.Range(-_offset, _offset), 
    //                Random.Range(-_offset, _offset));

    //            ExplosionParticle particle = Instantiate(randomParticle, transform.position + randomPosition, Quaternion.identity);
    //        }
    //    }
    //}
}

using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Colliders
{
    public class DeathTrigger : MonoBehaviour
    {
        private Collider _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerTag"))
            {
                ParticleSystem playerDeathParticle = other.gameObject.transform.GetChild(0).GetComponent<ParticleSystem>();
                var emission = playerDeathParticle.emission;

                emission.enabled = true;
                playerDeathParticle.Play();

                other.gameObject.GetComponent<MeshRenderer>().enabled = false;
                _collider.enabled = false;
                other.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}

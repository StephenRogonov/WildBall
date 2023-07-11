using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Colliders
{
    public class OffTrackDeathTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerTag"))
            {
                ParticleSystem playerDeathParticle = other.gameObject.transform.GetChild(1).GetComponent<ParticleSystem>();
                var emission = playerDeathParticle.emission;

                emission.enabled = true;
                playerDeathParticle.Play();

                other.gameObject.GetComponent<MeshRenderer>().enabled = false;
                other.gameObject.GetComponentInParent<Rigidbody>().isKinematic = true;
                gameObject.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
    }
}

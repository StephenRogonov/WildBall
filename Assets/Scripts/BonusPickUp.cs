using UnityEngine;

public class BonusPickUp : MonoBehaviour
{
    public ParticleSystem collisionParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTag"))
        {
            var emission = collisionParticleSystem.emission;
            var duration = collisionParticleSystem.main.duration;

            emission.enabled = true;
            collisionParticleSystem.Play();

            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Invoke(nameof(DestroyObj), duration);
        }
    }

    private void DestroyObj()
    {
        Destroy(gameObject);
    }
}

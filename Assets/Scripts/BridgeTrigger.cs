using UnityEngine;

namespace WildBall.Colliders
{
    public class BridgeTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerTag"))
            {
                gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().enabled = true;
            }
        }
    }
}

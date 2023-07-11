using UnityEngine;

namespace WildBall.Colliders
{
    public class DoorTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerTag") && !gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().enabled)
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(true);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("PlayerTag") && Input.GetKey(KeyCode.E))
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
                gameObject.transform.GetChild(0).gameObject.GetComponent<Animator>().enabled = true;
                gameObject.transform.GetChild(1).gameObject.GetComponent<Animator>().enabled = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("PlayerTag"))
            {
                gameObject.transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
}

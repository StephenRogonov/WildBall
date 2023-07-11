using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall.Colliders
{
    public class FinishTrigger : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerTag") && SceneManager.GetActiveScene().buildIndex == 5)
            {
                gameObject.transform.GetChild(1).gameObject.SetActive(true);
            }
            else
            {                
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}

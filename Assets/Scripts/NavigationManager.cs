using UnityEngine;
using UnityEngine.SceneManagement;

namespace WildBall
{
    public class NavigationManager : MonoBehaviour
    {
        public void OnChangeSceneButtonClick(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }

        public void OnRestartLevelButtonClick()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

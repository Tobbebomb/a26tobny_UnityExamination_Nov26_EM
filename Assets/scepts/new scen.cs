using UnityEngine;
using UnityEngine.SceneManagement;

public class newscen : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("load");
    }
}

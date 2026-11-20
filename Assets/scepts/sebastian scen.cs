using UnityEngine;
using UnityEngine.SceneManagement;

public class sebastianscen : MonoBehaviour
{
    public void MoveToScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("load");
    }
}
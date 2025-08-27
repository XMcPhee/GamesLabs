using Unity.Loading;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void ChangeScene(int level)
    {
        SceneManager.LoadScene(level);   
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingController : MonoBehaviour
{
    [SceneName]
    public string nextLevel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);

        yield return SceneManager.LoadSceneAsync(nextLevel);
    }
}

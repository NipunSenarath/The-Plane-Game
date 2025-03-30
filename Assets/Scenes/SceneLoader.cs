using UnityEngine;
using UnityEngine.SceneManagement;  // Required to manage scenes

public class SceneLoader : MonoBehaviour
{
    // Function to load the next scene based on the build index
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a next scene
        if (currentSceneIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }

public void LoadStart()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a next scene
        if (currentSceneIndex - 2 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex -2);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }

public void Loadthree()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a next scene
        if (currentSceneIndex + 3 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex + 3);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }

public void Loadminusthree()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a next scene
        if (currentSceneIndex - 3 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex - 3);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }



public void LoadCredit()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a next scene
        if (currentSceneIndex + 2 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(currentSceneIndex + 2);
        }
        else
        {
            Debug.Log("No more scenes to load!");
        }
    }


    // Function to load the previous scene based on the build index
    public void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Check if there's a previous scene
        if (currentSceneIndex - 1 >= 0)
        {
            SceneManager.LoadScene(currentSceneIndex - 1);
        }
        else
        {
            Debug.Log("This is the first scene. No previous scene.");
        }
    }
}

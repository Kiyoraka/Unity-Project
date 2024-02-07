using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public VideoPlayer videoPlayer;


    void Start()
    {
        // Subscribe to the loopPointReached event
        videoPlayer.loopPointReached += EndReached; 
        // Start playing the video
        videoPlayer.Play(); 
    }

    void EndReached(VideoPlayer vp)
    {
        //Go to the method 
        LoadLevel();

    }

    void LoadLevel()
    {
        //Go to The level Selection
        SceneManager.LoadSceneAsync(4);
    }
}

    

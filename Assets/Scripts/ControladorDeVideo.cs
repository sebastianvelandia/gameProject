using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ControladorDeVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start() {
        videoPlayer.loopPointReached += TerminarVideo;
    }

    private void TerminarVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene("Lobby Salon 1");
    }
}

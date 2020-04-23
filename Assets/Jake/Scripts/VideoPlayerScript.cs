using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerScript : MonoBehaviour
{
    [SerializeField] private VideoClip[] videos;
    private VideoPlayer vp;
    private int vidId = 0;
    private int sceneId = 0;
    private WaitForSeconds wfs = new WaitForSeconds(1);
    void Start()
    {
        vp = gameObject.GetComponent<VideoPlayer>();
        StartCoroutine(PlayVideoClip(vidId, sceneId));
    }

    IEnumerator PlayVideoClip(int vidId, int sceneId)
    {
        vp.clip = videos[vidId];
        while (!vp.isPrepared || vp.isPlaying)
        {
            yield return wfs;
        }

        SceneManager.LoadScene(sceneId);
    }

}

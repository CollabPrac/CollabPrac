using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{
  [SerializeField]
   private float delayBeforeLoading = 10f;
   [SerializeField]
   private string sceneNameToLoad;
   private float timeElaspsed;

    // Update is called once per frame
    private void Update()
    {
      timeElaspsed += Time.deltaTime;
      if (timeElaspsed > delayBeforeLoading)
      {
        SceneManager.LoadScene (sceneNameToLoad);
      }
    }
}

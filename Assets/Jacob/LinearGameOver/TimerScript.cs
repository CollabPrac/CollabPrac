using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	Image timerBar;
	public float maxTime = 5f;
	float timeRight;
	public GameObject timesUpImage;

    // Start is called before the first frame update
    void Start()
    {
		timesUpImage.SetActive (false);
		timerBar = GetComponent<Image> ();
		timeRight = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
		if (timeRight > 0) {
			timeRight -= Time.deltaTime;
			timerBar.fillAmount = timeRight / maxTime;
		} else {
			timesUpImage.SetActive (true);
			Time.timeScale = 0;
		}
    }
}

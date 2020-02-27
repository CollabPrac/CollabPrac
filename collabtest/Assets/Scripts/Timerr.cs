using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timerr : MonoBehaviour
{
	Image timerBar;
	public float maxTime = 5f;
	float timeRight;
	public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {
		timesUpText.SetActive (false);
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
			timesUpText.SetActive (true);
			Time.timeScale = 0;
		}
    }
}

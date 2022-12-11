using HectorRodriguez;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThirstIndicator : MonoBehaviour
{
    [SerializeField] Image image;
    [Tooltip("inMinutes")]
    [SerializeField] float Duration;
    [SerializeField] PlayerController PlayerController;
    float startTime;
    float currentTime;
    bool isTimerActive;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        currentTime = startTime;
        Duration *= 60;
        isTimerActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTimerActive) return;
        if (image.fillAmount >= 1)
        { PlayerController.SlowDown();
            isTimerActive=false;
            return;
        }
        currentTime += Time.deltaTime;
        image.fillAmount=(currentTime-startTime)/Duration;

    }
}

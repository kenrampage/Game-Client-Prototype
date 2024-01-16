using UnityEngine;

public class TimeManager : MonoBehaviour
{
    // Function to pause time
    public void PauseTime()
    {
        Time.timeScale = 0f;
    }

    // Function to resume time
    public void ResumeTime()
    {
        Time.timeScale = 1f;
    }

    // Function to set a custom time scale
    public void SetTimeScale(float newTimeScale)
    {
        Time.timeScale = Mathf.Clamp(newTimeScale, 0f, 1f);
    }

    // Function to reset time scale to normal (1.0)
    public void ResetTimeScale()
    {
        Time.timeScale = 1f;
    }
}

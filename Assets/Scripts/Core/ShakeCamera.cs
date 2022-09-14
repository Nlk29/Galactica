using UnityEngine;
using System.Collections;

public class ShakeCamera : MonoBehaviour 
{
    public Animation animation;

    private int shakeTime;

    public void shake(int time = 1)
    {
        shakeTime = time;
        animation.enabled = true;
        StartCoroutine(Delay());
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(shakeTime);

        animation.enabled = false;
    }
}

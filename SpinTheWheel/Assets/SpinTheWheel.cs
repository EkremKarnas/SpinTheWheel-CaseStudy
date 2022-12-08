using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinTheWheel : MonoBehaviour
{
    [SerializeField] AnimationCurve animationCurve;
    private bool isSpinning;
    [SerializeField] int spinningTime;
    [SerializeField] int spinningAngle;
    void Start()
    {
        isSpinning = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            StartCoroutine(SpinTheWheelFunc(spinningTime, spinningAngle));
        }
    }

    IEnumerator SpinTheWheelFunc(float time, float spinningAngle)
    {
        isSpinning = true;
        float timer = 0.0f;

        while (timer < time)
        {
            float angle = spinningAngle * animationCurve.Evaluate(timer / time);
            transform.eulerAngles = new Vector3(0f, 0f, angle);
            timer += Time.deltaTime;

            yield return null;
        }
        transform.eulerAngles = new Vector3(0f, 0f, spinningAngle);
        isSpinning = false;
    }
}

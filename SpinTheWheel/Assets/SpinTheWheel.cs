using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.SceneManagement;

public class SpinTheWheel : MonoBehaviour
{
    [SerializeField] AnimationCurve animationCurve;
    private bool isSpinning;
    [SerializeField] int spinningTime;
    [SerializeField] float spinningAngle;
    [SerializeField] DropDown dropdown;
    private float extraAngle;
    void Start()
    {
        ProbablityCalculator();
        spinningAngle = spinningAngle + (360 * Random.Range(3,5));
        spinningAngle = spinningAngle + extraAngle;

        Debug.Log(spinningAngle);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSpinning)
        {
            StartCoroutine(SpinTheWheelFunc(spinningTime, spinningAngle));
        }
    }

    public void ButtonFunc()
    {
        if(!isSpinning)
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

    void ProbablityCalculator()
    {
        var randomProbablity = Random.Range(1f, 100f);

        var probablityTreshold1 = dropdown.slot1DropProbablity;
        var probablityTreshold2 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity;
        var probablityTreshold3 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity;
        var probablityTreshold4 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity + dropdown.slot4DropProbablity;
        var probablityTreshold5 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity + dropdown.slot4DropProbablity + dropdown.slot5DropProbablity;
        var probablityTreshold6 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity + dropdown.slot4DropProbablity + dropdown.slot5DropProbablity + dropdown.slot6DropProbablity;
        var probablityTreshold7 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity + dropdown.slot4DropProbablity + dropdown.slot5DropProbablity + dropdown.slot6DropProbablity + dropdown.slot7DropProbablity;
        var probablityTreshold8 = dropdown.slot1DropProbablity + dropdown.slot2DropProbablity + dropdown.slot3DropProbablity + dropdown.slot4DropProbablity + dropdown.slot5DropProbablity + dropdown.slot6DropProbablity + dropdown.slot7DropProbablity + dropdown.slot8DropProbablity;


        if (randomProbablity < probablityTreshold1)
        {
            extraAngle = 0;
        }

        else if (randomProbablity >= probablityTreshold1 && randomProbablity < probablityTreshold2)
        {
            extraAngle = 45f;
        }

        else if (randomProbablity >= probablityTreshold2 && randomProbablity < probablityTreshold3)
        {
            extraAngle = 90;
        }

        else if (randomProbablity >= probablityTreshold3 && randomProbablity < probablityTreshold4)
        {
            extraAngle = 135;
        }

        else if (randomProbablity >= probablityTreshold4 && randomProbablity < probablityTreshold5)
        {
            extraAngle = 180;
        }

        else if (randomProbablity >= probablityTreshold5 && randomProbablity < probablityTreshold6)
        {
            extraAngle = 225;
        }

        else if (randomProbablity >= probablityTreshold6 && randomProbablity < probablityTreshold7)
        {
            extraAngle = 270;
        }

        else if (randomProbablity >= probablityTreshold7)
        {
            extraAngle = 315;
        }

    }
}

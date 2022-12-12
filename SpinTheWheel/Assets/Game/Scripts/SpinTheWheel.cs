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
    [SerializeField] ObjectTransporterAndUI objectTransporter;
    [SerializeField] DropDown dropdown;
    [SerializeField] GameObject takePrizesButton;
    [SerializeField] UI uI;
    private float extraAngle;
    private int itemNumber;
    private float randomProbablity;
    void Start()
    {
        takePrizesButton.SetActive(false);
    }

    void Update()
    {
    
    }

    public void SpinButtonFunc()
    {
        if (!isSpinning && !ObjectTransporterAndUI.IsPrizesTaken && !UI.IsGameOver)
        {
            takePrizesButton.SetActive(false);
            ProbablityCalculator();
            spinningAngle = spinningAngle + (360 * Random.Range(3, 5));
            spinningAngle = spinningAngle + extraAngle;
            StartCoroutine(SpinTheWheelFunc(spinningTime, spinningAngle));

            StartCoroutine(WaitAndMoveFunc());
            spinningAngle = 0;
        }
    }

    public void TakePrizesButton()
    {
        objectTransporter.TakePrizes();
    }

    IEnumerator SpinTheWheelFunc(float time, float spinningAngle)
    {
        isSpinning = true;
        float timer = 0.0f;
        float startAngle = transform.eulerAngles.z;
        spinningAngle = spinningAngle - startAngle;


        while (timer < time)
        {
            float angle = spinningAngle * animationCurve.Evaluate(timer / time);
            transform.eulerAngles = new Vector3(0f, 0f, angle + startAngle);
            timer += Time.deltaTime;

            yield return null;
        }
        transform.eulerAngles = new Vector3(0f, 0f, spinningAngle + startAngle);
        isSpinning = false;
    }

    IEnumerator WaitAndMoveFunc()
    {
        yield return new WaitForSeconds(spinningTime);
        var gameObject = dropdown.transformList[itemNumber].GetComponentInChildren<Rigidbody>().gameObject;

        if(gameObject.CompareTag("DeathCard"))
        {
            uI.GameOver();
        }

        if(!gameObject.CompareTag("DeathCard"))
        {
            objectTransporter.MoveObject(gameObject);
        }

        if(!UI.IsGameOver)
        takePrizesButton.SetActive(true);
    }

    void ProbablityCalculator()
    {
        randomProbablity = Random.Range(1f, 100f);

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
            itemNumber = 0;
        }

        else if (randomProbablity >= probablityTreshold1 && randomProbablity < probablityTreshold2)
        {
            extraAngle = 45f;
            itemNumber = 1;
        }

        else if (randomProbablity >= probablityTreshold2 && randomProbablity < probablityTreshold3)
        {
            extraAngle = 90;
            itemNumber = 2;
        }

        else if (randomProbablity >= probablityTreshold3 && randomProbablity < probablityTreshold4)
        {
            extraAngle = 135;
            itemNumber = 3;
        }

        else if (randomProbablity >= probablityTreshold4 && randomProbablity < probablityTreshold5)
        {
            extraAngle = 180;
            itemNumber = 4;
        }

        else if (randomProbablity >= probablityTreshold5 && randomProbablity < probablityTreshold6)
        {
            extraAngle = 225;
            itemNumber = 5;
        }

        else if (randomProbablity >= probablityTreshold6 && randomProbablity < probablityTreshold7)
        {
            extraAngle = 270;
            itemNumber = 6;
        }

        else if (randomProbablity >= probablityTreshold7)
        {
            extraAngle = 315;
            itemNumber = 7;
        }
    }
}

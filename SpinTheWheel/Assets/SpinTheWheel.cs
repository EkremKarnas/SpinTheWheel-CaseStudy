using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class SpinTheWheel : MonoBehaviour
{
    [SerializeField] AnimationCurve animationCurve;
    private bool isSpinning;
    [SerializeField] int spinningTime;
    [SerializeField] int spinningAngle;
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    [SerializeField] Transform slot1Transform,slot2Transform,slot3Transform,slot4Transform,slot5Transform,slot6Transform,slot7Transform,slot8Transform;
    [SerializeField] GameObject slot1Object,slot2Object,slot3Object,slot4Object,slot5Object,slot6Object,slot7Object,slot8Object;
    [SerializeField] List<GameObject> objList;
    [SerializeField] List<Transform> transformList;
    void Start()
    {
        
        if(transformList[0].gameObject.GetComponentInChildren<Rigidbody>().gameObject == objList[0])
        {
            Debug.Log("Yes");
        }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectTransporter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 startPos;
    [SerializeField] Vector3 targetPos;
    public static int ObjectCounter;
    void Start()
    {
        ObjectCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void MoveObject(GameObject gameObject)
    {
        var movedObject = Instantiate(gameObject, startPos, Quaternion.identity);
        movedObject.transform.DOMove(targetPos + (ObjectCounter * new Vector3(1,0,0)), 1f);
        ObjectCounter++;
    }
}

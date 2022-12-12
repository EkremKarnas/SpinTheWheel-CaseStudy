using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectTransporterAndUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 startPos;
    [SerializeField] Vector3 targetPos;
    [SerializeField] GameObject spinButton;
    [SerializeField] GameObject takePrizesButton;
    [SerializeField] GameObject restartGameButton;
    public static int ObjectCounter;
    public static bool IsPrizesTaken;
    public static bool IsGameOver;
    private List<GameObject> prizesList = new List<GameObject>();
    void Start()
    {
        ObjectCounter = 0;
        IsPrizesTaken = false;
    }

    void Update()
    {

    }

    public void MoveObject(GameObject gameObject)
    {
        var movedObject = Instantiate(gameObject, startPos, Quaternion.identity);
        prizesList.Add(movedObject);
        // movedObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        movedObject.transform.DOMove(targetPos + (ObjectCounter * new Vector3(1f, 0, 0)), 0.5f);
        ObjectCounter++;
    }

    public void TakePrizes()
    {
        if(UI.IsGameOver)
        return;

        for (int i = 0; i < prizesList.Count; i++)
        {
            prizesList[i].transform.DOMove(new Vector3(0,-6,0),0.5f);
            IsPrizesTaken = true;
        }

        spinButton.SetActive(false);
        takePrizesButton.SetActive(false);
        restartGameButton.SetActive(true);
    }

    public void DestroyObjects()
    {
        for (int i = 0; i < prizesList.Count; i++)
        {
            Destroy(prizesList[i]);
        }
        prizesList.Clear();
    }
}

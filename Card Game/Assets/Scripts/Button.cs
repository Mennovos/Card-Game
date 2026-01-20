using System.Collections;
using UnityEngine;

public class Button : MonoBehaviour
{
    private GameManger gameManger;
    protected GameObject MainUi;
    protected HandManager handManager;
    protected virtual void Start()
     {
        handManager = FindFirstObjectByType<HandManager>();
        gameManger = FindFirstObjectByType<GameManger>();
        MainUi = GameObject.Find("MainUI");
     }

    public virtual void Nexturn()
   {
        //handManager.DrawCards();
      gameManger.turnEnded = true;
        if (gameManger.turnEnded)
        {
           MainUi.SetActive(false);
        }
        handManager.maxHandSize++;
        Destroy(gameObject,0.1f);
    }
}

using System.Collections;
using UnityEngine;

public class Button : MonoBehaviour
{
    private GameManger gameManger;
    protected GameObject MainUi;
     protected virtual void Start()
     {
        gameManger = FindFirstObjectByType<GameManger>();
        MainUi = GameObject.Find("MainUI");
     }

    public virtual void Nexturn()
   {
      gameManger.turnEnded = true;
        if (gameManger.turnEnded)
        {
           Debug.Log("Turn Ended.");
           MainUi.SetActive(false);
        }
    }
}

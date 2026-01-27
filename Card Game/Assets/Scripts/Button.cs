using System.Collections;
using UnityEngine;

public class Button : MonoBehaviour
{
    protected GameManger gameManger;
    protected GameObject MainUi;
    protected HandManager handManager;
    private Vector3 Orginelscale;
    protected virtual void Start()
     {
        Orginelscale = transform.localScale;
        handManager = FindFirstObjectByType<HandManager>();
        gameManger = FindFirstObjectByType<GameManger>();
        MainUi = GameObject.Find("MainUI");
     }

    public virtual void Nexturn()
   {
      gameManger.turnEnded = true;
        if (gameManger.turnEnded)
        {
           MainUi.SetActive(false);
        }
        Destroy(gameObject,0.1f);
    }
    private void OnMouseOver()
    {
        transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
    }
    private void OnMouseExit()
    {
        transform.localScale = Orginelscale;
    }
}

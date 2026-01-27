using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public bool turnEnded = true;
    public bool CanTakecard = true;
    [SerializeField] private float waitTime = 10f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject MainUi;
    [SerializeField] private GameObject EnemyUi;
    [SerializeField] private GameObject Handmanger;
    private HandManager handManager;
    private Dragon dragon;
    private void Start()
    {
        dragon = FindFirstObjectByType<Dragon>();
        handManager = FindFirstObjectByType<HandManager>();
        for (int i = 0; i < 5; i++)
        {    
            handManager.DrawCards();
        }
    }
    private void Update()
    {
        if (turnEnded)
        {
            Check();
        }
    }
    protected void Check()
    {
      StartCoroutine(Waitime());
      turnEnded = false;
    }
    private IEnumerator Waitime()
    {
        dragon.PlayAttackAnimation();
        Handmanger.SetActive(false);
        EnemyUi.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        CanTakecard = true;
        player.GetComponent<Health>().TakeDamage(15f);
        EnemyUi.SetActive(false);
        Handmanger.SetActive(true);
        MainUi.SetActive(true);
    }
}

using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public bool turnEnded = true;
    [SerializeField] private GameObject player;
    [SerializeField] private float waitTime = 10f;
    [SerializeField] private GameObject MainUi;
    [SerializeField] private GameObject EnemyUi;
    [SerializeField] private GameObject Handmanger;

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
        Handmanger.SetActive(false);
        EnemyUi.SetActive(true);
        player.GetComponent<Health>().TakeDamage(15f);
        yield return new WaitForSeconds(waitTime);
        EnemyUi.SetActive(false);
        Handmanger.SetActive(true);
        MainUi.SetActive(true);
    }
}

using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
public class GameManger : MonoBehaviour
{
    public bool turnEnded = true;
    [SerializeField] private GameObject player;
    [SerializeField] private float waitTime = 10f;
    [SerializeField] private GameObject MainUi;
    [SerializeField] private GameObject EnemyUi;

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
        EnemyUi.SetActive(true);
        player.GetComponent<Health>().TakeDamage(15f);
        yield return new WaitForSeconds(waitTime);
        EnemyUi.SetActive(false);
        MainUi.SetActive(true);
    }
}

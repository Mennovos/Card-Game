using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
public class GameManger : MonoBehaviour
{
    public bool turnEnded = true;
    [SerializeField] private GameObject player;
    [SerializeField] private float waitTime = 10f;
    [SerializeField] private GameObject MainUi;

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
        player.GetComponent<Health>().TakeDamage(10f);
        yield return new WaitForSeconds(waitTime);
        MainUi.SetActive(true);

    }
}

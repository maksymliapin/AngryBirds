using Game;
using Settings;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePig : MonoBehaviour
{
    protected int basePigPoints = 100;
    protected float basePigArmor;
    protected const float timeDestroyBlast = 2.0f;
    [SerializeField] private DataSettings settings;
    [SerializeField] private GameObject blast;
    private bool isPigDied;
    private void Awake()
    {
        basePigArmor = settings.pigArmor;
        GameHelper.instance.numberPigs++;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > basePigArmor && isPigDied == false)
        {
            DestroyPig();
        }
    }
    private void DestroyPig()
    {
        isPigDied = true;
        Destroy(gameObject);
        GameHelper.instance.score += basePigPoints;
        GameHelper.instance.deadPigCounter++;
        var bang = Instantiate(blast, transform.position, Quaternion.identity);
        Destroy(bang, timeDestroyBlast);
    }
}

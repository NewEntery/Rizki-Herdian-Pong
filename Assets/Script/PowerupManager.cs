using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerupAmount;
    public int spawnInterfal;
    public Vector2 powerUpareamin;
    public Vector2 powerUpareamax;
    public List<GameObject> poweruptemplateList;

    
    private List<GameObject> poweruplist;

    private float timer;
    private void Start()
    {
        poweruplist = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterfal)
        {
            Generaterandompowerup();
            timer -= spawnInterfal;
        }
    }

    public void Generaterandompowerup()
    {
        Generaterandompowerup(new Vector2(Random.Range(powerUpareamin.x, powerUpareamax.x), Random.Range(powerUpareamin.y, powerUpareamax.y) ));
    }

    public void Generaterandompowerup(Vector2 position)
    {
        

        if (poweruplist.Count >= maxPowerupAmount)
        {
            return;
        }

        if (position.x < powerUpareamin.x ||
            position.x > powerUpareamax.x ||
            position.y < powerUpareamin.y ||
            position.y > powerUpareamax.y)
        {
            return;
        }

        int randomIndex = Random.Range(0, poweruptemplateList.Count);

        GameObject powerUp = Instantiate(poweruptemplateList[randomIndex], position, Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        poweruplist.Add(powerUp);
    }

    public void Removepowerup(GameObject powerUp)
    {
        poweruplist.Remove(powerUp);
        Destroy(powerUp);
            
    }
    public void RemoveAllPowerup()
    {
        while (poweruplist.Count > 0)
        {
            Removepowerup(poweruplist[0]);
        }
    }
}

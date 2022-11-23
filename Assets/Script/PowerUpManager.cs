using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

   public Transform spawnArea;
   public int maxPowerUpAmount;
   public int spawnInterval;
   public Vector2 powerUpAreaMin;
   public Vector2 powerUpAreaMax;
   public List<GameObject> powerUpTempLateList;
   public AudioSource audioPlayer;

   private List<GameObject> powerUpList;

   private float timer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "SpeedUp"){
         audioPlayer.Play();
      }
    }
   private void Start()
   {
        powerUpList = new List<GameObject>();
        timer = 0;
   }

   private void Update()
   {
        timer += Time.deltaTime;

        if (timer > spawnInterval )
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
   }

   public void GenerateRandomPowerUp()
   {
        GenerateRandomPowerUp(new Vector2(Random.Range(powerUpAreaMin.x, powerUpAreaMax.x), Random.Range(powerUpAreaMin.y, powerUpAreaMax.y)));

   }

   public void GenerateRandomPowerUp(Vector2 position)
   {

        Debug.Log("Test");
        
        if (powerUpList.Count > maxPowerUpAmount)
        {
            return;
        }

        if (position.x < powerUpAreaMin.x ||
            position.x > powerUpAreaMax.x ||
            position.y < powerUpAreaMin.y ||
            position.y > powerUpAreaMax.y )
            {
                return;
            }
            
            int randomIndex = Random.Range(0, powerUpTempLateList.Count);

            GameObject powerUp = Instantiate(powerUpTempLateList[randomIndex], position, Quaternion.identity, spawnArea);
            powerUp.SetActive(true);

            powerUpList.Add(powerUp);

   }

   public void RemovePowerUp(GameObject powerUp)
    {
        powerUpList.Remove(powerUp);
        Destroy(powerUp);
    }
 public void RemoveAllPowerUp()
   {
        while (powerUpList.Count > 0)
        {
            RemovePowerUp(powerUpList[0]);
        }
        
   }


}

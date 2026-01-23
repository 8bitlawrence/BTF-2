using System.IO.Compression;
using UnityEngine;

public class FruitRolling : MonoBehaviour
{
    private bool playerInRange = false;

    [Header("Fruit Settings")]
    public string[] fruits;
    public FruitRarity[] FruitRarities;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            RollFruit();
        }
    }

    void RollFruit()
    {
        FruitRarity chosenRarity = RollRarity();
        if (chosenRarity = null || fruits.Length == 0)
        {
            Debug.Log("No fruits available to roll.");
            return;

            

            //add an inventory for fruits later
        }

        else
        {
            int fruitIndex = Random.Range(0, chosenRarity.fruits.Length);
            string fruit = chosenRarity.fruits[fruitIndex];

            Debug.Log($"Rolled {chosenRarity.RarityName}: {fruit}");
        }   

    }

    public FruitRarity RollRarity()
    {
        float totalChance = 0f;
        foreach (var rarity in FruitRarities)
            totalChance += FruitRarity.rarity;
        float roll = Random.Range(0, totalChance);
        float current = 0f;

        foreach (var rarity in FruitRarities)
        {
            current += rarity.chance;
            if (roll <= current)
            {
                return rarity;
            }

        }

        return null;
        

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player entered fruit rolling area");
        }
    }
}
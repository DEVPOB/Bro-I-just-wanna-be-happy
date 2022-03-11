using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAIManager : MonoBehaviour
{
    public List<WeightedValue> weightedValues;
    public GameObject NormalFriend_Ai;
    public GameObject RunningFriend_Ai;
    public GameObject MuscleGuy_Ai;
    public GameObject GuyInfrontofDoor_Ai;
    public GameObject FBI_Ai;
    public Transform[] SpawnPoint;
    void Start()
    {
            StartCoroutine(test());

    }
    void Update()
    {
    }
    IEnumerator test()
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            RandomSpawning();
            yield return new WaitForSeconds(30);
            RandomSpawning();

        }
    }
    void RandomSpawning()
    {
        string randomValue = GetrandomValue(weightedValues);
        switch (randomValue)
        {
            case "NormalFriend_AI":
                Instantiate(NormalFriend_Ai, SpawnPoint[0].position, Quaternion.identity);
                break;
            case "GuyInFrontOfDoor_Ai":
                Instantiate(GuyInfrontofDoor_Ai, SpawnPoint[1].position, Quaternion.identity);
                break;
            case "RunnerFriend_Ai":
                Instantiate(RunningFriend_Ai, SpawnPoint[3].position, Quaternion.identity);
                break;
            case "GuyWithMuscle_Ai":
                Instantiate(MuscleGuy_Ai, SpawnPoint[2].position, Quaternion.identity);
                break;
            case "FBI_Ai":
                Instantiate(FBI_Ai, SpawnPoint[4].position, Quaternion.identity);
                break;
        }

    }
    string GetrandomValue(List<WeightedValue> weightedValuelist)
    {
        string output = null;
        // Getting a random weight value
        var totalweight = 0;
        foreach (var entry in weightedValuelist)
        {
            totalweight += entry.weight;
        }
        var rndweightValue = Random.Range(1, totalweight + 1);
        // checking  where random weight value fall
        var processedWeight = 0;
        foreach (var entry in weightedValuelist)
        {
            processedWeight += entry.weight;
            if (rndweightValue <= processedWeight)
            {
                output = entry.value;
                break;
            }
        }

        return output;
    }


}

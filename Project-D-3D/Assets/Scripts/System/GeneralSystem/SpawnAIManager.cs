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
    public Transform SpawnPoint1;
    void Start()
    {

    }
    void Update()
    {
        /**
            * TODO : Do it in 3/6/2022 (cause i'm lazy bye)
        **/
        string randomValue = GetrandomValue(weightedValues);
        switch (randomValue)
        {
            case "NormalFriend_AI":
                Instantiate(NormalFriend_Ai,SpawnPoint1.position,Quaternion.identity);
                break;
            case "GuyInFrontOfDoor_Ai":
                // 
                break;
            case "RunnerFriend_Ai":
                // 
                break;
            case "GuyWithMuscle_Ai":
                // 
                break;
            case "FBI_Ai":
                // 
                break;
        }
        // if (randomValue == "NormalFriend_AI")
        // {
        //     print("TEST");
        // }
        // else if (randomValue == "GuyInFrontOfDoor_Ai")
        // {

        // }
        // else if (randomValue == "")
        // print(randomValue ?? "No entries found");

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

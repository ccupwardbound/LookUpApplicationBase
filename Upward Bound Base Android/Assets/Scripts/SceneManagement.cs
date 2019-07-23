using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public Text NameOfItem;
    public Text BackgroundInfo;
    public Text Address;
    public Text City;
    public Text State;
    public Text ZIP;
    public Text Title;
    public GameObject InfoCanvas;
    public GameObject Instructions;

    public List<ItemInfo> ItemInfos;

    // Start is called before the first frame update
    void Start()
    {
        //var dataAsString = GatherData.GetDataAsStringFromJsonFile(GatherData.GetFilePath());
        //ItemInfos = GatherData.GetDeserializedData(dataAsString);

        ItemInfos = GatherData.GetDeserializedData(GatherData.GetTextAsset().text);

        NameOfItem.text = "this is the name of an item";
        BackgroundInfo.text = "this is background info";
        Address.text = "this is the address";
        City.text = "this is the city";
        State.text = "this is the state";
        ZIP.text = "this is the zip";
        Title.text = "This is what you are looking at!";

        InfoCanvas.SetActive(false);
        Instructions.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        var ThingWeFound = DefaultTrackableEventHandler.ThingWeFound;
        if (!string.IsNullOrEmpty(ThingWeFound) || !string.IsNullOrWhiteSpace(ThingWeFound))
        {
            foreach (var item in ItemInfos)
            {
                if (item.ID.Equals(ThingWeFound))
                {
                    NameOfItem.text = item.Name;
                    BackgroundInfo.text = item.Description.BackgroundInfo;
                    Address.text = item.Description.Location.Address;
                    City.text = item.Description.Location.City;
                    State.text = item.Description.Location.State;
                    ZIP.text = item.Description.Location.ZIP;
                    break;
                }
            }
            Debug.Log("ThingWeFound: " + ThingWeFound);
            ThingWeFound = "";
            InfoCanvas.SetActive(true);
            Instructions.SetActive(false);
        }
        else
        {
            Debug.Log("Nothing here ;)");
            InfoCanvas.SetActive(false);
            Instructions.SetActive(true);

        }

    }
}

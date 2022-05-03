using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ResourcesUIGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject resourceUIPanelPrefab;
    void Start()
    {

        foreach(var item in ResourcesFacory.CreateAllResources())
        {
            GameObject resourceUIPanel = Instantiate(resourceUIPanelPrefab, transform);
            resourceUIPanel.name = item.Name;
            resourceUIPanel.GetComponentInChildren<TextMeshProUGUI>().text = item.Amount + (item.MaxAmount == 0? "" : "/" + item.MaxAmount);
            Debug.Log(resourceUIPanel.transform.Find("Icon").GetComponent<Image>().sprite);
            resourceUIPanel.transform.Find("Icon").GetComponent<Image>().sprite = Resources.Load<Sprite>(item.pathToIconSprite);
            Debug.Log(resourceUIPanel.transform.Find("Icon").GetComponent<Image>().sprite);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

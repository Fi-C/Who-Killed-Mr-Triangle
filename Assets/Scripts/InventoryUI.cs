using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform contentPanel;

    public void Refresh()
    {
        foreach (Transform child in contentPanel)
            Destroy(child.gameObject);

        foreach (var item in Inventory.Instance.items)
        {
            GameObject btn = Instantiate(buttonPrefab, contentPanel);

            btn.GetComponentInChildren<Text>().text = item.itemName;

            btn.GetComponent<Button>().onClick.AddListener(() =>
            {
                Inventory.Instance.SelectItem(item);
            });
        }
    }
}
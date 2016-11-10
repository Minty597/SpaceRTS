using UnityEngine;
using System.Collections;

public class S_SelectUnitMenuDisplay : MonoBehaviour {

    public delegate void OpenUnitselectMenuDelegate();

    public static event OpenUnitselectMenuDelegate OnOpenUnitMenu;

	void Awake () {
        S_UnitSelectMenu.OnCloseUnitSelectMenu += new S_UnitSelectMenu.CloseUnitSelectMenuDelegate(ShowButton);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Display()
    {
        if (OnOpenUnitMenu != null)
        {
            OnOpenUnitMenu.Invoke();
            this.gameObject.SetActive(false);
        }
    }

    private void ShowButton()
    {
        this.gameObject.SetActive(true);
    }


}

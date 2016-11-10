using UnityEngine;
using System.Collections;

public class S_UnitSelectMenu : MonoBehaviour {

    public delegate void CloseUnitSelectMenuDelegate();

    public static event CloseUnitSelectMenuDelegate OnCloseUnitSelectMenu;

    public bool StartHiden;

	// Use this for initialization
	void Awake () 
    {
        S_SelectUnitMenuDisplay.OnOpenUnitMenu += new S_SelectUnitMenuDisplay.OpenUnitselectMenuDelegate(Show);

        if (StartHiden)
            this.gameObject.SetActive(!StartHiden);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    private void Show()
    {
        this.gameObject.SetActive(true);
    }

    private void Hide()
    {
        this.gameObject.SetActive(false);
    }


    #region unity button events
    public void CancelButtonClick()
    {
        if (OnCloseUnitSelectMenu != null)
        {
            OnCloseUnitSelectMenu.Invoke();
            Hide();
        }
    }
    private void UnitSelectButtonClicked()
    {
        this.Hide();
    }
    #endregion 
}

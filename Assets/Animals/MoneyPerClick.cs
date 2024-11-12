using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoneyPerClick : MonoBehaviour, IPointerClickHandler
{
	public IntStorage MoneyPerClickValue = new IntStorage();
	public IncomeResource IncomeMoney = new IncomeResource(0, 0);
	public GameObject Barn;
	public Barn BarnScript;
	public IncomeResource MoneyFromPanda = new IncomeResource(0, 0);


	public event Action OnChange;



	public void Start()
	{
		Barn = GameObject.Find("Àלבאנ");
		BarnScript = Barn.GetComponent<Barn>();
		BarnScript.Spawn += UpdateData;

	}

	public void UpdateData()
	{
		MoneyPerClickValue.ChangeValue(0);
		for (int i = 0; i < BarnScript.Animals.Count; i++)
		{
			MoneyPerClickValue.SetValue(BarnScript.Animals[i].GetComponent<AnimalMoney>().IncomeMoney.Resource.GetValue(), true);
		}

		IncomeMoney.IncomePerClickValue = MoneyPerClickValue.GetValue();

		OnChange?.Invoke();
	}

	public void IncomePerClick()
	{
		IncomeMoney.IncomePerClick();
		OnChange?.Invoke();
	}

	public void OnPointerClick(PointerEventData data)
	{
		IncomePerClick();
	}
}

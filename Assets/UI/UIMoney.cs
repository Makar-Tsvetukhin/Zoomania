using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIMoney : MonoBehaviour
{
	public GameObject Animal;
	public TextMeshProUGUI Text;
	public MoneyPerClick animalmoneyscript;

	void Start()
	{
		Animal = GameObject.Find("Деньги");
		Text = this.gameObject.GetComponent<TextMeshProUGUI>();
		Text.text += " 0";

		animalmoneyscript = Animal.GetComponent<MoneyPerClick>();
		animalmoneyscript.OnChange += UpdateUI;
	}

	public void UpdateUI()
	{
		if (Animal == null)
		{
			Animal = GameObject.Find("Панда");
			animalmoneyscript = Animal.GetComponent<MoneyPerClick>();
		}
		Text.text = $"Количество монет: {animalmoneyscript.IncomeMoney.Resource.GetValue()}";
	}
}
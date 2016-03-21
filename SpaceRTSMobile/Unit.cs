using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour 
{

	struct Weapon
	{
		enum WEAPON_TYPE
		{
			SLUG,
			LASER,
			PLASMA
		}
	};

	struct Player
	{

	};

	List<Weapon> weaponsList = new List<Weapon>();
	int weaponsMaxNumber;

	float shieldsMax;
	float shieldsCurrent;

	float healthMax;
	float healthCurrent;

	Player ownerOfThis;

	void Start()
	{
		healthCurrent = healthMax;
		shieldsCurrent = shieldsMax;

	}
}

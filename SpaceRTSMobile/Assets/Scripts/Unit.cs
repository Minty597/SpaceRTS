using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Unit : MonoBehaviour 
{

	struct Weapon // Weapons placeholder
	{
		enum WEAPON_TYPE
		{
			SLUG,
			LASER,
			PLASMA
		}
	};

	struct Player // Players placeholder
	{

	};

	List<Weapon> weaponsList = new List<Weapon>(); // List of the weapons currently on the unit
	int weaponsMaxNumber; // Max number of weapons a unit can hold

	float shieldsMax; // The units maximum shields power
	float shieldsCurrent; // The current shield power the unit has
	float shieldRegenPerSec; // The amount of shields the unit regains each second

	float healthMax; // The units maximum health
	float healthCurrent;// The current amount of health the unit has

	Player ownerOfThis; // The player who owns the unit

	void Start()
	{
		healthCurrent = healthMax;
		shieldsCurrent = shieldsMax;

	}
}

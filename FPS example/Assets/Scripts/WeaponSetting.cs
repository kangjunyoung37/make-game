public enum WeaponName { AssaultRifle = 0,Revolver,CombatKnife,HandGrenade}
[System.Serializable]
public struct WeaponSetting
{
    public WeaponName weaponName;
    public int damage;
    public int currentMagazine;
    public int maxMagazine;
    public int currentAmmo;
    public int maxAmmo;
    public float attackRate;
    public float attackDistance;
    public bool inAutomaticeAttack;


}


using WynncraftSharp.Common;
using WynncraftSharp.Common.Item;

namespace WynncraftSharp.Items;

public class Item : IItem
{
    public string Name { get; internal set; }
    public string Tier { get; internal set; }
    public string Set { get; internal set; }
    public ushort Sockets { get; internal set; }
    public string Type { get; internal set; }
    public string ArmorType { get; internal set; }
    public string ArmorColor { get; internal set; }
    public string AddedLore { get; internal set; }
    public string Material { get; internal set; }
    public string DropType { get; internal set; }
    public string Restrictions { get; internal set; }
    public string Damage { get; internal set; }
    public string FireDamage { get; internal set; }
    public string WaterDamage { get; internal set; }
    public string AirDamage { get; internal set; }
    public string ThunderDamage { get; internal set; }
    public string EarthDamage { get; internal set; }
    public string AttackSpeed { get; internal set; }
    public int Health { get; internal set; }
    public short FireDefense { get; internal set; }
    public short WaterDefense { get; internal set; }
    public short AirDefense { get; internal set; }
    public short ThunderDefense { get; internal set; }
    public short EarthDefense { get; internal set; }
    public short Level { get; internal set; }
    public string Quest { get; internal set; }
    public string ClassRequirement { get; internal set; }
    public short Strength { get; internal set; }
    public short Dexterity { get; internal set; }
    public short Intelligence { get; internal set; }
    public short Ability { get; internal set; }
    public short Defense { get; internal set; }
    public short HealthRegen { get; internal set; }
    public short ManaRegen { get; internal set; }
    public short SpellDamage { get; internal set; }
    public short DamageBonus { get; internal set; }
    public short LifeSteal { get; internal set; }
    public short ManaSteal { get; internal set; }
    public short XpBonus { get; internal set; }
    public short LootBonus { get; internal set; }
    public short Reflection { get; internal set; }
    public short StrengthPoints { get; internal set; }
    public short DexterityPoints { get; internal set; }
    public short IntelligencePoints { get; internal set; }
    public short AbilityPoints { get; internal set; }
    public short DefensePoints { get; internal set; }
    public short Thorns { get; internal set; }
    public short Exploding { get; internal set; }
    public short Speed { get; internal set; }
    public short AttackSpeedBonus { get; internal set; }
    public short Poison { get; internal set; }
    public short HealthBonus { get; internal set; }
    public short SoulPoints { get; internal set; }
    public short EmeraldStealing { get; internal set; }
    public int HealthRegenRaw { get; internal set; }
    public int SpellDamageRaw { get; internal set; }
    public int DamageBonusRaw { get; internal set; }
    public short BonusFireDamage { get; internal set; }
    public short BonusWaterDamage { get; internal set; }
    public short BonusAirDamage { get; internal set; }
    public short BonusThunderDamage { get; internal set; }
    public short BonusEarthDamage { get; internal set; }
    public short BonusFireDefense { get; internal set; }
    public short BonusWaterDefense { get; internal set; }
    public short BonusAirDefense { get; internal set; }
    public short BonusThunderDefense { get; internal set; }
    public short BonusEarthDefense { get; internal set; }
    public string AccessoryType { get; internal set; }
    public bool Identified { get; internal set; }
    public string Skin { get; internal set; }
    public string Category { get; internal set; }
}
namespace DnDSpellMaker
{
    public class Spell
    {
        string name;
        string flavour;

        int totalEnergyCost;
        
        HashSet<Effect> effects;
        Tradition tradition;
    }

    //effects are the mechanical and practical results of the spell, the damage it deals and any impact it has on the world
    public class Effect
    {
        string name;
        int energyCost;

        //normalEffect;

        //determines how an effect applies such as what targets can be hit or how long an Effect lasts
        //requirement;

    }

    public class Trigger
    {
        string name;

    }



    public class Tradition
    {
        string name;
    }
}
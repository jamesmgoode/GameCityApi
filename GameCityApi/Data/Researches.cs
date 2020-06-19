using GameCityApi.Models.NineIsles;

namespace GameCityApi.Data
{
    public class Researches
    {
        public static Research Mills() => new Research
        {
            Name = "Mills",
            Description = "May build mills which improve farm efficiency by +0.2",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research WindPonyRiding() => new Research
        {
            Name = "Wind Pony Riding",
            Description = "Ride wind ponies",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research Archery() => new Research
        {
            Name = "Archery",
            Description = "Damage 3 bows",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research CropRotation() => new Research
        {
            Name = "Crop Rotation",
            Description = "+0.1 farm efficiency",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research HorseArchers() => new Research
        {
            Name = "Horse Archers",
            Description = "Increase attack with bows by 2 while mounted, may spend a tactics point to move and shoot on a turn",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research MilitaryShields() => new Research
        {
            Name = "Military Shields",
            Description = "Sets base quality of all shields produced to Q3",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research ArcheryTowers() => new Research
        {
            Name = "Archery Towers",
            Description = "+1 Defense for troops in the towers and for 10BP you can construct defensive towers along your walls that consume 5 bows a year but will generate bow armed militia when the settlement is attacked",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research TextileMaking() => new Research
        {
            Name = "Textile Making",
            Description = "+1Q to all textiles",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research SkySaddles() => new Research
        {
            Name = "Sky Saddles",
            Description = "",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research AnimalHusbandry() => new Research
        {
            Name = "Animal Husbandry",
            Description = "+10% animal growth",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research LocalFlora() => new Research
        {
            Name = "Local Flora",
            Description = "You discover two local plants you can use",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research CelestialCartography() => new Research
        {
            Name = "Celestial Cartography",
            Description = "Allows you to calculate your rough distance to another god if they share their map with you and plus 0.1 research efficiency tribe wide",
            ResearchType = ResearchType.Culture,
            Level = 1
        };

        public static Research SilverWorking() => new Research
        {
            Name = "Silver Working",
            Description = "All items made from Silver are at +1Q including silver ore",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research Carts() => new Research
        {
            Name = "Carts",
            Description = "Allows you to construct carts to carry goods more efficiently",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research Longbows() => new Research
        {
            Name = "Longbows",
            Description = "Produces base Q6 Long Bows that have attack 6 and can attack at Range 9",
            ResearchType = ResearchType.Military,
            Level = 2
        };

        public static Research ImprovedLibraries() => new Research
        {
            Name = "Improved Libraries",
            Description = "",
            ResearchType = ResearchType.Culture,
            Level = 1
        };

        public static Research MagicalTheory() => new Research
        {
            Name = "Magical Theory",
            Description = "1% of your population become mages. This can either be a new specialist group or part of an existing specialist group.",
            ResearchType = ResearchType.Magic,
            Level = 1
        };

        public static Research MagicalTradition() => new Research
        {
            Name = "Magical Tradition",
            Description = "You may choose a magical tradition to be the path of magics practiced (psionics)",
            ResearchType = ResearchType.Magic,
            Level = 1
        };

        public static Research TouchTheMind() => new Research
        {
            Name = "Touch the Mind",
            Description = "Your casters are now able to cast the touch the mind spell which allows them to see another creatures surface thoughts. This can be used as a weapon in trick and convince conflicts.",
            ResearchType = ResearchType.Magic,
            Level = 1
        };

        public static Research Catapults() => new Research
        {
            Name = "Catapults",
            Description = "A 5BP siege engine produced at a workshop requiring a crew of 5 people. It is a D8 dice versus structures and D6 versus troops and has a base attack of 5 and range 4.",
            ResearchType = ResearchType.Military,
            Level = 1
        };

        public static Research Telescopes() => new Research
        {
            Name = "Telescopes",
            Description = "Allows you to produce a telescope workshop that will require 20 workers that will produce 5 telescopes which can be used as equipment for a +1 to scouting rolls and 5 lenses which produce wealth.",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research WitchsHut() => new Research
        {
            Name = "Witch's Hut",
            Description = "A 10 BP building that will mean you gain +20% population growth from rolls.",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research Currency() => new Research
        {
            Name = "Currency",
            Description = "Increase trade power with anyone you share a currency with.",
            ResearchType = ResearchType.Economic,
            Level = 1
        };

        public static Research PhilosopherGenerals() => new Research
        {
            Name = "Philosopher Generals",
            Description = "For every three culture technologies your society has gain +1 tactics point in a battle",
            ResearchType = ResearchType.Culture,
            Level = 1
        };

        public static Research ArcaneOrrery() => new Research
        {
            Name = "Arcane Orrery",
            Description = "10 BP building that gives a bonus D10 to examining magical artefacts",
            ResearchType = ResearchType.Magic,
            Level = 1
        };

        public static Research Telepathy() => new Research
        {
            Name = "Telepathy",
            Description = "A spell that allows mental communication between casters",
            ResearchType = ResearchType.Magic,
            Level = 1
        };
    }
}

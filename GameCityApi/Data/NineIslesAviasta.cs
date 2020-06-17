using GameCityApi.Models.NineIsles;
using System.Collections.Generic;

namespace GameCityApi.Data
{
    public class NineIslesAviasta
    {
        public static NineIslesData GetNineIslesData() => new NineIslesData
        {
            Settlements = new List<Settlement>
            {
                new Settlement
                {
                    Name = "Aviasta",
                    Buildings = new List<Building>
                    {
                        new Building
                        {
                            Name = "Training Yard",
                            Description = "+50% XP Per Person who trains here",
                            BuildPoints = 10,
                            WorkersRequired = 0
                        },
                        new Building
                        {
                            Name = "Stone Walls",
                            Description = "Stone fortifications to protect 500 people",
                            BuildPoints = 50,
                            WorkersRequired = 0
                        },
                        new Building
                        {
                            Name = "Shield Makers' Workshop",
                            Description = "Produces 10 shields per year",
                            BuildPoints = 10,
                            WorkersRequired = 10
                        }
                    }
                },
                new Settlement
                {
                    Name = "Seltbey",
                    Buildings = new List<Building>
                    {
                        new Building
                        {
                            Name = "Bowyers' Workshop",
                            Description = "Produces longbows",
                            BuildPoints = 20,
                            WorkersRequired = 20
                        }
                    }
                }
            },
            ResearchData = new List<Research>
            {
                Researches.Mills(),
                Researches.WindPonyRiding(),
                Researches.Archery(),
                Researches.CropRotation(),
                Researches.HorseArchers(),
                Researches.MilitaryShields(),
                Researches.ArcheryTowers(),
                Researches.TextileMaking(),
                Researches.AnimalHusbandry(),
                Researches.LocalFlora(),
                Researches.CelestialCartography(),
                Researches.SilverWorking(),
                Researches.Carts(),
                Researches.Longbows(),
                Researches.ImprovedLibraries(),
                Researches.MagicalTheory(),
                Researches.MagicalTradition(),
                Researches.TouchTheMind(),
                Researches.Catapults(),
                Researches.Telescopes(),
                Researches.WitchsHut(),
                Researches.Currency(),
                Researches.PhilosopherGenerals(),
                Researches.ArcaneOrrery(),
                Researches.Telepathy()
            }
        };
    }
}

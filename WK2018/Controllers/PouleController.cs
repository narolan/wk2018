﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WK2018.Models;
using WK2018.Models.PouleViewModels;

namespace WK2018.Controllers
{
    public class PouleController : Controller
    {
        public IActionResult Index()
        {
            List<Team> teams = new List<Team>()
            {
                new Team
                {
                    Naam = "België",
                    PouleID = 1,
                }
                ,
                new Team
                {
                    Naam = "Frankrijk",
                    PouleID = 1,
                },
                 new Team
                {
                    Naam = "Ierland",
                    PouleID = 1,
                },
                  new Team
                {
                    Naam = "Spanje",
                    PouleID = 1,
                }
            };

            List<Poule> poules = new List<Poule>()
            {
                new Poule
                {
                    ID= 1,
                    Naam= 'A',
                    Teams = teams
                }
            };

            //TODO sort by score then by name

            return View(poules);
        }

        public IActionResult Detail(int id)
        {
            List<Team> teams = new List<Team>()
            {
                new Team
                {
                    Naam = "België",
                    PouleID = 1,
                }
                ,
                new Team
                {
                    Naam = "Frankrijk",
                    PouleID = 1,
                },
                 new Team
                {
                    Naam = "Ierland",
                    PouleID = 1,
                },
                  new Team
                {
                    Naam = "Spanje",
                    PouleID = 1,
                }
            };

            Poule poule = new Poule
            {
                ID = 1,
                Naam = 'A',
                Teams = teams
            };

            DetailViewModel vm = new DetailViewModel();

            vm.Poule = poule;

            return View(vm);
        }
    }
}
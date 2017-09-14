using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Declencheurs.Models;

namespace Declencheurs.Services
{
    public static class DeclencheursService
    {
        private static IEnumerable<Declencheur> AllOrders()
        {
            // The following is order summary data
            var data = new ObservableCollection<Declencheur>
            {
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
                new Declencheur
                {
                    DeclencheursId = 70,
                    Nom = "Declencheur1",
                    Heure = "12:13",
                    Composant = "WIFI",
                    Repetition = "Lundi",
                    Son = "Bird",
                    IntervalRepetition = "50 minutes"
                },
            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Declencheur>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllOrders();
        }
    }
}

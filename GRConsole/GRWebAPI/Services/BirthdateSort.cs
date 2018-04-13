﻿using System.Collections.Generic;
using DBLibrary.Services;
using DBLibrary.Model;

namespace DBWebAPI.Services
{
    public class BirthdateSort : SortSelector
    {
        private ISortService _sortService;
        public BirthdateSort(ISortService sortService)
        {
            _sortService = sortService;
        }

        public override IList<Person> GetGersons(IList<Person> unsortedList, string sortBy)
        {
            IList<Person> persons = new List<Person>();
            if (sortBy.Contains(DBWebAPI.Model.Constants.Birthdate))
            {
                persons = _sortService.SortByBirthDateAscending(unsortedList);
            }
            return persons;
        }
    }
}

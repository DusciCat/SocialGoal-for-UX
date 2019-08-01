using System;
using System.Collections.Generic;

namespace SocialGoal
{
    public class Iterator
    {
        private List<string> _list = new List<string>();
        public void Execute(int amount)
        {
            _list.Add("This is the first string to add.");

            for (var i = 0; i < amount; i++)
            {
                _list.Add($"This is item {i+1}/{amount} with id {Guid.NewGuid()}.");
            }

            _list.Add("This is the last string to add.");
        }
    }
}
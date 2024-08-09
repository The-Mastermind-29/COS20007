﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2P_Iteration_2
{
    public class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();
        public IdentifiableObject(string[] idents)
        {
            _identifiers = idents.ToList();
        }

        public bool AreYou(string id)
        {
            for (int i = 0; i < _identifiers.Count; i++)
            {
                string x = _identifiers[i];
                if (x == id.ToLower())
                    return true;
            }
            return false;

        }

        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                    return "";
                return _identifiers[0];
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}

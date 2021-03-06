﻿using System;
using Newtonsoft.Json;

namespace CanasUvighi
{
    public class Terrain
    {
        private int id;
        private string 
            name,
            visual;
        private bool 
            isTransparent,
            isBlocked;

        //private delegate void Effect(Unit unit);

        #region Constructors
        public Terrain(int id, string name, string visual, bool isTransparent, bool isBlocked)
        {
            this.id = id;
            this.name = name;
            this.visual = visual;
            this.isTransparent = isTransparent;
            this.isBlocked = isBlocked;
        }
        #endregion

        #region Properties
        public int Id
        { 
            get{ return this.id; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Visual
        {
            get { return this.visual; }
        }

        public bool IsTransparent 
        {
            get { return this.isTransparent; }
            set { this.isTransparent = value; }
        }

        public bool IsBlocked
        {
            get { return this.isBlocked; }
        }
        #endregion
    }
}

﻿using GameStore.Abstrack;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

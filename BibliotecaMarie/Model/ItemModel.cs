﻿using BibliotecaMarie.Controller.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace BibliotecaMarie.Model
{
    public class ItemModel
    {
        public int id;
        public string name;
        public int idStatus;
        public int idType;
        public Imagem imagem;
        
        //public int classification;

    }
}
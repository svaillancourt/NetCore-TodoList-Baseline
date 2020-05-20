﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext ( DbContextOptions<ToDoContext> options ) : base( options )
        {

        }
        public DbSet<ToDoItem> ToDoItem { get; set; }
    }
}

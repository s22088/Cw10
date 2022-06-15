﻿using System;

namespace Ex10.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        //[DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
    }
}

﻿using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public int TotalPages { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public int GenerId { get; set; }
        public Author Author { get; set; } = null!;
        public Publisher Publisher { get; set; } = null!;
        public Gener Genre { get; set; } = null!;

        // ** New Lines ends here ** //

        // Columns not mapped to the DB

        [NotMapped]
        public string? AuthorName { get; set; }
        [NotMapped]
        public string? PublisherName { get; set; }
        [NotMapped]
        public string? GenreName { get; set; }

        [NotMapped]
        public List<SelectListItem>? AuthorList { get; set; }
        [NotMapped]
        public List<SelectListItem>? PublisherList { get; set; }
        [NotMapped]
        public List<SelectListItem>? GenreList { get; set; }
    }
}

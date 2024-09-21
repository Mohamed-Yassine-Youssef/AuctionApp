using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace AuctionApp.Models;

public class Listing
{
 public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsSold { get; set; } = false;

        [Required] //listing cannot exist without a user).
        public string? IdentityUserId { get; set; } //The ? means that the property can be null, but with [Required] applied, it must always have a value.
        [ForeignKey("IdentityUserId")] //The [ForeignKey("IdentityUserId")] attribute tells Entity Framework Core that the User property refers to the user whose ID is stored in IdentityUserId.
        public IdentityUser? User { get; set; } //IdentityUser is a class provided by the ASP.NET Core Identity system to manage users, roles, and claims in the system.

        public List<Bid>? Bids { get; set; } //This establishes a one-to-many relationship between the Listing and Bid models, where a listing can have multiple bids.
        public List<Comment>? Comments { get; set; }
}

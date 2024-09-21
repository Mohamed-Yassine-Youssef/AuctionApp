using System;
using AuctionApp.Models;
using Microsoft.EntityFrameworkCore;
namespace AuctionApp.Data;

public class ApplicationDbContext : DbContext
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

public DbSet<Listing> Listings { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Comment> Comments { get; set; }
}

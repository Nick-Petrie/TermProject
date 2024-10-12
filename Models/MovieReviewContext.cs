using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class MovieReviewContext : DbContext
    {
        public MovieReviewContext(DbContextOptions<MovieReviewContext> options)
            : base(options)
        {
        }

        public DbSet<MovieReview> MovieReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data for the MovieReview table
            modelBuilder.Entity<MovieReview>().HasData(
                new MovieReview
                {
                    Id = 1,
                    MovieTitle = "Inception",
                    ReviewerName = "Nick",
                    Rating = 9,
                    ReviewText = "A brilliant, mind-bending thriller!"
                },
                new MovieReview
                {
                    Id = 2,
                    MovieTitle = "The Matrix",
                    ReviewerName = "Jon",
                    Rating = 10,
                    ReviewText = "An absolute sci-fi classic!"
                }
            );
        }
    }
}
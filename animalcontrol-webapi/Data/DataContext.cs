using System.Collections.Generic;
using animalcontrol_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace animalcontrol_webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        {

        }        

        public DbSet<Animal> Animals {get; set;}
        public DbSet<Owner> Owners {get; set;}
        public DbSet<LearningTopic> LearningTopics {get; set;}
        public DbSet<AnimalLearning> AnimalLearnings {get; set;}

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<AnimalLearning>()
                .HasKey(AL => new { AL.AnimalId, AL.LearningTopic});
            
            builder.Entity<Owner>()
                .HasData(new List<Owner>(){
                    new Owner(1, "Antonio", "Rua Dr", "9-18h"),
                    new Owner(2, "Susana", "Praceta Iv", "9-18h"),
                });

            builder.Entity<LearningTopic>()
                .HasData(new List<LearningTopic>(){
                    new LearningTopic(1, "Food", "Teach pet eating rules", 1),
                    new LearningTopic(2, "Walk", "Teach pet how to walk on leash", 2),
                    new LearningTopic(3, "Sit", "Teach pet how to sit", 3),
                    new LearningTopic(4, "Tricks", "Teach awesome tricks", 4)
                });

            builder.Entity<Animal>()
                .HasData(new List<Animal>(){
                    new Animal(1, "Ciri", "Cirigatas", 1204151, 3),
                    new Animal(2, "Bali", "BaliWally", 1204151, 1),
                    new Animal(3, "Flake", "Flakinho", 1204151, 5),
                    new Animal(4, "Diesel", "N/A", 1204151, 5)
                });

            builder.Entity<AnimalLearning>()
                .HasData(new List<AnimalLearning>(){
                    new AnimalLearning() { AnimalId = 1, LearningTopicId = 1 },
                    new AnimalLearning() { AnimalId = 1, LearningTopicId = 2 },
                    new AnimalLearning() { AnimalId = 1, LearningTopicId = 3 },
                    new AnimalLearning() { AnimalId = 1, LearningTopicId = 4 },
                    new AnimalLearning() { AnimalId = 2, LearningTopicId = 1 },
                    new AnimalLearning() { AnimalId = 2, LearningTopicId = 2 },
                    new AnimalLearning() { AnimalId = 2, LearningTopicId = 3 },
                    new AnimalLearning() { AnimalId = 2, LearningTopicId = 4 },                
                    new AnimalLearning() { AnimalId = 3, LearningTopicId = 1 },
                    new AnimalLearning() { AnimalId = 3, LearningTopicId = 2 },
                    new AnimalLearning() { AnimalId = 3, LearningTopicId = 3 },
                    new AnimalLearning() { AnimalId = 3, LearningTopicId = 4 },
                    new AnimalLearning() { AnimalId = 4, LearningTopicId = 1 },
                    new AnimalLearning() { AnimalId = 4, LearningTopicId = 2 },
                    new AnimalLearning() { AnimalId = 4, LearningTopicId = 3 },
                    new AnimalLearning() { AnimalId = 4, LearningTopicId = 4 }                    
                });
        }
    }
}
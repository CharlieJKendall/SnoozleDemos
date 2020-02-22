using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Snoozle;
using Snoozle.SqlServer;
using System;

namespace SnoozleDemos.RestResources
{
    public class Cat : IRestResource
    {
        public int? Id { get; set; }
        public long? HairLength { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeLastUpdated { get; set; }
    }

    public class CatResourceConfiguration : SqlResourceConfigurationBuilder<Cat>
    {
        public override void Configure()
        {
            ConfigurationForModel().HasTableName("Cats").HasAllowedHttpVerbs(HttpVerbs.All).HasRoute("Catters");

            ConfigurationForProperty(x => x.DateTimeCreated).HasComputedValue().DateTimeNow(HttpVerbs.POST);
            ConfigurationForProperty(x => x.DateTimeLastUpdated).HasComputedValue().DateTimeNow();
            ConfigurationForProperty(x => x.Name).HasColumnName("CatName");
        }
    }

    public class CatValidator : AbstractValidator<Cat>
    {
        public CatValidator()
        {
            RuleFor(x => x.HairLength).NotNull();
            RuleFor(x => x.Name).NotNull();
        }
    }

    public class CatEntityConfiguration : IEntityTypeConfiguration<Cat>
    {
        public void Configure(EntityTypeBuilder<Cat> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Cats");

            builder.Property(x => x.DateTimeCreated).IsRequired();
            builder.Property(x => x.DateTimeLastUpdated).IsRequired();
            builder.Property(x => x.HairLength).IsRequired();
            builder.Property(x => x.Name).HasColumnName("CatName").IsRequired();
        }
    }
}

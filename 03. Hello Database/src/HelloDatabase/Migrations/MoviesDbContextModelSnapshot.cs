using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using HelloDatabase.DataAccess;

namespace HelloDatabase.Migrations {

  [DbContext( typeof( MoviesDbContext ) )]
  partial class MoviesDbContextModelSnapshot : ModelSnapshot {

    protected override void BuildModel( ModelBuilder modelBuilder ) {
      modelBuilder
          .HasAnnotation( "ProductVersion", "1.0.0-rtm-21431" );

      modelBuilder.Entity( "HelloDatabase.Model.Category", b =>
           {
             b.Property<Guid>( "Id" )
                      .ValueGeneratedOnAdd( );

             b.Property<string>( "Name" );

             b.HasKey( "Id" );

             b.ToTable( "Categories" );
           } );

      modelBuilder.Entity( "HelloDatabase.Model.Movie", b =>
           {
             b.Property<Guid>( "Id" )
                      .ValueGeneratedOnAdd( );

             b.Property<Guid?>( "CategoryId" );

             b.Property<string>( "Director" );

             b.Property<TimeSpan>( "Length" );

             b.Property<int>( "Rating" );

             b.Property<string>( "Title" );

             b.HasKey( "Id" );

             b.HasIndex( "CategoryId" );

             b.ToTable( "Movies" );
           } );

      modelBuilder.Entity( "HelloDatabase.Model.Movie", b =>
           {
             b.HasOne( "HelloDatabase.Model.Category", "Category" )
                      .WithMany( "Movies" )
                      .HasForeignKey( "CategoryId" );
           } );
    }

  }

}
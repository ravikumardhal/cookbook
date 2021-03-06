﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Webproject.Models;

namespace Webproject.Migrations
{
    [DbContext(typeof(WebprojectContext))]
    [Migration("20180720044800_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Webproject.Models.Tweet.Post", b =>
                {
                    b.Property<string>("TweetID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tweet");

                    b.Property<string>("UserId");

                    b.Property<bool>("istweet");

                    b.HasKey("TweetID");

                    b.ToTable("Post");
                });
#pragma warning restore 612, 618
        }
    }
}

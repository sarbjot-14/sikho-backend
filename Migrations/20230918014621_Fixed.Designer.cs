﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sikho_backend.Models;

#nullable disable

namespace sikho_backend.Migrations
{
    [DbContext(typeof(APIDbContext))]
    [Migration("20230918014621_Fixed")]
    partial class Fixed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("image_link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("video_link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("website_link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IndustryId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IndustryId = 1,
                            image_link = "https://lh3.googleusercontent.com/J0ugh3MHXa6tgOeXoP0aS27NCHNURCHOl-bTqgLW2R8ACZFn2FxwTJWn9DGHA4tG7h6zvxiZrndU_HKwzXpJDbDvSrqQJWR3ItKz5fud=rw-w2880-e365",
                            name = "Waymo",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/uKfAJDEkstg",
                            website_link = "https://waymo.com/"
                        },
                        new
                        {
                            Id = 2,
                            IndustryId = 1,
                            image_link = "https://images.ctfassets.net/95kuvdv8zn1v/5o4wKdIkXUT7V2WZQciD9b/9007ad36565c4b0f4600a42f96b0adc5/brand_assets_icon_f3f5f8_bg.png?fit=fill&f=center&fm=jpg",
                            name = "Cruise",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/HfcAsfmYbUA",
                            website_link = "https://getcruise.com/"
                        },
                        new
                        {
                            Id = 3,
                            IndustryId = 2,
                            image_link = "data:image/png;base64,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",
                            name = "Blendid",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/-ZxkN-Ikb9Q",
                            website_link = "https://www.blendid.com/"
                        },
                        new
                        {
                            Id = 4,
                            IndustryId = 2,
                            image_link = "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAllBMVEX///8gGzEbFS0dGC/8/P0ZEywcFi6vrrZFQ1IAAB/5+foVDimysbgbFi3z8vYYESthX2uNi5X09PU1MULn5+lWU2BAPUw6NkYRCSZwbnkuKjzb295QTVspJTm/vsR5d4HQz9SYlqDFxMqFg42lpKtcWmcNACTk4+hpZ3PNy9LW1dqgn6d8e4UAABYkHzRKSFUAAAAAAAtGAaxdAAAHXUlEQVR4nO2ca3eqOhCGgQS0EVHkKgoqogh26zn//88dsNbtJdMi0hLOmmft/amaldeZzCRhBklCEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARpCtr2BC5Q+vG/6TFZs0O+gjGLdD2eNTQjVg6oFwOmohjRiNcbz7KsjbmcNDEemyVTpxjPG6+WQmg03t3BSCOEjNT5qgkz5rvQV4vxtIF2jBoY71Xs6UCVz2iHsfHSYAaTWNQn5HNAxY0bmmZ92NS/zEeWiX98TaJkRMHo73iyGrQuMQ6uBBZsx7Y0qemr1JBo5Kk34w12zc73aYzFrUCZWFP7heH0o3I3XttGXPZvf3JZHgbrWfGHWlGVRfM7gTIJk4an/CS6dWfDMtws7JoK4/nwfjSZvLeb+JPwQaF8kM1ajmpEzr0Fyx9s+mLsehGeQpnIpiE9P6/cvff4EmXRrg1j99GvConb9fMC44AnUJbNdhXOHP60/phPSjQyb8QbiAQtb2uMNVdgkcfKtVh1V1kcJJZH/k+lHGc/KuD7ud1n/E+0QyGxqh3pZAn4grxd/ej8K8AWPn9qw3BlV84Zyw0g0N+0G0lLUm/An5wSmpMKbmoUnwEtOAqyn1fwLXYASBweqoSbQmAOrMFCYOv77hNL0IpWpYiaOsD3R5YQAo0vbKCEFfJiHgArWT0dDttfhyVL3nbrJDH4egNHKcvG0HePukBXURkkkVirr+IpNWZTDbBgX/+16VchOnJ3JKWr7UErFtpnO5mfT0eeSBaUGGPLPhAu5CCBlhKT8ikgUA1ikQSerm8jC7DiyO3x0mJ51ZGOCSDQ6pWfMYRSKS0twIpE6/G/YWxUwEWtnljazkRQ0tBkrkTjuOV/XnV1IW6CH6CRA8RFJbyfMpUm6RjIg8RLmEiPZa6J53yvk1Xv1u3oREqngMXPnxUj09/DojlkRfcu+M+mQJBR3ETINXiGRSGQ+rX+tURmQwKJL1QefIQufcBRh5fwUfhfOtWAg7OfUEEd9ESZv3Qf2md6521YIWEMpAniixtk/hKFUAg5nJOGcQSiqHZIRFd3Qvegw5SsS5RJ9gbIg5q1EthBr6C6CzhqkQhSe7kDfgAS7MUOMn+hiQUdpoL5HIy2YWnBjmic6KBEBYgxsqaeziAdUShJCZDuQLSh2Ykgc4GuhsDuBrDt0GykjuMXofsDEFB4KIfOCSzDjadU9dSP25xuealUHqbGYSVPJf7HnrUbufCGfOUevtVI/GAtxMVvHagRrYO30RciiboNp4IfJr6AFTO3lyvH8n1fUZXHf/42cMzY7tz6u/BRkMnSOHlfuP1H3EUSp6cQyjq4BG+hlPHorvEQBEEQ5GkotbMej8xuukvjtymnz+zIdMLwjUfYd1aZzaQOHpzOTCSW7x1/O4Ju8NWRYm32KatXbysCaWLJwJPhi8rBsNDY9kRrwuIddHN4wyDcRV00IjX0fsVrDKK5ZgfNSBPocp+DZq07J9HeH6p46MWM20XHJNL9c/elsvw27ZRE9vSddyHR6ZDESRJAzy0Gigouz/eWS7qrUwQZsOxkapoPnT8X9V1x1EkCPj+0evZkkjtQIU34/kJX2O9hgI/WymfAJakHSZQ7kTTAgpPLc3wphQoZid9yD1AVwFqMkfe3JDZ1oAeloicNSiOonoZY10WYM6jusliLQu9RDR1KE7c1UZKUgxIHa4HDDYMLTVz97o47H0MlGVa99sVfoDhNcDsI5XO94V0MyaA2i0KioGuR6h6UJh7qS8uPp30oaVhrQ8hnNRHQIgnVCEuZC1V/BWsRk8byDdqNQXXehaOCv0kj759oEipFb0CaGLhwa0i2gdai/C7U/RulRvzQmP85V++ruvvM4X+rcFS4E6UFKI35Xbzf9r7QeA5ZMTAn4lwYs9iBdjJfWlAqJYItUy7YbPP7ZFABO9nqlH0TMzJwG+QJU9MO9h+Sf6Aoek22hSKqJUbJsJGDPaR+FYGlFcGi4pUIEnOo30kNexUfuYCBWBvuf3j2FQB7udXyuFQxVsRwy1TrFWFgP75s7auHQs6Lac6MNm0fFzPgnQpKaD7x/JMyqPqdhNXW8s+xOnAVFieg5357Bt1fqeN2j1KzDX9e/z5fta0r3KGUfrsrcTbnhQjy1quxHelxU3/bL4riKlRks9ZgOndzq7abMLgKg1X1F7dcQ3se751MLSt83Der9buXioj6kFyJ1e6bB+zFw4wOq7oHu2KT3ntIGsRZNjnh50nusgVR6t8FFvnTeHTU95bPUPTuBPvnxctOqv97cxJTrbyhmdYmvn5XpfZW4zVmtxi962Yb1RJg6x0Hn++2GJJQf92ljF7weeFPlFCIlsR8FwwG6mAw8KaNvNXJyHbB6DRisBHhHbQFM309ne92ZtRUTEh1c7ebT9e6OLf7zM7TZi//7DS3RXDQn+V/rdCgEjVEuKNBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEARBEOT3+Q9mmXHvkK4GYAAAAABJRU5ErkJggg==",
                            name = "Cafe X",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/E-b1GiQZ7jM",
                            website_link = "https://cafexapp.com/"
                        },
                        new
                        {
                            Id = 5,
                            IndustryId = 2,
                            image_link = "data:image/png;base64,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",
                            name = "Artly The Barista Bot",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/D8LSqdaORH4",
                            website_link = "https://artly.coffee/"
                        },
                        new
                        {
                            Id = 6,
                            IndustryId = 2,
                            image_link = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSz77AAnmUdEh0TSaIkhSPp5QAzeSGdxsen3w&usqp=CAU",
                            name = "Makr Shakr",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/fcScX-pFMkU",
                            website_link = "https://www.makrshakr.com/"
                        },
                        new
                        {
                            Id = 7,
                            IndustryId = 2,
                            image_link = "data:image/png;base64,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",
                            name = "RC Coffee",
                            type = 2,
                            video_link = "https://www.youtube.com/embed/JEQambkCuVw",
                            website_link = "https://www.rccoffee.com/"
                        });
                });

            modelBuilder.Entity("sikho_backend.Models.DataPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double?>("cost")
                        .HasColumnType("float");

                    b.Property<string>("cost_source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("units")
                        .HasColumnType("int");

                    b.Property<string>("units_source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("DataPoints");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            units = 10000,
                            units_source = "https://techcrunch.com/2022/02/10/fewer-autonomous-vehicle-companies-in-california-drive-millions-more-miles-in-testing/ ",
                            year = 2020
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            units = 30000,
                            units_source = "https://techcrunch.com/2022/02/10/fewer-autonomous-vehicle-companies-in-california-drive-millions-more-miles-in-testing/ ",
                            year = 2021
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            cost = 30.0,
                            cost_source = "https://www.emergingtechbrew.com/stories/2021/07/16/spent-two-days-riding-waymos-driverless-taxis-felt-surprisingly-normal",
                            units = 40000,
                            units_source = "https://techcrunch.com/2022/02/10/fewer-autonomous-vehicle-companies-in-california-drive-millions-more-miles-in-testing/ ",
                            year = 2022
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 2,
                            cost_source = "https://www.theverge.com/2022/6/23/23180156/cruise-driverless-vehicle-charge-riders-san-francisco",
                            units_source = "https://www.theverge.com/2023/1/31/23579426/cruise-waymo-cpuc-trips-growth-robotaxi-sf ",
                            year = 2020
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 2,
                            cost_source = "https://www.theverge.com/2022/6/23/23180156/cruise-driverless-vehicle-charge-riders-san-francisco",
                            units_source = "https://www.theverge.com/2023/1/31/23579426/cruise-waymo-cpuc-trips-growth-robotaxi-sf ",
                            year = 2021
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 2,
                            cost = 20.0,
                            cost_source = "https://www.theverge.com/2022/6/23/23180156/cruise-driverless-vehicle-charge-riders-san-francisco",
                            units = 2783,
                            units_source = "https://www.theverge.com/2023/1/31/23579426/cruise-waymo-cpuc-trips-growth-robotaxi-sf ",
                            year = 2022
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 3,
                            units = 3,
                            units_source = "https://www.sec.gov/Archives/edgar/data/1830909/000147793223001263/sixdbytes_1k.html",
                            year = 2020
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 3,
                            units = 3,
                            units_source = "https://www.sec.gov/Archives/edgar/data/1830909/000164460023000042/BlendidARandFinancials2.pdf",
                            year = 2021
                        },
                        new
                        {
                            Id = 9,
                            CompanyId = 3,
                            units = 9,
                            units_source = "https://www.startengine.com/offering/blendid ",
                            year = 2022
                        },
                        new
                        {
                            Id = 21,
                            CompanyId = 4,
                            units = 2,
                            units_source = "https://cafexapp.com/ ",
                            year = 2020
                        },
                        new
                        {
                            Id = 10,
                            CompanyId = 4,
                            units = 2,
                            units_source = "https://cafexapp.com/ ",
                            year = 2021
                        },
                        new
                        {
                            Id = 11,
                            CompanyId = 4,
                            units = 3,
                            units_source = "https://cafexapp.com/ ",
                            year = 2022
                        },
                        new
                        {
                            Id = 12,
                            CompanyId = 5,
                            cost = 0.0,
                            cost_source = "https://www.startengine.com/offering/artly",
                            units = 0,
                            units_source = "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment",
                            year = 2020
                        },
                        new
                        {
                            Id = 13,
                            CompanyId = 5,
                            cost = 10000.0,
                            cost_source = "https://www.startengine.com/offering/artly",
                            units = 3,
                            units_source = "https://www.businesswire.com/news/home/20220926005763/en/Artly-the-Friendly-Barista-Bot-is-Coming-to-a-Neighborhood-Near-You-Having-Closed-Its-Series-Pre-A-Investment ",
                            year = 2021
                        },
                        new
                        {
                            Id = 14,
                            CompanyId = 5,
                            cost = 101000.0,
                            cost_source = "https://www.startengine.com/offering/artly ",
                            units = 9,
                            units_source = "https://www.startengine.com/offering/artly",
                            year = 2022
                        },
                        new
                        {
                            Id = 15,
                            CompanyId = 6,
                            cost_source = "https://www.startengine.com/offering/artly ",
                            units_source = "https://www.makrshakr.com/locations ",
                            year = 2020
                        },
                        new
                        {
                            Id = 16,
                            CompanyId = 6,
                            cost = 101000.0,
                            cost_source = "https://www.startengine.com/offering/artly ",
                            units = 12,
                            units_source = "https://www.makrshakr.com/locations ",
                            year = 2021
                        },
                        new
                        {
                            Id = 17,
                            CompanyId = 6,
                            units = 14,
                            units_source = "https://www.makrshakr.com/locations ",
                            year = 2022
                        },
                        new
                        {
                            Id = 18,
                            CompanyId = 7,
                            units = 1,
                            units_source = "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market",
                            year = 2021
                        },
                        new
                        {
                            Id = 19,
                            CompanyId = 7,
                            units = 10,
                            units_source = "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market",
                            year = 2022
                        },
                        new
                        {
                            Id = 20,
                            CompanyId = 7,
                            units = 10,
                            units_source = "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market",
                            year = 2020
                        });
                });

            modelBuilder.Entity("sikho_backend.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cost_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("revenue_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("unit_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Industries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            cost_title = "Average Cost per Trip",
                            revenue_title = "Estimated Total Sales",
                            type = 1,
                            unit_title = "Trips Completed"
                        },
                        new
                        {
                            Id = 2,
                            cost_title = "Sales per Location",
                            revenue_title = "Estimated Total Sales",
                            type = 2,
                            unit_title = "Number of Locations"
                        });
                });

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.HasOne("sikho_backend.Models.Industry", "Industry")
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("sikho_backend.Models.DataPoint", b =>
                {
                    b.HasOne("sikho_backend.Models.Company", "Company")
                        .WithMany("DataPoints")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("sikho_backend.Models.Company", b =>
                {
                    b.Navigation("DataPoints");
                });

            modelBuilder.Entity("sikho_backend.Models.Industry", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿using CoreIntro_0.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntro_0.Configurations
{
    public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        //burada veritabanı icin ayarlama yapmak istiyoruz

        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder); //base'i oldugu gibi bırakıyoruz ki o özelligi de alsın
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new { x.OrderID, x.ProductID });
            builder.ToTable("Satıslar");
        }

    }
}

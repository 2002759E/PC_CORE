using CarRentalManagement.Server.Configurations.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PC_CORE.Server.Configurations.Entities;
using PC_CORE.Server.Models;
using PC_CORE.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PC_CORE.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

        public DbSet<Item> Items { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Request> Requests { get; set; }
		public DbSet<Offer> Offers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

			builder.ApplyConfiguration(new CategorySeedConfiguration());

			builder.ApplyConfiguration(new RoleSeedConfiguration());

			builder.ApplyConfiguration(new UserRoleSeedConfiguration());

			builder.ApplyConfiguration(new UserSeedConfiguration());
		}

    }
}

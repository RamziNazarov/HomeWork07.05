using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Homeworkasd
{
    public partial class RamziDBContext : DbContext
    {
        public RamziDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trekking.Models;

namespace Trekking.ViewModels
{
    public class PackageViewModel
    {
        private ApplicationDbContext _context;
        public PackageViewModel(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        //public List<PackageViewModel> GetGroupedPackageViewModels()
        //{
        //}
    }
}
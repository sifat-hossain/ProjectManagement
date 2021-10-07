using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Interface;
using ProjectManagement.Models;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ServiceLayer
{
    public class VendorInformationServiceLayer : IVendorInformation
    {
        private readonly dbContext dbContext;
        private readonly AutoMapper.IMapper mapper;
        public VendorInformationServiceLayer(dbContext _dbContext, AutoMapper.IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }
        public Task<string> CreateVendorInformation(VendorInformationViewModel vendorInformationViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<VendorInformationViewModel>> GetVendorInformation()
        {
            List<VendorInformation> vendorInformation = await dbContext.VendorInformations.FromSqlRaw("exec SpGetVendorInformation").ToListAsync();
            List<VendorInformationViewModel> vendorInformationViewModel = mapper.Map<List<VendorInformationViewModel>>(vendorInformation);
            return vendorInformationViewModel;
        }

        public VendorInformationViewModel GetVendorInformationById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateVendorInformation(VendorInformationViewModel vendorInformationViewModel)
        {
            throw new NotImplementedException();
        }
    }
}

using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
  public  interface IVendorInformation
    {
        Task<List<VendorInformationViewModel>> GetVendorInformation();
        Task<string> CreateVendorInformation(VendorInformationViewModel vendorInformationViewModel);
        VendorInformationViewModel GetVendorInformationById(int? id);
        Task<string> UpdateVendorInformation(VendorInformationViewModel vendorInformationViewModel);
    }
}

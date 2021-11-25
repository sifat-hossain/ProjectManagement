using Microsoft.AspNetCore.Http;
using ProjectManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Interface
{
    public interface IInitialNoteSheet
    {
        Task<List<InitialNotesheetViewModel>> GetAllInitialNoteSheet();
        Task<string> CreateInitialNoteSheet(InitialNotesheetViewModel initialNotesheetViewModel, IFormFile initialNoteSheetAttachment);
        InitialNotesheetViewModel GetInitialNoteSheetById(int? id);
        Task<string> UpdateInitialNoteSheet(InitialNotesheetViewModel initialNotesheetViewModel);
    }
}

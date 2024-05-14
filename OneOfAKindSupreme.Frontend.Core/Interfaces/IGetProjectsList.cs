﻿using OneOfAKindSupreme.Frontend.Core.ViewModels;

namespace OneOfAKindSupreme.Frontend.Core.Interfaces
{
    public interface IGetProjectsList
    {
        Task<List<ProjectViewModel>> GetList();
    }
}

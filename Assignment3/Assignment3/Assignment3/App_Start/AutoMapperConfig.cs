using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using Assignment3.Models;
using AutoMapper;


namespace Assignment3
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // AutoMapper create map statements - using AutoMapper static API
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Models.Employee, Controllers.EmployeeBase>();
                cfg.CreateMap<Controllers.EmployeeBase, Controllers.EmployeeEditForm>();
                cfg.CreateMap<Models.Track, Controllers.TrackBase>();
                //cfg.CreateMap<Controllers.EmployeeBase, Controllers.EmployeeEditContactInfoForm>();
            });


        }
    }
}
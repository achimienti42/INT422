using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// new...
using AutoMapper;

namespace WebAppProjectTemplate_v21
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            // AutoMapper create map statements - using AutoMapper static API
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Models.Employee, Controllers.EmployeeBase>();
                cfg.CreateMap<Controllers.EmployeeAdd, Models.Employee>();
                //cfg.CreateMap<Controllers.EmployeeBase, Controllers.EmployeeEditContactInfoForm>();
            });



        }
    }
}
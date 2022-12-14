namespace DDD.Description
{
    internal class Description
    {
        #region [-  Step 1: Create SolutionFolders Based on DDD Architecture -]
        //01_PeresentationLayer
        //02_ApplicationLayer
        //03_DomainLayer
        //04_Infrastructure
        #endregion

        #region [-  Step 2: Adding Domain Layer projects -]

        #region [- Create ContractProject in the DomainLayer -]
        //  1-Project.Domain.Contract(Repository DesignPattern)
        //  1.0-Create Abstracts Folder
        //	1.1-Create IRepository interface in the Abstracts Folder
        // 	1.2-Create all database tasks in the interface
        // 	1.3-Create SaveChanges() in the interface
        #endregion

        #region [- Create Domain of the Solution -]
        //2-Create Project.Domain
        //	2.1-AddRef[Project.Domain.Contract]
        //	2.2-Create project inner layers:
        //		1-Frameworks,2-Repositories,3-Factories,4-Aggregates
        //	2.3-Create IEntity in Frameworks/Abstracts
        //	2.4-Create Entity class in Frameworks/Base
        //	2.5-Create Person AggregateRoot in Aggregates
        //	2.6-Install TanvirArjel.Extensions.Microsoft.DependencyInjection  by nuget
        //	2.7-Create IPersonRepository  in Repositories with  [ScopedService] attribute
        //	2.8-Create PersonFactoryService in Factories for FactoryDesignPattern 
        #endregion

        #endregion

        #region [- Step 3: Create Infrastructure Layer projects -]

        //	1-Project.EntityFrameworkCore
        //		1.1-Create project inner layers:
        //			1-Frameworks,2-Configurations,3-Services
        //		1.2-AddRef[Project.Domain]
        //		1.3-Install Identity packages for EFCore by nuget
        //		    [Microsoft.AspNetCore.Identity.EntityFrameworkCore]
        //		    [Microsoft.EntityFrameworkCore.Design]
        //		    [Microsoft.EntityFrameworkCore.SQLServer]
        //		1.4-Create DbContext class [ProjectDbContext]
        //		1.5-Create PersonConfiguration class for FluentApi config
        //		1.6-Create BaseRepository class for Implementing tasks
        //		1.7-Create PersonRepository class for Implementing BaseRepository tasks & IPersonRepository tasks
        //		1.8- Add-Migration init
        //		1.9- Update-Database 


        #endregion//***************************************************

        #region [- Step 4: Create Application Layer projects -]

        #region [- 1- Project.Application.Contract ==> for Application Dto & all other Application contracts -]
        //  1.1-Create project inner layers:
        //			1-Abstracts,2-Base		
        //	1.2-Create IPersonDto in Abstracts/Dtos
        //	1.3-Create PersonBaseDto in Base/Dtos
        #endregion

        #region [- 2- Project.Application -]
        //		2.1-Create project inner layers:
        //			1-Abstracts,2-Dtos,3-Profiles,4-Services
        //		2.2-Install TanvirArjel.Extensions.Microsoft.DependencyInjection  by nuget
        //		2.3-Install AutoMapper.Extensions.Microsoft.DependencyInjection by nuget
        //		2.4-AddRef[Project.Domain]
        //		2.5-AddRef[Project.Application.Contract]
        //		2.6-Create IPersonAppService in Abstracts for IOC
        //		2.7-Create PersonDto for Get Flow in Dtos
        //		2.8-Add up GetAsync(Guid id) & GetListAsync() in IPersonAppService
        //		2.9-Create CreatePersonDto for Post Flow in Dtos
        //		2.10-Add up CreateAsync(CreatePersonDto input) in IPersonAppService
        //		2.11-Create UpdatePersonDto for Put Flow in Dtos
        //		2.12-Add up UpdateAsync(Guid id, UpdatePersonDto input) in IPersonAppService
        //		2.13-Create AutoMapperProfile in Profiles
        //		2.14-Create PersonAppService in Services
        #endregion

        #endregion


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

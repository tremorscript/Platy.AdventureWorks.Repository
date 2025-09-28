using AdventureWorks.Repository.Data;
using AdventureWorks.Repository.Domain.Mapping;
using AdventureWorks.Repository.Domain.Models;
using AdventureWorks.Repository.Domain.Validation;
using AdventureWorks.Repository;
using Ardalis.SharedKernel;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Microsoft.Extensions.Configuration;

namespace AdventureWorks.Repository.UnitTests;

public class UnitTest1
{
  [Fact]
  public async void Test1()
  {
    
    var config = new ConfigurationBuilder()
      .AddUserSecrets<UnitTest1>()
      .Build();

    var serviceCollection = new ServiceCollection();
    serviceCollection.AddAdventureWorkDatabase($"{config["AdventureWorksDb"]}");

    
    var serviceProvider = serviceCollection.BuildServiceProvider();
     var configuration = new MapperConfiguration(cfg => {
         cfg.AddProfile<AddressProfile>();
     });
     var mapper = new Mapper(configuration);
    
    AddressRepository test = new AddressRepository(
      serviceProvider,
      mapper,
    serviceProvider.GetService<IMediator>(),
    serviceProvider.GetService<ILogger<AddressRepository>>(),
      new AddressCreateModelValidator(),
      new AddressUpdateModelValidator()
      );
    
    var readModel = await test.GetAsync(1, CancellationToken.None);
    AddressCreateModel newModel = new AddressCreateModel()
    {
      AddressLine1 = readModel.Value.AddressLine2 + "test",
      AddressLine2 = readModel.Value.AddressLine2 + "test",
      City = readModel.Value.City,
      PostalCode =  readModel.Value.PostalCode,
      StateProvinceId = readModel.Value.StateProvinceId 
    } ;
    await test.CreateAsync(newModel,CancellationToken.None);
  }
}

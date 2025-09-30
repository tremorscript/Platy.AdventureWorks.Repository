using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Platy.AdventureWorks.Repository.Domain.Mapping;

namespace Platy.AdventureWorks.Repository.UnitTests;

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

    var configuration = new MapperConfiguration(cfg =>
    {
      cfg.AddProfile<AddressProfile>();
    });
    var mapper = new Mapper(configuration);
    serviceCollection.AddAutoMapper(cfg => { }, typeof(AddressProfile));

    var serviceProvider = serviceCollection.BuildServiceProvider();


    var test = serviceProvider.GetService<IAddressRepository>();
    // var test = new AddressRepository(
    //   serviceProvider,
    //   mapper,
    //   serviceProvider.GetService<IMediator>(),
    //   serviceProvider.GetService<ILogger<AddressRepository>>(),
    //   new AddressCreateModelValidator(),
    //   new AddressUpdateModelValidator()
    // );
    //
    // var readModel = await test.GetAsync(1, CancellationToken.None);
    // var newModel = new AddressCreateModel
    // {
    //   AddressLine1 = readModel.Value.AddressLine2 + "test",
    //   AddressLine2 = readModel.Value.AddressLine2 + "test",
    //   City = readModel.Value.City,
    //   PostalCode = readModel.Value.PostalCode,
    //   StateProvinceId = readModel.Value.StateProvinceId
    // };
    // await test.CreateAsync(newModel, CancellationToken.None);
  }
}

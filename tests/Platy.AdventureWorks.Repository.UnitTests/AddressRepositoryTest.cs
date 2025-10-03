using Ardalis.Result;
using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Platy.AdventureWorks.Repository.Domain.Models;
using Shouldly;

namespace Platy.AdventureWorks.Repository.UnitTests;

/// <summary>
///   Unit tests for the AddressRepository.
///   Methods should follow the naming convention:- [MethodWeTest_StateUnderTest_ExpectedBehavior]
///   [HTTPMethod]_[MethodName]_[StateUnderTest]_ThenTheAPIReturnsExpected[Http_Code]
/// </summary>
public class AddressRepositoryTest
{
  private readonly IValidator<AddressCreateModel> _createValidator = Substitute.For<IValidator<AddressCreateModel>>();
  private readonly ILogger<AddressRepository> _logger = Substitute.For<ILogger<AddressRepository>>();
  private readonly IMapper _mapper = Substitute.For<IMapper>();
  private readonly IMediator _mediator = Substitute.For<IMediator>();
  private readonly IServiceProvider _serviceProvider = Substitute.For<IServiceProvider>();
  private readonly AddressRepository _sut;
  private readonly IValidator<AddressUpdateModel> _updateValidator = Substitute.For<IValidator<AddressUpdateModel>>();

  public AddressRepositoryTest()
  {
    _sut = new AddressRepository(_serviceProvider, _mapper, _mediator, _logger, _createValidator, _updateValidator);
  }

  [Fact]
  public async Task GetAsync_ValidAddressId_ReturnsValidAddress()
  {
    // var config = new ConfigurationBuilder()
    //   .AddUserSecrets<AddressRepositoryTest>()
    //   .Build();
    //
    // var serviceCollection = new ServiceCollection();
    // serviceCollection.AddAdventureWorkDatabase($"{config["AdventureWorksDb"]}");
    //
    // var configuration = new MapperConfiguration(cfg =>
    // {
    //   cfg.AddProfile<AddressProfile>();
    // });
    // var mapper = new Mapper(configuration);
    // serviceCollection.AddAutoMapper(cfg => { }, typeof(AddressProfile));
    //
    // var serviceProvider = serviceCollection.BuildServiceProvider();


    // var test = serviceProvider.GetService<IAddressRepository>();
    var test = Substitute.For<IAddressRepository>();

    // Arrange
    test.GetAsync(123, CancellationToken.None)
      .Returns(new Result<AddressReadModel>(new AddressReadModel { Id = 123 }));

    // Act
    var test1 = await test.GetAsync(123, CancellationToken.None);

    // Assert
    test1.Value.Id.ShouldBe(123);


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

using PackIt.Domain.Entities;
using PackIt.Domain.Events;
using PackIt.Domain.Exceptions;
using PackIt.Domain.Factories;
using PackIt.Domain.Policies;
using PackIt.Domain.ValueObjects;
using Shouldly;

namespace PackIt.UnitTests.Domain
{
    public class PackingListTests
    {
        [Fact]
        public void AddItem_Throws_PackingItemAlreadyExistsException_When_Is_Already_Item_With_The_Same_Name()
        {
            //Arrange
            var packingList = GetPackingList();
            packingList.AddItem(new PackingItem("Item 1", 1));

            //Act
            var exception = Record.Exception(() => packingList.AddItem(new PackingItem("Item 1", 1)));

            //Assertion
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<PackingItemAlreadyExistsException>();
        }


        [Fact]
        public void AddItem_Adds_PackingItemAdd_Domain_Event_On_Success()
        {
            var packingList = GetPackingList();

            //Act
            var exception = Record.Exception(() => packingList.AddItem(new PackingItem("Item 1", 1)));

            exception.ShouldBeNull();
            packingList.Events.Count().ShouldBe(1);

            var @event = packingList.Events.FirstOrDefault();

            @event.ShouldBeOfType<PackingItemAdded>();

            @event.ShouldNotBeNull();

            ((PackingItemAdded)@event).PackingItem.Name.ShouldBe("Item 1");
        }


        #region Arrange
        private PackingList GetPackingList()
        {
            var packingList = _factory.Create(Guid.NewGuid(), "MyList", Localization.Create("Warsaw,Poland"));
            packingList.ClearEvents();
            return packingList;
        }

        private readonly IPackingListFactory _factory;
        public PackingListTests()
        {
            _factory = new PackingListFactory(Enumerable.Empty<IPackingItemsPolicy>());
        }
        #endregion
    }
}

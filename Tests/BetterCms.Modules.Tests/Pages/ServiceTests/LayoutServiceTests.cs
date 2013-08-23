﻿using System.Linq;
using BetterCms.Core.DataAccess;
using BetterCms.Module.Pages.Services;
using Moq;
using NUnit.Framework;

namespace BetterCms.Test.Module.Pages.ServiceTests
{
    [TestFixture]
    public class LayoutServiceTests : TestBase
    {
        [Test]
        public void Should_Return_Templates_List_Successfully()
        {
            BetterCms.Module.Root.Models.Layout layout1 = TestDataProvider.CreateNewLayout();
            BetterCms.Module.Root.Models.Layout layout2 = TestDataProvider.CreateNewLayout();

            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            repositoryMock
                .Setup(f => f.AsQueryable<BetterCms.Module.Root.Models.Layout>())
                .Returns(new[] { layout1, layout2 }.AsQueryable());

            var service = new DefaultLayoutService(repositoryMock.Object);
            var response = service.GetLayouts();

            Assert.IsNotNull(response);
            Assert.AreEqual(response.Count, 2);
            Assert.AreEqual(response[0].Title, new[] { layout1, layout2 }.OrderBy(o => o.Name).Select(o => o.Name).First());

            var layout = response.FirstOrDefault(l => layout1.Id == l.TemplateId);
            Assert.IsNotNull(layout);

            Assert.AreEqual(layout1.Name, layout.Title);
        }

        [Test]
        public void Should_Return_Empty_List()
        {
            Mock<IRepository> repositoryMock = new Mock<IRepository>();
            repositoryMock
                .Setup(f => f.AsQueryable<BetterCms.Module.Root.Models.Layout>())
                .Returns(new BetterCms.Module.Root.Models.Layout[] { }.AsQueryable());

            var service = new DefaultLayoutService(repositoryMock.Object);
            var response = service.GetLayouts();

            Assert.IsNotNull(response);
            Assert.IsEmpty(response);
        }
    }
}
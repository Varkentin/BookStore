using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Store.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetAllByQuery_WhithIsbn_CallsGetAllByIsbn()
        {
            var bookRepositoryStub = new Mock<IBookRepository>();

            bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                                .Returns(new[] { new Book(1, "", "", "","",0m) });

            bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                                .Returns(new[] { new Book(2, "", "", "","",0m) });

            var bookService = new BookService(bookRepositoryStub.Object);

            var actual = bookService.GetAllByQuery("ISBN 12345-67890");

            Assert.Collection(actual, book => Assert.Equal(1, book.Id));
        }
    }
}

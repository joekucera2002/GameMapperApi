using System;
using FluentAssertions;
using Xunit;

namespace GameMapperApi.Business.Tests
{
  public class SampleBusinessTests
  {
    [Fact]
    public void Example_IsTrue()
    {
      var sut = new Example();

      sut.IsTrue()
        .Should().BeTrue();
    }
  }
}

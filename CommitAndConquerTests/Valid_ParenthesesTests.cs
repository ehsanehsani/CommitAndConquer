using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommitAndConquer;
using FluentAssertions;

namespace CommitAndConquerTests
{
    public class Valid_ParenthesesTests
    {
        [Test]
        public void Test()
        {
            var result = Valid_Parentheses.IsValid("([])");
            result.Should().BeTrue();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpTestsEx;

namespace HelloWorld.Tests
{
    public class MessageBuilderTests
    {
        public void message_should_be_Hello_World_exclamation()
        {
            var builder = new MessageBuilder();
            builder.Build().Should().Be("Hello World!");
        }
    }
}

﻿using NUnit.Framework;
using Rebus.Tests.Contracts.Transports;

namespace Rebus.RabbitMq.Tests
{
    [TestFixture, Category("rabbitmq")]
    public class RabbitMqTransportMessageExpiration : MessageExpiration<RabbitMqTransportFactory> { }
}
﻿// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using DotNetCore.CAP.Messages;
using DotNetCore.CAP.Transport;

namespace DotNetCore.CAP.Diagnostics;

public class CapEventDataPubStore
{
    public long? OperationTimestamp { get; set; }

    public string Operation { get; set; } = default!;

    public Message Message { get; set; } = default!;

    public long? ElapsedTimeMs { get; set; }

    public Exception? Exception { get; set; }
}

public class CapEventDataPubSend
{
    public long? OperationTimestamp { get; set; }

    public string Operation { get; set; } = default!;

    public TransportMessage TransportMessage { get; set; } = default!;

    public BrokerAddress BrokerAddress { get; set; }

    public long? ElapsedTimeMs { get; set; }

    public Exception? Exception { get; set; }
}
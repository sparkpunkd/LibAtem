﻿using LibAtem.Serialization;

namespace LibAtem.Commands.Streaming
{
    [CommandName("StrR", CommandDirection.ToServer, ProtocolVersion.V8_1_1, 4), NoCommandId]
    public class StreamingStatusSetCommand : SerializableCommandBase
    {
        [Serialize(0), Bool]
        public bool IsStreaming { get; set; }
    }
}
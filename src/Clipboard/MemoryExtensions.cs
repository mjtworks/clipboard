﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Clipboard
{
    internal static class MemoryExtensions
    {
        public static ArraySegment<byte> GetUnderlyingArray(this Memory<byte> bytes) => GetUnderlyingArray((ReadOnlyMemory<byte>)bytes);
        public static ArraySegment<byte> GetUnderlyingArray(this ReadOnlyMemory<byte> bytes)
        {
            if (!MemoryMarshal.TryGetArray(bytes, out var arraySegment)) throw new NotSupportedException("This Memory does not support exposing the underlying array.");
            return arraySegment;
        }
    }
}

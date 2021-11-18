using System;
using System.Runtime.CompilerServices;

//------------------------------------------------------------------------------

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
// ReSharper disable AccessToStaticMemberViaDerivedType
// ReSharper disable ConditionIsAlwaysTrueOrFalse
// ReSharper disable BuiltInTypeReferenceStyle

//------------------------------------------------------------------------------

namespace K4os.Compression.LZ4.Engine
{
    internal static unsafe class LLxx
    {
        private static NotImplementedException AlgorithmNotImplemented(string action) =>
            new NotImplementedException(
                $"Algorithm {LL.Algorithm} not implemented for {action}");

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_decompress_safe(
            byte* source, byte* target, int sourceLength, int targetLength)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_decompress_safe(
                    source, target, sourceLength, targetLength);
                case Algorithm.X32:
                    return LL32.LZ4_decompress_safe(
                    source, target, sourceLength, targetLength);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_decompress_safe));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_decompress_safe_continue(
            LL.LZ4_streamDecode_t* context,
            byte* source, byte* target, int sourceLength, int targetLength)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_decompress_safe_continue(
                    context, source, target, sourceLength, targetLength);
                case Algorithm.X32:
                    return LL32.LZ4_decompress_safe_continue(
                    context, source, target, sourceLength, targetLength);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_decompress_safe_continue));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_compress_fast(
            byte* source, byte* target, int sourceLength, int targetLength,
            int acceleration)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_compress_fast(
                    source, target, sourceLength, targetLength, acceleration);
                case Algorithm.X32:
                    return LL32.LZ4_compress_fast(
                    source, target, sourceLength, targetLength, acceleration);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_compress_fast));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_compress_fast_continue(
            LL.LZ4_stream_t* context,
            byte* source, byte* target, int sourceLength, int targetLength,
            int acceleration)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_compress_fast_continue(
                    context,
                    source, target, sourceLength, targetLength,
                    acceleration);
                case Algorithm.X32:
                    return LL32.LZ4_compress_fast_continue(
                    context,
                    source, target, sourceLength, targetLength,
                    acceleration);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_compress_fast_continue));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_compress_HC(
            byte* source, byte* target, int sourceLength, int targetLength, int level)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_compress_HC(
                    source, target, sourceLength, targetLength, level);
                case Algorithm.X32:
                    return LL32.LZ4_compress_HC(
                    source, target, sourceLength, targetLength, level);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_compress_HC));
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static int LZ4_compress_HC_continue(
            LL.LZ4_streamHC_t* context,
            byte* source, byte* target, int sourceLength, int targetLength)
        {
            switch (LL.Algorithm)
            {
                case Algorithm.X64:
                    return LL64.LZ4_compress_HC_continue(
                    context, source, target, sourceLength, targetLength);
                case Algorithm.X32:
                    return LL32.LZ4_compress_HC_continue(
                    context, source, target, sourceLength, targetLength);
                default:
                    throw AlgorithmNotImplemented(nameof(LZ4_compress_HC_continue));
            }
        }
    }
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005C RID: 92
	public static class BufferUtils : Object
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x000392A8 File Offset: 0x000374A8
		// Note: this type is marked as 'beforefieldinit'.
		static BufferUtils()
		{
			Il2CppClassPointerStore<BufferUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "BufferUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferUtils>.NativeClassPtr);
			BufferUtils.NativeMethodInfoPtr_RentBuffer_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferUtils>.NativeClassPtr, 100664900);
			BufferUtils.NativeMethodInfoPtr_ReturnBuffer_Public_Static_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferUtils>.NativeClassPtr, 100664901);
			BufferUtils.NativeMethodInfoPtr_EnsureBufferSize_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferUtils>.NativeClassPtr, 100664902);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00039314 File Offset: 0x00037514
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 743856, RefRangeEnd = 743875, XrefRangeStart = 743850, XrefRangeEnd = 743856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> RentBuffer(IArrayPool<char> bufferPool, int minSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferUtils.NativeMethodInfoPtr_RentBuffer_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00039368 File Offset: 0x00037568
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 743878, RefRangeEnd = 743888, XrefRangeStart = 743875, XrefRangeEnd = 743878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReturnBuffer(IArrayPool<char> bufferPool, Il2CppStructArray<char> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferUtils.NativeMethodInfoPtr_ReturnBuffer_Public_Static_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000393B0 File Offset: 0x000375B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743888, XrefRangeEnd = 743896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> EnsureBufferSize(IArrayPool<char> bufferPool, int size, Il2CppStructArray<char> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bufferPool);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BufferUtils.NativeMethodInfoPtr_EnsureBufferSize_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00004B2B File Offset: 0x00002D2B
		public BufferUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_RentBuffer_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_ReturnBuffer_Public_Static_Void_IArrayPool_1_Char_Il2CppStructArray_1_Char_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBufferSize_Public_Static_Il2CppStructArray_1_Char_IArrayPool_1_Char_Int32_Il2CppStructArray_1_Char_0;
	}
}

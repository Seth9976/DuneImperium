using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000EC RID: 236
	public static class HashUnsafeUtilities : Object
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x0005F048 File Offset: 0x0005D248
		// Note: this type is marked as 'beforefieldinit'.
		static HashUnsafeUtilities()
		{
			Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HashUnsafeUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr);
			HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665962);
			HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100665963);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005F0A0 File Offset: 0x0005D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657874, XrefRangeEnd = 657875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005F0FC File Offset: 0x0005D2FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 657876, RefRangeEnd = 657879, XrefRangeStart = 657875, XrefRangeEnd = 657876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x00007EB6 File Offset: 0x000060B6
		public HashUnsafeUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0;
	}
}

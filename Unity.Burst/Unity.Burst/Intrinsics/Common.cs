using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001A RID: 26
	public static class Common : Object
	{
		// Token: 0x060001FA RID: 506 RVA: 0x000098DC File Offset: 0x00007ADC
		// Note: this type is marked as 'beforefieldinit'.
		static Common()
		{
			Il2CppClassPointerStore<Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "Common");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Common>.NativeClassPtr);
			Common.NativeMethodInfoPtr_Pause_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Common>.NativeClassPtr, 100665939);
			Common.NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Common>.NativeClassPtr, 100665940);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00009934 File Offset: 0x00007B34
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Common.NativeMethodInfoPtr_Pause_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000995C File Offset: 0x00007B5C
		[CallerCount(0)]
		public unsafe static ulong umul128(ulong x, ulong y, out ulong high)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &high;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Common.NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002CE4 File Offset: 0x00000EE4
		public Common(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_umul128_Public_Static_UInt64_UInt64_UInt64_byref_UInt64_0;
	}
}

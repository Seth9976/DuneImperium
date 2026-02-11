using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004FE RID: 1278
	public static class IntrospectiveSortUtilities : Object
	{
		// Token: 0x06004ED3 RID: 20179 RVA: 0x0016DF98 File Offset: 0x0016C198
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectiveSortUtilities()
		{
			Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IntrospectiveSortUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100675171);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100675172);
		}

		// Token: 0x06004ED4 RID: 20180 RVA: 0x0016DFF0 File Offset: 0x0016C1F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1425879, RefRangeEnd = 1425884, XrefRangeStart = 1425879, XrefRangeEnd = 1425879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorLog2PlusOne(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x0016E030 File Offset: 0x0016C230
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1425891, RefRangeEnd = 1425896, XrefRangeStart = 1425884, XrefRangeEnd = 1425891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOrIgnoreBadComparer(Object comparer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x0001C702 File Offset: 0x0001A902
		public IntrospectiveSortUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004058 RID: 16472
		private static readonly IntPtr NativeMethodInfoPtr_FloorLog2PlusOne_Internal_Static_Int32_Int32_0;

		// Token: 0x04004059 RID: 16473
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0;
	}
}

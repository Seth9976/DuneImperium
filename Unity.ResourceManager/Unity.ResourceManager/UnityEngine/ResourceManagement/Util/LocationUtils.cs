using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x0200001C RID: 28
	public static class LocationUtils : Object
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000BA8C File Offset: 0x00009C8C
		// Note: this type is marked as 'beforefieldinit'.
		static LocationUtils()
		{
			Il2CppClassPointerStore<LocationUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "LocationUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocationUtils>.NativeClassPtr);
			LocationUtils.NativeMethodInfoPtr_LocationEquals_Public_Static_Boolean_IResourceLocation_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationUtils>.NativeClassPtr, 100663610);
			LocationUtils.NativeMethodInfoPtr_DependenciesEqual_Public_Static_Boolean_IList_1_IResourceLocation_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationUtils>.NativeClassPtr, 100663611);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1138722, RefRangeEnd = 1138727, XrefRangeStart = 1138707, XrefRangeEnd = 1138722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LocationEquals(IResourceLocation loc1, IResourceLocation loc2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loc2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationUtils.NativeMethodInfoPtr_LocationEquals_Public_Static_Boolean_IResourceLocation_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000BB38 File Offset: 0x00009D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138727, XrefRangeEnd = 1138742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DependenciesEqual(IList<IResourceLocation> deps1, IList<IResourceLocation> deps2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deps2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationUtils.NativeMethodInfoPtr_DependenciesEqual_Public_Static_Boolean_IList_1_IResourceLocation_IList_1_IResourceLocation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002B1F File Offset: 0x00000D1F
		public LocationUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_LocationEquals_Public_Static_Boolean_IResourceLocation_IResourceLocation_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_DependenciesEqual_Public_Static_Boolean_IList_1_IResourceLocation_IList_1_IResourceLocation_0;
	}
}

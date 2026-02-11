using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	public sealed class LightmapSettings : Object
	{
		// Token: 0x06000967 RID: 2407 RVA: 0x000346E4 File Offset: 0x000328E4
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapSettings()
		{
			Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightmapSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr);
			LightmapSettings.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664359);
			LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664360);
			LightmapSettings.NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664361);
			LightmapSettings.NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664362);
			LightmapSettings.NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664363);
			LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664364);
			LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664365);
			LightmapSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664366);
			LightmapSettings.NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664367);
			LightmapSettings.NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664368);
			LightmapSettings.NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664369);
			LightmapSettings.NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr, 100664370);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00034804 File Offset: 0x00032A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649974, XrefRangeEnd = 649978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightmapSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightmapSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00034840 File Offset: 0x00032A40
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00034874 File Offset: 0x00032A74
		public unsafe static Il2CppReferenceArray<LightmapData> lightmaps
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649978, XrefRangeEnd = 649980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LightmapData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649980, XrefRangeEnd = 649982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000348AC File Offset: 0x00032AAC
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000348DC File Offset: 0x00032ADC
		public unsafe static LightmapsMode lightmapsMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649982, XrefRangeEnd = 649984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649984, XrefRangeEnd = 649986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00034910 File Offset: 0x00032B10
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00034944 File Offset: 0x00032B44
		public unsafe static LightProbes lightProbes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649986, XrefRangeEnd = 649988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightProbes>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649988, XrefRangeEnd = 649990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0003497C File Offset: 0x00032B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649990, XrefRangeEnd = 649992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000349A4 File Offset: 0x00032BA4
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000349D4 File Offset: 0x00032BD4
		public unsafe static LightmapsModeLegacy lightmapsModeLegacy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x00034A08 File Offset: 0x00032C08
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00034A38 File Offset: 0x00032C38
		public unsafe static ColorSpace bakedColorSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649992, XrefRangeEnd = 649994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapSettings.NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0000592D File Offset: 0x00003B2D
		public LightmapSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmaps_Public_Static_get_Il2CppReferenceArray_1_LightmapData_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_set_lightmaps_Public_Static_set_Void_Il2CppReferenceArray_1_LightmapData_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsMode_Public_Static_get_LightmapsMode_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_set_lightmapsMode_Public_Static_set_Void_LightmapsMode_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_get_lightProbes_Public_Static_get_LightProbes_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_set_lightProbes_Public_Static_set_Void_LightProbes_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_get_lightmapsModeLegacy_Public_Static_get_LightmapsModeLegacy_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_set_lightmapsModeLegacy_Public_Static_set_Void_LightmapsModeLegacy_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_get_bakedColorSpace_Public_Static_get_ColorSpace_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_set_bakedColorSpace_Public_Static_set_Void_ColorSpace_0;
	}
}

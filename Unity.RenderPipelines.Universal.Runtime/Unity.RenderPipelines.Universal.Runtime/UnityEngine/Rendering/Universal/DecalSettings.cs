using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000C3 RID: 195
	[Serializable]
	public class DecalSettings : Object
	{
		// Token: 0x06000F0B RID: 3851 RVA: 0x0004938C File Offset: 0x0004758C
		// Note: this type is marked as 'beforefieldinit'.
		static DecalSettings()
		{
			Il2CppClassPointerStore<DecalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr);
			DecalSettings.NativeFieldInfoPtr_technique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "technique");
			DecalSettings.NativeFieldInfoPtr_maxDrawDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "maxDrawDistance");
			DecalSettings.NativeFieldInfoPtr_decalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "decalLayers");
			DecalSettings.NativeFieldInfoPtr_dBufferSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "dBufferSettings");
			DecalSettings.NativeFieldInfoPtr_screenSpaceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, "screenSpaceSettings");
			DecalSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr, 100665206);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00049434 File Offset: 0x00047634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614881, XrefRangeEnd = 614882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecalSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecalSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0000943F File Offset: 0x0000763F
		public DecalSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00049470 File Offset: 0x00047670
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x00009448 File Offset: 0x00007648
		public unsafe DecalTechniqueOption technique
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_technique);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_technique)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00049498 File Offset: 0x00047698
		// (set) Token: 0x06000F11 RID: 3857 RVA: 0x00009463 File Offset: 0x00007663
		public unsafe float maxDrawDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_maxDrawDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_maxDrawDistance)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x000494C0 File Offset: 0x000476C0
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0000947E File Offset: 0x0000767E
		public unsafe bool decalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_decalLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_decalLayers)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x000494E8 File Offset: 0x000476E8
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x00009499 File Offset: 0x00007699
		public unsafe DBufferSettings dBufferSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_dBufferSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBufferSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_dBufferSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00049518 File Offset: 0x00047718
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x000094B8 File Offset: 0x000076B8
		public unsafe DecalScreenSpaceSettings screenSpaceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_screenSpaceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalScreenSpaceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecalSettings.NativeFieldInfoPtr_screenSpaceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeFieldInfoPtr_technique;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeFieldInfoPtr_maxDrawDistance;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_decalLayers;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_dBufferSettings;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_screenSpaceSettings;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

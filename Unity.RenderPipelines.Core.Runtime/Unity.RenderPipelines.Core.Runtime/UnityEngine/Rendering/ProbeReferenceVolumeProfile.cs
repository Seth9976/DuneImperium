using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200008E RID: 142
	public sealed class ProbeReferenceVolumeProfile : ScriptableObject
	{
		// Token: 0x06000AAF RID: 2735 RVA: 0x00034644 File Offset: 0x00032844
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeReferenceVolumeProfile()
		{
			Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeReferenceVolumeProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr);
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "version");
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_freezePlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "freezePlacement");
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_simplificationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "simplificationLevels");
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minDistanceBetweenProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "minDistanceBetweenProbes");
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_renderersLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "renderersLayerMask");
			ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minRendererVolumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, "minRendererVolumeSize");
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664962);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664963);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664964);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664965);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664966);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr_IsEquivalent_Public_Boolean_ProbeReferenceVolumeProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664967);
			ProbeReferenceVolumeProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr, 100664968);
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00034778 File Offset: 0x00032978
		public unsafe int cellSizeInBricks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969640, XrefRangeEnd = 969641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000347B4 File Offset: 0x000329B4
		public unsafe int maxSubdivision
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x000347F0 File Offset: 0x000329F0
		public unsafe float minBrickSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0003482C File Offset: 0x00032A2C
		public unsafe float cellSizeInMeters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969641, XrefRangeEnd = 969642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00034868 File Offset: 0x00032A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969642, XrefRangeEnd = 969648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003489C File Offset: 0x00032A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969648, XrefRangeEnd = 969652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEquivalent(ProbeReferenceVolumeProfile otherProfile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherProfile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr_IsEquivalent_Public_Boolean_ProbeReferenceVolumeProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x000348EC File Offset: 0x00032AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969652, XrefRangeEnd = 969660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeReferenceVolumeProfile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeReferenceVolumeProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeReferenceVolumeProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000067C1 File Offset: 0x000049C1
		public ProbeReferenceVolumeProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00034928 File Offset: 0x00032B28
		// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x000067CA File Offset: 0x000049CA
		public unsafe ProbeReferenceVolumeProfile.Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00034950 File Offset: 0x00032B50
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x000067E5 File Offset: 0x000049E5
		public unsafe bool freezePlacement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_freezePlacement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_freezePlacement)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00034978 File Offset: 0x00032B78
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00006800 File Offset: 0x00004A00
		public unsafe int simplificationLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_simplificationLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_simplificationLevels)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x000349A0 File Offset: 0x00032BA0
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0000681B File Offset: 0x00004A1B
		public unsafe float minDistanceBetweenProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minDistanceBetweenProbes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minDistanceBetweenProbes)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x000349C8 File Offset: 0x00032BC8
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x00006836 File Offset: 0x00004A36
		public unsafe LayerMask renderersLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_renderersLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_renderersLayerMask)) = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x000349F0 File Offset: 0x00032BF0
		// (set) Token: 0x06000AC3 RID: 2755 RVA: 0x00006851 File Offset: 0x00004A51
		public unsafe float minRendererVolumeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minRendererVolumeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeReferenceVolumeProfile.NativeFieldInfoPtr_minRendererVolumeSize)) = value;
			}
		}

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeFieldInfoPtr_freezePlacement;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeFieldInfoPtr_simplificationLevels;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeFieldInfoPtr_minDistanceBetweenProbes;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeFieldInfoPtr_renderersLayerMask;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeFieldInfoPtr_minRendererVolumeSize;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSizeInBricks_Public_get_Int32_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSubdivision_Public_get_Int32_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_get_minBrickSize_Public_get_Single_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_get_cellSizeInMeters_Public_get_Single_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalent_Public_Boolean_ProbeReferenceVolumeProfile_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001D0 RID: 464
		public enum Version
		{
			// Token: 0x040012B5 RID: 4789
			Initial
		}
	}
}

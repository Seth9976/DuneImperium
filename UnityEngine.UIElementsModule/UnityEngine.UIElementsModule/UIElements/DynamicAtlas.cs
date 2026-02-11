using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001C RID: 28
	public class DynamicAtlas : AtlasBase
	{
		// Token: 0x06000189 RID: 393 RVA: 0x00021D6C File Offset: 0x0001FF6C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicAtlas()
		{
			Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DynamicAtlas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr);
			DynamicAtlas.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_Database");
			DynamicAtlas.NativeFieldInfoPtr_m_PointPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_PointPage");
			DynamicAtlas.NativeFieldInfoPtr_m_BilinearPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_BilinearPage");
			DynamicAtlas.NativeFieldInfoPtr_m_ColorSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_ColorSpace");
			DynamicAtlas.NativeFieldInfoPtr_m_Panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_Panels");
			DynamicAtlas.NativeFieldInfoPtr_m_MinAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_MinAtlasSize");
			DynamicAtlas.NativeFieldInfoPtr_m_MaxAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_MaxAtlasSize");
			DynamicAtlas.NativeFieldInfoPtr_m_MaxSubTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_MaxSubTextureSize");
			DynamicAtlas.NativeFieldInfoPtr_m_ActiveFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_ActiveFilters");
			DynamicAtlas.NativeFieldInfoPtr_m_CustomFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "m_CustomFilter");
			DynamicAtlas.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663486);
			DynamicAtlas.NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663487);
			DynamicAtlas.NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663488);
			DynamicAtlas.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663489);
			DynamicAtlas.NativeMethodInfoPtr_InitPages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663490);
			DynamicAtlas.NativeMethodInfoPtr_DestroyPages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663491);
			DynamicAtlas.NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663492);
			DynamicAtlas.NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_Void_VisualElement_Texture2D_TextureId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663493);
			DynamicAtlas.NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663494);
			DynamicAtlas.NativeMethodInfoPtr_IsTextureFormatSupported_Internal_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663495);
			DynamicAtlas.NativeMethodInfoPtr_IsTextureValid_Public_Virtual_New_Boolean_Texture2D_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663496);
			DynamicAtlas.NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663497);
			DynamicAtlas.NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663498);
			DynamicAtlas.NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663499);
			DynamicAtlas.NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663500);
			DynamicAtlas.NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663501);
			DynamicAtlas.NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663502);
			DynamicAtlas.NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663503);
			DynamicAtlas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, 100663504);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00021FE0 File Offset: 0x000201E0
		public unsafe bool isInitialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0002201C File Offset: 0x0002021C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283343, XrefRangeEnd = 283350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAssignedToPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0002206C File Offset: 0x0002026C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283350, XrefRangeEnd = 283356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRemovedFromPanel(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000220BC File Offset: 0x000202BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283356, XrefRangeEnd = 283368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000220F8 File Offset: 0x000202F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283368, XrefRangeEnd = 283381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitPages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_InitPages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0002212C File Offset: 0x0002032C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283389, RefRangeEnd = 283391, XrefRangeStart = 283381, XrefRangeEnd = 283389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyPages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_DestroyPages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00022160 File Offset: 0x00020360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283391, XrefRangeEnd = 283426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atlas;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atlasRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000221E8 File Offset: 0x000203E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283426, XrefRangeEnd = 283440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(src);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlas;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_Void_VisualElement_Texture2D_TextureId_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00022258 File Offset: 0x00020458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283440, XrefRangeEnd = 283444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdateDynamicTextures(IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_Void_IPanel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000222A8 File Offset: 0x000204A8
		[CallerCount(0)]
		public unsafe static bool IsTextureFormatSupported(TextureFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_IsTextureFormatSupported_Internal_Static_Boolean_TextureFormat_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000222E8 File Offset: 0x000204E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283444, XrefRangeEnd = 283449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasFilterMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicAtlas.NativeMethodInfoPtr_IsTextureValid_Public_Virtual_New_Boolean_Texture2D_FilterMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00022734 File Offset: 0x00020934
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00022350 File Offset: 0x00020550
		public unsafe int minAtlasSize
		{
			get
			{
				return this.m_MinAtlasSize;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283449, RefRangeEnd = 283450, XrefRangeStart = 283449, XrefRangeEnd = 283449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0002274C File Offset: 0x0002094C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00022390 File Offset: 0x00020590
		public unsafe int maxAtlasSize
		{
			get
			{
				return this.m_MaxAtlasSize;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283450, RefRangeEnd = 283451, XrefRangeStart = 283450, XrefRangeEnd = 283450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000223D0 File Offset: 0x000205D0
		public unsafe static DynamicAtlasFilters defaultFilters
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 73337, RefRangeEnd = 73340, XrefRangeStart = 73337, XrefRangeEnd = 73340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00022764 File Offset: 0x00020964
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00022400 File Offset: 0x00020600
		public unsafe DynamicAtlasFilters activeFilters
		{
			get
			{
				return this.m_ActiveFilters;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283451, RefRangeEnd = 283452, XrefRangeStart = 283451, XrefRangeEnd = 283451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00022440 File Offset: 0x00020640
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0002247C File Offset: 0x0002067C
		public unsafe int maxSubTextureSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283452, RefRangeEnd = 283453, XrefRangeStart = 283452, XrefRangeEnd = 283452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0002277C File Offset: 0x0002097C
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000224BC File Offset: 0x000206BC
		public unsafe DynamicAtlasCustomFilter customFilter
		{
			get
			{
				return this.m_CustomFilter;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283455, RefRangeEnd = 283456, XrefRangeStart = 283453, XrefRangeEnd = 283455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00022500 File Offset: 0x00020700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283479, RefRangeEnd = 283480, XrefRangeStart = 283456, XrefRangeEnd = 283479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicAtlas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002676 File Offset: 0x00000876
		public DynamicAtlas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0002253C File Offset: 0x0002073C
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0000267F File Offset: 0x0000087F
		public unsafe Dictionary<Texture, DynamicAtlas.TextureInfo> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Texture, DynamicAtlas.TextureInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0002256C File Offset: 0x0002076C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000269E File Offset: 0x0000089E
		public unsafe DynamicAtlasPage m_PointPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_PointPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasPage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_PointPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0002259C File Offset: 0x0002079C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x000026BD File Offset: 0x000008BD
		public unsafe DynamicAtlasPage m_BilinearPage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_BilinearPage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasPage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_BilinearPage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000225CC File Offset: 0x000207CC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000026DC File Offset: 0x000008DC
		public unsafe ColorSpace m_ColorSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_ColorSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_ColorSpace)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000225F4 File Offset: 0x000207F4
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000026F7 File Offset: 0x000008F7
		public unsafe List<IPanel> m_Panels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_Panels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_Panels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00022624 File Offset: 0x00020824
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002716 File Offset: 0x00000916
		public unsafe int m_MinAtlasSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MinAtlasSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MinAtlasSize)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0002264C File Offset: 0x0002084C
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002731 File Offset: 0x00000931
		public unsafe int m_MaxAtlasSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MaxAtlasSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MaxAtlasSize)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00022674 File Offset: 0x00020874
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0000274C File Offset: 0x0000094C
		public unsafe int m_MaxSubTextureSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MaxSubTextureSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_MaxSubTextureSize)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0002269C File Offset: 0x0002089C
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002767 File Offset: 0x00000967
		public unsafe DynamicAtlasFilters m_ActiveFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_ActiveFilters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_ActiveFilters)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000226C4 File Offset: 0x000208C4
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002782 File Offset: 0x00000982
		public unsafe DynamicAtlasCustomFilter m_CustomFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_CustomFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasCustomFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.NativeFieldInfoPtr_m_CustomFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000226F4 File Offset: 0x000208F4
		public void SetDirty(Texture2D tex)
		{
			bool flag = tex == null;
			if (!flag)
			{
				DynamicAtlas.TextureInfo textureInfo;
				bool flag2 = this.m_Database.TryGetValue(tex, out textureInfo);
				if (flag2)
				{
					textureInfo.page.Update(tex, textureInfo.rect);
				}
			}
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeFieldInfoPtr_m_PointPage;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeFieldInfoPtr_m_BilinearPage;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorSpace;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_m_Panels;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_m_MinAtlasSize;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxAtlasSize;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSubTextureSize;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveFilters;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomFilter;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_OnAssignedToPanel_Protected_Virtual_Void_IPanel_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_OnRemovedFromPanel_Protected_Virtual_Void_IPanel_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_InitPages_Private_Void_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPages_Private_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAtlas_Public_Virtual_Boolean_VisualElement_Texture2D_byref_TextureId_byref_RectInt_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_ReturnAtlas_Public_Virtual_Void_VisualElement_Texture2D_TextureId_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateDynamicTextures_Protected_Virtual_Void_IPanel_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_IsTextureFormatSupported_Internal_Static_Boolean_TextureFormat_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_IsTextureValid_Public_Virtual_New_Boolean_Texture2D_FilterMode_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_set_minAtlasSize_Public_set_Void_Int32_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_set_maxAtlasSize_Public_set_Void_Int32_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFilters_Public_Static_get_DynamicAtlasFilters_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_set_activeFilters_Public_set_Void_DynamicAtlasFilters_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_get_maxSubTextureSize_Public_get_Int32_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_set_maxSubTextureSize_Public_set_Void_Int32_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_set_customFilter_Public_set_Void_DynamicAtlasCustomFilter_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000321 RID: 801
		public class TextureInfo : UnityEngine.UIElements.UIR.LinkedPoolItem<DynamicAtlas.TextureInfo>
		{
			// Token: 0x06003514 RID: 13588 RVA: 0x000DC9BC File Offset: 0x000DABBC
			// Note: this type is marked as 'beforefieldinit'.
			static TextureInfo()
			{
				Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicAtlas>.NativeClassPtr, "TextureInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr);
				DynamicAtlas.TextureInfo.NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, "page");
				DynamicAtlas.TextureInfo.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, "counter");
				DynamicAtlas.TextureInfo.NativeFieldInfoPtr_alloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, "alloc");
				DynamicAtlas.TextureInfo.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, "rect");
				DynamicAtlas.TextureInfo.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, "pool");
				DynamicAtlas.TextureInfo.NativeMethodInfoPtr_Create_Private_Static_TextureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, 100663505);
				DynamicAtlas.TextureInfo.NativeMethodInfoPtr_Reset_Private_Static_Void_TextureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, 100663506);
				DynamicAtlas.TextureInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr, 100663507);
			}

			// Token: 0x06003515 RID: 13589 RVA: 0x000DCA88 File Offset: 0x000DAC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283333, XrefRangeEnd = 283339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DynamicAtlas.TextureInfo Create()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.TextureInfo.NativeMethodInfoPtr_Create_Private_Static_TextureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicAtlas.TextureInfo>(intPtr3) : null;
			}

			// Token: 0x06003516 RID: 13590 RVA: 0x000DCABC File Offset: 0x000DACBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283339, XrefRangeEnd = 283340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Reset(DynamicAtlas.TextureInfo info)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.TextureInfo.NativeMethodInfoPtr_Reset_Private_Static_Void_TextureInfo_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003517 RID: 13591 RVA: 0x000DCAF4 File Offset: 0x000DACF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283340, XrefRangeEnd = 283343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicAtlas.TextureInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlas.TextureInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003518 RID: 13592 RVA: 0x00015829 File Offset: 0x00013A29
			public TextureInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x06003519 RID: 13593 RVA: 0x000DCB30 File Offset: 0x000DAD30
			// (set) Token: 0x0600351A RID: 13594 RVA: 0x00015832 File Offset: 0x00013A32
			public unsafe DynamicAtlasPage page
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_page);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasPage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_page), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x0600351B RID: 13595 RVA: 0x000DCB60 File Offset: 0x000DAD60
			// (set) Token: 0x0600351C RID: 13596 RVA: 0x00015851 File Offset: 0x00013A51
			public unsafe int counter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_counter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_counter)) = value;
				}
			}

			// Token: 0x1700107A RID: 4218
			// (get) Token: 0x0600351D RID: 13597 RVA: 0x000DCB88 File Offset: 0x000DAD88
			// (set) Token: 0x0600351E RID: 13598 RVA: 0x0001586C File Offset: 0x00013A6C
			public UnityEngine.UIElements.UIR.Allocator2D.Alloc2D alloc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_alloc);
					return new UnityEngine.UIElements.UIR.Allocator2D.Alloc2D(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityEngine.UIElements.UIR.Allocator2D.Alloc2D>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_alloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnityEngine.UIElements.UIR.Allocator2D.Alloc2D>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700107B RID: 4219
			// (get) Token: 0x0600351F RID: 13599 RVA: 0x000DCBB8 File Offset: 0x000DADB8
			// (set) Token: 0x06003520 RID: 13600 RVA: 0x0001589A File Offset: 0x00013A9A
			public unsafe RectInt rect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_rect);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_rect)) = value;
				}
			}

			// Token: 0x1700107C RID: 4220
			// (get) Token: 0x06003521 RID: 13601 RVA: 0x000DCBE0 File Offset: 0x000DADE0
			// (set) Token: 0x06003522 RID: 13602 RVA: 0x000158B5 File Offset: 0x00013AB5
			public unsafe static UnityEngine.UIElements.UIR.LinkedPool<DynamicAtlas.TextureInfo> pool
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_pool, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.LinkedPool<DynamicAtlas.TextureInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicAtlas.TextureInfo.NativeFieldInfoPtr_pool, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400262A RID: 9770
			private static readonly IntPtr NativeFieldInfoPtr_page;

			// Token: 0x0400262B RID: 9771
			private static readonly IntPtr NativeFieldInfoPtr_counter;

			// Token: 0x0400262C RID: 9772
			private static readonly IntPtr NativeFieldInfoPtr_alloc;

			// Token: 0x0400262D RID: 9773
			private static readonly IntPtr NativeFieldInfoPtr_rect;

			// Token: 0x0400262E RID: 9774
			private static readonly IntPtr NativeFieldInfoPtr_pool;

			// Token: 0x0400262F RID: 9775
			private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_TextureInfo_0;

			// Token: 0x04002630 RID: 9776
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Static_Void_TextureInfo_0;

			// Token: 0x04002631 RID: 9777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

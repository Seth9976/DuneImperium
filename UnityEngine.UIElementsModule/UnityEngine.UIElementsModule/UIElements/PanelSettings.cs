using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000135 RID: 309
	public class PanelSettings : ScriptableObject
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x0006E0B4 File Offset: 0x0006C2B4
		// Note: this type is marked as 'beforefieldinit'.
		static PanelSettings()
		{
			Il2CppClassPointerStore<PanelSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PanelSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr);
			PanelSettings.NativeFieldInfoPtr_k_DefaultSortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "k_DefaultSortingOrder");
			PanelSettings.NativeFieldInfoPtr_k_DefaultScaleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "k_DefaultScaleValue");
			PanelSettings.NativeFieldInfoPtr_k_DefaultStyleSheetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "k_DefaultStyleSheetPath");
			PanelSettings.NativeFieldInfoPtr_themeUss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "themeUss");
			PanelSettings.NativeFieldInfoPtr_m_TargetTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_TargetTexture");
			PanelSettings.NativeFieldInfoPtr_m_ScaleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ScaleMode");
			PanelSettings.NativeFieldInfoPtr_m_ReferenceSpritePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ReferenceSpritePixelsPerUnit");
			PanelSettings.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_Scale");
			PanelSettings.NativeFieldInfoPtr_DefaultDpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "DefaultDpi");
			PanelSettings.NativeFieldInfoPtr_m_ReferenceDpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ReferenceDpi");
			PanelSettings.NativeFieldInfoPtr_m_FallbackDpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_FallbackDpi");
			PanelSettings.NativeFieldInfoPtr_m_ReferenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ReferenceResolution");
			PanelSettings.NativeFieldInfoPtr_m_ScreenMatchMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ScreenMatchMode");
			PanelSettings.NativeFieldInfoPtr_m_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_Match");
			PanelSettings.NativeFieldInfoPtr_m_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_SortingOrder");
			PanelSettings.NativeFieldInfoPtr_m_TargetDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_TargetDisplay");
			PanelSettings.NativeFieldInfoPtr_m_ClearDepthStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ClearDepthStencil");
			PanelSettings.NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ClearColor");
			PanelSettings.NativeFieldInfoPtr_m_ColorClearValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ColorClearValue");
			PanelSettings.NativeFieldInfoPtr_m_PanelAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_PanelAccess");
			PanelSettings.NativeFieldInfoPtr_m_AttachedUIDocumentsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_AttachedUIDocumentsList");
			PanelSettings.NativeFieldInfoPtr_m_DynamicAtlasSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_DynamicAtlasSettings");
			PanelSettings.NativeFieldInfoPtr_m_AtlasBlitShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_AtlasBlitShader");
			PanelSettings.NativeFieldInfoPtr_m_RuntimeShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_RuntimeShader");
			PanelSettings.NativeFieldInfoPtr_m_RuntimeWorldShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_RuntimeWorldShader");
			PanelSettings.NativeFieldInfoPtr_textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "textSettings");
			PanelSettings.NativeFieldInfoPtr_m_TargetRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_TargetRect");
			PanelSettings.NativeFieldInfoPtr_m_ResolvedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_ResolvedScale");
			PanelSettings.NativeFieldInfoPtr_m_OldThemeUss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_OldThemeUss");
			PanelSettings.NativeFieldInfoPtr__ScreenDPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "<ScreenDPI>k__BackingField");
			PanelSettings.NativeFieldInfoPtr_m_AssignedScreenToPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "m_AssignedScreenToPanel");
			PanelSettings.NativeMethodInfoPtr_get_themeStyleSheet_Public_get_ThemeStyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666712);
			PanelSettings.NativeMethodInfoPtr_set_themeStyleSheet_Public_set_Void_ThemeStyleSheet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666713);
			PanelSettings.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666714);
			PanelSettings.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666715);
			PanelSettings.NativeMethodInfoPtr_get_scaleMode_Public_get_PanelScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666716);
			PanelSettings.NativeMethodInfoPtr_set_scaleMode_Public_set_Void_PanelScaleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666717);
			PanelSettings.NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666718);
			PanelSettings.NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666719);
			PanelSettings.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666720);
			PanelSettings.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666721);
			PanelSettings.NativeMethodInfoPtr_get_referenceDpi_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666722);
			PanelSettings.NativeMethodInfoPtr_set_referenceDpi_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666723);
			PanelSettings.NativeMethodInfoPtr_get_fallbackDpi_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666724);
			PanelSettings.NativeMethodInfoPtr_set_fallbackDpi_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666725);
			PanelSettings.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666726);
			PanelSettings.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666727);
			PanelSettings.NativeMethodInfoPtr_get_screenMatchMode_Public_get_PanelScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666728);
			PanelSettings.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_PanelScreenMatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666729);
			PanelSettings.NativeMethodInfoPtr_get_match_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666730);
			PanelSettings.NativeMethodInfoPtr_set_match_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666731);
			PanelSettings.NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666732);
			PanelSettings.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666733);
			PanelSettings.NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666734);
			PanelSettings.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666735);
			PanelSettings.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666736);
			PanelSettings.NativeMethodInfoPtr_get_clearDepthStencil_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666737);
			PanelSettings.NativeMethodInfoPtr_set_clearDepthStencil_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666738);
			PanelSettings.NativeMethodInfoPtr_get_depthClearValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666739);
			PanelSettings.NativeMethodInfoPtr_get_clearColor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666740);
			PanelSettings.NativeMethodInfoPtr_set_clearColor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666741);
			PanelSettings.NativeMethodInfoPtr_get_colorClearValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666742);
			PanelSettings.NativeMethodInfoPtr_set_colorClearValue_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666743);
			PanelSettings.NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666744);
			PanelSettings.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666745);
			PanelSettings.NativeMethodInfoPtr_get_visualTree_Internal_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666746);
			PanelSettings.NativeMethodInfoPtr_get_dynamicAtlasSettings_Public_get_DynamicAtlasSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666747);
			PanelSettings.NativeMethodInfoPtr_set_dynamicAtlasSettings_Public_set_Void_DynamicAtlasSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666748);
			PanelSettings.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666749);
			PanelSettings.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666750);
			PanelSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666751);
			PanelSettings.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666752);
			PanelSettings.NativeMethodInfoPtr_DisposePanel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666753);
			PanelSettings.NativeMethodInfoPtr_get_ScreenDPI_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666754);
			PanelSettings.NativeMethodInfoPtr_set_ScreenDPI_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666755);
			PanelSettings.NativeMethodInfoPtr_UpdateScreenDPI_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666756);
			PanelSettings.NativeMethodInfoPtr_ApplyThemeStyleSheet_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666757);
			PanelSettings.NativeMethodInfoPtr_InitializeShaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666758);
			PanelSettings.NativeMethodInfoPtr_ApplyPanelSettings_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666759);
			PanelSettings.NativeMethodInfoPtr_SetScreenToPanelSpaceFunction_Public_Void_Func_2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666760);
			PanelSettings.NativeMethodInfoPtr_ResolveScale_Internal_Single_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666761);
			PanelSettings.NativeMethodInfoPtr_GetDisplayRect_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666762);
			PanelSettings.NativeMethodInfoPtr_AttachAndInsertUIDocumentToVisualTree_Internal_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666763);
			PanelSettings.NativeMethodInfoPtr_DetachUIDocument_Internal_Void_UIDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, 100666764);
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x0006E774 File Offset: 0x0006C974
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		public unsafe ThemeStyleSheet themeStyleSheet
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_themeStyleSheet_Public_get_ThemeStyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThemeStyleSheet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318212, XrefRangeEnd = 318214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_themeStyleSheet_Public_set_Void_ThemeStyleSheet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0006E7F8 File Offset: 0x0006C9F8
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x0006E838 File Offset: 0x0006CA38
		public unsafe RenderTexture targetTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318214, XrefRangeEnd = 318216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0006E87C File Offset: 0x0006CA7C
		// (set) Token: 0x060016DC RID: 5852 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
		public unsafe PanelScaleMode scaleMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_scaleMode_Public_get_PanelScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_scaleMode_Public_set_Void_PanelScaleMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0006E8F8 File Offset: 0x0006CAF8
		// (set) Token: 0x060016DE RID: 5854 RVA: 0x0006E934 File Offset: 0x0006CB34
		public unsafe float referenceSpritePixelsPerUnit
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 318216, RefRangeEnd = 318232, XrefRangeStart = 318216, XrefRangeEnd = 318216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318232, RefRangeEnd = 318235, XrefRangeStart = 318232, XrefRangeEnd = 318232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0006E974 File Offset: 0x0006CB74
		// (set) Token: 0x060016E0 RID: 5856 RVA: 0x0006E9B0 File Offset: 0x0006CBB0
		public unsafe float scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0006EA2C File Offset: 0x0006CC2C
		public unsafe float referenceDpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_referenceDpi_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_referenceDpi_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0006EA6C File Offset: 0x0006CC6C
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		public unsafe float fallbackDpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_fallbackDpi_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_fallbackDpi_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0006EAE8 File Offset: 0x0006CCE8
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x0006EB24 File Offset: 0x0006CD24
		public unsafe Vector2Int referenceResolution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0006EB64 File Offset: 0x0006CD64
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x0006EBA0 File Offset: 0x0006CDA0
		public unsafe PanelScreenMatchMode screenMatchMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_screenMatchMode_Public_get_PanelScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_PanelScreenMatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0006EBE0 File Offset: 0x0006CDE0
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x0006EC1C File Offset: 0x0006CE1C
		public unsafe float match
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_match_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318239, RefRangeEnd = 318240, XrefRangeStart = 318239, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_match_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x0006EC5C File Offset: 0x0006CE5C
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x0006EC98 File Offset: 0x0006CE98
		public unsafe float sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318240, XrefRangeEnd = 318241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0006ECD8 File Offset: 0x0006CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318241, XrefRangeEnd = 318242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySortingOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0006ED0C File Offset: 0x0006CF0C
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x0006ED48 File Offset: 0x0006CF48
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x0006ED88 File Offset: 0x0006CF88
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		public unsafe bool clearDepthStencil
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_clearDepthStencil_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_clearDepthStencil_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0006EE04 File Offset: 0x0006D004
		public unsafe float depthClearValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_depthClearValue_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0006EE40 File Offset: 0x0006D040
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0006EE7C File Offset: 0x0006D07C
		public unsafe bool clearColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_clearColor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_clearColor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0006EEBC File Offset: 0x0006D0BC
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0006EEF8 File Offset: 0x0006D0F8
		public unsafe Color colorClearValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_colorClearValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_colorClearValue_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0006EF38 File Offset: 0x0006D138
		public unsafe BaseRuntimePanel panel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318245, XrefRangeEnd = 318247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0006EF78 File Offset: 0x0006D178
		public unsafe bool isInitialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x0006EFB4 File Offset: 0x0006D1B4
		public unsafe VisualElement visualTree
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318249, RefRangeEnd = 318250, XrefRangeStart = 318247, XrefRangeEnd = 318249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_visualTree_Internal_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0006EFF4 File Offset: 0x0006D1F4
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x0006F034 File Offset: 0x0006D234
		public unsafe DynamicAtlasSettings dynamicAtlasSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_dynamicAtlasSettings_Public_get_DynamicAtlasSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicAtlasSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_dynamicAtlasSettings_Public_set_Void_DynamicAtlasSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0006F078 File Offset: 0x0006D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318250, XrefRangeEnd = 318265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0006F0B4 File Offset: 0x0006D2B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0006F0E8 File Offset: 0x0006D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318265, XrefRangeEnd = 318281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0006F11C File Offset: 0x0006D31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318283, RefRangeEnd = 318284, XrefRangeStart = 318281, XrefRangeEnd = 318283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0006F150 File Offset: 0x0006D350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318283, RefRangeEnd = 318284, XrefRangeStart = 318283, XrefRangeEnd = 318284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposePanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_DisposePanel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x0006F184 File Offset: 0x0006D384
		// (set) Token: 0x06001702 RID: 5890 RVA: 0x0006F1C0 File Offset: 0x0006D3C0
		public unsafe float ScreenDPI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_get_ScreenDPI_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_set_ScreenDPI_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0006F200 File Offset: 0x0006D400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318284, XrefRangeEnd = 318285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScreenDPI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_UpdateScreenDPI_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0006F234 File Offset: 0x0006D434
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318302, RefRangeEnd = 318304, XrefRangeStart = 318285, XrefRangeEnd = 318302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyThemeStyleSheet(VisualElement root = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_ApplyThemeStyleSheet_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0006F278 File Offset: 0x0006D478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318331, RefRangeEnd = 318332, XrefRangeStart = 318304, XrefRangeEnd = 318331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeShaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_InitializeShaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0006F2AC File Offset: 0x0006D4AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318404, RefRangeEnd = 318405, XrefRangeStart = 318332, XrefRangeEnd = 318404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPanelSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_ApplyPanelSettings_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0006F2E0 File Offset: 0x0006D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318405, XrefRangeEnd = 318409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(screentoPanelSpaceFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_SetScreenToPanelSpaceFunction_Public_Void_Func_2_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0006F324 File Offset: 0x0006D524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318409, XrefRangeEnd = 318414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ResolveScale(Rect targetRect, float screenDpi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenDpi;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_ResolveScale_Internal_Single_Rect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0006F37C File Offset: 0x0006D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318414, XrefRangeEnd = 318424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetDisplayRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_GetDisplayRect_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0006F3B8 File Offset: 0x0006D5B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318436, RefRangeEnd = 318438, XrefRangeStart = 318424, XrefRangeEnd = 318436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDocument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_AttachAndInsertUIDocumentToVisualTree_Internal_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0006F3FC File Offset: 0x0006D5FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318447, RefRangeEnd = 318450, XrefRangeStart = 318438, XrefRangeEnd = 318447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachUIDocument(UIDocument uiDocument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiDocument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.NativeMethodInfoPtr_DetachUIDocument_Internal_Void_UIDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public PanelSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0006F440 File Offset: 0x0006D640
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000A8B9 File Offset: 0x00008AB9
		public unsafe static int k_DefaultSortingOrder
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PanelSettings.NativeFieldInfoPtr_k_DefaultSortingOrder, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelSettings.NativeFieldInfoPtr_k_DefaultSortingOrder, (void*)(&value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0006F45C File Offset: 0x0006D65C
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000A8C7 File Offset: 0x00008AC7
		public unsafe static float k_DefaultScaleValue
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PanelSettings.NativeFieldInfoPtr_k_DefaultScaleValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelSettings.NativeFieldInfoPtr_k_DefaultScaleValue, (void*)(&value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x0006F478 File Offset: 0x0006D678
		// (set) Token: 0x06001712 RID: 5906 RVA: 0x0000A8D5 File Offset: 0x00008AD5
		public unsafe static string k_DefaultStyleSheetPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PanelSettings.NativeFieldInfoPtr_k_DefaultStyleSheetPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelSettings.NativeFieldInfoPtr_k_DefaultStyleSheetPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x0006F498 File Offset: 0x0006D698
		// (set) Token: 0x06001714 RID: 5908 RVA: 0x0000A8E7 File Offset: 0x00008AE7
		public unsafe ThemeStyleSheet themeUss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_themeUss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThemeStyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_themeUss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x0006F4C8 File Offset: 0x0006D6C8
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0000A906 File Offset: 0x00008B06
		public unsafe RenderTexture m_TargetTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x0006F4F8 File Offset: 0x0006D6F8
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x0000A925 File Offset: 0x00008B25
		public unsafe PanelScaleMode m_ScaleMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ScaleMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ScaleMode)) = value;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x0006F520 File Offset: 0x0006D720
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0000A940 File Offset: 0x00008B40
		public unsafe float m_ReferenceSpritePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceSpritePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceSpritePixelsPerUnit)) = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x0006F548 File Offset: 0x0006D748
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0000A95B File Offset: 0x00008B5B
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x0006F570 File Offset: 0x0006D770
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x0000A976 File Offset: 0x00008B76
		public unsafe static float DefaultDpi
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(PanelSettings.NativeFieldInfoPtr_DefaultDpi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PanelSettings.NativeFieldInfoPtr_DefaultDpi, (void*)(&value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x0006F58C File Offset: 0x0006D78C
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x0000A984 File Offset: 0x00008B84
		public unsafe float m_ReferenceDpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceDpi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceDpi)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x0006F5B4 File Offset: 0x0006D7B4
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x0000A99F File Offset: 0x00008B9F
		public unsafe float m_FallbackDpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_FallbackDpi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_FallbackDpi)) = value;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x0006F5DC File Offset: 0x0006D7DC
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x0000A9BA File Offset: 0x00008BBA
		public unsafe Vector2Int m_ReferenceResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ReferenceResolution)) = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x0006F604 File Offset: 0x0006D804
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x0000A9D5 File Offset: 0x00008BD5
		public unsafe PanelScreenMatchMode m_ScreenMatchMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ScreenMatchMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ScreenMatchMode)) = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x0006F62C File Offset: 0x0006D82C
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x0000A9F0 File Offset: 0x00008BF0
		public unsafe float m_Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_Match);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_Match)) = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x0006F654 File Offset: 0x0006D854
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x0000AA0B File Offset: 0x00008C0B
		public unsafe float m_SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_SortingOrder)) = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x0006F67C File Offset: 0x0006D87C
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x0000AA26 File Offset: 0x00008C26
		public unsafe int m_TargetDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetDisplay)) = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x0006F6A4 File Offset: 0x0006D8A4
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x0000AA41 File Offset: 0x00008C41
		public unsafe bool m_ClearDepthStencil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ClearDepthStencil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ClearDepthStencil)) = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0006F6CC File Offset: 0x0006D8CC
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x0000AA5C File Offset: 0x00008C5C
		public unsafe bool m_ClearColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ClearColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ClearColor)) = value;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x0006F6F4 File Offset: 0x0006D8F4
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x0000AA77 File Offset: 0x00008C77
		public unsafe Color m_ColorClearValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ColorClearValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ColorClearValue)) = value;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x0006F71C File Offset: 0x0006D91C
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x0000AA92 File Offset: 0x00008C92
		public unsafe PanelSettings.RuntimePanelAccess m_PanelAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_PanelAccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelSettings.RuntimePanelAccess>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_PanelAccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x0006F74C File Offset: 0x0006D94C
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000AAB1 File Offset: 0x00008CB1
		public unsafe UIDocumentList m_AttachedUIDocumentsList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AttachedUIDocumentsList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIDocumentList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AttachedUIDocumentsList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x0006F77C File Offset: 0x0006D97C
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		public unsafe DynamicAtlasSettings m_DynamicAtlasSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_DynamicAtlasSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicAtlasSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_DynamicAtlasSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x0006F7AC File Offset: 0x0006D9AC
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000AAEF File Offset: 0x00008CEF
		public unsafe Shader m_AtlasBlitShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AtlasBlitShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AtlasBlitShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		// (set) Token: 0x0600173C RID: 5948 RVA: 0x0000AB0E File Offset: 0x00008D0E
		public unsafe Shader m_RuntimeShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_RuntimeShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_RuntimeShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x0006F80C File Offset: 0x0006DA0C
		// (set) Token: 0x0600173E RID: 5950 RVA: 0x0000AB2D File Offset: 0x00008D2D
		public unsafe Shader m_RuntimeWorldShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_RuntimeWorldShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_RuntimeWorldShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x0006F83C File Offset: 0x0006DA3C
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000AB4C File Offset: 0x00008D4C
		public unsafe PanelTextSettings textSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_textSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelTextSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_textSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0006F86C File Offset: 0x0006DA6C
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0000AB6B File Offset: 0x00008D6B
		public unsafe Rect m_TargetRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_TargetRect)) = value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0006F894 File Offset: 0x0006DA94
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0000AB86 File Offset: 0x00008D86
		public unsafe float m_ResolvedScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ResolvedScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_ResolvedScale)) = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x0006F8BC File Offset: 0x0006DABC
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x0000ABA1 File Offset: 0x00008DA1
		public unsafe StyleSheet m_OldThemeUss
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_OldThemeUss);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_OldThemeUss), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x0006F8EC File Offset: 0x0006DAEC
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public unsafe float _ScreenDPI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr__ScreenDPI_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr__ScreenDPI_k__BackingField)) = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x0006F914 File Offset: 0x0006DB14
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x0000ABDB File Offset: 0x00008DDB
		public unsafe Func<Vector2, Vector2> m_AssignedScreenToPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AssignedScreenToPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.NativeFieldInfoPtr_m_AssignedScreenToPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultSortingOrder;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultScaleValue;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeFieldInfoPtr_k_DefaultStyleSheetPath;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeFieldInfoPtr_themeUss;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetTexture;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeFieldInfoPtr_m_ScaleMode;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceSpritePixelsPerUnit;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDpi;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceDpi;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackDpi;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeFieldInfoPtr_m_ReferenceResolution;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeFieldInfoPtr_m_ScreenMatchMode;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeFieldInfoPtr_m_Match;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingOrder;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetDisplay;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDepthStencil;

		// Token: 0x04000FAA RID: 4010
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearColor;

		// Token: 0x04000FAB RID: 4011
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorClearValue;

		// Token: 0x04000FAC RID: 4012
		private static readonly IntPtr NativeFieldInfoPtr_m_PanelAccess;

		// Token: 0x04000FAD RID: 4013
		private static readonly IntPtr NativeFieldInfoPtr_m_AttachedUIDocumentsList;

		// Token: 0x04000FAE RID: 4014
		private static readonly IntPtr NativeFieldInfoPtr_m_DynamicAtlasSettings;

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasBlitShader;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeShader;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeWorldShader;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeFieldInfoPtr_textSettings;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetRect;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolvedScale;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeFieldInfoPtr_m_OldThemeUss;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeFieldInfoPtr__ScreenDPI_k__BackingField;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeFieldInfoPtr_m_AssignedScreenToPanel;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_get_themeStyleSheet_Public_get_ThemeStyleSheet_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_set_themeStyleSheet_Public_set_Void_ThemeStyleSheet_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_get_targetTexture_Public_get_RenderTexture_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_set_targetTexture_Public_set_Void_RenderTexture_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleMode_Public_get_PanelScaleMode_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleMode_Public_set_Void_PanelScaleMode_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceSpritePixelsPerUnit_Public_get_Single_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceSpritePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceDpi_Public_get_Single_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceDpi_Public_set_Void_Single_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackDpi_Public_get_Single_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackDpi_Public_set_Void_Single_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_get_referenceResolution_Public_get_Vector2Int_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_set_referenceResolution_Public_set_Void_Vector2Int_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_get_screenMatchMode_Public_get_PanelScreenMatchMode_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_set_screenMatchMode_Public_set_Void_PanelScreenMatchMode_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_get_match_Public_get_Single_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_set_match_Public_set_Void_Single_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Single_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Single_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_ApplySortingOrder_Internal_Void_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_get_clearDepthStencil_Public_get_Boolean_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_set_clearDepthStencil_Public_set_Void_Boolean_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_get_depthClearValue_Public_get_Single_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_get_clearColor_Public_get_Boolean_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_set_clearColor_Public_set_Void_Boolean_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_get_colorClearValue_Public_get_Color_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_set_colorClearValue_Public_set_Void_Color_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTree_Internal_get_VisualElement_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_get_dynamicAtlasSettings_Public_get_DynamicAtlasSettings_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_set_dynamicAtlasSettings_Public_set_Void_DynamicAtlasSettings_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_DisposePanel_Internal_Void_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenDPI_Private_get_Single_0;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenDPI_Private_set_Void_Single_0;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScreenDPI_Internal_Void_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_ApplyThemeStyleSheet_Private_Void_VisualElement_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_InitializeShaders_Private_Void_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPanelSettings_Internal_Void_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_SetScreenToPanelSpaceFunction_Public_Void_Func_2_Vector2_Vector2_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_ResolveScale_Internal_Single_Rect_Single_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayRect_Internal_Rect_0;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeMethodInfoPtr_AttachAndInsertUIDocumentToVisualTree_Internal_Void_UIDocument_0;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_DetachUIDocument_Internal_Void_UIDocument_0;

		// Token: 0x02000468 RID: 1128
		public class RuntimePanelAccess : Object
		{
			// Token: 0x06003C00 RID: 15360 RVA: 0x000F138C File Offset: 0x000EF58C
			// Note: this type is marked as 'beforefieldinit'.
			static RuntimePanelAccess()
			{
				Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PanelSettings>.NativeClassPtr, "RuntimePanelAccess");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr);
				PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, "m_Settings");
				PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_RuntimePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, "m_RuntimePanel");
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr__ctor_Internal_Void_PanelSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666765);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666766);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666767);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_DisposePanel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666768);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetTargetTexture_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666769);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetSortingPriority_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666770);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetTargetDisplay_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666771);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_CreateRelatedRuntimePanel_Private_BaseRuntimePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666772);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_DisposeRelatedPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666773);
				PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr, 100666774);
			}

			// Token: 0x06003C01 RID: 15361 RVA: 0x000F14A8 File Offset: 0x000EF6A8
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RuntimePanelAccess(PanelSettings settings)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelSettings.RuntimePanelAccess>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr__ctor_Internal_Void_PanelSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001238 RID: 4664
			// (get) Token: 0x06003C02 RID: 15362 RVA: 0x000F14F4 File Offset: 0x000EF6F4
			public unsafe bool isInitialized
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 318072, RefRangeEnd = 318096, XrefRangeStart = 318072, XrefRangeEnd = 318072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001239 RID: 4665
			// (get) Token: 0x06003C03 RID: 15363 RVA: 0x000F1530 File Offset: 0x000EF730
			public unsafe BaseRuntimePanel panel
			{
				[CallerCount(17)]
				[CachedScanResults(RefRangeStart = 318121, RefRangeEnd = 318138, XrefRangeStart = 318096, XrefRangeEnd = 318121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
				}
			}

			// Token: 0x06003C04 RID: 15364 RVA: 0x000F1570 File Offset: 0x000EF770
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318143, RefRangeEnd = 318145, XrefRangeStart = 318138, XrefRangeEnd = 318143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DisposePanel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_DisposePanel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C05 RID: 15365 RVA: 0x000F15A4 File Offset: 0x000EF7A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318145, XrefRangeEnd = 318146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetTargetTexture()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetTargetTexture_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C06 RID: 15366 RVA: 0x000F15D8 File Offset: 0x000EF7D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318146, XrefRangeEnd = 318147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSortingPriority()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetSortingPriority_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C07 RID: 15367 RVA: 0x000F160C File Offset: 0x000EF80C
			[CallerCount(0)]
			public unsafe void SetTargetDisplay()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_SetTargetDisplay_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C08 RID: 15368 RVA: 0x000F1640 File Offset: 0x000EF840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318147, XrefRangeEnd = 318159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseRuntimePanel CreateRelatedRuntimePanel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_CreateRelatedRuntimePanel_Private_BaseRuntimePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr3) : null;
			}

			// Token: 0x06003C09 RID: 15369 RVA: 0x000F1680 File Offset: 0x000EF880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318159, XrefRangeEnd = 318163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void DisposeRelatedPanel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_DisposeRelatedPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C0A RID: 15370 RVA: 0x000F16B4 File Offset: 0x000EF8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318163, XrefRangeEnd = 318167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MarkPotentiallyEmpty()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelSettings.RuntimePanelAccess.NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C0B RID: 15371 RVA: 0x00019316 File Offset: 0x00017516
			public RuntimePanelAccess(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x06003C0C RID: 15372 RVA: 0x000F16E8 File Offset: 0x000EF8E8
			// (set) Token: 0x06003C0D RID: 15373 RVA: 0x0001931F File Offset: 0x0001751F
			public unsafe PanelSettings m_Settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_Settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001237 RID: 4663
			// (get) Token: 0x06003C0E RID: 15374 RVA: 0x000F1718 File Offset: 0x000EF918
			// (set) Token: 0x06003C0F RID: 15375 RVA: 0x0001933E File Offset: 0x0001753E
			public unsafe BaseRuntimePanel m_RuntimePanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_RuntimePanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelSettings.RuntimePanelAccess.NativeFieldInfoPtr_m_RuntimePanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A49 RID: 10825
			private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

			// Token: 0x04002A4A RID: 10826
			private static readonly IntPtr NativeFieldInfoPtr_m_RuntimePanel;

			// Token: 0x04002A4B RID: 10827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PanelSettings_0;

			// Token: 0x04002A4C RID: 10828
			private static readonly IntPtr NativeMethodInfoPtr_get_isInitialized_Internal_get_Boolean_0;

			// Token: 0x04002A4D RID: 10829
			private static readonly IntPtr NativeMethodInfoPtr_get_panel_Internal_get_BaseRuntimePanel_0;

			// Token: 0x04002A4E RID: 10830
			private static readonly IntPtr NativeMethodInfoPtr_DisposePanel_Internal_Void_0;

			// Token: 0x04002A4F RID: 10831
			private static readonly IntPtr NativeMethodInfoPtr_SetTargetTexture_Internal_Void_0;

			// Token: 0x04002A50 RID: 10832
			private static readonly IntPtr NativeMethodInfoPtr_SetSortingPriority_Internal_Void_0;

			// Token: 0x04002A51 RID: 10833
			private static readonly IntPtr NativeMethodInfoPtr_SetTargetDisplay_Internal_Void_0;

			// Token: 0x04002A52 RID: 10834
			private static readonly IntPtr NativeMethodInfoPtr_CreateRelatedRuntimePanel_Private_BaseRuntimePanel_0;

			// Token: 0x04002A53 RID: 10835
			private static readonly IntPtr NativeMethodInfoPtr_DisposeRelatedPanel_Private_Void_0;

			// Token: 0x04002A54 RID: 10836
			private static readonly IntPtr NativeMethodInfoPtr_MarkPotentiallyEmpty_Internal_Void_0;
		}
	}
}

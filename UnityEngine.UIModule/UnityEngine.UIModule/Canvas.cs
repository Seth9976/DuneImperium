using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public sealed class Canvas : Behaviour
	{
		// Token: 0x0600005F RID: 95 RVA: 0x000043E4 File Offset: 0x000025E4
		// Note: this type is marked as 'beforefieldinit'.
		static Canvas()
		{
			Il2CppClassPointerStore<Canvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "Canvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Canvas>.NativeClassPtr);
			Canvas.NativeFieldInfoPtr_preWillRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "preWillRenderCanvases");
			Canvas.NativeFieldInfoPtr_willRenderCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "willRenderCanvases");
			Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externBeginRenderOverlays>k__BackingField");
			Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externRenderOverlaysBefore>k__BackingField");
			Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "<externEndRenderOverlays>k__BackingField");
			Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663379);
			Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663380);
			Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663381);
			Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663382);
			Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663383);
			Canvas.NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663384);
			Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663385);
			Canvas.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663386);
			Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663387);
			Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663388);
			Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663389);
			Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663390);
			Canvas.NativeMethodInfoPtr_get_overridePixelPerfect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663391);
			Canvas.NativeMethodInfoPtr_set_overridePixelPerfect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663392);
			Canvas.NativeMethodInfoPtr_get_vertexColorAlwaysGammaSpace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663393);
			Canvas.NativeMethodInfoPtr_set_vertexColorAlwaysGammaSpace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663394);
			Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663395);
			Canvas.NativeMethodInfoPtr_set_pixelPerfect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663396);
			Canvas.NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663397);
			Canvas.NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663398);
			Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663399);
			Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663400);
			Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663401);
			Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663402);
			Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663403);
			Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663404);
			Canvas.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663405);
			Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663406);
			Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663407);
			Canvas.NativeMethodInfoPtr_get_cachedSortingLayerValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663408);
			Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663409);
			Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663410);
			Canvas.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663411);
			Canvas.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663412);
			Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663413);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663414);
			Canvas.NativeMethodInfoPtr_get_updateRectTransformForStandalone_Public_get_StandaloneRenderResize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663415);
			Canvas.NativeMethodInfoPtr_set_updateRectTransformForStandalone_Public_set_Void_StandaloneRenderResize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663416);
			Canvas.NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663417);
			Canvas.NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663418);
			Canvas.NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663419);
			Canvas.NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663420);
			Canvas.NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663421);
			Canvas.NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663422);
			Canvas.NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663423);
			Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663424);
			Canvas.NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663425);
			Canvas.NativeMethodInfoPtr_get_normalizedSortingGridSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663426);
			Canvas.NativeMethodInfoPtr_set_normalizedSortingGridSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663427);
			Canvas.NativeMethodInfoPtr_get_sortingGridNormalizedSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663428);
			Canvas.NativeMethodInfoPtr_set_sortingGridNormalizedSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663429);
			Canvas.NativeMethodInfoPtr_GetDefaultCanvasTextMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663430);
			Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663431);
			Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663432);
			Canvas.NativeMethodInfoPtr_UpdateCanvasRectTransform_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663433);
			Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663434);
			Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663435);
			Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663436);
			Canvas.NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663437);
			Canvas.NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663438);
			Canvas.NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663439);
			Canvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663440);
			Canvas.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663441);
			Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas>.NativeClassPtr, 100663442);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004978 File Offset: 0x00002B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256927, RefRangeEnd = 1256928, XrefRangeStart = 1256920, XrefRangeEnd = 1256927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000049B0 File Offset: 0x00002BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256935, RefRangeEnd = 1256936, XrefRangeStart = 1256928, XrefRangeEnd = 1256935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000049E8 File Offset: 0x00002BE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1256943, RefRangeEnd = 1256947, XrefRangeStart = 1256936, XrefRangeEnd = 1256943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004A20 File Offset: 0x00002C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256947, XrefRangeEnd = 1256954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_willRenderCanvases(Canvas.WillRenderCanvases value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004A58 File Offset: 0x00002C58
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00004A94 File Offset: 0x00002C94
		public unsafe RenderMode renderMode
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 1256956, RefRangeEnd = 1256975, XrefRangeStart = 1256954, XrefRangeEnd = 1256956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1256977, RefRangeEnd = 1256978, XrefRangeStart = 1256975, XrefRangeEnd = 1256977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public unsafe bool isRootCanvas
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1256980, RefRangeEnd = 1256985, XrefRangeStart = 1256978, XrefRangeEnd = 1256980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe Rect pixelRect
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1256987, RefRangeEnd = 1256997, XrefRangeStart = 1256985, XrefRangeEnd = 1256987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004B4C File Offset: 0x00002D4C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004B88 File Offset: 0x00002D88
		public unsafe float scaleFactor
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1256999, RefRangeEnd = 1257006, XrefRangeStart = 1256997, XrefRangeEnd = 1256999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1257008, RefRangeEnd = 1257014, XrefRangeStart = 1257006, XrefRangeEnd = 1257008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004C04 File Offset: 0x00002E04
		public unsafe float referencePixelsPerUnit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1257016, RefRangeEnd = 1257019, XrefRangeStart = 1257014, XrefRangeEnd = 1257016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1257021, RefRangeEnd = 1257027, XrefRangeStart = 1257019, XrefRangeEnd = 1257021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004C44 File Offset: 0x00002E44
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004C80 File Offset: 0x00002E80
		public unsafe bool overridePixelPerfect
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257027, XrefRangeEnd = 1257029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_overridePixelPerfect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257029, XrefRangeEnd = 1257031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_overridePixelPerfect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004CC0 File Offset: 0x00002EC0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00004CFC File Offset: 0x00002EFC
		public unsafe bool vertexColorAlwaysGammaSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257031, XrefRangeEnd = 1257033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_vertexColorAlwaysGammaSpace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257033, XrefRangeEnd = 1257035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_vertexColorAlwaysGammaSpace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004D3C File Offset: 0x00002F3C
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00004D78 File Offset: 0x00002F78
		public unsafe bool pixelPerfect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1257037, RefRangeEnd = 1257039, XrefRangeStart = 1257035, XrefRangeEnd = 1257037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257039, XrefRangeEnd = 1257041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_pixelPerfect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00004DB8 File Offset: 0x00002FB8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00004DF4 File Offset: 0x00002FF4
		public unsafe float planeDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1257043, RefRangeEnd = 1257045, XrefRangeStart = 1257041, XrefRangeEnd = 1257043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1257047, RefRangeEnd = 1257049, XrefRangeStart = 1257045, XrefRangeEnd = 1257047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004E34 File Offset: 0x00003034
		public unsafe int renderOrder
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1257051, RefRangeEnd = 1257052, XrefRangeStart = 1257049, XrefRangeEnd = 1257051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004E70 File Offset: 0x00003070
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00004EAC File Offset: 0x000030AC
		public unsafe bool overrideSorting
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1257054, RefRangeEnd = 1257061, XrefRangeStart = 1257052, XrefRangeEnd = 1257054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1257063, RefRangeEnd = 1257069, XrefRangeStart = 1257061, XrefRangeEnd = 1257063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00004F28 File Offset: 0x00003128
		public unsafe int sortingOrder
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1257071, RefRangeEnd = 1257074, XrefRangeStart = 1257069, XrefRangeEnd = 1257071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1257076, RefRangeEnd = 1257081, XrefRangeStart = 1257074, XrefRangeEnd = 1257076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00004FA4 File Offset: 0x000031A4
		public unsafe int targetDisplay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1257083, RefRangeEnd = 1257086, XrefRangeStart = 1257081, XrefRangeEnd = 1257083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257086, XrefRangeEnd = 1257088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004FE4 File Offset: 0x000031E4
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00005020 File Offset: 0x00003220
		public unsafe int sortingLayerID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1257090, RefRangeEnd = 1257094, XrefRangeStart = 1257088, XrefRangeEnd = 1257090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1257096, RefRangeEnd = 1257100, XrefRangeStart = 1257094, XrefRangeEnd = 1257096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00005060 File Offset: 0x00003260
		public unsafe int cachedSortingLayerValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257100, XrefRangeEnd = 1257102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_cachedSortingLayerValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000509C File Offset: 0x0000329C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000050D8 File Offset: 0x000032D8
		public unsafe AdditionalCanvasShaderChannels additionalShaderChannels
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1257104, RefRangeEnd = 1257106, XrefRangeStart = 1257102, XrefRangeEnd = 1257104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1257108, RefRangeEnd = 1257109, XrefRangeStart = 1257106, XrefRangeEnd = 1257108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005118 File Offset: 0x00003318
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00005150 File Offset: 0x00003350
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257109, XrefRangeEnd = 1257111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257111, XrefRangeEnd = 1257113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005194 File Offset: 0x00003394
		public unsafe Canvas rootCanvas
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1257115, RefRangeEnd = 1257132, XrefRangeStart = 1257113, XrefRangeEnd = 1257115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000051D4 File Offset: 0x000033D4
		public unsafe Vector2 renderingDisplaySize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1257134, RefRangeEnd = 1257135, XrefRangeStart = 1257132, XrefRangeEnd = 1257134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005210 File Offset: 0x00003410
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000524C File Offset: 0x0000344C
		public unsafe StandaloneRenderResize updateRectTransformForStandalone
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257135, XrefRangeEnd = 1257137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_updateRectTransformForStandalone_Public_get_StandaloneRenderResize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257137, XrefRangeEnd = 1257139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_updateRectTransformForStandalone_Public_set_Void_StandaloneRenderResize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000528C File Offset: 0x0000348C
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000052C0 File Offset: 0x000034C0
		public unsafe static Action<int> externBeginRenderOverlays
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257139, XrefRangeEnd = 1257141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257141, XrefRangeEnd = 1257145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000052F8 File Offset: 0x000034F8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000532C File Offset: 0x0000352C
		public unsafe static Action<int, int> externRenderOverlaysBefore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257145, XrefRangeEnd = 1257147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257147, XrefRangeEnd = 1257151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00005364 File Offset: 0x00003564
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00005398 File Offset: 0x00003598
		public unsafe static Action<int> externEndRenderOverlays
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257151, XrefRangeEnd = 1257153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257153, XrefRangeEnd = 1257157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000053D0 File Offset: 0x000035D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1257159, RefRangeEnd = 1257161, XrefRangeStart = 1257157, XrefRangeEnd = 1257159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExternalCanvasEnabled(bool enabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005404 File Offset: 0x00003604
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00005444 File Offset: 0x00003644
		public unsafe Camera worldCamera
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1257163, RefRangeEnd = 1257176, XrefRangeStart = 1257161, XrefRangeEnd = 1257163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1257178, RefRangeEnd = 1257180, XrefRangeStart = 1257176, XrefRangeEnd = 1257178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005488 File Offset: 0x00003688
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000054C4 File Offset: 0x000036C4
		public unsafe float normalizedSortingGridSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257180, XrefRangeEnd = 1257182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_normalizedSortingGridSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257182, XrefRangeEnd = 1257184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_normalizedSortingGridSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00005504 File Offset: 0x00003704
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00005540 File Offset: 0x00003740
		public unsafe int sortingGridNormalizedSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257184, XrefRangeEnd = 1257186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_sortingGridNormalizedSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257186, XrefRangeEnd = 1257188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_set_sortingGridNormalizedSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005580 File Offset: 0x00003780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257188, XrefRangeEnd = 1257190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetDefaultCanvasTextMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetDefaultCanvasTextMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000055B4 File Offset: 0x000037B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1257192, RefRangeEnd = 1257194, XrefRangeStart = 1257190, XrefRangeEnd = 1257192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetDefaultCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000055E8 File Offset: 0x000037E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1257196, RefRangeEnd = 1257198, XrefRangeStart = 1257194, XrefRangeEnd = 1257196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Material GetETC1SupportedCanvasMaterial()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000561C File Offset: 0x0000381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257198, XrefRangeEnd = 1257200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvasRectTransform(bool alignWithCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alignWithCamera;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_UpdateCanvasRectTransform_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000565C File Offset: 0x0000385C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1257204, RefRangeEnd = 1257209, XrefRangeStart = 1257200, XrefRangeEnd = 1257204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceUpdateCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005684 File Offset: 0x00003884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257209, XrefRangeEnd = 1257211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendPreWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000056AC File Offset: 0x000038AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257211, XrefRangeEnd = 1257213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendWillRenderCanvases()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257213, XrefRangeEnd = 1257215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginRenderExtraOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005708 File Offset: 0x00003908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257215, XrefRangeEnd = 1257217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005748 File Offset: 0x00003948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257217, XrefRangeEnd = 1257219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndRenderExtraOverlays(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000577C File Offset: 0x0000397C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canvas()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000057B8 File Offset: 0x000039B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257219, XrefRangeEnd = 1257221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pixelRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000057F8 File Offset: 0x000039F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257221, XrefRangeEnd = 1257223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_renderingDisplaySize_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000020D0 File Offset: 0x000002D0
		public Canvas(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005838 File Offset: 0x00003A38
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000020D9 File Offset: 0x000002D9
		public unsafe static Canvas.WillRenderCanvases preWillRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_preWillRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00005860 File Offset: 0x00003A60
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000020EB File Offset: 0x000002EB
		public unsafe static Canvas.WillRenderCanvases willRenderCanvases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas.WillRenderCanvases>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr_willRenderCanvases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005888 File Offset: 0x00003A88
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000020FD File Offset: 0x000002FD
		public unsafe static Action<int> _externBeginRenderOverlays_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000058B0 File Offset: 0x00003AB0
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe static Action<int, int> _externRenderOverlaysBefore_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000058D8 File Offset: 0x00003AD8
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002121 File Offset: 0x00000321
		public unsafe static Action<int> _externEndRenderOverlays_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Canvas.NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_preWillRenderCanvases;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_willRenderCanvases;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr__externBeginRenderOverlays_k__BackingField;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr__externRenderOverlaysBefore_k__BackingField;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr__externEndRenderOverlays_k__BackingField;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_add_preWillRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_remove_preWillRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_add_willRenderCanvases_Public_Static_add_Void_WillRenderCanvases_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_remove_willRenderCanvases_Public_Static_rem_Void_WillRenderCanvases_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_renderMode_Public_get_RenderMode_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_renderMode_Public_set_Void_RenderMode_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_isRootCanvas_Public_get_Boolean_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Public_get_Rect_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_scaleFactor_Public_get_Single_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_scaleFactor_Public_set_Void_Single_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_referencePixelsPerUnit_Public_get_Single_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_referencePixelsPerUnit_Public_set_Void_Single_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_overridePixelPerfect_Public_get_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_overridePixelPerfect_Public_set_Void_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_vertexColorAlwaysGammaSpace_Public_get_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_vertexColorAlwaysGammaSpace_Public_set_Void_Boolean_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelPerfect_Public_get_Boolean_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelPerfect_Public_set_Void_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_planeDistance_Public_get_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_set_planeDistance_Public_set_Void_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrder_Public_get_Int32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSorting_Public_get_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSorting_Public_set_Void_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_targetDisplay_Public_get_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_set_targetDisplay_Public_set_Void_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_cachedSortingLayerValue_Public_get_Int32_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_additionalShaderChannels_Public_get_AdditionalCanvasShaderChannels_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_set_additionalShaderChannels_Public_set_Void_AdditionalCanvasShaderChannels_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvas_Public_get_Canvas_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Public_get_Vector2_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRectTransformForStandalone_Public_get_StandaloneRenderResize_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_updateRectTransformForStandalone_Public_set_Void_StandaloneRenderResize_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_externBeginRenderOverlays_Internal_Static_get_Action_1_Int32_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_externBeginRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_externRenderOverlaysBefore_Internal_Static_get_Action_2_Int32_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_externRenderOverlaysBefore_Internal_Static_set_Void_Action_2_Int32_Int32_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_externEndRenderOverlays_Internal_Static_get_Action_1_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_set_externEndRenderOverlays_Internal_Static_set_Void_Action_1_Int32_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_SetExternalCanvasEnabled_Internal_Static_Void_Boolean_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_worldCamera_Public_get_Camera_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_worldCamera_Public_set_Void_Camera_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_normalizedSortingGridSize_Public_get_Single_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_normalizedSortingGridSize_Public_set_Void_Single_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingGridNormalizedSize_Public_get_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingGridNormalizedSize_Public_set_Void_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCanvasTextMaterial_Public_Static_Material_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultCanvasMaterial_Public_Static_Material_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GetETC1SupportedCanvasMaterial_Public_Static_Material_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvasRectTransform_Internal_Void_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateCanvases_Public_Static_Void_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_SendPreWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_SendWillRenderCanvases_Private_Static_Void_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_BeginRenderExtraOverlays_Private_Static_Void_Int32_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_RenderExtraOverlaysBefore_Private_Static_Void_Int32_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_EndRenderExtraOverlays_Private_Static_Void_Int32_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingDisplaySize_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x0200000B RID: 11
		public sealed class WillRenderCanvases : MulticastDelegate
		{
			// Token: 0x060000B0 RID: 176 RVA: 0x0000213C File Offset: 0x0000033C
			// Note: this type is marked as 'beforefieldinit'.
			static WillRenderCanvases()
			{
				Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Canvas>.NativeClassPtr, "WillRenderCanvases");
				Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663443);
				Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr, 100663444);
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00005A1C File Offset: 0x00003C1C
			[CallerCount(288)]
			[CachedScanResults(RefRangeStart = 320972, RefRangeEnd = 321260, XrefRangeStart = 320972, XrefRangeEnd = 321260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WillRenderCanvases(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Canvas.WillRenderCanvases>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00005A78 File Offset: 0x00003C78
			[CallerCount(0)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Canvas.WillRenderCanvases.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x0000217A File Offset: 0x0000037A
			public WillRenderCanvases(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x00002183 File Offset: 0x00000383
			public static implicit operator Canvas.WillRenderCanvases(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Canvas.WillRenderCanvases>(A_0);
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x0000218B File Offset: 0x0000038B
			public static Canvas.WillRenderCanvases operator +(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Canvas.WillRenderCanvases>();
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00002199 File Offset: 0x00000399
			public static Canvas.WillRenderCanvases operator -(Canvas.WillRenderCanvases A_0, Canvas.WillRenderCanvases A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Canvas.WillRenderCanvases>();
				}
				return delegate2;
			}

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	// Token: 0x02000016 RID: 22
	public class Image : MaskableGraphic
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		// Note: this type is marked as 'beforefieldinit'.
		static Image()
		{
			Il2CppClassPointerStore<Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Image");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image>.NativeClassPtr);
			Image.NativeFieldInfoPtr_s_ETC1DefaultUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_ETC1DefaultUI");
			Image.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Sprite");
			Image.NativeFieldInfoPtr_m_OverrideSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_OverrideSprite");
			Image.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Type");
			Image.NativeFieldInfoPtr_m_PreserveAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_PreserveAspect");
			Image.NativeFieldInfoPtr_m_FillCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillCenter");
			Image.NativeFieldInfoPtr_m_FillMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillMethod");
			Image.NativeFieldInfoPtr_m_FillAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillAmount");
			Image.NativeFieldInfoPtr_m_FillClockwise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillClockwise");
			Image.NativeFieldInfoPtr_m_FillOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_FillOrigin");
			Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_AlphaHitTestMinimumThreshold");
			Image.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_Tracked");
			Image.NativeFieldInfoPtr_m_UseSpriteMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_UseSpriteMesh");
			Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_PixelsPerUnitMultiplier");
			Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_CachedReferencePixelsPerUnit");
			Image.NativeFieldInfoPtr_s_VertScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_VertScratch");
			Image.NativeFieldInfoPtr_s_UVScratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_UVScratch");
			Image.NativeFieldInfoPtr_s_Xy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Xy");
			Image.NativeFieldInfoPtr_s_Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Uv");
			Image.NativeFieldInfoPtr_m_TrackedTexturelessImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "m_TrackedTexturelessImages");
			Image.NativeFieldInfoPtr_s_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "s_Initialized");
			Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663613);
			Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663614);
			Image.NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663615);
			Image.NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663616);
			Image.NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663617);
			Image.NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663618);
			Image.NativeMethodInfoPtr_get_type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663619);
			Image.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663620);
			Image.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663621);
			Image.NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663622);
			Image.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663623);
			Image.NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663624);
			Image.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663625);
			Image.NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663626);
			Image.NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663627);
			Image.NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663628);
			Image.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663629);
			Image.NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663630);
			Image.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663631);
			Image.NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663632);
			Image.NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663633);
			Image.NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663634);
			Image.NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663635);
			Image.NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663636);
			Image.NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663637);
			Image.NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663638);
			Image.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663639);
			Image.NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663640);
			Image.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663641);
			Image.NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663642);
			Image.NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663643);
			Image.NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663644);
			Image.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663645);
			Image.NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663646);
			Image.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663647);
			Image.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663648);
			Image.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663649);
			Image.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663650);
			Image.NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663651);
			Image.NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663652);
			Image.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663653);
			Image.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663654);
			Image.NativeMethodInfoPtr_TrackSprite_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663655);
			Image.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663656);
			Image.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663657);
			Image.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663658);
			Image.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663659);
			Image.NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663660);
			Image.NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663661);
			Image.NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663662);
			Image.NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663663);
			Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663664);
			Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663665);
			Image.NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663666);
			Image.NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663667);
			Image.NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663668);
			Image.NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663669);
			Image.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663670);
			Image.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663671);
			Image.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663672);
			Image.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663673);
			Image.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663674);
			Image.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663675);
			Image.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663676);
			Image.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663677);
			Image.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663678);
			Image.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663679);
			Image.NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663680);
			Image.NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663681);
			Image.NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663682);
			Image.NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663683);
			Image.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663684);
			Image.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663686);
			Image.NativeMethodInfoPtr_Method_Private_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100663687);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000F04C File Offset: 0x0000D24C
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000F08C File Offset: 0x0000D28C
		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 1085058, RefRangeEnd = 1085123, XrefRangeStart = 1085041, XrefRangeEnd = 1085058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		[CallerCount(0)]
		public unsafe void DisableSpriteOptimizations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000F104 File Offset: 0x0000D304
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000F144 File Offset: 0x0000D344
		public unsafe Sprite overrideSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085123, XrefRangeEnd = 1085124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1085128, RefRangeEnd = 1085129, XrefRangeStart = 1085124, XrefRangeEnd = 1085128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000F188 File Offset: 0x0000D388
		public unsafe Sprite activeSprite
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 1085133, RefRangeEnd = 1085191, XrefRangeStart = 1085129, XrefRangeEnd = 1085133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000F204 File Offset: 0x0000D404
		public unsafe Image.Type type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1085194, RefRangeEnd = 1085201, XrefRangeStart = 1085191, XrefRangeEnd = 1085194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_type_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000F244 File Offset: 0x0000D444
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000F280 File Offset: 0x0000D480
		public unsafe bool preserveAspect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085201, XrefRangeEnd = 1085204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000F2C0 File Offset: 0x0000D4C0
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000F2FC File Offset: 0x0000D4FC
		public unsafe bool fillCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085204, XrefRangeEnd = 1085207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000F33C File Offset: 0x0000D53C
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000F378 File Offset: 0x0000D578
		public unsafe Image.FillMethod fillMethod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085207, XrefRangeEnd = 1085210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
		public unsafe float fillAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1085214, RefRangeEnd = 1085216, XrefRangeStart = 1085210, XrefRangeEnd = 1085214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000F434 File Offset: 0x0000D634
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000F470 File Offset: 0x0000D670
		public unsafe bool fillClockwise
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085216, XrefRangeEnd = 1085219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000F4EC File Offset: 0x0000D6EC
		public unsafe int fillOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085219, XrefRangeEnd = 1085222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000F52C File Offset: 0x0000D72C
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000F568 File Offset: 0x0000D768
		public unsafe float eventAlphaThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085222, XrefRangeEnd = 1085233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000F5A8 File Offset: 0x0000D7A8
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public unsafe float alphaHitTestMinimumThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085233, XrefRangeEnd = 1085244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000F624 File Offset: 0x0000D824
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000F660 File Offset: 0x0000D860
		public unsafe bool useSpriteMesh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085244, XrefRangeEnd = 1085247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085247, XrefRangeEnd = 1085248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Image()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		public unsafe static Material defaultETC1GraphicMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085248, XrefRangeEnd = 1085265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000F710 File Offset: 0x0000D910
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085265, XrefRangeEnd = 1085284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000F75C File Offset: 0x0000D95C
		public unsafe bool hasBorder
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1085289, RefRangeEnd = 1085293, XrefRangeStart = 1085284, XrefRangeEnd = 1085289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000F798 File Offset: 0x0000D998
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		public unsafe float pixelsPerUnitMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000F814 File Offset: 0x0000DA14
		public unsafe float pixelsPerUnit
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1085310, RefRangeEnd = 1085321, XrefRangeStart = 1085293, XrefRangeEnd = 1085310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000F850 File Offset: 0x0000DA50
		public unsafe float multipliedPixelsPerUnit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085321, XrefRangeEnd = 1085322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000F88C File Offset: 0x0000DA8C
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		public unsafe override Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085322, XrefRangeEnd = 1085355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000F928 File Offset: 0x0000DB28
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000F964 File Offset: 0x0000DB64
		[CallerCount(0)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1085360, RefRangeEnd = 1085363, XrefRangeStart = 1085355, XrefRangeEnd = 1085360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1085388, RefRangeEnd = 1085390, XrefRangeStart = 1085363, XrefRangeEnd = 1085388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shouldPreserveAspect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085390, XrefRangeEnd = 1085416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000FA74 File Offset: 0x0000DC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085416, XrefRangeEnd = 1085427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPopulateMesh(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1085465, RefRangeEnd = 1085468, XrefRangeStart = 1085427, XrefRangeEnd = 1085465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackSprite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_TrackSprite_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085468, XrefRangeEnd = 1085470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000FB34 File Offset: 0x0000DD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085470, XrefRangeEnd = 1085481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085481, XrefRangeEnd = 1085499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085499, XrefRangeEnd = 1085513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085535, RefRangeEnd = 1085536, XrefRangeStart = 1085513, XrefRangeEnd = 1085535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lPreserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000FC38 File Offset: 0x0000DE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085576, RefRangeEnd = 1085577, XrefRangeStart = 1085536, XrefRangeEnd = 1085576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lPreserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000FC88 File Offset: 0x0000DE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085635, RefRangeEnd = 1085636, XrefRangeStart = 1085577, XrefRangeEnd = 1085635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateSlicedSprite(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000FCCC File Offset: 0x0000DECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085712, RefRangeEnd = 1085713, XrefRangeStart = 1085636, XrefRangeEnd = 1085712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTiledSprite(VertexHelper toFill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000FD10 File Offset: 0x0000DF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085719, RefRangeEnd = 1085720, XrefRangeStart = 1085713, XrefRangeEnd = 1085719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddQuad(VertexHelper vertexHelper, Il2CppStructArray<Vector3> quadPositions, Color32 color, Il2CppStructArray<Vector3> quadUVs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertexHelper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadPositions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadUVs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000FD78 File Offset: 0x0000DF78
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1085728, RefRangeEnd = 1085738, XrefRangeStart = 1085720, XrefRangeEnd = 1085728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertexHelper);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref posMax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvMin;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uvMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000FDF4 File Offset: 0x0000DFF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1085755, RefRangeEnd = 1085758, XrefRangeStart = 1085738, XrefRangeEnd = 1085755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref border;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref adjustedRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000FE4C File Offset: 0x0000E04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085833, RefRangeEnd = 1085834, XrefRangeStart = 1085758, XrefRangeEnd = 1085833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toFill);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveAspect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000FE9C File Offset: 0x0000E09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085835, RefRangeEnd = 1085836, XrefRangeStart = 1085834, XrefRangeEnd = 1085835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RadialCut(Il2CppStructArray<Vector3> xy, Il2CppStructArray<Vector3> uv, float fill, bool invert, int corner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uv);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fill;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref corner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000FF1C File Offset: 0x0000E11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085836, XrefRangeEnd = 1085841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RadialCut(Il2CppStructArray<Vector3> xy, float cos, float sin, bool invert, int corner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref corner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000FF8C File Offset: 0x0000E18C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000FFC8 File Offset: 0x0000E1C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00010004 File Offset: 0x0000E204
		public unsafe virtual float minWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0001004C File Offset: 0x0000E24C
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085841, XrefRangeEnd = 1085849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00010094 File Offset: 0x0000E294
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000231 RID: 561 RVA: 0x000100DC File Offset: 0x0000E2DC
		public unsafe virtual float minHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 122524, RefRangeEnd = 122525, XrefRangeStart = 122524, XrefRangeEnd = 122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00010124 File Offset: 0x0000E324
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085849, XrefRangeEnd = 1085857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0001016C File Offset: 0x0000E36C
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000234 RID: 564 RVA: 0x000101B4 File Offset: 0x0000E3B4
		public unsafe virtual int layoutPriority
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000101FC File Offset: 0x0000E3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085857, XrefRangeEnd = 1085892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref screenPoint;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00010264 File Offset: 0x0000E464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1085926, RefRangeEnd = 1085927, XrefRangeStart = 1085892, XrefRangeEnd = 1085926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref local;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000102BC File Offset: 0x0000E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085927, XrefRangeEnd = 1085956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildImage(SpriteAtlas spriteAtlas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteAtlas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000102F4 File Offset: 0x0000E4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085956, XrefRangeEnd = 1085984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackImage(Image g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001032C File Offset: 0x0000E52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085984, XrefRangeEnd = 1085992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnTrackImage(Image g)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00010364 File Offset: 0x0000E564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1085992, XrefRangeEnd = 1085993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Image.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000103A0 File Offset: 0x0000E5A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1086014, RefRangeEnd = 1086015, XrefRangeStart = 1085993, XrefRangeEnd = 1086014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000103D4 File Offset: 0x0000E5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1086015, XrefRangeEnd = 1086030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Boolean_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Image.NativeMethodInfoPtr_Method_Private_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002B45 File Offset: 0x00000D45
		public Image(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00010410 File Offset: 0x0000E610
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002B4E File Offset: 0x00000D4E
		public unsafe static Material s_ETC1DefaultUI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_ETC1DefaultUI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_ETC1DefaultUI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00010438 File Offset: 0x0000E638
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002B60 File Offset: 0x00000D60
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00010468 File Offset: 0x0000E668
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002B7F File Offset: 0x00000D7F
		public unsafe Sprite m_OverrideSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_OverrideSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_OverrideSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00010498 File Offset: 0x0000E698
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002B9E File Offset: 0x00000D9E
		public unsafe Image.Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000104C0 File Offset: 0x0000E6C0
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public unsafe bool m_PreserveAspect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PreserveAspect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PreserveAspect)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000104E8 File Offset: 0x0000E6E8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public unsafe bool m_FillCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillCenter)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00010510 File Offset: 0x0000E710
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002BEF File Offset: 0x00000DEF
		public unsafe Image.FillMethod m_FillMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillMethod)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00010538 File Offset: 0x0000E738
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002C0A File Offset: 0x00000E0A
		public unsafe float m_FillAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillAmount)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00010560 File Offset: 0x0000E760
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002C25 File Offset: 0x00000E25
		public unsafe bool m_FillClockwise
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillClockwise);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillClockwise)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00010588 File Offset: 0x0000E788
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00002C40 File Offset: 0x00000E40
		public unsafe int m_FillOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_FillOrigin)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000252 RID: 594 RVA: 0x000105B0 File Offset: 0x0000E7B0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002C5B File Offset: 0x00000E5B
		public unsafe float m_AlphaHitTestMinimumThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000105D8 File Offset: 0x0000E7D8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002C76 File Offset: 0x00000E76
		public unsafe bool m_Tracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Tracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_Tracked)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00010600 File Offset: 0x0000E800
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002C91 File Offset: 0x00000E91
		public unsafe bool m_UseSpriteMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UseSpriteMesh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_UseSpriteMesh)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00010628 File Offset: 0x0000E828
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002CAC File Offset: 0x00000EAC
		public unsafe float m_PixelsPerUnitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_PixelsPerUnitMultiplier)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00010650 File Offset: 0x0000E850
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002CC7 File Offset: 0x00000EC7
		public unsafe float m_CachedReferencePixelsPerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Image.NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00010678 File Offset: 0x0000E878
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002CE2 File Offset: 0x00000EE2
		public unsafe static Il2CppStructArray<Vector2> s_VertScratch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_VertScratch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_VertScratch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600025E RID: 606 RVA: 0x000106A0 File Offset: 0x0000E8A0
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public unsafe static Il2CppStructArray<Vector2> s_UVScratch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_UVScratch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_UVScratch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000106C8 File Offset: 0x0000E8C8
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002D06 File Offset: 0x00000F06
		public unsafe static Il2CppStructArray<Vector3> s_Xy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Xy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Xy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000106F0 File Offset: 0x0000E8F0
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002D18 File Offset: 0x00000F18
		public unsafe static Il2CppStructArray<Vector3> s_Uv
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Uv, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Uv, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00010718 File Offset: 0x0000E918
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002D2A File Offset: 0x00000F2A
		public unsafe static List<Image> m_TrackedTexturelessImages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_m_TrackedTexturelessImages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Image>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_m_TrackedTexturelessImages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00010740 File Offset: 0x0000E940
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002D3C File Offset: 0x00000F3C
		public unsafe static bool s_Initialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Image.NativeFieldInfoPtr_s_Initialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Image.NativeFieldInfoPtr_s_Initialized, (void*)(&value));
			}
		}

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_s_ETC1DefaultUI;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideSprite;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_m_PreserveAspect;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_m_FillCenter;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_m_FillMethod;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_m_FillAmount;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_m_FillClockwise;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_m_FillOrigin;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaHitTestMinimumThreshold;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_m_UseSpriteMesh;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_m_PixelsPerUnitMultiplier;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedReferencePixelsPerUnit;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_s_VertScratch;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_s_UVScratch;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_s_Xy;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_s_Uv;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedTexturelessImages;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_s_Initialized;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_DisableSpriteOptimizations_Public_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_overrideSprite_Public_get_Sprite_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideSprite_Public_set_Void_Sprite_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_activeSprite_Private_get_Sprite_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_Type_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_Type_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_preserveAspect_Public_get_Boolean_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_set_preserveAspect_Public_set_Void_Boolean_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_fillCenter_Public_get_Boolean_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_set_fillCenter_Public_set_Void_Boolean_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_get_fillMethod_Public_get_FillMethod_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_set_fillMethod_Public_set_Void_FillMethod_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_fillAmount_Public_get_Single_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_set_fillAmount_Public_set_Void_Single_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_fillClockwise_Public_get_Boolean_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_set_fillClockwise_Public_set_Void_Boolean_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_fillOrigin_Public_get_Int32_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_set_fillOrigin_Public_set_Void_Int32_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_eventAlphaThreshold_Public_get_Single_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_set_eventAlphaThreshold_Public_set_Void_Single_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaHitTestMinimumThreshold_Public_get_Single_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaHitTestMinimumThreshold_Public_set_Void_Single_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_get_useSpriteMesh_Public_get_Boolean_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_set_useSpriteMesh_Public_set_Void_Boolean_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultETC1GraphicMaterial_Public_Static_get_Material_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_get_hasBorder_Public_get_Boolean_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnitMultiplier_Public_get_Single_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelsPerUnitMultiplier_Public_set_Void_Single_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_get_multipliedPixelsPerUnit_Protected_get_Single_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_PreserveSpriteAspectRatio_Private_Void_byref_Rect_Vector2_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_GetDrawingDimensions_Private_Vector4_Boolean_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_Void_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_Void_VertexHelper_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_TrackSprite_Private_Void_1;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSimpleSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSlicedSprite_Private_Void_VertexHelper_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTiledSprite_Private_Void_VertexHelper_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Il2CppStructArray_1_Vector3_Color32_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_AddQuad_Private_Static_Void_VertexHelper_Vector2_Vector2_Color32_Vector2_Vector2_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustedBorders_Private_Vector4_Vector4_Rect_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_GenerateFilledSprite_Private_Void_VertexHelper_Boolean_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Boolean_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Single_Boolean_Int32_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_RadialCut_Private_Static_Void_Il2CppStructArray_1_Vector3_Single_Single_Boolean_Int32_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_New_Void_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_MapCoordinate_Private_Vector2_Vector2_Rect_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_RebuildImage_Private_Static_Void_SpriteAtlas_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_TrackImage_Private_Static_Void_Image_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_UnTrackImage_Private_Static_Void_Image_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_PDM_0;

		// Token: 0x02000088 RID: 136
		public enum Type
		{
			// Token: 0x0400092D RID: 2349
			Simple,
			// Token: 0x0400092E RID: 2350
			Sliced,
			// Token: 0x0400092F RID: 2351
			Tiled,
			// Token: 0x04000930 RID: 2352
			Filled
		}

		// Token: 0x02000089 RID: 137
		public enum FillMethod
		{
			// Token: 0x04000932 RID: 2354
			Horizontal,
			// Token: 0x04000933 RID: 2355
			Vertical,
			// Token: 0x04000934 RID: 2356
			Radial90,
			// Token: 0x04000935 RID: 2357
			Radial180,
			// Token: 0x04000936 RID: 2358
			Radial360
		}

		// Token: 0x0200008A RID: 138
		public enum OriginHorizontal
		{
			// Token: 0x04000938 RID: 2360
			Left,
			// Token: 0x04000939 RID: 2361
			Right
		}

		// Token: 0x0200008B RID: 139
		public enum OriginVertical
		{
			// Token: 0x0400093B RID: 2363
			Bottom,
			// Token: 0x0400093C RID: 2364
			Top
		}

		// Token: 0x0200008C RID: 140
		public enum Origin90
		{
			// Token: 0x0400093E RID: 2366
			BottomLeft,
			// Token: 0x0400093F RID: 2367
			TopLeft,
			// Token: 0x04000940 RID: 2368
			TopRight,
			// Token: 0x04000941 RID: 2369
			BottomRight
		}

		// Token: 0x0200008D RID: 141
		public enum Origin180
		{
			// Token: 0x04000943 RID: 2371
			Bottom,
			// Token: 0x04000944 RID: 2372
			Left,
			// Token: 0x04000945 RID: 2373
			Top,
			// Token: 0x04000946 RID: 2374
			Right
		}

		// Token: 0x0200008E RID: 142
		public enum Origin360
		{
			// Token: 0x04000948 RID: 2376
			Bottom,
			// Token: 0x04000949 RID: 2377
			Right,
			// Token: 0x0400094A RID: 2378
			Top,
			// Token: 0x0400094B RID: 2379
			Left
		}

		// Token: 0x0200008F RID: 143
		[ObfuscatedName("UnityEngine.UI.Image+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000C43 RID: 3139 RVA: 0x00006858 File Offset: 0x00004A58
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<Image.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Image>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image.__O>.NativeClassPtr);
				Image.__O.NativeFieldInfoPtr__0___RebuildImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image.__O>.NativeClassPtr, "<0>__RebuildImage");
			}

			// Token: 0x06000C44 RID: 3140 RVA: 0x0000688C File Offset: 0x00004A8C
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00035D20 File Offset: 0x00033F20
			// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00006895 File Offset: 0x00004A95
			public unsafe static Action<SpriteAtlas> _0___RebuildImage
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Image.__O.NativeFieldInfoPtr__0___RebuildImage, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteAtlas>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Image.__O.NativeFieldInfoPtr__0___RebuildImage, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400094C RID: 2380
			private static readonly IntPtr NativeFieldInfoPtr__0___RebuildImage;
		}
	}
}

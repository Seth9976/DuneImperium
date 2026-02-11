using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI.CoroutineTween;

namespace UnityEngine.UI
{
	// Token: 0x02000012 RID: 18
	public class Graphic : UIBehaviour
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// Note: this type is marked as 'beforefieldinit'.
		static Graphic()
		{
			Il2CppClassPointerStore<Graphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Graphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Graphic>.NativeClassPtr);
			Graphic.NativeFieldInfoPtr_s_DefaultUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_DefaultUI");
			Graphic.NativeFieldInfoPtr_s_WhiteTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_WhiteTexture");
			Graphic.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Material");
			Graphic.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Color");
			Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipLayoutUpdate");
			Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_SkipMaterialUpdate");
			Graphic.NativeFieldInfoPtr_m_RaycastTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastTarget");
			Graphic.NativeFieldInfoPtr_m_RaycastTargetCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastTargetCache");
			Graphic.NativeFieldInfoPtr_m_RaycastPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RaycastPadding");
			Graphic.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_RectTransform");
			Graphic.NativeFieldInfoPtr_m_CanvasRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CanvasRenderer");
			Graphic.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_Canvas");
			Graphic.NativeFieldInfoPtr_m_VertsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_VertsDirty");
			Graphic.NativeFieldInfoPtr_m_MaterialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_MaterialDirty");
			Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyLayoutCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyVertsCallback");
			Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_OnDirtyMaterialCallback");
			Graphic.NativeFieldInfoPtr_s_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_Mesh");
			Graphic.NativeFieldInfoPtr_s_VertexHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "s_VertexHelper");
			Graphic.NativeFieldInfoPtr_m_CachedMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedMesh");
			Graphic.NativeFieldInfoPtr_m_CachedUvs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_CachedUvs");
			Graphic.NativeFieldInfoPtr_m_ColorTweenRunner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "m_ColorTweenRunner");
			Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Graphic>.NativeClassPtr, "<useLegacyMeshGeneration>k__BackingField");
			Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663523);
			Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663524);
			Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663525);
			Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663526);
			Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663527);
			Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663528);
			Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663529);
			Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663530);
			Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663531);
			Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663532);
			Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663533);
			Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663534);
			Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663535);
			Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663536);
			Graphic.NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663537);
			Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663538);
			Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663539);
			Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663540);
			Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663541);
			Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663542);
			Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663543);
			Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663544);
			Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663545);
			Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663546);
			Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663547);
			Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663548);
			Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663549);
			Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663550);
			Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663551);
			Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663552);
			Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663553);
			Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663554);
			Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663555);
			Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663556);
			Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663557);
			Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663558);
			Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663559);
			Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663560);
			Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663561);
			Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663562);
			Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663563);
			Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663564);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663565);
			Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663566);
			Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663567);
			Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663568);
			Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663569);
			Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663570);
			Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663571);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663572);
			Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663573);
			Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663574);
			Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663575);
			Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663576);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663577);
			Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663578);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663579);
			Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663580);
			Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663581);
			Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Graphic>.NativeClassPtr, 100663583);
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000C97C File Offset: 0x0000AB7C
		public unsafe static Material defaultGraphicMaterial
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1083621, RefRangeEnd = 1083626, XrefRangeStart = 1083604, XrefRangeEnd = 1083621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		public unsafe virtual Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083626, XrefRangeEnd = 1083627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000CA44 File Offset: 0x0000AC44
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		public unsafe virtual bool raycastTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083627, XrefRangeEnd = 1083637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000CB14 File Offset: 0x0000AD14
		public unsafe Vector4 raycastPadding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000CB54 File Offset: 0x0000AD54
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000CB90 File Offset: 0x0000AD90
		public unsafe bool useLegacyMeshGeneration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083647, RefRangeEnd = 1083649, XrefRangeStart = 1083637, XrefRangeEnd = 1083647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Graphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Graphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000CC0C File Offset: 0x0000AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083649, XrefRangeEnd = 1083652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083652, XrefRangeEnd = 1083660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000CC84 File Offset: 0x0000AE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083660, XrefRangeEnd = 1083668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083668, XrefRangeEnd = 1083676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1083682, RefRangeEnd = 1083685, XrefRangeStart = 1083676, XrefRangeEnd = 1083682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRaycastDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000CD30 File Offset: 0x0000AF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083685, XrefRangeEnd = 1083694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000CD6C File Offset: 0x0000AF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083694, XrefRangeEnd = 1083711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000CDA8 File Offset: 0x0000AFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083719, RefRangeEnd = 1083720, XrefRangeStart = 1083711, XrefRangeEnd = 1083719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		public unsafe int depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083720, XrefRangeEnd = 1083723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000CE20 File Offset: 0x0000B020
		public unsafe virtual RectTransform rectTransform
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 1083727, RefRangeEnd = 1083769, XrefRangeStart = 1083723, XrefRangeEnd = 1083727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000CE60 File Offset: 0x0000B060
		public unsafe Canvas canvas
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1083774, RefRangeEnd = 1083808, XrefRangeStart = 1083769, XrefRangeEnd = 1083774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1083835, RefRangeEnd = 1083847, XrefRangeStart = 1083808, XrefRangeEnd = 1083835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CacheCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000CED4 File Offset: 0x0000B0D4
		public unsafe CanvasRenderer canvasRenderer
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 1083856, RefRangeEnd = 1083902, XrefRangeStart = 1083847, XrefRangeEnd = 1083856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr3) : null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000CF14 File Offset: 0x0000B114
		public unsafe virtual Material defaultMaterial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083902, XrefRangeEnd = 1083922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000CFAC File Offset: 0x0000B1AC
		public unsafe virtual Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083922, XrefRangeEnd = 1083926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083926, XrefRangeEnd = 1083931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		public unsafe virtual Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083931, XrefRangeEnd = 1083954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000D048 File Offset: 0x0000B248
		public unsafe virtual Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083954, XrefRangeEnd = 1083958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000D094 File Offset: 0x0000B294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1083983, RefRangeEnd = 1083984, XrefRangeStart = 1083958, XrefRangeEnd = 1083983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084014, RefRangeEnd = 1084015, XrefRangeStart = 1083984, XrefRangeEnd = 1084014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000D10C File Offset: 0x0000B30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084015, XrefRangeEnd = 1084037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000D148 File Offset: 0x0000B348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084054, RefRangeEnd = 1084055, XrefRangeStart = 1084037, XrefRangeEnd = 1084054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000D184 File Offset: 0x0000B384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084055, XrefRangeEnd = 1084065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCullingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000D1C0 File Offset: 0x0000B3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084065, XrefRangeEnd = 1084072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000D20C File Offset: 0x0000B40C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000D248 File Offset: 0x0000B448
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000D284 File Offset: 0x0000B484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084072, XrefRangeEnd = 1084078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084079, RefRangeEnd = 1084080, XrefRangeStart = 1084078, XrefRangeEnd = 1084079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084080, XrefRangeEnd = 1084160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000D330 File Offset: 0x0000B530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084237, RefRangeEnd = 1084238, XrefRangeStart = 1084160, XrefRangeEnd = 1084237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoLegacyMeshGeneration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000D364 File Offset: 0x0000B564
		public unsafe static Mesh workerMesh
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1084262, RefRangeEnd = 1084268, XrefRangeStart = 1084238, XrefRangeEnd = 1084262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000D398 File Offset: 0x0000B598
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnFillVBO(List<UIVertex> vbo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vbo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084268, XrefRangeEnd = 1084275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(Mesh m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000D438 File Offset: 0x0000B638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084284, RefRangeEnd = 1084285, XrefRangeStart = 1084275, XrefRangeEnd = 1084284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPopulateMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000D488 File Offset: 0x0000B688
		[CallerCount(0)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNativeSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000D500 File Offset: 0x0000B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084285, XrefRangeEnd = 1084335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Raycast(Vector2 sp, Camera eventCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sp;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000D568 File Offset: 0x0000B768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1084356, RefRangeEnd = 1084358, XrefRangeStart = 1084335, XrefRangeEnd = 1084356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 PixelAdjustPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1084379, RefRangeEnd = 1084387, XrefRangeStart = 1084358, XrefRangeEnd = 1084379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetPixelAdjustedRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084387, RefRangeEnd = 1084388, XrefRangeStart = 1084387, XrefRangeEnd = 1084387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000D664 File Offset: 0x0000B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084388, XrefRangeEnd = 1084405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref targetColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useAlpha;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useRGB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		[CallerCount(0)]
		public unsafe static Color CreateColorFromAlpha(float alpha)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000D728 File Offset: 0x0000B928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1084408, RefRangeEnd = 1084409, XrefRangeStart = 1084405, XrefRangeEnd = 1084408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreTimeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Graphic.NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000D790 File Offset: 0x0000B990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084409, XrefRangeEnd = 1084417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1084417, XrefRangeEnd = 1084425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyLayoutCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000D818 File Offset: 0x0000BA18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1084433, RefRangeEnd = 1084439, XrefRangeStart = 1084425, XrefRangeEnd = 1084433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000D85C File Offset: 0x0000BA5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1084447, RefRangeEnd = 1084453, XrefRangeStart = 1084439, XrefRangeEnd = 1084447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyVerticesCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1084461, RefRangeEnd = 1084463, XrefRangeStart = 1084453, XrefRangeEnd = 1084461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1084471, RefRangeEnd = 1084473, XrefRangeStart = 1084463, XrefRangeEnd = 1084471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterDirtyMaterialCallback(UnityAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000D928 File Offset: 0x0000BB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Transform UnityEngine_UI_ICanvasElement_get_transform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Graphic.NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002770 File Offset: 0x00000970
		public Graphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000D968 File Offset: 0x0000BB68
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002779 File Offset: 0x00000979
		public unsafe static Material s_DefaultUI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_DefaultUI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000D990 File Offset: 0x0000BB90
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0000278B File Offset: 0x0000098B
		public unsafe static Texture2D s_WhiteTexture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_WhiteTexture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0000279D File Offset: 0x0000099D
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		// (set) Token: 0x06000197 RID: 407 RVA: 0x000027BC File Offset: 0x000009BC
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000DA10 File Offset: 0x0000BC10
		// (set) Token: 0x06000199 RID: 409 RVA: 0x000027D7 File Offset: 0x000009D7
		public unsafe bool m_SkipLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipLayoutUpdate)) = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000DA38 File Offset: 0x0000BC38
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000027F2 File Offset: 0x000009F2
		public unsafe bool m_SkipMaterialUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_SkipMaterialUpdate)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000DA60 File Offset: 0x0000BC60
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000280D File Offset: 0x00000A0D
		public unsafe bool m_RaycastTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTarget)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0000DA88 File Offset: 0x0000BC88
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002828 File Offset: 0x00000A28
		public unsafe bool m_RaycastTargetCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTargetCache);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastTargetCache)) = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002843 File Offset: 0x00000A43
		public unsafe Vector4 m_RaycastPadding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RaycastPadding)) = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0000DB08 File Offset: 0x0000BD08
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000287D File Offset: 0x00000A7D
		public unsafe CanvasRenderer m_CanvasRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CanvasRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000DB38 File Offset: 0x0000BD38
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000289C File Offset: 0x00000A9C
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000DB68 File Offset: 0x0000BD68
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000028BB File Offset: 0x00000ABB
		public unsafe bool m_VertsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_VertsDirty)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000DB90 File Offset: 0x0000BD90
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000028D6 File Offset: 0x00000AD6
		public unsafe bool m_MaterialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_MaterialDirty)) = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000028F1 File Offset: 0x00000AF1
		public unsafe UnityAction m_OnDirtyLayoutCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyLayoutCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002910 File Offset: 0x00000B10
		public unsafe UnityAction m_OnDirtyVertsCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyVertsCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000DC18 File Offset: 0x0000BE18
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000292F File Offset: 0x00000B2F
		public unsafe UnityAction m_OnDirtyMaterialCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_OnDirtyMaterialCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000DC48 File Offset: 0x0000BE48
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000294E File Offset: 0x00000B4E
		public unsafe static Mesh s_Mesh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_Mesh, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_Mesh, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000DC70 File Offset: 0x0000BE70
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002960 File Offset: 0x00000B60
		public unsafe static VertexHelper s_VertexHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VertexHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Graphic.NativeFieldInfoPtr_s_VertexHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000DC98 File Offset: 0x0000BE98
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002972 File Offset: 0x00000B72
		public unsafe Mesh m_CachedMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002991 File Offset: 0x00000B91
		public unsafe Il2CppStructArray<Vector2> m_CachedUvs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_CachedUvs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000029B0 File Offset: 0x00000BB0
		public unsafe TweenRunner<ColorTween> m_ColorTweenRunner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TweenRunner<ColorTween>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr_m_ColorTweenRunner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000DD28 File Offset: 0x0000BF28
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000029CF File Offset: 0x00000BCF
		public unsafe bool _useLegacyMeshGeneration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Graphic.NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField)) = value;
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultUI;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_s_WhiteTexture;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipLayoutUpdate;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_m_SkipMaterialUpdate;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastTarget;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastTargetCache;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastPadding;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasRenderer;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_m_VertsDirty;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialDirty;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyLayoutCallback;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyVertsCallback;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_OnDirtyMaterialCallback;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_s_Mesh;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeFieldInfoPtr_s_VertexHelper;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedMesh;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedUvs;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorTweenRunner;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeFieldInfoPtr__useLegacyMeshGeneration_k__BackingField;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultGraphicMaterial_Public_Static_get_Material_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_Virtual_New_get_Color_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_Virtual_New_set_Void_Color_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastTarget_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastTarget_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastPadding_Public_get_Vector4_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_set_raycastPadding_Public_set_Void_Vector4_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_get_useLegacyMeshGeneration_Protected_get_Boolean_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_set_useLegacyMeshGeneration_Protected_set_Void_Boolean_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_New_Void_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_SetRaycastDirty_Public_Void_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_get_Int32_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Public_get_Canvas_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_CacheCanvas_Private_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_get_canvasRenderer_Public_get_CanvasRenderer_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_New_get_Material_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_New_set_Void_Material_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_New_get_Material_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_New_get_Texture_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_OnCullingChanged_Public_Virtual_New_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_New_Void_CanvasUpdate_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_New_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_New_Void_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_New_Void_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_DoMeshGeneration_Private_Void_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_DoLegacyMeshGeneration_Private_Void_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_get_workerMesh_Protected_Static_get_Mesh_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_OnFillVBO_Protected_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_Mesh_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_OnPopulateMesh_Protected_Virtual_New_Void_VertexHelper_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeSize_Public_Virtual_New_Void_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_PixelAdjustPoint_Public_Vector2_Vector2_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_GetPixelAdjustedRect_Public_Rect_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeColor_Public_Virtual_New_Void_Color_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_CreateColorFromAlpha_Private_Static_Color_Single_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_CrossFadeAlpha_Public_Virtual_New_Void_Single_Single_Boolean_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyLayoutCallback_Public_Void_UnityAction_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyVerticesCallback_Public_Void_UnityAction_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterDirtyMaterialCallback_Public_Void_UnityAction_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_ICanvasElement_get_transform_Private_Virtual_Final_New_Transform_0;
	}
}

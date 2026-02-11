using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x0200002B RID: 43
	public class MaskableGraphic : Graphic
	{
		// Token: 0x06000508 RID: 1288 RVA: 0x0001AB14 File Offset: 0x00018D14
		// Note: this type is marked as 'beforefieldinit'.
		static MaskableGraphic()
		{
			Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "MaskableGraphic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr);
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculateStencil");
			MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_MaskMaterial");
			MaskableGraphic.NativeFieldInfoPtr_m_ParentMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ParentMask");
			MaskableGraphic.NativeFieldInfoPtr_m_Maskable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Maskable");
			MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IsMaskingGraphic");
			MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_IncludeForMasking");
			MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_OnCullStateChanged");
			MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_ShouldRecalculate");
			MaskableGraphic.NativeFieldInfoPtr_m_StencilValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_StencilValue");
			MaskableGraphic.NativeFieldInfoPtr_m_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "m_Corners");
			MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664129);
			MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664130);
			MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664131);
			MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664132);
			MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664133);
			MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664134);
			MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664135);
			MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664136);
			MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664137);
			MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664138);
			MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664139);
			MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664140);
			MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664141);
			MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664142);
			MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664143);
			MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664144);
			MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664145);
			MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664146);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664147);
			MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664148);
			MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664149);
			MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, 100664150);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0001ADC4 File Offset: 0x00018FC4
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0001AE04 File Offset: 0x00019004
		public unsafe MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0001AE48 File Offset: 0x00019048
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0001AE84 File Offset: 0x00019084
		public unsafe bool maskable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001AEC4 File Offset: 0x000190C4
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0001AF00 File Offset: 0x00019100
		public unsafe bool isMaskingGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001AF40 File Offset: 0x00019140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089735, XrefRangeEnd = 1089746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001AF9C File Offset: 0x0001919C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089750, RefRangeEnd = 1089751, XrefRangeStart = 1089746, XrefRangeEnd = 1089750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001AFF4 File Offset: 0x000191F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1089761, RefRangeEnd = 1089763, XrefRangeStart = 1089751, XrefRangeEnd = 1089761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull(bool cull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cull;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001B034 File Offset: 0x00019234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089763, XrefRangeEnd = 1089767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipRect(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001B08C File Offset: 0x0001928C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089767, XrefRangeEnd = 1089770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetClipSoftness(Vector2 clipSoftness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipSoftness;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001B0D8 File Offset: 0x000192D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1089773, RefRangeEnd = 1089775, XrefRangeStart = 1089770, XrefRangeEnd = 1089773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001B114 File Offset: 0x00019314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1089783, RefRangeEnd = 1089786, XrefRangeStart = 1089775, XrefRangeEnd = 1089783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0001B150 File Offset: 0x00019350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089789, RefRangeEnd = 1089790, XrefRangeStart = 1089786, XrefRangeEnd = 1089789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001B18C File Offset: 0x0001938C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ParentMaskStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001B1C8 File Offset: 0x000193C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1089793, RefRangeEnd = 1089795, XrefRangeStart = 1089790, XrefRangeEnd = 1089793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001B204 File Offset: 0x00019404
		public unsafe Rect rootCanvasRect
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1089810, RefRangeEnd = 1089811, XrefRangeStart = 1089795, XrefRangeEnd = 1089810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001B240 File Offset: 0x00019440
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1089828, RefRangeEnd = 1089833, XrefRangeStart = 1089811, XrefRangeEnd = 1089828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClipParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UpdateClipParent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001B274 File Offset: 0x00019474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1089834, RefRangeEnd = 1089836, XrefRangeStart = 1089833, XrefRangeEnd = 1089834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001B2B0 File Offset: 0x000194B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089836, XrefRangeEnd = 1089841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecalculateMasking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MaskableGraphic.NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0001B2EC File Offset: 0x000194EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1089856, RefRangeEnd = 1089862, XrefRangeStart = 1089841, XrefRangeEnd = 1089856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskableGraphic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0001B328 File Offset: 0x00019528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject UnityEngine_UI_IClippable_get_gameObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00003B21 File Offset: 0x00001D21
		public MaskableGraphic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0001B368 File Offset: 0x00019568
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003B2A File Offset: 0x00001D2A
		public unsafe bool m_ShouldRecalculateStencil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculateStencil)) = value;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0001B390 File Offset: 0x00019590
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003B45 File Offset: 0x00001D45
		public unsafe Material m_MaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_MaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0001B3C0 File Offset: 0x000195C0
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00003B64 File Offset: 0x00001D64
		public unsafe RectMask2D m_ParentMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectMask2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ParentMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001B3F0 File Offset: 0x000195F0
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00003B83 File Offset: 0x00001D83
		public unsafe bool m_Maskable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Maskable)) = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0001B418 File Offset: 0x00019618
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00003B9E File Offset: 0x00001D9E
		public unsafe bool m_IsMaskingGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IsMaskingGraphic)) = value;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0001B440 File Offset: 0x00019640
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00003BB9 File Offset: 0x00001DB9
		public unsafe bool m_IncludeForMasking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_IncludeForMasking)) = value;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0001B468 File Offset: 0x00019668
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00003BD4 File Offset: 0x00001DD4
		public unsafe MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskableGraphic.CullStateChangedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_OnCullStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001B498 File Offset: 0x00019698
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00003BF3 File Offset: 0x00001DF3
		public unsafe bool m_ShouldRecalculate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_ShouldRecalculate)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001B4C0 File Offset: 0x000196C0
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00003C0E File Offset: 0x00001E0E
		public unsafe int m_StencilValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_StencilValue)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001B4E8 File Offset: 0x000196E8
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00003C29 File Offset: 0x00001E29
		public unsafe Il2CppStructArray<Vector3> m_Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskableGraphic.NativeFieldInfoPtr_m_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculateStencil;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskMaterial;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentMask;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_m_Maskable;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_m_IsMaskingGraphic;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_m_IncludeForMasking;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_m_OnCullStateChanged;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldRecalculate;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilValue;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_m_Corners;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_get_onCullStateChanged_Public_get_CullStateChangedEvent_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_set_onCullStateChanged_Public_set_Void_CullStateChangedEvent_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_get_maskable_Public_get_Boolean_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_set_maskable_Public_set_Void_Boolean_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_get_isMaskingGraphic_Public_get_Boolean_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_set_isMaskingGraphic_Public_set_Void_Boolean_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_Boolean_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr_SetClipRect_Public_Virtual_New_Void_Rect_Boolean_0;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr_SetClipSoftness_Public_Virtual_New_Void_Vector2_0;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_ParentMaskStateChanged_Public_Virtual_New_Void_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCanvasRect_Private_get_Rect_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClipParent_Private_Void_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_New_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateMasking_Public_Virtual_New_Void_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_UI_IClippable_get_gameObject_Private_Virtual_Final_New_GameObject_0;

		// Token: 0x020000A7 RID: 167
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x06000CB9 RID: 3257 RVA: 0x00006BF3 File Offset: 0x00004DF3
			// Note: this type is marked as 'beforefieldinit'.
			static CullStateChangedEvent()
			{
				Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskableGraphic>.NativeClassPtr, "CullStateChangedEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr);
				MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr, 100664151);
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x0003733C File Offset: 0x0003553C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089732, XrefRangeEnd = 1089735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CullStateChangedEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskableGraphic.CullStateChangedEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskableGraphic.CullStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00006C27 File Offset: 0x00004E27
			public CullStateChangedEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009D2 RID: 2514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

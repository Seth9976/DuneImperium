using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200002A RID: 42
	public class Mask : UIBehaviour
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x0001A5C4 File Offset: 0x000187C4
		// Note: this type is marked as 'beforefieldinit'.
		static Mask()
		{
			Il2CppClassPointerStore<Mask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Mask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mask>.NativeClassPtr);
			Mask.NativeFieldInfoPtr_m_RectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_RectTransform");
			Mask.NativeFieldInfoPtr_m_ShowMaskGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_ShowMaskGraphic");
			Mask.NativeFieldInfoPtr_m_Graphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_Graphic");
			Mask.NativeFieldInfoPtr_m_MaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_MaskMaterial");
			Mask.NativeFieldInfoPtr_m_UnmaskMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mask>.NativeClassPtr, "m_UnmaskMaterial");
			Mask.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664118);
			Mask.NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664119);
			Mask.NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664120);
			Mask.NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664121);
			Mask.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664122);
			Mask.NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664123);
			Mask.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664124);
			Mask.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664125);
			Mask.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664126);
			Mask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664127);
			Mask.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mask>.NativeClassPtr, 100664128);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x0001A734 File Offset: 0x00018934
		public unsafe RectTransform rectTransform
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1089594, RefRangeEnd = 1089595, XrefRangeStart = 1089590, XrefRangeEnd = 1089594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001A774 File Offset: 0x00018974
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0001A7B0 File Offset: 0x000189B0
		public unsafe bool showMaskGraphic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1089604, RefRangeEnd = 1089607, XrefRangeStart = 1089595, XrefRangeEnd = 1089604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001A7F0 File Offset: 0x000189F0
		public unsafe Graphic graphic
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1089611, RefRangeEnd = 1089619, XrefRangeStart = 1089607, XrefRangeEnd = 1089611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr3) : null;
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001A830 File Offset: 0x00018A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089620, RefRangeEnd = 1089621, XrefRangeStart = 1089619, XrefRangeEnd = 1089620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Mask()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mask.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001A86C File Offset: 0x00018A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089621, XrefRangeEnd = 1089622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MaskEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001A8B4 File Offset: 0x00018AB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSiblingGraphicEnabledDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089622, XrefRangeEnd = 1089651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001A92C File Offset: 0x00018B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089651, XrefRangeEnd = 1089693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001A968 File Offset: 0x00018B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089693, XrefRangeEnd = 1089702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089702, XrefRangeEnd = 1089732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Mask.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00003A81 File Offset: 0x00001C81
		public Mask(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0001AA2C File Offset: 0x00018C2C
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00003A8A File Offset: 0x00001C8A
		public unsafe RectTransform m_RectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_RectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_RectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0001AA5C File Offset: 0x00018C5C
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00003AA9 File Offset: 0x00001CA9
		public unsafe bool m_ShowMaskGraphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_ShowMaskGraphic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_ShowMaskGraphic)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001AA84 File Offset: 0x00018C84
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00003AC4 File Offset: 0x00001CC4
		public unsafe Graphic m_Graphic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_Graphic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_Graphic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0001AAB4 File Offset: 0x00018CB4
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00003AE3 File Offset: 0x00001CE3
		public unsafe Material m_MaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_MaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_MaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001AAE4 File Offset: 0x00018CE4
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00003B02 File Offset: 0x00001D02
		public unsafe Material m_UnmaskMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_UnmaskMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Mask.NativeFieldInfoPtr_m_UnmaskMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_m_RectTransform;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_m_ShowMaskGraphic;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphic;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_m_MaskMaterial;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_m_UnmaskMaterial;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Public_get_RectTransform_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_get_showMaskGraphic_Public_get_Boolean_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_set_showMaskGraphic_Public_set_Void_Boolean_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_get_graphic_Public_get_Graphic_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_MaskEnabled_Public_Virtual_New_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_OnSiblingGraphicEnabledDisabled_Public_Virtual_New_Void_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_IsRaycastLocationValid_Public_Virtual_New_Boolean_Vector2_Camera_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_New_Material_Material_0;
	}
}

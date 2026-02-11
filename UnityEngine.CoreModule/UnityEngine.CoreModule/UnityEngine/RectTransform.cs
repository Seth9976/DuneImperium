using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000175 RID: 373
	public sealed class RectTransform : Transform
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x0007F2E8 File Offset: 0x0007D4E8
		// Note: this type is marked as 'beforefieldinit'.
		static RectTransform()
		{
			Il2CppClassPointerStore<RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransform>.NativeClassPtr);
			RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "reapplyDrivenProperties");
			RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667087);
			RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667088);
			RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667089);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667090);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667091);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667092);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667093);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667094);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667095);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667096);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667097);
			RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667098);
			RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667099);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667100);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667101);
			RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667102);
			RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667103);
			RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667104);
			RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667105);
			RectTransform.NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667106);
			RectTransform.NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667107);
			RectTransform.NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667108);
			RectTransform.NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667109);
			RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667110);
			RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667111);
			RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667112);
			RectTransform.NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667113);
			RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667114);
			RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667115);
			RectTransform.NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667116);
			RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667117);
			RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667118);
			RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667119);
			RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667120);
			RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667121);
			RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667122);
			RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667123);
			RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667124);
			RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667125);
			RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667126);
			RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667127);
			RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667128);
			RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100667129);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0007F688 File Offset: 0x0007D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674292, XrefRangeEnd = 674299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0007F6C0 File Offset: 0x0007D8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 674299, XrefRangeEnd = 674306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0007F6F8 File Offset: 0x0007D8F8
		public unsafe Rect rect
		{
			[CallerCount(135)]
			[CachedScanResults(RefRangeStart = 674308, RefRangeEnd = 674443, XrefRangeStart = 674306, XrefRangeEnd = 674308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001BDE RID: 7134 RVA: 0x0007F734 File Offset: 0x0007D934
		// (set) Token: 0x06001BDF RID: 7135 RVA: 0x0007F770 File Offset: 0x0007D970
		public unsafe Vector2 anchorMin
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 674445, RefRangeEnd = 674466, XrefRangeStart = 674443, XrefRangeEnd = 674445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 674468, RefRangeEnd = 674538, XrefRangeStart = 674466, XrefRangeEnd = 674468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x0007F7B0 File Offset: 0x0007D9B0
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0007F7EC File Offset: 0x0007D9EC
		public unsafe Vector2 anchorMax
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 674540, RefRangeEnd = 674558, XrefRangeStart = 674538, XrefRangeEnd = 674540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 674560, RefRangeEnd = 674629, XrefRangeStart = 674558, XrefRangeEnd = 674560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x0007F82C File Offset: 0x0007DA2C
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x0007F868 File Offset: 0x0007DA68
		public unsafe Vector2 anchoredPosition
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 674631, RefRangeEnd = 674686, XrefRangeStart = 674629, XrefRangeEnd = 674631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 674688, RefRangeEnd = 674741, XrefRangeStart = 674686, XrefRangeEnd = 674688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		public unsafe Vector2 sizeDelta
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 674743, RefRangeEnd = 674812, XrefRangeStart = 674741, XrefRangeEnd = 674743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(77)]
			[CachedScanResults(RefRangeStart = 674814, RefRangeEnd = 674891, XrefRangeStart = 674812, XrefRangeEnd = 674814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0007F924 File Offset: 0x0007DB24
		// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x0007F960 File Offset: 0x0007DB60
		public unsafe Vector2 pivot
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 674893, RefRangeEnd = 674934, XrefRangeStart = 674891, XrefRangeEnd = 674893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 674936, RefRangeEnd = 674962, XrefRangeStart = 674934, XrefRangeEnd = 674936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
		// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x0007F9DC File Offset: 0x0007DBDC
		public unsafe Vector3 anchoredPosition3D
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 674966, RefRangeEnd = 674967, XrefRangeStart = 674962, XrefRangeEnd = 674966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 674973, RefRangeEnd = 674974, XrefRangeStart = 674967, XrefRangeEnd = 674973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001BEA RID: 7146 RVA: 0x0007FA1C File Offset: 0x0007DC1C
		// (set) Token: 0x06001BEB RID: 7147 RVA: 0x0007FA58 File Offset: 0x0007DC58
		public unsafe Vector2 offsetMin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 674980, RefRangeEnd = 674982, XrefRangeStart = 674974, XrefRangeEnd = 674980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 675000, RefRangeEnd = 675012, XrefRangeStart = 674982, XrefRangeEnd = 675000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x0007FA98 File Offset: 0x0007DC98
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0007FAD4 File Offset: 0x0007DCD4
		public unsafe Vector2 offsetMax
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 675020, RefRangeEnd = 675022, XrefRangeStart = 675012, XrefRangeEnd = 675020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 675040, RefRangeEnd = 675052, XrefRangeStart = 675022, XrefRangeEnd = 675040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x0007FB14 File Offset: 0x0007DD14
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x0007FB54 File Offset: 0x0007DD54
		public unsafe Object drivenByObject
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675052, XrefRangeEnd = 675054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675054, XrefRangeEnd = 675056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x0007FB98 File Offset: 0x0007DD98
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x0007FBD4 File Offset: 0x0007DDD4
		public unsafe DrivenTransformProperties drivenProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675056, XrefRangeEnd = 675058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675058, XrefRangeEnd = 675060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0007FC14 File Offset: 0x0007DE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675060, XrefRangeEnd = 675062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdateRectTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0007FC48 File Offset: 0x0007DE48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 675066, RefRangeEnd = 675071, XrefRangeStart = 675062, XrefRangeEnd = 675066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetLocalCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0007FC8C File Offset: 0x0007DE8C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 675086, RefRangeEnd = 675101, XrefRangeStart = 675071, XrefRangeEnd = 675086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetWorldCorners(Il2CppStructArray<Vector3> fourCornersArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fourCornersArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0007FCD0 File Offset: 0x0007DED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675101, XrefRangeEnd = 675128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref edge;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0007FD2C File Offset: 0x0007DF2C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 675153, RefRangeEnd = 675162, XrefRangeStart = 675128, XrefRangeEnd = 675153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0007FD78 File Offset: 0x0007DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675162, XrefRangeEnd = 675164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendReapplyDrivenProperties(RectTransform driven)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0007FDB0 File Offset: 0x0007DFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675164, XrefRangeEnd = 675194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetRectInParentSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0007FDEC File Offset: 0x0007DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675194, XrefRangeEnd = 675204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetParentSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0007FE28 File Offset: 0x0007E028
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0007FE64 File Offset: 0x0007E064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675204, XrefRangeEnd = 675206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0007FEA4 File Offset: 0x0007E0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675206, XrefRangeEnd = 675208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMin_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0007FEE4 File Offset: 0x0007E0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675208, XrefRangeEnd = 675210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMin_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0007FF24 File Offset: 0x0007E124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675210, XrefRangeEnd = 675212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchorMax_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0007FF64 File Offset: 0x0007E164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675212, XrefRangeEnd = 675214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchorMax_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675214, XrefRangeEnd = 675216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_anchoredPosition_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0007FFE4 File Offset: 0x0007E1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675216, XrefRangeEnd = 675218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_anchoredPosition_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00080024 File Offset: 0x0007E224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675218, XrefRangeEnd = 675220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_sizeDelta_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00080064 File Offset: 0x0007E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675220, XrefRangeEnd = 675222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_sizeDelta_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x000800A4 File Offset: 0x0007E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675222, XrefRangeEnd = 675224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x000800E4 File Offset: 0x0007E2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 675224, XrefRangeEnd = 675226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_pivot_Injected(ref Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0000AC5B File Offset: 0x00008E5B
		public RectTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x00080124 File Offset: 0x0007E324
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x0000AC64 File Offset: 0x00008E64
		public unsafe static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform.ReapplyDrivenProperties>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeFieldInfoPtr_reapplyDrivenProperties;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMin_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_get_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_set_anchorMax_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x040018C1 RID: 6337
		private static readonly IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x020007FC RID: 2044
		public enum Edge
		{
			// Token: 0x04002CA8 RID: 11432
			Left,
			// Token: 0x04002CA9 RID: 11433
			Right,
			// Token: 0x04002CAA RID: 11434
			Top,
			// Token: 0x04002CAB RID: 11435
			Bottom
		}

		// Token: 0x020007FD RID: 2045
		public enum Axis
		{
			// Token: 0x04002CAD RID: 11437
			Horizontal,
			// Token: 0x04002CAE RID: 11438
			Vertical
		}

		// Token: 0x020007FE RID: 2046
		public sealed class ReapplyDrivenProperties : MulticastDelegate
		{
			// Token: 0x060038A0 RID: 14496 RVA: 0x0001408D File Offset: 0x0001228D
			// Note: this type is marked as 'beforefieldinit'.
			static ReapplyDrivenProperties()
			{
				Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "ReapplyDrivenProperties");
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100667130);
				RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100667131);
			}

			// Token: 0x060038A1 RID: 14497 RVA: 0x000BCC58 File Offset: 0x000BAE58
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 408098, RefRangeEnd = 408114, XrefRangeStart = 408098, XrefRangeEnd = 408114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReapplyDrivenProperties(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038A2 RID: 14498 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
			[CallerCount(0)]
			public unsafe void Invoke(RectTransform driven)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038A3 RID: 14499 RVA: 0x000140CB File Offset: 0x000122CB
			public ReapplyDrivenProperties(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060038A4 RID: 14500 RVA: 0x000140D4 File Offset: 0x000122D4
			public static implicit operator RectTransform.ReapplyDrivenProperties(Action<RectTransform> A_0)
			{
				return DelegateSupport.ConvertDelegate<RectTransform.ReapplyDrivenProperties>(A_0);
			}

			// Token: 0x060038A5 RID: 14501 RVA: 0x000140DC File Offset: 0x000122DC
			public static RectTransform.ReapplyDrivenProperties operator +(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<RectTransform.ReapplyDrivenProperties>();
			}

			// Token: 0x060038A6 RID: 14502 RVA: 0x000140EA File Offset: 0x000122EA
			public static RectTransform.ReapplyDrivenProperties operator -(RectTransform.ReapplyDrivenProperties A_0, RectTransform.ReapplyDrivenProperties A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<RectTransform.ReapplyDrivenProperties>();
				}
				return delegate2;
			}

			// Token: 0x04002CAF RID: 11439
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002CB0 RID: 11440
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000026 RID: 38
	public class LayoutGroup : UIBehaviour
	{
		// Token: 0x0600048B RID: 1163 RVA: 0x00018874 File Offset: 0x00016A74
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutGroup()
		{
			Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr);
			LayoutGroup.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Padding");
			LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_ChildAlignment");
			LayoutGroup.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Rect");
			LayoutGroup.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_Tracker");
			LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalMinSize");
			LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalPreferredSize");
			LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_TotalFlexibleSize");
			LayoutGroup.NativeFieldInfoPtr_m_RectChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "m_RectChildren");
			LayoutGroup.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664020);
			LayoutGroup.NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664021);
			LayoutGroup.NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664022);
			LayoutGroup.NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664023);
			LayoutGroup.NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664024);
			LayoutGroup.NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664025);
			LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664026);
			LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664027);
			LayoutGroup.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664028);
			LayoutGroup.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664029);
			LayoutGroup.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664030);
			LayoutGroup.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664031);
			LayoutGroup.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664032);
			LayoutGroup.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664033);
			LayoutGroup.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664034);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664035);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664036);
			LayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664037);
			LayoutGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664038);
			LayoutGroup.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664039);
			LayoutGroup.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664040);
			LayoutGroup.NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664041);
			LayoutGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664042);
			LayoutGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664043);
			LayoutGroup.NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664044);
			LayoutGroup.NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664045);
			LayoutGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664046);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664047);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664048);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664049);
			LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664050);
			LayoutGroup.NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664051);
			LayoutGroup.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664052);
			LayoutGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664053);
			LayoutGroup.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664054);
			LayoutGroup.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664055);
			LayoutGroup.NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, 100664056);
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00018C28 File Offset: 0x00016E28
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00018C68 File Offset: 0x00016E68
		public unsafe RectOffset padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1088456, RefRangeEnd = 1088458, XrefRangeStart = 1088453, XrefRangeEnd = 1088456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00018CAC File Offset: 0x00016EAC
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00018CE8 File Offset: 0x00016EE8
		public unsafe TextAnchor childAlignment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088458, XrefRangeEnd = 1088461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00018D28 File Offset: 0x00016F28
		public unsafe RectTransform rectTransform
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1088469, RefRangeEnd = 1088490, XrefRangeStart = 1088461, XrefRangeEnd = 1088469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00018D68 File Offset: 0x00016F68
		public unsafe List<RectTransform> rectChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr3) : null;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00018DA8 File Offset: 0x00016FA8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1088543, RefRangeEnd = 1088550, XrefRangeStart = 1088490, XrefRangeEnd = 1088543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00018DE4 File Offset: 0x00016FE4
		[CallerCount(0)]
		public unsafe virtual void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00018E20 File Offset: 0x00017020
		public unsafe virtual float minWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1032748, RefRangeEnd = 1032751, XrefRangeStart = 1032748, XrefRangeEnd = 1032751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00018E68 File Offset: 0x00017068
		public unsafe virtual float preferredWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00018EB0 File Offset: 0x000170B0
		public unsafe virtual float flexibleWidth
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1088550, RefRangeEnd = 1088553, XrefRangeStart = 1088550, XrefRangeEnd = 1088550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00018EF8 File Offset: 0x000170F8
		public unsafe virtual float minHeight
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1088553, RefRangeEnd = 1088556, XrefRangeStart = 1088553, XrefRangeEnd = 1088553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00018F40 File Offset: 0x00017140
		public unsafe virtual float preferredHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00018F88 File Offset: 0x00017188
		public unsafe virtual float flexibleHeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1088556, RefRangeEnd = 1088558, XrefRangeStart = 1088556, XrefRangeEnd = 1088556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00018FD0 File Offset: 0x000171D0
		public unsafe virtual int layoutPriority
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00019018 File Offset: 0x00017218
		[CallerCount(0)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00019054 File Offset: 0x00017254
		[CallerCount(0)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00019090 File Offset: 0x00017290
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1088581, RefRangeEnd = 1088587, XrefRangeStart = 1088558, XrefRangeEnd = 1088581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000190CC File Offset: 0x000172CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088587, XrefRangeEnd = 1088589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00019108 File Offset: 0x00017308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088589, XrefRangeEnd = 1088596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00019144 File Offset: 0x00017344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088596, XrefRangeEnd = 1088597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDidApplyAnimationProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00019180 File Offset: 0x00017380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088597, XrefRangeEnd = 1088598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalMinSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000191CC File Offset: 0x000173CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1088599, RefRangeEnd = 1088606, XrefRangeStart = 1088598, XrefRangeEnd = 1088599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalPreferredSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00019218 File Offset: 0x00017418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088607, RefRangeEnd = 1088609, XrefRangeStart = 1088606, XrefRangeEnd = 1088607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalFlexibleSize(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00019264 File Offset: 0x00017464
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1088617, RefRangeEnd = 1088629, XrefRangeStart = 1088609, XrefRangeEnd = 1088617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredSpaceWithoutPadding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000192BC File Offset: 0x000174BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1088629, RefRangeEnd = 1088634, XrefRangeStart = 1088629, XrefRangeEnd = 1088629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAlignmentOnAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00019308 File Offset: 0x00017508
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1088634, RefRangeEnd = 1088639, XrefRangeStart = 1088634, XrefRangeEnd = 1088634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPreferred;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalFlexible;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00019370 File Offset: 0x00017570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1088644, RefRangeEnd = 1088648, XrefRangeStart = 1088639, XrefRangeEnd = 1088644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000193D0 File Offset: 0x000175D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1088666, RefRangeEnd = 1088671, XrefRangeStart = 1088648, XrefRangeEnd = 1088666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001943C File Offset: 0x0001763C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1088676, RefRangeEnd = 1088688, XrefRangeStart = 1088671, XrefRangeEnd = 1088676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000194A8 File Offset: 0x000176A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1088707, RefRangeEnd = 1088712, XrefRangeStart = 1088688, XrefRangeEnd = 1088707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleFactor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00019524 File Offset: 0x00017724
		public unsafe bool isRootLayoutGroup
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088712, XrefRangeEnd = 1088730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00019560 File Offset: 0x00017760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088730, XrefRangeEnd = 1088750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001959C File Offset: 0x0001779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTransformChildrenChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutGroup.NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000195D8 File Offset: 0x000177D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1088757, RefRangeEnd = 1088764, XrefRangeStart = 1088750, XrefRangeEnd = 1088757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProperty<T>(ref T currentValue, T newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t = newValue;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref newValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			currentValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001967C File Offset: 0x0001787C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1088780, RefRangeEnd = 1088788, XrefRangeStart = 1088764, XrefRangeEnd = 1088780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000196B0 File Offset: 0x000178B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088788, XrefRangeEnd = 1088793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup.NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000392D File Offset: 0x00001B2D
		public LayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00019700 File Offset: 0x00017900
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00003936 File Offset: 0x00001B36
		public unsafe RectOffset m_Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00019730 File Offset: 0x00017930
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003955 File Offset: 0x00001B55
		public unsafe TextAnchor m_ChildAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_ChildAlignment)) = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00019758 File Offset: 0x00017958
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003970 File Offset: 0x00001B70
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00019788 File Offset: 0x00017988
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x0000398F File Offset: 0x00001B8F
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x000197B0 File Offset: 0x000179B0
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x000039AA File Offset: 0x00001BAA
		public unsafe Vector2 m_TotalMinSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalMinSize)) = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000197D8 File Offset: 0x000179D8
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x000039C5 File Offset: 0x00001BC5
		public unsafe Vector2 m_TotalPreferredSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalPreferredSize)) = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00019800 File Offset: 0x00017A00
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x000039E0 File Offset: 0x00001BE0
		public unsafe Vector2 m_TotalFlexibleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_TotalFlexibleSize)) = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00019828 File Offset: 0x00017A28
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000039FB File Offset: 0x00001BFB
		public unsafe List<RectTransform> m_RectChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_RectChildren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup.NativeFieldInfoPtr_m_RectChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_m_Padding;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildAlignment;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalMinSize;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalPreferredSize;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeFieldInfoPtr_m_TotalFlexibleSize;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeFieldInfoPtr_m_RectChildren;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_RectOffset_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_childAlignment_Public_get_TextAnchor_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_set_childAlignment_Public_set_Void_TextAnchor_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Protected_get_RectTransform_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_get_rectChildren_Protected_get_List_1_RectTransform_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_minWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleWidth_Public_Virtual_New_get_Single_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_minHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_get_preferredHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_get_flexibleHeight_Public_Virtual_New_get_Single_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_layoutPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Protected_Virtual_Void_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSize_Protected_Single_Int32_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalPreferredSize_Protected_Single_Int32_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFlexibleSize_Protected_Single_Int32_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_GetStartOffset_Protected_Single_Int32_Single_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_GetAlignmentOnAxis_Protected_Single_Int32_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutInputForAxis_Protected_Void_Single_Single_Single_Int32_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxis_Protected_Void_RectTransform_Int32_Single_Single_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_SetChildAlongAxisWithScale_Protected_Void_RectTransform_Int32_Single_Single_Single_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_get_isRootLayoutGroup_Private_get_Boolean_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChildrenChanged_Protected_Virtual_New_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSetDirty_Private_IEnumerator_RectTransform_0;

		// Token: 0x020000A3 RID: 163
		[ObfuscatedName("UnityEngine.UI.LayoutGroup+<DelayedSetDirty>d__56")]
		public sealed class _DelayedSetDirty_d__56 : Object
		{
			// Token: 0x06000C77 RID: 3191 RVA: 0x00036608 File Offset: 0x00034808
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetDirty_d__56()
			{
				Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr, "<DelayedSetDirty>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr);
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "<>1__state");
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "<>2__current");
				LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, "rectTransform");
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664057);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664058);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664059);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664060);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664061);
				LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr, 100664062);
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x000366E8 File Offset: 0x000348E8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetDirty_d__56(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutGroup._DelayedSetDirty_d__56>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x00036730 File Offset: 0x00034930
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x00036764 File Offset: 0x00034964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088446, XrefRangeEnd = 1088448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000367A0 File Offset: 0x000349A0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x000367E0 File Offset: 0x000349E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088448, XrefRangeEnd = 1088453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000C7D RID: 3197 RVA: 0x00036814 File Offset: 0x00034A14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutGroup._DelayedSetDirty_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00006A71 File Offset: 0x00004C71
			public _DelayedSetDirty_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000421 RID: 1057
			// (get) Token: 0x06000C7F RID: 3199 RVA: 0x00036854 File Offset: 0x00034A54
			// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00006A7A File Offset: 0x00004C7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0003687C File Offset: 0x00034A7C
			// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00006A95 File Offset: 0x00004C95
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x000368AC File Offset: 0x00034AAC
			// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00006AB4 File Offset: 0x00004CB4
			public unsafe RectTransform rectTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutGroup._DelayedSetDirty_d__56.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009A8 RID: 2472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009A9 RID: 2473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009AA RID: 2474
			private static readonly IntPtr NativeFieldInfoPtr_rectTransform;

			// Token: 0x040009AB RID: 2475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009AC RID: 2476
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009AD RID: 2477
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009AE RID: 2478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009AF RID: 2479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009B0 RID: 2480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000A4 RID: 164
		private sealed class MethodInfoStoreGeneric_SetProperty_Protected_Void_byref_T_T_0<T>
		{
			// Token: 0x040009B1 RID: 2481
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LayoutGroup.NativeMethodInfoPtr_SetProperty_Protected_Void_byref_T_T_0, Il2CppClassPointerStore<LayoutGroup>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

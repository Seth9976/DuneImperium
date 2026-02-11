using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Kyub.UI
{
	// Token: 0x02000003 RID: 3
	public class FlexLayoutGroup : HorizontalOrVerticalLayoutGroup
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002524 File Offset: 0x00000724
		// Note: this type is marked as 'beforefieldinit'.
		static FlexLayoutGroup()
		{
			Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UICommons.dll", "Kyub.UI", "FlexLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr);
			FlexLayoutGroup.NativeFieldInfoPtr_m_IsVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, "m_IsVertical");
			FlexLayoutGroup.NativeFieldInfoPtr_m_SpacingBetween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, "m_SpacingBetween");
			FlexLayoutGroup.NativeFieldInfoPtr__Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, "_Groups");
			FlexLayoutGroup.NativeMethodInfoPtr_get_isVertical_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663299);
			FlexLayoutGroup.NativeMethodInfoPtr_set_isVertical_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663300);
			FlexLayoutGroup.NativeMethodInfoPtr_get_spacingBetweenGroups_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663301);
			FlexLayoutGroup.NativeMethodInfoPtr_set_spacingBetweenGroups_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663302);
			FlexLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663303);
			FlexLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663304);
			FlexLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663305);
			FlexLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663306);
			FlexLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663307);
			FlexLayoutGroup.NativeMethodInfoPtr_BuildChildrenGroups_Protected_Virtual_New_List_1_LinearGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663308);
			FlexLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663309);
			FlexLayoutGroup.NativeMethodInfoPtr_CalcAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663310);
			FlexLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663311);
			FlexLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663312);
			FlexLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Protected_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000026BC File Offset: 0x000008BC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000026F8 File Offset: 0x000008F8
		public unsafe bool isVertical
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_get_isVertical_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269189, XrefRangeEnd = 1269190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_set_isVertical_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002738 File Offset: 0x00000938
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002774 File Offset: 0x00000974
		public unsafe float spacingBetweenGroups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_get_spacingBetweenGroups_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269190, XrefRangeEnd = 1269191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_set_spacingBetweenGroups_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000027B4 File Offset: 0x000009B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269191, XrefRangeEnd = 1269199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlexLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000027F0 File Offset: 0x000009F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269199, XrefRangeEnd = 1269202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000282C File Offset: 0x00000A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269202, XrefRangeEnd = 1269203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalculateLayoutInputVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexLayoutGroup.NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002868 File Offset: 0x00000A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269203, XrefRangeEnd = 1269204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexLayoutGroup.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000028A4 File Offset: 0x00000AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269204, XrefRangeEnd = 1269223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexLayoutGroup.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028E0 File Offset: 0x00000AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269223, XrefRangeEnd = 1269281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<FlexLayoutGroup.LinearGroup> BuildChildrenGroups(bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVertical;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FlexLayoutGroup.NativeMethodInfoPtr_BuildChildrenGroups_Protected_Virtual_New_List_1_LinearGroup_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FlexLayoutGroup.LinearGroup>>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002938 File Offset: 0x00000B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1269296, RefRangeEnd = 1269298, XrefRangeStart = 1269281, XrefRangeEnd = 1269296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void CalcAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002984 File Offset: 0x00000B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269327, RefRangeEnd = 1269328, XrefRangeStart = 1269298, XrefRangeEnd = 1269327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcAlongGroupAxis(int axis, bool isVertical, FlexLayoutGroup.LinearGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_CalcAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029E4 File Offset: 0x00000BE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1269356, RefRangeEnd = 1269357, XrefRangeStart = 1269328, XrefRangeEnd = 1269356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A30 File Offset: 0x00000C30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1269440, RefRangeEnd = 1269442, XrefRangeStart = 1269357, XrefRangeEnd = 1269440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildrenAlongGroupAxis(int axis, bool isVertical, FlexLayoutGroup.LinearGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002A90 File Offset: 0x00000C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childForceExpand;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferred;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flexible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Protected_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002059 File Offset: 0x00000259
		public FlexLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002B2C File Offset: 0x00000D2C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe bool m_IsVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr_m_IsVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr_m_IsVertical)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002B54 File Offset: 0x00000D54
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe float m_SpacingBetween
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr_m_SpacingBetween);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr_m_SpacingBetween)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002B7C File Offset: 0x00000D7C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe List<FlexLayoutGroup.LinearGroup> _Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr__Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FlexLayoutGroup.LinearGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.NativeFieldInfoPtr__Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_IsVertical;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_SpacingBetween;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr__Groups;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_isVertical_Public_get_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_set_isVertical_Public_set_Void_Boolean_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_spacingBetweenGroups_Public_get_Single_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_set_spacingBetweenGroups_Public_set_Void_Single_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLayoutInputVertical_Public_Virtual_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_Void_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_BuildChildrenGroups_Protected_Virtual_New_List_1_LinearGroup_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongGroupAxis_Protected_Void_Int32_Boolean_LinearGroup_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Protected_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x02000009 RID: 9
		[Serializable]
		public class LinearGroup : global::Il2CppSystem.Object
		{
			// Token: 0x06000082 RID: 130 RVA: 0x000042A0 File Offset: 0x000024A0
			// Note: this type is marked as 'beforefieldinit'.
			static LinearGroup()
			{
				Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlexLayoutGroup>.NativeClassPtr, "LinearGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr);
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_Size");
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_Position");
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_RectChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_RectChildren");
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalMinSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_TotalMinSize");
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalPreferredSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_TotalPreferredSize");
				FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalFlexibleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, "m_TotalFlexibleSize");
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663314);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663315);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663316);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663317);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_RectChildren_Public_get_List_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663318);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_RectChildren_Public_set_Void_List_1_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663319);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalMinSize_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663320);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663321);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663322);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Public_Void_Single_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663323);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetStartOffset_Public_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663324);
				FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr, 100663325);
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000083 RID: 131 RVA: 0x00004434 File Offset: 0x00002634
			// (set) Token: 0x06000084 RID: 132 RVA: 0x00004470 File Offset: 0x00002670
			public unsafe Vector2 position
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1269147, RefRangeEnd = 1269149, XrefRangeStart = 1269147, XrefRangeEnd = 1269147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000085 RID: 133 RVA: 0x000044B0 File Offset: 0x000026B0
			// (set) Token: 0x06000086 RID: 134 RVA: 0x000044EC File Offset: 0x000026EC
			public unsafe Vector2 size
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 1269149, RefRangeEnd = 1269151, XrefRangeStart = 1269149, XrefRangeEnd = 1269149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000087 RID: 135 RVA: 0x0000452C File Offset: 0x0000272C
			// (set) Token: 0x06000088 RID: 136 RVA: 0x0000456C File Offset: 0x0000276C
			public unsafe List<RectTransform> RectChildren
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 1269158, RefRangeEnd = 1269163, XrefRangeStart = 1269151, XrefRangeEnd = 1269158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_get_RectChildren_Public_get_List_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269163, XrefRangeEnd = 1269164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_set_RectChildren_Public_set_Void_List_1_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000045B0 File Offset: 0x000027B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269164, XrefRangeEnd = 1269165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetTotalMinSize(int axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axis;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalMinSize_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600008A RID: 138 RVA: 0x000045FC File Offset: 0x000027FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269165, XrefRangeEnd = 1269166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetTotalPreferredSize(int axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axis;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalPreferredSize_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00004648 File Offset: 0x00002848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269166, XrefRangeEnd = 1269167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetTotalFlexibleSize(int axis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axis;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetTotalFlexibleSize_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00004694 File Offset: 0x00002894
			[CallerCount(0)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_SetLayoutInputForAxis_Public_Void_Single_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000046FC File Offset: 0x000028FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1269167, RefRangeEnd = 1269169, XrefRangeStart = 1269167, XrefRangeEnd = 1269167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float GetStartOffset(int axis, float requiredSpaceWithoutPadding, float alignmentOnAxis)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axis;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredSpaceWithoutPadding;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignmentOnAxis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr_GetStartOffset_Public_Single_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00004764 File Offset: 0x00002964
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1269187, RefRangeEnd = 1269189, XrefRangeStart = 1269169, XrefRangeEnd = 1269187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LinearGroup()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlexLayoutGroup.LinearGroup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlexLayoutGroup.LinearGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600008F RID: 143 RVA: 0x00002300 File Offset: 0x00000500
			public LinearGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000090 RID: 144 RVA: 0x000047A0 File Offset: 0x000029A0
			// (set) Token: 0x06000091 RID: 145 RVA: 0x00002309 File Offset: 0x00000509
			public unsafe Vector2 m_Size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Size)) = value;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000092 RID: 146 RVA: 0x000047C8 File Offset: 0x000029C8
			// (set) Token: 0x06000093 RID: 147 RVA: 0x00002324 File Offset: 0x00000524
			public unsafe Vector2 m_Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_Position)) = value;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000094 RID: 148 RVA: 0x000047F0 File Offset: 0x000029F0
			// (set) Token: 0x06000095 RID: 149 RVA: 0x0000233F File Offset: 0x0000053F
			public unsafe List<RectTransform> m_RectChildren
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_RectChildren);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_RectChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00004820 File Offset: 0x00002A20
			// (set) Token: 0x06000097 RID: 151 RVA: 0x0000235E File Offset: 0x0000055E
			public unsafe Vector2 m_TotalMinSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalMinSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalMinSize)) = value;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00004848 File Offset: 0x00002A48
			// (set) Token: 0x06000099 RID: 153 RVA: 0x00002379 File Offset: 0x00000579
			public unsafe Vector2 m_TotalPreferredSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalPreferredSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalPreferredSize)) = value;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00004870 File Offset: 0x00002A70
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00002394 File Offset: 0x00000594
			public unsafe Vector2 m_TotalFlexibleSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalFlexibleSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlexLayoutGroup.LinearGroup.NativeFieldInfoPtr_m_TotalFlexibleSize)) = value;
				}
			}

			// Token: 0x0400005C RID: 92
			private static readonly IntPtr NativeFieldInfoPtr_m_Size;

			// Token: 0x0400005D RID: 93
			private static readonly IntPtr NativeFieldInfoPtr_m_Position;

			// Token: 0x0400005E RID: 94
			private static readonly IntPtr NativeFieldInfoPtr_m_RectChildren;

			// Token: 0x0400005F RID: 95
			private static readonly IntPtr NativeFieldInfoPtr_m_TotalMinSize;

			// Token: 0x04000060 RID: 96
			private static readonly IntPtr NativeFieldInfoPtr_m_TotalPreferredSize;

			// Token: 0x04000061 RID: 97
			private static readonly IntPtr NativeFieldInfoPtr_m_TotalFlexibleSize;

			// Token: 0x04000062 RID: 98
			private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

			// Token: 0x04000063 RID: 99
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

			// Token: 0x04000064 RID: 100
			private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

			// Token: 0x04000065 RID: 101
			private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

			// Token: 0x04000066 RID: 102
			private static readonly IntPtr NativeMethodInfoPtr_get_RectChildren_Public_get_List_1_RectTransform_0;

			// Token: 0x04000067 RID: 103
			private static readonly IntPtr NativeMethodInfoPtr_set_RectChildren_Public_set_Void_List_1_RectTransform_0;

			// Token: 0x04000068 RID: 104
			private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSize_Public_Single_Int32_0;

			// Token: 0x04000069 RID: 105
			private static readonly IntPtr NativeMethodInfoPtr_GetTotalPreferredSize_Public_Single_Int32_0;

			// Token: 0x0400006A RID: 106
			private static readonly IntPtr NativeMethodInfoPtr_GetTotalFlexibleSize_Public_Single_Int32_0;

			// Token: 0x0400006B RID: 107
			private static readonly IntPtr NativeMethodInfoPtr_SetLayoutInputForAxis_Public_Void_Single_Single_Single_Int32_0;

			// Token: 0x0400006C RID: 108
			private static readonly IntPtr NativeMethodInfoPtr_GetStartOffset_Public_Single_Int32_Single_Single_0;

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

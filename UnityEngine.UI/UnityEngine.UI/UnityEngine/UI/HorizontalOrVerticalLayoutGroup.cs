using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x0200001F RID: 31
	public class HorizontalOrVerticalLayoutGroup : LayoutGroup
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00017070 File Offset: 0x00015270
		// Note: this type is marked as 'beforefieldinit'.
		static HorizontalOrVerticalLayoutGroup()
		{
			Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "HorizontalOrVerticalLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr);
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_Spacing");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildForceExpandHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildControlHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleWidth");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ChildScaleHeight");
			HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, "m_ReverseArrangement");
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663963);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663964);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663965);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663966);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663967);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663968);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663969);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663970);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663971);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663972);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663973);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663974);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663975);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663976);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663977);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663978);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663979);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663980);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663981);
			HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr, 100663982);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000172D0 File Offset: 0x000154D0
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0001730C File Offset: 0x0001550C
		public unsafe float spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1088251, RefRangeEnd = 1088252, XrefRangeStart = 1088248, XrefRangeEnd = 1088251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001734C File Offset: 0x0001554C
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00017388 File Offset: 0x00015588
		public unsafe bool childForceExpandWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088252, XrefRangeEnd = 1088255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x000173C8 File Offset: 0x000155C8
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00017404 File Offset: 0x00015604
		public unsafe bool childForceExpandHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088255, XrefRangeEnd = 1088258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00017444 File Offset: 0x00015644
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00017480 File Offset: 0x00015680
		public unsafe bool childControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088258, XrefRangeEnd = 1088261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000174C0 File Offset: 0x000156C0
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000174FC File Offset: 0x000156FC
		public unsafe bool childControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088261, XrefRangeEnd = 1088264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001753C File Offset: 0x0001573C
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00017578 File Offset: 0x00015778
		public unsafe bool childScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088264, XrefRangeEnd = 1088267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000175B8 File Offset: 0x000157B8
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000175F4 File Offset: 0x000157F4
		public unsafe bool childScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088267, XrefRangeEnd = 1088270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00017634 File Offset: 0x00015834
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00017670 File Offset: 0x00015870
		public unsafe bool reverseArrangement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088270, XrefRangeEnd = 1088273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000176B0 File Offset: 0x000158B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1088289, RefRangeEnd = 1088295, XrefRangeStart = 1088273, XrefRangeEnd = 1088289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcAlongAxis(int axis, bool isVertical)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000176FC File Offset: 0x000158FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1088363, RefRangeEnd = 1088369, XrefRangeStart = 1088295, XrefRangeEnd = 1088363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00017748 File Offset: 0x00015948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088369, XrefRangeEnd = 1088375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000177E4 File Offset: 0x000159E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088241, RefRangeEnd = 1088243, XrefRangeStart = 1088241, XrefRangeEnd = 1088243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HorizontalOrVerticalLayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalOrVerticalLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HorizontalOrVerticalLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000036D9 File Offset: 0x000018D9
		public HorizontalOrVerticalLayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00017820 File Offset: 0x00015A20
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x000036E2 File Offset: 0x000018E2
		public unsafe float m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00017848 File Offset: 0x00015A48
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x000036FD File Offset: 0x000018FD
		public unsafe bool m_ChildForceExpandWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandWidth)) = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00017870 File Offset: 0x00015A70
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003718 File Offset: 0x00001918
		public unsafe bool m_ChildForceExpandHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildForceExpandHeight)) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00017898 File Offset: 0x00015A98
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003733 File Offset: 0x00001933
		public unsafe bool m_ChildControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth)) = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000178C0 File Offset: 0x00015AC0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0000374E File Offset: 0x0000194E
		public unsafe bool m_ChildControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000178E8 File Offset: 0x00015AE8
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003769 File Offset: 0x00001969
		public unsafe bool m_ChildScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00017910 File Offset: 0x00015B10
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00003784 File Offset: 0x00001984
		public unsafe bool m_ChildScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00017938 File Offset: 0x00015B38
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x0000379F File Offset: 0x0000199F
		public unsafe bool m_ReverseArrangement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HorizontalOrVerticalLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement)) = value;
			}
		}

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandWidth;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildForceExpandHeight;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlWidth;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlHeight;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleWidth;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleHeight;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_m_ReverseArrangement;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandWidth_Public_get_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandWidth_Public_set_Void_Boolean_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_childForceExpandHeight_Public_get_Boolean_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_set_childForceExpandHeight_Public_set_Void_Boolean_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

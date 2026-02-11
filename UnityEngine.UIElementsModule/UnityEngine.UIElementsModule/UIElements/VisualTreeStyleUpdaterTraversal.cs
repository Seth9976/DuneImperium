using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200023B RID: 571
	public class VisualTreeStyleUpdaterTraversal : UnityEngine.UIElements.StyleSheets.HierarchyTraversal
	{
		// Token: 0x06002A2A RID: 10794 RVA: 0x000B7AA0 File Offset: 0x000B5CA0
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeStyleUpdaterTraversal()
		{
			Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeStyleUpdaterTraversal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr);
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ProcessVarContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_ProcessVarContext");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_UpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_UpdateList");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ParentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_ParentList");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_TempMatchResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_TempMatchResults");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr__currentPixelsPerPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "<currentPixelsPerPoint>k__BackingField");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StyleMatchingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_StyleMatchingContext");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StylePropertyReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_StylePropertyReader");
			VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_AnimatedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "m_AnimatedProperties");
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_get_currentPixelsPerPoint_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669600);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_set_currentPixelsPerPoint_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669601);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PrepareTraversal_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669602);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_AddChangedElement_Public_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669603);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669604);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PropagateToChildren_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669605);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669606);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_OnProcessMatchResult_Private_Static_Void_VisualElement_MatchResultInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669607);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669608);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessTransitions_Private_Void_VisualElement_byref_ComputedStyle_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669609);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ForceUpdateTransitions_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669610);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_CancelAnimationsWithNoTransitionProperty_Internal_Void_VisualElement_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669611);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ShouldSkipElement_Protected_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669612);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessMatchedRules_Private_ComputedStyle_VisualElement_List_1_SelectorMatchRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669613);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessMatchedVariables_Private_Void_StyleSheet_StyleRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669614);
			VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, 100669615);
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x000B7CB0 File Offset: 0x000B5EB0
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x000B7CEC File Offset: 0x000B5EEC
		public unsafe float currentPixelsPerPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 318235, RefRangeEnd = 318236, XrefRangeStart = 318235, XrefRangeEnd = 318236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_get_currentPixelsPerPoint_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_set_currentPixelsPerPoint_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x000B7D2C File Offset: 0x000B5F2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318236, RefRangeEnd = 318239, XrefRangeStart = 318236, XrefRangeEnd = 318239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareTraversal(float pixelsPerPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pixelsPerPoint;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PrepareTraversal_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x000B7D6C File Offset: 0x000B5F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347176, RefRangeEnd = 347178, XrefRangeStart = 347167, XrefRangeEnd = 347176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_AddChangedElement_Public_Void_VisualElement_VersionChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x000B7DBC File Offset: 0x000B5FBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347185, RefRangeEnd = 347187, XrefRangeStart = 347178, XrefRangeEnd = 347185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x000B7DF0 File Offset: 0x000B5FF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347193, RefRangeEnd = 347195, XrefRangeStart = 347187, XrefRangeEnd = 347193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropagateToChildren(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PropagateToChildren_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000B7E34 File Offset: 0x000B6034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347195, XrefRangeEnd = 347200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropagateToParents(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000B7E78 File Offset: 0x000B6078
		[CallerCount(0)]
		public unsafe static void OnProcessMatchResult(VisualElement current, UnityEngine.UIElements.StyleSheets.MatchResultInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_OnProcessMatchResult_Private_Static_Void_VisualElement_MatchResultInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000B7EBC File Offset: 0x000B60BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347200, XrefRangeEnd = 347292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TraverseRecursive(VisualElement element, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x000B7F18 File Offset: 0x000B6118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347292, XrefRangeEnd = 347295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(oldStyle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(newStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessTransitions_Private_Void_VisualElement_byref_ComputedStyle_byref_ComputedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x000B7F80 File Offset: 0x000B6180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347319, RefRangeEnd = 347320, XrefRangeStart = 347295, XrefRangeEnd = 347319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceUpdateTransitions(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ForceUpdateTransitions_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x000B7FC4 File Offset: 0x000B61C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347346, RefRangeEnd = 347348, XrefRangeStart = 347320, XrefRangeEnd = 347346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(newStyle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_CancelAnimationsWithNoTransitionProperty_Internal_Void_VisualElement_byref_ComputedStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x000B801C File Offset: 0x000B621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347348, XrefRangeEnd = 347351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSkipElement(VisualElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ShouldSkipElement_Protected_Boolean_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x000B806C File Offset: 0x000B626C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347468, RefRangeEnd = 347469, XrefRangeStart = 347351, XrefRangeEnd = 347468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputedStyle ProcessMatchedRules(VisualElement element, List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchingSelectors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessMatchedRules_Private_ComputedStyle_VisualElement_List_1_SelectorMatchRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ComputedStyle(intPtr);
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x000B80C8 File Offset: 0x000B62C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347475, RefRangeEnd = 347476, XrefRangeStart = 347469, XrefRangeEnd = 347475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rule);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr_ProcessMatchedVariables_Private_Void_StyleSheet_StyleRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000B811C File Offset: 0x000B631C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347543, RefRangeEnd = 347544, XrefRangeStart = 347476, XrefRangeEnd = 347543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeStyleUpdaterTraversal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00010FDB File Offset: 0x0000F1DB
		public VisualTreeStyleUpdaterTraversal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000B8158 File Offset: 0x000B6358
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		public unsafe StyleVariableContext m_ProcessVarContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ProcessVarContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleVariableContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ProcessVarContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x000B8188 File Offset: 0x000B6388
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00011003 File Offset: 0x0000F203
		public unsafe HashSet<VisualElement> m_UpdateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_UpdateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_UpdateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x000B81B8 File Offset: 0x000B63B8
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x00011022 File Offset: 0x0000F222
		public unsafe HashSet<VisualElement> m_ParentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ParentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_ParentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x000B81E8 File Offset: 0x000B63E8
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00011041 File Offset: 0x0000F241
		public unsafe List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_TempMatchResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_TempMatchResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000B8218 File Offset: 0x000B6418
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00011060 File Offset: 0x0000F260
		public unsafe float _currentPixelsPerPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr__currentPixelsPerPoint_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr__currentPixelsPerPoint_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000B8240 File Offset: 0x000B6440
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x0001107B File Offset: 0x0000F27B
		public unsafe StyleMatchingContext m_StyleMatchingContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StyleMatchingContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleMatchingContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StyleMatchingContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000B8270 File Offset: 0x000B6470
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x0001109A File Offset: 0x0000F29A
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyReader m_StylePropertyReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StylePropertyReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.StyleSheets.StylePropertyReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_StylePropertyReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x000B82A0 File Offset: 0x000B64A0
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x000110B9 File Offset: 0x0000F2B9
		public unsafe List<UnityEngine.UIElements.StyleSheets.StylePropertyId> m_AnimatedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_AnimatedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.StyleSheets.StylePropertyId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdaterTraversal.NativeFieldInfoPtr_m_AnimatedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000110D8 File Offset: 0x0000F2D8
		public StyleMatchingContext styleMatchingContext
		{
			get
			{
				return this.m_StyleMatchingContext;
			}
		}

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeFieldInfoPtr_m_ProcessVarContext;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateList;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentList;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeFieldInfoPtr_m_TempMatchResults;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeFieldInfoPtr__currentPixelsPerPoint_k__BackingField;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleMatchingContext;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeFieldInfoPtr_m_StylePropertyReader;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedProperties;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPixelsPerPoint_Private_get_Single_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_set_currentPixelsPerPoint_Private_set_Void_Single_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_PrepareTraversal_Public_Void_Single_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_AddChangedElement_Public_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_PropagateToChildren_Private_Void_VisualElement_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_PropagateToParents_Private_Void_VisualElement_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessMatchResult_Private_Static_Void_VisualElement_MatchResultInfo_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_TraverseRecursive_Public_Virtual_Void_VisualElement_Int32_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTransitions_Private_Void_VisualElement_byref_ComputedStyle_byref_ComputedStyle_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdateTransitions_Private_Void_VisualElement_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_CancelAnimationsWithNoTransitionProperty_Internal_Void_VisualElement_byref_ComputedStyle_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSkipElement_Protected_Boolean_VisualElement_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMatchedRules_Private_ComputedStyle_VisualElement_List_1_SelectorMatchRecord_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMatchedVariables_Private_Void_StyleSheet_StyleRule_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000535 RID: 1333
		[ObfuscatedName("UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060040A9 RID: 16553 RVA: 0x0010049C File Offset: 0x000FE69C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr);
				VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr, "<>9");
				VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr, "<>9__24_0");
				VisualTreeStyleUpdaterTraversal.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr, 100669617);
				VisualTreeStyleUpdaterTraversal.__c.NativeMethodInfoPtr__ProcessMatchedRules_b__24_0_Internal_Int32_SelectorMatchRecord_SelectorMatchRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr, 100669618);
			}

			// Token: 0x060040AA RID: 16554 RVA: 0x00100518 File Offset: 0x000FE718
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeStyleUpdaterTraversal.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060040AB RID: 16555 RVA: 0x00100554 File Offset: 0x000FE754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347166, XrefRangeEnd = 347167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ProcessMatchedRules_b__24_0(UnityEngine.UIElements.StyleSheets.SelectorMatchRecord a, UnityEngine.UIElements.StyleSheets.SelectorMatchRecord b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdaterTraversal.__c.NativeMethodInfoPtr__ProcessMatchedRules_b__24_0_Internal_Int32_SelectorMatchRecord_SelectorMatchRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060040AC RID: 16556 RVA: 0x0001B3B4 File Offset: 0x000195B4
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700135B RID: 4955
			// (get) Token: 0x060040AD RID: 16557 RVA: 0x001005C0 File Offset: 0x000FE7C0
			// (set) Token: 0x060040AE RID: 16558 RVA: 0x0001B3BD File Offset: 0x000195BD
			public unsafe static VisualTreeStyleUpdaterTraversal.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeStyleUpdaterTraversal.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700135C RID: 4956
			// (get) Token: 0x060040AF RID: 16559 RVA: 0x001005E8 File Offset: 0x000FE7E8
			// (set) Token: 0x060040B0 RID: 16560 RVA: 0x0001B3CF File Offset: 0x000195CF
			public unsafe static Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VisualTreeStyleUpdaterTraversal.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D86 RID: 11654
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D87 RID: 11655
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04002D88 RID: 11656
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D89 RID: 11657
			private static readonly IntPtr NativeMethodInfoPtr__ProcessMatchedRules_b__24_0_Internal_Int32_SelectorMatchRecord_SelectorMatchRecord_0;
		}

		// Token: 0x02000536 RID: 1334
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

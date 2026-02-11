using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022D RID: 557
	public class VisualElementFocusRing : Object
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x000B4C18 File Offset: 0x000B2E18
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementFocusRing()
		{
			Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementFocusRing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr);
			VisualElementFocusRing.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, "root");
			VisualElementFocusRing.NativeFieldInfoPtr__defaultFocusOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, "<defaultFocusOrder>k__BackingField");
			VisualElementFocusRing.NativeFieldInfoPtr_m_FocusRing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, "m_FocusRing");
			VisualElementFocusRing.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_DefaultFocusOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669505);
			VisualElementFocusRing.NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669506);
			VisualElementFocusRing.NativeMethodInfoPtr_get_defaultFocusOrder_Public_get_DefaultFocusOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669507);
			VisualElementFocusRing.NativeMethodInfoPtr_set_defaultFocusOrder_Public_set_Void_DefaultFocusOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669508);
			VisualElementFocusRing.NativeMethodInfoPtr_FocusRingAutoIndexSort_Private_Int32_FocusRingRecord_FocusRingRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669509);
			VisualElementFocusRing.NativeMethodInfoPtr_FocusRingSort_Private_Int32_FocusRingRecord_FocusRingRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669510);
			VisualElementFocusRing.NativeMethodInfoPtr_DoUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669511);
			VisualElementFocusRing.NativeMethodInfoPtr_BuildRingForScopeRecursive_Private_Void_VisualElement_byref_Int32_List_1_FocusRingRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669512);
			VisualElementFocusRing.NativeMethodInfoPtr_SortAndFlattenScopeLists_Private_Void_List_1_FocusRingRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669513);
			VisualElementFocusRing.NativeMethodInfoPtr_GetFocusableInternalIndex_Private_Int32_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669514);
			VisualElementFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669515);
			VisualElementFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_Final_New_Focusable_Focusable_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669516);
			VisualElementFocusRing.NativeMethodInfoPtr_GetNextFocusableInTree_Internal_Static_Focusable_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669517);
			VisualElementFocusRing.NativeMethodInfoPtr_GetPreviousFocusableInTree_Internal_Static_Focusable_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, 100669518);
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x000B4D9C File Offset: 0x000B2F9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346423, RefRangeEnd = 346426, XrefRangeStart = 346414, XrefRangeEnd = 346423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementFocusRing(VisualElement root, VisualElementFocusRing.DefaultFocusOrder dfo = VisualElementFocusRing.DefaultFocusOrder.ChildOrder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr__ctor_Public_Void_VisualElement_DefaultFocusOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
		public unsafe FocusController focusController
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusController>(intPtr3) : null;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x000B4E38 File Offset: 0x000B3038
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x000B4E74 File Offset: 0x000B3074
		public unsafe VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_get_defaultFocusOrder_Public_get_DefaultFocusOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_set_defaultFocusOrder_Public_set_Void_DefaultFocusOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x000B4EB4 File Offset: 0x000B30B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346426, XrefRangeEnd = 346453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_FocusRingAutoIndexSort_Private_Int32_FocusRingRecord_FocusRingRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000B4F14 File Offset: 0x000B3114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346453, XrefRangeEnd = 346454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_FocusRingSort_Private_Int32_FocusRingRecord_FocusRingRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x000B4F74 File Offset: 0x000B3174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346454, XrefRangeEnd = 346464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_DoUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x000B4FA8 File Offset: 0x000B31A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346495, RefRangeEnd = 346498, XrefRangeStart = 346464, XrefRangeEnd = 346495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scopeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scopeList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_BuildRingForScopeRecursive_Private_Void_VisualElement_byref_Int32_List_1_FocusRingRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x000B500C File Offset: 0x000B320C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346530, RefRangeEnd = 346534, XrefRangeStart = 346498, XrefRangeEnd = 346530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootScopeList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_SortAndFlattenScopeLists_Private_Void_List_1_FocusRingRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x000B5050 File Offset: 0x000B3250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346534, XrefRangeEnd = 346539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFocusableInternalIndex(Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_GetFocusableInternalIndex_Private_Int32_Focusable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x000B50A0 File Offset: 0x000B32A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346539, XrefRangeEnd = 346567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x000B5104 File Offset: 0x000B3304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346646, RefRangeEnd = 346647, XrefRangeStart = 346567, XrefRangeEnd = 346646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_Final_New_Focusable_Focusable_FocusChangeDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x000B5168 File Offset: 0x000B3368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346647, XrefRangeEnd = 346652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_GetNextFocusableInTree_Internal_Static_Focusable_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x000B51AC File Offset: 0x000B33AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346652, XrefRangeEnd = 346661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentFocusable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.NativeMethodInfoPtr_GetPreviousFocusableInTree_Internal_Static_Focusable_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr3) : null;
			}
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00010AAD File Offset: 0x0000ECAD
		public VisualElementFocusRing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000B51F0 File Offset: 0x000B33F0
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x00010AB6 File Offset: 0x0000ECB6
		public unsafe VisualElement root
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr_root);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000B5220 File Offset: 0x000B3420
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x00010AD5 File Offset: 0x0000ECD5
		public unsafe VisualElementFocusRing.DefaultFocusOrder _defaultFocusOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr__defaultFocusOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr__defaultFocusOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002968 RID: 10600 RVA: 0x000B5248 File Offset: 0x000B3448
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		public unsafe List<VisualElementFocusRing.FocusRingRecord> m_FocusRing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr_m_FocusRing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElementFocusRing.FocusRingRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.NativeFieldInfoPtr_m_FocusRing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeFieldInfoPtr_root;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeFieldInfoPtr__defaultFocusOrder_k__BackingField;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeFieldInfoPtr_m_FocusRing;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisualElement_DefaultFocusOrder_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_get_focusController_Private_get_FocusController_0;

		// Token: 0x04001D77 RID: 7543
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultFocusOrder_Public_get_DefaultFocusOrder_0;

		// Token: 0x04001D78 RID: 7544
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultFocusOrder_Public_set_Void_DefaultFocusOrder_0;

		// Token: 0x04001D79 RID: 7545
		private static readonly IntPtr NativeMethodInfoPtr_FocusRingAutoIndexSort_Private_Int32_FocusRingRecord_FocusRingRecord_0;

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_FocusRingSort_Private_Int32_FocusRingRecord_FocusRingRecord_0;

		// Token: 0x04001D7B RID: 7547
		private static readonly IntPtr NativeMethodInfoPtr_DoUpdate_Private_Void_0;

		// Token: 0x04001D7C RID: 7548
		private static readonly IntPtr NativeMethodInfoPtr_BuildRingForScopeRecursive_Private_Void_VisualElement_byref_Int32_List_1_FocusRingRecord_0;

		// Token: 0x04001D7D RID: 7549
		private static readonly IntPtr NativeMethodInfoPtr_SortAndFlattenScopeLists_Private_Void_List_1_FocusRingRecord_0;

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusableInternalIndex_Private_Int32_Focusable_0;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusChangeDirection_Public_Virtual_Final_New_FocusChangeDirection_Focusable_EventBase_0;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusable_Public_Virtual_Final_New_Focusable_Focusable_FocusChangeDirection_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFocusableInTree_Internal_Static_Focusable_VisualElement_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousFocusableInTree_Internal_Static_Focusable_VisualElement_0;

		// Token: 0x02000530 RID: 1328
		public enum DefaultFocusOrder
		{
			// Token: 0x04002D76 RID: 11638
			ChildOrder,
			// Token: 0x04002D77 RID: 11639
			PositionXY,
			// Token: 0x04002D78 RID: 11640
			PositionYX
		}

		// Token: 0x02000531 RID: 1329
		public class FocusRingRecord : Object
		{
			// Token: 0x06004096 RID: 16534 RVA: 0x001001C8 File Offset: 0x000FE3C8
			// Note: this type is marked as 'beforefieldinit'.
			static FocusRingRecord()
			{
				Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisualElementFocusRing>.NativeClassPtr, "FocusRingRecord");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr);
				VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_AutoIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr, "m_AutoIndex");
				VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_Focusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr, "m_Focusable");
				VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_IsSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr, "m_IsSlot");
				VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_ScopeNavigationOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr, "m_ScopeNavigationOrder");
				VisualElementFocusRing.FocusRingRecord.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr, 100669519);
			}

			// Token: 0x06004097 RID: 16535 RVA: 0x00100258 File Offset: 0x000FE458
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FocusRingRecord()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusRing.FocusRingRecord>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusRing.FocusRingRecord.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004098 RID: 16536 RVA: 0x0001B30A File Offset: 0x0001950A
			public FocusRingRecord(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001355 RID: 4949
			// (get) Token: 0x06004099 RID: 16537 RVA: 0x00100294 File Offset: 0x000FE494
			// (set) Token: 0x0600409A RID: 16538 RVA: 0x0001B313 File Offset: 0x00019513
			public unsafe int m_AutoIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_AutoIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_AutoIndex)) = value;
				}
			}

			// Token: 0x17001356 RID: 4950
			// (get) Token: 0x0600409B RID: 16539 RVA: 0x001002BC File Offset: 0x000FE4BC
			// (set) Token: 0x0600409C RID: 16540 RVA: 0x0001B32E File Offset: 0x0001952E
			public unsafe Focusable m_Focusable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_Focusable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Focusable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_Focusable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001357 RID: 4951
			// (get) Token: 0x0600409D RID: 16541 RVA: 0x001002EC File Offset: 0x000FE4EC
			// (set) Token: 0x0600409E RID: 16542 RVA: 0x0001B34D File Offset: 0x0001954D
			public unsafe bool m_IsSlot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_IsSlot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_IsSlot)) = value;
				}
			}

			// Token: 0x17001358 RID: 4952
			// (get) Token: 0x0600409F RID: 16543 RVA: 0x00100314 File Offset: 0x000FE514
			// (set) Token: 0x060040A0 RID: 16544 RVA: 0x0001B368 File Offset: 0x00019568
			public unsafe List<VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_ScopeNavigationOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisualElementFocusRing.FocusRingRecord>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementFocusRing.FocusRingRecord.NativeFieldInfoPtr_m_ScopeNavigationOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D79 RID: 11641
			private static readonly IntPtr NativeFieldInfoPtr_m_AutoIndex;

			// Token: 0x04002D7A RID: 11642
			private static readonly IntPtr NativeFieldInfoPtr_m_Focusable;

			// Token: 0x04002D7B RID: 11643
			private static readonly IntPtr NativeFieldInfoPtr_m_IsSlot;

			// Token: 0x04002D7C RID: 11644
			private static readonly IntPtr NativeFieldInfoPtr_m_ScopeNavigationOrder;

			// Token: 0x04002D7D RID: 11645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

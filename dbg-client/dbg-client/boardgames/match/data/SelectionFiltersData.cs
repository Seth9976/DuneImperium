using System;
using Canis.attributes;
using Canis.selectionfilters;
using Canis.utils.ids;
using dwd.core.data.composition;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetresponse;

namespace boardgames.match.data
{
	// Token: 0x0200027A RID: 634
	public class SelectionFiltersData : DataComponent
	{
		// Token: 0x06001D9E RID: 7582 RVA: 0x000800B4 File Offset: 0x0007E2B4
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionFiltersData()
		{
			Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.data", "SelectionFiltersData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr);
			SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "forceSelectionStepOne");
			SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "forceSelectionStepTwo");
			SelectionFiltersData.NativeFieldInfoPtr_forceIntChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "forceIntChoice");
			SelectionFiltersData.NativeFieldInfoPtr_forceDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "forceDone");
			SelectionFiltersData.NativeFieldInfoPtr_canCancelStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "canCancelStepTwo");
			SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepOneList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "filterSelectionStepOneList");
			SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "filterSelectionStepTwo");
			SelectionFiltersData.NativeFieldInfoPtr_selectionNodeFilterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "selectionNodeFilterData");
			SelectionFiltersData.NativeFieldInfoPtr_filterIntChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "filterIntChoice");
			SelectionFiltersData.NativeFieldInfoPtr_filterDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "filterDone");
			SelectionFiltersData.NativeFieldInfoPtr_selectionMessageFilterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "selectionMessageFilterData");
			SelectionFiltersData.NativeFieldInfoPtr__SelectionDisabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "<SelectionDisabled>k__BackingField");
			SelectionFiltersData.NativeMethodInfoPtr_get_SelectionDisabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668149);
			SelectionFiltersData.NativeMethodInfoPtr_set_SelectionDisabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668150);
			SelectionFiltersData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668151);
			SelectionFiltersData.NativeMethodInfoPtr_FiltersActive_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668152);
			SelectionFiltersData.NativeMethodInfoPtr_AutoSelectActive_Public_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668153);
			SelectionFiltersData.NativeMethodInfoPtr_AutoSelectIfNeeded_Public_Virtual_New_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668154);
			SelectionFiltersData.NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_EntityID_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668155);
			SelectionFiltersData.NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_Int32_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668156);
			SelectionFiltersData.NativeMethodInfoPtr_CanSelectForAnyNode_Public_Boolean_EntityID_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668157);
			SelectionFiltersData.NativeMethodInfoPtr_canSelectForNodeOrChildren_Private_Boolean_EntityID_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668158);
			SelectionFiltersData.NativeMethodInfoPtr_CanCancel_Public_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668159);
			SelectionFiltersData.NativeMethodInfoPtr_MustAdvance_Public_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668160);
			SelectionFiltersData.NativeMethodInfoPtr_FilterSatisfied_Public_Virtual_New_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668161);
			SelectionFiltersData.NativeMethodInfoPtr_nodeSatisfiesTargetResponse_Protected_Virtual_New_Boolean_ISelectionNode_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668162);
			SelectionFiltersData.NativeMethodInfoPtr_FilteredEntities_Public_Virtual_New_List_1_EntityID_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668163);
			SelectionFiltersData.NativeMethodInfoPtr_entitiesInTargetResponse_Protected_Virtual_New_List_1_EntityID_ISelectionNode_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668164);
			SelectionFiltersData.NativeMethodInfoPtr_FilteredInts_Public_Virtual_New_List_1_Int32_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668165);
			SelectionFiltersData.NativeMethodInfoPtr_intInTargetResponse_Protected_Virtual_New_Nullable_1_Int32_ISelectionNode_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668166);
			SelectionFiltersData.NativeMethodInfoPtr_GetSelectionNodeFilterData_Public_Il2CppReferenceArray_1_SelectionNodeFilterData_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668167);
			SelectionFiltersData.NativeMethodInfoPtr_getNodeDepth_Private_Int32_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668168);
			SelectionFiltersData.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668169);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668170);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668171);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668172);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Il2CppReferenceArray_1_SelectionMessageFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668173);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668174);
			SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668175);
			SelectionFiltersData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, 100668176);
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00080404 File Offset: 0x0007E604
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00080440 File Offset: 0x0007E640
		public unsafe bool SelectionDisabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_get_SelectionDisabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_set_SelectionDisabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00080480 File Offset: 0x0007E680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537175, RefRangeEnd = 537176, XrefRangeStart = 537129, XrefRangeEnd = 537175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionFiltersData(EntityComponent entity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000804CC File Offset: 0x0007E6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537176, XrefRangeEnd = 537214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool FiltersActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_FiltersActive_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00080514 File Offset: 0x0007E714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537255, RefRangeEnd = 537256, XrefRangeStart = 537214, XrefRangeEnd = 537255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AutoSelectActive(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_AutoSelectActive_Public_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00080564 File Offset: 0x0007E764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537256, XrefRangeEnd = 537311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AutoSelectIfNeeded(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_AutoSelectIfNeeded_Public_Virtual_New_Boolean_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000805BC File Offset: 0x0007E7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537311, XrefRangeEnd = 537323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSelect(EntityID entityID, ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_EntityID_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00080628 File Offset: 0x0007E828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537323, XrefRangeEnd = 537335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSelect(int number, ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref number;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_Int32_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x00080690 File Offset: 0x0007E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537335, XrefRangeEnd = 537340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSelectForAnyNode(EntityID entityID, ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_CanSelectForAnyNode_Public_Boolean_EntityID_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000806F0 File Offset: 0x0007E8F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 537362, RefRangeEnd = 537364, XrefRangeStart = 537340, XrefRangeEnd = 537362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool canSelectForNodeOrChildren(EntityID entityID, ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_canSelectForNodeOrChildren_Private_Boolean_EntityID_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00080750 File Offset: 0x0007E950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 537434, RefRangeEnd = 537435, XrefRangeStart = 537364, XrefRangeEnd = 537434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCancel(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_CanCancel_Public_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000807A0 File Offset: 0x0007E9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537435, XrefRangeEnd = 537440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MustAdvance(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_MustAdvance_Public_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000807F0 File Offset: 0x0007E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537440, XrefRangeEnd = 537486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool FilterSatisfied(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_FilterSatisfied_Public_Virtual_New_Boolean_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00080848 File Offset: 0x0007EA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537486, XrefRangeEnd = 537509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool nodeSatisfiesTargetResponse(ISelectionNode node, TargetResponse targetResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_nodeSatisfiesTargetResponse_Protected_Virtual_New_Boolean_ISelectionNode_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000808B4 File Offset: 0x0007EAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537509, XrefRangeEnd = 537573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<EntityID> FilteredEntities(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_FilteredEntities_Public_Virtual_New_List_1_EntityID_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00080910 File Offset: 0x0007EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537573, XrefRangeEnd = 537585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<EntityID> entitiesInTargetResponse(ISelectionNode node, TargetResponse targetResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_entitiesInTargetResponse_Protected_Virtual_New_List_1_EntityID_ISelectionNode_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr3) : null;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x00080980 File Offset: 0x0007EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537585, XrefRangeEnd = 537609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<int> FilteredInts(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_FilteredInts_Public_Virtual_New_List_1_Int32_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000809DC File Offset: 0x0007EBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537609, XrefRangeEnd = 537618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<int> intInTargetResponse(ISelectionNode node, TargetResponse targetResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetResponse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_intInTargetResponse_Protected_Virtual_New_Nullable_1_Int32_ISelectionNode_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00080A44 File Offset: 0x0007EC44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 537660, RefRangeEnd = 537664, XrefRangeStart = 537618, XrefRangeEnd = 537660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<SelectionNodeFilterData> GetSelectionNodeFilterData(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_GetSelectionNodeFilterData_Public_Il2CppReferenceArray_1_SelectionNodeFilterData_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SelectionNodeFilterData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00080A94 File Offset: 0x0007EC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 537672, RefRangeEnd = 537674, XrefRangeStart = 537664, XrefRangeEnd = 537672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int getNodeDepth(ISelectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_getNodeDepth_Private_Int32_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00080AE4 File Offset: 0x0007ECE4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537674, XrefRangeEnd = 537693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00080B2C File Offset: 0x0007ED2C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 537698, RefRangeEnd = 537706, XrefRangeStart = 537693, XrefRangeEnd = 537698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00080B7C File Offset: 0x0007ED7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537706, XrefRangeEnd = 537707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(List<EntityID> entityList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00080BCC File Offset: 0x0007EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537707, XrefRangeEnd = 537708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(List<SelectionNodeFilterData> targetResponses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetResponses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x00080C1C File Offset: 0x0007EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537708, XrefRangeEnd = 537709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(Il2CppReferenceArray<SelectionMessageFilter> messageFilters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageFilters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Il2CppReferenceArray_1_SelectionMessageFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00080C6C File Offset: 0x0007EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537709, XrefRangeEnd = 537711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(Nullable<int> nullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nullable));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00080CC0 File Offset: 0x0007EEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537711, XrefRangeEnd = 537713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isNullOrDisabled(Nullable<bool> nullable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(nullable));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00080D14 File Offset: 0x0007EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537713, XrefRangeEnd = 537821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionFiltersData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0000FAF9 File Offset: 0x0000DCF9
		public SelectionFiltersData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00080D58 File Offset: 0x0007EF58
		// (set) Token: 0x06001DBD RID: 7613 RVA: 0x0000FB02 File Offset: 0x0000DD02
		public unsafe IAttribute<EntityID> forceSelectionStepOne
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepOne);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepOne), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00080D88 File Offset: 0x0007EF88
		// (set) Token: 0x06001DBF RID: 7615 RVA: 0x0000FB21 File Offset: 0x0000DD21
		public unsafe IAttribute<EntityID> forceSelectionStepTwo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepTwo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceSelectionStepTwo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x00080DB8 File Offset: 0x0007EFB8
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x0000FB40 File Offset: 0x0000DD40
		public unsafe IAttribute<Nullable<int>> forceIntChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceIntChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceIntChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00080DE8 File Offset: 0x0007EFE8
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x0000FB5F File Offset: 0x0000DD5F
		public unsafe IAttribute<Nullable<bool>> forceDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_forceDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00080E18 File Offset: 0x0007F018
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x0000FB7E File Offset: 0x0000DD7E
		public unsafe IAttribute<Nullable<bool>> canCancelStepTwo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_canCancelStepTwo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_canCancelStepTwo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00080E48 File Offset: 0x0007F048
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x0000FB9D File Offset: 0x0000DD9D
		public unsafe IAttribute<List<EntityID>> filterSelectionStepOneList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepOneList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepOneList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x00080E78 File Offset: 0x0007F078
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public unsafe IAttribute<EntityID> filterSelectionStepTwo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepTwo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterSelectionStepTwo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00080EA8 File Offset: 0x0007F0A8
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x0000FBDB File Offset: 0x0000DDDB
		public unsafe IAttribute<List<SelectionNodeFilterData>> selectionNodeFilterData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_selectionNodeFilterData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<SelectionNodeFilterData>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_selectionNodeFilterData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00080ED8 File Offset: 0x0007F0D8
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x0000FBFA File Offset: 0x0000DDFA
		public unsafe IAttribute<Nullable<int>> filterIntChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterIntChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterIntChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001DCE RID: 7630 RVA: 0x00080F08 File Offset: 0x0007F108
		// (set) Token: 0x06001DCF RID: 7631 RVA: 0x0000FC19 File Offset: 0x0000DE19
		public unsafe IAttribute<Nullable<bool>> filterDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_filterDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x00080F38 File Offset: 0x0007F138
		// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x0000FC38 File Offset: 0x0000DE38
		public unsafe IAttribute<Il2CppReferenceArray<SelectionMessageFilter>> selectionMessageFilterData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_selectionMessageFilterData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Il2CppReferenceArray<SelectionMessageFilter>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr_selectionMessageFilterData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x00080F68 File Offset: 0x0007F168
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x0000FC57 File Offset: 0x0000DE57
		public unsafe bool _SelectionDisabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr__SelectionDisabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.NativeFieldInfoPtr__SelectionDisabled_k__BackingField)) = value;
			}
		}

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_forceSelectionStepOne;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_forceSelectionStepTwo;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_forceIntChoice;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_forceDone;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_canCancelStepTwo;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeFieldInfoPtr_filterSelectionStepOneList;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeFieldInfoPtr_filterSelectionStepTwo;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeFieldInfoPtr_selectionNodeFilterData;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeFieldInfoPtr_filterIntChoice;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_filterDone;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_selectionMessageFilterData;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeFieldInfoPtr__SelectionDisabled_k__BackingField;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionDisabled_Public_get_Boolean_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionDisabled_Public_set_Void_Boolean_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_FiltersActive_Public_Virtual_New_Boolean_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_AutoSelectActive_Public_Boolean_ISelectionNode_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_AutoSelectIfNeeded_Public_Virtual_New_Boolean_ISelectionNode_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_EntityID_ISelectionNode_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_CanSelect_Public_Virtual_New_Boolean_Int32_ISelectionNode_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_CanSelectForAnyNode_Public_Boolean_EntityID_ISelectionNode_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_canSelectForNodeOrChildren_Private_Boolean_EntityID_ISelectionNode_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_CanCancel_Public_Boolean_ISelectionNode_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_MustAdvance_Public_Boolean_ISelectionNode_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_FilterSatisfied_Public_Virtual_New_Boolean_ISelectionNode_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_nodeSatisfiesTargetResponse_Protected_Virtual_New_Boolean_ISelectionNode_TargetResponse_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_FilteredEntities_Public_Virtual_New_List_1_EntityID_ISelectionNode_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_entitiesInTargetResponse_Protected_Virtual_New_List_1_EntityID_ISelectionNode_TargetResponse_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_FilteredInts_Public_Virtual_New_List_1_Int32_ISelectionNode_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_intInTargetResponse_Protected_Virtual_New_Nullable_1_Int32_ISelectionNode_TargetResponse_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionNodeFilterData_Public_Il2CppReferenceArray_1_SelectionNodeFilterData_ISelectionNode_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_getNodeDepth_Private_Int32_ISelectionNode_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_New_get_UInt64_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_EntityID_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_EntityID_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_List_1_SelectionNodeFilterData_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Il2CppReferenceArray_1_SelectionMessageFilter_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Int32_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_isNullOrDisabled_Protected_Boolean_Nullable_1_Boolean_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200046C RID: 1132
		[ObfuscatedName("boardgames.match.data.SelectionFiltersData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060035A2 RID: 13730 RVA: 0x000C8B34 File Offset: 0x000C6D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr);
				SelectionFiltersData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__17_0");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__18_0");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__18_1");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__23_0");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__23_1");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__27_0");
				SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, "<>9__27_1");
				SelectionFiltersData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668178);
				SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectActive_b__17_0_Internal_Boolean_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668179);
				SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_0_Internal_Boolean_SelectionWithTargetsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668180);
				SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_1_Internal_Boolean_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668181);
				SelectionFiltersData.__c.NativeMethodInfoPtr__CanCancel_b__23_0_Internal_Boolean_SelectionWithTargetsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668182);
				SelectionFiltersData.__c.NativeMethodInfoPtr__CanCancel_b__23_1_Internal_Boolean_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668183);
				SelectionFiltersData.__c.NativeMethodInfoPtr__FilteredEntities_b__27_0_Internal_EntityID_SelectionWithTargetsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668184);
				SelectionFiltersData.__c.NativeMethodInfoPtr__FilteredEntities_b__27_1_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr, 100668185);
			}

			// Token: 0x060035A3 RID: 13731 RVA: 0x000C8CA0 File Offset: 0x000C6EA0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFiltersData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035A4 RID: 13732 RVA: 0x000C8CDC File Offset: 0x000C6EDC
			[CallerCount(0)]
			public unsafe bool _AutoSelectActive_b__17_0(SelectionNodeFilterData filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectActive_b__17_0_Internal_Boolean_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035A5 RID: 13733 RVA: 0x000C8D2C File Offset: 0x000C6F2C
			[CallerCount(0)]
			public unsafe bool _AutoSelectIfNeeded_b__18_0(SelectionWithTargetsFilter selectionMessageFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionMessageFilter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_0_Internal_Boolean_SelectionWithTargetsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035A6 RID: 13734 RVA: 0x000C8D7C File Offset: 0x000C6F7C
			[CallerCount(0)]
			public unsafe bool _AutoSelectIfNeeded_b__18_1(SelectionNodeFilterData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_1_Internal_Boolean_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035A7 RID: 13735 RVA: 0x000C8DCC File Offset: 0x000C6FCC
			[CallerCount(0)]
			public unsafe bool _CanCancel_b__23_0(SelectionWithTargetsFilter selectionMessageFilter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionMessageFilter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__CanCancel_b__23_0_Internal_Boolean_SelectionWithTargetsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035A8 RID: 13736 RVA: 0x000C8E1C File Offset: 0x000C701C
			[CallerCount(0)]
			public unsafe bool _CanCancel_b__23_1(SelectionNodeFilterData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__CanCancel_b__23_1_Internal_Boolean_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035A9 RID: 13737 RVA: 0x000C8E6C File Offset: 0x000C706C
			[CallerCount(0)]
			public unsafe EntityID _FilteredEntities_b__27_0(SelectionWithTargetsFilter filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__FilteredEntities_b__27_0_Internal_EntityID_SelectionWithTargetsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060035AA RID: 13738 RVA: 0x000C8EBC File Offset: 0x000C70BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537114, XrefRangeEnd = 537118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilteredEntities_b__27_1(EntityID entityID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c.NativeMethodInfoPtr__FilteredEntities_b__27_1_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035AB RID: 13739 RVA: 0x0001BA9C File Offset: 0x00019C9C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FBF RID: 4031
			// (get) Token: 0x060035AC RID: 13740 RVA: 0x000C8F0C File Offset: 0x000C710C
			// (set) Token: 0x060035AD RID: 13741 RVA: 0x0001BAA5 File Offset: 0x00019CA5
			public unsafe static SelectionFiltersData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionFiltersData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC0 RID: 4032
			// (get) Token: 0x060035AE RID: 13742 RVA: 0x000C8F34 File Offset: 0x000C7134
			// (set) Token: 0x060035AF RID: 13743 RVA: 0x0001BAB7 File Offset: 0x00019CB7
			public unsafe static Func<SelectionNodeFilterData, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionNodeFilterData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC1 RID: 4033
			// (get) Token: 0x060035B0 RID: 13744 RVA: 0x000C8F5C File Offset: 0x000C715C
			// (set) Token: 0x060035B1 RID: 13745 RVA: 0x0001BAC9 File Offset: 0x00019CC9
			public unsafe static Func<SelectionWithTargetsFilter, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionWithTargetsFilter, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC2 RID: 4034
			// (get) Token: 0x060035B2 RID: 13746 RVA: 0x000C8F84 File Offset: 0x000C7184
			// (set) Token: 0x060035B3 RID: 13747 RVA: 0x0001BADB File Offset: 0x00019CDB
			public unsafe static Func<SelectionNodeFilterData, bool> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionNodeFilterData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC3 RID: 4035
			// (get) Token: 0x060035B4 RID: 13748 RVA: 0x000C8FAC File Offset: 0x000C71AC
			// (set) Token: 0x060035B5 RID: 13749 RVA: 0x0001BAED File Offset: 0x00019CED
			public unsafe static Func<SelectionWithTargetsFilter, bool> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionWithTargetsFilter, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC4 RID: 4036
			// (get) Token: 0x060035B6 RID: 13750 RVA: 0x000C8FD4 File Offset: 0x000C71D4
			// (set) Token: 0x060035B7 RID: 13751 RVA: 0x0001BAFF File Offset: 0x00019CFF
			public unsafe static Func<SelectionNodeFilterData, bool> __9__23_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionNodeFilterData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC5 RID: 4037
			// (get) Token: 0x060035B8 RID: 13752 RVA: 0x000C8FFC File Offset: 0x000C71FC
			// (set) Token: 0x060035B9 RID: 13753 RVA: 0x0001BB11 File Offset: 0x00019D11
			public unsafe static Func<SelectionWithTargetsFilter, EntityID> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionWithTargetsFilter, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC6 RID: 4038
			// (get) Token: 0x060035BA RID: 13754 RVA: 0x000C9024 File Offset: 0x000C7224
			// (set) Token: 0x060035BB RID: 13755 RVA: 0x0001BB23 File Offset: 0x00019D23
			public unsafe static Func<EntityID, bool> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SelectionFiltersData.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400210A RID: 8458
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400210B RID: 8459
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400210C RID: 8460
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400210D RID: 8461
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x0400210E RID: 8462
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x0400210F RID: 8463
			private static readonly IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04002110 RID: 8464
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04002111 RID: 8465
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04002112 RID: 8466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002113 RID: 8467
			private static readonly IntPtr NativeMethodInfoPtr__AutoSelectActive_b__17_0_Internal_Boolean_SelectionNodeFilterData_0;

			// Token: 0x04002114 RID: 8468
			private static readonly IntPtr NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_0_Internal_Boolean_SelectionWithTargetsFilter_0;

			// Token: 0x04002115 RID: 8469
			private static readonly IntPtr NativeMethodInfoPtr__AutoSelectIfNeeded_b__18_1_Internal_Boolean_SelectionNodeFilterData_0;

			// Token: 0x04002116 RID: 8470
			private static readonly IntPtr NativeMethodInfoPtr__CanCancel_b__23_0_Internal_Boolean_SelectionWithTargetsFilter_0;

			// Token: 0x04002117 RID: 8471
			private static readonly IntPtr NativeMethodInfoPtr__CanCancel_b__23_1_Internal_Boolean_SelectionNodeFilterData_0;

			// Token: 0x04002118 RID: 8472
			private static readonly IntPtr NativeMethodInfoPtr__FilteredEntities_b__27_0_Internal_EntityID_SelectionWithTargetsFilter_0;

			// Token: 0x04002119 RID: 8473
			private static readonly IntPtr NativeMethodInfoPtr__FilteredEntities_b__27_1_Internal_Boolean_EntityID_0;
		}

		// Token: 0x0200046D RID: 1133
		[ObfuscatedName("boardgames.match.data.SelectionFiltersData+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x060035BC RID: 13756 RVA: 0x000C904C File Offset: 0x000C724C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr);
				SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr, "node");
				SelectionFiltersData.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr, 100668186);
				SelectionFiltersData.__c__DisplayClass25_0.NativeMethodInfoPtr__FilterSatisfied_b__0_Internal_Boolean_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr, 100668187);
			}

			// Token: 0x060035BD RID: 13757 RVA: 0x000C90C8 File Offset: 0x000C72C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035BE RID: 13758 RVA: 0x000C9104 File Offset: 0x000C7304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537118, XrefRangeEnd = 537119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilterSatisfied_b__0(SelectionNodeFilterData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass25_0.NativeMethodInfoPtr__FilterSatisfied_b__0_Internal_Boolean_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035BF RID: 13759 RVA: 0x0001BB35 File Offset: 0x00019D35
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC7 RID: 4039
			// (get) Token: 0x060035C0 RID: 13760 RVA: 0x000C9154 File Offset: 0x000C7354
			// (set) Token: 0x060035C1 RID: 13761 RVA: 0x0001BB3E File Offset: 0x00019D3E
			public unsafe SelectionFiltersData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionFiltersData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FC8 RID: 4040
			// (get) Token: 0x060035C2 RID: 13762 RVA: 0x000C9184 File Offset: 0x000C7384
			// (set) Token: 0x060035C3 RID: 13763 RVA: 0x0001BB5D File Offset: 0x00019D5D
			public unsafe ISelectionNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_0.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400211A RID: 8474
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400211B RID: 8475
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x0400211C RID: 8476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400211D RID: 8477
			private static readonly IntPtr NativeMethodInfoPtr__FilterSatisfied_b__0_Internal_Boolean_SelectionNodeFilterData_0;
		}

		// Token: 0x0200046E RID: 1134
		[ObfuscatedName("boardgames.match.data.SelectionFiltersData+<>c__DisplayClass25_1")]
		public sealed class __c__DisplayClass25_1 : Object
		{
			// Token: 0x060035C4 RID: 13764 RVA: 0x000C91B4 File Offset: 0x000C73B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_1()
			{
				Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "<>c__DisplayClass25_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr);
				SelectionFiltersData.__c__DisplayClass25_1.NativeFieldInfoPtr_entityListSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr, "entityListSelection");
				SelectionFiltersData.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr, 100668188);
				SelectionFiltersData.__c__DisplayClass25_1.NativeMethodInfoPtr__FilterSatisfied_b__1_Internal_Boolean_SelectionWithTargetsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr, 100668189);
			}

			// Token: 0x060035C5 RID: 13765 RVA: 0x000C921C File Offset: 0x000C741C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass25_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass25_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035C6 RID: 13766 RVA: 0x000C9258 File Offset: 0x000C7458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537119, XrefRangeEnd = 537125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FilterSatisfied_b__1(SelectionWithTargetsFilter filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass25_1.NativeMethodInfoPtr__FilterSatisfied_b__1_Internal_Boolean_SelectionWithTargetsFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035C7 RID: 13767 RVA: 0x0001BB7C File Offset: 0x00019D7C
			public __c__DisplayClass25_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FC9 RID: 4041
			// (get) Token: 0x060035C8 RID: 13768 RVA: 0x000C92A8 File Offset: 0x000C74A8
			// (set) Token: 0x060035C9 RID: 13769 RVA: 0x0001BB85 File Offset: 0x00019D85
			public unsafe IEntityListSelection entityListSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_1.NativeFieldInfoPtr_entityListSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEntityListSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass25_1.NativeFieldInfoPtr_entityListSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400211E RID: 8478
			private static readonly IntPtr NativeFieldInfoPtr_entityListSelection;

			// Token: 0x0400211F RID: 8479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002120 RID: 8480
			private static readonly IntPtr NativeMethodInfoPtr__FilterSatisfied_b__1_Internal_Boolean_SelectionWithTargetsFilter_0;
		}

		// Token: 0x0200046F RID: 1135
		[ObfuscatedName("boardgames.match.data.SelectionFiltersData+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x060035CA RID: 13770 RVA: 0x000C92D8 File Offset: 0x000C74D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionFiltersData>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr);
				SelectionFiltersData.__c__DisplayClass26_0.NativeFieldInfoPtr__entityListTargetNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr, "<entityListTargetNode>5__2");
				SelectionFiltersData.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr, 100668190);
				SelectionFiltersData.__c__DisplayClass26_0.NativeMethodInfoPtr__nodeSatisfiesTargetResponse_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr, 100668191);
			}

			// Token: 0x060035CB RID: 13771 RVA: 0x000C9340 File Offset: 0x000C7540
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFiltersData.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060035CC RID: 13772 RVA: 0x000C937C File Offset: 0x000C757C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 537125, XrefRangeEnd = 537129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _nodeSatisfiesTargetResponse_b__0(EntityID targetEntity)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetEntity);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFiltersData.__c__DisplayClass26_0.NativeMethodInfoPtr__nodeSatisfiesTargetResponse_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060035CD RID: 13773 RVA: 0x0001BBA4 File Offset: 0x00019DA4
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FCA RID: 4042
			// (get) Token: 0x060035CE RID: 13774 RVA: 0x000C93CC File Offset: 0x000C75CC
			// (set) Token: 0x060035CF RID: 13775 RVA: 0x0001BBAD File Offset: 0x00019DAD
			public unsafe EntityListTargetNode _entityListTargetNode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass26_0.NativeFieldInfoPtr__entityListTargetNode_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityListTargetNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFiltersData.__c__DisplayClass26_0.NativeFieldInfoPtr__entityListTargetNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002121 RID: 8481
			private static readonly IntPtr NativeFieldInfoPtr__entityListTargetNode_5__2;

			// Token: 0x04002122 RID: 8482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002123 RID: 8483
			private static readonly IntPtr NativeMethodInfoPtr__nodeSatisfiesTargetResponse_b__0_Internal_Boolean_EntityID_0;
		}
	}
}

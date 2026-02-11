using System;
using Canis.utils.ids;
using dwd.core.match.selection.rootSelections;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x0200014B RID: 331
	public class SelectionNodeFactory : Object
	{
		// Token: 0x060012E0 RID: 4832 RVA: 0x0005F46C File Offset: 0x0005D66C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionNodeFactory()
		{
			Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "SelectionNodeFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr);
			SelectionNodeFactory.NativeFieldInfoPtr_SelectionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, "SelectionMap");
			SelectionNodeFactory.NativeFieldInfoPtr_InfoMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, "InfoMap");
			SelectionNodeFactory.NativeFieldInfoPtr_sessionWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, "sessionWriter");
			SelectionNodeFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666118);
			SelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_New_get_IAccountSessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666119);
			SelectionNodeFactory.NativeMethodInfoPtr_OverrideSessionWriter_Protected_Void_IAccountSessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666120);
			SelectionNodeFactory.NativeMethodInfoPtr_GetSubtypeFromDictionary_Private_T_Dictionary_2_Type_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666121);
			SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_ISelectionRoot_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666122);
			SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666123);
			SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666124);
			SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666125);
			SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoice_Private_CustomChoiceNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666126);
			SelectionNodeFactory.NativeMethodInfoPtr_createArchetypeChoice_Private_ArchetypeCustomChoiceNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666127);
			SelectionNodeFactory.NativeMethodInfoPtr_createMSWT_Private_MultipleSelectionWithTargetsNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666128);
			SelectionNodeFactory.NativeMethodInfoPtr_createSWT_Private_SelectionWithTargetsNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666129);
			SelectionNodeFactory.NativeMethodInfoPtr_createSWTAA_Private_SelectionWithTargetsAndActionsNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666130);
			SelectionNodeFactory.NativeMethodInfoPtr_createMulliganChoice_Private_MulliganChoiceNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666131);
			SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceWithTargetsNode_Private_CustomChoiceWithTargetsNode_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666132);
			SelectionNodeFactory.NativeMethodInfoPtr_createEntityList_Private_EntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666133);
			SelectionNodeFactory.NativeMethodInfoPtr_createKnapsackEntityList_Private_KnapsackEntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666134);
			SelectionNodeFactory.NativeMethodInfoPtr_createXTarget_Private_XTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666135);
			SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceInfo_Private_CustomChoiceInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666136);
			SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceResultInfo_Private_CustomChoiceResultTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666137);
			SelectionNodeFactory.NativeMethodInfoPtr_createArchetypeCustomChoiceTargetInfo_Private_ArchetypeCustomChoiceTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666138);
			SelectionNodeFactory.NativeMethodInfoPtr_createRevealInfo_Private_RevealEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666139);
			SelectionNodeFactory.NativeMethodInfoPtr_createDetailedRevealInfo_Private_RevealDetailedEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666140);
			SelectionNodeFactory.NativeMethodInfoPtr_createIntChoiceNode_Private_ISelectionRoot_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666141);
			SelectionNodeFactory.NativeMethodInfoPtr_createCompositeTargetInfoList_Private_CompositeTargetInfoListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, 100666142);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0005F6CC File Offset: 0x0005D8CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 872578, RefRangeEnd = 872581, XrefRangeStart = 872376, XrefRangeEnd = 872578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionNodeFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0005F708 File Offset: 0x0005D908
		public unsafe virtual IAccountSessionWriter SessionWriter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 872584, RefRangeEnd = 872585, XrefRangeStart = 872581, XrefRangeEnd = 872584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_New_get_IAccountSessionWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0005F754 File Offset: 0x0005D954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSessionWriter(IAccountSessionWriter sessionWriter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sessionWriter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_OverrideSessionWriter_Protected_Void_IAccountSessionWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005F798 File Offset: 0x0005D998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 872597, RefRangeEnd = 872599, XrefRangeStart = 872585, XrefRangeEnd = 872597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetSubtypeFromDictionary<T>(Dictionary<Type, T> dictionary, Type type) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dictionary);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.MethodInfoStoreGeneric_GetSubtypeFromDictionary_Private_T_Dictionary_2_Type_T_Type_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005F7F4 File Offset: 0x0005D9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872599, XrefRangeEnd = 872613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionRoot GetSelection(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_ISelectionRoot_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005F850 File Offset: 0x0005DA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872613, XrefRangeEnd = 872627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetInfoNode GetSelection(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872627, XrefRangeEnd = 872631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IActionSelection GetSelection(Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>> actions, ISelectionRoot root, ISelectionNode parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActionSelection>(intPtr3) : null;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0005F974 File Offset: 0x0005DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872631, XrefRangeEnd = 872656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MultipleTargetInformationNode GetSelection(MultipleTargetInformation info, EntityID source, ISelectionRoot root, ISelectionNode parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectionNodeFactory.NativeMethodInfoPtr_GetSelection_Public_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleTargetInformationNode>(intPtr3) : null;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0005FA08 File Offset: 0x0005DC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872656, XrefRangeEnd = 872662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceNode createCustomChoice(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoice_Private_CustomChoiceNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomChoiceNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0005FA58 File Offset: 0x0005DC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872662, XrefRangeEnd = 872668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceNode createArchetypeChoice(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createArchetypeChoice_Private_ArchetypeCustomChoiceNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x0005FAA8 File Offset: 0x0005DCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872668, XrefRangeEnd = 872674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleSelectionWithTargetsNode createMSWT(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createMSWT_Private_MultipleSelectionWithTargetsNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MultipleSelectionWithTargetsNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x0005FAF8 File Offset: 0x0005DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872674, XrefRangeEnd = 872680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsNode createSWT(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createSWT_Private_SelectionWithTargetsNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0005FB48 File Offset: 0x0005DD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872680, XrefRangeEnd = 872686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionWithTargetsAndActionsNode createSWTAA(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createSWTAA_Private_SelectionWithTargetsAndActionsNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionWithTargetsAndActionsNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0005FB98 File Offset: 0x0005DD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872686, XrefRangeEnd = 872692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulliganChoiceNode createMulliganChoice(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createMulliganChoice_Private_MulliganChoiceNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MulliganChoiceNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x0005FBE8 File Offset: 0x0005DDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872692, XrefRangeEnd = 872698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceWithTargetsNode createCustomChoiceWithTargetsNode(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceWithTargetsNode_Private_CustomChoiceWithTargetsNode_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomChoiceWithTargetsNode>(intPtr3) : null;
			}
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0005FC38 File Offset: 0x0005DE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872698, XrefRangeEnd = 872705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetNode createEntityList(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createEntityList_Private_EntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetNode>(intPtr3) : null;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0005FCD0 File Offset: 0x0005DED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872705, XrefRangeEnd = 872745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KnapsackEntityListTargetNode createKnapsackEntityList(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createKnapsackEntityList_Private_KnapsackEntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<KnapsackEntityListTargetNode>(intPtr3) : null;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0005FD68 File Offset: 0x0005DF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872745, XrefRangeEnd = 872753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTargetNode createXTarget(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createXTarget_Private_XTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XTargetNode>(intPtr3) : null;
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x0005FE00 File Offset: 0x0005E000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872753, XrefRangeEnd = 872761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceInfoNode createCustomChoiceInfo(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceInfo_Private_CustomChoiceInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomChoiceInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0005FE98 File Offset: 0x0005E098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872761, XrefRangeEnd = 872768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomChoiceResultTargetInfoNode createCustomChoiceResultInfo(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createCustomChoiceResultInfo_Private_CustomChoiceResultTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomChoiceResultTargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0005FF30 File Offset: 0x0005E130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872768, XrefRangeEnd = 872775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArchetypeCustomChoiceTargetInfoNode createArchetypeCustomChoiceTargetInfo(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createArchetypeCustomChoiceTargetInfo_Private_ArchetypeCustomChoiceTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceTargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x0005FFC8 File Offset: 0x0005E1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872775, XrefRangeEnd = 872786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealEntityListTargetInfoNode createRevealInfo(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createRevealInfo_Private_RevealEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RevealEntityListTargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x00060060 File Offset: 0x0005E260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872786, XrefRangeEnd = 872806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealDetailedEntityListTargetInfoNode createDetailedRevealInfo(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createDetailedRevealInfo_Private_RevealDetailedEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RevealDetailedEntityListTargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000600F8 File Offset: 0x0005E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872806, XrefRangeEnd = 872813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISelectionRoot createIntChoiceNode(SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createIntChoiceNode_Private_ISelectionRoot_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionRoot>(intPtr3) : null;
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00060148 File Offset: 0x0005E348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872813, XrefRangeEnd = 872820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeTargetInfoListTargetInfoNode createCompositeTargetInfoList(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NativeMethodInfoPtr_createCompositeTargetInfoList_Private_CompositeTargetInfoListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CompositeTargetInfoListTargetInfoNode>(intPtr3) : null;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000878C File Offset: 0x0000698C
		public SelectionNodeFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x000601E0 File Offset: 0x0005E3E0
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00008795 File Offset: 0x00006995
		public unsafe Dictionary<Type, Func<SelectionMessage, ISelectionRoot>> SelectionMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_SelectionMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Func<SelectionMessage, ISelectionRoot>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_SelectionMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00060210 File Offset: 0x0005E410
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x000087B4 File Offset: 0x000069B4
		public unsafe Dictionary<Type, SelectionNodeFactory.NodeFactory> InfoMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_InfoMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, SelectionNodeFactory.NodeFactory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_InfoMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00060240 File Offset: 0x0005E440
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x000087D3 File Offset: 0x000069D3
		public unsafe IAccountSessionWriter sessionWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_sessionWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionNodeFactory.NativeFieldInfoPtr_sessionWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeFieldInfoPtr_SelectionMap;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeFieldInfoPtr_InfoMap;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeFieldInfoPtr_sessionWriter;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_New_get_IAccountSessionWriter_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSessionWriter_Protected_Void_IAccountSessionWriter_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_GetSubtypeFromDictionary_Private_T_Dictionary_2_Type_T_Type_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Virtual_New_ISelectionRoot_SelectionMessage_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Virtual_New_IActionSelection_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_ISelectionRoot_ISelectionNode_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Public_Virtual_New_MultipleTargetInformationNode_MultipleTargetInformation_EntityID_ISelectionRoot_ISelectionNode_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_createCustomChoice_Private_CustomChoiceNode_SelectionMessage_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_createArchetypeChoice_Private_ArchetypeCustomChoiceNode_SelectionMessage_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_createMSWT_Private_MultipleSelectionWithTargetsNode_SelectionMessage_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_createSWT_Private_SelectionWithTargetsNode_SelectionMessage_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_createSWTAA_Private_SelectionWithTargetsAndActionsNode_SelectionMessage_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_createMulliganChoice_Private_MulliganChoiceNode_SelectionMessage_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_createCustomChoiceWithTargetsNode_Private_CustomChoiceWithTargetsNode_SelectionMessage_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_createEntityList_Private_EntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_createKnapsackEntityList_Private_KnapsackEntityListTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_createXTarget_Private_XTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_createCustomChoiceInfo_Private_CustomChoiceInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_createCustomChoiceResultInfo_Private_CustomChoiceResultTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_createArchetypeCustomChoiceTargetInfo_Private_ArchetypeCustomChoiceTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_createRevealInfo_Private_RevealEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_createDetailedRevealInfo_Private_RevealDetailedEntityListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_createIntChoiceNode_Private_ISelectionRoot_SelectionMessage_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_createCompositeTargetInfoList_Private_CompositeTargetInfoListTargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x020002DA RID: 730
		public sealed class NodeFactory : MulticastDelegate
		{
			// Token: 0x060021D5 RID: 8661 RVA: 0x00096F1C File Offset: 0x0009511C
			// Note: this type is marked as 'beforefieldinit'.
			static NodeFactory()
			{
				Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr, "NodeFactory");
				SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr, 100666143);
				SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr, 100666144);
				SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr, 100666145);
				SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TargetInfoNode_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr, 100666146);
			}

			// Token: 0x060021D6 RID: 8662 RVA: 0x00096F90 File Offset: 0x00095190
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 872360, RefRangeEnd = 872372, XrefRangeStart = 872351, XrefRangeEnd = 872360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeFactory(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionNodeFactory.NodeFactory>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021D7 RID: 8663 RVA: 0x00096FEC File Offset: 0x000951EC
			[CallerCount(0)]
			public unsafe TargetInfoNode Invoke(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_Invoke_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInfoNode>(intPtr3) : null;
			}

			// Token: 0x060021D8 RID: 8664 RVA: 0x00097084 File Offset: 0x00095284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872372, XrefRangeEnd = 872376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060021D9 RID: 8665 RVA: 0x00097140 File Offset: 0x00095340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TargetInfoNode EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionNodeFactory.NodeFactory.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TargetInfoNode_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInfoNode>(intPtr3) : null;
				}
			}

			// Token: 0x060021DA RID: 8666 RVA: 0x0000E81A File Offset: 0x0000CA1A
			public NodeFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060021DB RID: 8667 RVA: 0x0000E823 File Offset: 0x0000CA23
			public static implicit operator SelectionNodeFactory.NodeFactory(Func<TargetInformation, bool, ISelectionRoot, ISelectionNode, IEnumerable<TargetInformation>, TargetInfoNode> A_0)
			{
				return DelegateSupport.ConvertDelegate<SelectionNodeFactory.NodeFactory>(A_0);
			}

			// Token: 0x060021DC RID: 8668 RVA: 0x0000E82B File Offset: 0x0000CA2B
			public static SelectionNodeFactory.NodeFactory operator +(SelectionNodeFactory.NodeFactory A_0, SelectionNodeFactory.NodeFactory A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<SelectionNodeFactory.NodeFactory>();
			}

			// Token: 0x060021DD RID: 8669 RVA: 0x0000E839 File Offset: 0x0000CA39
			public static SelectionNodeFactory.NodeFactory operator -(SelectionNodeFactory.NodeFactory A_0, SelectionNodeFactory.NodeFactory A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<SelectionNodeFactory.NodeFactory>();
				}
				return delegate2;
			}

			// Token: 0x04001775 RID: 6005
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001776 RID: 6006
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_TargetInfoNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

			// Token: 0x04001777 RID: 6007
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_AsyncCallback_Object_0;

			// Token: 0x04001778 RID: 6008
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_TargetInfoNode_IAsyncResult_0;
		}

		// Token: 0x020002DB RID: 731
		private sealed class MethodInfoStoreGeneric_GetSubtypeFromDictionary_Private_T_Dictionary_2_Type_T_Type_0<T>
		{
			// Token: 0x04001779 RID: 6009
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SelectionNodeFactory.NativeMethodInfoPtr_GetSubtypeFromDictionary_Private_T_Dictionary_2_Type_T_Type_0, Il2CppClassPointerStore<SelectionNodeFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

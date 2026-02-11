using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x0200014F RID: 335
	public class CompositeTargetInfoListTargetInfoNode : TargetInfoNode
	{
		// Token: 0x0600133E RID: 4926 RVA: 0x000613D8 File Offset: 0x0005F5D8
		// Note: this type is marked as 'beforefieldinit'.
		static CompositeTargetInfoListTargetInfoNode()
		{
			Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "CompositeTargetInfoListTargetInfoNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr);
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "none");
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_availableSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "availableSelections");
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_previousSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "previousSelections");
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_targetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "targetInfo");
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_infoHeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "infoHeads");
			CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_cachedHints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "cachedHints");
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666197);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666198);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666199);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_parentCard_Private_get_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666200);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_selectedEmptyList_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666201);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666202);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666203);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666204);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666205);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666206);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_cacheHints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666207);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666208);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666209);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666210);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666211);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666212);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666213);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666214);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666215);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666216);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666217);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666218);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666219);
			CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__NodeToAdvanceTo_b__29_0_Private_Boolean_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, 100666221);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00061660 File Offset: 0x0005F860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873399, RefRangeEnd = 873401, XrefRangeStart = 873308, XrefRangeEnd = 873399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeTargetInfoListTargetInfoNode(ISelectionNodeFactory factory, CompositeTargetInformationListTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent, string kind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00061718 File Offset: 0x0005F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873401, XrefRangeEnd = 873404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompositeTargetInfoListTargetInfoNode(ISelectionNodeFactory factory, CompositeTargetInformationListTargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000617BC File Offset: 0x0005F9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873404, XrefRangeEnd = 873423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x00061808 File Offset: 0x0005FA08
		public unsafe EntityID parentCard
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 873431, RefRangeEnd = 873436, XrefRangeStart = 873423, XrefRangeEnd = 873431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_parentCard_Private_get_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001343 RID: 4931 RVA: 0x00061848 File Offset: 0x0005FA48
		public unsafe bool selectedEmptyList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873436, XrefRangeEnd = 873445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_selectedEmptyList_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00061884 File Offset: 0x0005FA84
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873445, XrefRangeEnd = 873448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000618CC File Offset: 0x0005FACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873448, XrefRangeEnd = 873455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00061908 File Offset: 0x0005FB08
		public unsafe override bool satisfied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873455, XrefRangeEnd = 873458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00061950 File Offset: 0x0005FB50
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TargetResponse getResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0006199C File Offset: 0x0005FB9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873500, RefRangeEnd = 873502, XrefRangeStart = 873458, XrefRangeEnd = 873500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setAvailableSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_setAvailableSelections_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000619D0 File Offset: 0x0005FBD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 873577, RefRangeEnd = 873578, XrefRangeStart = 873502, XrefRangeEnd = 873577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void cacheHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_cacheHints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00061A04 File Offset: 0x0005FC04
		public unsafe virtual IList<EntityID> AvailableSelections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00061A44 File Offset: 0x0005FC44
		public unsafe virtual IList<EntityID> PreviousSelections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00061A84 File Offset: 0x0005FC84
		public unsafe virtual IList<EntityID> ForcedSelections
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873578, XrefRangeEnd = 873582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00061AC4 File Offset: 0x0005FCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873582, XrefRangeEnd = 873596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00061B08 File Offset: 0x0005FD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873596, XrefRangeEnd = 873617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00061B4C File Offset: 0x0005FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873617, XrefRangeEnd = 873642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00061B98 File Offset: 0x0005FD98
		public unsafe virtual int MaxToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x00061BD4 File Offset: 0x0005FDD4
		public unsafe virtual int MinToSelect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00061C10 File Offset: 0x0005FE10
		[CallerCount(0)]
		public unsafe virtual ISelectionNode PeekNode(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00061C60 File Offset: 0x0005FE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873642, XrefRangeEnd = 873651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TargetStrength HintStrength(EntityID entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873651, XrefRangeEnd = 873660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<TargetStrength> HintStrengths(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TargetStrength>>(intPtr3) : null;
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00061D00 File Offset: 0x0005FF00
		[CallerCount(0)]
		public unsafe virtual Dictionary<EntityID, List<TargetStrength>> AllHintStrengths()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr3) : null;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00061D40 File Offset: 0x0005FF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873660, XrefRangeEnd = 873669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _NodeToAdvanceTo_b__29_0(ISelectionNode _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.NativeMethodInfoPtr__NodeToAdvanceTo_b__29_0_Private_Boolean_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00008905 File Offset: 0x00006B05
		public CompositeTargetInfoListTargetInfoNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00061D90 File Offset: 0x0005FF90
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x0000890E File Offset: 0x00006B0E
		public unsafe static IList<EntityID> none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00061DB8 File Offset: 0x0005FFB8
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00008920 File Offset: 0x00006B20
		public unsafe IList<EntityID> availableSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_availableSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_availableSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00061DE8 File Offset: 0x0005FFE8
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0000893F File Offset: 0x00006B3F
		public unsafe IList<EntityID> previousSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_previousSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_previousSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00061E18 File Offset: 0x00060018
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0000895E File Offset: 0x00006B5E
		public new unsafe CompositeTargetInformationListTargetInformation targetInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_targetInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeTargetInformationListTargetInformation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_targetInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00061E48 File Offset: 0x00060048
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000897D File Offset: 0x00006B7D
		public unsafe IList<TargetInformation> infoHeads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_infoHeads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<TargetInformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_infoHeads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00061E78 File Offset: 0x00060078
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x0000899C File Offset: 0x00006B9C
		public unsafe Dictionary<EntityID, List<TargetStrength>> cachedHints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_cachedHints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, List<TargetStrength>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CompositeTargetInfoListTargetInfoNode.NativeFieldInfoPtr_cachedHints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeFieldInfoPtr_availableSelections;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeFieldInfoPtr_previousSelections;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeFieldInfoPtr_targetInfo;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeFieldInfoPtr_infoHeads;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeFieldInfoPtr_cachedHints;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_String_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_CompositeTargetInformationListTargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_enter_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_get_parentCard_Private_get_EntityID_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedEmptyList_Private_get_Boolean_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_get_satisfied_Protected_Virtual_get_Boolean_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_getResponse_Protected_Virtual_TargetResponse_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_setAvailableSelections_Private_Void_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_cacheHints_Private_Void_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_get_ForcedSelections_Public_Virtual_Final_New_get_IList_1_EntityID_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_EntityID_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_get_MinToSelect_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_EntityID_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_HintStrength_Public_Virtual_Final_New_TargetStrength_EntityID_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_HintStrengths_Public_Virtual_Final_New_List_1_TargetStrength_EntityID_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_AllHintStrengths_Public_Virtual_Final_New_Dictionary_2_EntityID_List_1_TargetStrength_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr__NodeToAdvanceTo_b__29_0_Private_Boolean_ISelectionNode_0;

		// Token: 0x020002E0 RID: 736
		[ObfuscatedName("dwd.core.match.selection.CompositeTargetInfoListTargetInfoNode+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060021FE RID: 8702 RVA: 0x00097780 File Offset: 0x00095980
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr);
				CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, "<>9");
				CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, "<>9__6_0");
				CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, "<>9__6_1");
				CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, "<>9__20_0");
				CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, 100666223);
				CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_TargetInformation_TargetInformationList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, 100666224);
				CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, 100666225);
				CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr__cacheHints_b__20_0_Internal_IEnumerable_1_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr, 100666226);
			}

			// Token: 0x060021FF RID: 8703 RVA: 0x0009784C File Offset: 0x00095A4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompositeTargetInfoListTargetInfoNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x00097888 File Offset: 0x00095A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873290, XrefRangeEnd = 873293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TargetInformation __ctor_b__6_0(CompositeTargetInformationListTargetInformation.TargetInformationList _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_TargetInformation_TargetInformationList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetInformation>(intPtr3) : null;
				}
			}

			// Token: 0x06002201 RID: 8705 RVA: 0x000978D8 File Offset: 0x00095AD8
			[CallerCount(0)]
			public unsafe bool __ctor_b__6_1(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr___ctor_b__6_1_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002202 RID: 8706 RVA: 0x00097928 File Offset: 0x00095B28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873293, XrefRangeEnd = 873308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>> _cacheHints_b__20_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompositeTargetInfoListTargetInfoNode.__c.NativeMethodInfoPtr__cacheHints_b__20_0_Internal_IEnumerable_1_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>>(intPtr3) : null;
				}
			}

			// Token: 0x06002203 RID: 8707 RVA: 0x0000E906 File Offset: 0x0000CB06
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000945 RID: 2373
			// (get) Token: 0x06002204 RID: 8708 RVA: 0x00097978 File Offset: 0x00095B78
			// (set) Token: 0x06002205 RID: 8709 RVA: 0x0000E90F File Offset: 0x0000CB0F
			public unsafe static CompositeTargetInfoListTargetInfoNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompositeTargetInfoListTargetInfoNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000946 RID: 2374
			// (get) Token: 0x06002206 RID: 8710 RVA: 0x000979A0 File Offset: 0x00095BA0
			// (set) Token: 0x06002207 RID: 8711 RVA: 0x0000E921 File Offset: 0x0000CB21
			public unsafe static Func<CompositeTargetInformationListTargetInformation.TargetInformationList, TargetInformation> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CompositeTargetInformationListTargetInformation.TargetInformationList, TargetInformation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000947 RID: 2375
			// (get) Token: 0x06002208 RID: 8712 RVA: 0x000979C8 File Offset: 0x00095BC8
			// (set) Token: 0x06002209 RID: 8713 RVA: 0x0000E933 File Offset: 0x0000CB33
			public unsafe static Func<TargetInformation, bool> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000948 RID: 2376
			// (get) Token: 0x0600220A RID: 8714 RVA: 0x000979F0 File Offset: 0x00095BF0
			// (set) Token: 0x0600220B RID: 8715 RVA: 0x0000E945 File Offset: 0x0000CB45
			public unsafe static Func<TargetInformation, IEnumerable<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, IEnumerable<Dictionary<TargetStrength, Il2CppReferenceArray<EntityID>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CompositeTargetInfoListTargetInfoNode.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400178A RID: 6026
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400178B RID: 6027
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400178C RID: 6028
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x0400178D RID: 6029
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400178E RID: 6030
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400178F RID: 6031
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_TargetInformation_TargetInformationList_0;

			// Token: 0x04001790 RID: 6032
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_1_Internal_Boolean_TargetInformation_0;

			// Token: 0x04001791 RID: 6033
			private static readonly IntPtr NativeMethodInfoPtr__cacheHints_b__20_0_Internal_IEnumerable_1_Dictionary_2_TargetStrength_Il2CppReferenceArray_1_EntityID_TargetInformation_0;
		}
	}
}

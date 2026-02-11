using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection
{
	// Token: 0x0200014D RID: 333
	public class ActionsNode : SelectionNode
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x000605F4 File Offset: 0x0005E7F4
		// Note: this type is marked as 'beforefieldinit'.
		static ActionsNode()
		{
			Il2CppClassPointerStore<ActionsNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "ActionsNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr);
			ActionsNode.NativeFieldInfoPtr_selectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "selectionType");
			ActionsNode.NativeFieldInfoPtr__SelectedAbility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "<SelectedAbility>k__BackingField");
			ActionsNode.NativeFieldInfoPtr_AbilityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "AbilityMap");
			ActionsNode.NativeFieldInfoPtr__Attributes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "<Attributes>k__BackingField");
			ActionsNode.NativeMethodInfoPtr_get_SelectedAbility_Public_Virtual_Final_New_get_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666157);
			ActionsNode.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666158);
			ActionsNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666159);
			ActionsNode.NativeMethodInfoPtr_GetAction_Public_SelectableAction_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666160);
			ActionsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666161);
			ActionsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666162);
			ActionsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666163);
			ActionsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666164);
			ActionsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666165);
			ActionsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666166);
			ActionsNode.NativeMethodInfoPtr_get_AvailableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_SelectableAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666167);
			ActionsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666168);
			ActionsNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666169);
			ActionsNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666170);
			ActionsNode.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666171);
			ActionsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666172);
			ActionsNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, 100666173);
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x000607C8 File Offset: 0x0005E9C8
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00060808 File Offset: 0x0005EA08
		public unsafe virtual AbilityID SelectedAbility
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_get_SelectedAbility_Public_Virtual_Final_New_get_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x0006084C File Offset: 0x0005EA4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 873108, RefRangeEnd = 873109, XrefRangeStart = 872991, XrefRangeEnd = 873108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActionsNode(ISelectionNodeFactory factory, ISelectionRoot root, ISelectionNode parent, Dictionary<SelectableAction, Il2CppReferenceArray<TargetInformation>> actions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000608D0 File Offset: 0x0005EAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 873127, RefRangeEnd = 873129, XrefRangeStart = 873109, XrefRangeEnd = 873127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableAction GetAction(AbilityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_GetAction_Public_SelectableAction_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectableAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00060920 File Offset: 0x0005EB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873129, XrefRangeEnd = 873134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionNode NodeToAdvanceTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0006096C File Offset: 0x0005EB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873134, XrefRangeEnd = 873139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionNode PeekNode(AbilityID abilityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000609BC File Offset: 0x0005EBBC
		public unsafe override bool MayAdvance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873139, XrefRangeEnd = 873143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00060A04 File Offset: 0x0005EC04
		public unsafe override bool MayCancel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x00060A4C File Offset: 0x0005EC4C
		public unsafe override bool HasClearableState
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873143, XrefRangeEnd = 873147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00060A94 File Offset: 0x0005EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873147, XrefRangeEnd = 873148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00060AD0 File Offset: 0x0005ECD0
		public unsafe virtual IEnumerable<SelectableAction> AvailableAbilities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873148, XrefRangeEnd = 873159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_get_AvailableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_SelectableAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectableAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00060B10 File Offset: 0x0005ED10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Select(AbilityID selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00060B54 File Offset: 0x0005ED54
		public unsafe override LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 873159, XrefRangeEnd = 873163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00060BA0 File Offset: 0x0005EDA0
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00060BEC File Offset: 0x0005EDEC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 873163, RefRangeEnd = 873182, XrefRangeStart = 873163, XrefRangeEnd = 873163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00060C2C File Offset: 0x0005EE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00060C60 File Offset: 0x0005EE60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetKind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionsNode.NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0000881A File Offset: 0x00006A1A
		public ActionsNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x00060CA4 File Offset: 0x0005EEA4
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x00008823 File Offset: 0x00006A23
		public unsafe string selectionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr_selectionType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr_selectionType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x00060CCC File Offset: 0x0005EECC
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x00008842 File Offset: 0x00006A42
		public unsafe AbilityID _SelectedAbility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr__SelectedAbility_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr__SelectedAbility_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x00060CFC File Offset: 0x0005EEFC
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x00008861 File Offset: 0x00006A61
		public unsafe Dictionary<SelectableAction, TargetInfoNode> AbilityMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr_AbilityMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<SelectableAction, TargetInfoNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr_AbilityMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x00060D2C File Offset: 0x0005EF2C
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x00008880 File Offset: 0x00006A80
		public unsafe ReadOnlyAttributes _Attributes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr__Attributes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.NativeFieldInfoPtr__Attributes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeFieldInfoPtr_selectionType;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAbility_k__BackingField;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeFieldInfoPtr_AbilityMap;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeFieldInfoPtr__Attributes_k__BackingField;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAbility_Public_Virtual_Final_New_get_AbilityID_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityID_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNodeFactory_ISelectionRoot_ISelectionNode_Dictionary_2_SelectableAction_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_SelectableAction_AbilityID_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_NodeToAdvanceTo_Public_Virtual_ISelectionNode_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_PeekNode_Public_Virtual_Final_New_ISelectionNode_AbilityID_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_get_MayAdvance_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_get_HasClearableState_Public_Virtual_get_Boolean_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_ClearState_Public_Virtual_Void_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableAbilities_Public_Virtual_Final_New_get_IEnumerable_1_SelectableAction_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Virtual_Final_New_Void_AbilityID_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_Unselect_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_GetKind_Protected_Virtual_String_0;

		// Token: 0x020002DD RID: 733
		[ObfuscatedName("dwd.core.match.selection.ActionsNode+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060021E5 RID: 8677 RVA: 0x0009730C File Offset: 0x0009550C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr);
				ActionsNode.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr, "<>9");
				ActionsNode.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr, "<>9__6_0");
				ActionsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr, 100666175);
				ActionsNode.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr, 100666176);
			}

			// Token: 0x060021E6 RID: 8678 RVA: 0x00097388 File Offset: 0x00095588
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionsNode.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021E7 RID: 8679 RVA: 0x000973C4 File Offset: 0x000955C4
			[CallerCount(0)]
			public unsafe bool __ctor_b__6_0(TargetInformation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.__c.NativeMethodInfoPtr___ctor_b__6_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021E8 RID: 8680 RVA: 0x0000E872 File Offset: 0x0000CA72
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x060021E9 RID: 8681 RVA: 0x00097414 File Offset: 0x00095614
			// (set) Token: 0x060021EA RID: 8682 RVA: 0x0000E87B File Offset: 0x0000CA7B
			public unsafe static ActionsNode.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActionsNode.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionsNode.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActionsNode.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x0009743C File Offset: 0x0009563C
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x0000E88D File Offset: 0x0000CA8D
			public unsafe static Func<TargetInformation, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActionsNode.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActionsNode.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400177D RID: 6013
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400177E RID: 6014
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400177F RID: 6015
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001780 RID: 6016
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Internal_Boolean_TargetInformation_0;
		}

		// Token: 0x020002DE RID: 734
		[ObfuscatedName("dwd.core.match.selection.ActionsNode+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060021ED RID: 8685 RVA: 0x00097464 File Offset: 0x00095664
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionsNode>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr);
				ActionsNode.__c__DisplayClass7_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr, "id");
				ActionsNode.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr, 100666177);
				ActionsNode.__c__DisplayClass7_0.NativeMethodInfoPtr__GetAction_b__0_Internal_Boolean_SelectableAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr, 100666178);
			}

			// Token: 0x060021EE RID: 8686 RVA: 0x000974CC File Offset: 0x000956CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionsNode.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021EF RID: 8687 RVA: 0x00097508 File Offset: 0x00095708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 872923, XrefRangeEnd = 872991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAction_b__0(SelectableAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionsNode.__c__DisplayClass7_0.NativeMethodInfoPtr__GetAction_b__0_Internal_Boolean_SelectableAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021F0 RID: 8688 RVA: 0x0000E89F File Offset: 0x0000CA9F
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x00097558 File Offset: 0x00095758
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
			public unsafe AbilityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.__c__DisplayClass7_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionsNode.__c__DisplayClass7_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001781 RID: 6017
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001782 RID: 6018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001783 RID: 6019
			private static readonly IntPtr NativeMethodInfoPtr__GetAction_b__0_Internal_Boolean_SelectableAction_0;
		}
	}
}

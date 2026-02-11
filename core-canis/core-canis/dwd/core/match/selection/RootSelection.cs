using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetresponse;

namespace dwd.core.match.selection
{
	// Token: 0x02000145 RID: 325
	public class RootSelection : SelectionNode
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x0005C3E0 File Offset: 0x0005A5E0
		// Note: this type is marked as 'beforefieldinit'.
		static RootSelection()
		{
			Il2CppClassPointerStore<RootSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection", "RootSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RootSelection>.NativeClassPtr);
			RootSelection.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "message");
			RootSelection.NativeFieldInfoPtr_sessionWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "sessionWriter");
			RootSelection.NativeFieldInfoPtr__ResponseSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "<ResponseSent>k__BackingField");
			RootSelection.NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "<Current>k__BackingField");
			RootSelection.NativeFieldInfoPtr_OnChoiceEntered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "OnChoiceEntered");
			RootSelection.NativeFieldInfoPtr_OnSelectionSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "OnSelectionSent");
			RootSelection.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, "attributes");
			RootSelection.NativeMethodInfoPtr_get_ResponseSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665990);
			RootSelection.NativeMethodInfoPtr_set_ResponseSent_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665991);
			RootSelection.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMessage_ISelectionNodeFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665992);
			RootSelection.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665993);
			RootSelection.NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665994);
			RootSelection.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665995);
			RootSelection.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665996);
			RootSelection.NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665997);
			RootSelection.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665998);
			RootSelection.NativeMethodInfoPtr_moveToNode_Private_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100665999);
			RootSelection.NativeMethodInfoPtr_getResponses_Protected_IEnumerable_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666000);
			RootSelection.NativeMethodInfoPtr_writeResponseMessage_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666001);
			RootSelection.NativeMethodInfoPtr_getResponseMessage_Protected_Abstract_Virtual_New_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666002);
			RootSelection.NativeMethodInfoPtr_GetAccountID_Private_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666003);
			RootSelection.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666004);
			RootSelection.NativeMethodInfoPtr_set_Current_Private_set_Void_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666005);
			RootSelection.NativeMethodInfoPtr_add_OnChoiceEntered_Public_Virtual_Final_New_add_Void_Action_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666006);
			RootSelection.NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666007);
			RootSelection.NativeMethodInfoPtr_add_OnSelectionSent_Public_Virtual_Final_New_add_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666008);
			RootSelection.NativeMethodInfoPtr_remove_OnSelectionSent_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionRoot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666009);
			RootSelection.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootSelection>.NativeClassPtr, 100666010);
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x0005C640 File Offset: 0x0005A840
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x0005C67C File Offset: 0x0005A87C
		public unsafe bool ResponseSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_get_ResponseSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_set_ResponseSent_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 871410, RefRangeEnd = 871419, XrefRangeStart = 871401, XrefRangeEnd = 871410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RootSelection(SelectionMessage message, ISelectionNodeFactory factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RootSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr__ctor_Protected_Void_SelectionMessage_ISelectionNodeFactory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0005C71C File Offset: 0x0005A91C
		[CallerCount(0)]
		public unsafe override void Enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0005C75C File Offset: 0x0005A95C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void enter(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RootSelection.NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0005C7A8 File Offset: 0x0005A9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871425, RefRangeEnd = 871426, XrefRangeStart = 871419, XrefRangeEnd = 871425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x0005C7DC File Offset: 0x0005A9DC
		public unsafe override bool MayCancel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RootSelection.NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0005C824 File Offset: 0x0005AA24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871436, RefRangeEnd = 871437, XrefRangeStart = 871426, XrefRangeEnd = 871436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x0005C858 File Offset: 0x0005AA58
		public unsafe override LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RootSelection.NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
			}
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0005C8A4 File Offset: 0x0005AAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871441, RefRangeEnd = 871442, XrefRangeStart = 871437, XrefRangeEnd = 871441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void moveToNode(ISelectionNode newNode, bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_moveToNode_Private_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0005C8F4 File Offset: 0x0005AAF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 871464, RefRangeEnd = 871467, XrefRangeStart = 871442, XrefRangeEnd = 871464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<TargetResponse> getResponses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_getResponses_Protected_IEnumerable_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponse>>(intPtr3) : null;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0005C934 File Offset: 0x0005AB34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 871493, RefRangeEnd = 871494, XrefRangeStart = 871467, XrefRangeEnd = 871493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void writeResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_writeResponseMessage_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0005C974 File Offset: 0x0005AB74
		[CallerCount(0)]
		public unsafe virtual Object getResponseMessage(bool cancelled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cancelled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RootSelection.NativeMethodInfoPtr_getResponseMessage_Protected_Abstract_Virtual_New_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0005C9CC File Offset: 0x0005ABCC
		[CallerCount(0)]
		public unsafe AccountID GetAccountID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_GetAccountID_Private_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0005CA0C File Offset: 0x0005AC0C
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		public unsafe virtual ISelectionNode Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_set_Current_Private_set_Void_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0005CA90 File Offset: 0x0005AC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871494, XrefRangeEnd = 871499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnChoiceEntered(Action<ISelectionNode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_add_OnChoiceEntered_Public_Virtual_Final_New_add_Void_Action_1_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0005CAD4 File Offset: 0x0005ACD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871499, XrefRangeEnd = 871504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnChoiceEntered(Action<ISelectionNode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0005CB18 File Offset: 0x0005AD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871504, XrefRangeEnd = 871509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_OnSelectionSent(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_add_OnSelectionSent_Public_Virtual_Final_New_add_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0005CB5C File Offset: 0x0005AD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871509, XrefRangeEnd = 871514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_OnSelectionSent(Action<ISelectionRoot> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootSelection.NativeMethodInfoPtr_remove_OnSelectionSent_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionRoot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0005CBA0 File Offset: 0x0005ADA0
		public unsafe override ReadOnlyAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 871514, XrefRangeEnd = 871519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RootSelection.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00008398 File Offset: 0x00006598
		public RootSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x0005CBEC File Offset: 0x0005ADEC
		// (set) Token: 0x0600123D RID: 4669 RVA: 0x000083A1 File Offset: 0x000065A1
		public unsafe SelectionMessage message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x0005CC1C File Offset: 0x0005AE1C
		// (set) Token: 0x0600123F RID: 4671 RVA: 0x000083C0 File Offset: 0x000065C0
		public unsafe IAccountSessionWriter sessionWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_sessionWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_sessionWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0005CC4C File Offset: 0x0005AE4C
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x000083DF File Offset: 0x000065DF
		public unsafe bool _ResponseSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr__ResponseSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr__ResponseSent_k__BackingField)) = value;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0005CC74 File Offset: 0x0005AE74
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x000083FA File Offset: 0x000065FA
		public unsafe ISelectionNode _Current_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr__Current_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr__Current_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0005CCA4 File Offset: 0x0005AEA4
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00008419 File Offset: 0x00006619
		public unsafe Action<ISelectionNode> OnChoiceEntered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_OnChoiceEntered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_OnChoiceEntered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x0005CCD4 File Offset: 0x0005AED4
		// (set) Token: 0x06001247 RID: 4679 RVA: 0x00008438 File Offset: 0x00006638
		public unsafe Action<ISelectionRoot> OnSelectionSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_OnSelectionSent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ISelectionRoot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_OnSelectionSent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x0005CD04 File Offset: 0x0005AF04
		// (set) Token: 0x06001249 RID: 4681 RVA: 0x00008457 File Offset: 0x00006657
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootSelection.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeFieldInfoPtr_sessionWriter;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeFieldInfoPtr__ResponseSent_k__BackingField;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeFieldInfoPtr__Current_k__BackingField;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeFieldInfoPtr_OnChoiceEntered;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeFieldInfoPtr_OnSelectionSent;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_get_ResponseSent_Public_get_Boolean_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_set_ResponseSent_Private_set_Void_Boolean_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SelectionMessage_ISelectionNodeFactory_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Virtual_Final_Void_Boolean_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_enter_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_MayCancel_Public_Virtual_get_Boolean_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_Virtual_get_LocalizableTextVariables_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_moveToNode_Private_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_getResponses_Protected_IEnumerable_1_TargetResponse_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_writeResponseMessage_Private_Void_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_getResponseMessage_Protected_Abstract_Virtual_New_Object_Boolean_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_GetAccountID_Private_AccountID_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_ISelectionNode_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_set_Current_Private_set_Void_ISelectionNode_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr_add_OnChoiceEntered_Public_Virtual_Final_New_add_Void_Action_1_ISelectionNode_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnChoiceEntered_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionNode_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSelectionSent_Public_Virtual_Final_New_add_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSelectionSent_Public_Virtual_Final_New_rem_Void_Action_1_ISelectionRoot_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_ReadOnlyAttributes_0;
	}
}

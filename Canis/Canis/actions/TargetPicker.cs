using System;
using Canis.actions.completions;
using Canis.actions.continuations;
using Canis.actions.serialized;
using Canis.attributes;
using Canis.hasExecutionStack;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Networking.selection.messages;

namespace Canis.actions
{
	// Token: 0x0200018D RID: 397
	public class TargetPicker : Action
	{
		// Token: 0x06001150 RID: 4432 RVA: 0x0005F7F8 File Offset: 0x0005D9F8
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPicker()
		{
			Il2CppClassPointerStore<TargetPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "TargetPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr);
			TargetPicker.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "action");
			TargetPicker.NativeFieldInfoPtr_serAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "serAction");
			TargetPicker.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "selectionCounter");
			TargetPicker.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "attributes");
			TargetPicker.NativeFieldInfoPtr__Prompt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "<Prompt>k__BackingField");
			TargetPicker.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "<Kind>k__BackingField");
			TargetPicker.NativeFieldInfoPtr__ExecutingStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, "<ExecutingStack>k__BackingField");
			TargetPicker.NativeMethodInfoPtr_get_Action_Protected_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666915);
			TargetPicker.NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666916);
			TargetPicker.NativeMethodInfoPtr_GetSelectionCounter_Public_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666917);
			TargetPicker.NativeMethodInfoPtr_get_Prompt_Public_get_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666918);
			TargetPicker.NativeMethodInfoPtr_set_Prompt_Protected_set_Void_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666919);
			TargetPicker.NativeMethodInfoPtr_get_Kind_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666920);
			TargetPicker.NativeMethodInfoPtr_set_Kind_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666921);
			TargetPicker.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666922);
			TargetPicker.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666923);
			TargetPicker.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666924);
			TargetPicker.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_New_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666925);
			TargetPicker.NativeMethodInfoPtr_Has_Public_Void_AttributeDefinition_1_TAttr_TAttr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666926);
			TargetPicker.NativeMethodInfoPtr_PickTargets_Public_Abstract_Virtual_New_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666927);
			TargetPicker.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_New_ActionContinuation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666928);
			TargetPicker.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_New_SelectionCompletion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666929);
			TargetPicker.NativeMethodInfoPtr_CancelOnSlapjack_Public_Virtual_Final_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr, 100666930);
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0005F9F4 File Offset: 0x0005DBF4
		public unsafe Action Action
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 583786, RefRangeEnd = 583793, XrefRangeStart = 583785, XrefRangeEnd = 583786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_get_Action_Protected_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0005FA34 File Offset: 0x0005DC34
		public unsafe override Action CompletedAction
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker.NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005FA80 File Offset: 0x0005DC80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<int> GetSelectionCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_GetSelectionCounter_Public_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0005FAB8 File Offset: 0x0005DCB8
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0005FAF8 File Offset: 0x0005DCF8
		public unsafe LocalizableTextVariables Prompt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_get_Prompt_Public_get_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_set_Prompt_Protected_set_Void_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0005FB3C File Offset: 0x0005DD3C
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0005FB74 File Offset: 0x0005DD74
		public unsafe string Kind
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_get_Kind_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_set_Kind_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0005FBB8 File Offset: 0x0005DDB8
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0005FBF8 File Offset: 0x0005DDF8
		public unsafe virtual IHasExecutionStack ExecutingStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0005FC3C File Offset: 0x0005DE3C
		[CallerCount(605)]
		[CachedScanResults(RefRangeStart = 579585, RefRangeEnd = 580190, XrefRangeStart = 579585, XrefRangeEnd = 580190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPicker>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005FC88 File Offset: 0x0005DE88
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SelectionMessage GetSelectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker.NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_New_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0005FCD4 File Offset: 0x0005DED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 583820, RefRangeEnd = 583822, XrefRangeStart = 583793, XrefRangeEnd = 583820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Has<TAttr>(AttributeDefinition<TAttr> attribute, TAttr value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TAttr).IsValueType)
			{
				TAttr tattr = value;
				intPtr = ((tattr is string) ? IL2CPP.ManagedStringToIl2Cpp(tattr as string) : IL2CPP.Il2CppObjectBaseToPtr(tattr as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TargetPicker.MethodInfoStoreGeneric_Has_Public_Void_AttributeDefinition_1_TAttr_TAttr_0<TAttr>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0005FD60 File Offset: 0x0005DF60
		[CallerCount(0)]
		public unsafe virtual SelectionRequest PickTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker.NativeMethodInfoPtr_PickTargets_Public_Abstract_Virtual_New_SelectionRequest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionRequest>(intPtr3) : null;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0005FDAC File Offset: 0x0005DFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583822, XrefRangeEnd = 583825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ActionContinuation MakeContinuation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker.NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_New_ActionContinuation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActionContinuation>(intPtr3) : null;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005FDF8 File Offset: 0x0005DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583825, XrefRangeEnd = 583829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SelectionCompletion MakeCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker.NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_New_SelectionCompletion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionCompletion>(intPtr3) : null;
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0005FE44 File Offset: 0x0005E044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583829, XrefRangeEnd = 583834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action CancelOnSlapjack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker.NativeMethodInfoPtr_CancelOnSlapjack_Public_Virtual_Final_New_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00008AA8 File Offset: 0x00006CA8
		public TargetPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0005FE84 File Offset: 0x0005E084
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00008AB1 File Offset: 0x00006CB1
		public unsafe Action action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x0005FEB4 File Offset: 0x0005E0B4
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x00008AD0 File Offset: 0x00006CD0
		public unsafe SerializedAction serAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_serAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_serAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0005FEE4 File Offset: 0x0005E0E4
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00008AEF File Offset: 0x00006CEF
		public Nullable<int> selectionCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_selectionCounter);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_selectionCounter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0005FF14 File Offset: 0x0005E114
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x00008B1D File Offset: 0x00006D1D
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0005FF44 File Offset: 0x0005E144
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00008B3C File Offset: 0x00006D3C
		public unsafe LocalizableTextVariables _Prompt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__Prompt_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__Prompt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0005FF74 File Offset: 0x0005E174
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00008B5B File Offset: 0x00006D5B
		public unsafe string _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__Kind_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__Kind_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0005FF9C File Offset: 0x0005E19C
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00008B7A File Offset: 0x00006D7A
		public unsafe IHasExecutionStack _ExecutingStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__ExecutingStack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker.NativeFieldInfoPtr__ExecutingStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_serAction;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr__Prompt_k__BackingField;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr__ExecutingStack_k__BackingField;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Protected_get_Action_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedAction_Public_Virtual_get_Action_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionCounter_Public_Nullable_1_Int32_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_get_Prompt_Public_get_LocalizableTextVariables_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_set_Prompt_Protected_set_Void_LocalizableTextVariables_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_String_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_set_Kind_Protected_set_Void_String_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectionMessage_Public_Virtual_New_SelectionMessage_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Void_AttributeDefinition_1_TAttr_TAttr_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_PickTargets_Public_Abstract_Virtual_New_SelectionRequest_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_MakeContinuation_Protected_Virtual_New_ActionContinuation_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_MakeCompletion_Protected_Virtual_New_SelectionCompletion_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_CancelOnSlapjack_Public_Virtual_Final_New_Action_0;

		// Token: 0x020003C6 RID: 966
		private sealed class MethodInfoStoreGeneric_Has_Public_Void_AttributeDefinition_1_TAttr_TAttr_0<TAttr>
		{
			// Token: 0x0400197C RID: 6524
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetPicker.NativeMethodInfoPtr_Has_Public_Void_AttributeDefinition_1_TAttr_TAttr_0, Il2CppClassPointerStore<TargetPicker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAttr>.NativeClassPtr)) }))));
		}
	}
}

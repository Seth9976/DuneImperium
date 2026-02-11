using System;
using Canis.actions.responseparsers;
using Canis.actions.serialized;
using Canis.context;
using Canis.entities;
using Canis.hasExecutionStack;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x0200018E RID: 398
	public class TargetPicker<T> : TargetPicker
	{
		// Token: 0x06001170 RID: 4464 RVA: 0x0005FFCC File Offset: 0x0005E1CC
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPicker()
		{
			Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "TargetPicker`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr);
			TargetPicker<T>.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, "targets");
			TargetPicker<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666931);
			TargetPicker<T>.NativeMethodInfoPtr_get_responseParser_Public_Abstract_Virtual_New_get_ResponseParser_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666932);
			TargetPicker<T>.NativeMethodInfoPtr_ParseResponse_Public_IEnumerable_1_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666933);
			TargetPicker<T>.NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666934);
			TargetPicker<T>.NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_SerializedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666935);
			TargetPicker<T>.NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666936);
			TargetPicker<T>.NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666937);
			TargetPicker<T>.NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666938);
			TargetPicker<T>.NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666939);
			TargetPicker<T>.NativeMethodInfoPtr_WithKind_Public_TargetPicker_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666940);
			TargetPicker<T>.NativeMethodInfoPtr_WithSelectionCounter_Public_TargetPicker_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666941);
			TargetPicker<T>.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666942);
			TargetPicker<T>.NativeMethodInfoPtr_PendSelectionForContinuation_Private_Action_HasExecutionStack_SelectionRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666943);
			TargetPicker<T>.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666944);
			TargetPicker<T>.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, 100666945);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00060178 File Offset: 0x0005E378
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 583929, RefRangeEnd = 583947, XrefRangeStart = 583920, XrefRangeEnd = 583929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr__ctor_Protected_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x000601C4 File Offset: 0x0005E3C4
		public unsafe virtual ResponseParser<T> responseParser
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker<T>.NativeMethodInfoPtr_get_responseParser_Public_Abstract_Virtual_New_get_ResponseParser_1_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResponseParser<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00060210 File Offset: 0x0005E410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583947, XrefRangeEnd = 583976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> ParseResponse(Object response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_ParseResponse_Public_IEnumerable_1_T_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00060260 File Offset: 0x0005E460
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 544371, RefRangeEnd = 544377, XrefRangeStart = 544371, XrefRangeEnd = 544377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> PickingFor(Action act)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000602B0 File Offset: 0x0005E4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> PickingFor(SerializedAction sa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_SerializedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00060300 File Offset: 0x0005E500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 583981, RefRangeEnd = 583984, XrefRangeStart = 583976, XrefRangeEnd = 583981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithPrompt(string prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00060350 File Offset: 0x0005E550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583984, XrefRangeEnd = 583985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithTargetContext(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000603A0 File Offset: 0x0005E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583985, XrefRangeEnd = 583986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithTargetContext(Entity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000603F0 File Offset: 0x0005E5F0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 583987, RefRangeEnd = 584002, XrefRangeStart = 583986, XrefRangeEnd = 583987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithPrompt(LocalizableTextVariables prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00060440 File Offset: 0x0005E640
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 584003, RefRangeEnd = 584023, XrefRangeStart = 584002, XrefRangeEnd = 584003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithKind(string kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(kind);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithKind_Public_TargetPicker_1_T_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00060490 File Offset: 0x0005E690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584023, XrefRangeEnd = 584026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetPicker<T> WithSelectionCounter(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_WithSelectionCounter_Public_TargetPicker_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000604DC File Offset: 0x0005E6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584026, XrefRangeEnd = 584030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0006051C File Offset: 0x0005E71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584046, RefRangeEnd = 584047, XrefRangeStart = 584030, XrefRangeEnd = 584046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action PendSelectionForContinuation(HasExecutionStack hasExecutionStack, SelectionRequest selectionRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasExecutionStack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectionRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.NativeMethodInfoPtr_PendSelectionForContinuation_Private_Action_HasExecutionStack_SelectionRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00060580 File Offset: 0x0005E780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584047, XrefRangeEnd = 584051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker<T>.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x000605DC File Offset: 0x0005E7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584051, XrefRangeEnd = 584056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> undo(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TargetPicker<T>.NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00008B99 File Offset: 0x00006D99
		public TargetPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00060638 File Offset: 0x0005E838
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00008BA2 File Offset: 0x00006DA2
		public unsafe List<T> targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.NativeFieldInfoPtr_targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_targets;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_responseParser_Public_Abstract_Virtual_New_get_ResponseParser_1_T_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_IEnumerable_1_T_Object_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_Action_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_PickingFor_Public_TargetPicker_1_T_SerializedAction_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_String_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Context_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_WithTargetContext_Public_TargetPicker_1_T_Entity_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_WithPrompt_Public_TargetPicker_1_T_LocalizableTextVariables_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_WithKind_Public_TargetPicker_1_T_String_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_WithSelectionCounter_Public_TargetPicker_1_T_Int32_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_Final_IEnumerable_1_Action_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_PendSelectionForContinuation_Private_Action_HasExecutionStack_SelectionRequest_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_undo_Protected_Virtual_IEnumerable_1_Action_Context_0;

		// Token: 0x020003C7 RID: 967
		[ObfuscatedName("Canis.actions.TargetPicker`1+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x060028CF RID: 10447 RVA: 0x000B0CEC File Offset: 0x000AEEEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, "<>c__DisplayClass14_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr);
				TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_actionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, "actionContext");
				TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_hasExecutionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, "hasExecutionStack");
				TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, 100666946);
				TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__PendSelectionForContinuation_b__0_Internal_Action_AutoSelection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, 100666947);
				TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__PendSelectionForContinuation_b__1_Internal_Action_RequestSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr, 100666948);
			}

			// Token: 0x060028D0 RID: 10448 RVA: 0x000B0DCC File Offset: 0x000AEFCC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPicker<T>.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028D1 RID: 10449 RVA: 0x000B0E08 File Offset: 0x000AF008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583834, XrefRangeEnd = 583868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action _PendSelectionForContinuation_b__0(SelectionRequest.AutoSelection<T> auto)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(auto);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__PendSelectionForContinuation_b__0_Internal_Action_AutoSelection_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060028D2 RID: 10450 RVA: 0x000B0E58 File Offset: 0x000AF058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583868, XrefRangeEnd = 583880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Action _PendSelectionForContinuation_b__1(SelectionRequest.RequestSelection toSend)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(toSend);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__PendSelectionForContinuation_b__1_Internal_Action_RequestSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060028D3 RID: 10451 RVA: 0x0001385A File Offset: 0x00011A5A
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000B0EA8 File Offset: 0x000AF0A8
			// (set) Token: 0x060028D5 RID: 10453 RVA: 0x00013863 File Offset: 0x00011A63
			public unsafe TargetPicker<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x060028D6 RID: 10454 RVA: 0x000B0ED8 File Offset: 0x000AF0D8
			// (set) Token: 0x060028D7 RID: 10455 RVA: 0x00013882 File Offset: 0x00011A82
			public unsafe Context actionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_actionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_actionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000B0F08 File Offset: 0x000AF108
			// (set) Token: 0x060028D9 RID: 10457 RVA: 0x000138A1 File Offset: 0x00011AA1
			public unsafe HasExecutionStack hasExecutionStack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_hasExecutionStack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HasExecutionStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_hasExecutionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400197D RID: 6525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400197E RID: 6526
			private static readonly IntPtr NativeFieldInfoPtr_actionContext;

			// Token: 0x0400197F RID: 6527
			private static readonly IntPtr NativeFieldInfoPtr_hasExecutionStack;

			// Token: 0x04001980 RID: 6528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001981 RID: 6529
			private static readonly IntPtr NativeMethodInfoPtr__PendSelectionForContinuation_b__0_Internal_Action_AutoSelection_1_T_0;

			// Token: 0x04001982 RID: 6530
			private static readonly IntPtr NativeMethodInfoPtr__PendSelectionForContinuation_b__1_Internal_Action_RequestSelection_0;
		}

		// Token: 0x020003C8 RID: 968
		[ObfuscatedName("Canis.actions.TargetPicker`1+<execute>d__13")]
		public sealed class _execute_d__13 : Object
		{
			// Token: 0x060028DA RID: 10458 RVA: 0x000B0F38 File Offset: 0x000AF138
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__13()
			{
				Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, "<execute>d__13"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr);
				TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, "<>1__state");
				TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, "<>2__current");
				TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, "<>l__initialThreadId");
				TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, "<>4__this");
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666949);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666950);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666951);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666952);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666953);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666954);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666955);
				TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr, 100666956);
			}

			// Token: 0x060028DB RID: 10459 RVA: 0x000B1090 File Offset: 0x000AF290
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPicker<T>._execute_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028DC RID: 10460 RVA: 0x000B10D8 File Offset: 0x000AF2D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028DD RID: 10461 RVA: 0x000B110C File Offset: 0x000AF30C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583880, XrefRangeEnd = 583885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x060028DE RID: 10462 RVA: 0x000B1148 File Offset: 0x000AF348
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060028DF RID: 10463 RVA: 0x000B1188 File Offset: 0x000AF388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000B11BC File Offset: 0x000AF3BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028E1 RID: 10465 RVA: 0x000B11FC File Offset: 0x000AF3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060028E2 RID: 10466 RVA: 0x000B123C File Offset: 0x000AF43C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583885, XrefRangeEnd = 583886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._execute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028E3 RID: 10467 RVA: 0x000138C0 File Offset: 0x00011AC0
			public _execute_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000B127C File Offset: 0x000AF47C
			// (set) Token: 0x060028E5 RID: 10469 RVA: 0x000138C9 File Offset: 0x00011AC9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000B12A4 File Offset: 0x000AF4A4
			// (set) Token: 0x060028E7 RID: 10471 RVA: 0x000138E4 File Offset: 0x00011AE4
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000B12D4 File Offset: 0x000AF4D4
			// (set) Token: 0x060028E9 RID: 10473 RVA: 0x00013903 File Offset: 0x00011B03
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x060028EA RID: 10474 RVA: 0x000B12FC File Offset: 0x000AF4FC
			// (set) Token: 0x060028EB RID: 10475 RVA: 0x0001391E File Offset: 0x00011B1E
			public unsafe TargetPicker<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._execute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001983 RID: 6531
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001984 RID: 6532
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001985 RID: 6533
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001986 RID: 6534
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001987 RID: 6535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001988 RID: 6536
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001989 RID: 6537
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400198A RID: 6538
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400198B RID: 6539
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400198C RID: 6540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400198D RID: 6541
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400198E RID: 6542
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020003C9 RID: 969
		[ObfuscatedName("Canis.actions.TargetPicker`1+<undo>d__16")]
		public sealed class _undo_d__16 : Object
		{
			// Token: 0x060028EC RID: 10476 RVA: 0x000B132C File Offset: 0x000AF52C
			// Note: this type is marked as 'beforefieldinit'.
			static _undo_d__16()
			{
				Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPicker<T>>.NativeClassPtr, "<undo>d__16"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr);
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>1__state");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>2__current");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>l__initialThreadId");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>4__this");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "context");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>3__context");
				TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, "<>7__wrap1");
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666957);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666958);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666959);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666960);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666961);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666962);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666963);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666964);
				TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr, 100666965);
			}

			// Token: 0x060028ED RID: 10477 RVA: 0x000B14D4 File Offset: 0x000AF6D4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _undo_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPicker<T>._undo_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060028EE RID: 10478 RVA: 0x000B151C File Offset: 0x000AF71C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583886, XrefRangeEnd = 583889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060028EF RID: 10479 RVA: 0x000B1550 File Offset: 0x000AF750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583889, XrefRangeEnd = 583903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060028F0 RID: 10480 RVA: 0x000B158C File Offset: 0x000AF78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583903, XrefRangeEnd = 583912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x060028F1 RID: 10481 RVA: 0x000B15C0 File Offset: 0x000AF7C0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x060028F2 RID: 10482 RVA: 0x000B1600 File Offset: 0x000AF800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x060028F3 RID: 10483 RVA: 0x000B1634 File Offset: 0x000AF834
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060028F4 RID: 10484 RVA: 0x000B1674 File Offset: 0x000AF874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x060028F5 RID: 10485 RVA: 0x000B16B4 File Offset: 0x000AF8B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 583912, XrefRangeEnd = 583920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPicker<T>._undo_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060028F6 RID: 10486 RVA: 0x0001393D File Offset: 0x00011B3D
			public _undo_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x060028F7 RID: 10487 RVA: 0x000B16F4 File Offset: 0x000AF8F4
			// (set) Token: 0x060028F8 RID: 10488 RVA: 0x00013946 File Offset: 0x00011B46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000B171C File Offset: 0x000AF91C
			// (set) Token: 0x060028FA RID: 10490 RVA: 0x00013961 File Offset: 0x00011B61
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x060028FB RID: 10491 RVA: 0x000B174C File Offset: 0x000AF94C
			// (set) Token: 0x060028FC RID: 10492 RVA: 0x00013980 File Offset: 0x00011B80
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x060028FD RID: 10493 RVA: 0x000B1774 File Offset: 0x000AF974
			// (set) Token: 0x060028FE RID: 10494 RVA: 0x0001399B File Offset: 0x00011B9B
			public unsafe TargetPicker<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPicker<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x060028FF RID: 10495 RVA: 0x000B17A4 File Offset: 0x000AF9A4
			// (set) Token: 0x06002900 RID: 10496 RVA: 0x000139BA File Offset: 0x00011BBA
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06002901 RID: 10497 RVA: 0x000B17D4 File Offset: 0x000AF9D4
			// (set) Token: 0x06002902 RID: 10498 RVA: 0x000139D9 File Offset: 0x00011BD9
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x06002903 RID: 10499 RVA: 0x000B1804 File Offset: 0x000AFA04
			// (set) Token: 0x06002904 RID: 10500 RVA: 0x000139F8 File Offset: 0x00011BF8
			public List<T>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___7__wrap1);
					return new List<T>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetPicker<T>._undo_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<T>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400198F RID: 6543
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001990 RID: 6544
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001991 RID: 6545
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001992 RID: 6546
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001993 RID: 6547
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001994 RID: 6548
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001995 RID: 6549
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001996 RID: 6550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001997 RID: 6551
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001998 RID: 6552
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001999 RID: 6553
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400199A RID: 6554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400199B RID: 6555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400199C RID: 6556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400199D RID: 6557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400199E RID: 6558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

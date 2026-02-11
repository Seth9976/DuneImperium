using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D1 RID: 209
	public class EventCallbackFunctorBase : Object
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x0005E054 File Offset: 0x0005C254
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackFunctorBase()
		{
			Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackFunctorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr);
			EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, "<phase>k__BackingField");
			EventCallbackFunctorBase.NativeFieldInfoPtr__invokePolicy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, "<invokePolicy>k__BackingField");
			EventCallbackFunctorBase.NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665932);
			EventCallbackFunctorBase.NativeMethodInfoPtr_get_invokePolicy_Public_get_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665933);
			EventCallbackFunctorBase.NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665934);
			EventCallbackFunctorBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665935);
			EventCallbackFunctorBase.NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665936);
			EventCallbackFunctorBase.NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr, 100665937);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0005E124 File Offset: 0x0005C324
		public unsafe CallbackPhase phase
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0005E160 File Offset: 0x0005C360
		public unsafe InvokePolicy invokePolicy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_get_invokePolicy_Public_get_InvokePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0005E19C File Offset: 0x0005C39C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313224, RefRangeEnd = 313226, XrefRangeStart = 313223, XrefRangeEnd = 313224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackFunctorBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_InvokePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0005E1F4 File Offset: 0x0005C3F4
		[CallerCount(0)]
		public unsafe virtual void Invoke(EventBase evt, PropagationPhase propagationPhase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref propagationPhase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctorBase.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_PropagationPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0005E250 File Offset: 0x0005C450
		[CallerCount(0)]
		public unsafe virtual bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctorBase.NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0005E2C4 File Offset: 0x0005C4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313226, RefRangeEnd = 313228, XrefRangeStart = 313226, XrefRangeEnd = 313226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PhaseMatches(PropagationPhase propagationPhase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref propagationPhase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctorBase.NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00009270 File Offset: 0x00007470
		public EventCallbackFunctorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0005E310 File Offset: 0x0005C510
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00009279 File Offset: 0x00007479
		public unsafe CallbackPhase _phase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__phase_k__BackingField)) = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0005E338 File Offset: 0x0005C538
		// (set) Token: 0x0600128E RID: 4750 RVA: 0x00009294 File Offset: 0x00007494
		public unsafe InvokePolicy _invokePolicy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__invokePolicy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctorBase.NativeFieldInfoPtr__invokePolicy_k__BackingField)) = value;
			}
		}

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeFieldInfoPtr__phase_k__BackingField;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeFieldInfoPtr__invokePolicy_k__BackingField;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_get_phase_Public_get_CallbackPhase_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_get_invokePolicy_Public_get_InvokePolicy_0;

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_CallbackPhase_InvokePolicy_0;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_EventBase_PropagationPhase_0;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Abstract_Virtual_New_Boolean_Int64_Delegate_CallbackPhase_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr_PhaseMatches_Protected_Boolean_PropagationPhase_0;
	}
}

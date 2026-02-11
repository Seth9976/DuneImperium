using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D2 RID: 210
	public class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		// Token: 0x0600128F RID: 4751 RVA: 0x0005E360 File Offset: 0x0005C560
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackFunctor()
		{
			Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackFunctor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr);
			EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, "m_Callback");
			EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, "m_EventTypeId");
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100665938);
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100665939);
			EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr, 100665940);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0005E430 File Offset: 0x0005C630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313233, RefRangeEnd = 313234, XrefRangeStart = 313228, XrefRangeEnd = 313233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackFunctor<TEventType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctor<TEventType>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_InvokePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0005E498 File Offset: 0x0005C698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313234, XrefRangeEnd = 313243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(EventBase evt, PropagationPhase propagationPhase)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0005E4F4 File Offset: 0x0005C6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313243, XrefRangeEnd = 313244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000092AF File Offset: 0x000074AF
		public EventCallbackFunctor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x0005E568 File Offset: 0x0005C768
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x000092B8 File Offset: 0x000074B8
		public unsafe EventCallback<TEventType> m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<TEventType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0005E598 File Offset: 0x0005C798
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x000092D7 File Offset: 0x000074D7
		public unsafe long m_EventTypeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType>.NativeFieldInfoPtr_m_EventTypeId)) = value;
			}
		}

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeFieldInfoPtr_m_EventTypeId;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCallback_1_TEventType_CallbackPhase_InvokePolicy_0;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0;
	}
}

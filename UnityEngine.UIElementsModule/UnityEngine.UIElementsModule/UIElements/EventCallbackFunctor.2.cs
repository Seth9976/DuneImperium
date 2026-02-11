using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D3 RID: 211
	public class EventCallbackFunctor<TEventType, TCallbackArgs> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x0005E5C0 File Offset: 0x0005C7C0
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackFunctor()
		{
			Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackFunctor`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackArgs>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr);
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, "m_Callback");
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_EventTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, "m_EventTypeId");
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr__userArgs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, "<userArgs>k__BackingField");
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_get_userArgs_Internal_get_TCallbackArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, 100665941);
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_set_userArgs_Internal_set_Void_TCallbackArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, 100665942);
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_CallbackPhase_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, 100665943);
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, 100665944);
			EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr, 100665945);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0005E71C File Offset: 0x0005C91C
		public unsafe TCallbackArgs userArgs
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_get_userArgs_Internal_get_TCallbackArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TCallbackArgs>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TCallbackArgs).IsValueType)
					{
						TCallbackArgs tcallbackArgs = value;
						intPtr = ((tcallbackArgs is string) ? IL2CPP.ManagedStringToIl2Cpp(tcallbackArgs as string) : IL2CPP.Il2CppObjectBaseToPtr(tcallbackArgs as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_set_userArgs_Internal_set_Void_TCallbackArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0005E794 File Offset: 0x0005C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313244, XrefRangeEnd = 313250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackFunctor(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackFunctor<TEventType, TCallbackArgs>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TCallbackArgs).IsValueType)
			{
				TCallbackArgs tcallbackArgs = userArgs;
				intPtr = ((tcallbackArgs is string) ? IL2CPP.ManagedStringToIl2Cpp(tcallbackArgs as string) : IL2CPP.Il2CppObjectBaseToPtr(tcallbackArgs as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref userArgs;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr__ctor_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_CallbackPhase_InvokePolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0005E844 File Offset: 0x0005CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313250, XrefRangeEnd = 313259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0005E8A0 File Offset: 0x0005CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventCallbackFunctor<TEventType, TCallbackArgs>.NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000092F2 File Offset: 0x000074F2
		public EventCallbackFunctor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x0005E914 File Offset: 0x0005CB14
		// (set) Token: 0x060012A0 RID: 4768 RVA: 0x000092FB File Offset: 0x000074FB
		public unsafe EventCallback<TEventType, TCallbackArgs> m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallback<TEventType, TCallbackArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0005E944 File Offset: 0x0005CB44
		// (set) Token: 0x060012A2 RID: 4770 RVA: 0x0000931A File Offset: 0x0000751A
		public unsafe long m_EventTypeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_EventTypeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr_m_EventTypeId)) = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x0005E96C File Offset: 0x0005CB6C
		// (set) Token: 0x060012A4 RID: 4772 RVA: 0x0005E994 File Offset: 0x0005CB94
		public unsafe TCallbackArgs _userArgs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr__userArgs_k__BackingField);
				return IL2CPP.PointerToValueGeneric<TCallbackArgs>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackFunctor<TEventType, TCallbackArgs>.NativeFieldInfoPtr__userArgs_k__BackingField);
				Type typeFromHandle = typeof(TCallbackArgs);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_m_EventTypeId;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr__userArgs_k__BackingField;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_get_userArgs_Internal_get_TCallbackArgs_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_set_userArgs_Internal_set_Void_TCallbackArgs_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_CallbackPhase_InvokePolicy_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_EventBase_PropagationPhase_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_IsEquivalentTo_Public_Virtual_Boolean_Int64_Delegate_CallbackPhase_0;
	}
}

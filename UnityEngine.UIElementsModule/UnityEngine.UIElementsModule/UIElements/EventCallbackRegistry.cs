using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D9 RID: 217
	public class EventCallbackRegistry : Object
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x0005F1C8 File Offset: 0x0005D3C8
		// Note: this type is marked as 'beforefieldinit'.
		static EventCallbackRegistry()
		{
			Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventCallbackRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr);
			EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "s_ListPool");
			EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_Callbacks");
			EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_TemporaryCallbacks");
			EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, "m_IsInvoking");
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665963);
			EventCallbackRegistry.NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665964);
			EventCallbackRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665965);
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665966);
			EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665967);
			EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665968);
			EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665969);
			EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_TrickleDown_InvokePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665970);
			EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665971);
			EventCallbackRegistry.NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_PropagationPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665972);
			EventCallbackRegistry.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665973);
			EventCallbackRegistry.NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr, 100665974);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005F338 File Offset: 0x0005D538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 313365, RefRangeEnd = 313369, XrefRangeStart = 313355, XrefRangeEnd = 313365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventCallbackList GetCallbackList(EventCallbackList initializer = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x0005F37C File Offset: 0x0005D57C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313379, RefRangeEnd = 313381, XrefRangeStart = 313369, XrefRangeEnd = 313379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCallbackList(EventCallbackList toRelease)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toRelease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313382, RefRangeEnd = 313385, XrefRangeStart = 313381, XrefRangeEnd = 313382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0005F3F0 File Offset: 0x0005D5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313390, RefRangeEnd = 313391, XrefRangeStart = 313385, XrefRangeEnd = 313390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList GetCallbackListForWriting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x0005F430 File Offset: 0x0005D630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313391, RefRangeEnd = 313393, XrefRangeStart = 313391, XrefRangeEnd = 313391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventCallbackList GetCallbackListForReading()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr3) : null;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0005F470 File Offset: 0x0005D670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313415, RefRangeEnd = 313416, XrefRangeStart = 313393, XrefRangeEnd = 313415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventTypeId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313427, RefRangeEnd = 313429, XrefRangeStart = 313416, XrefRangeEnd = 313427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_InvokePolicy_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0005F53C File Offset: 0x0005D73C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313438, RefRangeEnd = 313439, XrefRangeStart = 313429, XrefRangeEnd = 313438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallback<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokePolicy;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_TrickleDown_InvokePolicy_0<TEventType, TCallbackArgs>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0005F5E4 File Offset: 0x0005D7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313444, RefRangeEnd = 313445, XrefRangeStart = 313439, XrefRangeEnd = 313444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useTrickleDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.MethodInfoStoreGeneric_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0<TEventType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0005F640 File Offset: 0x0005D840
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313462, RefRangeEnd = 313465, XrefRangeStart = 313445, XrefRangeEnd = 313462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_PropagationPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0005F690 File Offset: 0x0005D890
		[CallerCount(0)]
		public unsafe bool HasTrickleDownHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x0005F6CC File Offset: 0x0005D8CC
		[CallerCount(0)]
		public unsafe bool HasBubbleHandlers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventCallbackRegistry.NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000093CC File Offset: 0x000075CC
		public EventCallbackRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0005F708 File Offset: 0x0005D908
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x000093D5 File Offset: 0x000075D5
		public unsafe static EventCallbackListPool s_ListPool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackListPool>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventCallbackRegistry.NativeFieldInfoPtr_s_ListPool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0005F730 File Offset: 0x0005D930
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x000093E7 File Offset: 0x000075E7
		public unsafe EventCallbackList m_Callbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_Callbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0005F760 File Offset: 0x0005D960
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x00009406 File Offset: 0x00007606
		public unsafe EventCallbackList m_TemporaryCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventCallbackList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_TemporaryCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x0005F790 File Offset: 0x0005D990
		// (set) Token: 0x060012D8 RID: 4824 RVA: 0x00009425 File Offset: 0x00007625
		public unsafe int m_IsInvoking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventCallbackRegistry.NativeFieldInfoPtr_m_IsInvoking)) = value;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x0005F7B8 File Offset: 0x0005D9B8
		public bool ShouldRegisterCallback(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			bool flag = callback == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventCallbackList callbackListForReading = this.GetCallbackListForReading();
				bool flag3 = callbackListForReading != null;
				flag2 = !flag3 || !callbackListForReading.Contains(eventTypeId, callback, phase);
			}
			return flag2;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0005F7F8 File Offset: 0x0005D9F8
		public bool UnregisterCallback<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, [Optional] TrickleDown useTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			long num = EventBase<TEventType>.TypeId();
			return this.UnregisterCallback(num, callback, useTrickleDown);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x0005F81C File Offset: 0x0005DA1C
		public bool TryGetUserArgs<TEventType, TCallbackArgs>(EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown, out TCallbackArgs userArgs) where TEventType : EventBase<TEventType>, new()
		{
			userArgs = default(TCallbackArgs);
			bool flag = callback == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				EventCallbackList callbackListForReading = this.GetCallbackListForReading();
				long num = EventBase<TEventType>.TypeId();
				CallbackPhase callbackPhase = ((useTrickleDown == TrickleDown.TrickleDown) ? CallbackPhase.TrickleDownAndTarget : CallbackPhase.TargetAndBubbleUp);
				EventCallbackFunctor<TEventType, TCallbackArgs> eventCallbackFunctor = callbackListForReading.Find(num, callback, callbackPhase).TryCast<EventCallbackFunctor<TEventType, TCallbackArgs>>();
				bool flag3 = eventCallbackFunctor == null;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					userArgs = eventCallbackFunctor.userArgs;
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr_s_ListPool;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeFieldInfoPtr_m_Callbacks;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeFieldInfoPtr_m_TemporaryCallbacks;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr_m_IsInvoking;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackList_Private_Static_EventCallbackList_EventCallbackList_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCallbackList_Private_Static_Void_EventCallbackList_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackListForWriting_Private_EventCallbackList_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackListForReading_Private_EventCallbackList_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Private_Boolean_Int64_Delegate_TrickleDown_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_InvokePolicy_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_TrickleDown_InvokePolicy_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallbacks_Public_Void_EventBase_PropagationPhase_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_HasTrickleDownHandlers_Public_Boolean_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_HasBubbleHandlers_Public_Boolean_0;

		// Token: 0x020003FB RID: 1019
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_InvokePolicy_0<TEventType>
		{
			// Token: 0x0400298C RID: 10636
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_1_TEventType_TrickleDown_InvokePolicy_0, Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}

		// Token: 0x020003FC RID: 1020
		private sealed class MethodInfoStoreGeneric_RegisterCallback_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_TrickleDown_InvokePolicy_0<TEventType, TCallbackArgs>
		{
			// Token: 0x0400298D RID: 10637
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventCallbackRegistry.NativeMethodInfoPtr_RegisterCallback_Public_Void_EventCallback_2_TEventType_TCallbackArgs_TCallbackArgs_TrickleDown_InvokePolicy_0, Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCallbackArgs>.NativeClassPtr))
			}))));
		}

		// Token: 0x020003FD RID: 1021
		private sealed class MethodInfoStoreGeneric_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0<TEventType>
		{
			// Token: 0x0400298E RID: 10638
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(EventCallbackRegistry.NativeMethodInfoPtr_UnregisterCallback_Public_Boolean_EventCallback_1_TEventType_TrickleDown_0, Il2CppClassPointerStore<EventCallbackRegistry>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEventType>.NativeClassPtr)) }))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BD RID: 189
	public sealed class EventDispatcher : Object
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x00059C94 File Offset: 0x00057E94
		// Note: this type is marked as 'beforefieldinit'.
		static EventDispatcher()
		{
			Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr);
			EventDispatcher.NativeFieldInfoPtr_m_ClickDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_ClickDetector");
			EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_DispatchingStrategies");
			EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "k_EventQueuePool");
			EventDispatcher.NativeFieldInfoPtr_m_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Queue");
			EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "<pointerState>k__BackingField");
			EventDispatcher.NativeFieldInfoPtr_m_GateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_GateCount");
			EventDispatcher.NativeFieldInfoPtr_m_GateDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_GateDepth");
			EventDispatcher.NativeFieldInfoPtr_k_MaxGateDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "k_MaxGateDepth");
			EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithStackInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "k_NumberOfEventsWithStackInfo");
			EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithEventInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "k_NumberOfEventsWithEventInfo");
			EventDispatcher.NativeFieldInfoPtr_m_DispatchStackFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_DispatchStackFrame");
			EventDispatcher.NativeFieldInfoPtr_m_CurrentEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_CurrentEvent");
			EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_DispatchContexts");
			EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "s_EditorStrategies");
			EventDispatcher.NativeFieldInfoPtr_m_Immediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "m_Immediate");
			EventDispatcher.NativeFieldInfoPtr__processingEvents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "<processingEvents>k__BackingField");
			EventDispatcher.NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665751);
			EventDispatcher.NativeMethodInfoPtr_CreateForRuntime_Internal_Static_EventDispatcher_IList_1_IEventDispatchingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665752);
			EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665753);
			EventDispatcher.NativeMethodInfoPtr__ctor_Private_Void_IList_1_IEventDispatchingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665754);
			EventDispatcher.NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665755);
			EventDispatcher.NativeMethodInfoPtr_set_processingEvents_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665756);
			EventDispatcher.NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665757);
			EventDispatcher.NativeMethodInfoPtr_HandleRecursiveState_Private_Boolean_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665758);
			EventDispatcher.NativeMethodInfoPtr_CloseGate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665759);
			EventDispatcher.NativeMethodInfoPtr_OpenGate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665760);
			EventDispatcher.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665761);
			EventDispatcher.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665762);
			EventDispatcher.NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, 100665763);
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x00059F08 File Offset: 0x00058108
		public unsafe PointerDispatchState pointerState
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr3) : null;
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00059F48 File Offset: 0x00058148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311573, RefRangeEnd = 311574, XrefRangeStart = 311569, XrefRangeEnd = 311573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventDispatcher CreateForRuntime(IList<IEventDispatchingStrategy> strategies)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_CreateForRuntime_Internal_Static_EventDispatcher_IList_1_IEventDispatchingStrategy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDispatcher>(intPtr3) : null;
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00059F8C File Offset: 0x0005818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311574, XrefRangeEnd = 311579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00059FC8 File Offset: 0x000581C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311616, RefRangeEnd = 311618, XrefRangeStart = 311579, XrefRangeEnd = 311616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDispatcher(IList<IEventDispatchingStrategy> strategies)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr__ctor_Private_Void_IList_1_IEventDispatchingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0005A014 File Offset: 0x00058214
		public unsafe bool dispatchImmediately
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00008CE9 File Offset: 0x00006EE9
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0005A050 File Offset: 0x00058250
		public unsafe bool processingEvents
		{
			get
			{
				return this._processingEvents_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_set_processingEvents_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0005A090 File Offset: 0x00058290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311637, RefRangeEnd = 311638, XrefRangeStart = 311618, XrefRangeEnd = 311637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatchMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005A0F4 File Offset: 0x000582F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311638, XrefRangeEnd = 311686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleRecursiveState(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_HandleRecursiveState_Private_Boolean_EventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005A144 File Offset: 0x00058344
		[CallerCount(0)]
		public unsafe void CloseGate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_CloseGate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0005A178 File Offset: 0x00058378
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 311695, RefRangeEnd = 311706, XrefRangeStart = 311686, XrefRangeEnd = 311695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_OpenGate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0005A1AC File Offset: 0x000583AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311729, RefRangeEnd = 311730, XrefRangeStart = 311706, XrefRangeEnd = 311729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEventQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005A1E0 File Offset: 0x000583E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311796, RefRangeEnd = 311797, XrefRangeStart = 311730, XrefRangeEnd = 311796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessEvent(EventBase evt, IPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005A234 File Offset: 0x00058434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311825, RefRangeEnd = 311826, XrefRangeStart = 311797, XrefRangeEnd = 311825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref imguiEventIsInitiallyUsed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00008B49 File Offset: 0x00006D49
		public EventDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0005A298 File Offset: 0x00058498
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00008B52 File Offset: 0x00006D52
		public unsafe ClickDetector m_ClickDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_ClickDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClickDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_ClickDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0005A2C8 File Offset: 0x000584C8
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00008B71 File Offset: 0x00006D71
		public unsafe List<IEventDispatchingStrategy> m_DispatchingStrategies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IEventDispatchingStrategy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchingStrategies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0005A2F8 File Offset: 0x000584F8
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00008B90 File Offset: 0x00006D90
		public unsafe static ObjectPool<Queue<EventDispatcher.EventRecord>> k_EventQueuePool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<Queue<EventDispatcher.EventRecord>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_k_EventQueuePool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x0005A320 File Offset: 0x00058520
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00008BA2 File Offset: 0x00006DA2
		public unsafe Queue<EventDispatcher.EventRecord> m_Queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<EventDispatcher.EventRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0005A350 File Offset: 0x00058550
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00008BC1 File Offset: 0x00006DC1
		public unsafe PointerDispatchState _pointerState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerDispatchState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__pointerState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0005A380 File Offset: 0x00058580
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x00008BE0 File Offset: 0x00006DE0
		public unsafe uint m_GateCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateCount)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0005A3A8 File Offset: 0x000585A8
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x00008BFB File Offset: 0x00006DFB
		public unsafe uint m_GateDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_GateDepth)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0005A3D0 File Offset: 0x000585D0
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00008C16 File Offset: 0x00006E16
		public unsafe static int k_MaxGateDepth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_k_MaxGateDepth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_k_MaxGateDepth, (void*)(&value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0005A3EC File Offset: 0x000585EC
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x00008C24 File Offset: 0x00006E24
		public unsafe static int k_NumberOfEventsWithStackInfo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithStackInfo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithStackInfo, (void*)(&value));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0005A408 File Offset: 0x00058608
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00008C32 File Offset: 0x00006E32
		public unsafe static int k_NumberOfEventsWithEventInfo
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithEventInfo, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_k_NumberOfEventsWithEventInfo, (void*)(&value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0005A424 File Offset: 0x00058624
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00008C40 File Offset: 0x00006E40
		public unsafe int m_DispatchStackFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchStackFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchStackFrame)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0005A44C File Offset: 0x0005864C
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x00008C5B File Offset: 0x00006E5B
		public unsafe EventBase m_CurrentEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_CurrentEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_CurrentEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0005A47C File Offset: 0x0005867C
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x00008C7A File Offset: 0x00006E7A
		public unsafe Stack<EventDispatcher.DispatchContext> m_DispatchContexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<EventDispatcher.DispatchContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_DispatchContexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0005A4AC File Offset: 0x000586AC
		// (set) Token: 0x06001185 RID: 4485 RVA: 0x00008C99 File Offset: 0x00006E99
		public unsafe static Il2CppReferenceArray<IEventDispatchingStrategy> s_EditorStrategies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IEventDispatchingStrategy>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDispatcher.NativeFieldInfoPtr_s_EditorStrategies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0005A4D4 File Offset: 0x000586D4
		// (set) Token: 0x06001187 RID: 4487 RVA: 0x00008CAB File Offset: 0x00006EAB
		public unsafe bool m_Immediate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Immediate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr_m_Immediate)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0005A4FC File Offset: 0x000586FC
		// (set) Token: 0x06001189 RID: 4489 RVA: 0x00008CC6 File Offset: 0x00006EC6
		public unsafe bool _processingEvents_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__processingEvents_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.NativeFieldInfoPtr__processingEvents_k__BackingField)) = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00008CE1 File Offset: 0x00006EE1
		public uint GateDepth
		{
			get
			{
				return this.m_GateDepth;
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0005A524 File Offset: 0x00058724
		public static EventDispatcher CreateDefault()
		{
			return new EventDispatcher(EventDispatcher.s_EditorStrategies);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0005A540 File Offset: 0x00058740
		public void PushDispatcherContext()
		{
			this.ProcessEventQueue();
			Stack<EventDispatcher.DispatchContext> dispatchContexts = this.m_DispatchContexts;
			EventDispatcher.DispatchContext dispatchContext = null;
			dispatchContext.m_GateCount = this.m_GateCount;
			dispatchContext.m_Queue = this.m_Queue;
			dispatchContexts.Push(dispatchContext);
			this.m_GateCount = 0U;
			this.m_Queue = EventDispatcher.k_EventQueuePool.Get();
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0005A59C File Offset: 0x0005879C
		public void PopDispatcherContext()
		{
			Debug.Assert(this.m_GateCount == 0U, "All gates should have been opened before popping dispatch context.");
			Debug.Assert(this.m_Queue.Count == 0, "Queue should be empty when popping dispatch context.");
			EventDispatcher.k_EventQueuePool.Release(this.m_Queue);
			this.m_GateCount = this.m_DispatchContexts.Peek().m_GateCount;
			this.m_Queue = this.m_DispatchContexts.Peek().m_Queue;
			this.m_DispatchContexts.Pop();
		}

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_m_ClickDetector;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchingStrategies;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_k_EventQueuePool;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeFieldInfoPtr_m_Queue;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeFieldInfoPtr__pointerState_k__BackingField;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeFieldInfoPtr_m_GateCount;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeFieldInfoPtr_m_GateDepth;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxGateDepth;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeFieldInfoPtr_k_NumberOfEventsWithStackInfo;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeFieldInfoPtr_k_NumberOfEventsWithEventInfo;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchStackFrame;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentEvent;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeFieldInfoPtr_m_DispatchContexts;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeFieldInfoPtr_s_EditorStrategies;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeFieldInfoPtr_m_Immediate;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeFieldInfoPtr__processingEvents_k__BackingField;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_get_pointerState_Internal_get_PointerDispatchState_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_CreateForRuntime_Internal_Static_EventDispatcher_IList_1_IEventDispatchingStrategy_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_IList_1_IEventDispatchingStrategy_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_get_dispatchImmediately_Private_get_Boolean_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_set_processingEvents_Private_set_Void_Boolean_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Internal_Void_EventBase_IPanel_DispatchMode_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_HandleRecursiveState_Private_Boolean_EventBase_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_CloseGate_Internal_Void_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_OpenGate_Internal_Void_0;

		// Token: 0x04000C09 RID: 3081
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEventQueue_Private_Void_0;

		// Token: 0x04000C0A RID: 3082
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Private_Void_EventBase_IPanel_0;

		// Token: 0x04000C0B RID: 3083
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDispatchingStrategies_Private_Void_EventBase_IPanel_Boolean_0;

		// Token: 0x020003E7 RID: 999
		public sealed class EventRecord : ValueType
		{
			// Token: 0x06003A79 RID: 14969 RVA: 0x000ECCA0 File Offset: 0x000EAEA0
			// Note: this type is marked as 'beforefieldinit'.
			static EventRecord()
			{
				Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "EventRecord");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr);
				EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr, "m_Event");
				EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr, "m_Panel");
			}

			// Token: 0x06003A7A RID: 14970 RVA: 0x00018B0E File Offset: 0x00016D0E
			public EventRecord(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003A7B RID: 14971 RVA: 0x00018B17 File Offset: 0x00016D17
			public EventRecord()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher.EventRecord>.NativeClassPtr))
			{
			}

			// Token: 0x170011EF RID: 4591
			// (get) Token: 0x06003A7C RID: 14972 RVA: 0x000ECCF4 File Offset: 0x000EAEF4
			// (set) Token: 0x06003A7D RID: 14973 RVA: 0x00018B29 File Offset: 0x00016D29
			public unsafe EventBase m_Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x06003A7E RID: 14974 RVA: 0x000ECD24 File Offset: 0x000EAF24
			// (set) Token: 0x06003A7F RID: 14975 RVA: 0x00018B48 File Offset: 0x00016D48
			public unsafe IPanel m_Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.EventRecord.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002959 RID: 10585
			private static readonly IntPtr NativeFieldInfoPtr_m_Event;

			// Token: 0x0400295A RID: 10586
			private static readonly IntPtr NativeFieldInfoPtr_m_Panel;
		}

		// Token: 0x020003E8 RID: 1000
		public sealed class DispatchContext : ValueType
		{
			// Token: 0x06003A80 RID: 14976 RVA: 0x000ECD54 File Offset: 0x000EAF54
			// Note: this type is marked as 'beforefieldinit'.
			static DispatchContext()
			{
				Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "DispatchContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr);
				EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr, "m_GateCount");
				EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr, "m_Queue");
			}

			// Token: 0x06003A81 RID: 14977 RVA: 0x00018B67 File Offset: 0x00016D67
			public DispatchContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003A82 RID: 14978 RVA: 0x00018B70 File Offset: 0x00016D70
			public DispatchContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher.DispatchContext>.NativeClassPtr))
			{
			}

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x06003A83 RID: 14979 RVA: 0x000ECDA8 File Offset: 0x000EAFA8
			// (set) Token: 0x06003A84 RID: 14980 RVA: 0x00018B82 File Offset: 0x00016D82
			public unsafe uint m_GateCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_GateCount)) = value;
				}
			}

			// Token: 0x170011F2 RID: 4594
			// (get) Token: 0x06003A85 RID: 14981 RVA: 0x000ECDD0 File Offset: 0x000EAFD0
			// (set) Token: 0x06003A86 RID: 14982 RVA: 0x00018B9D File Offset: 0x00016D9D
			public unsafe Queue<EventDispatcher.EventRecord> m_Queue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<EventDispatcher.EventRecord>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDispatcher.DispatchContext.NativeFieldInfoPtr_m_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400295B RID: 10587
			private static readonly IntPtr NativeFieldInfoPtr_m_GateCount;

			// Token: 0x0400295C RID: 10588
			private static readonly IntPtr NativeFieldInfoPtr_m_Queue;
		}

		// Token: 0x020003E9 RID: 1001
		[ObfuscatedName("UnityEngine.UIElements.EventDispatcher+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003A87 RID: 14983 RVA: 0x000ECE00 File Offset: 0x000EB000
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDispatcher>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr);
				EventDispatcher.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr, "<>9");
				EventDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr, 100665766);
				EventDispatcher.__c.NativeMethodInfoPtr___cctor_b__40_0_Internal_Queue_1_EventRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr, 100665767);
			}

			// Token: 0x06003A88 RID: 14984 RVA: 0x000ECE68 File Offset: 0x000EB068
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDispatcher.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003A89 RID: 14985 RVA: 0x000ECEA4 File Offset: 0x000EB0A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311563, XrefRangeEnd = 311569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Queue<EventDispatcher.EventRecord> __cctor_b__40_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDispatcher.__c.NativeMethodInfoPtr___cctor_b__40_0_Internal_Queue_1_EventRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Queue<EventDispatcher.EventRecord>>(intPtr3) : null;
			}

			// Token: 0x06003A8A RID: 14986 RVA: 0x00018BBC File Offset: 0x00016DBC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011F3 RID: 4595
			// (get) Token: 0x06003A8B RID: 14987 RVA: 0x000ECEE4 File Offset: 0x000EB0E4
			// (set) Token: 0x06003A8C RID: 14988 RVA: 0x00018BC5 File Offset: 0x00016DC5
			public unsafe static EventDispatcher.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventDispatcher.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDispatcher.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventDispatcher.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400295D RID: 10589
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400295E RID: 10590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400295F RID: 10591
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__40_0_Internal_Queue_1_EventRecord_0;
		}

		// Token: 0x020003EA RID: 1002
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

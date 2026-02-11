using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D4 RID: 468
	public static class TimerThread : Object
	{
		// Token: 0x06001CC8 RID: 7368 RVA: 0x0008C484 File Offset: 0x0008A684
		// Note: this type is marked as 'beforefieldinit'.
		static TimerThread()
		{
			Il2CppClassPointerStore<TimerThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "TimerThread");
			TimerThread.NativeFieldInfoPtr_s_Queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_Queues");
			TimerThread.NativeFieldInfoPtr_s_NewQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_NewQueues");
			TimerThread.NativeFieldInfoPtr_s_ThreadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadState");
			TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadReadyEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadShutdownEvent");
			TimerThread.NativeFieldInfoPtr_s_ThreadEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_ThreadEvents");
			TimerThread.NativeFieldInfoPtr_s_CacheScanIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_CacheScanIteration");
			TimerThread.NativeFieldInfoPtr_s_QueuesCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "s_QueuesCache");
			TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667701);
			TimerThread.NativeMethodInfoPtr_GetOrCreateQueue_Internal_Static_Queue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667702);
			TimerThread.NativeMethodInfoPtr_Prod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667703);
			TimerThread.NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667704);
			TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667705);
			TimerThread.NativeMethodInfoPtr_IsTickBetween_Private_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667706);
			TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, 100667707);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476410, XrefRangeEnd = 476433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationMilliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr3) : null;
			}
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0008C618 File Offset: 0x0008A818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476518, RefRangeEnd = 476520, XrefRangeStart = 476433, XrefRangeEnd = 476518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref durationMilliseconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_GetOrCreateQueue_Internal_Static_Queue_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Queue>(intPtr3) : null;
			}
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x0008C658 File Offset: 0x0008A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476520, XrefRangeEnd = 476538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Prod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_Prod_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x0008C680 File Offset: 0x0008A880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476538, XrefRangeEnd = 476636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThreadProc()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x0008C6A8 File Offset: 0x0008A8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476636, XrefRangeEnd = 476644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopTimerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x0008C6D0 File Offset: 0x0008A8D0
		[CallerCount(0)]
		public unsafe static bool IsTickBetween(int start, int end, int comparand)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparand;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_IsTickBetween_Private_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x0008C72C File Offset: 0x0008A92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476644, XrefRangeEnd = 476655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnDomainUnload(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0000C3E3 File Offset: 0x0000A5E3
		public TimerThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x0008C774 File Offset: 0x0008A974
		// (set) Token: 0x06001CD2 RID: 7378 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		public unsafe static LinkedList<WeakReference> s_Queues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_Queues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_Queues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x0008C79C File Offset: 0x0008A99C
		// (set) Token: 0x06001CD4 RID: 7380 RVA: 0x0000C3FE File Offset: 0x0000A5FE
		public unsafe static LinkedList<WeakReference> s_NewQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_NewQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x0008C7C4 File Offset: 0x0008A9C4
		// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x0000C410 File Offset: 0x0000A610
		public unsafe static int s_ThreadState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadState, (void*)(&value));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x0000C41E File Offset: 0x0000A61E
		public unsafe static AutoResetEvent s_ThreadReadyEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadReadyEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0008C808 File Offset: 0x0008AA08
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x0000C430 File Offset: 0x0000A630
		public unsafe static ManualResetEvent s_ThreadShutdownEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadShutdownEvent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0008C830 File Offset: 0x0008AA30
		// (set) Token: 0x06001CDC RID: 7388 RVA: 0x0000C442 File Offset: 0x0000A642
		public unsafe static Il2CppReferenceArray<WaitHandle> s_ThreadEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WaitHandle>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_ThreadEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0008C858 File Offset: 0x0008AA58
		// (set) Token: 0x06001CDE RID: 7390 RVA: 0x0000C454 File Offset: 0x0000A654
		public unsafe static int s_CacheScanIteration
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_CacheScanIteration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_CacheScanIteration, (void*)(&value));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0008C874 File Offset: 0x0008AA74
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0000C462 File Offset: 0x0000A662
		public unsafe static Hashtable s_QueuesCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimerThread.NativeFieldInfoPtr_s_QueuesCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_s_Queues;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_s_NewQueues;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadState;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadReadyEvent;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadShutdownEvent;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_s_ThreadEvents;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_s_CacheScanIteration;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_s_QueuesCache;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_CreateQueue_Internal_Static_Queue_Int32_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateQueue_Internal_Static_Queue_Int32_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_Prod_Private_Static_Void_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_StopTimerThread_Private_Static_Void_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_IsTickBetween_Private_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_OnDomainUnload_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x02000324 RID: 804
		public class Queue : Object
		{
			// Token: 0x06002EEA RID: 12010 RVA: 0x000CD03C File Offset: 0x000CB23C
			// Note: this type is marked as 'beforefieldinit'.
			static Queue()
			{
				Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Queue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr);
				TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, 100667708);
				TimerThread.Queue.NativeMethodInfoPtr_get_Duration_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, 100667709);
				TimerThread.Queue.NativeMethodInfoPtr_CreateTimer_Internal_Abstract_Virtual_New_Timer_Callback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr, 100667710);
			}

			// Token: 0x06002EEB RID: 12011 RVA: 0x000CD0B8 File Offset: 0x000CB2B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Queue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Queue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Queue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x06002EEC RID: 12012 RVA: 0x000CD100 File Offset: 0x000CB300
			public unsafe int Duration
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Queue.NativeMethodInfoPtr_get_Duration_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002EED RID: 12013 RVA: 0x000CD13C File Offset: 0x000CB33C
			[CallerCount(0)]
			public unsafe virtual TimerThread.Timer CreateTimer(TimerThread.Callback callback, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.Queue.NativeMethodInfoPtr_CreateTimer_Internal_Abstract_Virtual_New_Timer_Callback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Timer>(intPtr3) : null;
			}

			// Token: 0x06002EEE RID: 12014 RVA: 0x00015023 File Offset: 0x00013223
			public Queue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EAC RID: 3756
			// (get) Token: 0x06002EEF RID: 12015 RVA: 0x000CD1AC File Offset: 0x000CB3AC
			// (set) Token: 0x06002EF0 RID: 12016 RVA: 0x0001502C File Offset: 0x0001322C
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Queue.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x040024D6 RID: 9430
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x040024D7 RID: 9431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040024D8 RID: 9432
			private static readonly IntPtr NativeMethodInfoPtr_get_Duration_Internal_get_Int32_0;

			// Token: 0x040024D9 RID: 9433
			private static readonly IntPtr NativeMethodInfoPtr_CreateTimer_Internal_Abstract_Virtual_New_Timer_Callback_Object_0;
		}

		// Token: 0x02000325 RID: 805
		public class Timer : Object
		{
			// Token: 0x06002EF1 RID: 12017 RVA: 0x000CD1D4 File Offset: 0x000CB3D4
			// Note: this type is marked as 'beforefieldinit'.
			static Timer()
			{
				Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Timer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr);
				TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_StartTimeMilliseconds");
				TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, "m_DurationMilliseconds");
				TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667711);
				TimerThread.Timer.NativeMethodInfoPtr_get_StartTime_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667712);
				TimerThread.Timer.NativeMethodInfoPtr_get_Expiration_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667713);
				TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667714);
				TimerThread.Timer.NativeMethodInfoPtr_get_HasExpired_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667715);
				TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr, 100667716);
			}

			// Token: 0x06002EF2 RID: 12018 RVA: 0x000CD2A0 File Offset: 0x000CB4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476295, XrefRangeEnd = 476297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Timer(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Timer>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x000CD2E8 File Offset: 0x000CB4E8
			public unsafe int StartTime
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr_get_StartTime_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x000CD324 File Offset: 0x000CB524
			public unsafe int Expiration
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr_get_Expiration_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002EF5 RID: 12021 RVA: 0x000CD360 File Offset: 0x000CB560
			[CallerCount(0)]
			public unsafe virtual bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.Timer.NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000EB2 RID: 3762
			// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x000CD3A8 File Offset: 0x000CB5A8
			public unsafe virtual bool HasExpired
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.Timer.NativeMethodInfoPtr_get_HasExpired_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002EF7 RID: 12023 RVA: 0x000CD3F0 File Offset: 0x000CB5F0
			[CallerCount(0)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EF8 RID: 12024 RVA: 0x00015047 File Offset: 0x00013247
			public Timer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x000CD424 File Offset: 0x000CB624
			// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00015050 File Offset: 0x00013250
			public unsafe int m_StartTimeMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_StartTimeMilliseconds)) = value;
				}
			}

			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x06002EFB RID: 12027 RVA: 0x000CD44C File Offset: 0x000CB64C
			// (set) Token: 0x06002EFC RID: 12028 RVA: 0x0001506B File Offset: 0x0001326B
			public unsafe int m_DurationMilliseconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.Timer.NativeFieldInfoPtr_m_DurationMilliseconds)) = value;
				}
			}

			// Token: 0x040024DA RID: 9434
			private static readonly IntPtr NativeFieldInfoPtr_m_StartTimeMilliseconds;

			// Token: 0x040024DB RID: 9435
			private static readonly IntPtr NativeFieldInfoPtr_m_DurationMilliseconds;

			// Token: 0x040024DC RID: 9436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040024DD RID: 9437
			private static readonly IntPtr NativeMethodInfoPtr_get_StartTime_Internal_get_Int32_0;

			// Token: 0x040024DE RID: 9438
			private static readonly IntPtr NativeMethodInfoPtr_get_Expiration_Internal_get_Int32_0;

			// Token: 0x040024DF RID: 9439
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Abstract_Virtual_New_Boolean_0;

			// Token: 0x040024E0 RID: 9440
			private static readonly IntPtr NativeMethodInfoPtr_get_HasExpired_Internal_Abstract_Virtual_New_get_Boolean_0;

			// Token: 0x040024E1 RID: 9441
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000326 RID: 806
		public sealed class Callback : MulticastDelegate
		{
			// Token: 0x06002EFD RID: 12029 RVA: 0x00015086 File Offset: 0x00013286
			// Note: this type is marked as 'beforefieldinit'.
			static Callback()
			{
				Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "Callback");
				TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100667717);
				TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr, 100667718);
			}

			// Token: 0x06002EFE RID: 12030 RVA: 0x000CD474 File Offset: 0x000CB674
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 476306, RefRangeEnd = 476308, XrefRangeStart = 476297, XrefRangeEnd = 476306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Callback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.Callback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EFF RID: 12031 RVA: 0x000CD4D0 File Offset: 0x000CB6D0
			[CallerCount(0)]
			public unsafe void Invoke(TimerThread.Timer timer, int timeNoticed, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeNoticed;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.Callback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F00 RID: 12032 RVA: 0x000150C4 File Offset: 0x000132C4
			public Callback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002F01 RID: 12033 RVA: 0x000150CD File Offset: 0x000132CD
			public static implicit operator TimerThread.Callback(Action<TimerThread.Timer, int, Object> A_0)
			{
				return DelegateSupport.ConvertDelegate<TimerThread.Callback>(A_0);
			}

			// Token: 0x06002F02 RID: 12034 RVA: 0x000150D5 File Offset: 0x000132D5
			public static TimerThread.Callback operator +(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TimerThread.Callback>();
			}

			// Token: 0x06002F03 RID: 12035 RVA: 0x000150E3 File Offset: 0x000132E3
			public static TimerThread.Callback operator -(TimerThread.Callback A_0, TimerThread.Callback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<TimerThread.Callback>();
				}
				return delegate2;
			}

			// Token: 0x040024E2 RID: 9442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040024E3 RID: 9443
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Timer_Int32_Object_0;
		}

		// Token: 0x02000327 RID: 807
		public class TimerQueue : TimerThread.Queue
		{
			// Token: 0x06002F04 RID: 12036 RVA: 0x000CD534 File Offset: 0x000CB734
			// Note: this type is marked as 'beforefieldinit'.
			static TimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr);
				TimerThread.TimerQueue.NativeFieldInfoPtr_m_ThisHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, "m_ThisHandle");
				TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, "m_Timers");
				TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, 100667719);
				TimerThread.TimerQueue.NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, 100667720);
				TimerThread.TimerQueue.NativeMethodInfoPtr_Fire_Internal_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr, 100667721);
			}

			// Token: 0x06002F05 RID: 12037 RVA: 0x000CD5C4 File Offset: 0x000CB7C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 476318, RefRangeEnd = 476320, XrefRangeStart = 476308, XrefRangeEnd = 476318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerQueue(int durationMilliseconds)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerQueue>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref durationMilliseconds;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002F06 RID: 12038 RVA: 0x000CD60C File Offset: 0x000CB80C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476320, XrefRangeEnd = 476359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TimerThread.Timer CreateTimer(TimerThread.Callback callback, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.TimerQueue.NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Timer>(intPtr3) : null;
			}

			// Token: 0x06002F07 RID: 12039 RVA: 0x000CD67C File Offset: 0x000CB87C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 476366, RefRangeEnd = 476367, XrefRangeStart = 476359, XrefRangeEnd = 476366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fire(out int nextExpiration)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &nextExpiration;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerQueue.NativeMethodInfoPtr_Fire_Internal_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F08 RID: 12040 RVA: 0x000150F4 File Offset: 0x000132F4
			public TimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EB3 RID: 3763
			// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000CD6C8 File Offset: 0x000CB8C8
			// (set) Token: 0x06002F0A RID: 12042 RVA: 0x000150FD File Offset: 0x000132FD
			public unsafe IntPtr m_ThisHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_ThisHandle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_ThisHandle)) = value;
				}
			}

			// Token: 0x17000EB4 RID: 3764
			// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000CD6F0 File Offset: 0x000CB8F0
			// (set) Token: 0x06002F0C RID: 12044 RVA: 0x00015118 File Offset: 0x00013318
			public unsafe TimerThread.TimerNode m_Timers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerQueue.NativeFieldInfoPtr_m_Timers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024E4 RID: 9444
			private static readonly IntPtr NativeFieldInfoPtr_m_ThisHandle;

			// Token: 0x040024E5 RID: 9445
			private static readonly IntPtr NativeFieldInfoPtr_m_Timers;

			// Token: 0x040024E6 RID: 9446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040024E7 RID: 9447
			private static readonly IntPtr NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0;

			// Token: 0x040024E8 RID: 9448
			private static readonly IntPtr NativeMethodInfoPtr_Fire_Internal_Boolean_byref_Int32_0;
		}

		// Token: 0x02000328 RID: 808
		public class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x06002F0D RID: 12045 RVA: 0x000CD720 File Offset: 0x000CB920
			// Note: this type is marked as 'beforefieldinit'.
			static InfiniteTimerQueue()
			{
				Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "InfiniteTimerQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr);
				TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr, 100667722);
				TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr, 100667723);
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x000CD774 File Offset: 0x000CB974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476367, XrefRangeEnd = 476368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InfiniteTimerQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.InfiniteTimerQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F0F RID: 12047 RVA: 0x000CD7B0 File Offset: 0x000CB9B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476368, XrefRangeEnd = 476373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override TimerThread.Timer CreateTimer(TimerThread.Callback callback, Object context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.InfiniteTimerQueue.NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.Timer>(intPtr3) : null;
			}

			// Token: 0x06002F10 RID: 12048 RVA: 0x00015137 File Offset: 0x00013337
			public InfiniteTimerQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040024E9 RID: 9449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040024EA RID: 9450
			private static readonly IntPtr NativeMethodInfoPtr_CreateTimer_Internal_Virtual_Timer_Callback_Object_0;
		}

		// Token: 0x02000329 RID: 809
		public class TimerNode : TimerThread.Timer
		{
			// Token: 0x06002F11 RID: 12049 RVA: 0x000CD820 File Offset: 0x000CBA20
			// Note: this type is marked as 'beforefieldinit'.
			static TimerNode()
			{
				Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "TimerNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr);
				TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_TimerState");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Callback");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_Context");
				TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "m_QueueLock");
				TimerThread.TimerNode.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "next");
				TimerThread.TimerNode.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, "prev");
				TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_Callback_Object_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667724);
				TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667725);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667726);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667727);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667728);
				TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667729);
				TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667730);
				TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667731);
				TimerThread.TimerNode.NativeMethodInfoPtr_Fire_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr, 100667732);
			}

			// Token: 0x06002F12 RID: 12050 RVA: 0x000CD978 File Offset: 0x000CBB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476373, XrefRangeEnd = 476378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerNode(TimerThread.Callback callback, Object context, int durationMilliseconds, Object queueLock)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref durationMilliseconds;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(queueLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_Callback_Object_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002F13 RID: 12051 RVA: 0x000CD9F8 File Offset: 0x000CBBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476378, XrefRangeEnd = 476380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.TimerNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EBB RID: 3771
			// (get) Token: 0x06002F14 RID: 12052 RVA: 0x000CDA34 File Offset: 0x000CBC34
			public unsafe override bool HasExpired
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.TimerNode.NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000EBC RID: 3772
			// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000CDA7C File Offset: 0x000CBC7C
			// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000CDABC File Offset: 0x000CBCBC
			public unsafe TimerThread.TimerNode Next
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000EBD RID: 3773
			// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000CDB00 File Offset: 0x000CBD00
			// (set) Token: 0x06002F18 RID: 12056 RVA: 0x000CDB40 File Offset: 0x000CBD40
			public unsafe TimerThread.TimerNode Prev
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06002F19 RID: 12057 RVA: 0x000CDB84 File Offset: 0x000CBD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476380, XrefRangeEnd = 476390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.TimerNode.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F1A RID: 12058 RVA: 0x000CDBCC File Offset: 0x000CBDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476390, XrefRangeEnd = 476407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Fire()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.TimerNode.NativeMethodInfoPtr_Fire_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F1B RID: 12059 RVA: 0x00015140 File Offset: 0x00013340
			public TimerNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EB5 RID: 3765
			// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000CDC08 File Offset: 0x000CBE08
			// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00015149 File Offset: 0x00013349
			public unsafe TimerThread.TimerNode.TimerState m_TimerState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_TimerState)) = value;
				}
			}

			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000CDC30 File Offset: 0x000CBE30
			// (set) Token: 0x06002F1F RID: 12063 RVA: 0x00015164 File Offset: 0x00013364
			public unsafe TimerThread.Callback m_Callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.Callback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000CDC60 File Offset: 0x000CBE60
			// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00015183 File Offset: 0x00013383
			public unsafe Object m_Context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB8 RID: 3768
			// (get) Token: 0x06002F22 RID: 12066 RVA: 0x000CDC90 File Offset: 0x000CBE90
			// (set) Token: 0x06002F23 RID: 12067 RVA: 0x000151A2 File Offset: 0x000133A2
			public unsafe Object m_QueueLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_m_QueueLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB9 RID: 3769
			// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000CDCC0 File Offset: 0x000CBEC0
			// (set) Token: 0x06002F25 RID: 12069 RVA: 0x000151C1 File Offset: 0x000133C1
			public unsafe TimerThread.TimerNode next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EBA RID: 3770
			// (get) Token: 0x06002F26 RID: 12070 RVA: 0x000CDCF0 File Offset: 0x000CBEF0
			// (set) Token: 0x06002F27 RID: 12071 RVA: 0x000151E0 File Offset: 0x000133E0
			public unsafe TimerThread.TimerNode prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerThread.TimerNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.TimerNode.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040024EB RID: 9451
			private static readonly IntPtr NativeFieldInfoPtr_m_TimerState;

			// Token: 0x040024EC RID: 9452
			private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

			// Token: 0x040024ED RID: 9453
			private static readonly IntPtr NativeFieldInfoPtr_m_Context;

			// Token: 0x040024EE RID: 9454
			private static readonly IntPtr NativeFieldInfoPtr_m_QueueLock;

			// Token: 0x040024EF RID: 9455
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x040024F0 RID: 9456
			private static readonly IntPtr NativeFieldInfoPtr_prev;

			// Token: 0x040024F1 RID: 9457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Callback_Object_Int32_Object_0;

			// Token: 0x040024F2 RID: 9458
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040024F3 RID: 9459
			private static readonly IntPtr NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0;

			// Token: 0x040024F4 RID: 9460
			private static readonly IntPtr NativeMethodInfoPtr_get_Next_Internal_get_TimerNode_0;

			// Token: 0x040024F5 RID: 9461
			private static readonly IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_TimerNode_0;

			// Token: 0x040024F6 RID: 9462
			private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_TimerNode_0;

			// Token: 0x040024F7 RID: 9463
			private static readonly IntPtr NativeMethodInfoPtr_set_Prev_Internal_set_Void_TimerNode_0;

			// Token: 0x040024F8 RID: 9464
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0;

			// Token: 0x040024F9 RID: 9465
			private static readonly IntPtr NativeMethodInfoPtr_Fire_Internal_Boolean_0;

			// Token: 0x020003C3 RID: 963
			public enum TimerState
			{
				// Token: 0x040028AB RID: 10411
				Ready,
				// Token: 0x040028AC RID: 10412
				Fired,
				// Token: 0x040028AD RID: 10413
				Cancelled,
				// Token: 0x040028AE RID: 10414
				Sentinel
			}
		}

		// Token: 0x0200032A RID: 810
		public class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x06002F28 RID: 12072 RVA: 0x000CDD20 File Offset: 0x000CBF20
			// Note: this type is marked as 'beforefieldinit'.
			static InfiniteTimer()
			{
				Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimerThread>.NativeClassPtr, "InfiniteTimer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr);
				TimerThread.InfiniteTimer.NativeFieldInfoPtr_cancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr, "cancelled");
				TimerThread.InfiniteTimer.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr, 100667733);
				TimerThread.InfiniteTimer.NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr, 100667734);
				TimerThread.InfiniteTimer.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr, 100667735);
			}

			// Token: 0x06002F29 RID: 12073 RVA: 0x000CDD9C File Offset: 0x000CBF9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476407, XrefRangeEnd = 476409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InfiniteTimer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerThread.InfiniteTimer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerThread.InfiniteTimer.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000CDDD8 File Offset: 0x000CBFD8
			public unsafe override bool HasExpired
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.InfiniteTimer.NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002F2B RID: 12075 RVA: 0x000CDE20 File Offset: 0x000CC020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476409, XrefRangeEnd = 476410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Cancel()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerThread.InfiniteTimer.NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002F2C RID: 12076 RVA: 0x000151FF File Offset: 0x000133FF
			public InfiniteTimer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06002F2D RID: 12077 RVA: 0x000CDE68 File Offset: 0x000CC068
			// (set) Token: 0x06002F2E RID: 12078 RVA: 0x00015208 File Offset: 0x00013408
			public unsafe int cancelled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.InfiniteTimer.NativeFieldInfoPtr_cancelled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerThread.InfiniteTimer.NativeFieldInfoPtr_cancelled)) = value;
				}
			}

			// Token: 0x040024FA RID: 9466
			private static readonly IntPtr NativeFieldInfoPtr_cancelled;

			// Token: 0x040024FB RID: 9467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040024FC RID: 9468
			private static readonly IntPtr NativeMethodInfoPtr_get_HasExpired_Internal_Virtual_get_Boolean_0;

			// Token: 0x040024FD RID: 9469
			private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Virtual_Boolean_0;
		}
	}
}

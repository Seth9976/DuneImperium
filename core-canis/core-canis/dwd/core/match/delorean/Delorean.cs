using System;
using System.Runtime.InteropServices;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace dwd.core.match.delorean
{
	// Token: 0x02000164 RID: 356
	public class Delorean : Object
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x000677C8 File Offset: 0x000659C8
		// Note: this type is marked as 'beforefieldinit'.
		static Delorean()
		{
			Il2CppClassPointerStore<Delorean>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.delorean", "Delorean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delorean>.NativeClassPtr);
			Delorean.NativeFieldInfoPtr_queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean>.NativeClassPtr, "queues");
			Delorean.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean>.NativeClassPtr, "initialized");
			Delorean.NativeFieldInfoPtr_skipToResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean>.NativeClassPtr, "skipToResults");
			Delorean.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IDeloreanExecutionQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666427);
			Delorean.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_byref_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666428);
			Delorean.NativeMethodInfoPtr_enqueue_Private_IEnumerator_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666429);
			Delorean.NativeMethodInfoPtr_process_Private_Boolean_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666430);
			Delorean.NativeMethodInfoPtr_Process_Public_Void_IGameMessage_byref_DeloreanEnqueueCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666431);
			Delorean.NativeMethodInfoPtr_SkipToResults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean>.NativeClassPtr, 100666432);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000678AC File Offset: 0x00065AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875129, XrefRangeEnd = 875137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delorean([Optional] Il2CppReferenceArray<IDeloreanExecutionQueue> queues)
		{
			if (queues == null)
			{
				queues = new Il2CppReferenceArray<IDeloreanExecutionQueue>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Delorean>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queues);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IDeloreanExecutionQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00067904 File Offset: 0x00065B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875137, XrefRangeEnd = 875146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IGameMessage message, out IEnumerator coroutine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_byref_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			coroutine = ((intPtr4 == 0) ? null : new IEnumerator(intPtr4));
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00067968 File Offset: 0x00065B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875146, XrefRangeEnd = 875152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr_enqueue_Private_IEnumerator_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000679B8 File Offset: 0x00065BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 875181, RefRangeEnd = 875183, XrefRangeStart = 875152, XrefRangeEnd = 875181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool process(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr_process_Private_Boolean_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00067A08 File Offset: 0x00065C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875183, XrefRangeEnd = 875192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Process(IGameMessage message, out DeloreanEnqueueCommand enqueue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr_Process_Public_Void_IGameMessage_byref_DeloreanEnqueueCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			enqueue = ((intPtr4 == 0) ? null : new DeloreanEnqueueCommand(intPtr4));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00067A6C File Offset: 0x00065C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875192, RefRangeEnd = 875193, XrefRangeStart = 875192, XrefRangeEnd = 875192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipToResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean.NativeMethodInfoPtr_SkipToResults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0000934F File Offset: 0x0000754F
		public Delorean(params IDeloreanExecutionQueue[] queues)
			: this(new Il2CppReferenceArray<IDeloreanExecutionQueue>(queues))
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0000935D File Offset: 0x0000755D
		public Delorean(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00067AA0 File Offset: 0x00065CA0
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00009366 File Offset: 0x00007566
		public unsafe ReadOnlyCollection<IDeloreanExecutionQueue> queues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_queues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<IDeloreanExecutionQueue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_queues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00067AD0 File Offset: 0x00065CD0
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00009385 File Offset: 0x00007585
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00067AF8 File Offset: 0x00065CF8
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x000093A0 File Offset: 0x000075A0
		public unsafe bool skipToResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_skipToResults);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean.NativeFieldInfoPtr_skipToResults)) = value;
			}
		}

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeFieldInfoPtr_queues;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeFieldInfoPtr_skipToResults;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IDeloreanExecutionQueue_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_byref_IEnumerator_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_enqueue_Private_IEnumerator_IGameMessage_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_process_Private_Boolean_IGameMessage_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Void_IGameMessage_byref_DeloreanEnqueueCommand_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_SkipToResults_Public_Void_0;

		// Token: 0x020002E4 RID: 740
		[ObfuscatedName("dwd.core.match.delorean.Delorean+<enqueue>d__5")]
		public sealed class _enqueue_d__5 : Object
		{
			// Token: 0x0600223B RID: 8763 RVA: 0x00098288 File Offset: 0x00096488
			// Note: this type is marked as 'beforefieldinit'.
			static _enqueue_d__5()
			{
				Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Delorean>.NativeClassPtr, "<enqueue>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr);
				Delorean._enqueue_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "<>1__state");
				Delorean._enqueue_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "<>2__current");
				Delorean._enqueue_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "<>4__this");
				Delorean._enqueue_d__5.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "message");
				Delorean._enqueue_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "<>7__wrap1");
				Delorean._enqueue_d__5.NativeFieldInfoPtr__queue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, "<queue>5__3");
				Delorean._enqueue_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666433);
				Delorean._enqueue_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666434);
				Delorean._enqueue_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666435);
				Delorean._enqueue_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666436);
				Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666437);
				Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666438);
				Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr, 100666439);
			}

			// Token: 0x0600223C RID: 8764 RVA: 0x000983B8 File Offset: 0x000965B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _enqueue_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Delorean._enqueue_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600223D RID: 8765 RVA: 0x00098400 File Offset: 0x00096600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875088, XrefRangeEnd = 875093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600223E RID: 8766 RVA: 0x00098434 File Offset: 0x00096634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875093, XrefRangeEnd = 875121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600223F RID: 8767 RVA: 0x00098470 File Offset: 0x00096670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875121, XrefRangeEnd = 875124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x06002240 RID: 8768 RVA: 0x000984A4 File Offset: 0x000966A4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002241 RID: 8769 RVA: 0x000984E4 File Offset: 0x000966E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875124, XrefRangeEnd = 875129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06002242 RID: 8770 RVA: 0x00098518 File Offset: 0x00096718
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delorean._enqueue_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002243 RID: 8771 RVA: 0x0000EAE6 File Offset: 0x0000CCE6
			public _enqueue_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x06002244 RID: 8772 RVA: 0x00098558 File Offset: 0x00096758
			// (set) Token: 0x06002245 RID: 8773 RVA: 0x0000EAEF File Offset: 0x0000CCEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06002246 RID: 8774 RVA: 0x00098580 File Offset: 0x00096780
			// (set) Token: 0x06002247 RID: 8775 RVA: 0x0000EB0A File Offset: 0x0000CD0A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06002248 RID: 8776 RVA: 0x000985B0 File Offset: 0x000967B0
			// (set) Token: 0x06002249 RID: 8777 RVA: 0x0000EB29 File Offset: 0x0000CD29
			public unsafe Delorean __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Delorean>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x0600224A RID: 8778 RVA: 0x000985E0 File Offset: 0x000967E0
			// (set) Token: 0x0600224B RID: 8779 RVA: 0x0000EB48 File Offset: 0x0000CD48
			public unsafe IGameMessage message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x0600224C RID: 8780 RVA: 0x00098610 File Offset: 0x00096810
			// (set) Token: 0x0600224D RID: 8781 RVA: 0x0000EB67 File Offset: 0x0000CD67
			public unsafe IEnumerator<IDeloreanExecutionQueue> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IDeloreanExecutionQueue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x0600224E RID: 8782 RVA: 0x00098640 File Offset: 0x00096840
			// (set) Token: 0x0600224F RID: 8783 RVA: 0x0000EB86 File Offset: 0x0000CD86
			public unsafe IDeloreanExecutionQueue _queue_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr__queue_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDeloreanExecutionQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delorean._enqueue_d__5.NativeFieldInfoPtr__queue_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017AF RID: 6063
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017B0 RID: 6064
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__3;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

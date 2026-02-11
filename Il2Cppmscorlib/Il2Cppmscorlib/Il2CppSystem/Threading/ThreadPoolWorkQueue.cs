using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B6 RID: 438
	public sealed class ThreadPoolWorkQueue : Object
	{
		// Token: 0x06001C7D RID: 7293 RVA: 0x000A933C File Offset: 0x000A753C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueue()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr);
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueHead");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueTail");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "allThreadQueues");
			ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "numOutstandingThreadRequests");
			ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668197);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668198);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668199);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668200);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668201);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668202);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668203);
			ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100668204);
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000A945C File Offset: 0x000A765C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356550, XrefRangeEnd = 1356563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000A9498 File Offset: 0x000A7698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356563, XrefRangeEnd = 1356576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr3) : null;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000A94D8 File Offset: 0x000A76D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1356585, RefRangeEnd = 1356589, XrefRangeStart = 1356576, XrefRangeEnd = 1356585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureThreadRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000A950C File Offset: 0x000A770C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356589, XrefRangeEnd = 1356592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkThreadRequestSatisfied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000A9540 File Offset: 0x000A7740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356592, XrefRangeEnd = 1356624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000A9590 File Offset: 0x000A7790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356624, XrefRangeEnd = 1356628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalFindAndPop(IThreadPoolWorkItem callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000A95E0 File Offset: 0x000A77E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356628, XrefRangeEnd = 1356659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tl);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			callback = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000A9654 File Offset: 0x000A7854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1356704, RefRangeEnd = 1356705, XrefRangeStart = 1356659, XrefRangeEnd = 1356704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Dispatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00009219 File Offset: 0x00007419
		public ThreadPoolWorkQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x000A9684 File Offset: 0x000A7884
		// (set) Token: 0x06001C88 RID: 7304 RVA: 0x00009222 File Offset: 0x00007422
		public unsafe ThreadPoolWorkQueue.QueueSegment queueHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001C89 RID: 7305 RVA: 0x000A96B4 File Offset: 0x000A78B4
		// (set) Token: 0x06001C8A RID: 7306 RVA: 0x00009241 File Offset: 0x00007441
		public unsafe ThreadPoolWorkQueue.QueueSegment queueTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_queueTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000A96E4 File Offset: 0x000A78E4
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00009260 File Offset: 0x00007460
		public unsafe static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueue.NativeFieldInfoPtr_allThreadQueues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000A970C File Offset: 0x000A790C
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00009272 File Offset: 0x00007472
		public unsafe int numOutstandingThreadRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.NativeFieldInfoPtr_numOutstandingThreadRequests)) = value;
			}
		}

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeFieldInfoPtr_queueHead;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeFieldInfoPtr_queueTail;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeFieldInfoPtr_allThreadQueues;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeFieldInfoPtr_numOutstandingThreadRequests;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0;

		// Token: 0x02000612 RID: 1554
		public class SparseArray<T> : Object where T : class
		{
			// Token: 0x06005887 RID: 22663 RVA: 0x00196D58 File Offset: 0x00194F58
			// Note: this type is marked as 'beforefieldinit'.
			static SparseArray()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "SparseArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr);
				ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100668206);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100668207);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100668208);
				ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr, 100668209);
			}

			// Token: 0x06005888 RID: 22664 RVA: 0x00196E24 File Offset: 0x00195024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356309, XrefRangeEnd = 1356314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SparseArray(int initialSize)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.SparseArray<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref initialSize;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001693 RID: 5779
			// (get) Token: 0x06005889 RID: 22665 RVA: 0x00196E6C File Offset: 0x0019506C
			public unsafe Il2CppArrayBase<T> Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1356315, RefRangeEnd = 1356316, XrefRangeStart = 1356314, XrefRangeEnd = 1356315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
				}
			}

			// Token: 0x0600588A RID: 22666 RVA: 0x00196EA4 File Offset: 0x001950A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1356335, RefRangeEnd = 1356336, XrefRangeStart = 1356316, XrefRangeEnd = 1356335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Add(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref e;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Add_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x0600588B RID: 22667 RVA: 0x00196F28 File Offset: 0x00195128
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1356349, RefRangeEnd = 1356350, XrefRangeStart = 1356336, XrefRangeEnd = 1356349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(T e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = e;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref e;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.SparseArray<T>.NativeMethodInfoPtr_Remove_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}

			// Token: 0x0600588C RID: 22668 RVA: 0x0001F8DC File Offset: 0x0001DADC
			public SparseArray(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001692 RID: 5778
			// (get) Token: 0x0600588D RID: 22669 RVA: 0x00196FA0 File Offset: 0x001951A0
			// (set) Token: 0x0600588E RID: 22670 RVA: 0x0001F8E5 File Offset: 0x0001DAE5
			public unsafe Il2CppArrayBase<T> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array);
					return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.SparseArray<T>.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048C8 RID: 18632
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x040048C9 RID: 18633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x040048CA RID: 18634
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0;

			// Token: 0x040048CB RID: 18635
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Int32_T_0;

			// Token: 0x040048CC RID: 18636
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_T_0;
		}

		// Token: 0x02000613 RID: 1555
		public class WorkStealingQueue : Object
		{
			// Token: 0x0600588F RID: 22671 RVA: 0x00196FC8 File Offset: 0x001951C8
			// Note: this type is marked as 'beforefieldinit'.
			static WorkStealingQueue()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "WorkStealingQueue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_array");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_mask");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_headIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_tailIndex");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, "m_foreignLock");
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668210);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668211);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668212);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668213);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668214);
				ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr, 100668215);
			}

			// Token: 0x06005890 RID: 22672 RVA: 0x001970D0 File Offset: 0x001952D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1356408, RefRangeEnd = 1356409, XrefRangeStart = 1356350, XrefRangeEnd = 1356408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LocalPush(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005891 RID: 22673 RVA: 0x00197114 File Offset: 0x00195314
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1356436, RefRangeEnd = 1356438, XrefRangeStart = 1356409, XrefRangeEnd = 1356436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalFindAndPop(IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005892 RID: 22674 RVA: 0x00197164 File Offset: 0x00195364
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1356478, RefRangeEnd = 1356479, XrefRangeStart = 1356438, XrefRangeEnd = 1356478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool LocalPop(out IThreadPoolWorkItem obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x06005893 RID: 22675 RVA: 0x001971C4 File Offset: 0x001953C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356479, XrefRangeEnd = 1356480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06005894 RID: 22676 RVA: 0x00197230 File Offset: 0x00195430
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1356513, RefRangeEnd = 1356515, XrefRangeStart = 1356480, XrefRangeEnd = 1356513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &missedSteal;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06005895 RID: 22677 RVA: 0x001972AC File Offset: 0x001954AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356515, XrefRangeEnd = 1356523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WorkStealingQueue()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.WorkStealingQueue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.WorkStealingQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005896 RID: 22678 RVA: 0x0001F904 File Offset: 0x0001DB04
			public WorkStealingQueue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001694 RID: 5780
			// (get) Token: 0x06005897 RID: 22679 RVA: 0x001972E8 File Offset: 0x001954E8
			// (set) Token: 0x06005898 RID: 22680 RVA: 0x0001F90D File Offset: 0x0001DB0D
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> m_array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001695 RID: 5781
			// (get) Token: 0x06005899 RID: 22681 RVA: 0x00197318 File Offset: 0x00195518
			// (set) Token: 0x0600589A RID: 22682 RVA: 0x0001F92C File Offset: 0x0001DB2C
			public unsafe int m_mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_mask)) = value;
				}
			}

			// Token: 0x17001696 RID: 5782
			// (get) Token: 0x0600589B RID: 22683 RVA: 0x00197340 File Offset: 0x00195540
			// (set) Token: 0x0600589C RID: 22684 RVA: 0x0001F947 File Offset: 0x0001DB47
			public unsafe int m_headIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_headIndex)) = value;
				}
			}

			// Token: 0x17001697 RID: 5783
			// (get) Token: 0x0600589D RID: 22685 RVA: 0x00197368 File Offset: 0x00195568
			// (set) Token: 0x0600589E RID: 22686 RVA: 0x0001F962 File Offset: 0x0001DB62
			public unsafe int m_tailIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_tailIndex)) = value;
				}
			}

			// Token: 0x17001698 RID: 5784
			// (get) Token: 0x0600589F RID: 22687 RVA: 0x00197390 File Offset: 0x00195590
			// (set) Token: 0x060058A0 RID: 22688 RVA: 0x0001F97D File Offset: 0x0001DB7D
			public unsafe SpinLock m_foreignLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.WorkStealingQueue.NativeFieldInfoPtr_m_foreignLock)) = value;
				}
			}

			// Token: 0x040048CD RID: 18637
			private static readonly IntPtr NativeFieldInfoPtr_m_array;

			// Token: 0x040048CE RID: 18638
			private static readonly IntPtr NativeFieldInfoPtr_m_mask;

			// Token: 0x040048CF RID: 18639
			private static readonly IntPtr NativeFieldInfoPtr_m_headIndex;

			// Token: 0x040048D0 RID: 18640
			private static readonly IntPtr NativeFieldInfoPtr_m_tailIndex;

			// Token: 0x040048D1 RID: 18641
			private static readonly IntPtr NativeFieldInfoPtr_m_foreignLock;

			// Token: 0x040048D2 RID: 18642
			private static readonly IntPtr NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0;

			// Token: 0x040048D3 RID: 18643
			private static readonly IntPtr NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x040048D4 RID: 18644
			private static readonly IntPtr NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0;

			// Token: 0x040048D5 RID: 18645
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0;

			// Token: 0x040048D6 RID: 18646
			private static readonly IntPtr NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0;

			// Token: 0x040048D7 RID: 18647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000614 RID: 1556
		public class QueueSegment : Object
		{
			// Token: 0x060058A1 RID: 22689 RVA: 0x001973B8 File Offset: 0x001955B8
			// Note: this type is marked as 'beforefieldinit'.
			static QueueSegment()
			{
				Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "QueueSegment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr);
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "nodes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "indexes");
				ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, "Next");
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668216);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668217);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668218);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668219);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668220);
				ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr, 100668221);
			}

			// Token: 0x060058A2 RID: 22690 RVA: 0x00197498 File Offset: 0x00195698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356523, XrefRangeEnd = 1356524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetIndexes(out int upper, out int lower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &upper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058A3 RID: 22691 RVA: 0x001974E4 File Offset: 0x001956E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356524, XrefRangeEnd = 1356526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &prevUpper;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newUpper;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &prevLower;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058A4 RID: 22692 RVA: 0x00197558 File Offset: 0x00195758
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356526, XrefRangeEnd = 1356531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QueueSegment()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue.QueueSegment>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058A5 RID: 22693 RVA: 0x00197594 File Offset: 0x00195794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356531, XrefRangeEnd = 1356532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsUsedUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058A6 RID: 22694 RVA: 0x001975D0 File Offset: 0x001957D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356532, XrefRangeEnd = 1356537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryEnqueue(IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060058A7 RID: 22695 RVA: 0x00197620 File Offset: 0x00195820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356537, XrefRangeEnd = 1356550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryDequeue(out IThreadPoolWorkItem node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueue.QueueSegment.NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					node = ((intPtr4 == 0) ? null : new IThreadPoolWorkItem(intPtr4));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060058A8 RID: 22696 RVA: 0x0001F998 File Offset: 0x0001DB98
			public QueueSegment(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001699 RID: 5785
			// (get) Token: 0x060058A9 RID: 22697 RVA: 0x00197680 File Offset: 0x00195880
			// (set) Token: 0x060058AA RID: 22698 RVA: 0x0001F9A1 File Offset: 0x0001DBA1
			public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700169A RID: 5786
			// (get) Token: 0x060058AB RID: 22699 RVA: 0x001976B0 File Offset: 0x001958B0
			// (set) Token: 0x060058AC RID: 22700 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
			public unsafe int indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_indexes)) = value;
				}
			}

			// Token: 0x1700169B RID: 5787
			// (get) Token: 0x060058AD RID: 22701 RVA: 0x001976D8 File Offset: 0x001958D8
			// (set) Token: 0x060058AE RID: 22702 RVA: 0x0001F9DB File Offset: 0x0001DBDB
			public unsafe ThreadPoolWorkQueue.QueueSegment Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.QueueSegment>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueue.QueueSegment.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048D8 RID: 18648
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x040048D9 RID: 18649
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x040048DA RID: 18650
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x040048DB RID: 18651
			private static readonly IntPtr NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0;

			// Token: 0x040048DC RID: 18652
			private static readonly IntPtr NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0;

			// Token: 0x040048DD RID: 18653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048DE RID: 18654
			private static readonly IntPtr NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0;

			// Token: 0x040048DF RID: 18655
			private static readonly IntPtr NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0;

			// Token: 0x040048E0 RID: 18656
			private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0;
		}
	}
}

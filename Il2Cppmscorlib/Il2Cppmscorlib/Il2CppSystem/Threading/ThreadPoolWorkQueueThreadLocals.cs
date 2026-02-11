using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B7 RID: 439
	public sealed class ThreadPoolWorkQueueThreadLocals : Object
	{
		// Token: 0x06001C8F RID: 7311 RVA: 0x000A9734 File Offset: 0x000A7934
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolWorkQueueThreadLocals()
		{
			Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueueThreadLocals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr);
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "threadLocals");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "workStealingQueue");
			ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, "random");
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100668222);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100668223);
			ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr, 100668224);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x000A97F0 File Offset: 0x000A79F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1356737, RefRangeEnd = 1356739, XrefRangeStart = 1356705, XrefRangeEnd = 1356737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueueThreadLocals>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpq);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x000A983C File Offset: 0x000A7A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1356750, RefRangeEnd = 1356751, XrefRangeStart = 1356739, XrefRangeEnd = 1356750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000A9870 File Offset: 0x000A7A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356751, XrefRangeEnd = 1356758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolWorkQueueThreadLocals.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0000928D File Offset: 0x0000748D
		public ThreadPoolWorkQueueThreadLocals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x000A98A4 File Offset: 0x000A7AA4
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00009296 File Offset: 0x00007496
		public unsafe static ThreadPoolWorkQueueThreadLocals threadLocals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_threadLocals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x000A98CC File Offset: 0x000A7ACC
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x000092A8 File Offset: 0x000074A8
		public unsafe ThreadPoolWorkQueue workQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x000A98FC File Offset: 0x000A7AFC
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x000092C7 File Offset: 0x000074C7
		public unsafe ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueue.WorkStealingQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_workStealingQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x000A992C File Offset: 0x000A7B2C
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x000092E6 File Offset: 0x000074E6
		public unsafe Random random
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPoolWorkQueueThreadLocals.NativeFieldInfoPtr_random), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_threadLocals;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_workQueue;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr_workStealingQueue;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ThreadPoolWorkQueue_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}

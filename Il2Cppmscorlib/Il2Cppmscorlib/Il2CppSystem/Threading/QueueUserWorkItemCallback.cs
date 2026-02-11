using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001B9 RID: 441
	public sealed class QueueUserWorkItemCallback : Object
	{
		// Token: 0x06001C9F RID: 7327 RVA: 0x000A998C File Offset: 0x000A7B8C
		// Note: this type is marked as 'beforefieldinit'.
		static QueueUserWorkItemCallback()
		{
			Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "QueueUserWorkItemCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr);
			QueueUserWorkItemCallback.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "callback");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "context");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "state");
			QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, "ccb");
			QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100668226);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100668227);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100668228);
			QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr, 100668229);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000A9A5C File Offset: 0x000A7C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356762, XrefRangeEnd = 1356773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueUserWorkItemCallback(WaitCallback waitCallback, Object stateObj, bool compressStack, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueUserWorkItemCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000A9AD8 File Offset: 0x000A7CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356773, XrefRangeEnd = 1356781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x000A9B0C File Offset: 0x000A7D0C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x000A9B50 File Offset: 0x000A7D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356781, XrefRangeEnd = 1356795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WaitCallback_Context(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueueUserWorkItemCallback.NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00009347 File Offset: 0x00007547
		public QueueUserWorkItemCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000A9B88 File Offset: 0x000A7D88
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x00009350 File Offset: 0x00007550
		public unsafe WaitCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0000936F File Offset: 0x0000756F
		public unsafe ExecutionContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000A9BE8 File Offset: 0x000A7DE8
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000938E File Offset: 0x0000758E
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QueueUserWorkItemCallback.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000A9C18 File Offset: 0x000A7E18
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x000093AD File Offset: 0x000075AD
		public unsafe static ContextCallback ccb
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QueueUserWorkItemCallback.NativeFieldInfoPtr_ccb, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeFieldInfoPtr_ccb;

		// Token: 0x040019F6 RID: 6646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitCallback_Object_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly IntPtr NativeMethodInfoPtr_WaitCallback_Context_Private_Static_Void_Object_0;
	}
}

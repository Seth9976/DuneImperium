using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x0200006F RID: 111
	public class IOSelectorJob : Object
	{
		// Token: 0x060006C5 RID: 1733 RVA: 0x00036660 File Offset: 0x00034860
		// Note: this type is marked as 'beforefieldinit'.
		static IOSelectorJob()
		{
			Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOSelectorJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr);
			IOSelectorJob.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "operation");
			IOSelectorJob.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "callback");
			IOSelectorJob.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, "state");
			IOSelectorJob.NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100664412);
			IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100664413);
			IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100664414);
			IOSelectorJob.NativeMethodInfoPtr_MarkDisposed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr, 100664415);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0003671C File Offset: 0x0003491C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 425621, RefRangeEnd = 425634, XrefRangeStart = 425621, XrefRangeEnd = 425634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOSelectorJob>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref operation;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00036788 File Offset: 0x00034988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437151, XrefRangeEnd = 437152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x000367BC File Offset: 0x000349BC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00036800 File Offset: 0x00034A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437153, RefRangeEnd = 437154, XrefRangeStart = 437152, XrefRangeEnd = 437153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelectorJob.NativeMethodInfoPtr_MarkDisposed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x000042EB File Offset: 0x000024EB
		public IOSelectorJob(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00036834 File Offset: 0x00034A34
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x000042F4 File Offset: 0x000024F4
		public unsafe IOOperation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0003685C File Offset: 0x00034A5C
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0000430F File Offset: 0x0000250F
		public unsafe IOAsyncCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0003688C File Offset: 0x00034A8C
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0000432E File Offset: 0x0000252E
		public unsafe IOAsyncResult state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOSelectorJob.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IOOperation_IOAsyncCallback_IOAsyncResult_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_MarkDisposed_Public_Void_0;
	}
}

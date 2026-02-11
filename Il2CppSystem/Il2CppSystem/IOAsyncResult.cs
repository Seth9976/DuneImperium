using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x0200006E RID: 110
	public class IOAsyncResult : Object
	{
		// Token: 0x060006AE RID: 1710 RVA: 0x0003612C File Offset: 0x0003432C
		// Note: this type is marked as 'beforefieldinit'.
		static IOAsyncResult()
		{
			Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr);
			IOAsyncResult.NativeFieldInfoPtr_async_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "async_callback");
			IOAsyncResult.NativeFieldInfoPtr_async_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "async_state");
			IOAsyncResult.NativeFieldInfoPtr_wait_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "wait_handle");
			IOAsyncResult.NativeFieldInfoPtr_completed_synchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "completed_synchronously");
			IOAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, "completed");
			IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664401);
			IOAsyncResult.NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664402);
			IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664403);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664404);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664405);
			IOAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664406);
			IOAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664407);
			IOAsyncResult.NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664408);
			IOAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664409);
			IOAsyncResult.NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664410);
			IOAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr, 100664411);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0003629C File Offset: 0x0003449C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x000362D8 File Offset: 0x000344D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 437121, RefRangeEnd = 437122, XrefRangeStart = 437118, XrefRangeEnd = 437121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncCallback async_callback, Object async_state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(async_callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(async_state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0003632C File Offset: 0x0003452C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IOAsyncResult(AsyncCallback async_callback, Object async_state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IOAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(async_callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(async_state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0003638C File Offset: 0x0003458C
		public unsafe AsyncCallback AsyncCallback
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr3) : null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000363CC File Offset: 0x000345CC
		public unsafe virtual Object AsyncState
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0003640C File Offset: 0x0003460C
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 437131, RefRangeEnd = 437145, XrefRangeStart = 437122, XrefRangeEnd = 437131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0003644C File Offset: 0x0003464C
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00036488 File Offset: 0x00034688
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000364C8 File Offset: 0x000346C8
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00036504 File Offset: 0x00034704
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 437150, RefRangeEnd = 437151, XrefRangeStart = 437145, XrefRangeEnd = 437150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOAsyncResult.NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00036544 File Offset: 0x00034744
		[CallerCount(0)]
		public unsafe virtual void CompleteDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IOAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000424F File Offset: 0x0000244F
		public IOAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00036580 File Offset: 0x00034780
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00004258 File Offset: 0x00002458
		public unsafe AsyncCallback async_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000365B0 File Offset: 0x000347B0
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00004277 File Offset: 0x00002477
		public unsafe Object async_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_async_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x000365E0 File Offset: 0x000347E0
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00004296 File Offset: 0x00002496
		public unsafe ManualResetEvent wait_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_wait_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_wait_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00036610 File Offset: 0x00034810
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000042B5 File Offset: 0x000024B5
		public unsafe bool completed_synchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed_synchronously);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed_synchronously)) = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00036638 File Offset: 0x00034838
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x000042D0 File Offset: 0x000024D0
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IOAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_async_callback;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_async_state;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_wait_handle;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_completed_synchronously;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Void_AsyncCallback_Object_0;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_AsyncCallback_Object_0;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncCallback_Public_get_AsyncCallback_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeMethodInfoPtr_set_CompletedSynchronously_Protected_set_Void_Boolean_0;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCompleted_Protected_set_Void_Boolean_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDisposed_Internal_Abstract_Virtual_New_Void_0;
	}
}

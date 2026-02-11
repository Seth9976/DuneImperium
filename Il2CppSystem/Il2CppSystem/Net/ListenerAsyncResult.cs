using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000205 RID: 517
	public class ListenerAsyncResult : Object
	{
		// Token: 0x06002196 RID: 8598 RVA: 0x0009D918 File Offset: 0x0009BB18
		// Note: this type is marked as 'beforefieldinit'.
		static ListenerAsyncResult()
		{
			Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ListenerAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr);
			ListenerAsyncResult.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "handle");
			ListenerAsyncResult.NativeFieldInfoPtr_synch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "synch");
			ListenerAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "completed");
			ListenerAsyncResult.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "cb");
			ListenerAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "state");
			ListenerAsyncResult.NativeFieldInfoPtr_exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "exception");
			ListenerAsyncResult.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "context");
			ListenerAsyncResult.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "locker");
			ListenerAsyncResult.NativeFieldInfoPtr_forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "forward");
			ListenerAsyncResult.NativeFieldInfoPtr_EndCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "EndCalled");
			ListenerAsyncResult.NativeFieldInfoPtr_InGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "InGet");
			ListenerAsyncResult.NativeFieldInfoPtr_InvokeCB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, "InvokeCB");
			ListenerAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668305);
			ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668306);
			ListenerAsyncResult.NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668307);
			ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668308);
			ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668309);
			ListenerAsyncResult.NativeMethodInfoPtr_GetContext_Internal_HttpListenerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668310);
			ListenerAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668311);
			ListenerAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668312);
			ListenerAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668313);
			ListenerAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr, 100668314);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0009DB00 File Offset: 0x0009BD00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482543, RefRangeEnd = 482544, XrefRangeStart = 482535, XrefRangeEnd = 482543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListenerAsyncResult(AsyncCallback cb, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListenerAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0009DB60 File Offset: 0x0009BD60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 482566, RefRangeEnd = 482569, XrefRangeStart = 482544, XrefRangeEnd = 482566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception exc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0009DBA4 File Offset: 0x0009BDA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482569, XrefRangeEnd = 482572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeCallback(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0009DBDC File Offset: 0x0009BDDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482573, RefRangeEnd = 482574, XrefRangeStart = 482572, XrefRangeEnd = 482573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(HttpListenerContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0009DC20 File Offset: 0x0009BE20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 482624, RefRangeEnd = 482627, XrefRangeStart = 482574, XrefRangeEnd = 482624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(HttpListenerContext context, bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x0009DC70 File Offset: 0x0009BE70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 482627, RefRangeEnd = 482628, XrefRangeStart = 482627, XrefRangeEnd = 482627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpListenerContext GetContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_GetContext_Internal_HttpListenerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr3) : null;
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0009DCB0 File Offset: 0x0009BEB0
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0009DCF0 File Offset: 0x0009BEF0
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 482637, RefRangeEnd = 482638, XrefRangeStart = 482628, XrefRangeEnd = 482637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x0009DD30 File Offset: 0x0009BF30
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x0009DD6C File Offset: 0x0009BF6C
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 482642, RefRangeEnd = 482643, XrefRangeStart = 482638, XrefRangeEnd = 482642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListenerAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0000E80D File Offset: 0x0000CA0D
		public ListenerAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0009DDA8 File Offset: 0x0009BFA8
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x0000E816 File Offset: 0x0000CA16
		public unsafe ManualResetEvent handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x0009DDD8 File Offset: 0x0009BFD8
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0000E835 File Offset: 0x0000CA35
		public unsafe bool synch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_synch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_synch)) = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x0009DE00 File Offset: 0x0009C000
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x0000E850 File Offset: 0x0000CA50
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x0009DE28 File Offset: 0x0009C028
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x0000E86B File Offset: 0x0000CA6B
		public unsafe AsyncCallback cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x0009DE58 File Offset: 0x0009C058
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x0000E88A File Offset: 0x0000CA8A
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x0009DE88 File Offset: 0x0009C088
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x0000E8A9 File Offset: 0x0000CAA9
		public unsafe Exception exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x0009DEB8 File Offset: 0x0009C0B8
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		public unsafe HttpListenerContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpListenerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x0009DEE8 File Offset: 0x0009C0E8
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x0000E8E7 File Offset: 0x0000CAE7
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x0009DF18 File Offset: 0x0009C118
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x0000E906 File Offset: 0x0000CB06
		public unsafe ListenerAsyncResult forward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_forward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_forward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0009DF48 File Offset: 0x0009C148
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x0000E925 File Offset: 0x0000CB25
		public unsafe bool EndCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_EndCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_EndCalled)) = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x0009DF70 File Offset: 0x0009C170
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x0000E940 File Offset: 0x0000CB40
		public unsafe bool InGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_InGet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListenerAsyncResult.NativeFieldInfoPtr_InGet)) = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x0009DF98 File Offset: 0x0009C198
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x0000E95B File Offset: 0x0000CB5B
		public unsafe static WaitCallback InvokeCB
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ListenerAsyncResult.NativeFieldInfoPtr_InvokeCB, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListenerAsyncResult.NativeFieldInfoPtr_InvokeCB, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeFieldInfoPtr_synch;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeFieldInfoPtr_cb;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeFieldInfoPtr_exception;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr_forward;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeFieldInfoPtr_EndCalled;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeFieldInfoPtr_InGet;

		// Token: 0x04001A42 RID: 6722
		private static readonly IntPtr NativeFieldInfoPtr_InvokeCB;

		// Token: 0x04001A43 RID: 6723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_Exception_0;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Object_0;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_HttpListenerContext_Boolean_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_GetContext_Internal_HttpListenerContext_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A4A RID: 6730
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04001A4B RID: 6731
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001A4C RID: 6732
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;
	}
}

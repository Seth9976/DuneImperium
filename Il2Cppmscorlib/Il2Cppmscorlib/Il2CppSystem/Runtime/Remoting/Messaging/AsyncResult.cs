using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002EA RID: 746
	public class AsyncResult : Object
	{
		// Token: 0x06002E25 RID: 11813 RVA: 0x000EEE98 File Offset: 0x000ED098
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncResult()
		{
			Il2CppClassPointerStore<AsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "AsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr);
			AsyncResult.NativeFieldInfoPtr_async_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_state");
			AsyncResult.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "handle");
			AsyncResult.NativeFieldInfoPtr_async_delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_delegate");
			AsyncResult.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "data");
			AsyncResult.NativeFieldInfoPtr_object_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "object_data");
			AsyncResult.NativeFieldInfoPtr_sync_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "sync_completed");
			AsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "completed");
			AsyncResult.NativeFieldInfoPtr_endinvoke_called = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "endinvoke_called");
			AsyncResult.NativeFieldInfoPtr_async_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "async_callback");
			AsyncResult.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "current");
			AsyncResult.NativeFieldInfoPtr_original = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "original");
			AsyncResult.NativeFieldInfoPtr_add_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "add_time");
			AsyncResult.NativeFieldInfoPtr_call_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "call_message");
			AsyncResult.NativeFieldInfoPtr_message_ctrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "message_ctrl");
			AsyncResult.NativeFieldInfoPtr_reply_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "reply_message");
			AsyncResult.NativeFieldInfoPtr_orig_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, "orig_cb");
			AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670667);
			AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670668);
			AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670669);
			AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670670);
			AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670671);
			AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670672);
			AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670673);
			AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670674);
			AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670675);
			AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670676);
			AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670677);
			AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670678);
			AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670679);
			AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670680);
			AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670681);
			AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670682);
			AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670683);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670684);
			AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670685);
			AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr, 100670686);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000EF198 File Offset: 0x000ED398
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x000EF1D4 File Offset: 0x000ED3D4
		public unsafe virtual Object AsyncState
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000EF220 File Offset: 0x000ED420
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382482, XrefRangeEnd = 1382491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000EF26C File Offset: 0x000ED46C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000EF2B4 File Offset: 0x000ED4B4
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x000EF2FC File Offset: 0x000ED4FC
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x000EF338 File Offset: 0x000ED538
		public unsafe bool EndInvokeCalled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x000EF378 File Offset: 0x000ED578
		public unsafe virtual Object AsyncDelegate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000EF3C4 File Offset: 0x000ED5C4
		public unsafe virtual IMessageSink NextSink
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x000EF404 File Offset: 0x000ED604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382491, XrefRangeEnd = 1382496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x000EF474 File Offset: 0x000ED674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage GetReplyMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x000EF4C0 File Offset: 0x000ED6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMessageCtrl(IMessageCtrl mc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x000EF510 File Offset: 0x000ED710
		[CallerCount(0)]
		public unsafe void SetCompletedSynchronously(bool completed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref completed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x000EF550 File Offset: 0x000ED750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382500, RefRangeEnd = 1382501, XrefRangeStart = 1382496, XrefRangeEnd = 1382500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMessage EndInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x000EF590 File Offset: 0x000ED790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382501, XrefRangeEnd = 1382511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsyncResult.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x000EF5EC File Offset: 0x000ED7EC
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x000EF62C File Offset: 0x000ED82C
		public unsafe MonoMethodMessage CallMessage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x000EF670 File Offset: 0x000ED870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382511, XrefRangeEnd = 1382512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x000EF6A4 File Offset: 0x000ED8A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x000EF6E8 File Offset: 0x000ED8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncResult.NativeMethodInfoPtr_Invoke_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x0000F99F File Offset: 0x0000DB9F
		public AsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x000EF728 File Offset: 0x000ED928
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		public unsafe Object async_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000EF758 File Offset: 0x000ED958
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0000F9C7 File Offset: 0x0000DBC7
		public unsafe WaitHandle handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000EF788 File Offset: 0x000ED988
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x0000F9E6 File Offset: 0x0000DBE6
		public unsafe Object async_delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x000EF7B8 File Offset: 0x000ED9B8
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x0000FA05 File Offset: 0x0000DC05
		public unsafe IntPtr data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x000EF7E0 File Offset: 0x000ED9E0
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x0000FA20 File Offset: 0x0000DC20
		public unsafe Object object_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_object_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000EF810 File Offset: 0x000EDA10
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x0000FA3F File Offset: 0x0000DC3F
		public unsafe bool sync_completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_sync_completed)) = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x000EF838 File Offset: 0x000EDA38
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x0000FA5A File Offset: 0x0000DC5A
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000EF860 File Offset: 0x000EDA60
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0000FA75 File Offset: 0x0000DC75
		public unsafe bool endinvoke_called
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_endinvoke_called)) = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000EF888 File Offset: 0x000EDA88
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x0000FA90 File Offset: 0x0000DC90
		public unsafe Object async_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_async_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000EF8B8 File Offset: 0x000EDAB8
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x0000FAAF File Offset: 0x0000DCAF
		public unsafe ExecutionContext current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000EF8E8 File Offset: 0x000EDAE8
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x0000FACE File Offset: 0x0000DCCE
		public unsafe ExecutionContext original
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_original), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000EF918 File Offset: 0x000EDB18
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x0000FAED File Offset: 0x0000DCED
		public unsafe long add_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_add_time)) = value;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000EF940 File Offset: 0x000EDB40
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0000FB08 File Offset: 0x0000DD08
		public unsafe MonoMethodMessage call_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoMethodMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_call_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000EF970 File Offset: 0x000EDB70
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0000FB27 File Offset: 0x0000DD27
		public unsafe IMessageCtrl message_ctrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_message_ctrl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000EF9A0 File Offset: 0x000EDBA0
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x0000FB46 File Offset: 0x0000DD46
		public unsafe IMessage reply_message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_reply_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x000EF9D0 File Offset: 0x000EDBD0
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x0000FB65 File Offset: 0x0000DD65
		public unsafe WaitCallback orig_cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncResult.NativeFieldInfoPtr_orig_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002687 RID: 9863
		private static readonly IntPtr NativeFieldInfoPtr_async_state;

		// Token: 0x04002688 RID: 9864
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeFieldInfoPtr_async_delegate;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeFieldInfoPtr_object_data;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeFieldInfoPtr_sync_completed;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeFieldInfoPtr_endinvoke_called;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeFieldInfoPtr_async_callback;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeFieldInfoPtr_original;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeFieldInfoPtr_add_time;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeFieldInfoPtr_call_message;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeFieldInfoPtr_message_ctrl;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeFieldInfoPtr_reply_message;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeFieldInfoPtr_orig_cb;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_New_get_Object_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_New_get_WaitHandle_0;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_get_EndInvokeCalled_Public_get_Boolean_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_set_EndInvokeCalled_Public_set_Void_Boolean_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncDelegate_Public_Virtual_New_get_Object_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSink_Public_Virtual_Final_New_get_IMessageSink_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeMethodInfoPtr_GetReplyMessage_Public_Virtual_New_IMessage_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageCtrl_Public_Virtual_New_Void_IMessageCtrl_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeMethodInfoPtr_SetCompletedSynchronously_Internal_Void_Boolean_0;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Internal_IMessage_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_New_IMessage_IMessage_0;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeMethodInfoPtr_get_CallMessage_Internal_get_MonoMethodMessage_0;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeMethodInfoPtr_set_CallMessage_Internal_set_Void_MonoMethodMessage_0;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Object_0;
	}
}

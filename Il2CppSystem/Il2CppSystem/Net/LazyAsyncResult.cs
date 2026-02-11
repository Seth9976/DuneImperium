using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x020001D1 RID: 465
	public class LazyAsyncResult : Object
	{
		// Token: 0x06001C94 RID: 7316 RVA: 0x0008B8E8 File Offset: 0x00089AE8
		// Note: this type is marked as 'beforefieldinit'.
		static LazyAsyncResult()
		{
			Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "LazyAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr);
			LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "t_ThreadContext");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncObject");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncState");
			LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_AsyncCallback");
			LazyAsyncResult.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Result");
			LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_IntCompleted");
			LazyAsyncResult.NativeFieldInfoPtr_m_EndCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_EndCalled");
			LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_UserEvent");
			LazyAsyncResult.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "m_Event");
			LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667675);
			LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667676);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667677);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667678);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Protected_get_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667679);
			LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667680);
			LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667681);
			LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667682);
			LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667683);
			LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667684);
			LazyAsyncResult.NativeMethodInfoPtr_get_EndCalled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667685);
			LazyAsyncResult.NativeMethodInfoPtr_set_EndCalled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667686);
			LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667687);
			LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667688);
			LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667689);
			LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667690);
			LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667691);
			LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667692);
			LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667693);
			LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, 100667694);
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x0008BB5C File Offset: 0x00089D5C
		public unsafe static LazyAsyncResult.ThreadContext CurrentThreadContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476110, XrefRangeEnd = 476122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr3) : null;
			}
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0008BB90 File Offset: 0x00089D90
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 476131, RefRangeEnd = 476141, XrefRangeStart = 476122, XrefRangeEnd = 476131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LazyAsyncResult(Object myObject, Object myState, AsyncCallback myCallBack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(myObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(myCallBack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x0008BC00 File Offset: 0x00089E00
		public unsafe Object AsyncObject
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x0008BC40 File Offset: 0x00089E40
		public unsafe virtual Object AsyncState
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x0008BC80 File Offset: 0x00089E80
		public unsafe AsyncCallback AsyncCallback
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncCallback_Protected_get_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr3) : null;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0008BCC0 File Offset: 0x00089EC0
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476141, XrefRangeEnd = 476145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0008BD00 File Offset: 0x00089F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476157, RefRangeEnd = 476159, XrefRangeStart = 476145, XrefRangeEnd = 476157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LazilyCreateEvent(out ManualResetEvent waitHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				waitHandle = ((intPtr4 == 0) ? null : new ManualResetEvent(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0008BD60 File Offset: 0x00089F60
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 476160, RefRangeEnd = 476163, XrefRangeStart = 476159, XrefRangeEnd = 476160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0008BD9C File Offset: 0x00089F9C
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 476164, RefRangeEnd = 476165, XrefRangeStart = 476163, XrefRangeEnd = 476164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x0008BDD8 File Offset: 0x00089FD8
		public unsafe bool InternalPeekCompleted
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 476165, RefRangeEnd = 476169, XrefRangeStart = 476165, XrefRangeEnd = 476165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0008BE14 File Offset: 0x0008A014
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0008BE50 File Offset: 0x0008A050
		public unsafe bool EndCalled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_get_EndCalled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_set_EndCalled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0008BE90 File Offset: 0x0008A090
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 476182, RefRangeEnd = 476188, XrefRangeStart = 476169, XrefRangeEnd = 476182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProtectedInvokeCallback(Object result, IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userToken;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0008BEE0 File Offset: 0x0008A0E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 476189, RefRangeEnd = 476192, XrefRangeStart = 476188, XrefRangeEnd = 476189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback(Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0008BF24 File Offset: 0x0008A124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 476193, RefRangeEnd = 476194, XrefRangeStart = 476192, XrefRangeEnd = 476193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0008BF58 File Offset: 0x0008A158
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 476216, RefRangeEnd = 476218, XrefRangeStart = 476194, XrefRangeEnd = 476216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(IntPtr userToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userToken;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0008BFA4 File Offset: 0x0008A1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 476218, XrefRangeEnd = 476219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WorkerThreadComplete(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0008BFE8 File Offset: 0x0008A1E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LazyAsyncResult.NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0008C024 File Offset: 0x0008A224
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 476220, RefRangeEnd = 476225, XrefRangeStart = 476219, XrefRangeEnd = 476220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InternalWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0008C064 File Offset: 0x0008A264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 476243, RefRangeEnd = 476246, XrefRangeStart = 476225, XrefRangeEnd = 476243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object WaitForCompletion(bool snap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref snap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0000C28C File Offset: 0x0000A48C
		public LazyAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001CAA RID: 7338 RVA: 0x0008C0B0 File Offset: 0x0008A2B0
		// (set) Token: 0x06001CAB RID: 7339 RVA: 0x0000C295 File Offset: 0x0000A495
		public unsafe static LazyAsyncResult.ThreadContext t_ThreadContext
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LazyAsyncResult.ThreadContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LazyAsyncResult.NativeFieldInfoPtr_t_ThreadContext, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001CAC RID: 7340 RVA: 0x0008C0D8 File Offset: 0x0008A2D8
		// (set) Token: 0x06001CAD RID: 7341 RVA: 0x0000C2A7 File Offset: 0x0000A4A7
		public unsafe Object m_AsyncObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x0008C108 File Offset: 0x0008A308
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x0000C2C6 File Offset: 0x0000A4C6
		public unsafe Object m_AsyncState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x0008C138 File Offset: 0x0008A338
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x0000C2E5 File Offset: 0x0000A4E5
		public unsafe AsyncCallback m_AsyncCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_AsyncCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x0008C168 File Offset: 0x0008A368
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x0000C304 File Offset: 0x0000A504
		public unsafe Object m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x0008C198 File Offset: 0x0008A398
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x0000C323 File Offset: 0x0000A523
		public unsafe int m_IntCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_IntCompleted)) = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0000C33E File Offset: 0x0000A53E
		public unsafe bool m_EndCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_EndCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_EndCalled)) = value;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0008C1E8 File Offset: 0x0008A3E8
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0000C359 File Offset: 0x0000A559
		public unsafe bool m_UserEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_UserEvent)) = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0008C210 File Offset: 0x0008A410
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x0000C374 File Offset: 0x0000A574
		public unsafe Object m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_t_ThreadContext;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncObject;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncState;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncCallback;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeFieldInfoPtr_m_IntCompleted;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_m_EndCalled;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeFieldInfoPtr_m_UserEvent;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentThreadContext_Private_Static_get_ThreadContext_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Object_AsyncCallback_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncObject_Internal_get_Object_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncCallback_Protected_get_AsyncCallback_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_LazilyCreateEvent_Private_Boolean_byref_ManualResetEvent_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalPeekCompleted_Internal_get_Boolean_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_get_EndCalled_Internal_get_Boolean_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_set_EndCalled_Internal_set_Void_Boolean_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_ProtectedInvokeCallback_Protected_Void_Object_IntPtr_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Protected_Virtual_New_Void_IntPtr_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_WorkerThreadComplete_Private_Void_Object_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Protected_Virtual_New_Void_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitForCompletion_Internal_Object_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Private_Object_Boolean_0;

		// Token: 0x02000323 RID: 803
		public class ThreadContext : Object
		{
			// Token: 0x06002EE5 RID: 12005 RVA: 0x000CCF84 File Offset: 0x000CB184
			// Note: this type is marked as 'beforefieldinit'.
			static ThreadContext()
			{
				Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LazyAsyncResult>.NativeClassPtr, "ThreadContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr);
				LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, "m_NestedIOCount");
				LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr, 100667695);
			}

			// Token: 0x06002EE6 RID: 12006 RVA: 0x000CCFD8 File Offset: 0x000CB1D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ThreadContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LazyAsyncResult.ThreadContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LazyAsyncResult.ThreadContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EE7 RID: 12007 RVA: 0x00014FFF File Offset: 0x000131FF
			public ThreadContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EAB RID: 3755
			// (get) Token: 0x06002EE8 RID: 12008 RVA: 0x000CD014 File Offset: 0x000CB214
			// (set) Token: 0x06002EE9 RID: 12009 RVA: 0x00015008 File Offset: 0x00013208
			public unsafe int m_NestedIOCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LazyAsyncResult.ThreadContext.NativeFieldInfoPtr_m_NestedIOCount)) = value;
				}
			}

			// Token: 0x040024D4 RID: 9428
			private static readonly IntPtr NativeFieldInfoPtr_m_NestedIOCount;

			// Token: 0x040024D5 RID: 9429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

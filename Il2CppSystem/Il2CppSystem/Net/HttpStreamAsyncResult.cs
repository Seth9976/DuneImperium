using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net
{
	// Token: 0x02000201 RID: 513
	public class HttpStreamAsyncResult : Object
	{
		// Token: 0x0600207A RID: 8314 RVA: 0x000999A0 File Offset: 0x00097BA0
		// Note: this type is marked as 'beforefieldinit'.
		static HttpStreamAsyncResult()
		{
			Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpStreamAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr);
			HttpStreamAsyncResult.NativeFieldInfoPtr_locker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "locker");
			HttpStreamAsyncResult.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "handle");
			HttpStreamAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "completed");
			HttpStreamAsyncResult.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "Buffer");
			HttpStreamAsyncResult.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "Offset");
			HttpStreamAsyncResult.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "Count");
			HttpStreamAsyncResult.NativeFieldInfoPtr_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "Callback");
			HttpStreamAsyncResult.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "State");
			HttpStreamAsyncResult.NativeFieldInfoPtr_SynchRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "SynchRead");
			HttpStreamAsyncResult.NativeFieldInfoPtr_Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, "Error");
			HttpStreamAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668168);
			HttpStreamAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668169);
			HttpStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668170);
			HttpStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668171);
			HttpStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668172);
			HttpStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668173);
			HttpStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr, 100668174);
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00099B24 File Offset: 0x00097D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481237, XrefRangeEnd = 481239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00099B68 File Offset: 0x00097D68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 481247, RefRangeEnd = 481250, XrefRangeStart = 481239, XrefRangeEnd = 481247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x00099B9C File Offset: 0x00097D9C
		public unsafe virtual Object AsyncState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x00099BDC File Offset: 0x00097DDC
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481250, XrefRangeEnd = 481259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x00099C1C File Offset: 0x00097E1C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00099C58 File Offset: 0x00097E58
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481259, XrefRangeEnd = 481263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x00099C94 File Offset: 0x00097E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481263, XrefRangeEnd = 481269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpStreamAsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpStreamAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0000DED6 File Offset: 0x0000C0D6
		public HttpStreamAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x00099CD0 File Offset: 0x00097ED0
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x0000DEDF File Offset: 0x0000C0DF
		public unsafe Object locker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_locker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_locker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x00099D00 File Offset: 0x00097F00
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0000DEFE File Offset: 0x0000C0FE
		public unsafe ManualResetEvent handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x00099D30 File Offset: 0x00097F30
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0000DF1D File Offset: 0x0000C11D
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x00099D58 File Offset: 0x00097F58
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0000DF38 File Offset: 0x0000C138
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x00099D88 File Offset: 0x00097F88
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000DF57 File Offset: 0x0000C157
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x00099DB0 File Offset: 0x00097FB0
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000DF72 File Offset: 0x0000C172
		public unsafe int Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Count)) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x00099DD8 File Offset: 0x00097FD8
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000DF8D File Offset: 0x0000C18D
		public unsafe AsyncCallback Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x00099E08 File Offset: 0x00098008
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		public unsafe Object State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x00099E38 File Offset: 0x00098038
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000DFCB File Offset: 0x0000C1CB
		public unsafe int SynchRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_SynchRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_SynchRead)) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x00099E60 File Offset: 0x00098060
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
		public unsafe Exception Error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Error);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpStreamAsyncResult.NativeFieldInfoPtr_Error), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_locker;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeFieldInfoPtr_Callback;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeFieldInfoPtr_SynchRead;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeFieldInfoPtr_Error;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

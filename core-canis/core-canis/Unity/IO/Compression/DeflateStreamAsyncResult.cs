using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Unity.IO.Compression
{
	// Token: 0x0200006A RID: 106
	public class DeflateStreamAsyncResult : Object
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x00032310 File Offset: 0x00030510
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateStreamAsyncResult()
		{
			Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Unity.IO.Compression", "DeflateStreamAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr);
			DeflateStreamAsyncResult.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "buffer");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "offset");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "count");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_isWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "isWrite");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_AsyncState");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_AsyncCallback");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_Result");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_CompletedSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_CompletedSynchronously");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_InvokedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_InvokedCallback");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_Completed");
			DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, "m_Event");
			DeflateStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_AsyncCallback_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664449);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664450);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664451);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664452);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664453);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_get_Result_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664454);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_Close_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664455);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664456);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664457);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_Complete_Private_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664458);
			DeflateStreamAsyncResult.NativeMethodInfoPtr_Complete_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr, 100664459);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000324F8 File Offset: 0x000306F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861163, XrefRangeEnd = 861167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStreamAsyncResult(Object asyncObject, Object asyncState, AsyncCallback asyncCallback, Il2CppStructArray<byte> buffer, int offset, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_AsyncCallback_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00032598 File Offset: 0x00030798
		public unsafe virtual Object AsyncState
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000325D8 File Offset: 0x000307D8
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861167, XrefRangeEnd = 861174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00032618 File Offset: 0x00030818
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00032654 File Offset: 0x00030854
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00032690 File Offset: 0x00030890
		public unsafe Object Result
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_get_Result_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000326D0 File Offset: 0x000308D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861174, XrefRangeEnd = 861176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_Close_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00032704 File Offset: 0x00030904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861176, XrefRangeEnd = 861177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback(bool completedSynchronously, Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref completedSynchronously;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00032754 File Offset: 0x00030954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861177, XrefRangeEnd = 861178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCallback(Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00032798 File Offset: 0x00030998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(bool completedSynchronously, Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref completedSynchronously;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_Complete_Private_Void_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000327E8 File Offset: 0x000309E8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 861184, RefRangeEnd = 861193, XrefRangeStart = 861178, XrefRangeEnd = 861184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamAsyncResult.NativeMethodInfoPtr_Complete_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000475A File Offset: 0x0000295A
		public DeflateStreamAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0003282C File Offset: 0x00030A2C
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x00004763 File Offset: 0x00002963
		public unsafe Il2CppStructArray<byte> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0003285C File Offset: 0x00030A5C
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x00004782 File Offset: 0x00002982
		public unsafe int offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00032884 File Offset: 0x00030A84
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0000479D File Offset: 0x0000299D
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x000328AC File Offset: 0x00030AAC
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000047B8 File Offset: 0x000029B8
		public unsafe bool isWrite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_isWrite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_isWrite)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x000328D4 File Offset: 0x00030AD4
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x000047D3 File Offset: 0x000029D3
		public unsafe Object m_AsyncState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00032904 File Offset: 0x00030B04
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000047F2 File Offset: 0x000029F2
		public unsafe AsyncCallback m_AsyncCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_AsyncCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00032934 File Offset: 0x00030B34
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00004811 File Offset: 0x00002A11
		public unsafe Object m_Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00032964 File Offset: 0x00030B64
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00004830 File Offset: 0x00002A30
		public unsafe bool m_CompletedSynchronously
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_CompletedSynchronously);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_CompletedSynchronously)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0003298C File Offset: 0x00030B8C
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0000484B File Offset: 0x00002A4B
		public unsafe int m_InvokedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_InvokedCallback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_InvokedCallback)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x000329B4 File Offset: 0x00030BB4
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00004866 File Offset: 0x00002A66
		public unsafe int m_Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Completed)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x000329DC File Offset: 0x00030BDC
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x00004881 File Offset: 0x00002A81
		public unsafe Object m_Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamAsyncResult.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_isWrite;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncState;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncCallback;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_m_Result;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_m_CompletedSynchronously;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokedCallback;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_m_Completed;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_m_Event;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_AsyncCallback_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Internal_get_Object_0;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_0;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_Boolean_Object_0;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallback_Internal_Void_Object_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Private_Void_Boolean_Object_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Private_Void_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000247 RID: 583
	public sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x000B2B80 File Offset: 0x000B0D80
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncResult()
		{
			Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr);
			SocketAsyncResult.NativeFieldInfoPtr_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "socket");
			SocketAsyncResult.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "operation");
			SocketAsyncResult.NativeFieldInfoPtr_DelayedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "DelayedException");
			SocketAsyncResult.NativeFieldInfoPtr_EndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndPoint");
			SocketAsyncResult.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffer");
			SocketAsyncResult.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Offset");
			SocketAsyncResult.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Size");
			SocketAsyncResult.NativeFieldInfoPtr_SockFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "SockFlags");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Addresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Addresses");
			SocketAsyncResult.NativeFieldInfoPtr_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Port");
			SocketAsyncResult.NativeFieldInfoPtr_Buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Buffers");
			SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "ReuseSocket");
			SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "CurrentAddress");
			SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "AcceptedSocket");
			SocketAsyncResult.NativeFieldInfoPtr_Total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "Total");
			SocketAsyncResult.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "error");
			SocketAsyncResult.NativeFieldInfoPtr_EndCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "EndCalled");
			SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669120);
			SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669121);
			SocketAsyncResult.NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669122);
			SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669123);
			SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669124);
			SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669125);
			SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669126);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669127);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669128);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669129);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669130);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669131);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669132);
			SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, 100669133);
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x000B2E30 File Offset: 0x000B1030
		public unsafe IntPtr Handle
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 490623, RefRangeEnd = 490635, XrefRangeStart = 490622, XrefRangeEnd = 490623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000B2E6C File Offset: 0x000B106C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000B2EA8 File Offset: 0x000B10A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 490647, RefRangeEnd = 490652, XrefRangeStart = 490635, XrefRangeEnd = 490647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Socket socket, AsyncCallback callback, Object state, SocketOperation operation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000B2F1C File Offset: 0x000B111C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 490654, RefRangeEnd = 490664, XrefRangeStart = 490652, XrefRangeEnd = 490654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncResult(Socket socket, AsyncCallback callback, Object state, SocketOperation operation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref operation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000B2F9C File Offset: 0x000B119C
		public unsafe SocketError ErrorCode
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 490668, RefRangeEnd = 490672, XrefRangeStart = 490664, XrefRangeEnd = 490668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000B2FD8 File Offset: 0x000B11D8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 490672, RefRangeEnd = 490686, XrefRangeStart = 490672, XrefRangeEnd = 490672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfThrowDelayedException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000B300C File Offset: 0x000B120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490686, XrefRangeEnd = 490687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CompleteDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000B3040 File Offset: 0x000B1240
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 490713, RefRangeEnd = 490723, XrefRangeStart = 490687, XrefRangeEnd = 490713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000B3074 File Offset: 0x000B1274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490723, XrefRangeEnd = 490724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref synch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000B30B4 File Offset: 0x000B12B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 490725, RefRangeEnd = 490730, XrefRangeStart = 490724, XrefRangeEnd = 490725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref total;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000B30F4 File Offset: 0x000B12F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490732, RefRangeEnd = 490733, XrefRangeStart = 490730, XrefRangeEnd = 490732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e, bool synch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref synch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000B3144 File Offset: 0x000B1344
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 490735, RefRangeEnd = 490741, XrefRangeStart = 490733, XrefRangeEnd = 490735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000B3188 File Offset: 0x000B1388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490743, RefRangeEnd = 490744, XrefRangeStart = 490741, XrefRangeEnd = 490743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000B31CC File Offset: 0x000B13CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490744, XrefRangeEnd = 490746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete(Socket s, int total)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00010BB2 File Offset: 0x0000EDB2
		public SocketAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000B321C File Offset: 0x000B141C
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x00010BBB File Offset: 0x0000EDBB
		public unsafe Socket socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000B324C File Offset: 0x000B144C
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00010BDA File Offset: 0x0000EDDA
		public unsafe SocketOperation operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_operation)) = value;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000B3274 File Offset: 0x000B1474
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00010BF5 File Offset: 0x0000EDF5
		public unsafe Exception DelayedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_DelayedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000B32A4 File Offset: 0x000B14A4
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00010C14 File Offset: 0x0000EE14
		public unsafe EndPoint EndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000B32D4 File Offset: 0x000B14D4
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x00010C33 File Offset: 0x0000EE33
		public Memory<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer);
				return new Memory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000B3304 File Offset: 0x000B1504
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00010C61 File Offset: 0x0000EE61
		public unsafe int Offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Offset)) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000B332C File Offset: 0x000B152C
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00010C7C File Offset: 0x0000EE7C
		public unsafe int Size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000B3354 File Offset: 0x000B1554
		// (set) Token: 0x06002706 RID: 9990 RVA: 0x00010C97 File Offset: 0x0000EE97
		public unsafe SocketFlags SockFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_SockFlags)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000B337C File Offset: 0x000B157C
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		public unsafe Socket AcceptSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000B33AC File Offset: 0x000B15AC
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00010CD1 File Offset: 0x0000EED1
		public unsafe Il2CppReferenceArray<IPAddress> Addresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPAddress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Addresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x000B33DC File Offset: 0x000B15DC
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		public unsafe int Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Port)) = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x000B3404 File Offset: 0x000B1604
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00010D0B File Offset: 0x0000EF0B
		public unsafe IList<ArraySegment<byte>> Buffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Buffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000B3434 File Offset: 0x000B1634
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00010D2A File Offset: 0x0000EF2A
		public unsafe bool ReuseSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_ReuseSocket)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000B345C File Offset: 0x000B165C
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00010D45 File Offset: 0x0000EF45
		public unsafe int CurrentAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_CurrentAddress)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000B3484 File Offset: 0x000B1684
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x00010D60 File Offset: 0x0000EF60
		public unsafe Socket AcceptedSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_AcceptedSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000B34B4 File Offset: 0x000B16B4
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00010D7F File Offset: 0x0000EF7F
		public unsafe int Total
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_Total)) = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x000B34DC File Offset: 0x000B16DC
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00010D9A File Offset: 0x0000EF9A
		public unsafe int error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_error)) = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x000B3504 File Offset: 0x000B1704
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00010DB5 File Offset: 0x0000EFB5
		public unsafe int EndCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncResult.NativeFieldInfoPtr_EndCalled)) = value;
			}
		}

		// Token: 0x04001EFF RID: 7935
		private static readonly IntPtr NativeFieldInfoPtr_socket;

		// Token: 0x04001F00 RID: 7936
		private static readonly IntPtr NativeFieldInfoPtr_operation;

		// Token: 0x04001F01 RID: 7937
		private static readonly IntPtr NativeFieldInfoPtr_DelayedException;

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_EndPoint;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_Offset;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeFieldInfoPtr_SockFlags;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeFieldInfoPtr_AcceptSocket;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr_Addresses;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_Port;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_Buffers;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_ReuseSocket;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_CurrentAddress;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedSocket;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeFieldInfoPtr_Total;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_EndCalled;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Public_get_IntPtr_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Socket_AsyncCallback_Object_SocketOperation_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCode_Public_get_SocketError_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfThrowDelayedException_Public_Void_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDisposed_Internal_Virtual_Void_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Boolean_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Int32_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_Boolean_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Exception_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_Socket_Int32_0;

		// Token: 0x02000374 RID: 884
		[ObfuscatedName("System.Net.Sockets.SocketAsyncResult+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600331A RID: 13082 RVA: 0x000D7E98 File Offset: 0x000D6098
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketAsyncResult>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr);
				SocketAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9");
				SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, "<>9__27_0");
				SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100669135);
				SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr, 100669136);
			}

			// Token: 0x0600331B RID: 13083 RVA: 0x000D7F14 File Offset: 0x000D6114
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncResult.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600331C RID: 13084 RVA: 0x000D7F50 File Offset: 0x000D6150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490618, XrefRangeEnd = 490622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Complete_b__27_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncResult.__c.NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600331D RID: 13085 RVA: 0x000182FD File Offset: 0x000164FD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001016 RID: 4118
			// (get) Token: 0x0600331E RID: 13086 RVA: 0x000D7F94 File Offset: 0x000D6194
			// (set) Token: 0x0600331F RID: 13087 RVA: 0x00018306 File Offset: 0x00016506
			public unsafe static SocketAsyncResult.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001017 RID: 4119
			// (get) Token: 0x06003320 RID: 13088 RVA: 0x000D7FBC File Offset: 0x000D61BC
			// (set) Token: 0x06003321 RID: 13089 RVA: 0x00018318 File Offset: 0x00016518
			public unsafe static WaitCallback __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketAsyncResult.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400272D RID: 10029
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400272E RID: 10030
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x0400272F RID: 10031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002730 RID: 10032
			private static readonly IntPtr NativeMethodInfoPtr__Complete_b__27_0_Internal_Void_Object_0;
		}
	}
}

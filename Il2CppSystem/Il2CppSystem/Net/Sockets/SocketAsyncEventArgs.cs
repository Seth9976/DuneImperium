using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000246 RID: 582
	public class SocketAsyncEventArgs : EventArgs
	{
		// Token: 0x060026A3 RID: 9891 RVA: 0x000B1D00 File Offset: 0x000AFF00
		// Note: this type is marked as 'beforefieldinit'.
		static SocketAsyncEventArgs()
		{
			Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketAsyncEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr);
			SocketAsyncEventArgs.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "disposed");
			SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "in_progress");
			SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "remote_ep");
			SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "current_socket");
			SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "socket_async_result");
			SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<AcceptSocket>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<BytesTransferred>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<LastOperation>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SendPacketsSendSize>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SocketError>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<SocketFlags>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "<UserToken>k__BackingField");
			SocketAsyncEventArgs.NativeFieldInfoPtr_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "Completed");
			SocketAsyncEventArgs.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "_buffer");
			SocketAsyncEventArgs.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "_offset");
			SocketAsyncEventArgs.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "_count");
			SocketAsyncEventArgs.NativeFieldInfoPtr__bufferIsExplicitArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "_bufferIsExplicitArray");
			SocketAsyncEventArgs.NativeFieldInfoPtr__bufferList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, "_bufferList");
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669090);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669091);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_BytesTransferred_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669092);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669093);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669094);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669095);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669096);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669097);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669098);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketFlags_Public_set_Void_SocketFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669099);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_UserToken_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669100);
			SocketAsyncEventArgs.NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669101);
			SocketAsyncEventArgs.NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669102);
			SocketAsyncEventArgs.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669103);
			SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669104);
			SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669105);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669106);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669107);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669108);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetBytesTransferred_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669109);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_CurrentSocket_Internal_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669110);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetCurrentSocket_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669111);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669112);
			SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_internal_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669113);
			SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669114);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_MemoryBuffer_Public_get_Memory_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669115);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669116);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669117);
			SocketAsyncEventArgs.NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669118);
			SocketAsyncEventArgs.NativeMethodInfoPtr_SetBuffer_Public_Void_Memory_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr, 100669119);
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000B20F0 File Offset: 0x000B02F0
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x000B2130 File Offset: 0x000B0330
		public unsafe Socket AcceptSocket
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000B2174 File Offset: 0x000B0374
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x000B21B0 File Offset: 0x000B03B0
		public unsafe int BytesTransferred
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_BytesTransferred_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_BytesTransferred_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x000B21F0 File Offset: 0x000B03F0
		public unsafe SocketAsyncOperation LastOperation
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x000B2230 File Offset: 0x000B0430
		public unsafe EndPoint RemoteEndPoint
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x000B2274 File Offset: 0x000B0474
		public unsafe int SendPacketsSendSize
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000B22B4 File Offset: 0x000B04B4
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x000B22F0 File Offset: 0x000B04F0
		public unsafe SocketError SocketError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x000B2330 File Offset: 0x000B0530
		public unsafe SocketFlags SocketFlags
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_SocketFlags_Public_set_Void_SocketFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000B2370 File Offset: 0x000B0570
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x000B23B0 File Offset: 0x000B05B0
		public unsafe Object UserToken
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_UserToken_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000B23F4 File Offset: 0x000B05F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490545, RefRangeEnd = 490546, XrefRangeStart = 490540, XrefRangeEnd = 490545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Completed(EventHandler<SocketAsyncEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x000B2438 File Offset: 0x000B0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490546, XrefRangeEnd = 490551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Completed(EventHandler<SocketAsyncEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x000B247C File Offset: 0x000B067C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490560, RefRangeEnd = 490561, XrefRangeStart = 490551, XrefRangeEnd = 490560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000B24B8 File Offset: 0x000B06B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490570, RefRangeEnd = 490572, XrefRangeStart = 490561, XrefRangeEnd = 490570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketAsyncEventArgs(bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketAsyncEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flowExecutionContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x000B2500 File Offset: 0x000B0700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490572, XrefRangeEnd = 490575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAsyncEventArgs.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x000B253C File Offset: 0x000B073C
		[CallerCount(0)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000B257C File Offset: 0x000B077C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490575, XrefRangeEnd = 490580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000B25B0 File Offset: 0x000B07B0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBytesTransferred(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetBytesTransferred_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x000B25F0 File Offset: 0x000B07F0
		public unsafe Socket CurrentSocket
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_CurrentSocket_Internal_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x000B2630 File Offset: 0x000B0830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentSocket(Socket socket)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetCurrentSocket_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000B2674 File Offset: 0x000B0874
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 490582, RefRangeEnd = 490587, XrefRangeStart = 490580, XrefRangeEnd = 490582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLastOperation(SocketAsyncOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000B26B4 File Offset: 0x000B08B4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 490588, RefRangeEnd = 490612, XrefRangeStart = 490587, XrefRangeEnd = 490588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_Complete_internal_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x000B26E8 File Offset: 0x000B08E8
		[CallerCount(0)]
		public unsafe virtual void OnCompleted(SocketAsyncEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SocketAsyncEventArgs.NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000B2738 File Offset: 0x000B0938
		public unsafe Memory<byte> MemoryBuffer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_MemoryBuffer_Public_get_Memory_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Memory<byte>(intPtr);
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x000B2770 File Offset: 0x000B0970
		public unsafe int Offset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_Offset_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000B27AC File Offset: 0x000B09AC
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000B27E8 File Offset: 0x000B09E8
		public unsafe IList<ArraySegment<byte>> BufferList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr3) : null;
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x000B2828 File Offset: 0x000B0A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490612, XrefRangeEnd = 490618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBuffer(Memory<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(buffer));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketAsyncEventArgs.NativeMethodInfoPtr_SetBuffer_Public_Void_Memory_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00010994 File Offset: 0x0000EB94
		public SocketAsyncEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000B2870 File Offset: 0x000B0A70
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0001099D File Offset: 0x0000EB9D
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000B2898 File Offset: 0x000B0A98
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x000109B8 File Offset: 0x0000EBB8
		public unsafe int in_progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_in_progress)) = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000B28C0 File Offset: 0x000B0AC0
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x000109D3 File Offset: 0x0000EBD3
		public unsafe EndPoint remote_ep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_remote_ep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000B28F0 File Offset: 0x000B0AF0
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x000109F2 File Offset: 0x0000EBF2
		public unsafe Socket current_socket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_current_socket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060026CB RID: 9931 RVA: 0x000B2920 File Offset: 0x000B0B20
		// (set) Token: 0x060026CC RID: 9932 RVA: 0x00010A11 File Offset: 0x0000EC11
		public unsafe SocketAsyncResult socket_async_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketAsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_socket_async_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060026CD RID: 9933 RVA: 0x000B2950 File Offset: 0x000B0B50
		// (set) Token: 0x060026CE RID: 9934 RVA: 0x00010A30 File Offset: 0x0000EC30
		public unsafe Socket _AcceptSocket_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__AcceptSocket_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x000B2980 File Offset: 0x000B0B80
		// (set) Token: 0x060026D0 RID: 9936 RVA: 0x00010A4F File Offset: 0x0000EC4F
		public unsafe int _BytesTransferred_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__BytesTransferred_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060026D1 RID: 9937 RVA: 0x000B29A8 File Offset: 0x000B0BA8
		// (set) Token: 0x060026D2 RID: 9938 RVA: 0x00010A6A File Offset: 0x0000EC6A
		public unsafe SocketAsyncOperation _LastOperation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__LastOperation_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000B29D0 File Offset: 0x000B0BD0
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00010A85 File Offset: 0x0000EC85
		public unsafe int _SendPacketsSendSize_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x000B29F8 File Offset: 0x000B0BF8
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		public unsafe SocketError _SocketError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketError_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000B2A20 File Offset: 0x000B0C20
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00010ABB File Offset: 0x0000ECBB
		public unsafe SocketFlags _SocketFlags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__SocketFlags_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000B2A48 File Offset: 0x000B0C48
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x00010AD6 File Offset: 0x0000ECD6
		public unsafe Object _UserToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__UserToken_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000B2A78 File Offset: 0x000B0C78
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00010AF5 File Offset: 0x0000ECF5
		public unsafe EventHandler<SocketAsyncEventArgs> Completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<SocketAsyncEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr_Completed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x00010B14 File Offset: 0x0000ED14
		public Memory<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__buffer);
				return new Memory<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__buffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Memory<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000B2AD8 File Offset: 0x000B0CD8
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x00010B42 File Offset: 0x0000ED42
		public unsafe int _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000B2B00 File Offset: 0x000B0D00
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x00010B5D File Offset: 0x0000ED5D
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x000B2B28 File Offset: 0x000B0D28
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x00010B78 File Offset: 0x0000ED78
		public unsafe bool _bufferIsExplicitArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__bufferIsExplicitArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__bufferIsExplicitArray)) = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x000B2B50 File Offset: 0x000B0D50
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00010B93 File Offset: 0x0000ED93
		public unsafe IList<ArraySegment<byte>> _bufferList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__bufferList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ArraySegment<byte>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SocketAsyncEventArgs.NativeFieldInfoPtr__bufferList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeFieldInfoPtr_in_progress;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeFieldInfoPtr_remote_ep;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeFieldInfoPtr_current_socket;

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeFieldInfoPtr_socket_async_result;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeFieldInfoPtr__AcceptSocket_k__BackingField;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeFieldInfoPtr__BytesTransferred_k__BackingField;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeFieldInfoPtr__LastOperation_k__BackingField;

		// Token: 0x04001ED7 RID: 7895
		private static readonly IntPtr NativeFieldInfoPtr__SendPacketsSendSize_k__BackingField;

		// Token: 0x04001ED8 RID: 7896
		private static readonly IntPtr NativeFieldInfoPtr__SocketError_k__BackingField;

		// Token: 0x04001ED9 RID: 7897
		private static readonly IntPtr NativeFieldInfoPtr__SocketFlags_k__BackingField;

		// Token: 0x04001EDA RID: 7898
		private static readonly IntPtr NativeFieldInfoPtr__UserToken_k__BackingField;

		// Token: 0x04001EDB RID: 7899
		private static readonly IntPtr NativeFieldInfoPtr_Completed;

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeFieldInfoPtr__bufferIsExplicitArray;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr__bufferList;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptSocket_Public_get_Socket_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptSocket_Public_set_Void_Socket_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr_get_BytesTransferred_Public_get_Int32_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr_set_BytesTransferred_Private_set_Void_Int32_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr_set_LastOperation_Private_set_Void_SocketAsyncOperation_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_set_RemoteEndPoint_Public_set_Void_EndPoint_0;

		// Token: 0x04001EE7 RID: 7911
		private static readonly IntPtr NativeMethodInfoPtr_set_SendPacketsSendSize_Public_set_Void_Int32_0;

		// Token: 0x04001EE8 RID: 7912
		private static readonly IntPtr NativeMethodInfoPtr_get_SocketError_Public_get_SocketError_0;

		// Token: 0x04001EE9 RID: 7913
		private static readonly IntPtr NativeMethodInfoPtr_set_SocketError_Public_set_Void_SocketError_0;

		// Token: 0x04001EEA RID: 7914
		private static readonly IntPtr NativeMethodInfoPtr_set_SocketFlags_Public_set_Void_SocketFlags_0;

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr_get_UserToken_Public_get_Object_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_set_UserToken_Public_set_Void_Object_0;

		// Token: 0x04001EED RID: 7917
		private static readonly IntPtr NativeMethodInfoPtr_add_Completed_Public_add_Void_EventHandler_1_SocketAsyncEventArgs_0;

		// Token: 0x04001EEE RID: 7918
		private static readonly IntPtr NativeMethodInfoPtr_remove_Completed_Public_rem_Void_EventHandler_1_SocketAsyncEventArgs_0;

		// Token: 0x04001EEF RID: 7919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EF0 RID: 7920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04001EF1 RID: 7921
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001EF2 RID: 7922
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04001EF3 RID: 7923
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001EF4 RID: 7924
		private static readonly IntPtr NativeMethodInfoPtr_SetBytesTransferred_Internal_Void_Int32_0;

		// Token: 0x04001EF5 RID: 7925
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSocket_Internal_get_Socket_0;

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentSocket_Internal_Void_Socket_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_SetLastOperation_Internal_Void_SocketAsyncOperation_0;

		// Token: 0x04001EF8 RID: 7928
		private static readonly IntPtr NativeMethodInfoPtr_Complete_internal_Internal_Void_0;

		// Token: 0x04001EF9 RID: 7929
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Protected_Virtual_New_Void_SocketAsyncEventArgs_0;

		// Token: 0x04001EFA RID: 7930
		private static readonly IntPtr NativeMethodInfoPtr_get_MemoryBuffer_Public_get_Memory_1_Byte_0;

		// Token: 0x04001EFB RID: 7931
		private static readonly IntPtr NativeMethodInfoPtr_get_Offset_Public_get_Int32_0;

		// Token: 0x04001EFC RID: 7932
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001EFD RID: 7933
		private static readonly IntPtr NativeMethodInfoPtr_get_BufferList_Public_get_IList_1_ArraySegment_1_Byte_0;

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_Memory_1_Byte_0;
	}
}

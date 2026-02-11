using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000242 RID: 578
	public class TcpListener : Object
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x000B0A48 File Offset: 0x000AEC48
		// Note: this type is marked as 'beforefieldinit'.
		static TcpListener()
		{
			Il2CppClassPointerStore<TcpListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "TcpListener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TcpListener>.NativeClassPtr);
			TcpListener.NativeFieldInfoPtr_m_ServerSocketEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, "m_ServerSocketEP");
			TcpListener.NativeFieldInfoPtr_m_ServerSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, "m_ServerSocket");
			TcpListener.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, "m_Active");
			TcpListener.NativeFieldInfoPtr_m_ExclusiveAddressUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, "m_ExclusiveAddressUse");
			TcpListener.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669052);
			TcpListener.NativeMethodInfoPtr_get_LocalEndpoint_Public_get_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669053);
			TcpListener.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669054);
			TcpListener.NativeMethodInfoPtr_Start_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669055);
			TcpListener.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669056);
			TcpListener.NativeMethodInfoPtr_BeginAcceptTcpClient_Public_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669057);
			TcpListener.NativeMethodInfoPtr_EndAcceptTcpClient_Public_TcpClient_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669058);
			TcpListener.NativeMethodInfoPtr_AcceptTcpClientAsync_Public_Task_1_TcpClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpListener>.NativeClassPtr, 100669059);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000B0B68 File Offset: 0x000AED68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490076, RefRangeEnd = 490078, XrefRangeStart = 490046, XrefRangeEnd = 490076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TcpListener(IPAddress localaddr, int port)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TcpListener>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localaddr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x000B0BC4 File Offset: 0x000AEDC4
		public unsafe EndPoint LocalEndpoint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 490083, RefRangeEnd = 490086, XrefRangeStart = 490078, XrefRangeEnd = 490083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_get_LocalEndpoint_Public_get_EndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EndPoint>(intPtr3) : null;
			}
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000B0C04 File Offset: 0x000AEE04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 490087, RefRangeEnd = 490090, XrefRangeStart = 490086, XrefRangeEnd = 490087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000B0C38 File Offset: 0x000AEE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490146, RefRangeEnd = 490147, XrefRangeStart = 490090, XrefRangeEnd = 490146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(int backlog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref backlog;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_Start_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000B0C78 File Offset: 0x000AEE78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 490168, RefRangeEnd = 490172, XrefRangeStart = 490147, XrefRangeEnd = 490168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000B0CAC File Offset: 0x000AEEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490172, XrefRangeEnd = 490189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginAcceptTcpClient(AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_BeginAcceptTcpClient_Public_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000B0D10 File Offset: 0x000AEF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490189, XrefRangeEnd = 490201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TcpClient EndAcceptTcpClient(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_EndAcceptTcpClient_Public_TcpClient_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TcpClient>(intPtr3) : null;
			}
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000B0D60 File Offset: 0x000AEF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490219, RefRangeEnd = 490220, XrefRangeStart = 490201, XrefRangeEnd = 490219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TcpClient> AcceptTcpClientAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpListener.NativeMethodInfoPtr_AcceptTcpClientAsync_Public_Task_1_TcpClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TcpClient>>(intPtr3) : null;
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0001079B File Offset: 0x0000E99B
		public TcpListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000B0DA0 File Offset: 0x000AEFA0
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x000107A4 File Offset: 0x0000E9A4
		public unsafe IPEndPoint m_ServerSocketEP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ServerSocketEP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ServerSocketEP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06002661 RID: 9825 RVA: 0x000B0DD0 File Offset: 0x000AEFD0
		// (set) Token: 0x06002662 RID: 9826 RVA: 0x000107C3 File Offset: 0x0000E9C3
		public unsafe Socket m_ServerSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ServerSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ServerSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002663 RID: 9827 RVA: 0x000B0E00 File Offset: 0x000AF000
		// (set) Token: 0x06002664 RID: 9828 RVA: 0x000107E2 File Offset: 0x0000E9E2
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000B0E28 File Offset: 0x000AF028
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x000107FD File Offset: 0x0000E9FD
		public unsafe bool m_ExclusiveAddressUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ExclusiveAddressUse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpListener.NativeFieldInfoPtr_m_ExclusiveAddressUse)) = value;
			}
		}

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerSocketEP;

		// Token: 0x04001E9B RID: 7835
		private static readonly IntPtr NativeFieldInfoPtr_m_ServerSocket;

		// Token: 0x04001E9C RID: 7836
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04001E9D RID: 7837
		private static readonly IntPtr NativeFieldInfoPtr_m_ExclusiveAddressUse;

		// Token: 0x04001E9E RID: 7838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPAddress_Int32_0;

		// Token: 0x04001E9F RID: 7839
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalEndpoint_Public_get_EndPoint_0;

		// Token: 0x04001EA0 RID: 7840
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001EA1 RID: 7841
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Int32_0;

		// Token: 0x04001EA2 RID: 7842
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeMethodInfoPtr_BeginAcceptTcpClient_Public_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_EndAcceptTcpClient_Public_TcpClient_IAsyncResult_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_AcceptTcpClientAsync_Public_Task_1_TcpClient_0;
	}
}

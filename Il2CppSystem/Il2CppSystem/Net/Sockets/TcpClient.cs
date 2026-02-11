using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000241 RID: 577
	public class TcpClient : Object
	{
		// Token: 0x0600263A RID: 9786 RVA: 0x000B0370 File Offset: 0x000AE570
		// Note: this type is marked as 'beforefieldinit'.
		static TcpClient()
		{
			Il2CppClassPointerStore<TcpClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "TcpClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TcpClient>.NativeClassPtr);
			TcpClient.NativeFieldInfoPtr_m_ClientSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, "m_ClientSocket");
			TcpClient.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, "m_Active");
			TcpClient.NativeFieldInfoPtr_m_DataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, "m_DataStream");
			TcpClient.NativeFieldInfoPtr_m_Family = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, "m_Family");
			TcpClient.NativeFieldInfoPtr_m_CleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, "m_CleanedUp");
			TcpClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669037);
			TcpClient.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669038);
			TcpClient.NativeMethodInfoPtr__ctor_Internal_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669039);
			TcpClient.NativeMethodInfoPtr_get_Client_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669040);
			TcpClient.NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669041);
			TcpClient.NativeMethodInfoPtr_Connect_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669042);
			TcpClient.NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669043);
			TcpClient.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669044);
			TcpClient.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669045);
			TcpClient.NativeMethodInfoPtr_ConnectAsync_Public_Task_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669046);
			TcpClient.NativeMethodInfoPtr_GetStream_Public_NetworkStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669047);
			TcpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669048);
			TcpClient.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669049);
			TcpClient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669050);
			TcpClient.NativeMethodInfoPtr_initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TcpClient>.NativeClassPtr, 100669051);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000B0530 File Offset: 0x000AE730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 489888, RefRangeEnd = 489890, XrefRangeStart = 489878, XrefRangeEnd = 489888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TcpClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TcpClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000B056C File Offset: 0x000AE76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489890, XrefRangeEnd = 489913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TcpClient(AddressFamily family)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TcpClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000B05B4 File Offset: 0x000AE7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489913, XrefRangeEnd = 489917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TcpClient(Socket acceptedSocket)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TcpClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptedSocket);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr__ctor_Internal_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x000B0600 File Offset: 0x000AE800
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x000B0640 File Offset: 0x000AE840
		public unsafe Socket Client
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_get_Client_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000B0684 File Offset: 0x000AE884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489966, RefRangeEnd = 489967, XrefRangeStart = 489917, XrefRangeEnd = 489966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(string hostname, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hostname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_Connect_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000B06D4 File Offset: 0x000AE8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 489985, RefRangeEnd = 489986, XrefRangeStart = 489967, XrefRangeEnd = 489985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(IPEndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000B0718 File Offset: 0x000AE918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489986, XrefRangeEnd = 489989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000B079C File Offset: 0x000AE99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489989, XrefRangeEnd = 489993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndConnect(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000B07E0 File Offset: 0x000AE9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490015, RefRangeEnd = 490016, XrefRangeStart = 489993, XrefRangeEnd = 490015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ConnectAsync(string host, int port)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_ConnectAsync_Public_Task_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000B0840 File Offset: 0x000AEA40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 490023, RefRangeEnd = 490027, XrefRangeStart = 490016, XrefRangeEnd = 490023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkStream GetStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_GetStream_Public_NetworkStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr3) : null;
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000B0880 File Offset: 0x000AEA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490027, XrefRangeEnd = 490041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TcpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000B08CC File Offset: 0x000AEACC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 451127, RefRangeEnd = 451138, XrefRangeStart = 451127, XrefRangeEnd = 451138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000B0900 File Offset: 0x000AEB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TcpClient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000B093C File Offset: 0x000AEB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490041, XrefRangeEnd = 490046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TcpClient.NativeMethodInfoPtr_initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x00010703 File Offset: 0x0000E903
		public TcpClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x000B0970 File Offset: 0x000AEB70
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x0001070C File Offset: 0x0000E90C
		public unsafe Socket m_ClientSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_ClientSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_ClientSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x0001072B File Offset: 0x0000E92B
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x000B09C8 File Offset: 0x000AEBC8
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x00010746 File Offset: 0x0000E946
		public unsafe NetworkStream m_DataStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_DataStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_DataStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x000B09F8 File Offset: 0x000AEBF8
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x00010765 File Offset: 0x0000E965
		public unsafe AddressFamily m_Family
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_Family);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_Family)) = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x000B0A20 File Offset: 0x000AEC20
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x00010780 File Offset: 0x0000E980
		public unsafe bool m_CleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_CleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TcpClient.NativeFieldInfoPtr_m_CleanedUp)) = value;
			}
		}

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeFieldInfoPtr_m_ClientSocket;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04001E88 RID: 7816
		private static readonly IntPtr NativeFieldInfoPtr_m_DataStream;

		// Token: 0x04001E89 RID: 7817
		private static readonly IntPtr NativeFieldInfoPtr_m_Family;

		// Token: 0x04001E8A RID: 7818
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanedUp;

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0;

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Socket_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_get_Socket_0;

		// Token: 0x04001E8F RID: 7823
		private static readonly IntPtr NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0;

		// Token: 0x04001E90 RID: 7824
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_String_Int32_0;

		// Token: 0x04001E91 RID: 7825
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0;

		// Token: 0x04001E92 RID: 7826
		private static readonly IntPtr NativeMethodInfoPtr_BeginConnect_Public_IAsyncResult_String_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E93 RID: 7827
		private static readonly IntPtr NativeMethodInfoPtr_EndConnect_Public_Void_IAsyncResult_0;

		// Token: 0x04001E94 RID: 7828
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Public_Task_String_Int32_0;

		// Token: 0x04001E95 RID: 7829
		private static readonly IntPtr NativeMethodInfoPtr_GetStream_Public_NetworkStream_0;

		// Token: 0x04001E96 RID: 7830
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Private_Void_0;
	}
}

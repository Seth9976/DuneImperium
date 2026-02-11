using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000243 RID: 579
	public class UdpClient : Object
	{
		// Token: 0x06002667 RID: 9831 RVA: 0x000B0E50 File Offset: 0x000AF050
		// Note: this type is marked as 'beforefieldinit'.
		static UdpClient()
		{
			Il2CppClassPointerStore<UdpClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "UdpClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UdpClient>.NativeClassPtr);
			UdpClient.NativeFieldInfoPtr_m_ClientSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_ClientSocket");
			UdpClient.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_Active");
			UdpClient.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_Buffer");
			UdpClient.NativeFieldInfoPtr_m_Family = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_Family");
			UdpClient.NativeFieldInfoPtr_m_CleanedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_CleanedUp");
			UdpClient.NativeFieldInfoPtr_m_IsBroadcast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, "m_IsBroadcast");
			UdpClient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669060);
			UdpClient.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669061);
			UdpClient.NativeMethodInfoPtr_get_Client_Public_get_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669062);
			UdpClient.NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669063);
			UdpClient.NativeMethodInfoPtr_FreeResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669064);
			UdpClient.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669065);
			UdpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669066);
			UdpClient.NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669067);
			UdpClient.NativeMethodInfoPtr_CheckForBroadcast_Private_Void_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669068);
			UdpClient.NativeMethodInfoPtr_IsBroadcast_Private_Static_Boolean_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669069);
			UdpClient.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_IPEndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669070);
			UdpClient.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669071);
			UdpClient.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669072);
			UdpClient.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669073);
			UdpClient.NativeMethodInfoPtr_EndReceive_Public_Il2CppStructArray_1_Byte_IAsyncResult_byref_IPEndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669074);
			UdpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669075);
			UdpClient.NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_UdpReceiveResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669076);
			UdpClient.NativeMethodInfoPtr_createClientSocket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669077);
			UdpClient.NativeMethodInfoPtr__ReceiveAsync_b__65_0_Private_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669078);
			UdpClient.NativeMethodInfoPtr__ReceiveAsync_b__65_1_Private_UdpReceiveResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UdpClient>.NativeClassPtr, 100669079);
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000B1088 File Offset: 0x000AF288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490230, RefRangeEnd = 490231, XrefRangeStart = 490220, XrefRangeEnd = 490230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UdpClient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpClient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000B10C4 File Offset: 0x000AF2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490231, XrefRangeEnd = 490256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UdpClient(AddressFamily family)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UdpClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref family;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x000B110C File Offset: 0x000AF30C
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x000B114C File Offset: 0x000AF34C
		public unsafe Socket Client
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_get_Client_Public_get_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x000B1190 File Offset: 0x000AF390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490256, XrefRangeEnd = 490259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_FreeResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x000B11C4 File Offset: 0x000AF3C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 451127, RefRangeEnd = 451138, XrefRangeStart = 451127, XrefRangeEnd = 451138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490259, XrefRangeEnd = 490266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UdpClient.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x000B1244 File Offset: 0x000AF444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490268, RefRangeEnd = 490269, XrefRangeStart = 490266, XrefRangeEnd = 490268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Connect(IPEndPoint endPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x000B1288 File Offset: 0x000AF488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 490275, RefRangeEnd = 490277, XrefRangeStart = 490269, XrefRangeEnd = 490275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForBroadcast(IPAddress ipAddress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_CheckForBroadcast_Private_Void_IPAddress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x000B12CC File Offset: 0x000AF4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490277, XrefRangeEnd = 490282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBroadcast(IPAddress address)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(address);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_IsBroadcast_Private_Static_Boolean_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x000B1310 File Offset: 0x000AF510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490285, RefRangeEnd = 490286, XrefRangeStart = 490282, XrefRangeEnd = 490285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> datagram, int bytes, IPEndPoint endPoint, AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datagram);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endPoint);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_IPEndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000B13A8 File Offset: 0x000AF5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490286, XrefRangeEnd = 490287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginSend(Il2CppStructArray<byte> datagram, int bytes, AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datagram);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x000B142C File Offset: 0x000AF62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490287, XrefRangeEnd = 490298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EndSend(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x000B147C File Offset: 0x000AF67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490298, XrefRangeEnd = 490306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReceive(AsyncCallback requestCallback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestCallback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x000B14E0 File Offset: 0x000AF6E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490328, RefRangeEnd = 490329, XrefRangeStart = 490306, XrefRangeEnd = 490328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> EndReceive(IAsyncResult asyncResult, ref IPEndPoint remoteEP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_EndReceive_Public_Il2CppStructArray_1_Byte_IAsyncResult_byref_IPEndPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			remoteEP = ((intPtr4 == 0) ? null : new IPEndPoint(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr5) : null;
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x000B155C File Offset: 0x000AF75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490347, RefRangeEnd = 490348, XrefRangeStart = 490329, XrefRangeEnd = 490347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> SendAsync(Il2CppStructArray<byte> datagram, int bytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datagram);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_SendAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000B15BC File Offset: 0x000AF7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 490366, RefRangeEnd = 490367, XrefRangeStart = 490348, XrefRangeEnd = 490366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<UdpReceiveResult> ReceiveAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_UdpReceiveResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<UdpReceiveResult>>(intPtr3) : null;
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x000B15FC File Offset: 0x000AF7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490367, XrefRangeEnd = 490372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void createClientSocket()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr_createClientSocket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x000B1630 File Offset: 0x000AF830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult _ReceiveAsync_b__65_0(AsyncCallback callback, Object state)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr__ReceiveAsync_b__65_0_Private_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600267B RID: 9851 RVA: 0x000B1694 File Offset: 0x000AF894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490372, XrefRangeEnd = 490374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UdpReceiveResult _ReceiveAsync_b__65_1(IAsyncResult ar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ar);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UdpClient.NativeMethodInfoPtr__ReceiveAsync_b__65_1_Private_UdpReceiveResult_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new UdpReceiveResult(intPtr);
			}
		}

		// Token: 0x0600267C RID: 9852 RVA: 0x00010818 File Offset: 0x0000EA18
		public UdpClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x000B16DC File Offset: 0x000AF8DC
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x00010821 File Offset: 0x0000EA21
		public unsafe Socket m_ClientSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_ClientSocket);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Socket>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_ClientSocket), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x000B170C File Offset: 0x000AF90C
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x00010840 File Offset: 0x0000EA40
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x000B1734 File Offset: 0x000AF934
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x0001085B File Offset: 0x0000EA5B
		public unsafe Il2CppStructArray<byte> m_Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x000B1764 File Offset: 0x000AF964
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x0001087A File Offset: 0x0000EA7A
		public unsafe AddressFamily m_Family
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Family);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_Family)) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000B178C File Offset: 0x000AF98C
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x00010895 File Offset: 0x0000EA95
		public unsafe bool m_CleanedUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_CleanedUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_CleanedUp)) = value;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x000B17B4 File Offset: 0x000AF9B4
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x000108B0 File Offset: 0x0000EAB0
		public unsafe bool m_IsBroadcast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_IsBroadcast);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UdpClient.NativeFieldInfoPtr_m_IsBroadcast)) = value;
			}
		}

		// Token: 0x04001EA6 RID: 7846
		private static readonly IntPtr NativeFieldInfoPtr_m_ClientSocket;

		// Token: 0x04001EA7 RID: 7847
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04001EA8 RID: 7848
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x04001EA9 RID: 7849
		private static readonly IntPtr NativeFieldInfoPtr_m_Family;

		// Token: 0x04001EAA RID: 7850
		private static readonly IntPtr NativeFieldInfoPtr_m_CleanedUp;

		// Token: 0x04001EAB RID: 7851
		private static readonly IntPtr NativeFieldInfoPtr_m_IsBroadcast;

		// Token: 0x04001EAC RID: 7852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressFamily_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_get_Socket_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly IntPtr NativeMethodInfoPtr_set_Client_Public_set_Void_Socket_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly IntPtr NativeMethodInfoPtr_FreeResources_Private_Void_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Void_IPEndPoint_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr_CheckForBroadcast_Private_Void_IPAddress_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_IsBroadcast_Private_Static_Boolean_IPAddress_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_IPEndPoint_AsyncCallback_Object_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_BeginSend_Public_IAsyncResult_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr_EndSend_Public_Int32_IAsyncResult_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_BeginReceive_Public_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly IntPtr NativeMethodInfoPtr_EndReceive_Public_Il2CppStructArray_1_Byte_IAsyncResult_byref_IPEndPoint_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeMethodInfoPtr_SendAsync_Public_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveAsync_Public_Task_1_UdpReceiveResult_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_createClientSocket_Private_Void_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsync_b__65_0_Private_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly IntPtr NativeMethodInfoPtr__ReceiveAsync_b__65_1_Private_UdpReceiveResult_IAsyncResult_0;
	}
}

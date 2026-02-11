using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200009B RID: 155
	public class ISocketManager : Il2CppObjectBase
	{
		// Token: 0x06000858 RID: 2136 RVA: 0x000425C8 File Offset: 0x000407C8
		// Note: this type is marked as 'beforefieldinit'.
		static ISocketManager()
		{
			Il2CppClassPointerStore<ISocketManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISocketManager");
			ISocketManager.NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocketManager>.NativeClassPtr, 100665296);
			ISocketManager.NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocketManager>.NativeClassPtr, 100665297);
			ISocketManager.NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocketManager>.NativeClassPtr, 100665298);
			ISocketManager.NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISocketManager>.NativeClassPtr, 100665299);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00042640 File Offset: 0x00040840
		[CallerCount(0)]
		public unsafe virtual void OnConnecting(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocketManager.NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000426A0 File Offset: 0x000408A0
		[CallerCount(0)]
		public unsafe virtual void OnConnected(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocketManager.NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00042700 File Offset: 0x00040900
		[CallerCount(0)]
		public unsafe virtual void OnDisconnected(Connection connection, ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocketManager.NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00042760 File Offset: 0x00040960
		[CallerCount(0)]
		public unsafe virtual void OnMessage(Connection connection, NetIdentity identity, IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connection;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref identity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageNum;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recvTime;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISocketManager.NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000025D7 File Offset: 0x000007D7
		public ISocketManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_Connection_ConnectionInfo_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_Connection_NetIdentity_IntPtr_Int32_Int64_Int64_Int32_0;
	}
}

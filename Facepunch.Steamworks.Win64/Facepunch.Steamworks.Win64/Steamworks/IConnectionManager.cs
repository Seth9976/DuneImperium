using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200009A RID: 154
	public class IConnectionManager : Il2CppObjectBase
	{
		// Token: 0x06000852 RID: 2130 RVA: 0x000423D0 File Offset: 0x000405D0
		// Note: this type is marked as 'beforefieldinit'.
		static IConnectionManager()
		{
			Il2CppClassPointerStore<IConnectionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "IConnectionManager");
			IConnectionManager.NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConnectionManager>.NativeClassPtr, 100665292);
			IConnectionManager.NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConnectionManager>.NativeClassPtr, 100665293);
			IConnectionManager.NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConnectionManager>.NativeClassPtr, 100665294);
			IConnectionManager.NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConnectionManager>.NativeClassPtr, 100665295);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00042448 File Offset: 0x00040648
		[CallerCount(0)]
		public unsafe virtual void OnConnecting(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConnectionManager.NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0004249C File Offset: 0x0004069C
		[CallerCount(0)]
		public unsafe virtual void OnConnected(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConnectionManager.NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000424F0 File Offset: 0x000406F0
		[CallerCount(0)]
		public unsafe virtual void OnDisconnected(ConnectionInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(info));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConnectionManager.NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00042544 File Offset: 0x00040744
		[CallerCount(0)]
		public unsafe virtual void OnMessage(IntPtr data, int size, long messageNum, long recvTime, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recvTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IConnectionManager.NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000025CE File Offset: 0x000007CE
		public IConnectionManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_OnConnecting_Public_Abstract_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Public_Abstract_Virtual_New_Void_ConnectionInfo_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_OnMessage_Public_Abstract_Virtual_New_Void_IntPtr_Int32_Int64_Int64_Int32_0;
	}
}

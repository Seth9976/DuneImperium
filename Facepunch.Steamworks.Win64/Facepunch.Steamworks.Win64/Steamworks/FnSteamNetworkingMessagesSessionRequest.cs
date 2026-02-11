using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000097 RID: 151
	public sealed class FnSteamNetworkingMessagesSessionRequest : MulticastDelegate
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x00041E2C File Offset: 0x0004002C
		// Note: this type is marked as 'beforefieldinit'.
		static FnSteamNetworkingMessagesSessionRequest()
		{
			Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "FnSteamNetworkingMessagesSessionRequest");
			FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr, 100665280);
			FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr, 100665281);
			FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingMessagesSessionRequest_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr, 100665282);
			FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr, 100665283);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00041EA4 File Offset: 0x000400A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FnSteamNetworkingMessagesSessionRequest(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FnSteamNetworkingMessagesSessionRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00041F00 File Offset: 0x00040100
		[CallerCount(0)]
		public unsafe void Invoke(ref SteamNetworkingMessagesSessionRequest_t arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arg;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00041F40 File Offset: 0x00040140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936969, XrefRangeEnd = 936973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref SteamNetworkingMessagesSessionRequest_t arg, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingMessagesSessionRequest_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00041FB0 File Offset: 0x000401B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref SteamNetworkingMessagesSessionRequest_t arg, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &arg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingMessagesSessionRequest.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000025B3 File Offset: 0x000007B3
		public FnSteamNetworkingMessagesSessionRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingMessagesSessionRequest_t_AsyncCallback_Object_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingMessagesSessionRequest_t_IAsyncResult_0;
	}
}

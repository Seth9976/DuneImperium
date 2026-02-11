using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000099 RID: 153
	public sealed class FnSteamNetworkingFakeIPResult : MulticastDelegate
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x000421E8 File Offset: 0x000403E8
		// Note: this type is marked as 'beforefieldinit'.
		static FnSteamNetworkingFakeIPResult()
		{
			Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "FnSteamNetworkingFakeIPResult");
			FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr, 100665288);
			FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr, 100665289);
			FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingFakeIPResult_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr, 100665290);
			FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr, 100665291);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00042260 File Offset: 0x00040460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FnSteamNetworkingFakeIPResult(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FnSteamNetworkingFakeIPResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000422BC File Offset: 0x000404BC
		[CallerCount(0)]
		public unsafe void Invoke(ref SteamNetworkingFakeIPResult_t arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00042300 File Offset: 0x00040500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936977, XrefRangeEnd = 936981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref SteamNetworkingFakeIPResult_t arg, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingFakeIPResult_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00042378 File Offset: 0x00040578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref SteamNetworkingFakeIPResult_t arg, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetworkingFakeIPResult.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000025C5 File Offset: 0x000007C5
		public FnSteamNetworkingFakeIPResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetworkingFakeIPResult_t_AsyncCallback_Object_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetworkingFakeIPResult_t_IAsyncResult_0;
	}
}

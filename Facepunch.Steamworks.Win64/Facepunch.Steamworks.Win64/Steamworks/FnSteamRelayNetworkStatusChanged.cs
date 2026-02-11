using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000096 RID: 150
	public sealed class FnSteamRelayNetworkStatusChanged : MulticastDelegate
	{
		// Token: 0x0600083A RID: 2106 RVA: 0x00041C44 File Offset: 0x0003FE44
		// Note: this type is marked as 'beforefieldinit'.
		static FnSteamRelayNetworkStatusChanged()
		{
			Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "FnSteamRelayNetworkStatusChanged");
			FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr, 100665276);
			FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr, 100665277);
			FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamRelayNetworkStatus_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr, 100665278);
			FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr, 100665279);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00041CBC File Offset: 0x0003FEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FnSteamRelayNetworkStatusChanged(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FnSteamRelayNetworkStatusChanged>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00041D18 File Offset: 0x0003FF18
		[CallerCount(0)]
		public unsafe void Invoke(ref SteamRelayNetworkStatus_t arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00041D5C File Offset: 0x0003FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936965, XrefRangeEnd = 936969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref SteamRelayNetworkStatus_t arg, AsyncCallback callback, Object @object)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamRelayNetworkStatus_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00041DD4 File Offset: 0x0003FFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref SteamRelayNetworkStatus_t arg, IAsyncResult result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamRelayNetworkStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000025AA File Offset: 0x000007AA
		public FnSteamRelayNetworkStatusChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamRelayNetworkStatus_t_AsyncCallback_Object_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamRelayNetworkStatus_t_IAsyncResult_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000094 RID: 148
	public sealed class FnSteamNetConnectionStatusChanged : MulticastDelegate
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00041874 File Offset: 0x0003FA74
		// Note: this type is marked as 'beforefieldinit'.
		static FnSteamNetConnectionStatusChanged()
		{
			Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "FnSteamNetConnectionStatusChanged");
			FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr, 100665268);
			FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr, 100665269);
			FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetConnectionStatusChangedCallback_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr, 100665270);
			FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr, 100665271);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000418EC File Offset: 0x0003FAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936952, XrefRangeEnd = 936956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FnSteamNetConnectionStatusChanged(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FnSteamNetConnectionStatusChanged>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00041948 File Offset: 0x0003FB48
		[CallerCount(0)]
		public unsafe void Invoke(ref SteamNetConnectionStatusChangedCallback_t arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0004198C File Offset: 0x0003FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936956, XrefRangeEnd = 936960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref SteamNetConnectionStatusChangedCallback_t arg, AsyncCallback callback, Object @object)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetConnectionStatusChangedCallback_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00041A04 File Offset: 0x0003FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936960, XrefRangeEnd = 936961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref SteamNetConnectionStatusChangedCallback_t arg, IAsyncResult result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetConnectionStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002598 File Offset: 0x00000798
		public FnSteamNetConnectionStatusChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetConnectionStatusChangedCallback_t_AsyncCallback_Object_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetConnectionStatusChangedCallback_t_IAsyncResult_0;
	}
}

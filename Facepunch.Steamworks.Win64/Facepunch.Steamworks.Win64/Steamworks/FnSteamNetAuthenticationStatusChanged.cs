using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000095 RID: 149
	public sealed class FnSteamNetAuthenticationStatusChanged : MulticastDelegate
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00041A5C File Offset: 0x0003FC5C
		// Note: this type is marked as 'beforefieldinit'.
		static FnSteamNetAuthenticationStatusChanged()
		{
			Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "FnSteamNetAuthenticationStatusChanged");
			FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr, 100665272);
			FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr, 100665273);
			FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetAuthenticationStatus_t_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr, 100665274);
			FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr, 100665275);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00041AD4 File Offset: 0x0003FCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FnSteamNetAuthenticationStatusChanged(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FnSteamNetAuthenticationStatusChanged>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00041B30 File Offset: 0x0003FD30
		[CallerCount(0)]
		public unsafe void Invoke(ref SteamNetAuthenticationStatus_t arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(arg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00041B74 File Offset: 0x0003FD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936961, XrefRangeEnd = 936965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref SteamNetAuthenticationStatus_t arg, AsyncCallback callback, Object @object)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetAuthenticationStatus_t_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00041BEC File Offset: 0x0003FDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref SteamNetAuthenticationStatus_t arg, IAsyncResult result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FnSteamNetAuthenticationStatusChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000025A1 File Offset: 0x000007A1
		public FnSteamNetAuthenticationStatusChanged(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_SteamNetAuthenticationStatus_t_AsyncCallback_Object_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_SteamNetAuthenticationStatus_t_IAsyncResult_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Steamworks
{
	// Token: 0x020000A3 RID: 163
	public class SteamMatchmakingServers : SteamClientClass<SteamMatchmakingServers>
	{
		// Token: 0x06000989 RID: 2441 RVA: 0x00047008 File Offset: 0x00045208
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMatchmakingServers()
		{
			Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamMatchmakingServers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr);
			SteamMatchmakingServers.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100665652);
			SteamMatchmakingServers.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100665653);
			SteamMatchmakingServers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr, 100665654);
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00047074 File Offset: 0x00045274
		public unsafe static ISteamMatchmakingServers Internal
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 940644, RefRangeEnd = 940661, XrefRangeStart = 940641, XrefRangeEnd = 940644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamMatchmakingServers>(intPtr3) : null;
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000470A8 File Offset: 0x000452A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940661, XrefRangeEnd = 940665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamMatchmakingServers.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000470F4 File Offset: 0x000452F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940665, XrefRangeEnd = 940668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamMatchmakingServers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMatchmakingServers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmakingServers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002960 File Offset: 0x00000B60
		public SteamMatchmakingServers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001083 RID: 4227
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMatchmakingServers_0;

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

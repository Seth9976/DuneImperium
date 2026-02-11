using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000009 RID: 9
	public static class SteamGameServer : Object
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServer()
		{
			Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamGameServer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr);
			SteamGameServer.NativeMethodInfoPtr_RunCallbacks_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100663354);
			SteamGameServer.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100663355);
			SteamGameServer.NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, 100663356);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000F93C File Offset: 0x0000DB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_RunCallbacks_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000F964 File Offset: 0x0000DB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930934, RefRangeEnd = 930935, XrefRangeStart = 930934, XrefRangeEnd = 930935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000F98C File Offset: 0x0000DB8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930937, RefRangeEnd = 930938, XrefRangeStart = 930937, XrefRangeEnd = 930938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe GetHSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002234 File Offset: 0x00000434
		public SteamGameServer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Internal_Static_Void_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0;

		// Token: 0x02000219 RID: 537
		public static class Native : Object
		{
			// Token: 0x06001AFF RID: 6911 RVA: 0x00080B60 File Offset: 0x0007ED60
			// Note: this type is marked as 'beforefieldinit'.
			static Native()
			{
				Il2CppClassPointerStore<SteamGameServer.Native>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamGameServer>.NativeClassPtr, "Native");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServer.Native>.NativeClassPtr);
				SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_RunCallbacks_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer.Native>.NativeClassPtr, 100663357);
				SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer.Native>.NativeClassPtr, 100663358);
				SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServer.Native>.NativeClassPtr, 100663359);
			}

			// Token: 0x06001B00 RID: 6912 RVA: 0x00080BC8 File Offset: 0x0007EDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930930, XrefRangeEnd = 930932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void SteamGameServer_RunCallbacks()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_RunCallbacks_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B01 RID: 6913 RVA: 0x00080BF0 File Offset: 0x0007EDF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930934, RefRangeEnd = 930935, XrefRangeStart = 930932, XrefRangeEnd = 930934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void SteamGameServer_Shutdown()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x00080C18 File Offset: 0x0007EE18
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930937, RefRangeEnd = 930938, XrefRangeStart = 930935, XrefRangeEnd = 930937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static HSteamPipe SteamGameServer_GetHSteamPipe()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServer.Native.NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B03 RID: 6915 RVA: 0x00008E8E File Offset: 0x0000708E
			public Native(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FD4 RID: 8148
			private static readonly IntPtr NativeMethodInfoPtr_SteamGameServer_RunCallbacks_Public_Static_Void_0;

			// Token: 0x04001FD5 RID: 8149
			private static readonly IntPtr NativeMethodInfoPtr_SteamGameServer_Shutdown_Public_Static_Void_0;

			// Token: 0x04001FD6 RID: 8150
			private static readonly IntPtr NativeMethodInfoPtr_SteamGameServer_GetHSteamPipe_Public_Static_HSteamPipe_0;
		}
	}
}

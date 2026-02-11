using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x02000008 RID: 8
	public static class SteamAPI : Object
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000F788 File Offset: 0x0000D988
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPI()
		{
			Il2CppClassPointerStore<SteamAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamAPI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr);
			SteamAPI.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663346);
			SteamAPI.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663347);
			SteamAPI.NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663348);
			SteamAPI.NativeMethodInfoPtr_RestartAppIfNecessary_Internal_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, 100663349);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000F808 File Offset: 0x0000DA08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930920, RefRangeEnd = 930921, XrefRangeStart = 930920, XrefRangeEnd = 930921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_Init_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000F838 File Offset: 0x0000DA38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930923, RefRangeEnd = 930924, XrefRangeStart = 930923, XrefRangeEnd = 930924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000F860 File Offset: 0x0000DA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930926, RefRangeEnd = 930927, XrefRangeStart = 930926, XrefRangeEnd = 930927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamPipe GetHSteamPipe()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000F890 File Offset: 0x0000DA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930929, RefRangeEnd = 930930, XrefRangeStart = 930929, XrefRangeEnd = 930930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RestartAppIfNecessary(uint unOwnAppID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unOwnAppID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.NativeMethodInfoPtr_RestartAppIfNecessary_Internal_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000222B File Offset: 0x0000042B
		public SteamAPI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Static_Boolean_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamPipe_Internal_Static_HSteamPipe_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_RestartAppIfNecessary_Internal_Static_Boolean_UInt32_0;

		// Token: 0x02000218 RID: 536
		public static class Native : Object
		{
			// Token: 0x06001AF9 RID: 6905 RVA: 0x00080A1C File Offset: 0x0007EC1C
			// Note: this type is marked as 'beforefieldinit'.
			static Native()
			{
				Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamAPI>.NativeClassPtr, "Native");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr);
				SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr, 100663350);
				SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr, 100663351);
				SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr, 100663352);
				SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI.Native>.NativeClassPtr, 100663353);
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x00080A98 File Offset: 0x0007EC98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930920, RefRangeEnd = 930921, XrefRangeStart = 930918, XrefRangeEnd = 930920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool SteamAPI_Init()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AFB RID: 6907 RVA: 0x00080AC8 File Offset: 0x0007ECC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930923, RefRangeEnd = 930924, XrefRangeStart = 930921, XrefRangeEnd = 930923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void SteamAPI_Shutdown()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFC RID: 6908 RVA: 0x00080AF0 File Offset: 0x0007ECF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930926, RefRangeEnd = 930927, XrefRangeStart = 930924, XrefRangeEnd = 930926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static HSteamPipe SteamAPI_GetHSteamPipe()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AFD RID: 6909 RVA: 0x00080B20 File Offset: 0x0007ED20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930929, RefRangeEnd = 930930, XrefRangeStart = 930927, XrefRangeEnd = 930929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool SteamAPI_RestartAppIfNecessary(uint unOwnAppID)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unOwnAppID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI.Native.NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AFE RID: 6910 RVA: 0x00008E85 File Offset: 0x00007085
			public Native(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FD0 RID: 8144
			private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_Init_Public_Static_Boolean_0;

			// Token: 0x04001FD1 RID: 8145
			private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_Shutdown_Public_Static_Void_0;

			// Token: 0x04001FD2 RID: 8146
			private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_GetHSteamPipe_Public_Static_HSteamPipe_0;

			// Token: 0x04001FD3 RID: 8147
			private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_RestartAppIfNecessary_Public_Static_Boolean_UInt32_0;
		}
	}
}

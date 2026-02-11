using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200000A RID: 10
	public static class SteamInternal : Object
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000223D File Offset: 0x0000043D
		// Note: this type is marked as 'beforefieldinit'.
		static SteamInternal()
		{
			Il2CppClassPointerStore<SteamInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInternal>.NativeClassPtr);
			SteamInternal.NativeMethodInfoPtr_GameServer_Init_Internal_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInternal>.NativeClassPtr, 100663360);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000F9BC File Offset: 0x0000DBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 930941, RefRangeEnd = 930942, XrefRangeStart = 930941, XrefRangeEnd = 930942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usGamePort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eServerMode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersionString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInternal.NativeMethodInfoPtr_GameServer_Init_Internal_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002276 File Offset: 0x00000476
		public SteamInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GameServer_Init_Internal_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0;

		// Token: 0x0200021A RID: 538
		public static class Native : Object
		{
			// Token: 0x06001B04 RID: 6916 RVA: 0x00008E97 File Offset: 0x00007097
			// Note: this type is marked as 'beforefieldinit'.
			static Native()
			{
				Il2CppClassPointerStore<SteamInternal.Native>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamInternal>.NativeClassPtr, "Native");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamInternal.Native>.NativeClassPtr);
				SteamInternal.Native.NativeMethodInfoPtr_SteamInternal_GameServer_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamInternal.Native>.NativeClassPtr, 100663361);
			}

			// Token: 0x06001B05 RID: 6917 RVA: 0x00080C48 File Offset: 0x0007EE48
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 930941, RefRangeEnd = 930942, XrefRangeStart = 930938, XrefRangeEnd = 930941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool SteamInternal_GameServer_Init(uint unIP, ushort usPort, ushort usGamePort, ushort usQueryPort, int eServerMode, string pchVersionString)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref unIP;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPort;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usGamePort;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usQueryPort;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eServerMode;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchVersionString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamInternal.Native.NativeMethodInfoPtr_SteamInternal_GameServer_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B06 RID: 6918 RVA: 0x00008ECB File Offset: 0x000070CB
			public Native(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001FD7 RID: 8151
			private static readonly IntPtr NativeMethodInfoPtr_SteamInternal_GameServer_Init_Public_Static_Boolean_UInt32_UInt16_UInt16_UInt16_Int32_String_0;
		}
	}
}

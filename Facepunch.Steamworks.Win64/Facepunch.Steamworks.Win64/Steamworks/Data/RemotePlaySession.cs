using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000208 RID: 520
	[StructLayout(2)]
	public struct RemotePlaySession
	{
		// Token: 0x06001A09 RID: 6665 RVA: 0x0007D6C0 File Offset: 0x0007B8C0
		// Note: this type is marked as 'beforefieldinit'.
		static RemotePlaySession()
		{
			Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemotePlaySession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr);
			RemotePlaySession.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, "<Id>k__BackingField");
			RemotePlaySession.NativeMethodInfoPtr_get_Id_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668046);
			RemotePlaySession.NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668047);
			RemotePlaySession.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668048);
			RemotePlaySession.NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySession_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668049);
			RemotePlaySession.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668050);
			RemotePlaySession.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668051);
			RemotePlaySession.NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668052);
			RemotePlaySession.NativeMethodInfoPtr_get_ClientName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668053);
			RemotePlaySession.NativeMethodInfoPtr_get_FormFactor_Public_get_SteamDeviceFormFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, 100668054);
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0007D7B8 File Offset: 0x0007B9B8
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x0007D7E8 File Offset: 0x0007B9E8
		public unsafe uint Id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_get_Id_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0007D81C File Offset: 0x0007BA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951576, RefRangeEnd = 951577, XrefRangeStart = 951576, XrefRangeEnd = 951577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0007D848 File Offset: 0x0007BA48
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RemotePlaySession(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySession_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0007D888 File Offset: 0x0007BA88
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(RemotePlaySession value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySession_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0007D8C8 File Offset: 0x0007BAC8
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0007D8F8 File Offset: 0x0007BAF8
		public unsafe SteamId SteamId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952761, XrefRangeEnd = 952765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0007D928 File Offset: 0x0007BB28
		public unsafe string ClientName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952765, XrefRangeEnd = 952769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_get_ClientName_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x0007D954 File Offset: 0x0007BB54
		public unsafe SteamDeviceFormFactor FormFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952769, XrefRangeEnd = 952773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySession.NativeMethodInfoPtr_get_FormFactor_Public_get_SteamDeviceFormFactor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000087F4 File Offset: 0x000069F4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemotePlaySession>.NativeClassPtr, ref this));
		}

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_UInt32_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySession_UInt32_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySession_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_get_SteamId_Public_get_SteamId_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientName_Public_get_String_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr_get_FormFactor_Public_get_SteamDeviceFormFactor_0;

		// Token: 0x04001F31 RID: 7985
		[FieldOffset(0)]
		public uint _Id_k__BackingField;
	}
}

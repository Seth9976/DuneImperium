using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B7 RID: 439
	public sealed class SteamDatagramHostedAddress : ValueType
	{
		// Token: 0x06001642 RID: 5698 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramHostedAddress()
		{
			Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamDatagramHostedAddress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr);
			SteamDatagramHostedAddress.NativeFieldInfoPtr_CbSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, "CbSize");
			SteamDatagramHostedAddress.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, "Data");
			SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, 100667405);
			SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalGetPopID_Internal_Static_SteamNetworkingPOPID_byref_SteamDatagramHostedAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, 100667406);
			SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalSetDevAddress_Internal_Static_Void_byref_SteamDatagramHostedAddress_UInt32_UInt16_SteamNetworkingPOPID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, 100667407);
			SteamDatagramHostedAddress.NativeMethodInfoPtr_DataUTF8_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr, 100667408);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0006E498 File Offset: 0x0006C698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951141, XrefRangeEnd = 951145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalClear(ref SteamDatagramHostedAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_SteamDatagramHostedAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0006E4D0 File Offset: 0x0006C6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951145, XrefRangeEnd = 951149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamNetworkingPOPID InternalGetPopID(ref SteamDatagramHostedAddress self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalGetPopID_Internal_Static_SteamNetworkingPOPID_byref_SteamDatagramHostedAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0006E514 File Offset: 0x0006C714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951149, XrefRangeEnd = 951153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetDevAddress(ref SteamDatagramHostedAddress self, uint nIP, ushort nPort, SteamNetworkingPOPID popid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref popid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramHostedAddress.NativeMethodInfoPtr_InternalSetDevAddress_Internal_Static_Void_byref_SteamDatagramHostedAddress_UInt32_UInt16_SteamNetworkingPOPID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0006E578 File Offset: 0x0006C778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951153, XrefRangeEnd = 951157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DataUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamDatagramHostedAddress.NativeMethodInfoPtr_DataUTF8_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000076AB File Offset: 0x000058AB
		public SteamDatagramHostedAddress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000076B4 File Offset: 0x000058B4
		public SteamDatagramHostedAddress()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamDatagramHostedAddress>.NativeClassPtr))
		{
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0006E5B4 File Offset: 0x0006C7B4
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x000076C6 File Offset: 0x000058C6
		public unsafe int CbSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_CbSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_CbSize)) = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0006E5DC File Offset: 0x0006C7DC
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x000076E1 File Offset: 0x000058E1
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamDatagramHostedAddress.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr_CbSize;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_InternalClear_Internal_Static_Void_byref_SteamDatagramHostedAddress_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetPopID_Internal_Static_SteamNetworkingPOPID_byref_SteamDatagramHostedAddress_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetDevAddress_Internal_Static_Void_byref_SteamDatagramHostedAddress_UInt32_UInt16_SteamNetworkingPOPID_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_DataUTF8_Internal_String_0;
	}
}

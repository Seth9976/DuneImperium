using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001BE RID: 446
	[StructLayout(2)]
	public struct SteamPartyBeaconLocation_t
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x000700E4 File Offset: 0x0006E2E4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamPartyBeaconLocation_t()
		{
			Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamPartyBeaconLocation_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr);
			SteamPartyBeaconLocation_t.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, "Type");
			SteamPartyBeaconLocation_t.NativeFieldInfoPtr_LocationID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, "LocationID");
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0000776C File Offset: 0x0000596C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamPartyBeaconLocation_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeFieldInfoPtr_LocationID;

		// Token: 0x04001C15 RID: 7189
		[FieldOffset(0)]
		public SteamPartyBeaconLocationType Type;

		// Token: 0x04001C16 RID: 7190
		[FieldOffset(8)]
		public ulong LocationID;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F5 RID: 501
	[StructLayout(2)]
	public struct SteamDatagramRelayAuthTicket
	{
		// Token: 0x06001930 RID: 6448 RVA: 0x00008290 File Offset: 0x00006490
		// Note: this type is marked as 'beforefieldinit'.
		static SteamDatagramRelayAuthTicket()
		{
			Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamDatagramRelayAuthTicket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000082B5 File Offset: 0x000064B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamDatagramRelayAuthTicket>.NativeClassPtr, ref this));
		}
	}
}

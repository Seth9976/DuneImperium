using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000207 RID: 519
	public sealed class P2Packet : ValueType
	{
		// Token: 0x06001A02 RID: 6658 RVA: 0x0007D610 File Offset: 0x0007B810
		// Note: this type is marked as 'beforefieldinit'.
		static P2Packet()
		{
			Il2CppClassPointerStore<P2Packet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "P2Packet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<P2Packet>.NativeClassPtr);
			P2Packet.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2Packet>.NativeClassPtr, "SteamId");
			P2Packet.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<P2Packet>.NativeClassPtr, "Data");
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000879F File Offset: 0x0000699F
		public P2Packet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x000087A8 File Offset: 0x000069A8
		public P2Packet()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<P2Packet>.NativeClassPtr))
		{
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0007D668 File Offset: 0x0007B868
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x000087BA File Offset: 0x000069BA
		public unsafe SteamId SteamId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(P2Packet.NativeFieldInfoPtr_SteamId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(P2Packet.NativeFieldInfoPtr_SteamId)) = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0007D690 File Offset: 0x0007B890
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x000087D5 File Offset: 0x000069D5
		public unsafe Il2CppStructArray<byte> Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(P2Packet.NativeFieldInfoPtr_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(P2Packet.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeFieldInfoPtr_SteamId;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_Data;
	}
}

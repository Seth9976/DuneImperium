using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C4 RID: 452
	[StructLayout(2)]
	public struct SteamItemDetails_t
	{
		// Token: 0x060016E5 RID: 5861 RVA: 0x00070B50 File Offset: 0x0006ED50
		// Note: this type is marked as 'beforefieldinit'.
		static SteamItemDetails_t()
		{
			Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamItemDetails_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr);
			SteamItemDetails_t.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "ItemId");
			SteamItemDetails_t.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "Definition");
			SteamItemDetails_t.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "Quantity");
			SteamItemDetails_t.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, "Flags");
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00007AB3 File Offset: 0x00005CB3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamItemDetails_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeFieldInfoPtr_ItemId;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_Definition;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x04001C5C RID: 7260
		[FieldOffset(0)]
		public InventoryItemId ItemId;

		// Token: 0x04001C5D RID: 7261
		[FieldOffset(8)]
		public InventoryDefId Definition;

		// Token: 0x04001C5E RID: 7262
		[FieldOffset(12)]
		public ushort Quantity;

		// Token: 0x04001C5F RID: 7263
		[FieldOffset(14)]
		public ushort Flags;
	}
}

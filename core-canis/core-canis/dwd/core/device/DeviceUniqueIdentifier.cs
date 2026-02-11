using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.device
{
	// Token: 0x020001C0 RID: 448
	public static class DeviceUniqueIdentifier : Object
	{
		// Token: 0x06001918 RID: 6424 RVA: 0x00077B6C File Offset: 0x00075D6C
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceUniqueIdentifier()
		{
			Il2CppClassPointerStore<DeviceUniqueIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.device", "DeviceUniqueIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceUniqueIdentifier>.NativeClassPtr);
			DeviceUniqueIdentifier.NativeFieldInfoPtr_PREF_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceUniqueIdentifier>.NativeClassPtr, "PREF_KEY");
			DeviceUniqueIdentifier.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceUniqueIdentifier>.NativeClassPtr, "id");
			DeviceUniqueIdentifier.NativeMethodInfoPtr_get_ID_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceUniqueIdentifier>.NativeClassPtr, 100667285);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00077BD8 File Offset: 0x00075DD8
		public unsafe static string ID
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 880929, RefRangeEnd = 880946, XrefRangeStart = 880900, XrefRangeEnd = 880929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceUniqueIdentifier.NativeMethodInfoPtr_get_ID_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0000B08F File Offset: 0x0000928F
		public DeviceUniqueIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x00077C04 File Offset: 0x00075E04
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000B098 File Offset: 0x00009298
		public unsafe static string PREF_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeviceUniqueIdentifier.NativeFieldInfoPtr_PREF_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceUniqueIdentifier.NativeFieldInfoPtr_PREF_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x00077C24 File Offset: 0x00075E24
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000B0AA File Offset: 0x000092AA
		public unsafe static string id
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeviceUniqueIdentifier.NativeFieldInfoPtr_id, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeviceUniqueIdentifier.NativeFieldInfoPtr_id, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_PREF_KEY;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Static_get_String_0;
	}
}

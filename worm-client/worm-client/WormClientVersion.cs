using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200002B RID: 43
public static class WormClientVersion : Object
{
	// Token: 0x060001ED RID: 493 RVA: 0x00002E50 File Offset: 0x00001050
	// Note: this type is marked as 'beforefieldinit'.
	static WormClientVersion()
	{
		Il2CppClassPointerStore<WormClientVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormClientVersion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormClientVersion>.NativeClassPtr);
		WormClientVersion.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormClientVersion>.NativeClassPtr, "Version");
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00002E89 File Offset: 0x00001089
	public WormClientVersion(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0001EFFC File Offset: 0x0001D1FC
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002E92 File Offset: 0x00001092
	public unsafe static string Version
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(WormClientVersion.NativeFieldInfoPtr_Version, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(WormClientVersion.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeFieldInfoPtr_Version;
}

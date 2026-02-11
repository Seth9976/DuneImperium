using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.canis.data.enums
{
	// Token: 0x020000D7 RID: 215
	public static class Notifications : Object
	{
		// Token: 0x06000E17 RID: 3607 RVA: 0x000076EA File Offset: 0x000058EA
		// Note: this type is marked as 'beforefieldinit'.
		static Notifications()
		{
			Il2CppClassPointerStore<Notifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.enums", "Notifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Notifications>.NativeClassPtr);
			Notifications.NativeFieldInfoPtr_YourTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Notifications>.NativeClassPtr, "YourTurn");
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00007723 File Offset: 0x00005923
		public Notifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00097E08 File Offset: 0x00096008
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0000772C File Offset: 0x0000592C
		public unsafe static string YourTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Notifications.NativeFieldInfoPtr_YourTurn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Notifications.NativeFieldInfoPtr_YourTurn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr_YourTurn;
	}
}

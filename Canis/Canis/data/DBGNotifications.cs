using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000152 RID: 338
	public static class DBGNotifications : Object
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x000077E9 File Offset: 0x000059E9
		// Note: this type is marked as 'beforefieldinit'.
		static DBGNotifications()
		{
			Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGNotifications");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr);
			DBGNotifications.NativeFieldInfoPtr_YourTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGNotifications>.NativeClassPtr, "YourTurn");
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00007822 File Offset: 0x00005A22
		public DBGNotifications(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x00058074 File Offset: 0x00056274
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x0000782B File Offset: 0x00005A2B
		public unsafe static string YourTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGNotifications.NativeFieldInfoPtr_YourTurn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGNotifications.NativeFieldInfoPtr_YourTurn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_YourTurn;
	}
}

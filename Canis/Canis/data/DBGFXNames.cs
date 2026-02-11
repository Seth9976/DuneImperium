using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000155 RID: 341
	public static class DBGFXNames : Object
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x00007906 File Offset: 0x00005B06
		// Note: this type is marked as 'beforefieldinit'.
		static DBGFXNames()
		{
			Il2CppClassPointerStore<DBGFXNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGFXNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGFXNames>.NativeClassPtr);
			DBGFXNames.NativeFieldInfoPtr_PresentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGFXNames>.NativeClassPtr, "PresentEntity");
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000793F File Offset: 0x00005B3F
		public DBGFXNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x0005830C File Offset: 0x0005650C
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00007948 File Offset: 0x00005B48
		public unsafe static string PresentEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGFXNames.NativeFieldInfoPtr_PresentEntity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGFXNames.NativeFieldInfoPtr_PresentEntity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeFieldInfoPtr_PresentEntity;
	}
}

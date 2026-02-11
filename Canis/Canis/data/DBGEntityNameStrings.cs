using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000151 RID: 337
	public static class DBGEntityNameStrings : Object
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x00007795 File Offset: 0x00005995
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntityNameStrings()
		{
			Il2CppClassPointerStore<DBGEntityNameStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGEntityNameStrings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityNameStrings>.NativeClassPtr);
			DBGEntityNameStrings.NativeFieldInfoPtr_SelectionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityNameStrings>.NativeClassPtr, "SelectionFilter");
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000077CE File Offset: 0x000059CE
		public DBGEntityNameStrings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00058054 File Offset: 0x00056254
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x000077D7 File Offset: 0x000059D7
		public unsafe static string SelectionFilter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGEntityNameStrings.NativeFieldInfoPtr_SelectionFilter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGEntityNameStrings.NativeFieldInfoPtr_SelectionFilter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_SelectionFilter;
	}
}

using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000018 RID: 24
	public static class Options : Object
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00002282 File Offset: 0x00000482
		// Note: this type is marked as 'beforefieldinit'.
		static Options()
		{
			Il2CppClassPointerStore<Options>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "Options");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Options>.NativeClassPtr);
			Options.NativeFieldInfoPtr_DefaultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Options>.NativeClassPtr, "DefaultName");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022BB File Offset: 0x000004BB
		public Options(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003B7C File Offset: 0x00001D7C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022C4 File Offset: 0x000004C4
		public unsafe static string DefaultName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Options.NativeFieldInfoPtr_DefaultName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Options.NativeFieldInfoPtr_DefaultName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_DefaultName;
	}
}

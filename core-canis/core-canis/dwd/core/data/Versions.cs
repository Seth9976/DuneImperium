using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001CE RID: 462
	public static class Versions : Object
	{
		// Token: 0x0600198D RID: 6541 RVA: 0x00079750 File Offset: 0x00077950
		// Note: this type is marked as 'beforefieldinit'.
		static Versions()
		{
			Il2CppClassPointerStore<Versions>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "Versions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Versions>.NativeClassPtr);
			Versions.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Versions>.NativeClassPtr, "None");
			Versions.NativeFieldInfoPtr_Initial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Versions>.NativeClassPtr, "Initial");
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0000B2FE File Offset: 0x000094FE
		public Versions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x000797A8 File Offset: 0x000779A8
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0000B307 File Offset: 0x00009507
		public unsafe static ulong None
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(Versions.NativeFieldInfoPtr_None, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Versions.NativeFieldInfoPtr_None, (void*)(&value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x000797C4 File Offset: 0x000779C4
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0000B315 File Offset: 0x00009515
		public unsafe static ulong Initial
		{
			get
			{
				ulong num;
				IL2CPP.il2cpp_field_static_get_value(Versions.NativeFieldInfoPtr_Initial, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Versions.NativeFieldInfoPtr_Initial, (void*)(&value));
			}
		}

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeFieldInfoPtr_Initial;
	}
}

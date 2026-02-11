using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001BF RID: 447
	[StructLayout(2)]
	public struct SteamParamStringArray_t
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x0007013C File Offset: 0x0006E33C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamParamStringArray_t()
		{
			Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamParamStringArray_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr);
			SteamParamStringArray_t.NativeFieldInfoPtr_Strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "Strings");
			SteamParamStringArray_t.NativeFieldInfoPtr_NumStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, "NumStrings");
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0000777E File Offset: 0x0000597E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamParamStringArray_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeFieldInfoPtr_Strings;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr_NumStrings;

		// Token: 0x04001C19 RID: 7193
		[FieldOffset(0)]
		public IntPtr Strings;

		// Token: 0x04001C1A RID: 7194
		[FieldOffset(8)]
		public int NumStrings;
	}
}

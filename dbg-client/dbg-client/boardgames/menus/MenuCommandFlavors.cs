using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.menus
{
	// Token: 0x020001A6 RID: 422
	public static class MenuCommandFlavors : Object
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x0005A398 File Offset: 0x00058598
		// Note: this type is marked as 'beforefieldinit'.
		static MenuCommandFlavors()
		{
			Il2CppClassPointerStore<MenuCommandFlavors>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "MenuCommandFlavors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenuCommandFlavors>.NativeClassPtr);
			MenuCommandFlavors.NativeFieldInfoPtr_UIScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCommandFlavors>.NativeClassPtr, "UIScale");
			MenuCommandFlavors.NativeFieldInfoPtr_PostMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCommandFlavors>.NativeClassPtr, "PostMatch");
			MenuCommandFlavors.NativeFieldInfoPtr_DailyChallengePostMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MenuCommandFlavors>.NativeClassPtr, "DailyChallengePostMatch");
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0000ADD1 File Offset: 0x00008FD1
		public MenuCommandFlavors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0005A404 File Offset: 0x00058604
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0000ADDA File Offset: 0x00008FDA
		public unsafe static string UIScale
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MenuCommandFlavors.NativeFieldInfoPtr_UIScale, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuCommandFlavors.NativeFieldInfoPtr_UIScale, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0005A424 File Offset: 0x00058624
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0000ADEC File Offset: 0x00008FEC
		public unsafe static string PostMatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MenuCommandFlavors.NativeFieldInfoPtr_PostMatch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuCommandFlavors.NativeFieldInfoPtr_PostMatch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x0005A444 File Offset: 0x00058644
		// (set) Token: 0x060012D6 RID: 4822 RVA: 0x0000ADFE File Offset: 0x00008FFE
		public unsafe static string DailyChallengePostMatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MenuCommandFlavors.NativeFieldInfoPtr_DailyChallengePostMatch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MenuCommandFlavors.NativeFieldInfoPtr_DailyChallengePostMatch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeFieldInfoPtr_UIScale;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeFieldInfoPtr_PostMatch;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengePostMatch;
	}
}

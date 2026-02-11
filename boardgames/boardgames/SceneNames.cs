using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames
{
	// Token: 0x02000102 RID: 258
	public static class SceneNames : Object
	{
		// Token: 0x06000C62 RID: 3170 RVA: 0x00038878 File Offset: 0x00036A78
		// Note: this type is marked as 'beforefieldinit'.
		static SceneNames()
		{
			Il2CppClassPointerStore<SceneNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "SceneNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneNames>.NativeClassPtr);
			SceneNames.NativeFieldInfoPtr_Menus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Menus");
			SceneNames.NativeFieldInfoPtr_Menus_Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Menus_Base");
			SceneNames.NativeFieldInfoPtr_Menus_Phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Menus_Phone");
			SceneNames.NativeFieldInfoPtr_Playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat");
			SceneNames.NativeFieldInfoPtr_Playmat_Base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat_Base");
			SceneNames.NativeFieldInfoPtr_Playmat_Phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat_Phone");
			SceneNames.NativeFieldInfoPtr_Playmat_SteamDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat_SteamDeck");
			SceneNames.NativeFieldInfoPtr_Playmat_Solo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat_Solo");
			SceneNames.NativeFieldInfoPtr_Playmat_Solo_Phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Playmat_Solo_Phone");
			SceneNames.NativeFieldInfoPtr_Loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Loading");
			SceneNames.NativeFieldInfoPtr_EmptyScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "EmptyScene");
			SceneNames.NativeFieldInfoPtr_Main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Main");
			SceneNames.NativeFieldInfoPtr_Splash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "Splash");
			SceneNames.NativeFieldInfoPtr_PhoneExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "PhoneExtension");
			SceneNames.NativeFieldInfoPtr_TabletExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, "TabletExtension");
			SceneNames.NativeMethodInfoPtr_WithPhoneExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, 100665273);
			SceneNames.NativeMethodInfoPtr_WithTabletExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneNames>.NativeClassPtr, 100665274);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000389FC File Offset: 0x00036BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995650, RefRangeEnd = 995652, XrefRangeStart = 995647, XrefRangeEnd = 995650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WithPhoneExtension(this string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneNames.NativeMethodInfoPtr_WithPhoneExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00038A38 File Offset: 0x00036C38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995674, RefRangeEnd = 995676, XrefRangeStart = 995652, XrefRangeEnd = 995674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string WithTabletExtension(this string sceneName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneNames.NativeMethodInfoPtr_WithTabletExtension_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00007B0C File Offset: 0x00005D0C
		public SceneNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00038A74 File Offset: 0x00036C74
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00007B15 File Offset: 0x00005D15
		public unsafe static string Menus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Menus, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Menus, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00038A94 File Offset: 0x00036C94
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00007B27 File Offset: 0x00005D27
		public unsafe static string Menus_Base
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Menus_Base, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Menus_Base, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00038AB4 File Offset: 0x00036CB4
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00007B39 File Offset: 0x00005D39
		public unsafe static string Menus_Phone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Menus_Phone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Menus_Phone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00038AD4 File Offset: 0x00036CD4
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00007B4B File Offset: 0x00005D4B
		public unsafe static string Playmat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00038AF4 File Offset: 0x00036CF4
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00007B5D File Offset: 0x00005D5D
		public unsafe static string Playmat_Base
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat_Base, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat_Base, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00038B14 File Offset: 0x00036D14
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00007B6F File Offset: 0x00005D6F
		public unsafe static string Playmat_Phone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat_Phone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat_Phone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00038B34 File Offset: 0x00036D34
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00007B81 File Offset: 0x00005D81
		public unsafe static string Playmat_SteamDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat_SteamDeck, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat_SteamDeck, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00038B54 File Offset: 0x00036D54
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00007B93 File Offset: 0x00005D93
		public unsafe static string Playmat_Solo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat_Solo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat_Solo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00038B74 File Offset: 0x00036D74
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public unsafe static string Playmat_Solo_Phone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Playmat_Solo_Phone, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Playmat_Solo_Phone, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00038B94 File Offset: 0x00036D94
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00007BB7 File Offset: 0x00005DB7
		public unsafe static string Loading
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Loading, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Loading, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00038BB4 File Offset: 0x00036DB4
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00007BC9 File Offset: 0x00005DC9
		public unsafe static string EmptyScene
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_EmptyScene, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_EmptyScene, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00038BD4 File Offset: 0x00036DD4
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00007BDB File Offset: 0x00005DDB
		public unsafe static string Main
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Main, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Main, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x00038BF4 File Offset: 0x00036DF4
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00007BED File Offset: 0x00005DED
		public unsafe static string Splash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_Splash, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_Splash, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00038C14 File Offset: 0x00036E14
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x00007BFF File Offset: 0x00005DFF
		public unsafe static string PhoneExtension
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_PhoneExtension, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_PhoneExtension, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00038C34 File Offset: 0x00036E34
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00007C11 File Offset: 0x00005E11
		public unsafe static string TabletExtension
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneNames.NativeFieldInfoPtr_TabletExtension, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneNames.NativeFieldInfoPtr_TabletExtension, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeFieldInfoPtr_Menus;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeFieldInfoPtr_Menus_Base;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeFieldInfoPtr_Menus_Phone;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeFieldInfoPtr_Playmat;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_Playmat_Base;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_Playmat_Phone;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_Playmat_SteamDeck;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_Playmat_Solo;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_Playmat_Solo_Phone;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_Loading;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_EmptyScene;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_Main;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeFieldInfoPtr_Splash;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeFieldInfoPtr_PhoneExtension;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeFieldInfoPtr_TabletExtension;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_WithPhoneExtension_Public_Static_String_String_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr_WithTabletExtension_Public_Static_String_String_0;
	}
}

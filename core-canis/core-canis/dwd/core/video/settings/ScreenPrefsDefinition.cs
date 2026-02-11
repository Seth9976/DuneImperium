using System;
using dwd.core.settings;
using dwd.core.settings.playerPrefs;
using dwd.core.settings.playerPrefs.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.video.settings
{
	// Token: 0x02000086 RID: 134
	public class ScreenPrefsDefinition : PrefDefinition<ScreenSettings>
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x000392AC File Offset: 0x000374AC
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenPrefsDefinition()
		{
			Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.video.settings", "ScreenPrefsDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr);
			ScreenPrefsDefinition.NativeFieldInfoPtr_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, "KEY");
			ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664667);
			ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ScreenSettings_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664668);
			ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ISetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664669);
			ScreenPrefsDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664670);
			ScreenPrefsDefinition.NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664671);
			ScreenPrefsDefinition.NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664672);
			ScreenPrefsDefinition.NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664673);
			ScreenPrefsDefinition.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, 100664674);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00039390 File Offset: 0x00037590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862132, XrefRangeEnd = 862137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenPrefsDefinition(ScreenResolution resolution, bool isWindowed, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resolution;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindowed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000393F8 File Offset: 0x000375F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862137, XrefRangeEnd = 862142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenPrefsDefinition(ScreenSettings defaultValue, ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ScreenSettings_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00039454 File Offset: 0x00037654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862142, XrefRangeEnd = 862151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenPrefsDefinition(ISetting<string> namespaceSetting = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceSetting);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr__ctor_Public_Void_ISetting_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000394A0 File Offset: 0x000376A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862151, XrefRangeEnd = 862202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<ScreenSettings> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenPrefsDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenSettings>>(intPtr3) : null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000394EC File Offset: 0x000376EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862202, XrefRangeEnd = 862229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGet(string key, out ScreenSettings value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0003953C File Offset: 0x0003773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862229, XrefRangeEnd = 862250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Store(string key, ScreenSettings value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00039580 File Offset: 0x00037780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862250, XrefRangeEnd = 862258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetKeys(string key, out string rezKey, out string isWinKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			rezKey = IL2CPP.Il2CppStringToManaged(intPtr);
			isWinKey = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000395EC File Offset: 0x000377EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862258, XrefRangeEnd = 862280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenPrefsDefinition.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00005799 File Offset: 0x00003999
		public ScreenPrefsDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00039624 File Offset: 0x00037824
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x000057A2 File Offset: 0x000039A2
		public unsafe static string KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScreenPrefsDefinition.NativeFieldInfoPtr_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScreenPrefsDefinition.NativeFieldInfoPtr_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr_KEY;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScreenResolution_Boolean_ISetting_1_String_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ScreenSettings_ISetting_1_String_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISetting_1_String_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenSettings_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenSettings_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenSettings_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x02000288 RID: 648
		[ObfuscatedName("dwd.core.video.settings.ScreenPrefsDefinition+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001F32 RID: 7986 RVA: 0x0008E044 File Offset: 0x0008C244
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ScreenPrefsDefinition.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenPrefsDefinition>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenPrefsDefinition.__O>.NativeClassPtr);
				ScreenPrefsDefinition.__O.NativeFieldInfoPtr__0___TryGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPrefsDefinition.__O>.NativeClassPtr, "<0>__TryGet");
				ScreenPrefsDefinition.__O.NativeFieldInfoPtr__1___Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPrefsDefinition.__O>.NativeClassPtr, "<1>__Store");
				ScreenPrefsDefinition.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenPrefsDefinition.__O>.NativeClassPtr, "<2>__DeleteKey");
			}

			// Token: 0x06001F33 RID: 7987 RVA: 0x0000D48D File Offset: 0x0000B68D
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088E RID: 2190
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x0008E0AC File Offset: 0x0008C2AC
			// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000D496 File Offset: 0x0000B696
			public unsafe static PrefSetting<ScreenSettings>.Load _0___TryGet
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__0___TryGet, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenSettings>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__0___TryGet, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0008E0D4 File Offset: 0x0008C2D4
			// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
			public unsafe static PrefSetting<ScreenSettings>.Store _1___Store
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__1___Store, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenSettings>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__1___Store, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0008E0FC File Offset: 0x0008C2FC
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x0000D4BA File Offset: 0x0000B6BA
			public unsafe static PrefSetting<ScreenSettings>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenSettings>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenPrefsDefinition.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeFieldInfoPtr__0___TryGet;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeFieldInfoPtr__1___Store;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;
		}
	}
}

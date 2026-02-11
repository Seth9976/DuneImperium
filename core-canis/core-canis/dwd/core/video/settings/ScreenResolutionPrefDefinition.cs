using System;
using dwd.core.settings.playerPrefs;
using dwd.core.settings.playerPrefs.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.video.settings
{
	// Token: 0x02000087 RID: 135
	public class ScreenResolutionPrefDefinition : PrefDefinition<ScreenResolution>
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00039644 File Offset: 0x00037844
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenResolutionPrefDefinition()
		{
			Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.video.settings", "ScreenResolutionPrefDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664675);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664676);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664677);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664678);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664679);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664680);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664681);
			ScreenResolutionPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, 100664682);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00039714 File Offset: 0x00037914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862280, XrefRangeEnd = 862283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScreenResolutionPrefDefinition(string key, bool isAccountSetting, ScreenResolution defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAccountSetting;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0003977C File Offset: 0x0003797C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862283, XrefRangeEnd = 862360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PrefSetting<ScreenResolution> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScreenResolutionPrefDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenResolution_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenResolution>>(intPtr3) : null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000397C8 File Offset: 0x000379C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862360, XrefRangeEnd = 862373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGet(string key, out ScreenResolution resolution)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00039818 File Offset: 0x00037A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862373, XrefRangeEnd = 862385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Store(string key, ScreenResolution resolution)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resolution;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0003985C File Offset: 0x00037A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862385, XrefRangeEnd = 862393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetKeys(string key, out string xKey, out string yKey)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			xKey = IL2CPP.Il2CppStringToManaged(intPtr);
			yKey = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000398C8 File Offset: 0x00037AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862393, XrefRangeEnd = 862405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00039900 File Offset: 0x00037B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862405, XrefRangeEnd = 862411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenResolutionPrefDefinition UserPref(string key, ScreenResolution defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_UserPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenResolutionPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00039954 File Offset: 0x00037B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862411, XrefRangeEnd = 862417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenResolutionPrefDefinition SystemPref(string key, ScreenResolution defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenResolutionPrefDefinition.NativeMethodInfoPtr_SystemPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScreenResolutionPrefDefinition>(intPtr3) : null;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x000057B4 File Offset: 0x000039B4
		public ScreenResolutionPrefDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_ScreenResolution_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_PrefSetting_1_ScreenResolution_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_TryGet_Public_Static_Boolean_String_byref_ScreenResolution_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Static_Void_String_ScreenResolution_0;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeMethodInfoPtr_GetKeys_Private_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_UserPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_SystemPref_Public_Static_ScreenResolutionPrefDefinition_String_ScreenResolution_0;

		// Token: 0x02000289 RID: 649
		[ObfuscatedName("dwd.core.video.settings.ScreenResolutionPrefDefinition+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001F3A RID: 7994 RVA: 0x0008E124 File Offset: 0x0008C324
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ScreenResolutionPrefDefinition.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenResolutionPrefDefinition>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenResolutionPrefDefinition.__O>.NativeClassPtr);
				ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__0___TryGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionPrefDefinition.__O>.NativeClassPtr, "<0>__TryGet");
				ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__1___Store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionPrefDefinition.__O>.NativeClassPtr, "<1>__Store");
				ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__2___DeleteKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenResolutionPrefDefinition.__O>.NativeClassPtr, "<2>__DeleteKey");
			}

			// Token: 0x06001F3B RID: 7995 RVA: 0x0000D4CC File Offset: 0x0000B6CC
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0008E18C File Offset: 0x0008C38C
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000D4D5 File Offset: 0x0000B6D5
			public unsafe static PrefSetting<ScreenResolution>.Load _0___TryGet
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__0___TryGet, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenResolution>.Load>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__0___TryGet, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0008E1B4 File Offset: 0x0008C3B4
			// (set) Token: 0x06001F3F RID: 7999 RVA: 0x0000D4E7 File Offset: 0x0000B6E7
			public unsafe static PrefSetting<ScreenResolution>.Store _1___Store
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__1___Store, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenResolution>.Store>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__1___Store, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0008E1DC File Offset: 0x0008C3DC
			// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0000D4F9 File Offset: 0x0000B6F9
			public unsafe static PrefSetting<ScreenResolution>.DeleteKey _2___DeleteKey
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__2___DeleteKey, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefSetting<ScreenResolution>.DeleteKey>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScreenResolutionPrefDefinition.__O.NativeFieldInfoPtr__2___DeleteKey, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr__0___TryGet;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeFieldInfoPtr__1___Store;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeFieldInfoPtr__2___DeleteKey;
		}
	}
}

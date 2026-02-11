using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Localization;

namespace localization.bridge
{
	// Token: 0x02000004 RID: 4
	public static class UnityLocalizationUtil : Object
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002062 File Offset: 0x00000262
		// Note: this type is marked as 'beforefieldinit'.
		static UnityLocalizationUtil()
		{
			Il2CppClassPointerStore<UnityLocalizationUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization-bridge.dll", "localization.bridge", "UnityLocalizationUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLocalizationUtil>.NativeClassPtr);
			UnityLocalizationUtil.NativeMethodInfoPtr_SetLocale_Public_Static_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLocalizationUtil>.NativeClassPtr, 100663301);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002380 File Offset: 0x00000580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1275166, RefRangeEnd = 1275167, XrefRangeStart = 1275139, XrefRangeEnd = 1275166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLocale(TextLocalization.Locale locale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref locale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLocalizationUtil.NativeMethodInfoPtr_SetLocale_Public_Static_Void_Locale_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000209B File Offset: 0x0000029B
		public UnityLocalizationUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_SetLocale_Public_Static_Void_Locale_0;

		// Token: 0x02000007 RID: 7
		[ObfuscatedName("localization.bridge.UnityLocalizationUtil+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600001F RID: 31 RVA: 0x000025A4 File Offset: 0x000007A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityLocalizationUtil>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr);
				UnityLocalizationUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_localeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr, "localeString");
				UnityLocalizationUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr, 100663302);
				UnityLocalizationUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__SetLocale_b__0_Internal_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr, 100663303);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x0000260C File Offset: 0x0000080C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityLocalizationUtil.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLocalizationUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00002648 File Offset: 0x00000848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275137, XrefRangeEnd = 1275139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetLocale_b__0(UnityEngine.Localization.Locale f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityLocalizationUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__SetLocale_b__0_Internal_Boolean_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00002173 File Offset: 0x00000373
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000023 RID: 35 RVA: 0x00002698 File Offset: 0x00000898
			// (set) Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000037C
			public unsafe string localeString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityLocalizationUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_localeString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityLocalizationUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_localeString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400000D RID: 13
			private static readonly IntPtr NativeFieldInfoPtr_localeString;

			// Token: 0x0400000E RID: 14
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400000F RID: 15
			private static readonly IntPtr NativeMethodInfoPtr__SetLocale_b__0_Internal_Boolean_Locale_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using localization;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001C0 RID: 448
	public class LocaleDropdown : MonoBehaviour
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x0005EBB8 File Offset: 0x0005CDB8
		// Note: this type is marked as 'beforefieldinit'.
		static LocaleDropdown()
		{
			Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "LocaleDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr);
			LocaleDropdown.NativeFieldInfoPtr_localeDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, "localeDropdown");
			LocaleDropdown.NativeFieldInfoPtr_onLocaleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, "onLocaleChanged");
			LocaleDropdown.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, "started");
			LocaleDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, 100666254);
			LocaleDropdown.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, 100666255);
			LocaleDropdown.NativeMethodInfoPtr_Event_SetLocale_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, 100666256);
			LocaleDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, 100666257);
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0005EC74 File Offset: 0x0005CE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520123, XrefRangeEnd = 520172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleDropdown.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0005ECA8 File Offset: 0x0005CEA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 468865, RefRangeEnd = 468871, XrefRangeStart = 468865, XrefRangeEnd = 468871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleDropdown.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0005ECDC File Offset: 0x0005CEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520172, XrefRangeEnd = 520190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetLocale(int localeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleDropdown.NativeMethodInfoPtr_Event_SetLocale_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0005ED1C File Offset: 0x0005CF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520190, XrefRangeEnd = 520196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocaleDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0000B82B File Offset: 0x00009A2B
		public LocaleDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0005ED58 File Offset: 0x0005CF58
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000B834 File Offset: 0x00009A34
		public unsafe TMP_Dropdown localeDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_localeDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_localeDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0005ED88 File Offset: 0x0005CF88
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000B853 File Offset: 0x00009A53
		public unsafe UnityEvent onLocaleChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_onLocaleChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_onLocaleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0005EDB8 File Offset: 0x0005CFB8
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000B872 File Offset: 0x00009A72
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocaleDropdown.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeFieldInfoPtr_localeDropdown;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_onLocaleChanged;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetLocale_Public_Void_Int32_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AE RID: 942
		[ObfuscatedName("boardgames.menus.behaviours.LocaleDropdown+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06002C20 RID: 11296 RVA: 0x00016D59 File Offset: 0x00014F59
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<LocaleDropdown.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LocaleDropdown>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocaleDropdown.__O>.NativeClassPtr);
				LocaleDropdown.__O.NativeFieldInfoPtr__0___GetNameForLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocaleDropdown.__O>.NativeClassPtr, "<0>__GetNameForLocale");
			}

			// Token: 0x06002C21 RID: 11297 RVA: 0x00016D8D File Offset: 0x00014F8D
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x06002C22 RID: 11298 RVA: 0x000AC6AC File Offset: 0x000AA8AC
			// (set) Token: 0x06002C23 RID: 11299 RVA: 0x00016D96 File Offset: 0x00014F96
			public unsafe static Func<TextLocalization.Locale, string> _0___GetNameForLocale
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LocaleDropdown.__O.NativeFieldInfoPtr__0___GetNameForLocale, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TextLocalization.Locale, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LocaleDropdown.__O.NativeFieldInfoPtr__0___GetNameForLocale, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B74 RID: 7028
			private static readonly IntPtr NativeFieldInfoPtr__0___GetNameForLocale;
		}
	}
}

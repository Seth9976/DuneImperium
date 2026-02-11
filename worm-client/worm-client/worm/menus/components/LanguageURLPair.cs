using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using localization;

namespace worm.menus.components
{
	// Token: 0x0200009F RID: 159
	[Serializable]
	public class LanguageURLPair : Object
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x0002BBA0 File Offset: 0x00029DA0
		// Note: this type is marked as 'beforefieldinit'.
		static LanguageURLPair()
		{
			Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "LanguageURLPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr);
			LanguageURLPair.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr, "locale");
			LanguageURLPair.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr, "url");
			LanguageURLPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr, 100664178);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0002BC0C File Offset: 0x00029E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696163, XrefRangeEnd = 696167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LanguageURLPair()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageURLPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LanguageURLPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00005247 File Offset: 0x00003447
		public LanguageURLPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0002BC48 File Offset: 0x00029E48
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00005250 File Offset: 0x00003450
		public unsafe TextLocalization.Locale locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageURLPair.NativeFieldInfoPtr_locale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageURLPair.NativeFieldInfoPtr_locale)) = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x0002BC70 File Offset: 0x00029E70
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000526B File Offset: 0x0000346B
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageURLPair.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LanguageURLPair.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr_locale;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

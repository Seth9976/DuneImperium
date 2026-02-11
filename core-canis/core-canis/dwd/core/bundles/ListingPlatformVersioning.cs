using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using localization;

namespace dwd.core.bundles
{
	// Token: 0x020001F3 RID: 499
	[Serializable]
	public class ListingPlatformVersioning : Object
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x0007F788 File Offset: 0x0007D988
		// Note: this type is marked as 'beforefieldinit'.
		static ListingPlatformVersioning()
		{
			Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "ListingPlatformVersioning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr);
			ListingPlatformVersioning.NativeFieldInfoPtr_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "platform");
			ListingPlatformVersioning.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "locale");
			ListingPlatformVersioning.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "version");
			ListingPlatformVersioning.NativeFieldInfoPtr_alt_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "alt_version");
			ListingPlatformVersioning.NativeFieldInfoPtr_CRC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "CRC");
			ListingPlatformVersioning.NativeFieldInfoPtr__locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, "_locale");
			ListingPlatformVersioning.NativeMethodInfoPtr_get_Locale_Public_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, 100667606);
			ListingPlatformVersioning.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, 100667607);
			ListingPlatformVersioning.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr, 100667608);
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001B2B RID: 6955 RVA: 0x0007F86C File Offset: 0x0007DA6C
		public unsafe TextLocalization.Locale Locale
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 884239, RefRangeEnd = 884242, XrefRangeStart = 884226, XrefRangeEnd = 884239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingPlatformVersioning.NativeMethodInfoPtr_get_Locale_Public_get_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0007F8A8 File Offset: 0x0007DAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884242, XrefRangeEnd = 884261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingPlatformVersioning.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0007F8EC File Offset: 0x0007DAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884261, XrefRangeEnd = 884262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingPlatformVersioning()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingPlatformVersioning>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingPlatformVersioning.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x0000BB69 File Offset: 0x00009D69
		public ListingPlatformVersioning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0007F928 File Offset: 0x0007DB28
		// (set) Token: 0x06001B30 RID: 6960 RVA: 0x0000BB72 File Offset: 0x00009D72
		public unsafe string platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_platform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_platform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0007F950 File Offset: 0x0007DB50
		// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000BB91 File Offset: 0x00009D91
		public unsafe string locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_locale);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_locale), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0007F978 File Offset: 0x0007DB78
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0007F9A0 File Offset: 0x0007DBA0
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0000BBCB File Offset: 0x00009DCB
		public unsafe int alt_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_alt_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_alt_version)) = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0007F9C8 File Offset: 0x0007DBC8
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0000BBE6 File Offset: 0x00009DE6
		public unsafe uint CRC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_CRC);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr_CRC)) = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0007F9F0 File Offset: 0x0007DBF0
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0000BC01 File Offset: 0x00009E01
		public Nullable<TextLocalization.Locale> _locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr__locale);
				return new Nullable<TextLocalization.Locale>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TextLocalization.Locale>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingPlatformVersioning.NativeFieldInfoPtr__locale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TextLocalization.Locale>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeFieldInfoPtr_platform;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeFieldInfoPtr_locale;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_alt_version;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_CRC;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr__locale;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeMethodInfoPtr_get_Locale_Public_get_Locale_0;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

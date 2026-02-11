using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using localization;

namespace dwd.core.bundles
{
	// Token: 0x020001F4 RID: 500
	[Serializable]
	public class PrecachedPlatformVersioning : Object
	{
		// Token: 0x06001B3B RID: 6971 RVA: 0x0007FA20 File Offset: 0x0007DC20
		// Note: this type is marked as 'beforefieldinit'.
		static PrecachedPlatformVersioning()
		{
			Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "PrecachedPlatformVersioning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr);
			PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, "alt_locale");
			PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, "alt_platform");
			PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, "alt_version");
			PrecachedPlatformVersioning.NativeFieldInfoPtr__alt_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, "_alt_locale");
			PrecachedPlatformVersioning.NativeMethodInfoPtr_get_Alt_Locale_Public_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, 100667609);
			PrecachedPlatformVersioning.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr, 100667610);
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0007FAC8 File Offset: 0x0007DCC8
		public unsafe TextLocalization.Locale Alt_Locale
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 884275, RefRangeEnd = 884278, XrefRangeStart = 884262, XrefRangeEnd = 884275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrecachedPlatformVersioning.NativeMethodInfoPtr_get_Alt_Locale_Public_get_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0007FB04 File Offset: 0x0007DD04
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrecachedPlatformVersioning()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrecachedPlatformVersioning>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrecachedPlatformVersioning.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000BC2F File Offset: 0x00009E2F
		public PrecachedPlatformVersioning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001B3F RID: 6975 RVA: 0x0007FB40 File Offset: 0x0007DD40
		// (set) Token: 0x06001B40 RID: 6976 RVA: 0x0000BC38 File Offset: 0x00009E38
		public unsafe string alt_locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_locale);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_locale), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x0007FB68 File Offset: 0x0007DD68
		// (set) Token: 0x06001B42 RID: 6978 RVA: 0x0000BC57 File Offset: 0x00009E57
		public unsafe string alt_platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_platform);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_platform), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x0007FB90 File Offset: 0x0007DD90
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x0000BC76 File Offset: 0x00009E76
		public unsafe int alt_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr_alt_version)) = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0007FBB8 File Offset: 0x0007DDB8
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000BC91 File Offset: 0x00009E91
		public Nullable<TextLocalization.Locale> _alt_locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr__alt_locale);
				return new Nullable<TextLocalization.Locale>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TextLocalization.Locale>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrecachedPlatformVersioning.NativeFieldInfoPtr__alt_locale), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TextLocalization.Locale>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_alt_locale;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_alt_platform;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_alt_version;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr__alt_locale;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_get_Alt_Locale_Public_get_Locale_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

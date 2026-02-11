using System;
using Canis.attributes;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data
{
	// Token: 0x020001C2 RID: 450
	public class NameData : NameLookup
	{
		// Token: 0x06001926 RID: 6438 RVA: 0x00077DC4 File Offset: 0x00075FC4
		// Note: this type is marked as 'beforefieldinit'.
		static NameData()
		{
			Il2CppClassPointerStore<NameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "NameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameData>.NativeClassPtr);
			NameData.NativeFieldInfoPtr_nameAttr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameData>.NativeClassPtr, "nameAttr");
			NameData.NativeFieldInfoPtr_cachedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameData>.NativeClassPtr, "cachedDisplayName");
			NameData.NativeFieldInfoPtr_cachedNameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameData>.NativeClassPtr, "cachedNameVersion");
			NameData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667289);
			NameData.NativeMethodInfoPtr__ctor_Private_Void_NameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667290);
			NameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667291);
			NameData.NativeMethodInfoPtr_CacheName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667292);
			NameData.NativeMethodInfoPtr_ClearCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667293);
			NameData.NativeMethodInfoPtr_get_UnlocalizedName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667294);
			NameData.NativeMethodInfoPtr_get_Value_Public_get_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667295);
			NameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667296);
			NameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667297);
			NameData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameData>.NativeClassPtr, 100667298);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00077EF8 File Offset: 0x000760F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 880960, RefRangeEnd = 880962, XrefRangeStart = 880952, XrefRangeEnd = 880960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameData(IAttribute<LocalizableText> nameAttr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameAttr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00077F44 File Offset: 0x00076144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880962, XrefRangeEnd = 880966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameData(NameData other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr__ctor_Private_Void_NameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00077F90 File Offset: 0x00076190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880966, XrefRangeEnd = 880974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameData.NativeMethodInfoPtr_name_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00077FD4 File Offset: 0x000761D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880974, XrefRangeEnd = 880982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr_CacheName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00078008 File Offset: 0x00076208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880982, XrefRangeEnd = 880983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCache()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr_ClearCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0007803C File Offset: 0x0007623C
		public unsafe string UnlocalizedName
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 880988, RefRangeEnd = 880994, XrefRangeStart = 880983, XrefRangeEnd = 880988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr_get_UnlocalizedName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00078074 File Offset: 0x00076274
		public unsafe LocalizableText Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 880998, RefRangeEnd = 880999, XrefRangeStart = 880994, XrefRangeEnd = 880998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameData.NativeMethodInfoPtr_get_Value_Public_get_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x000780B4 File Offset: 0x000762B4
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880999, XrefRangeEnd = 881006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000780FC File Offset: 0x000762FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881006, XrefRangeEnd = 881009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00078140 File Offset: 0x00076340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881009, XrefRangeEnd = 881016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameData.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0000B0E4 File Offset: 0x000092E4
		public NameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x0007818C File Offset: 0x0007638C
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x0000B0ED File Offset: 0x000092ED
		public unsafe IAttribute<LocalizableText> nameAttr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_nameAttr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_nameAttr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000781BC File Offset: 0x000763BC
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0000B10C File Offset: 0x0000930C
		public unsafe string cachedDisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_cachedDisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_cachedDisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000781E4 File Offset: 0x000763E4
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000B12B File Offset: 0x0000932B
		public unsafe ulong cachedNameVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_cachedNameVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameData.NativeFieldInfoPtr_cachedNameVersion)) = value;
			}
		}

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeFieldInfoPtr_nameAttr;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeFieldInfoPtr_cachedDisplayName;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_cachedNameVersion;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_LocalizableText_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_NameData_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Virtual_String_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_CacheName_Public_Void_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Void_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlocalizedName_Public_get_String_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_LocalizableText_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using UnityEngine.Localization.Metadata;
using UnityEngine.Pool;

namespace UnityEngine.Localization
{
	// Token: 0x02000006 RID: 6
	public class Locale : ScriptableObject
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000A168 File Offset: 0x00008368
		// Note: this type is marked as 'beforefieldinit'.
		static Locale()
		{
			Il2CppClassPointerStore<Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "Locale");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Locale>.NativeClassPtr);
			Locale.NativeFieldInfoPtr_m_Identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_Identifier");
			Locale.NativeFieldInfoPtr_m_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_Metadata");
			Locale.NativeFieldInfoPtr_m_LocaleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_LocaleName");
			Locale.NativeFieldInfoPtr_m_CustomFormatCultureCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_CustomFormatCultureCode");
			Locale.NativeFieldInfoPtr_m_UseCustomFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_UseCustomFormatter");
			Locale.NativeFieldInfoPtr_m_SortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_SortOrder");
			Locale.NativeFieldInfoPtr_m_Formatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale>.NativeClassPtr, "m_Formatter");
			Locale.NativeMethodInfoPtr_get_Identifier_Public_get_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663345);
			Locale.NativeMethodInfoPtr_set_Identifier_Public_set_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663346);
			Locale.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663347);
			Locale.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663348);
			Locale.NativeMethodInfoPtr_get_SortOrder_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663349);
			Locale.NativeMethodInfoPtr_set_SortOrder_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663350);
			Locale.NativeMethodInfoPtr_get_LocaleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663351);
			Locale.NativeMethodInfoPtr_set_LocaleName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663352);
			Locale.NativeMethodInfoPtr_GetFallback_Public_Virtual_New_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663353);
			Locale.NativeMethodInfoPtr_GetFallbacks_Public_IEnumerable_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663354);
			Locale.NativeMethodInfoPtr_get_UseCustomFormatter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663355);
			Locale.NativeMethodInfoPtr_set_UseCustomFormatter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663356);
			Locale.NativeMethodInfoPtr_get_CustomFormatterCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663357);
			Locale.NativeMethodInfoPtr_set_CustomFormatterCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663358);
			Locale.NativeMethodInfoPtr_get_Formatter_Public_Virtual_New_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663359);
			Locale.NativeMethodInfoPtr_set_Formatter_Public_Virtual_New_set_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663360);
			Locale.NativeMethodInfoPtr_GetFormatter_Internal_Static_CultureInfo_Boolean_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663361);
			Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663362);
			Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663363);
			Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663364);
			Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663365);
			Locale.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663366);
			Locale.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663367);
			Locale.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663368);
			Locale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663369);
			Locale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663370);
			Locale.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663371);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000A440 File Offset: 0x00008640
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000A478 File Offset: 0x00008678
		public unsafe LocaleIdentifier Identifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_Identifier_Public_get_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065276, XrefRangeEnd = 1065277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_Identifier_Public_set_Void_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000A4C0 File Offset: 0x000086C0
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000A500 File Offset: 0x00008700
		public unsafe MetadataCollection Metadata
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000A544 File Offset: 0x00008744
		// (set) Token: 0x0600004A RID: 74 RVA: 0x0000A580 File Offset: 0x00008780
		public unsafe ushort SortOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_SortOrder_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_SortOrder_Public_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000A5C0 File Offset: 0x000087C0
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public unsafe string LocaleName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1065280, RefRangeEnd = 1065284, XrefRangeStart = 1065277, XrefRangeEnd = 1065280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_LocaleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_LocaleName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A63C File Offset: 0x0000883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065284, XrefRangeEnd = 1065298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Locale GetFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Locale.NativeMethodInfoPtr_GetFallback_Public_Virtual_New_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000A688 File Offset: 0x00008888
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1065304, RefRangeEnd = 1065306, XrefRangeStart = 1065298, XrefRangeEnd = 1065304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Locale> GetFallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_GetFallbacks_Public_IEnumerable_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Locale>>(intPtr3) : null;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000A6C8 File Offset: 0x000088C8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000A704 File Offset: 0x00008904
		public unsafe bool UseCustomFormatter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_UseCustomFormatter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065306, XrefRangeEnd = 1065307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_UseCustomFormatter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000A744 File Offset: 0x00008944
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000A77C File Offset: 0x0000897C
		public unsafe string CustomFormatterCode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_get_CustomFormatterCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065307, XrefRangeEnd = 1065309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_set_CustomFormatterCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000A7C0 File Offset: 0x000089C0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000A80C File Offset: 0x00008A0C
		public unsafe virtual IFormatProvider Formatter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065309, XrefRangeEnd = 1065320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Locale.NativeMethodInfoPtr_get_Formatter_Public_Virtual_New_get_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Locale.NativeMethodInfoPtr_set_Formatter_Public_Virtual_New_set_Void_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A85C File Offset: 0x00008A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065320, XrefRangeEnd = 1065330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CultureInfo GetFormatter(bool useCustom, LocaleIdentifier localeIdentifier, string customCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useCustom;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_GetFormatter_Internal_Static_CultureInfo_Boolean_LocaleIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr3) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065330, XrefRangeEnd = 1065339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Locale CreateLocale(string code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A90C File Offset: 0x00008B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065339, XrefRangeEnd = 1065346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Locale CreateLocale(LocaleIdentifier identifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(identifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000A958 File Offset: 0x00008B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065346, XrefRangeEnd = 1065356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Locale CreateLocale(SystemLanguage language)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref language;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_SystemLanguage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000A998 File Offset: 0x00008B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065356, XrefRangeEnd = 1065365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Locale CreateLocale(CultureInfo cultureInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000A9DC File Offset: 0x00008BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065365, XrefRangeEnd = 1065377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(Locale other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000AA2C File Offset: 0x00008C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000AA60 File Offset: 0x00008C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065377, XrefRangeEnd = 1065380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000AA94 File Offset: 0x00008C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065384, RefRangeEnd = 1065385, XrefRangeStart = 1065380, XrefRangeEnd = 1065384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Locale.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065385, XrefRangeEnd = 1065392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Locale other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000AB28 File Offset: 0x00008D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1065398, RefRangeEnd = 1065399, XrefRangeStart = 1065392, XrefRangeEnd = 1065398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Locale()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Locale>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002114 File Offset: 0x00000314
		public Locale(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000AB64 File Offset: 0x00008D64
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0000211D File Offset: 0x0000031D
		public LocaleIdentifier m_Identifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Identifier);
				return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Identifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000AB94 File Offset: 0x00008D94
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000214B File Offset: 0x0000034B
		public unsafe MetadataCollection m_Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetadataCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000216A File Offset: 0x0000036A
		public unsafe string m_LocaleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_LocaleName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_LocaleName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000ABEC File Offset: 0x00008DEC
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002189 File Offset: 0x00000389
		public unsafe string m_CustomFormatCultureCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_CustomFormatCultureCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_CustomFormatCultureCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000AC14 File Offset: 0x00008E14
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000021A8 File Offset: 0x000003A8
		public unsafe bool m_UseCustomFormatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_UseCustomFormatter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_UseCustomFormatter)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000AC3C File Offset: 0x00008E3C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000021C3 File Offset: 0x000003C3
		public unsafe ushort m_SortOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_SortOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_SortOrder)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000AC64 File Offset: 0x00008E64
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000021DE File Offset: 0x000003DE
		public unsafe IFormatProvider m_Formatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Formatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale.NativeFieldInfoPtr_m_Formatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_Identifier;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_Metadata;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_LocaleName;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomFormatCultureCode;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_m_UseCustomFormatter;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_m_SortOrder;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_m_Formatter;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_LocaleIdentifier_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_set_Identifier_Public_set_Void_LocaleIdentifier_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_Metadata_Public_get_MetadataCollection_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_set_Metadata_Public_set_Void_MetadataCollection_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_SortOrder_Public_get_UInt16_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_set_SortOrder_Public_set_Void_UInt16_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_LocaleName_Public_get_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_set_LocaleName_Public_set_Void_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetFallback_Public_Virtual_New_Locale_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbacks_Public_IEnumerable_1_Locale_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCustomFormatter_Public_get_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_set_UseCustomFormatter_Public_set_Void_Boolean_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomFormatterCode_Public_get_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_set_CustomFormatterCode_Public_set_Void_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_Formatter_Public_Virtual_New_get_IFormatProvider_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_set_Formatter_Public_Virtual_New_set_Void_IFormatProvider_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatter_Internal_Static_CultureInfo_Boolean_LocaleIdentifier_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_LocaleIdentifier_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_SystemLanguage_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocale_Public_Static_Locale_CultureInfo_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Locale_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Locale_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200010E RID: 270
		[ObfuscatedName("UnityEngine.Localization.Locale+<GetFallbacks>d__20")]
		public sealed class _GetFallbacks_d__20 : Object
		{
			// Token: 0x06000C89 RID: 3209 RVA: 0x000386C4 File Offset: 0x000368C4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetFallbacks_d__20()
			{
				Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Locale>.NativeClassPtr, "<GetFallbacks>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr);
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<>1__state");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<>2__current");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<>l__initialThreadId");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<>4__this");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr__processedLocales_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<processedLocales>5__2");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<>7__wrap2");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr__entries_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<entries>5__4");
				Locale._GetFallbacks_d__20.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, "<i>5__5");
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663372);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663373);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663374);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663375);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_Locale__get_Current_Private_Virtual_Final_New_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663376);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663377);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663378);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_Locale__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663379);
				Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr, 100663380);
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00038844 File Offset: 0x00036A44
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetFallbacks_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Locale._GetFallbacks_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x0003888C File Offset: 0x00036A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065198, XrefRangeEnd = 1065203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x000388C0 File Offset: 0x00036AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065203, XrefRangeEnd = 1065266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x000388FC File Offset: 0x00036AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065266, XrefRangeEnd = 1065269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00038930 File Offset: 0x00036B30
			public unsafe Locale System.Collections.Generic.IEnumerator<UnityEngine.Localization.Locale>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_Locale__get_Current_Private_Virtual_Final_New_get_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
				}
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x00038970 File Offset: 0x00036B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065269, XrefRangeEnd = 1065274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x000389A4 File Offset: 0x00036BA4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x000389E4 File Offset: 0x00036BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065274, XrefRangeEnd = 1065276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Locale> System_Collections_Generic_IEnumerable_UnityEngine_Localization_Locale__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_Locale__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Locale>>(intPtr3) : null;
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00038A24 File Offset: 0x00036C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale._GetFallbacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x0000744A File Offset: 0x0000564A
			public _GetFallbacks_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00038A64 File Offset: 0x00036C64
			// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00007453 File Offset: 0x00005653
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00038A8C File Offset: 0x00036C8C
			// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0000746E File Offset: 0x0000566E
			public unsafe Locale __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00038ABC File Offset: 0x00036CBC
			// (set) Token: 0x06000C99 RID: 3225 RVA: 0x0000748D File Offset: 0x0000568D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00038AE4 File Offset: 0x00036CE4
			// (set) Token: 0x06000C9B RID: 3227 RVA: 0x000074A8 File Offset: 0x000056A8
			public unsafe Locale __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00038B14 File Offset: 0x00036D14
			// (set) Token: 0x06000C9D RID: 3229 RVA: 0x000074C7 File Offset: 0x000056C7
			public unsafe HashSet<Locale> _processedLocales_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__processedLocales_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Locale>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__processedLocales_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00038B44 File Offset: 0x00036D44
			// (set) Token: 0x06000C9F RID: 3231 RVA: 0x000074E6 File Offset: 0x000056E6
			public PooledObject<HashSet<Locale>> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___7__wrap2);
					return new PooledObject<HashSet<Locale>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PooledObject<HashSet<Locale>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PooledObject<HashSet<Locale>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00038B74 File Offset: 0x00036D74
			// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00007514 File Offset: 0x00005714
			public unsafe IList<IMetadata> _entries_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__entries_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<IMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__entries_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00038BA4 File Offset: 0x00036DA4
			// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00007533 File Offset: 0x00005733
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Locale._GetFallbacks_d__20.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040008BF RID: 2239
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008C0 RID: 2240
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008C1 RID: 2241
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040008C2 RID: 2242
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008C3 RID: 2243
			private static readonly IntPtr NativeFieldInfoPtr__processedLocales_5__2;

			// Token: 0x040008C4 RID: 2244
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040008C5 RID: 2245
			private static readonly IntPtr NativeFieldInfoPtr__entries_5__4;

			// Token: 0x040008C6 RID: 2246
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040008C7 RID: 2247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008C8 RID: 2248
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008C9 RID: 2249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008CA RID: 2250
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040008CB RID: 2251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Localization_Locale__get_Current_Private_Virtual_Final_New_get_Locale_0;

			// Token: 0x040008CC RID: 2252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008CD RID: 2253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008CE RID: 2254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Localization_Locale__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Locale_0;

			// Token: 0x040008CF RID: 2255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}

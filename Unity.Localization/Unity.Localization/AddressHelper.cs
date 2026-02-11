using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization
{
	// Token: 0x02000019 RID: 25
	public class AddressHelper : Object
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0000E144 File Offset: 0x0000C344
		// Note: this type is marked as 'beforefieldinit'.
		static AddressHelper()
		{
			Il2CppClassPointerStore<AddressHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "AddressHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr);
			AddressHelper.NativeFieldInfoPtr_k_Separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, "k_Separator");
			AddressHelper.NativeFieldInfoPtr_k_AssetLabelPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, "k_AssetLabelPrefix");
			AddressHelper.NativeMethodInfoPtr_GetTableAddress_Public_Static_String_String_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663558);
			AddressHelper.NativeMethodInfoPtr_GetSharedTableAddress_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663559);
			AddressHelper.NativeMethodInfoPtr_FormatAssetLabel_Public_Static_String_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663560);
			AddressHelper.NativeMethodInfoPtr_IsLocaleLabel_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663561);
			AddressHelper.NativeMethodInfoPtr_LocaleLabelToId_Public_Static_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663562);
			AddressHelper.NativeMethodInfoPtr_TryGetLocaleLabelToId_Public_Static_Boolean_String_byref_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663563);
			AddressHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr, 100663564);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000E228 File Offset: 0x0000C428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066328, XrefRangeEnd = 1066334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTableAddress(string tableName, LocaleIdentifier localeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeId));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_GetTableAddress_Public_Static_String_String_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000E27C File Offset: 0x0000C47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066334, XrefRangeEnd = 1066337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSharedTableAddress(string tableName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_GetSharedTableAddress_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1066340, RefRangeEnd = 1066341, XrefRangeStart = 1066337, XrefRangeEnd = 1066340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatAssetLabel(LocaleIdentifier localeIdentifier)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_FormatAssetLabel_Public_Static_String_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066341, XrefRangeEnd = 1066345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLocaleLabel(string label)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_IsLocaleLabel_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000E340 File Offset: 0x0000C540
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1063114, RefRangeEnd = 1063118, XrefRangeStart = 1063114, XrefRangeEnd = 1063118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LocaleIdentifier LocaleLabelToId(string label)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_LocaleLabelToId_Public_Static_LocaleIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LocaleIdentifier(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000E37C File Offset: 0x0000C57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066345, XrefRangeEnd = 1066354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetLocaleLabelToId(string label, out LocaleIdentifier localeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr_TryGetLocaleLabelToId_Public_Static_Boolean_String_byref_LocaleIdentifier_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			localeId = ((intPtr4 == 0) ? null : new LocaleIdentifier(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddressHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddressHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddressHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000028BA File Offset: 0x00000ABA
		public AddressHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000E41C File Offset: 0x0000C61C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe static char k_Separator
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(AddressHelper.NativeFieldInfoPtr_k_Separator, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressHelper.NativeFieldInfoPtr_k_Separator, (void*)(&value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0000E438 File Offset: 0x0000C638
		// (set) Token: 0x06000159 RID: 345 RVA: 0x000028D1 File Offset: 0x00000AD1
		public unsafe static string k_AssetLabelPrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AddressHelper.NativeFieldInfoPtr_k_AssetLabelPrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AddressHelper.NativeFieldInfoPtr_k_AssetLabelPrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_k_Separator;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_k_AssetLabelPrefix;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetTableAddress_Public_Static_String_String_LocaleIdentifier_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedTableAddress_Public_Static_String_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_FormatAssetLabel_Public_Static_String_LocaleIdentifier_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_IsLocaleLabel_Public_Static_Boolean_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_LocaleLabelToId_Public_Static_LocaleIdentifier_String_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLocaleLabelToId_Public_Static_Boolean_String_byref_LocaleIdentifier_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

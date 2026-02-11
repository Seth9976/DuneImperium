using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Formatting;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000033 RID: 51
	public class SmartFormatterLiteralCharacterExtractor : SmartFormatter
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0001688C File Offset: 0x00014A8C
		// Note: this type is marked as 'beforefieldinit'.
		static SmartFormatterLiteralCharacterExtractor()
		{
			Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "SmartFormatterLiteralCharacterExtractor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr);
			SmartFormatterLiteralCharacterExtractor.NativeFieldInfoPtr_m_Characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr, "m_Characters");
			SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr, 100663894);
			SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr_ExtractLiteralsCharacters_Public_IEnumerable_1_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr, 100663895);
			SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr_Format_Public_Virtual_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr, 100663896);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0001690C File Offset: 0x00014B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068875, XrefRangeEnd = 1068888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartFormatterLiteralCharacterExtractor(SmartFormatter parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartFormatterLiteralCharacterExtractor>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00016958 File Offset: 0x00014B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068893, RefRangeEnd = 1068894, XrefRangeStart = 1068888, XrefRangeEnd = 1068893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<char> ExtractLiteralsCharacters(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr_ExtractLiteralsCharacters_Public_IEnumerable_1_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000169A8 File Offset: 0x00014BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068894, XrefRangeEnd = 1068945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Format(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmartFormatterLiteralCharacterExtractor.NativeMethodInfoPtr_Format_Public_Virtual_Void_FormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000032EE File Offset: 0x000014EE
		public SmartFormatterLiteralCharacterExtractor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000169F8 File Offset: 0x00014BF8
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000032F7 File Offset: 0x000014F7
		public unsafe IEnumerable<char> m_Characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatterLiteralCharacterExtractor.NativeFieldInfoPtr_m_Characters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatterLiteralCharacterExtractor.NativeFieldInfoPtr_m_Characters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_m_Characters;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_ExtractLiteralsCharacters_Public_IEnumerable_1_Char_String_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_Void_FormattingInfo_0;
	}
}

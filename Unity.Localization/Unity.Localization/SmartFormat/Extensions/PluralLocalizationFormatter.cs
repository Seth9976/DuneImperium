using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Utilities;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006C RID: 108
	[Serializable]
	public class PluralLocalizationFormatter : FormatterBase
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0001C674 File Offset: 0x0001A874
		// Note: this type is marked as 'beforefieldinit'.
		static PluralLocalizationFormatter()
		{
			Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "PluralLocalizationFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr);
			PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterISOLanguageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, "m_DefaultTwoLetterISOLanguageName");
			PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultPluralRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, "m_DefaultPluralRule");
			PluralLocalizationFormatter.NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664253);
			PluralLocalizationFormatter.NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664254);
			PluralLocalizationFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664255);
			PluralLocalizationFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664256);
			PluralLocalizationFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664257);
			PluralLocalizationFormatter.NativeMethodInfoPtr_GetPluralRule_Protected_Virtual_New_PluralRuleDelegate_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664258);
			PluralLocalizationFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr, 100664259);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0001C758 File Offset: 0x0001A958
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0001C790 File Offset: 0x0001A990
		public unsafe string DefaultTwoLetterISOLanguageName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralLocalizationFormatter.NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072454, XrefRangeEnd = 1072480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralLocalizationFormatter.NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0001C7D4 File Offset: 0x0001A9D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072486, RefRangeEnd = 1072487, XrefRangeStart = 1072480, XrefRangeEnd = 1072486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PluralLocalizationFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PluralLocalizationFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralLocalizationFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001C810 File Offset: 0x0001AA10
		public unsafe override Il2CppStringArray DefaultNames
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072487, XrefRangeEnd = 1072499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PluralLocalizationFormatter.NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001C85C File Offset: 0x0001AA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072499, XrefRangeEnd = 1072544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PluralLocalizationFormatter.NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001C8B4 File Offset: 0x0001AAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072544, XrefRangeEnd = 1072566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PluralRules.PluralRuleDelegate GetPluralRule(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PluralLocalizationFormatter.NativeMethodInfoPtr_GetPluralRule_Protected_Virtual_New_PluralRuleDelegate_IFormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001C910 File Offset: 0x0001AB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072566, XrefRangeEnd = 1072586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteAllLiterals(IFormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PluralLocalizationFormatter.NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00003F17 File Offset: 0x00002117
		public PluralLocalizationFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001C954 File Offset: 0x0001AB54
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00003F20 File Offset: 0x00002120
		public unsafe string m_DefaultTwoLetterISOLanguageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterISOLanguageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultTwoLetterISOLanguageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001C97C File Offset: 0x0001AB7C
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00003F3F File Offset: 0x0000213F
		public unsafe PluralRules.PluralRuleDelegate m_DefaultPluralRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultPluralRule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PluralRules.PluralRuleDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PluralLocalizationFormatter.NativeFieldInfoPtr_m_DefaultPluralRule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultTwoLetterISOLanguageName;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultPluralRule;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultTwoLetterISOLanguageName_Public_get_String_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultTwoLetterISOLanguageName_Public_set_Void_String_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNames_Public_Virtual_get_Il2CppStringArray_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateFormat_Public_Virtual_Boolean_IFormattingInfo_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_GetPluralRule_Protected_Virtual_New_PluralRuleDelegate_IFormattingInfo_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_WriteAllLiterals_Public_Virtual_Final_New_Void_IFormattingInfo_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007B RID: 123
	[Serializable]
	public class Parser : Object
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr_m_OpeningBrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_OpeningBrace");
			Parser.NativeFieldInfoPtr_m_ClosingBrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_ClosingBrace");
			Parser.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_Settings");
			Parser.NativeFieldInfoPtr_m_AlphanumericSelectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_AlphanumericSelectors");
			Parser.NativeFieldInfoPtr_m_AllowedSelectorChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_AllowedSelectorChars");
			Parser.NativeFieldInfoPtr_m_Operators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_Operators");
			Parser.NativeFieldInfoPtr_m_AlternativeEscaping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_AlternativeEscaping");
			Parser.NativeFieldInfoPtr_m_AlternativeEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_AlternativeEscapeChar");
			Parser.NativeFieldInfoPtr_m_CharLiteralEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "m_CharLiteralEscapeChar");
			Parser.NativeFieldInfoPtr_s_ParsingErrorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "s_ParsingErrorText");
			Parser.NativeFieldInfoPtr_OnParsingFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "OnParsingFailure");
			Parser.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664372);
			Parser.NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664373);
			Parser.NativeMethodInfoPtr_add_OnParsingFailure_Public_add_Void_EventHandler_1_ParsingErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664374);
			Parser.NativeMethodInfoPtr_remove_OnParsingFailure_Public_rem_Void_EventHandler_1_ParsingErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664375);
			Parser.NativeMethodInfoPtr__ctor_Public_Void_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664376);
			Parser.NativeMethodInfoPtr_AddAlphanumericSelectors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664377);
			Parser.NativeMethodInfoPtr_AddAdditionalSelectorChars_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664378);
			Parser.NativeMethodInfoPtr_AddOperators_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664379);
			Parser.NativeMethodInfoPtr_UseAlternativeEscapeChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664380);
			Parser.NativeMethodInfoPtr_UseBraceEscaping_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664381);
			Parser.NativeMethodInfoPtr_UseAlternativeBraces_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664382);
			Parser.NativeMethodInfoPtr_ParseFormat_Public_Format_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664383);
			Parser.NativeMethodInfoPtr_HandleParsingErrors_Private_Format_ParsingErrors_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664384);
			Parser.NativeMethodInfoPtr_FormatterNameExists_Private_Static_Boolean_String_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100664385);
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0001F0E4 File Offset: 0x0001D2E4
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0001F124 File Offset: 0x0001D324
		public unsafe SmartSettings Settings
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0001F168 File Offset: 0x0001D368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073618, XrefRangeEnd = 1073623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_add_OnParsingFailure_Public_add_Void_EventHandler_1_ParsingErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073623, XrefRangeEnd = 1073628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnParsingFailure(EventHandler<ParsingErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_remove_OnParsingFailure_Public_rem_Void_EventHandler_1_ParsingErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073637, RefRangeEnd = 1073638, XrefRangeStart = 1073628, XrefRangeEnd = 1073637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(SmartSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Public_Void_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0001F23C File Offset: 0x0001D43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497605, RefRangeEnd = 497606, XrefRangeStart = 497605, XrefRangeEnd = 497606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAlphanumericSelectors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_AddAlphanumericSelectors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001F270 File Offset: 0x0001D470
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1073647, RefRangeEnd = 1073651, XrefRangeStart = 1073638, XrefRangeEnd = 1073647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAdditionalSelectorChars(string chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_AddAdditionalSelectorChars_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1073660, RefRangeEnd = 1073667, XrefRangeStart = 1073651, XrefRangeEnd = 1073660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOperators(string chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_AddOperators_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0001F2F8 File Offset: 0x0001D4F8
		[CallerCount(0)]
		public unsafe void UseAlternativeEscapeChar(char alternativeEscapeChar = '\\')
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alternativeEscapeChar;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_UseAlternativeEscapeChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0001F338 File Offset: 0x0001D538
		[CallerCount(0)]
		public unsafe void UseBraceEscaping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_UseBraceEscaping_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0001F36C File Offset: 0x0001D56C
		[CallerCount(0)]
		public unsafe void UseAlternativeBraces(char opening, char closing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref opening;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_UseAlternativeBraces_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1073867, RefRangeEnd = 1073874, XrefRangeStart = 1073667, XrefRangeEnd = 1073867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Format ParseFormat(string format, IList<string> formatterExtensionNames)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterExtensionNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseFormat_Public_Format_String_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0001F41C File Offset: 0x0001D61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073874, XrefRangeEnd = 1073914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Format HandleParsingErrors(ParsingErrors parsingErrors, Format currentResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parsingErrors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_HandleParsingErrors_Private_Format_ParsingErrors_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0001F480 File Offset: 0x0001D680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1073927, RefRangeEnd = 1073929, XrefRangeStart = 1073914, XrefRangeEnd = 1073927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FormatterNameExists(string name, IList<string> formatterExtensionNames)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterExtensionNames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_FormatterNameExists_Private_Static_Boolean_String_IList_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000042F5 File Offset: 0x000024F5
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001F4D4 File Offset: 0x0001D6D4
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x000042FE File Offset: 0x000024FE
		public unsafe char m_OpeningBrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_OpeningBrace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_OpeningBrace)) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001F4FC File Offset: 0x0001D6FC
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00004319 File Offset: 0x00002519
		public unsafe char m_ClosingBrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_ClosingBrace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_ClosingBrace)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001F524 File Offset: 0x0001D724
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe SmartSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001F554 File Offset: 0x0001D754
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00004353 File Offset: 0x00002553
		public unsafe bool m_AlphanumericSelectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlphanumericSelectors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlphanumericSelectors)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x0001F57C File Offset: 0x0001D77C
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000436E File Offset: 0x0000256E
		public unsafe string m_AllowedSelectorChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AllowedSelectorChars);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AllowedSelectorChars), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001F5A4 File Offset: 0x0001D7A4
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000438D File Offset: 0x0000258D
		public unsafe string m_Operators
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_Operators);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_Operators), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000043AC File Offset: 0x000025AC
		public unsafe bool m_AlternativeEscaping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlternativeEscaping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlternativeEscaping)) = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001F5F4 File Offset: 0x0001D7F4
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x000043C7 File Offset: 0x000025C7
		public unsafe char m_AlternativeEscapeChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlternativeEscapeChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_m_AlternativeEscapeChar)) = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0001F61C File Offset: 0x0001D81C
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x000043E2 File Offset: 0x000025E2
		public unsafe static char m_CharLiteralEscapeChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(Parser.NativeFieldInfoPtr_m_CharLiteralEscapeChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Parser.NativeFieldInfoPtr_m_CharLiteralEscapeChar, (void*)(&value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001F638 File Offset: 0x0001D838
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x000043F0 File Offset: 0x000025F0
		public unsafe static Parser.ParsingErrorText s_ParsingErrorText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Parser.NativeFieldInfoPtr_s_ParsingErrorText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser.ParsingErrorText>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Parser.NativeFieldInfoPtr_s_ParsingErrorText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001F660 File Offset: 0x0001D860
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00004402 File Offset: 0x00002602
		public unsafe EventHandler<ParsingErrorEventArgs> OnParsingFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_OnParsingFailure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<ParsingErrorEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr_OnParsingFailure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_m_OpeningBrace;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosingBrace;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphanumericSelectors;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowedSelectorChars;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_m_Operators;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_m_AlternativeEscaping;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_m_AlternativeEscapeChar;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_m_CharLiteralEscapeChar;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_s_ParsingErrorText;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_OnParsingFailure;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_add_OnParsingFailure_Public_add_Void_EventHandler_1_ParsingErrorEventArgs_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnParsingFailure_Public_rem_Void_EventHandler_1_ParsingErrorEventArgs_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartSettings_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_AddAlphanumericSelectors_Public_Void_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_AddAdditionalSelectorChars_Public_Void_String_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_AddOperators_Public_Void_String_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_UseAlternativeEscapeChar_Public_Void_Char_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_UseBraceEscaping_Public_Void_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_UseAlternativeBraces_Public_Void_Char_Char_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_ParseFormat_Public_Format_String_IList_1_String_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_HandleParsingErrors_Private_Format_ParsingErrors_Format_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr_FormatterNameExists_Private_Static_Boolean_String_IList_1_String_0;

		// Token: 0x0200014F RID: 335
		public enum ParsingError
		{
			// Token: 0x04000A32 RID: 2610
			TooManyClosingBraces = 1,
			// Token: 0x04000A33 RID: 2611
			TrailingOperatorsInSelector,
			// Token: 0x04000A34 RID: 2612
			InvalidCharactersInSelector,
			// Token: 0x04000A35 RID: 2613
			MissingClosingBrace
		}

		// Token: 0x02000150 RID: 336
		public class ParsingErrorText : Object
		{
			// Token: 0x06000ED7 RID: 3799 RVA: 0x0003FF70 File Offset: 0x0003E170
			// Note: this type is marked as 'beforefieldinit'.
			static ParsingErrorText()
			{
				Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "ParsingErrorText");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr);
				Parser.ParsingErrorText.NativeFieldInfoPtr__errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr, "_errors");
				Parser.ParsingErrorText.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr, 100664386);
				Parser.ParsingErrorText.NativeMethodInfoPtr_get_Item_Public_get_String_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr, 100664387);
			}

			// Token: 0x06000ED8 RID: 3800 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073578, XrefRangeEnd = 1073604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParsingErrorText()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.ParsingErrorText>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.ParsingErrorText.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000401 RID: 1025
			public unsafe string this[Parser.ParsingError parsingErrorKey]
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 1073608, RefRangeEnd = 1073612, XrefRangeStart = 1073604, XrefRangeEnd = 1073608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref parsingErrorKey;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.ParsingErrorText.NativeMethodInfoPtr_get_Item_Public_get_String_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}
			}

			// Token: 0x06000EDA RID: 3802 RVA: 0x000083B6 File Offset: 0x000065B6
			public ParsingErrorText(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06000EDB RID: 3803 RVA: 0x00040058 File Offset: 0x0003E258
			// (set) Token: 0x06000EDC RID: 3804 RVA: 0x000083BF File Offset: 0x000065BF
			public unsafe Dictionary<Parser.ParsingError, string> _errors
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.ParsingErrorText.NativeFieldInfoPtr__errors);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Parser.ParsingError, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.ParsingErrorText.NativeFieldInfoPtr__errors), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A36 RID: 2614
			private static readonly IntPtr NativeFieldInfoPtr__errors;

			// Token: 0x04000A37 RID: 2615
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04000A38 RID: 2616
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_String_ParsingError_0;
		}

		// Token: 0x02000151 RID: 337
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Core.Parsing.Parser+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06000EDD RID: 3805 RVA: 0x00040088 File Offset: 0x0003E288
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<Parser.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.__c__DisplayClass24_0>.NativeClassPtr);
				Parser.__c__DisplayClass24_0.NativeFieldInfoPtr_currentResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.__c__DisplayClass24_0>.NativeClassPtr, "currentResult");
				Parser.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.__c__DisplayClass24_0>.NativeClassPtr, 100664388);
			}

			// Token: 0x06000EDE RID: 3806 RVA: 0x000400DC File Offset: 0x0003E2DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EDF RID: 3807 RVA: 0x000083DE File Offset: 0x000065DE
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x00040118 File Offset: 0x0003E318
			// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x000083E7 File Offset: 0x000065E7
			public unsafe Format currentResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_0.NativeFieldInfoPtr_currentResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_0.NativeFieldInfoPtr_currentResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A39 RID: 2617
			private static readonly IntPtr NativeFieldInfoPtr_currentResult;

			// Token: 0x04000A3A RID: 2618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000152 RID: 338
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Core.Parsing.Parser+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Object
		{
			// Token: 0x06000EE2 RID: 3810 RVA: 0x00040148 File Offset: 0x0003E348
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr);
				Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr, "i");
				Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr, "CS$<>8__locals1");
				Parser.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr, 100664389);
				Parser.__c__DisplayClass24_1.NativeMethodInfoPtr__HandleParsingErrors_b__0_Internal_Boolean_ParsingIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr, 100664390);
			}

			// Token: 0x06000EE3 RID: 3811 RVA: 0x000401C4 File Offset: 0x0003E3C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EE4 RID: 3812 RVA: 0x00040200 File Offset: 0x0003E400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073612, XrefRangeEnd = 1073615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleParsingErrors_b__0(ParsingErrors.ParsingIssue errItem)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(errItem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.__c__DisplayClass24_1.NativeMethodInfoPtr__HandleParsingErrors_b__0_Internal_Boolean_ParsingIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EE5 RID: 3813 RVA: 0x00008406 File Offset: 0x00006606
			public __c__DisplayClass24_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x00040250 File Offset: 0x0003E450
			// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x0000840F File Offset: 0x0000660F
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x00040278 File Offset: 0x0003E478
			// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x0000842A File Offset: 0x0000662A
			public unsafe Parser.__c__DisplayClass24_0 field_Public___c__DisplayClass24_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser.__c__DisplayClass24_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_1.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A3B RID: 2619
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04000A3C RID: 2620
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0;

			// Token: 0x04000A3D RID: 2621
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A3E RID: 2622
			private static readonly IntPtr NativeMethodInfoPtr__HandleParsingErrors_b__0_Internal_Boolean_ParsingIssue_0;
		}

		// Token: 0x02000153 RID: 339
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Core.Parsing.Parser+<>c__DisplayClass24_2")]
		public sealed class __c__DisplayClass24_2 : Object
		{
			// Token: 0x06000EEA RID: 3818 RVA: 0x000402A8 File Offset: 0x0003E4A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_2()
			{
				Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Parser>.NativeClassPtr, "<>c__DisplayClass24_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr);
				Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr, "i");
				Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr, "CS$<>8__locals2");
				Parser.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr, 100664391);
				Parser.__c__DisplayClass24_2.NativeMethodInfoPtr__HandleParsingErrors_b__1_Internal_Boolean_ParsingIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr, 100664392);
			}

			// Token: 0x06000EEB RID: 3819 RVA: 0x00040324 File Offset: 0x0003E524
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser.__c__DisplayClass24_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000EEC RID: 3820 RVA: 0x00040360 File Offset: 0x0003E560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073615, XrefRangeEnd = 1073618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleParsingErrors_b__1(ParsingErrors.ParsingIssue errItem)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(errItem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.__c__DisplayClass24_2.NativeMethodInfoPtr__HandleParsingErrors_b__1_Internal_Boolean_ParsingIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000EED RID: 3821 RVA: 0x00008449 File Offset: 0x00006649
			public __c__DisplayClass24_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000EEE RID: 3822 RVA: 0x000403B0 File Offset: 0x0003E5B0
			// (set) Token: 0x06000EEF RID: 3823 RVA: 0x00008452 File Offset: 0x00006652
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000EF0 RID: 3824 RVA: 0x000403D8 File Offset: 0x0003E5D8
			// (set) Token: 0x06000EF1 RID: 3825 RVA: 0x0000846D File Offset: 0x0000666D
			public unsafe Parser.__c__DisplayClass24_0 field_Public___c__DisplayClass24_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser.__c__DisplayClass24_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.__c__DisplayClass24_2.NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A3F RID: 2623
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04000A40 RID: 2624
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass24_0_0;

			// Token: 0x04000A41 RID: 2625
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A42 RID: 2626
			private static readonly IntPtr NativeMethodInfoPtr__HandleParsingErrors_b__1_Internal_Boolean_ParsingIssue_0;
		}
	}
}

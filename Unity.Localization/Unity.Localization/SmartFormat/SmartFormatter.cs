using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.Core.Formatting;
using UnityEngine.Localization.SmartFormat.Core.Output;
using UnityEngine.Localization.SmartFormat.Core.Parsing;
using UnityEngine.Localization.SmartFormat.Core.Settings;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	public class SmartFormatter : Object
	{
		// Token: 0x0600032A RID: 810 RVA: 0x00015998 File Offset: 0x00013B98
		// Note: this type is marked as 'beforefieldinit'.
		static SmartFormatter()
		{
			Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "SmartFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr);
			SmartFormatter.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "m_Settings");
			SmartFormatter.NativeFieldInfoPtr_m_Parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "m_Parser");
			SmartFormatter.NativeFieldInfoPtr_m_Sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "m_Sources");
			SmartFormatter.NativeFieldInfoPtr_m_Formatters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "m_Formatters");
			SmartFormatter.NativeFieldInfoPtr_m_NotEmptyFormatterExtensionNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "m_NotEmptyFormatterExtensionNames");
			SmartFormatter.NativeFieldInfoPtr_k_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "k_Empty");
			SmartFormatter.NativeFieldInfoPtr_OnFormattingFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, "OnFormattingFailure");
			SmartFormatter.NativeMethodInfoPtr_add_OnFormattingFailure_Public_add_Void_EventHandler_1_FormattingErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663861);
			SmartFormatter.NativeMethodInfoPtr_remove_OnFormattingFailure_Public_rem_Void_EventHandler_1_FormattingErrorEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663862);
			SmartFormatter.NativeMethodInfoPtr_get_SourceExtensions_Public_get_List_1_ISource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663863);
			SmartFormatter.NativeMethodInfoPtr_get_FormatterExtensions_Public_get_List_1_IFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663864);
			SmartFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663865);
			SmartFormatter.NativeMethodInfoPtr_GetNotEmptyFormatterExtensionNames_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663866);
			SmartFormatter.NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_ISource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663867);
			SmartFormatter.NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_IFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663868);
			SmartFormatter.NativeMethodInfoPtr_GetSourceExtension_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663869);
			SmartFormatter.NativeMethodInfoPtr_GetFormatterExtension_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663870);
			SmartFormatter.NativeMethodInfoPtr_get_Parser_Public_get_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663871);
			SmartFormatter.NativeMethodInfoPtr_set_Parser_Public_set_Void_Parser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663872);
			SmartFormatter.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663873);
			SmartFormatter.NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663874);
			SmartFormatter.NativeMethodInfoPtr_Format_Public_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663875);
			SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IList_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663876);
			SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663877);
			SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IFormatProvider_IList_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663878);
			SmartFormatter.NativeMethodInfoPtr_FormatInto_Public_Void_IOutput_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663879);
			SmartFormatter.NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663880);
			SmartFormatter.NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IFormatProvider_IList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663881);
			SmartFormatter.NativeMethodInfoPtr_FormatWithCacheInto_Public_Void_byref_FormatCache_IOutput_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663882);
			SmartFormatter.NativeMethodInfoPtr_Format_Private_Void_FormatDetails_Format_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663883);
			SmartFormatter.NativeMethodInfoPtr_Format_Public_Virtual_New_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663884);
			SmartFormatter.NativeMethodInfoPtr_FormatError_Private_Void_FormatItem_Exception_Int32_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663885);
			SmartFormatter.NativeMethodInfoPtr_CheckForExtensions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663886);
			SmartFormatter.NativeMethodInfoPtr_EvaluateSelectors_Private_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663887);
			SmartFormatter.NativeMethodInfoPtr_InvokeSourceExtensions_Private_Boolean_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663888);
			SmartFormatter.NativeMethodInfoPtr_EvaluateFormatters_Private_Void_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663889);
			SmartFormatter.NativeMethodInfoPtr_InvokeFormatterExtensions_Private_Boolean_FormattingInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663890);
			SmartFormatter.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663891);
			SmartFormatter.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr, 100663892);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00015CD4 File Offset: 0x00013ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068504, XrefRangeEnd = 1068509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_add_OnFormattingFailure_Public_add_Void_EventHandler_1_FormattingErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00015D18 File Offset: 0x00013F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068509, XrefRangeEnd = 1068514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnFormattingFailure(EventHandler<FormattingErrorEventArgs> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_remove_OnFormattingFailure_Public_rem_Void_EventHandler_1_FormattingErrorEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600032D RID: 813 RVA: 0x00015D5C File Offset: 0x00013F5C
		public unsafe List<ISource> SourceExtensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_get_SourceExtensions_Public_get_List_1_ISource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ISource>>(intPtr3) : null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00015D9C File Offset: 0x00013F9C
		public unsafe List<IFormatter> FormatterExtensions
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_get_FormatterExtensions_Public_get_List_1_IFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IFormatter>>(intPtr3) : null;
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00015DDC File Offset: 0x00013FDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068539, RefRangeEnd = 1068542, XrefRangeStart = 1068514, XrefRangeEnd = 1068539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00015E18 File Offset: 0x00014018
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1068572, RefRangeEnd = 1068579, XrefRangeStart = 1068542, XrefRangeEnd = 1068572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetNotEmptyFormatterExtensionNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_GetNotEmptyFormatterExtensionNames_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00015E58 File Offset: 0x00014058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068579, XrefRangeEnd = 1068583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtensions([Optional] Il2CppReferenceArray<ISource> sourceExtensions)
		{
			if (sourceExtensions == null)
			{
				sourceExtensions = new Il2CppReferenceArray<ISource>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceExtensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_ISource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00015EA8 File Offset: 0x000140A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068583, XrefRangeEnd = 1068588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddExtensions([Optional] Il2CppReferenceArray<IFormatter> formatterExtensions)
		{
			if (formatterExtensions == null)
			{
				formatterExtensions = new Il2CppReferenceArray<IFormatter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatterExtensions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_IFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00015EF8 File Offset: 0x000140F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068588, XrefRangeEnd = 1068591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetSourceExtension<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.MethodInfoStoreGeneric_GetSourceExtension_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00015F34 File Offset: 0x00014134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068591, XrefRangeEnd = 1068594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetFormatterExtension<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.MethodInfoStoreGeneric_GetFormatterExtension_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00015F70 File Offset: 0x00014170
		// (set) Token: 0x06000336 RID: 822 RVA: 0x00015FB0 File Offset: 0x000141B0
		public unsafe Parser Parser
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_get_Parser_Public_get_Parser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_set_Parser_Public_set_Void_Parser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00015FF4 File Offset: 0x000141F4
		// (set) Token: 0x06000338 RID: 824 RVA: 0x00016034 File Offset: 0x00014234
		public unsafe SmartSettings Settings
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00016078 File Offset: 0x00014278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068595, RefRangeEnd = 1068596, XrefRangeStart = 1068594, XrefRangeEnd = 1068595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_Format_Public_String_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000160E0 File Offset: 0x000142E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068596, XrefRangeEnd = 1068597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(IList<Object> args, string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IList_1_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001613C File Offset: 0x0001433C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068597, XrefRangeEnd = 1068598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000161B8 File Offset: 0x000143B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1068640, RefRangeEnd = 1068647, XrefRangeStart = 1068598, XrefRangeEnd = 1068640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Format(IFormatProvider provider, IList<Object> args, string format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_Format_Public_String_IFormatProvider_IList_1_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00016224 File Offset: 0x00014424
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1068666, RefRangeEnd = 1068670, XrefRangeStart = 1068647, XrefRangeEnd = 1068666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FormatInto(IOutput output, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_FormatInto_Public_Void_IOutput_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00016298 File Offset: 0x00014498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068670, XrefRangeEnd = 1068671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatWithCache(ref FormatCache cache, string format, IList<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new FormatCache(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001631C File Offset: 0x0001451C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1068714, RefRangeEnd = 1068717, XrefRangeStart = 1068671, XrefRangeEnd = 1068714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FormatWithCache(ref FormatCache cache, string format, IFormatProvider formatProvider, IList<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IFormatProvider_IList_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new FormatCache(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000163B4 File Offset: 0x000145B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068717, XrefRangeEnd = 1068737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FormatWithCacheInto(ref FormatCache cache, IOutput output, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_FormatWithCacheInto_Public_Void_byref_FormatCache_IOutput_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			cache = ((intPtr4 == 0) ? null : new FormatCache(intPtr4));
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00016450 File Offset: 0x00014650
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1068756, RefRangeEnd = 1068760, XrefRangeStart = 1068737, XrefRangeEnd = 1068756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Format(FormatDetails formatDetails, Format format, Object current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_Format_Private_Void_FormatDetails_Format_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000164B8 File Offset: 0x000146B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068760, XrefRangeEnd = 1068800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Format(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmartFormatter.NativeMethodInfoPtr_Format_Public_Virtual_New_Void_FormattingInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00016508 File Offset: 0x00014708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068812, RefRangeEnd = 1068813, XrefRangeStart = 1068800, XrefRangeEnd = 1068812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FormatError(FormatItem errorItem, Exception innerException, int startIndex, FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_FormatError_Private_Void_FormatItem_Exception_Int32_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00016580 File Offset: 0x00014780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068813, XrefRangeEnd = 1068815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForExtensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_CheckForExtensions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000165B4 File Offset: 0x000147B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068838, RefRangeEnd = 1068839, XrefRangeStart = 1068815, XrefRangeEnd = 1068838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateSelectors(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_EvaluateSelectors_Private_Void_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000165F8 File Offset: 0x000147F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1068852, RefRangeEnd = 1068854, XrefRangeStart = 1068839, XrefRangeEnd = 1068852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeSourceExtensions(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_InvokeSourceExtensions_Private_Boolean_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00016648 File Offset: 0x00014848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068855, RefRangeEnd = 1068856, XrefRangeStart = 1068854, XrefRangeEnd = 1068855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateFormatters(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_EvaluateFormatters_Private_Void_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001668C File Offset: 0x0001488C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1068874, RefRangeEnd = 1068875, XrefRangeStart = 1068856, XrefRangeEnd = 1068874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeFormatterExtensions(FormattingInfo formattingInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formattingInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_InvokeFormatterExtensions_Private_Boolean_FormattingInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000166DC File Offset: 0x000148DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00016710 File Offset: 0x00014910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatter.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000031BC File Offset: 0x000013BC
		public void AddExtensions(params ISource[] sourceExtensions)
		{
			this.AddExtensions(new Il2CppReferenceArray<ISource>(sourceExtensions));
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000031CA File Offset: 0x000013CA
		public void AddExtensions(params IFormatter[] formatterExtensions)
		{
			this.AddExtensions(new Il2CppReferenceArray<IFormatter>(formatterExtensions));
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000031D8 File Offset: 0x000013D8
		public string Format(string format, params Object[] args)
		{
			return this.Format(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000031E7 File Offset: 0x000013E7
		public string Format(IFormatProvider provider, string format, params Object[] args)
		{
			return this.Format(provider, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000031F7 File Offset: 0x000013F7
		public void FormatInto(IOutput output, string format, params Object[] args)
		{
			this.FormatInto(output, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003207 File Offset: 0x00001407
		public void FormatWithCacheInto(ref FormatCache cache, IOutput output, string format, params Object[] args)
		{
			this.FormatWithCacheInto(ref cache, output, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003219 File Offset: 0x00001419
		public SmartFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00016744 File Offset: 0x00014944
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00003222 File Offset: 0x00001422
		public unsafe SmartSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmartSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00016774 File Offset: 0x00014974
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003241 File Offset: 0x00001441
		public unsafe Parser m_Parser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Parser);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Parser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Parser), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000167A4 File Offset: 0x000149A4
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00003260 File Offset: 0x00001460
		public unsafe List<ISource> m_Sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000358 RID: 856 RVA: 0x000167D4 File Offset: 0x000149D4
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000327F File Offset: 0x0000147F
		public unsafe List<IFormatter> m_Formatters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Formatters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IFormatter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_Formatters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00016804 File Offset: 0x00014A04
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000329E File Offset: 0x0000149E
		public unsafe List<string> m_NotEmptyFormatterExtensionNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_NotEmptyFormatterExtensionNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_m_NotEmptyFormatterExtensionNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00016834 File Offset: 0x00014A34
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000032BD File Offset: 0x000014BD
		public unsafe static Il2CppReferenceArray<Object> k_Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SmartFormatter.NativeFieldInfoPtr_k_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SmartFormatter.NativeFieldInfoPtr_k_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001685C File Offset: 0x00014A5C
		// (set) Token: 0x0600035F RID: 863 RVA: 0x000032CF File Offset: 0x000014CF
		public unsafe EventHandler<FormattingErrorEventArgs> OnFormattingFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_OnFormattingFailure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<FormattingErrorEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmartFormatter.NativeFieldInfoPtr_OnFormattingFailure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_m_Parser;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_m_Sources;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_m_Formatters;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_m_NotEmptyFormatterExtensionNames;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_k_Empty;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_OnFormattingFailure;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_add_OnFormattingFailure_Public_add_Void_EventHandler_1_FormattingErrorEventArgs_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnFormattingFailure_Public_rem_Void_EventHandler_1_FormattingErrorEventArgs_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceExtensions_Public_get_List_1_ISource_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatterExtensions_Public_get_List_1_IFormatter_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_GetNotEmptyFormatterExtensionNames_Public_List_1_String_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_ISource_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_AddExtensions_Public_Void_Il2CppReferenceArray_1_IFormatter_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceExtension_Public_T_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_GetFormatterExtension_Public_T_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_Parser_Public_get_Parser_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_set_Parser_Public_set_Void_Parser_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_SmartSettings_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_set_Settings_Public_set_Void_SmartSettings_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_IList_1_Object_String_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_String_IFormatProvider_IList_1_Object_String_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_FormatInto_Public_Void_IOutput_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IList_1_Object_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_FormatWithCache_Public_String_byref_FormatCache_String_IFormatProvider_IList_1_Object_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_FormatWithCacheInto_Public_Void_byref_FormatCache_IOutput_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_Format_Private_Void_FormatDetails_Format_Object_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Virtual_New_Void_FormattingInfo_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_FormatError_Private_Void_FormatItem_Exception_Int32_FormattingInfo_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_CheckForExtensions_Private_Void_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateSelectors_Private_Void_FormattingInfo_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSourceExtensions_Private_Boolean_FormattingInfo_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateFormatters_Private_Void_FormattingInfo_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_InvokeFormatterExtensions_Private_Boolean_FormattingInfo_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200012C RID: 300
		private sealed class MethodInfoStoreGeneric_GetSourceExtension_Public_T_0<T>
		{
			// Token: 0x04000939 RID: 2361
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SmartFormatter.NativeMethodInfoPtr_GetSourceExtension_Public_T_0, Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200012D RID: 301
		private sealed class MethodInfoStoreGeneric_GetFormatterExtension_Public_T_0<T>
		{
			// Token: 0x0400093A RID: 2362
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SmartFormatter.NativeMethodInfoPtr_GetFormatterExtension_Public_T_0, Il2CppClassPointerStore<SmartFormatter>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000018 RID: 24
	public static class LoggerRuleSelector : Object
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00004F14 File Offset: 0x00003114
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerRuleSelector()
		{
			Il2CppClassPointerStore<LoggerRuleSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerRuleSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerRuleSelector>.NativeClassPtr);
			LoggerRuleSelector.NativeMethodInfoPtr_Select_Public_Static_Void_LoggerFilterOptions_Type_String_byref_Nullable_1_LogLevel_byref_Func_4_String_String_LogLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerRuleSelector>.NativeClassPtr, 100663371);
			LoggerRuleSelector.NativeMethodInfoPtr_IsBetter_Private_Static_Boolean_LoggerFilterRule_LoggerFilterRule_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerRuleSelector>.NativeClassPtr, 100663372);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004F6C File Offset: 0x0000316C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1264373, RefRangeEnd = 1264374, XrefRangeStart = 1264350, XrefRangeEnd = 1264373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Select(LoggerFilterOptions options, Type providerType, string category, out Nullable<LogLevel> minLevel, out Func<string, string, LogLevel, bool> filter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LoggerRuleSelector.NativeMethodInfoPtr_Select_Public_Static_Void_LoggerFilterOptions_Type_String_byref_Nullable_1_LogLevel_byref_Func_4_String_String_LogLevel_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			minLevel = ((intPtr5 == 0) ? null : new Nullable<LogLevel>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			filter = ((intPtr6 == 0) ? null : new Func<string, string, LogLevel, bool>(intPtr6));
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000500C File Offset: 0x0000320C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1264395, RefRangeEnd = 1264397, XrefRangeStart = 1264374, XrefRangeEnd = 1264395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBetter(LoggerFilterRule rule, LoggerFilterRule current, string logger, string category)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rule);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(logger);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerRuleSelector.NativeMethodInfoPtr_IsBetter_Private_Static_Boolean_LoggerFilterRule_LoggerFilterRule_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000026E6 File Offset: 0x000008E6
		public LoggerRuleSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Static_Void_LoggerFilterOptions_Type_String_byref_Nullable_1_LogLevel_byref_Func_4_String_String_LogLevel_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_IsBetter_Private_Static_Boolean_LoggerFilterRule_LoggerFilterRule_String_String_0;
	}
}

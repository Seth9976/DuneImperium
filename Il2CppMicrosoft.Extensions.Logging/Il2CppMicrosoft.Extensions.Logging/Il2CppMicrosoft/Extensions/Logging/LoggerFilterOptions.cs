using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000013 RID: 19
	public class LoggerFilterOptions : Object
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000041CC File Offset: 0x000023CC
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerFilterOptions()
		{
			Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerFilterOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr);
			LoggerFilterOptions.NativeFieldInfoPtr__CaptureScopes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, "<CaptureScopes>k__BackingField");
			LoggerFilterOptions.NativeFieldInfoPtr__MinLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, "<MinLevel>k__BackingField");
			LoggerFilterOptions.NativeFieldInfoPtr__RulesInternal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, "<RulesInternal>k__BackingField");
			LoggerFilterOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, 100663349);
			LoggerFilterOptions.NativeMethodInfoPtr_get_CaptureScopes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, 100663350);
			LoggerFilterOptions.NativeMethodInfoPtr_get_MinLevel_Public_get_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, 100663351);
			LoggerFilterOptions.NativeMethodInfoPtr_set_MinLevel_Public_set_Void_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, 100663352);
			LoggerFilterOptions.NativeMethodInfoPtr_get_RulesInternal_Internal_get_List_1_LoggerFilterRule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr, 100663353);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000429C File Offset: 0x0000249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264325, XrefRangeEnd = 1264333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFilterOptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFilterOptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000042D8 File Offset: 0x000024D8
		public unsafe bool CaptureScopes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterOptions.NativeMethodInfoPtr_get_CaptureScopes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004314 File Offset: 0x00002514
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00004350 File Offset: 0x00002550
		public unsafe LogLevel MinLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterOptions.NativeMethodInfoPtr_get_MinLevel_Public_get_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterOptions.NativeMethodInfoPtr_set_MinLevel_Public_set_Void_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe List<LoggerFilterRule> RulesInternal
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFilterOptions.NativeMethodInfoPtr_get_RulesInternal_Internal_get_List_1_LoggerFilterRule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LoggerFilterRule>>(intPtr3) : null;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002443 File Offset: 0x00000643
		public LoggerFilterOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000043D0 File Offset: 0x000025D0
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000244C File Offset: 0x0000064C
		public unsafe bool _CaptureScopes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__CaptureScopes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__CaptureScopes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe LogLevel _MinLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__MinLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__MinLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00004420 File Offset: 0x00002620
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002482 File Offset: 0x00000682
		public unsafe List<LoggerFilterRule> _RulesInternal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__RulesInternal_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoggerFilterRule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFilterOptions.NativeFieldInfoPtr__RulesInternal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr__CaptureScopes_k__BackingField;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__MinLevel_k__BackingField;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr__RulesInternal_k__BackingField;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_CaptureScopes_Public_get_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_MinLevel_Public_get_LogLevel_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_set_MinLevel_Public_set_Void_LogLevel_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_RulesInternal_Internal_get_List_1_LoggerFilterRule_0;
	}
}

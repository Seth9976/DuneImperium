using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000017 RID: 23
	public sealed class LoggerInformation : ValueType
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x00004C14 File Offset: 0x00002E14
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerInformation()
		{
			Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr);
			LoggerInformation.NativeFieldInfoPtr__Logger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, "<Logger>k__BackingField");
			LoggerInformation.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, "<Category>k__BackingField");
			LoggerInformation.NativeFieldInfoPtr__ProviderType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, "<ProviderType>k__BackingField");
			LoggerInformation.NativeFieldInfoPtr__ExternalScope_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, "<ExternalScope>k__BackingField");
			LoggerInformation.NativeMethodInfoPtr__ctor_Public_Void_ILoggerProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, 100663366);
			LoggerInformation.NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, 100663367);
			LoggerInformation.NativeMethodInfoPtr_get_Category_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, 100663368);
			LoggerInformation.NativeMethodInfoPtr_get_ProviderType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, 100663369);
			LoggerInformation.NativeMethodInfoPtr_get_ExternalScope_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr, 100663370);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264340, XrefRangeEnd = 1264350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerInformation(ILoggerProvider provider, string category)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerInformation.NativeMethodInfoPtr__ctor_Public_Void_ILoggerProvider_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004D5C File Offset: 0x00002F5C
		public unsafe ILogger Logger
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerInformation.NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public unsafe string Category
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerInformation.NativeMethodInfoPtr_get_Category_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004DDC File Offset: 0x00002FDC
		public unsafe Type ProviderType
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerInformation.NativeMethodInfoPtr_get_ProviderType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004E20 File Offset: 0x00003020
		public unsafe bool ExternalScope
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerInformation.NativeMethodInfoPtr_get_ExternalScope_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002653 File Offset: 0x00000853
		public LoggerInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000265C File Offset: 0x0000085C
		public LoggerInformation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerInformation>.NativeClassPtr))
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004E64 File Offset: 0x00003064
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000266E File Offset: 0x0000086E
		public unsafe ILogger _Logger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__Logger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__Logger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004E94 File Offset: 0x00003094
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000268D File Offset: 0x0000088D
		public unsafe string _Category_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__Category_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__Category_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004EBC File Offset: 0x000030BC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000026AC File Offset: 0x000008AC
		public unsafe Type _ProviderType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__ProviderType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__ProviderType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000026CB File Offset: 0x000008CB
		public unsafe bool _ExternalScope_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__ExternalScope_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerInformation.NativeFieldInfoPtr__ExternalScope_k__BackingField)) = value;
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr__Logger_k__BackingField;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__Category_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr__ProviderType_k__BackingField;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr__ExternalScope_k__BackingField;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILoggerProvider_String_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_Logger_Public_get_ILogger_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_Category_Public_get_String_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderType_Public_get_Type_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_ExternalScope_Public_get_Boolean_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Extensions.Options;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x0200000E RID: 14
	public sealed class DefaultLoggerLevelConfigureOptions : ConfigureOptions<LoggerFilterOptions>
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002218 File Offset: 0x00000418
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultLoggerLevelConfigureOptions()
		{
			Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "DefaultLoggerLevelConfigureOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions>.NativeClassPtr);
			DefaultLoggerLevelConfigureOptions.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003228 File Offset: 0x00001428
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1263948, RefRangeEnd = 1263951, XrefRangeStart = 1263934, XrefRangeEnd = 1263948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultLoggerLevelConfigureOptions(LogLevel level)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoggerLevelConfigureOptions.NativeMethodInfoPtr__ctor_Public_Void_LogLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002251 File Offset: 0x00000451
		public DefaultLoggerLevelConfigureOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogLevel_0;

		// Token: 0x0200001D RID: 29
		[ObfuscatedName("Microsoft.Extensions.Logging.DefaultLoggerLevelConfigureOptions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x000053C8 File Offset: 0x000035C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr);
				DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr, "level");
				DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr, 100663316);
				DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_LoggerFilterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr, 100663317);
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00005430 File Offset: 0x00003630
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DB RID: 219 RVA: 0x0000546C File Offset: 0x0000366C
			[CallerCount(0)]
			public unsafe void __ctor_b__0(LoggerFilterOptions options)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeMethodInfoPtr___ctor_b__0_Internal_Void_LoggerFilterOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000DC RID: 220 RVA: 0x000027C3 File Offset: 0x000009C3
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000DD RID: 221 RVA: 0x000054B0 File Offset: 0x000036B0
			// (set) Token: 0x060000DE RID: 222 RVA: 0x000027CC File Offset: 0x000009CC
			public unsafe LogLevel level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultLoggerLevelConfigureOptions.__c__DisplayClass0_0.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Void_LoggerFilterOptions_0;
		}
	}
}

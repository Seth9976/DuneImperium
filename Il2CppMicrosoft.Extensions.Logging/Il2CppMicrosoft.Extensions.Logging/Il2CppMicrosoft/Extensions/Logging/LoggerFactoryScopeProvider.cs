using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000012 RID: 18
	public sealed class LoggerFactoryScopeProvider : Object
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000040C0 File Offset: 0x000022C0
		// Note: this type is marked as 'beforefieldinit'.
		static LoggerFactoryScopeProvider()
		{
			Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggerFactoryScopeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr);
			LoggerFactoryScopeProvider.NativeFieldInfoPtr__currentScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr, "_currentScope");
			LoggerFactoryScopeProvider.NativeFieldInfoPtr__activityTrackingOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr, "_activityTrackingOption");
			LoggerFactoryScopeProvider.NativeMethodInfoPtr__ctor_Public_Void_ActivityTrackingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000412C File Offset: 0x0000232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264317, XrefRangeEnd = 1264325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggerFactoryScopeProvider(ActivityTrackingOptions activityTrackingOption)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref activityTrackingOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactoryScopeProvider.NativeMethodInfoPtr__ctor_Public_Void_ActivityTrackingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002400 File Offset: 0x00000600
		public LoggerFactoryScopeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004174 File Offset: 0x00002374
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002409 File Offset: 0x00000609
		public unsafe AsyncLocal<LoggerFactoryScopeProvider.Scope> _currentScope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.NativeFieldInfoPtr__currentScope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncLocal<LoggerFactoryScopeProvider.Scope>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.NativeFieldInfoPtr__currentScope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000041A4 File Offset: 0x000023A4
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002428 File Offset: 0x00000628
		public unsafe ActivityTrackingOptions _activityTrackingOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.NativeFieldInfoPtr__activityTrackingOption);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.NativeFieldInfoPtr__activityTrackingOption)) = value;
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__currentScope;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr__activityTrackingOption;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActivityTrackingOptions_0;

		// Token: 0x02000024 RID: 36
		public sealed class Scope : Object
		{
			// Token: 0x060000F5 RID: 245 RVA: 0x00005800 File Offset: 0x00003A00
			// Note: this type is marked as 'beforefieldinit'.
			static Scope()
			{
				Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoggerFactoryScopeProvider>.NativeClassPtr, "Scope");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr);
				LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr, "_provider");
				LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr, "_isDisposed");
				LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr, "<Parent>k__BackingField");
				LoggerFactoryScopeProvider.Scope.NativeMethodInfoPtr_get_Parent_Public_get_Scope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr, 100663347);
				LoggerFactoryScopeProvider.Scope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggerFactoryScopeProvider.Scope>.NativeClassPtr, 100663348);
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x00005890 File Offset: 0x00003A90
			public unsafe LoggerFactoryScopeProvider.Scope Parent
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactoryScopeProvider.Scope.NativeMethodInfoPtr_get_Parent_Public_get_Scope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoggerFactoryScopeProvider.Scope>(intPtr3) : null;
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x000058D0 File Offset: 0x00003AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264314, XrefRangeEnd = 1264317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggerFactoryScopeProvider.Scope.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x000028D5 File Offset: 0x00000AD5
			public Scope(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005904 File Offset: 0x00003B04
			// (set) Token: 0x060000FA RID: 250 RVA: 0x000028DE File Offset: 0x00000ADE
			public unsafe LoggerFactoryScopeProvider _provider
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__provider);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggerFactoryScopeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__provider), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00005934 File Offset: 0x00003B34
			// (set) Token: 0x060000FC RID: 252 RVA: 0x000028FD File Offset: 0x00000AFD
			public unsafe bool _isDisposed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__isDisposed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__isDisposed)) = value;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000FD RID: 253 RVA: 0x0000595C File Offset: 0x00003B5C
			// (set) Token: 0x060000FE RID: 254 RVA: 0x00002918 File Offset: 0x00000B18
			public unsafe LoggerFactoryScopeProvider.Scope _Parent_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__Parent_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoggerFactoryScopeProvider.Scope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggerFactoryScopeProvider.Scope.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400008C RID: 140
			private static readonly IntPtr NativeFieldInfoPtr__provider;

			// Token: 0x0400008D RID: 141
			private static readonly IntPtr NativeFieldInfoPtr__isDisposed;

			// Token: 0x0400008E RID: 142
			private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

			// Token: 0x0400008F RID: 143
			private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_Scope_0;

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}

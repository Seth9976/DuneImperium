using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000016 RID: 22
	public sealed class ScopeLogger : ValueType
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00004AE4 File Offset: 0x00002CE4
		// Note: this type is marked as 'beforefieldinit'.
		static ScopeLogger()
		{
			Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "ScopeLogger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr);
			ScopeLogger.NativeFieldInfoPtr__Logger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr, "<Logger>k__BackingField");
			ScopeLogger.NativeFieldInfoPtr__ExternalScopeProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr, "<ExternalScopeProvider>k__BackingField");
			ScopeLogger.NativeMethodInfoPtr__ctor_Public_Void_ILogger_IExternalScopeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr, 100663365);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004B50 File Offset: 0x00002D50
		[CallerCount(238)]
		[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScopeLogger(ILogger logger, IExternalScopeProvider externalScopeProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logger);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(externalScopeProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopeLogger.NativeMethodInfoPtr__ctor_Public_Void_ILogger_IExternalScopeProvider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000025FA File Offset: 0x000007FA
		public ScopeLogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002603 File Offset: 0x00000803
		public ScopeLogger()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopeLogger>.NativeClassPtr))
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004BB4 File Offset: 0x00002DB4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002615 File Offset: 0x00000815
		public unsafe ILogger _Logger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeLogger.NativeFieldInfoPtr__Logger_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeLogger.NativeFieldInfoPtr__Logger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004BE4 File Offset: 0x00002DE4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002634 File Offset: 0x00000834
		public unsafe IExternalScopeProvider _ExternalScopeProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeLogger.NativeFieldInfoPtr__ExternalScopeProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IExternalScopeProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopeLogger.NativeFieldInfoPtr__ExternalScopeProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr__Logger_k__BackingField;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr__ExternalScopeProvider_k__BackingField;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogger_IExternalScopeProvider_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Extensions.DependencyInjection;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Logging
{
	// Token: 0x02000019 RID: 25
	public sealed class LoggingBuilder : Object
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00005084 File Offset: 0x00003284
		// Note: this type is marked as 'beforefieldinit'.
		static LoggingBuilder()
		{
			Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Logging.dll", "Microsoft.Extensions.Logging", "LoggingBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr);
			LoggingBuilder.NativeFieldInfoPtr__Services_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr, "<Services>k__BackingField");
			LoggingBuilder.NativeMethodInfoPtr__ctor_Public_Void_IServiceCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr, 100663373);
			LoggingBuilder.NativeMethodInfoPtr_get_Services_Public_Virtual_Final_New_get_IServiceCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr, 100663374);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000050F0 File Offset: 0x000032F0
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggingBuilder(IServiceCollection services)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoggingBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(services);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggingBuilder.NativeMethodInfoPtr__ctor_Public_Void_IServiceCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000513C File Offset: 0x0000333C
		public unsafe IServiceCollection Services
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoggingBuilder.NativeMethodInfoPtr_get_Services_Public_Virtual_Final_New_get_IServiceCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000026EF File Offset: 0x000008EF
		public LoggingBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000517C File Offset: 0x0000337C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000026F8 File Offset: 0x000008F8
		public unsafe IServiceCollection _Services_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggingBuilder.NativeFieldInfoPtr__Services_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IServiceCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoggingBuilder.NativeFieldInfoPtr__Services_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr__Services_k__BackingField;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IServiceCollection_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_Services_Public_Virtual_Final_New_get_IServiceCollection_0;
	}
}

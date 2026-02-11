using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using JsonFx.Serialization.Resolvers;

namespace JsonFx.Serialization
{
	// Token: 0x02000005 RID: 5
	public sealed class DataReaderSettings : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00004198 File Offset: 0x00002398
		// Note: this type is marked as 'beforefieldinit'.
		static DataReaderSettings()
		{
			Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "DataReaderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr);
			DataReaderSettings.NativeFieldInfoPtr_allowTrailingContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, "allowTrailingContent");
			DataReaderSettings.NativeFieldInfoPtr_ResolverCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, "ResolverCache");
			DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663310);
			DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663311);
			DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663312);
			DataReaderSettings.NativeMethodInfoPtr_get_AllowTrailingContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663313);
			DataReaderSettings.NativeMethodInfoPtr_set_AllowTrailingContent_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663314);
			DataReaderSettings.NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr, 100663315);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004268 File Offset: 0x00002468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189717, RefRangeEnd = 1189719, XrefRangeStart = 1189707, XrefRangeEnd = 1189717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataReaderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000042A4 File Offset: 0x000024A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189725, RefRangeEnd = 1189727, XrefRangeStart = 1189719, XrefRangeEnd = 1189725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataReaderSettings(IResolverStrategy strategy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000042F0 File Offset: 0x000024F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189727, XrefRangeEnd = 1189729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataReaderSettings(ResolverCache resolverCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataReaderSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolverCache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000433C File Offset: 0x0000253C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00004378 File Offset: 0x00002578
		public unsafe bool AllowTrailingContent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr_get_AllowTrailingContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr_set_AllowTrailingContent_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000043B8 File Offset: 0x000025B8
		public unsafe ResolverCache Resolver
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataReaderSettings.NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResolverCache>(intPtr3) : null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000206B File Offset: 0x0000026B
		public DataReaderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000043F8 File Offset: 0x000025F8
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe bool allowTrailingContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataReaderSettings.NativeFieldInfoPtr_allowTrailingContent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataReaderSettings.NativeFieldInfoPtr_allowTrailingContent)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004420 File Offset: 0x00002620
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000208F File Offset: 0x0000028F
		public unsafe ResolverCache ResolverCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataReaderSettings.NativeFieldInfoPtr_ResolverCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolverCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataReaderSettings.NativeFieldInfoPtr_ResolverCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_allowTrailingContent;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_ResolverCache;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowTrailingContent_Public_get_Boolean_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowTrailingContent_Public_set_Void_Boolean_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0;
	}
}

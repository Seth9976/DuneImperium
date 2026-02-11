using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using JsonFx.Serialization.GraphCycles;
using JsonFx.Serialization.Resolvers;

namespace JsonFx.Serialization
{
	// Token: 0x02000006 RID: 6
	public sealed class DataWriterSettings : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00004450 File Offset: 0x00002650
		// Note: this type is marked as 'beforefieldinit'.
		static DataWriterSettings()
		{
			Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "DataWriterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr);
			DataWriterSettings.NativeFieldInfoPtr_prettyPrint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "prettyPrint");
			DataWriterSettings.NativeFieldInfoPtr_graphCycles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "graphCycles");
			DataWriterSettings.NativeFieldInfoPtr_tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "tab");
			DataWriterSettings.NativeFieldInfoPtr_maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "maxDepth");
			DataWriterSettings.NativeFieldInfoPtr_newLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "newLine");
			DataWriterSettings.NativeFieldInfoPtr_ResolverCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, "ResolverCache");
			DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663316);
			DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663317);
			DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663318);
			DataWriterSettings.NativeMethodInfoPtr_get_GraphCycles_Public_get_GraphCycleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663319);
			DataWriterSettings.NativeMethodInfoPtr_set_GraphCycles_Public_set_Void_GraphCycleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663320);
			DataWriterSettings.NativeMethodInfoPtr_get_MaxDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663321);
			DataWriterSettings.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663322);
			DataWriterSettings.NativeMethodInfoPtr_get_PrettyPrint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663323);
			DataWriterSettings.NativeMethodInfoPtr_set_PrettyPrint_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663324);
			DataWriterSettings.NativeMethodInfoPtr_get_Tab_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663325);
			DataWriterSettings.NativeMethodInfoPtr_set_Tab_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663326);
			DataWriterSettings.NativeMethodInfoPtr_get_NewLine_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663327);
			DataWriterSettings.NativeMethodInfoPtr_set_NewLine_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663328);
			DataWriterSettings.NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr, 100663329);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004610 File Offset: 0x00002810
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1189745, RefRangeEnd = 1189748, XrefRangeStart = 1189729, XrefRangeEnd = 1189745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataWriterSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000464C File Offset: 0x0000284C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1189760, RefRangeEnd = 1189763, XrefRangeStart = 1189748, XrefRangeEnd = 1189760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataWriterSettings(IResolverStrategy strategy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004698 File Offset: 0x00002898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189763, XrefRangeEnd = 1189771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataWriterSettings(ResolverCache resolverCache)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataWriterSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolverCache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000046E4 File Offset: 0x000028E4
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00004720 File Offset: 0x00002920
		public unsafe GraphCycleType GraphCycles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_GraphCycles_Public_get_GraphCycleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_set_GraphCycles_Public_set_Void_GraphCycleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004760 File Offset: 0x00002960
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000479C File Offset: 0x0000299C
		public unsafe int MaxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_MaxDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000047DC File Offset: 0x000029DC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004818 File Offset: 0x00002A18
		public unsafe bool PrettyPrint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_PrettyPrint_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_set_PrettyPrint_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00004858 File Offset: 0x00002A58
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00004890 File Offset: 0x00002A90
		public unsafe string Tab
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_Tab_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_set_Tab_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000048D4 File Offset: 0x00002AD4
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000490C File Offset: 0x00002B0C
		public unsafe string NewLine
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_NewLine_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_set_NewLine_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00004950 File Offset: 0x00002B50
		public unsafe ResolverCache Resolver
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataWriterSettings.NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResolverCache>(intPtr3) : null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020AE File Offset: 0x000002AE
		public DataWriterSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004990 File Offset: 0x00002B90
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000020B7 File Offset: 0x000002B7
		public unsafe bool prettyPrint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_prettyPrint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_prettyPrint)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000049B8 File Offset: 0x00002BB8
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000020D2 File Offset: 0x000002D2
		public unsafe GraphCycleType graphCycles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_graphCycles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_graphCycles)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000020ED File Offset: 0x000002ED
		public unsafe string tab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_tab);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_tab), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004A08 File Offset: 0x00002C08
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000210C File Offset: 0x0000030C
		public unsafe int maxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_maxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_maxDepth)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004A30 File Offset: 0x00002C30
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00002127 File Offset: 0x00000327
		public unsafe string newLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_newLine);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_newLine), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00004A58 File Offset: 0x00002C58
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002146 File Offset: 0x00000346
		public unsafe ResolverCache ResolverCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_ResolverCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResolverCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataWriterSettings.NativeFieldInfoPtr_ResolverCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_prettyPrint;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_graphCycles;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_tab;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_maxDepth;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_newLine;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_ResolverCache;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResolverCache_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_GraphCycles_Public_get_GraphCycleType_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_GraphCycles_Public_set_Void_GraphCycleType_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDepth_Public_get_Int32_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDepth_Public_set_Void_Int32_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_PrettyPrint_Public_get_Boolean_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_set_PrettyPrint_Public_set_Void_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_Tab_Public_get_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_set_Tab_Public_set_Void_String_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_get_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_NewLine_Public_set_Void_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolver_Public_get_ResolverCache_0;
	}
}

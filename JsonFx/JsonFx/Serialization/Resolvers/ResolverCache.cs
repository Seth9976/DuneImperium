using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;

namespace JsonFx.Serialization.Resolvers
{
	// Token: 0x02000019 RID: 25
	public sealed class ResolverCache : Object
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00007F78 File Offset: 0x00006178
		// Note: this type is marked as 'beforefieldinit'.
		static ResolverCache()
		{
			Il2CppClassPointerStore<ResolverCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.Resolvers", "ResolverCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr);
			ResolverCache.NativeFieldInfoPtr_MemberCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, "MemberCache");
			ResolverCache.NativeFieldInfoPtr_EnumCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, "EnumCache");
			ResolverCache.NativeFieldInfoPtr_Factories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, "Factories");
			ResolverCache.NativeFieldInfoPtr_NameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, "NameCache");
			ResolverCache.NativeFieldInfoPtr_Strategy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, "Strategy");
			ResolverCache.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663424);
			ResolverCache.NativeMethodInfoPtr_SortMembers_Public_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663425);
			ResolverCache.NativeMethodInfoPtr_LoadTypeName_Public_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663426);
			ResolverCache.NativeMethodInfoPtr_LoadMaps_Public_IDictionary_2_String_MemberMap_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663427);
			ResolverCache.NativeMethodInfoPtr_LoadEnumMaps_Public_IDictionary_2_Enum_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663428);
			ResolverCache.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663429);
			ResolverCache.NativeMethodInfoPtr_BuildMap_Private_String_Type_byref_IDictionary_2_String_MemberMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663430);
			ResolverCache.NativeMethodInfoPtr_BuildEnumMap_Private_IDictionary_2_String_MemberMap_Type_byref_IDictionary_2_Enum_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663431);
			ResolverCache.NativeMethodInfoPtr_LoadFactory_Public_FactoryMap_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr, 100663432);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000080C0 File Offset: 0x000062C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1190929, RefRangeEnd = 1190933, XrefRangeStart = 1190763, XrefRangeEnd = 1190929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResolverCache(IResolverStrategy strategy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolverCache>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(strategy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000810C File Offset: 0x0000630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190933, XrefRangeEnd = 1190936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<MemberMap> SortMembers(IEnumerable<MemberMap> members)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_SortMembers_Public_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000815C File Offset: 0x0000635C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190936, XrefRangeEnd = 1190944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LoadTypeName(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_LoadTypeName_Public_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000081A4 File Offset: 0x000063A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1190959, RefRangeEnd = 1190964, XrefRangeStart = 1190944, XrefRangeEnd = 1190959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, MemberMap> LoadMaps(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_LoadMaps_Public_IDictionary_2_String_MemberMap_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, MemberMap>>(intPtr3) : null;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000081F4 File Offset: 0x000063F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190964, XrefRangeEnd = 1190972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<Enum, string> LoadEnumMaps(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_LoadEnumMaps_Public_IDictionary_2_Enum_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<Enum, string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008244 File Offset: 0x00006444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190972, XrefRangeEnd = 1190985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008278 File Offset: 0x00006478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1191060, RefRangeEnd = 1191063, XrefRangeStart = 1190985, XrefRangeEnd = 1191060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BuildMap(Type objectType, out IDictionary<string, MemberMap> maps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_BuildMap_Private_String_Type_byref_IDictionary_2_String_MemberMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			maps = ((intPtr4 == 0) ? null : new IDictionary<string, MemberMap>(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000082E4 File Offset: 0x000064E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1191114, RefRangeEnd = 1191116, XrefRangeStart = 1191063, XrefRangeEnd = 1191114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary<string, MemberMap> BuildEnumMap(Type enumType, out IDictionary<Enum, string> enumMaps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_BuildEnumMap_Private_IDictionary_2_String_MemberMap_Type_byref_IDictionary_2_Enum_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			enumMaps = ((intPtr4 == 0) ? null : new IDictionary<Enum, string>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IDictionary<string, MemberMap>>(intPtr5) : null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008358 File Offset: 0x00006558
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1191137, RefRangeEnd = 1191140, XrefRangeStart = 1191116, XrefRangeEnd = 1191137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FactoryMap LoadFactory(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResolverCache.NativeMethodInfoPtr_LoadFactory_Public_FactoryMap_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FactoryMap>(intPtr3) : null;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002779 File Offset: 0x00000979
		public ResolverCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000083A8 File Offset: 0x000065A8
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00002782 File Offset: 0x00000982
		public unsafe ConcurrentDictionary<Type, IDictionary<string, MemberMap>> MemberCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_MemberCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, IDictionary<string, MemberMap>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_MemberCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000083D8 File Offset: 0x000065D8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000027A1 File Offset: 0x000009A1
		public unsafe ConcurrentDictionary<Type, IDictionary<Enum, string>> EnumCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_EnumCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, IDictionary<Enum, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_EnumCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00008408 File Offset: 0x00006608
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000027C0 File Offset: 0x000009C0
		public unsafe ConcurrentDictionary<Type, FactoryMap> Factories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_Factories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, FactoryMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_Factories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00008438 File Offset: 0x00006638
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000027DF File Offset: 0x000009DF
		public unsafe ConcurrentDictionary<Type, string> NameCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_NameCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_NameCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00008468 File Offset: 0x00006668
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000027FE File Offset: 0x000009FE
		public unsafe IResolverStrategy Strategy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_Strategy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResolverStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResolverCache.NativeFieldInfoPtr_Strategy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_MemberCache;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_EnumCache;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_Factories;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_NameCache;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr_Strategy;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResolverStrategy_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_SortMembers_Public_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_LoadTypeName_Public_String_Type_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_LoadMaps_Public_IDictionary_2_String_MemberMap_Type_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_LoadEnumMaps_Public_IDictionary_2_Enum_String_Type_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_BuildMap_Private_String_Type_byref_IDictionary_2_String_MemberMap_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_BuildEnumMap_Private_IDictionary_2_String_MemberMap_Type_byref_IDictionary_2_Enum_String_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_LoadFactory_Public_FactoryMap_Type_0;
	}
}

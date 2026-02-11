using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x02000022 RID: 34
	public class PlatformDependentTransformInstantiator : PlatformDependentInstantiator
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000068D8 File Offset: 0x00004AD8
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentTransformInstantiator()
		{
			Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentTransformInstantiator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr);
			PlatformDependentTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr, "PlatformPrefabs");
			PlatformDependentTransformInstantiator.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr, 100663420);
			PlatformDependentTransformInstantiator.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr, 100663421);
			PlatformDependentTransformInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr, 100663422);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006958 File Offset: 0x00004B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239589, XrefRangeEnd = 1239617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTransformInstantiator.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006994 File Offset: 0x00004B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239617, XrefRangeEnd = 1239641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentTransformInstantiator.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000069D0 File Offset: 0x00004BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239641, XrefRangeEnd = 1239649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentTransformInstantiator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002906 File Offset: 0x00000B06
		public PlatformDependentTransformInstantiator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00006A0C File Offset: 0x00004C0C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0000290F File Offset: 0x00000B0F
		public unsafe List<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair> PlatformPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_PlatformPrefabs;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003E RID: 62
		[Serializable]
		public class PlatformTransformPrefabPair : Object
		{
			// Token: 0x0600020A RID: 522 RVA: 0x00008DDC File Offset: 0x00006FDC
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformTransformPrefabPair()
			{
				Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentTransformInstantiator>.NativeClassPtr, "PlatformTransformPrefabPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr);
				PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr, "Platform");
				PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr, "Prefab");
				PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr, 100663423);
				PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr, 100663424);
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00008E58 File Offset: 0x00007058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239583, XrefRangeEnd = 1239589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformTransformPrefabPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00008E94 File Offset: 0x00007094
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformTransformPrefabPair(uint platform, PlatformDependentPrefab prefab)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentTransformInstantiator.PlatformTransformPrefabPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00002FB1 File Offset: 0x000011B1
			public PlatformTransformPrefabPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600020E RID: 526 RVA: 0x00008EF0 File Offset: 0x000070F0
			// (set) Token: 0x0600020F RID: 527 RVA: 0x00002FBA File Offset: 0x000011BA
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000210 RID: 528 RVA: 0x00008F18 File Offset: 0x00007118
			// (set) Token: 0x06000211 RID: 529 RVA: 0x00002FD5 File Offset: 0x000011D5
			public unsafe PlatformDependentPrefab Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentPrefab>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentTransformInstantiator.PlatformTransformPrefabPair.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentPrefab_0;
		}
	}
}

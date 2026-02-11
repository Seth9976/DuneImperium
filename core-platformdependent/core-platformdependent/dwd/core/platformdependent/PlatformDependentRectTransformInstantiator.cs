using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platformdependent
{
	// Token: 0x0200001A RID: 26
	public class PlatformDependentRectTransformInstantiator : PlatformDependentInstantiator
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000059DC File Offset: 0x00003BDC
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentRectTransformInstantiator()
		{
			Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentRectTransformInstantiator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr);
			PlatformDependentRectTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr, "PlatformPrefabs");
			PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr, 100663393);
			PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr, 100663394);
			PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005A5C File Offset: 0x00003C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239288, XrefRangeEnd = 1239318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005A98 File Offset: 0x00003C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239318, XrefRangeEnd = 1239342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005AD4 File Offset: 0x00003CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239342, XrefRangeEnd = 1239350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentRectTransformInstantiator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformInstantiator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002625 File Offset: 0x00000825
		public PlatformDependentRectTransformInstantiator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005B10 File Offset: 0x00003D10
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000262E File Offset: 0x0000082E
		public unsafe List<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair> PlatformPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.NativeFieldInfoPtr_PlatformPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_PlatformPrefabs;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003A RID: 58
		[Serializable]
		public class PlatformRectTransformPrefabPair : Object
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0000891C File Offset: 0x00006B1C
			// Note: this type is marked as 'beforefieldinit'.
			static PlatformRectTransformPrefabPair()
			{
				Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator>.NativeClassPtr, "PlatformRectTransformPrefabPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr);
				PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr, "Platform");
				PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr, "Prefab");
				PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr, 100663396);
				PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformPrefab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr, 100663397);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x00008998 File Offset: 0x00006B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239274, XrefRangeEnd = 1239288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformRectTransformPrefabPair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001EF RID: 495 RVA: 0x000089D4 File Offset: 0x00006BD4
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422893, XrefRangeStart = 422885, XrefRangeEnd = 422893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlatformRectTransformPrefabPair(uint platform, PlatformDependentRectTransformPrefab prefab)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref platform;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformPrefab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00002EA5 File Offset: 0x000010A5
			public PlatformRectTransformPrefabPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x00008A30 File Offset: 0x00006C30
			// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002EAE File Offset: 0x000010AE
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x00008A58 File Offset: 0x00006C58
			// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002EC9 File Offset: 0x000010C9
			public unsafe PlatformDependentRectTransformPrefab Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformDependentRectTransformPrefab>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentRectTransformInstantiator.PlatformRectTransformPrefabPair.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000110 RID: 272
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x04000111 RID: 273
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;

			// Token: 0x04000112 RID: 274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000113 RID: 275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_PlatformDependentRectTransformPrefab_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x02000008 RID: 8
	public static class TerrainUtility : Object
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00005BC4 File Offset: 0x00003DC4
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainUtility()
		{
			Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.TerrainUtils", "TerrainUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr);
			TerrainUtility.NativeMethodInfoPtr_ValidTerrainsExist_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663329);
			TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663330);
			TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_Dictionary_2_Int32_TerrainMap_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663331);
			TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005C44 File Offset: 0x00003E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1268730, RefRangeEnd = 1268732, XrefRangeStart = 1268728, XrefRangeEnd = 1268730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidTerrainsExist()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_ValidTerrainsExist_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005C74 File Offset: 0x00003E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268732, XrefRangeEnd = 1268739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearConnectivity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005C9C File Offset: 0x00003E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268782, RefRangeEnd = 1268783, XrefRangeStart = 1268739, XrefRangeEnd = 1268782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<int, TerrainMap> CollectTerrains(bool onlyAutoConnectedTerrains = true)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyAutoConnectedTerrains;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_CollectTerrains_Internal_Static_Dictionary_2_Int32_TerrainMap_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, TerrainMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005CDC File Offset: 0x00003EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268783, XrefRangeEnd = 1268828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoConnect()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002D53 File Offset: 0x00000F53
		public TerrainUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_ValidTerrainsExist_Internal_Static_Boolean_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_ClearConnectivity_Internal_Static_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_CollectTerrains_Internal_Static_Dictionary_2_Int32_TerrainMap_Boolean_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_AutoConnect_Public_Static_Void_0;

		// Token: 0x020000BE RID: 190
		[ObfuscatedName("UnityEngine.TerrainUtils.TerrainUtility+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000340 RID: 832 RVA: 0x000073A4 File Offset: 0x000055A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_0>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_0>.NativeClassPtr, "onlyAutoConnectedTerrains");
				TerrainUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_0>.NativeClassPtr, 100663333);
			}

			// Token: 0x06000341 RID: 833 RVA: 0x000073F8 File Offset: 0x000055F8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000342 RID: 834 RVA: 0x000036B1 File Offset: 0x000018B1
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000343 RID: 835 RVA: 0x00007434 File Offset: 0x00005634
			// (set) Token: 0x06000344 RID: 836 RVA: 0x000036BA File Offset: 0x000018BA
			public unsafe bool onlyAutoConnectedTerrains
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_onlyAutoConnectedTerrains)) = value;
				}
			}

			// Token: 0x04000141 RID: 321
			private static readonly IntPtr NativeFieldInfoPtr_onlyAutoConnectedTerrains;

			// Token: 0x04000142 RID: 322
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020000BF RID: 191
		[ObfuscatedName("UnityEngine.TerrainUtils.TerrainUtility+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : Object
		{
			// Token: 0x06000345 RID: 837 RVA: 0x0000745C File Offset: 0x0000565C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainUtility>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr);
				TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr, "t");
				TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr, "CS$<>8__locals1");
				TerrainUtility.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr, 100663334);
				TerrainUtility.__c__DisplayClass2_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr, 100663335);
			}

			// Token: 0x06000346 RID: 838 RVA: 0x000074D8 File Offset: 0x000056D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainUtility.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000347 RID: 839 RVA: 0x00007514 File Offset: 0x00005714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268720, XrefRangeEnd = 1268728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CollectTerrains_b__0(Terrain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainUtility.__c__DisplayClass2_1.NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000348 RID: 840 RVA: 0x000036D5 File Offset: 0x000018D5
			public __c__DisplayClass2_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000349 RID: 841 RVA: 0x00007564 File Offset: 0x00005764
			// (set) Token: 0x0600034A RID: 842 RVA: 0x000036DE File Offset: 0x000018DE
			public unsafe Terrain t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600034B RID: 843 RVA: 0x00007594 File Offset: 0x00005794
			// (set) Token: 0x0600034C RID: 844 RVA: 0x000036FD File Offset: 0x000018FD
			public unsafe TerrainUtility.__c__DisplayClass2_0 field_Public___c__DisplayClass2_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TerrainUtility.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainUtility.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000143 RID: 323
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000144 RID: 324
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0;

			// Token: 0x04000145 RID: 325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000146 RID: 326
			private static readonly IntPtr NativeMethodInfoPtr__CollectTerrains_b__0_Internal_Boolean_Terrain_0;
		}

		// Token: 0x020000C0 RID: 192
		public sealed class <>c__DisplayClass2_0
		{
		}

		// Token: 0x020000C1 RID: 193
		public sealed class <>c__DisplayClass2_1
		{
		}
	}
}

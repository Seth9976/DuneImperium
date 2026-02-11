using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TerrainUtils
{
	// Token: 0x02000007 RID: 7
	public class TerrainMap : Object
	{
		// Token: 0x06000111 RID: 273 RVA: 0x00005724 File Offset: 0x00003924
		// Note: this type is marked as 'beforefieldinit'.
		static TerrainMap()
		{
			Il2CppClassPointerStore<TerrainMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.TerrainUtils", "TerrainMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr);
			TerrainMap.NativeFieldInfoPtr_m_patchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_patchSize");
			TerrainMap.NativeFieldInfoPtr_m_errorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_errorCode");
			TerrainMap.NativeFieldInfoPtr_m_terrainTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "m_terrainTiles");
			TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663318);
			TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663319);
			TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663320);
			TerrainMap.NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663321);
			TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663322);
			TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663323);
			TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663324);
			TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663325);
			TerrainMap.NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, 100663326);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005844 File Offset: 0x00003A44
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1268499, RefRangeEnd = 1268510, XrefRangeStart = 1268496, XrefRangeEnd = 1268499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Terrain GetTerrain(int tileX, int tileZ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tileX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Terrain>(intPtr3) : null;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000058A0 File Offset: 0x00003AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268549, RefRangeEnd = 1268550, XrefRangeStart = 1268510, XrefRangeEnd = 1268549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TerrainMap CreateFromPlacement(Terrain originTerrain, Predicate<Terrain> filter = null, bool fullValidation = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originTerrain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainMap>(intPtr3) : null;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005904 File Offset: 0x00003B04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268584, RefRangeEnd = 1268585, XrefRangeStart = 1268550, XrefRangeEnd = 1268584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, Predicate<Terrain> filter = null, bool fullValidation = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gridOrigin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gridSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullValidation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TerrainMap>(intPtr3) : null;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005974 File Offset: 0x00003B74
		public unsafe Dictionary<TerrainTileCoord, Terrain> terrainTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<TerrainTileCoord, Terrain>>(intPtr3) : null;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000059B4 File Offset: 0x00003BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268585, XrefRangeEnd = 1268593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerrainMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000059F0 File Offset: 0x00003BF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268608, RefRangeEnd = 1268609, XrefRangeStart = 1268593, XrefRangeEnd = 1268608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTerrainInternal(int x, int z, Terrain terrain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005A50 File Offset: 0x00003C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268622, RefRangeEnd = 1268623, XrefRangeStart = 1268609, XrefRangeEnd = 1268622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tileX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(terrain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005ABC File Offset: 0x00003CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268700, RefRangeEnd = 1268701, XrefRangeStart = 1268623, XrefRangeEnd = 1268700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateTerrain(int tileX, int tileZ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tileX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00005B08 File Offset: 0x00003D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1268719, RefRangeEnd = 1268720, XrefRangeStart = 1268701, XrefRangeEnd = 1268719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TerrainMapStatusCode Validate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002CE8 File Offset: 0x00000EE8
		public TerrainMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00005B44 File Offset: 0x00003D44
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public unsafe Vector3 m_patchSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_patchSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_patchSize)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005B6C File Offset: 0x00003D6C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002D0C File Offset: 0x00000F0C
		public unsafe TerrainMapStatusCode m_errorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_errorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_errorCode)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005B94 File Offset: 0x00003D94
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002D27 File Offset: 0x00000F27
		public unsafe Dictionary<TerrainTileCoord, Terrain> m_terrainTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_terrainTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TerrainTileCoord, Terrain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.NativeFieldInfoPtr_m_terrainTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002D46 File Offset: 0x00000F46
		public static TerrainMap CreateFromConnectedNeighbors(Terrain originTerrain, [Optional] Predicate<Terrain> filter, [Optional] bool fullValidation)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr_m_patchSize;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_m_errorCode;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_m_terrainTiles;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_GetTerrain_Public_Terrain_Int32_Int32_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Terrain_Predicate_1_Terrain_Boolean_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromPlacement_Public_Static_TerrainMap_Vector2_Vector2_Predicate_1_Terrain_Boolean_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_get_terrainTiles_Public_get_Dictionary_2_TerrainTileCoord_Terrain_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_AddTerrainInternal_Private_Void_Int32_Int32_Terrain_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_TryToAddTerrain_Private_Boolean_Int32_Int32_Terrain_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTerrain_Private_Void_Int32_Int32_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Private_TerrainMapStatusCode_0;

		// Token: 0x020000BC RID: 188
		[ObfuscatedName("UnityEngine.TerrainUtils.TerrainMap+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600033A RID: 826 RVA: 0x00007288 File Offset: 0x00005488
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerrainMap>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr);
				TerrainMap.__c__DisplayClass3_0.NativeFieldInfoPtr_groupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr, "groupID");
				TerrainMap.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr, 100663327);
				TerrainMap.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr, 100663328);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x000072F0 File Offset: 0x000054F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerrainMap.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033C RID: 828 RVA: 0x0000732C File Offset: 0x0000552C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268494, XrefRangeEnd = 1268496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateFromPlacement_b__0(Terrain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TerrainMap.__c__DisplayClass3_0.NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0000368D File Offset: 0x0000188D
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000737C File Offset: 0x0000557C
			// (set) Token: 0x0600033F RID: 831 RVA: 0x00003696 File Offset: 0x00001896
			public unsafe int groupID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.__c__DisplayClass3_0.NativeFieldInfoPtr_groupID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TerrainMap.__c__DisplayClass3_0.NativeFieldInfoPtr_groupID)) = value;
				}
			}

			// Token: 0x0400013E RID: 318
			private static readonly IntPtr NativeFieldInfoPtr_groupID;

			// Token: 0x0400013F RID: 319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000140 RID: 320
			private static readonly IntPtr NativeMethodInfoPtr__CreateFromPlacement_b__0_Internal_Boolean_Terrain_0;
		}

		// Token: 0x020000BD RID: 189
		public sealed class <>c__DisplayClass3_0
		{
		}
	}
}

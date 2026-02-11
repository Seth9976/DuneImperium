using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000002 RID: 2
	public class ITilemap : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002D9C File Offset: 0x00000F9C
		// Note: this type is marked as 'beforefieldinit'.
		static ITilemap()
		{
			Il2CppClassPointerStore<ITilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "ITilemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITilemap>.NativeClassPtr);
			ITilemap.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "s_Instance");
			ITilemap.NativeFieldInfoPtr_m_Tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_Tilemap");
			ITilemap.NativeFieldInfoPtr_m_AddToList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_AddToList");
			ITilemap.NativeFieldInfoPtr_m_RefreshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_RefreshCount");
			ITilemap.NativeFieldInfoPtr_m_RefreshPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_RefreshPos");
			ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663297);
			ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663298);
			ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663299);
			ITilemap.NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663300);
			ITilemap.NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002E94 File Offset: 0x00001094
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITilemap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITilemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002ED0 File Offset: 0x000010D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268828, XrefRangeEnd = 1268834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile(Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002F10 File Offset: 0x00001110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268834, XrefRangeEnd = 1268842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ITilemap CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002F44 File Offset: 0x00001144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268842, XrefRangeEnd = 1268873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindAllRefreshPositions(ITilemap tilemap, int count, IntPtr oldTilesIntPtr, IntPtr newTilesIntPtr, IntPtr positionsIntPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldTilesIntPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTilesIntPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002FB4 File Offset: 0x000011B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268873, XrefRangeEnd = 1268892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllTileData(ITilemap tilemap, int count, IntPtr tilesIntPtr, IntPtr positionsIntPtr, IntPtr outTileDataIntPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tilesIntPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsIntPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outTileDataIntPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		public ITilemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00003024 File Offset: 0x00001224
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static ITilemap s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ITilemap.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ITilemap.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000304C File Offset: 0x0000124C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe Tilemap m_Tilemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000307C File Offset: 0x0000127C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000208A File Offset: 0x0000028A
		public unsafe bool m_AddToList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_AddToList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_AddToList)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000030A4 File Offset: 0x000012A4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe int m_RefreshCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_RefreshCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_RefreshCount)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000030CC File Offset: 0x000012CC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020C0 File Offset: 0x000002C0
		public NativeArray<Vector3Int> m_RefreshPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_RefreshPos);
				return new NativeArray<Vector3Int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3Int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_RefreshPos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3Int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000030FC File Offset: 0x000012FC
		public static implicit operator ITilemap(Tilemap tilemap)
		{
			return new ITilemap(tilemap);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020EE File Offset: 0x000002EE
		public void SetTilemapInstance(Tilemap tilemap)
		{
			this.m_Tilemap = tilemap;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00003114 File Offset: 0x00001314
		public Vector3Int origin
		{
			get
			{
				return this.m_Tilemap.origin;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003134 File Offset: 0x00001334
		public Vector3Int size
		{
			get
			{
				return this.m_Tilemap.size;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003154 File Offset: 0x00001354
		public Bounds localBounds
		{
			get
			{
				return this.m_Tilemap.localBounds;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003174 File Offset: 0x00001374
		public BoundsInt cellBounds
		{
			get
			{
				return this.m_Tilemap.cellBounds;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003194 File Offset: 0x00001394
		public virtual Sprite GetSprite(Vector3Int position)
		{
			return this.m_Tilemap.GetSprite(position);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000031B4 File Offset: 0x000013B4
		public virtual Color GetColor(Vector3Int position)
		{
			return this.m_Tilemap.GetColor(position);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000031D4 File Offset: 0x000013D4
		public virtual Matrix4x4 GetTransformMatrix(Vector3Int position)
		{
			return this.m_Tilemap.GetTransformMatrix(position);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000031F4 File Offset: 0x000013F4
		public virtual TileFlags GetTileFlags(Vector3Int position)
		{
			return this.m_Tilemap.GetTileFlags(position);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003214 File Offset: 0x00001414
		public virtual TileBase GetTile(Vector3Int position)
		{
			return this.m_Tilemap.GetTile(position);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003234 File Offset: 0x00001434
		public virtual T GetTile<T>(Vector3Int position) where T : TileBase
		{
			return this.m_Tilemap.GetTile<T>(position);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003254 File Offset: 0x00001454
		public T GetComponent<T>()
		{
			bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Tilemap>());
			T t;
			if (flag)
			{
				t = this.m_Tilemap.Cast<T>();
			}
			else
			{
				t = this.m_Tilemap.GetComponent<T>();
			}
			return t;
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_Tilemap;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_m_AddToList;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshCount;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_m_RefreshPos;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_FindAllRefreshPositions_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTileData_Private_Static_Void_ITilemap_Int32_IntPtr_IntPtr_IntPtr_0;
	}
}

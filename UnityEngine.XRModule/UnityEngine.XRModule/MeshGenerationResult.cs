using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000015 RID: 21
	public sealed class MeshGenerationResult : ValueType
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00005ED4 File Offset: 0x000040D4
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerationResult()
		{
			Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "MeshGenerationResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr);
			MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshId>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Mesh>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<MeshCollider>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Status>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Attributes>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Timestamp>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Position>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Rotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Rotation>k__BackingField");
			MeshGenerationResult.NativeFieldInfoPtr__Scale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, "<Scale>k__BackingField");
			MeshGenerationResult.NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663372);
			MeshGenerationResult.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663373);
			MeshGenerationResult.NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663374);
			MeshGenerationResult.NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663375);
			MeshGenerationResult.NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663376);
			MeshGenerationResult.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663377);
			MeshGenerationResult.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663378);
			MeshGenerationResult.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663379);
			MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663380);
			MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663381);
			MeshGenerationResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr, 100663382);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006094 File Offset: 0x00004294
		public unsafe MeshId MeshId
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000060D8 File Offset: 0x000042D8
		public unsafe Mesh Mesh
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000611C File Offset: 0x0000431C
		public unsafe MeshCollider MeshCollider
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr3) : null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006160 File Offset: 0x00004360
		public unsafe MeshGenerationStatus Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000061A4 File Offset: 0x000043A4
		public unsafe MeshVertexAttributes Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000061E8 File Offset: 0x000043E8
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000622C File Offset: 0x0000442C
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00006270 File Offset: 0x00004470
		public unsafe Vector3 Scale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000062B4 File Offset: 0x000044B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258866, XrefRangeEnd = 1258870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006308 File Offset: 0x00004508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258877, RefRangeEnd = 1258878, XrefRangeStart = 1258870, XrefRangeEnd = 1258877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MeshGenerationResult other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006360 File Offset: 0x00004560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258878, XrefRangeEnd = 1258895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerationResult.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002A68 File Offset: 0x00000C68
		public MeshGenerationResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002A71 File Offset: 0x00000C71
		public MeshGenerationResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerationResult>.NativeClassPtr))
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000063A4 File Offset: 0x000045A4
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00002A83 File Offset: 0x00000C83
		public unsafe MeshId _MeshId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshId_k__BackingField)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000063CC File Offset: 0x000045CC
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002A9E File Offset: 0x00000C9E
		public unsafe Mesh _Mesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Mesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000063FC File Offset: 0x000045FC
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002ABD File Offset: 0x00000CBD
		public unsafe MeshCollider _MeshCollider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__MeshCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000642C File Offset: 0x0000462C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002ADC File Offset: 0x00000CDC
		public unsafe MeshGenerationStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00006454 File Offset: 0x00004654
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002AF7 File Offset: 0x00000CF7
		public unsafe MeshVertexAttributes _Attributes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Attributes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000647C File Offset: 0x0000467C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002B12 File Offset: 0x00000D12
		public unsafe ulong _Timestamp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Timestamp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Timestamp_k__BackingField)) = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000064A4 File Offset: 0x000046A4
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002B2D File Offset: 0x00000D2D
		public unsafe Vector3 _Position_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Position_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Position_k__BackingField)) = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000064CC File Offset: 0x000046CC
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002B48 File Offset: 0x00000D48
		public unsafe Quaternion _Rotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Rotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Rotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000064F4 File Offset: 0x000046F4
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002B63 File Offset: 0x00000D63
		public unsafe Vector3 _Scale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Scale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerationResult.NativeFieldInfoPtr__Scale_k__BackingField)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002B7E File Offset: 0x00000D7E
		public ulong Timestamp
		{
			get
			{
				return this._Timestamp_k__BackingField;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000651C File Offset: 0x0000471C
		public static bool operator ==(MeshGenerationResult lhs, MeshGenerationResult rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006538 File Offset: 0x00004738
		public static bool operator !=(MeshGenerationResult lhs, MeshGenerationResult rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr__MeshId_k__BackingField;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeFieldInfoPtr__Mesh_k__BackingField;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeFieldInfoPtr__MeshCollider_k__BackingField;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr__Attributes_k__BackingField;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr__Timestamp_k__BackingField;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeFieldInfoPtr__Position_k__BackingField;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeFieldInfoPtr__Rotation_k__BackingField;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr__Scale_k__BackingField;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_get_MeshId_Public_get_MeshId_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_Mesh_Public_get_Mesh_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_MeshCollider_Public_get_MeshCollider_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_MeshGenerationStatus_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_MeshVertexAttributes_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Vector3_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshGenerationResult_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

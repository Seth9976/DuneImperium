using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text.RegularExpressions;
using Networking.selection.targetinformation;

namespace moose.canis.networking
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public sealed class PotentialTileCoords : ValueType
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00006CD4 File Offset: 0x00004ED4
		// Note: this type is marked as 'beforefieldinit'.
		static PotentialTileCoords()
		{
			Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "moose.canis.networking", "PotentialTileCoords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr);
			PotentialTileCoords.NativeFieldInfoPtr_TileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, "TileID");
			PotentialTileCoords.NativeFieldInfoPtr_TileCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, "TileCoords");
			PotentialTileCoords.NativeFieldInfoPtr_coordsOrienRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, "coordsOrienRegex");
			PotentialTileCoords.NativeMethodInfoPtr__ctor_Public_Void_EntityID_HexCoordsWithOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663311);
			PotentialTileCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663312);
			PotentialTileCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663313);
			PotentialTileCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663314);
			PotentialTileCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663315);
			PotentialTileCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PotentialTileCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663316);
			PotentialTileCoords.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663317);
			PotentialTileCoords.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr, 100663318);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193438, RefRangeEnd = 1193439, XrefRangeStart = 1193437, XrefRangeEnd = 1193438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotentialTileCoords(EntityID tileID, HexCoordsWithOrientation tileCoords)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tileCoords;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr__ctor_Public_Void_EntityID_HexCoordsWithOrientation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006E40 File Offset: 0x00005040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193439, XrefRangeEnd = 1193462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotentialTileCoords(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006E90 File Offset: 0x00005090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193462, XrefRangeEnd = 1193468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006EE4 File Offset: 0x000050E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193468, XrefRangeEnd = 1193474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006F28 File Offset: 0x00005128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193474, XrefRangeEnd = 1193480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006F64 File Offset: 0x00005164
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1193484, RefRangeEnd = 1193487, XrefRangeStart = 1193480, XrefRangeEnd = 1193484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PotentialTileCoords other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PotentialTileCoords_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006FBC File Offset: 0x000051BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193487, XrefRangeEnd = 1193491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PotentialTileCoords left, PotentialTileCoords right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000701C File Offset: 0x0000521C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193491, XrefRangeEnd = 1193495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PotentialTileCoords left, PotentialTileCoords right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoords.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002358 File Offset: 0x00000558
		public PotentialTileCoords(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002361 File Offset: 0x00000561
		public PotentialTileCoords()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotentialTileCoords>.NativeClassPtr))
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000707C File Offset: 0x0000527C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002373 File Offset: 0x00000573
		public unsafe EntityID TileID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotentialTileCoords.NativeFieldInfoPtr_TileID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotentialTileCoords.NativeFieldInfoPtr_TileID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000070AC File Offset: 0x000052AC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002392 File Offset: 0x00000592
		public unsafe HexCoordsWithOrientation TileCoords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotentialTileCoords.NativeFieldInfoPtr_TileCoords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotentialTileCoords.NativeFieldInfoPtr_TileCoords)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000070D4 File Offset: 0x000052D4
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000023AD File Offset: 0x000005AD
		public unsafe static Regex coordsOrienRegex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PotentialTileCoords.NativeFieldInfoPtr_coordsOrienRegex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotentialTileCoords.NativeFieldInfoPtr_coordsOrienRegex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_TileID;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_TileCoords;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_coordsOrienRegex;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_HexCoordsWithOrientation_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PotentialTileCoords_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PotentialTileCoords_PotentialTileCoords_0;
	}
}

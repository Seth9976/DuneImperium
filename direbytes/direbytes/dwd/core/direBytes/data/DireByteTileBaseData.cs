using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000020 RID: 32
	public class DireByteTileBaseData : DataComponent
	{
		// Token: 0x06000174 RID: 372 RVA: 0x000077F8 File Offset: 0x000059F8
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileBaseData()
		{
			Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTileBaseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr);
			DireByteTileBaseData.NativeFieldInfoPtr__ID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, "<ID>k__BackingField");
			DireByteTileBaseData.NativeFieldInfoPtr__InternalName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, "<InternalName>k__BackingField");
			DireByteTileBaseData.NativeFieldInfoPtr__Layout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, "<Layout>k__BackingField");
			DireByteTileBaseData.NativeFieldInfoPtr__Priority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, "<Priority>k__BackingField");
			DireByteTileBaseData.NativeMethodInfoPtr_get_ID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663441);
			DireByteTileBaseData.NativeMethodInfoPtr_get_InternalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663442);
			DireByteTileBaseData.NativeMethodInfoPtr_get_Layout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663443);
			DireByteTileBaseData.NativeMethodInfoPtr_set_Layout_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663444);
			DireByteTileBaseData.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663445);
			DireByteTileBaseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663446);
			DireByteTileBaseData.NativeMethodInfoPtr_GetTileHash_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr, 100663447);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00007904 File Offset: 0x00005B04
		public unsafe string ID
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_get_ID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0000793C File Offset: 0x00005B3C
		public unsafe string InternalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_get_InternalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00007974 File Offset: 0x00005B74
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000079AC File Offset: 0x00005BAC
		public unsafe string Layout
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_get_Layout_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_set_Layout_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000079F0 File Offset: 0x00005BF0
		public unsafe int Priority
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007A2C File Offset: 0x00005C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1235068, RefRangeEnd = 1235070, XrefRangeStart = 1235064, XrefRangeEnd = 1235068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileBaseData(string id, string internalName, string layout, int priority)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileBaseData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(layout);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007AAC File Offset: 0x00005CAC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1235077, RefRangeEnd = 1235084, XrefRangeStart = 1235070, XrefRangeEnd = 1235077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTileHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileBaseData.NativeMethodInfoPtr_GetTileHash_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public DireByteTileBaseData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00007AE8 File Offset: 0x00005CE8
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002CFA File Offset: 0x00000EFA
		public unsafe string _ID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__ID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__ID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00007B10 File Offset: 0x00005D10
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002D19 File Offset: 0x00000F19
		public unsafe string _InternalName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__InternalName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__InternalName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00007B38 File Offset: 0x00005D38
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00002D38 File Offset: 0x00000F38
		public unsafe string _Layout_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__Layout_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__Layout_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00007B60 File Offset: 0x00005D60
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00002D57 File Offset: 0x00000F57
		public unsafe int _Priority_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__Priority_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileBaseData.NativeFieldInfoPtr__Priority_k__BackingField)) = value;
			}
		}

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr__ID_k__BackingField;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr__InternalName_k__BackingField;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr__Layout_k__BackingField;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr__Priority_k__BackingField;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_get_String_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_get_String_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_Layout_Public_get_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_set_Layout_Public_set_Void_String_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_get_Int32_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_GetTileHash_Public_Int32_0;
	}
}

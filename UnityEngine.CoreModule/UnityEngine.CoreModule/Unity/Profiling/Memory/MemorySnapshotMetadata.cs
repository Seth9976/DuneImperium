using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Profiling.Memory
{
	// Token: 0x02000026 RID: 38
	public class MemorySnapshotMetadata : Object
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00019F10 File Offset: 0x00018110
		// Note: this type is marked as 'beforefieldinit'.
		static MemorySnapshotMetadata()
		{
			Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.Memory", "MemorySnapshotMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr);
			MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, "<Description>k__BackingField");
			MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, "<Data>k__BackingField");
			MemorySnapshotMetadata.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663418);
			MemorySnapshotMetadata.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663419);
			MemorySnapshotMetadata.NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663420);
			MemorySnapshotMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr, 100663421);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00019FB8 File Offset: 0x000181B8
		// (set) Token: 0x0600014E RID: 334 RVA: 0x00019FF0 File Offset: 0x000181F0
		public unsafe string Description
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001A034 File Offset: 0x00018234
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002A31 File Offset: 0x00000C31
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			set
			{
				this._Data_k__BackingField = value;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001A074 File Offset: 0x00018274
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemorySnapshotMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemorySnapshotMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemorySnapshotMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000029EA File Offset: 0x00000BEA
		public MemorySnapshotMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0001A0B0 File Offset: 0x000182B0
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000029F3 File Offset: 0x00000BF3
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0001A0D8 File Offset: 0x000182D8
		// (set) Token: 0x06000155 RID: 341 RVA: 0x00002A12 File Offset: 0x00000C12
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemorySnapshotMetadata.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Internal_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

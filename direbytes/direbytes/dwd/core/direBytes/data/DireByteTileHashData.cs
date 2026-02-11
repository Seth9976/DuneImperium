using System;
using dwd.core.data.composition;
using dwd.core.Model;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.direBytes.data
{
	// Token: 0x02000021 RID: 33
	public class DireByteTileHashData : VersionedDataComponent
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00007B88 File Offset: 0x00005D88
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteTileHashData()
		{
			Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteTileHashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr);
			DireByteTileHashData.NativeFieldInfoPtr_seen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, "seen");
			DireByteTileHashData.NativeFieldInfoPtr_TileHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, "TileHash");
			DireByteTileHashData.NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, 100663448);
			DireByteTileHashData.NativeMethodInfoPtr_set_Seen_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, 100663449);
			DireByteTileHashData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, 100663450);
			DireByteTileHashData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, 100663451);
			DireByteTileHashData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr, 100663452);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00007C44 File Offset: 0x00005E44
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00007C80 File Offset: 0x00005E80
		public unsafe bool Seen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1235085, RefRangeEnd = 1235086, XrefRangeStart = 1235084, XrefRangeEnd = 1235085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileHashData.NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235086, XrefRangeEnd = 1235090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileHashData.NativeMethodInfoPtr_set_Seen_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00007CC0 File Offset: 0x00005EC0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235090, XrefRangeEnd = 1235091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteTileHashData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00007D08 File Offset: 0x00005F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1235099, RefRangeEnd = 1235100, XrefRangeStart = 1235091, XrefRangeEnd = 1235099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteTileHashData(int hash)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteTileHashData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteTileHashData.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007D50 File Offset: 0x00005F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235100, XrefRangeEnd = 1235104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteTileHashData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002D72 File Offset: 0x00000F72
		public DireByteTileHashData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00007D94 File Offset: 0x00005F94
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002D7B File Offset: 0x00000F7B
		public unsafe VersionedValue<bool> seen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileHashData.NativeFieldInfoPtr_seen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedValue<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileHashData.NativeFieldInfoPtr_seen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00007DC4 File Offset: 0x00005FC4
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002D9A File Offset: 0x00000F9A
		public unsafe int TileHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileHashData.NativeFieldInfoPtr_TileHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteTileHashData.NativeFieldInfoPtr_TileHash)) = value;
			}
		}

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_seen;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_TileHash;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_Seen_Public_set_Void_Boolean_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

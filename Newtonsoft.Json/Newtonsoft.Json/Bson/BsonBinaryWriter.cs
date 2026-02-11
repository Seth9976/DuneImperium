using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000102 RID: 258
	public class BsonBinaryWriter : Object
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x00074458 File Offset: 0x00072658
		// Note: this type is marked as 'beforefieldinit'.
		static BsonBinaryWriter()
		{
			Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonBinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr);
			BsonBinaryWriter.NativeFieldInfoPtr_Encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, "Encoding");
			BsonBinaryWriter.NativeFieldInfoPtr__writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, "_writer");
			BsonBinaryWriter.NativeFieldInfoPtr__largeByteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, "_largeByteBuffer");
			BsonBinaryWriter.NativeFieldInfoPtr__DateTimeKindHandling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, "<DateTimeKindHandling>k__BackingField");
			BsonBinaryWriter.NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667342);
			BsonBinaryWriter.NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667343);
			BsonBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667344);
			BsonBinaryWriter.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667345);
			BsonBinaryWriter.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667346);
			BsonBinaryWriter.NativeMethodInfoPtr_WriteToken_Public_Void_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667347);
			BsonBinaryWriter.NativeMethodInfoPtr_WriteTokenInternal_Private_Void_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667348);
			BsonBinaryWriter.NativeMethodInfoPtr_WriteString_Private_Void_String_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667349);
			BsonBinaryWriter.NativeMethodInfoPtr_WriteUtf8Bytes_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667350);
			BsonBinaryWriter.NativeMethodInfoPtr_CalculateSize_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667351);
			BsonBinaryWriter.NativeMethodInfoPtr_CalculateSizeWithLength_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667352);
			BsonBinaryWriter.NativeMethodInfoPtr_CalculateSize_Private_Int32_BsonToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr, 100667353);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x000745C8 File Offset: 0x000727C8
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00074604 File Offset: 0x00072804
		public unsafe DateTimeKind DateTimeKindHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00074644 File Offset: 0x00072844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766797, XrefRangeEnd = 766799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonBinaryWriter(BinaryWriter writer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonBinaryWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00074690 File Offset: 0x00072890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766799, XrefRangeEnd = 766800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x000746C4 File Offset: 0x000728C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766800, XrefRangeEnd = 766801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000746F8 File Offset: 0x000728F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766801, XrefRangeEnd = 766803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToken(BsonToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_WriteToken_Public_Void_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0007473C File Offset: 0x0007293C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 766829, RefRangeEnd = 766831, XrefRangeStart = 766803, XrefRangeEnd = 766829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTokenInternal(BsonToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_WriteTokenInternal_Private_Void_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00074780 File Offset: 0x00072980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766831, XrefRangeEnd = 766846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(string s, int byteCount, Nullable<int> calculatedlengthPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(calculatedlengthPrefix));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_WriteString_Private_Void_String_Int32_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000747E8 File Offset: 0x000729E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766846, XrefRangeEnd = 766851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUtf8Bytes(string s, int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_WriteUtf8Bytes_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00074838 File Offset: 0x00072A38
		[CallerCount(0)]
		public unsafe int CalculateSize(int stringByteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringByteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_CalculateSize_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00074884 File Offset: 0x00072A84
		[CallerCount(0)]
		public unsafe int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stringByteCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_CalculateSizeWithLength_Private_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000748DC File Offset: 0x00072ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 766868, RefRangeEnd = 766870, XrefRangeStart = 766851, XrefRangeEnd = 766868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateSize(BsonToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonBinaryWriter.NativeMethodInfoPtr_CalculateSize_Private_Int32_BsonToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00008601 File Offset: 0x00006801
		public BsonBinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0007492C File Offset: 0x00072B2C
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x0000860A File Offset: 0x0000680A
		public unsafe static Encoding Encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonBinaryWriter.NativeFieldInfoPtr_Encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonBinaryWriter.NativeFieldInfoPtr_Encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00074954 File Offset: 0x00072B54
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x0000861C File Offset: 0x0000681C
		public unsafe BinaryWriter _writer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__writer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__writer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00074984 File Offset: 0x00072B84
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x0000863B File Offset: 0x0000683B
		public unsafe Il2CppStructArray<byte> _largeByteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__largeByteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__largeByteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000749B4 File Offset: 0x00072BB4
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000865A File Offset: 0x0000685A
		public unsafe DateTimeKind _DateTimeKindHandling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__DateTimeKindHandling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonBinaryWriter.NativeFieldInfoPtr__DateTimeKindHandling_k__BackingField)) = value;
			}
		}

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_Encoding;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr__writer;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr__largeByteBuffer;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr__DateTimeKindHandling_k__BackingField;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryWriter_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_WriteToken_Public_Void_BsonToken_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_WriteTokenInternal_Private_Void_BsonToken_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Private_Void_String_Int32_Nullable_1_Int32_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_WriteUtf8Bytes_Public_Void_String_Int32_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSize_Private_Int32_Int32_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSizeWithLength_Private_Int32_Int32_Boolean_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSize_Private_Int32_BsonToken_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035B RID: 859
	public sealed class BinaryArray : Object
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x00102148 File Offset: 0x00100348
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryArray()
		{
			Il2CppClassPointerStore<BinaryArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr);
			BinaryArray.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "objectId");
			BinaryArray.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "rank");
			BinaryArray.NativeFieldInfoPtr_lengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lengthA");
			BinaryArray.NativeFieldInfoPtr_lowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lowerBoundA");
			BinaryArray.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryTypeEnum");
			BinaryArray.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "typeInformation");
			BinaryArray.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "assemId");
			BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryHeaderEnum");
			BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryArrayTypeEnum");
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671282);
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671283);
			BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671284);
			BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671285);
			BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671286);
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00102290 File Offset: 0x00100490
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x001022CC File Offset: 0x001004CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387330, RefRangeEnd = 1387331, XrefRangeStart = 1387329, XrefRangeEnd = 1387330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00102314 File Offset: 0x00100514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387334, RefRangeEnd = 1387337, XrefRangeStart = 1387331, XrefRangeEnd = 1387334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA, BinaryTypeEnum binaryTypeEnum, Object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryTypeEnum;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryArrayTypeEnum;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x001023C4 File Offset: 0x001005C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387339, RefRangeEnd = 1387342, XrefRangeStart = 1387337, XrefRangeEnd = 1387339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00102408 File Offset: 0x00100608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387384, RefRangeEnd = 1387385, XrefRangeStart = 1387342, XrefRangeEnd = 1387384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00011F58 File Offset: 0x00010158
		public BinaryArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x0010244C File Offset: 0x0010064C
		// (set) Token: 0x0600336E RID: 13166 RVA: 0x00011F61 File Offset: 0x00010161
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x0600336F RID: 13167 RVA: 0x00102474 File Offset: 0x00100674
		// (set) Token: 0x06003370 RID: 13168 RVA: 0x00011F7C File Offset: 0x0001017C
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x0010249C File Offset: 0x0010069C
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x00011F97 File Offset: 0x00010197
		public unsafe Il2CppStructArray<int> lengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x001024CC File Offset: 0x001006CC
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x00011FB6 File Offset: 0x000101B6
		public unsafe Il2CppStructArray<int> lowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06003375 RID: 13173 RVA: 0x001024FC File Offset: 0x001006FC
		// (set) Token: 0x06003376 RID: 13174 RVA: 0x00011FD5 File Offset: 0x000101D5
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06003377 RID: 13175 RVA: 0x00102524 File Offset: 0x00100724
		// (set) Token: 0x06003378 RID: 13176 RVA: 0x00011FF0 File Offset: 0x000101F0
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06003379 RID: 13177 RVA: 0x00102554 File Offset: 0x00100754
		// (set) Token: 0x0600337A RID: 13178 RVA: 0x0001200F File Offset: 0x0001020F
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x0600337B RID: 13179 RVA: 0x0010257C File Offset: 0x0010077C
		// (set) Token: 0x0600337C RID: 13180 RVA: 0x0001202A File Offset: 0x0001022A
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600337D RID: 13181 RVA: 0x001025A4 File Offset: 0x001007A4
		// (set) Token: 0x0600337E RID: 13182 RVA: 0x00012045 File Offset: 0x00010245
		public unsafe BinaryArrayTypeEnum binaryArrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum)) = value;
			}
		}

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeFieldInfoPtr_lengthA;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeFieldInfoPtr_lowerBoundA;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeFieldInfoPtr_binaryArrayTypeEnum;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}

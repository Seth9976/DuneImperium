using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035A RID: 858
	public sealed class BinaryObjectWithMapTyped : Object
	{
		// Token: 0x0600334D RID: 13133 RVA: 0x00101CB4 File Offset: 0x000FFEB4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectWithMapTyped()
		{
			Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectWithMapTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr);
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryHeaderEnum");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "objectId");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "name");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "numMembers");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberNames");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryTypeEnumA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "typeInformationA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberAssemIds");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "assemId");
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671277);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671278);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671279);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671280);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671281);
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00101DFC File Offset: 0x000FFFFC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMapTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00101E38 File Offset: 0x00100038
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x00101E80 File Offset: 0x00100080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387293, XrefRangeEnd = 1387298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, string name, int numMembers, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00101F38 File Offset: 0x00100138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387298, XrefRangeEnd = 1387299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00101F7C File Offset: 0x0010017C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387328, RefRangeEnd = 1387329, XrefRangeStart = 1387299, XrefRangeEnd = 1387328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00011E48 File Offset: 0x00010048
		public BinaryObjectWithMapTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x00101FC0 File Offset: 0x001001C0
		// (set) Token: 0x06003355 RID: 13141 RVA: 0x00011E51 File Offset: 0x00010051
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x00101FE8 File Offset: 0x001001E8
		// (set) Token: 0x06003357 RID: 13143 RVA: 0x00011E6C File Offset: 0x0001006C
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x00102010 File Offset: 0x00100210
		// (set) Token: 0x06003359 RID: 13145 RVA: 0x00011E87 File Offset: 0x00010087
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x00102038 File Offset: 0x00100238
		// (set) Token: 0x0600335B RID: 13147 RVA: 0x00011EA6 File Offset: 0x000100A6
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600335C RID: 13148 RVA: 0x00102060 File Offset: 0x00100260
		// (set) Token: 0x0600335D RID: 13149 RVA: 0x00011EC1 File Offset: 0x000100C1
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x00102090 File Offset: 0x00100290
		// (set) Token: 0x0600335F RID: 13151 RVA: 0x00011EE0 File Offset: 0x000100E0
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06003360 RID: 13152 RVA: 0x001020C0 File Offset: 0x001002C0
		// (set) Token: 0x06003361 RID: 13153 RVA: 0x00011EFF File Offset: 0x000100FF
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06003362 RID: 13154 RVA: 0x001020F0 File Offset: 0x001002F0
		// (set) Token: 0x06003363 RID: 13155 RVA: 0x00011F1E File Offset: 0x0001011E
		public unsafe Il2CppStructArray<int> memberAssemIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06003364 RID: 13156 RVA: 0x00102120 File Offset: 0x00100320
		// (set) Token: 0x06003365 RID: 13157 RVA: 0x00011F3D File Offset: 0x0001013D
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeFieldInfoPtr_memberAssemIds;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}

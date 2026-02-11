using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000360 RID: 864
	public sealed class ObjectMap : Object
	{
		// Token: 0x060033A4 RID: 13220 RVA: 0x00102E68 File Offset: 0x00101068
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMap()
		{
			Il2CppClassPointerStore<ObjectMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr);
			ObjectMap.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectName");
			ObjectMap.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectType");
			ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "binaryTypeEnumA");
			ObjectMap.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "typeInformationA");
			ObjectMap.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "memberTypes");
			ObjectMap.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "memberNames");
			ObjectMap.NativeFieldInfoPtr_objectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectInfo");
			ObjectMap.NativeFieldInfoPtr_isInitObjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "isInitObjectInfo");
			ObjectMap.NativeFieldInfoPtr_objectReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectReader");
			ObjectMap.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectId");
			ObjectMap.NativeFieldInfoPtr_assemblyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "assemblyInfo");
			ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671308);
			ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671309);
			ObjectMap.NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671310);
			ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671311);
			ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671312);
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00102FD8 File Offset: 0x001011D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387420, RefRangeEnd = 1387421, XrefRangeStart = 1387398, XrefRangeEnd = 1387420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap(string objectName, Type objectType, Il2CppStringArray memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x0010307C File Offset: 0x0010127C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387457, RefRangeEnd = 1387458, XrefRangeStart = 1387421, XrefRangeEnd = 1387457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap(string objectName, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemIdToAssemblyTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x0010315C File Offset: 0x0010135C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387460, RefRangeEnd = 1387463, XrefRangeStart = 1387458, XrefRangeEnd = 1387460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr7) : null;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x001031EC File Offset: 0x001013EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387467, RefRangeEnd = 1387468, XrefRangeStart = 1387463, XrefRangeEnd = 1387467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectMap Create(string name, Type objectType, Il2CppStringArray memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00103288 File Offset: 0x00101488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387472, RefRangeEnd = 1387473, XrefRangeStart = 1387468, XrefRangeEnd = 1387472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectMap Create(string name, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemIdToAssemblyTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000120F4 File Offset: 0x000102F4
		public ObjectMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060033AB RID: 13227 RVA: 0x00103360 File Offset: 0x00101560
		// (set) Token: 0x060033AC RID: 13228 RVA: 0x000120FD File Offset: 0x000102FD
		public unsafe string objectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x00103388 File Offset: 0x00101588
		// (set) Token: 0x060033AE RID: 13230 RVA: 0x0001211C File Offset: 0x0001031C
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x001033B8 File Offset: 0x001015B8
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x0001213B File Offset: 0x0001033B
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x001033E8 File Offset: 0x001015E8
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x0001215A File Offset: 0x0001035A
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x00103418 File Offset: 0x00101618
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x00012179 File Offset: 0x00010379
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x00103448 File Offset: 0x00101648
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00012198 File Offset: 0x00010398
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060033B7 RID: 13239 RVA: 0x00103478 File Offset: 0x00101678
		// (set) Token: 0x060033B8 RID: 13240 RVA: 0x000121B7 File Offset: 0x000103B7
		public unsafe ReadObjectInfo objectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060033B9 RID: 13241 RVA: 0x001034A8 File Offset: 0x001016A8
		// (set) Token: 0x060033BA RID: 13242 RVA: 0x000121D6 File Offset: 0x000103D6
		public unsafe bool isInitObjectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_isInitObjectInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_isInitObjectInfo)) = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060033BB RID: 13243 RVA: 0x001034D0 File Offset: 0x001016D0
		// (set) Token: 0x060033BC RID: 13244 RVA: 0x000121F1 File Offset: 0x000103F1
		public unsafe ObjectReader objectReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060033BD RID: 13245 RVA: 0x00103500 File Offset: 0x00101700
		// (set) Token: 0x060033BE RID: 13246 RVA: 0x00012210 File Offset: 0x00010410
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060033BF RID: 13247 RVA: 0x00103528 File Offset: 0x00101728
		// (set) Token: 0x060033C0 RID: 13248 RVA: 0x0001222B File Offset: 0x0001042B
		public unsafe BinaryAssemblyInfo assemblyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_assemblyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_assemblyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeFieldInfoPtr_objectName;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeFieldInfoPtr_objectInfo;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeFieldInfoPtr_isInitObjectInfo;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeFieldInfoPtr_objectReader;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeFieldInfoPtr_assemblyInfo;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0;
	}
}

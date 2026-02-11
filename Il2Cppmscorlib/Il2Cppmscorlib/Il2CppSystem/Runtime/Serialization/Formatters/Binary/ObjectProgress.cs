using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000361 RID: 865
	public sealed class ObjectProgress : Object
	{
		// Token: 0x060033C1 RID: 13249 RVA: 0x00103558 File Offset: 0x00101758
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectProgress()
		{
			Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr);
			ObjectProgress.NativeFieldInfoPtr_opRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "opRecordIdCount");
			ObjectProgress.NativeFieldInfoPtr_isInitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "isInitial");
			ObjectProgress.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "count");
			ObjectProgress.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedType");
			ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedTypeInformation");
			ObjectProgress.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "name");
			ObjectProgress.NativeFieldInfoPtr_objectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "objectTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberValueEnum");
			ObjectProgress.NativeFieldInfoPtr_dtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "dtType");
			ObjectProgress.NativeFieldInfoPtr_numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "numItems");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformation");
			ObjectProgress.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "nullCount");
			ObjectProgress.NativeFieldInfoPtr_memberLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberLength");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnumA");
			ObjectProgress.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformationA");
			ObjectProgress.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberNames");
			ObjectProgress.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypes");
			ObjectProgress.NativeFieldInfoPtr_pr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "pr");
			ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671313);
			ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671314);
			ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671315);
			ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671316);
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00103768 File Offset: 0x00101968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387473, XrefRangeEnd = 1387479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x001037A4 File Offset: 0x001019A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387491, RefRangeEnd = 1387492, XrefRangeStart = 1387479, XrefRangeEnd = 1387491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x001037D8 File Offset: 0x001019D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387492, RefRangeEnd = 1387493, XrefRangeStart = 1387492, XrefRangeEnd = 1387492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayCountIncrement(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00103818 File Offset: 0x00101A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387497, RefRangeEnd = 1387498, XrefRangeStart = 1387493, XrefRangeEnd = 1387497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out Object outTypeInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outBinaryTypeEnum;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outTypeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x0001224A File Offset: 0x0001044A
		public ObjectProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x00103884 File Offset: 0x00101A84
		// (set) Token: 0x060033C8 RID: 13256 RVA: 0x00012253 File Offset: 0x00010453
		public unsafe static int opRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060033C9 RID: 13257 RVA: 0x001038A0 File Offset: 0x00101AA0
		// (set) Token: 0x060033CA RID: 13258 RVA: 0x00012261 File Offset: 0x00010461
		public unsafe bool isInitial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial)) = value;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060033CB RID: 13259 RVA: 0x001038C8 File Offset: 0x00101AC8
		// (set) Token: 0x060033CC RID: 13260 RVA: 0x0001227C File Offset: 0x0001047C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x001038F0 File Offset: 0x00101AF0
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x00012297 File Offset: 0x00010497
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x00103918 File Offset: 0x00101B18
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x000122B2 File Offset: 0x000104B2
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x00103948 File Offset: 0x00101B48
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x000122D1 File Offset: 0x000104D1
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x00103970 File Offset: 0x00101B70
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x000122F0 File Offset: 0x000104F0
		public unsafe InternalObjectTypeE objectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum)) = value;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x00103998 File Offset: 0x00101B98
		// (set) Token: 0x060033D6 RID: 13270 RVA: 0x0001230B File Offset: 0x0001050B
		public unsafe InternalMemberTypeE memberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum)) = value;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x001039C0 File Offset: 0x00101BC0
		// (set) Token: 0x060033D8 RID: 13272 RVA: 0x00012326 File Offset: 0x00010526
		public unsafe InternalMemberValueE memberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum)) = value;
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x001039E8 File Offset: 0x00101BE8
		// (set) Token: 0x060033DA RID: 13274 RVA: 0x00012341 File Offset: 0x00010541
		public unsafe Type dtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x00103A18 File Offset: 0x00101C18
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x00012360 File Offset: 0x00010560
		public unsafe int numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems)) = value;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x00103A40 File Offset: 0x00101C40
		// (set) Token: 0x060033DE RID: 13278 RVA: 0x0001237B File Offset: 0x0001057B
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x00103A68 File Offset: 0x00101C68
		// (set) Token: 0x060033E0 RID: 13280 RVA: 0x00012396 File Offset: 0x00010596
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x060033E1 RID: 13281 RVA: 0x00103A98 File Offset: 0x00101C98
		// (set) Token: 0x060033E2 RID: 13282 RVA: 0x000123B5 File Offset: 0x000105B5
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x060033E3 RID: 13283 RVA: 0x00103AC0 File Offset: 0x00101CC0
		// (set) Token: 0x060033E4 RID: 13284 RVA: 0x000123D0 File Offset: 0x000105D0
		public unsafe int memberLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength)) = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x060033E5 RID: 13285 RVA: 0x00103AE8 File Offset: 0x00101CE8
		// (set) Token: 0x060033E6 RID: 13286 RVA: 0x000123EB File Offset: 0x000105EB
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x00103B18 File Offset: 0x00101D18
		// (set) Token: 0x060033E8 RID: 13288 RVA: 0x0001240A File Offset: 0x0001060A
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x00103B48 File Offset: 0x00101D48
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x00012429 File Offset: 0x00010629
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x00103B78 File Offset: 0x00101D78
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x00012448 File Offset: 0x00010648
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x00103BA8 File Offset: 0x00101DA8
		// (set) Token: 0x060033EE RID: 13294 RVA: 0x00012467 File Offset: 0x00010667
		public unsafe ParseRecord pr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeFieldInfoPtr_opRecordIdCount;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeFieldInfoPtr_isInitial;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeFieldInfoPtr_objectTypeEnum;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeFieldInfoPtr_memberTypeEnum;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeFieldInfoPtr_memberValueEnum;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeFieldInfoPtr_dtType;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeFieldInfoPtr_numItems;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeFieldInfoPtr_memberLength;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeFieldInfoPtr_pr;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200003A RID: 58
	public class WarningHeaderValue : Object
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x000137D0 File Offset: 0x000119D0
		// Note: this type is marked as 'beforefieldinit'.
		static WarningHeaderValue()
		{
			Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "WarningHeaderValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr);
			WarningHeaderValue.NativeFieldInfoPtr__Agent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, "<Agent>k__BackingField");
			WarningHeaderValue.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, "<Code>k__BackingField");
			WarningHeaderValue.NativeFieldInfoPtr__Date_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, "<Date>k__BackingField");
			WarningHeaderValue.NativeFieldInfoPtr__Text_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, "<Text>k__BackingField");
			WarningHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663907);
			WarningHeaderValue.NativeMethodInfoPtr_get_Agent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663908);
			WarningHeaderValue.NativeMethodInfoPtr_set_Agent_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663909);
			WarningHeaderValue.NativeMethodInfoPtr_get_Code_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663910);
			WarningHeaderValue.NativeMethodInfoPtr_set_Code_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663911);
			WarningHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663912);
			WarningHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663913);
			WarningHeaderValue.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663914);
			WarningHeaderValue.NativeMethodInfoPtr_set_Text_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663915);
			WarningHeaderValue.NativeMethodInfoPtr_IsCodeValid_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663916);
			WarningHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663917);
			WarningHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663918);
			WarningHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663919);
			WarningHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_WarningHeaderValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663920);
			WarningHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_WarningHeaderValue_byref_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663921);
			WarningHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr, 100663922);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00013990 File Offset: 0x00011B90
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WarningHeaderValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WarningHeaderValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000139CC File Offset: 0x00011BCC
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00013A04 File Offset: 0x00011C04
		public unsafe string Agent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_get_Agent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_set_Agent_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00013A48 File Offset: 0x00011C48
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00013A84 File Offset: 0x00011C84
		public unsafe int Code
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_get_Code_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_set_Code_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00013AC4 File Offset: 0x00011CC4
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00013AFC File Offset: 0x00011CFC
		public unsafe Nullable<DateTimeOffset> Date
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTimeOffset>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00013B44 File Offset: 0x00011D44
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00013B7C File Offset: 0x00011D7C
		public unsafe string Text
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_set_Text_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[CallerCount(0)]
		public unsafe static bool IsCodeValid(int code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_IsCodeValid_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00013C00 File Offset: 0x00011E00
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1172447, RefRangeEnd = 1172552, XrefRangeStart = 1172447, XrefRangeEnd = 1172552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00013C40 File Offset: 0x00011E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176152, XrefRangeEnd = 1176165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarningHeaderValue.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00013C98 File Offset: 0x00011E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176165, XrefRangeEnd = 1176170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarningHeaderValue.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00013CE0 File Offset: 0x00011EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176170, XrefRangeEnd = 1176179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse(string input, int minimalCount, out List<WarningHeaderValue> result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimalCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_WarningHeaderValue_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new List<WarningHeaderValue>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00013D54 File Offset: 0x00011F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176179, XrefRangeEnd = 1176213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseElement(Lexer lexer, out WarningHeaderValue parsedValue, out Token t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lexer);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WarningHeaderValue.NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_WarningHeaderValue_byref_Token_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsedValue = ((intPtr4 == 0) ? null : new WarningHeaderValue(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00013DC8 File Offset: 0x00011FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1176213, XrefRangeEnd = 1176247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WarningHeaderValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00003403 File Offset: 0x00001603
		public WarningHeaderValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00013E0C File Offset: 0x0001200C
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0000340C File Offset: 0x0000160C
		public unsafe string _Agent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Agent_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Agent_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00013E34 File Offset: 0x00012034
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000342B File Offset: 0x0000162B
		public unsafe int _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Code_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Code_k__BackingField)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00013E5C File Offset: 0x0001205C
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003446 File Offset: 0x00001646
		public Nullable<DateTimeOffset> _Date_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Date_k__BackingField);
				return new Nullable<DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Date_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<DateTimeOffset>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00013E8C File Offset: 0x0001208C
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003474 File Offset: 0x00001674
		public unsafe string _Text_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Text_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WarningHeaderValue.NativeFieldInfoPtr__Text_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr__Agent_k__BackingField;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr__Date_k__BackingField;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr__Text_k__BackingField;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Public_get_String_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_set_Agent_Private_set_Void_String_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_Int32_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Private_set_Void_Int32_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_Date_Public_get_Nullable_1_DateTimeOffset_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_set_Date_Private_set_Void_Nullable_1_DateTimeOffset_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Private_set_Void_String_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_IsCodeValid_Private_Static_Boolean_Int32_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Internal_Static_Boolean_String_Int32_byref_List_1_WarningHeaderValue_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_TryParseElement_Private_Static_Boolean_Lexer_byref_WarningHeaderValue_byref_Token_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

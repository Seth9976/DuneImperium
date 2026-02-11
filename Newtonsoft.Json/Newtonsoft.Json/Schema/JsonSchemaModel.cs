using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A8 RID: 168
	public class JsonSchemaModel : Object
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x000566D4 File Offset: 0x000548D4
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaModel()
		{
			Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr);
			JsonSchemaModel.NativeFieldInfoPtr__Required_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Required>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Type>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__MinimumLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<MinimumLength>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__MaximumLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<MaximumLength>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__DivisibleBy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<DivisibleBy>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Minimum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Minimum>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Maximum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Maximum>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<ExclusiveMinimum>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<ExclusiveMaximum>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__MinimumItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<MinimumItems>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__MaximumItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<MaximumItems>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Patterns_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Patterns>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Items>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Properties>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__PatternProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<PatternProperties>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__AdditionalProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<AdditionalProperties>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__AdditionalItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<AdditionalItems>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<PositionalItemsValidation>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<AllowAdditionalProperties>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<AllowAdditionalItems>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__UniqueItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<UniqueItems>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Enum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Enum>k__BackingField");
			JsonSchemaModel.NativeFieldInfoPtr__Disallow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, "<Disallow>k__BackingField");
			JsonSchemaModel.NativeMethodInfoPtr_get_Required_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665979);
			JsonSchemaModel.NativeMethodInfoPtr_set_Required_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665980);
			JsonSchemaModel.NativeMethodInfoPtr_get_Type_Public_get_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665981);
			JsonSchemaModel.NativeMethodInfoPtr_set_Type_Public_set_Void_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665982);
			JsonSchemaModel.NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665983);
			JsonSchemaModel.NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665984);
			JsonSchemaModel.NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665985);
			JsonSchemaModel.NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665986);
			JsonSchemaModel.NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665987);
			JsonSchemaModel.NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665988);
			JsonSchemaModel.NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665989);
			JsonSchemaModel.NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665990);
			JsonSchemaModel.NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665991);
			JsonSchemaModel.NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665992);
			JsonSchemaModel.NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665993);
			JsonSchemaModel.NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665994);
			JsonSchemaModel.NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665995);
			JsonSchemaModel.NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665996);
			JsonSchemaModel.NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665997);
			JsonSchemaModel.NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665998);
			JsonSchemaModel.NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100665999);
			JsonSchemaModel.NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666000);
			JsonSchemaModel.NativeMethodInfoPtr_get_Patterns_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666001);
			JsonSchemaModel.NativeMethodInfoPtr_set_Patterns_Public_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666002);
			JsonSchemaModel.NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666003);
			JsonSchemaModel.NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666004);
			JsonSchemaModel.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666005);
			JsonSchemaModel.NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666006);
			JsonSchemaModel.NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666007);
			JsonSchemaModel.NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666008);
			JsonSchemaModel.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666009);
			JsonSchemaModel.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666010);
			JsonSchemaModel.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666011);
			JsonSchemaModel.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666012);
			JsonSchemaModel.NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666013);
			JsonSchemaModel.NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666014);
			JsonSchemaModel.NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666015);
			JsonSchemaModel.NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666016);
			JsonSchemaModel.NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666017);
			JsonSchemaModel.NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666018);
			JsonSchemaModel.NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666019);
			JsonSchemaModel.NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666020);
			JsonSchemaModel.NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666021);
			JsonSchemaModel.NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666022);
			JsonSchemaModel.NativeMethodInfoPtr_get_Disallow_Public_get_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666023);
			JsonSchemaModel.NativeMethodInfoPtr_set_Disallow_Public_set_Void_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666024);
			JsonSchemaModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666025);
			JsonSchemaModel.NativeMethodInfoPtr_Create_Public_Static_JsonSchemaModel_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666026);
			JsonSchemaModel.NativeMethodInfoPtr_Combine_Private_Static_Void_JsonSchemaModel_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr, 100666027);
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00056CA4 File Offset: 0x00054EA4
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00056CE0 File Offset: 0x00054EE0
		public unsafe bool Required
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Required_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Required_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00056D20 File Offset: 0x00054F20
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00056D5C File Offset: 0x00054F5C
		public unsafe JsonSchemaType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Type_Public_get_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 310312, RefRangeEnd = 310318, XrefRangeStart = 310312, XrefRangeEnd = 310318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Type_Public_set_Void_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00056D9C File Offset: 0x00054F9C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00056DD4 File Offset: 0x00054FD4
		public unsafe Nullable<int> MinimumLength
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00056E1C File Offset: 0x0005501C
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00056E54 File Offset: 0x00055054
		public unsafe Nullable<int> MaximumLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00056E9C File Offset: 0x0005509C
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00056ED4 File Offset: 0x000550D4
		public unsafe Nullable<double> DivisibleBy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00056F1C File Offset: 0x0005511C
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00056F54 File Offset: 0x00055154
		public unsafe Nullable<double> Minimum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00056F9C File Offset: 0x0005519C
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00056FD4 File Offset: 0x000551D4
		public unsafe Nullable<double> Maximum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<double>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0005701C File Offset: 0x0005521C
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00057058 File Offset: 0x00055258
		public unsafe bool ExclusiveMinimum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x00057098 File Offset: 0x00055298
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000570D4 File Offset: 0x000552D4
		public unsafe bool ExclusiveMaximum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00057114 File Offset: 0x00055314
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0005714C File Offset: 0x0005534C
		public unsafe Nullable<int> MinimumItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00057194 File Offset: 0x00055394
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x000571CC File Offset: 0x000553CC
		public unsafe Nullable<int> MaximumItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00057214 File Offset: 0x00055414
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00057254 File Offset: 0x00055454
		public unsafe IList<string> Patterns
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Patterns_Public_get_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Patterns_Public_set_Void_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00057298 File Offset: 0x00055498
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x000572D8 File Offset: 0x000554D8
		public unsafe IList<JsonSchemaModel> Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0005731C File Offset: 0x0005551C
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x0005735C File Offset: 0x0005555C
		public unsafe IDictionary<string, JsonSchemaModel> Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchemaModel>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000573A0 File Offset: 0x000555A0
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x000573E0 File Offset: 0x000555E0
		public unsafe IDictionary<string, JsonSchemaModel> PatternProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchemaModel>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00057424 File Offset: 0x00055624
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00057464 File Offset: 0x00055664
		public unsafe JsonSchemaModel AdditionalProperties
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000574A8 File Offset: 0x000556A8
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x000574E8 File Offset: 0x000556E8
		public unsafe JsonSchemaModel AdditionalItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x0005752C File Offset: 0x0005572C
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00057568 File Offset: 0x00055768
		public unsafe bool PositionalItemsValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000575A8 File Offset: 0x000557A8
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000575E4 File Offset: 0x000557E4
		public unsafe bool AllowAdditionalProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x00057624 File Offset: 0x00055824
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x00057660 File Offset: 0x00055860
		public unsafe bool AllowAdditionalItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000576A0 File Offset: 0x000558A0
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000576DC File Offset: 0x000558DC
		public unsafe bool UniqueItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0005771C File Offset: 0x0005591C
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0005775C File Offset: 0x0005595C
		public unsafe IList<JToken> Enum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000577A0 File Offset: 0x000559A0
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x000577DC File Offset: 0x000559DC
		public unsafe JsonSchemaType Disallow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_get_Disallow_Public_get_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_set_Disallow_Public_set_Void_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0005781C File Offset: 0x00055A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 755149, XrefRangeEnd = 755150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchemaModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchemaModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00057858 File Offset: 0x00055A58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755172, RefRangeEnd = 755173, XrefRangeStart = 755150, XrefRangeEnd = 755172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchemaModel Create(IList<JsonSchema> schemata)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_Create_Public_Static_JsonSchemaModel_IList_1_JsonSchema_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr3) : null;
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0005789C File Offset: 0x00055A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 755211, RefRangeEnd = 755212, XrefRangeStart = 755173, XrefRangeEnd = 755211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Combine(JsonSchemaModel model, JsonSchema schema)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchemaModel.NativeMethodInfoPtr_Combine_Private_Static_Void_JsonSchemaModel_JsonSchema_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00007098 File Offset: 0x00005298
		public JsonSchemaModel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000578E4 File Offset: 0x00055AE4
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x000070A1 File Offset: 0x000052A1
		public unsafe bool _Required_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Required_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Required_k__BackingField)) = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0005790C File Offset: 0x00055B0C
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000070BC File Offset: 0x000052BC
		public unsafe JsonSchemaType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x00057934 File Offset: 0x00055B34
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x000070D7 File Offset: 0x000052D7
		public Nullable<int> _MinimumLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MinimumLength_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MinimumLength_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x00057964 File Offset: 0x00055B64
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x00007105 File Offset: 0x00005305
		public Nullable<int> _MaximumLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MaximumLength_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MaximumLength_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00057994 File Offset: 0x00055B94
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00007133 File Offset: 0x00005333
		public Nullable<double> _DivisibleBy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__DivisibleBy_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__DivisibleBy_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000579C4 File Offset: 0x00055BC4
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00007161 File Offset: 0x00005361
		public Nullable<double> _Minimum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Minimum_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Minimum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000579F4 File Offset: 0x00055BF4
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0000718F File Offset: 0x0000538F
		public Nullable<double> _Maximum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Maximum_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Maximum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00057A24 File Offset: 0x00055C24
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000071BD File Offset: 0x000053BD
		public unsafe bool _ExclusiveMinimum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00057A4C File Offset: 0x00055C4C
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000071D8 File Offset: 0x000053D8
		public unsafe bool _ExclusiveMaximum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField)) = value;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00057A74 File Offset: 0x00055C74
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000071F3 File Offset: 0x000053F3
		public Nullable<int> _MinimumItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MinimumItems_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MinimumItems_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00057AA4 File Offset: 0x00055CA4
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x00007221 File Offset: 0x00005421
		public Nullable<int> _MaximumItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MaximumItems_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__MaximumItems_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00057AD4 File Offset: 0x00055CD4
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x0000724F File Offset: 0x0000544F
		public unsafe IList<string> _Patterns_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Patterns_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Patterns_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00057B04 File Offset: 0x00055D04
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x0000726E File Offset: 0x0000546E
		public unsafe IList<JsonSchemaModel> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchemaModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00057B34 File Offset: 0x00055D34
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x0000728D File Offset: 0x0000548D
		public unsafe IDictionary<string, JsonSchemaModel> _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchemaModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00057B64 File Offset: 0x00055D64
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x000072AC File Offset: 0x000054AC
		public unsafe IDictionary<string, JsonSchemaModel> _PatternProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__PatternProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchemaModel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__PatternProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00057B94 File Offset: 0x00055D94
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x000072CB File Offset: 0x000054CB
		public unsafe JsonSchemaModel _AdditionalProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AdditionalProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AdditionalProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00057BC4 File Offset: 0x00055DC4
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x000072EA File Offset: 0x000054EA
		public unsafe JsonSchemaModel _AdditionalItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AdditionalItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchemaModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AdditionalItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00057BF4 File Offset: 0x00055DF4
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x00007309 File Offset: 0x00005509
		public unsafe bool _PositionalItemsValidation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField)) = value;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00057C1C File Offset: 0x00055E1C
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x00007324 File Offset: 0x00005524
		public unsafe bool _AllowAdditionalProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField)) = value;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00057C44 File Offset: 0x00055E44
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x0000733F File Offset: 0x0000553F
		public unsafe bool _AllowAdditionalItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00057C6C File Offset: 0x00055E6C
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x0000735A File Offset: 0x0000555A
		public unsafe bool _UniqueItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__UniqueItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__UniqueItems_k__BackingField)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00057C94 File Offset: 0x00055E94
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00007375 File Offset: 0x00005575
		public unsafe IList<JToken> _Enum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Enum_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Enum_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00057CC4 File Offset: 0x00055EC4
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00007394 File Offset: 0x00005594
		public unsafe JsonSchemaType _Disallow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Disallow_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchemaModel.NativeFieldInfoPtr__Disallow_k__BackingField)) = value;
			}
		}

		// Token: 0x04000C18 RID: 3096
		private static readonly IntPtr NativeFieldInfoPtr__Required_k__BackingField;

		// Token: 0x04000C19 RID: 3097
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000C1A RID: 3098
		private static readonly IntPtr NativeFieldInfoPtr__MinimumLength_k__BackingField;

		// Token: 0x04000C1B RID: 3099
		private static readonly IntPtr NativeFieldInfoPtr__MaximumLength_k__BackingField;

		// Token: 0x04000C1C RID: 3100
		private static readonly IntPtr NativeFieldInfoPtr__DivisibleBy_k__BackingField;

		// Token: 0x04000C1D RID: 3101
		private static readonly IntPtr NativeFieldInfoPtr__Minimum_k__BackingField;

		// Token: 0x04000C1E RID: 3102
		private static readonly IntPtr NativeFieldInfoPtr__Maximum_k__BackingField;

		// Token: 0x04000C1F RID: 3103
		private static readonly IntPtr NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField;

		// Token: 0x04000C20 RID: 3104
		private static readonly IntPtr NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField;

		// Token: 0x04000C21 RID: 3105
		private static readonly IntPtr NativeFieldInfoPtr__MinimumItems_k__BackingField;

		// Token: 0x04000C22 RID: 3106
		private static readonly IntPtr NativeFieldInfoPtr__MaximumItems_k__BackingField;

		// Token: 0x04000C23 RID: 3107
		private static readonly IntPtr NativeFieldInfoPtr__Patterns_k__BackingField;

		// Token: 0x04000C24 RID: 3108
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04000C25 RID: 3109
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x04000C26 RID: 3110
		private static readonly IntPtr NativeFieldInfoPtr__PatternProperties_k__BackingField;

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalProperties_k__BackingField;

		// Token: 0x04000C28 RID: 3112
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalItems_k__BackingField;

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField;

		// Token: 0x04000C2B RID: 3115
		private static readonly IntPtr NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField;

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeFieldInfoPtr__UniqueItems_k__BackingField;

		// Token: 0x04000C2D RID: 3117
		private static readonly IntPtr NativeFieldInfoPtr__Enum_k__BackingField;

		// Token: 0x04000C2E RID: 3118
		private static readonly IntPtr NativeFieldInfoPtr__Disallow_k__BackingField;

		// Token: 0x04000C2F RID: 3119
		private static readonly IntPtr NativeMethodInfoPtr_get_Required_Public_get_Boolean_0;

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr_set_Required_Public_set_Void_Boolean_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_JsonSchemaType_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_JsonSchemaType_0;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000C35 RID: 3125
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000C36 RID: 3126
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000C37 RID: 3127
		private static readonly IntPtr NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0;

		// Token: 0x04000C38 RID: 3128
		private static readonly IntPtr NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000C39 RID: 3129
		private static readonly IntPtr NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0;

		// Token: 0x04000C3A RID: 3130
		private static readonly IntPtr NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000C3B RID: 3131
		private static readonly IntPtr NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0;

		// Token: 0x04000C3C RID: 3132
		private static readonly IntPtr NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000C3D RID: 3133
		private static readonly IntPtr NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Boolean_0;

		// Token: 0x04000C3E RID: 3134
		private static readonly IntPtr NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Boolean_0;

		// Token: 0x04000C3F RID: 3135
		private static readonly IntPtr NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Boolean_0;

		// Token: 0x04000C40 RID: 3136
		private static readonly IntPtr NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Boolean_0;

		// Token: 0x04000C41 RID: 3137
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000C42 RID: 3138
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000C43 RID: 3139
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000C44 RID: 3140
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000C45 RID: 3141
		private static readonly IntPtr NativeMethodInfoPtr_get_Patterns_Public_get_IList_1_String_0;

		// Token: 0x04000C46 RID: 3142
		private static readonly IntPtr NativeMethodInfoPtr_set_Patterns_Public_set_Void_IList_1_String_0;

		// Token: 0x04000C47 RID: 3143
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchemaModel_0;

		// Token: 0x04000C48 RID: 3144
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchemaModel_0;

		// Token: 0x04000C49 RID: 3145
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchemaModel_0;

		// Token: 0x04000C4A RID: 3146
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0;

		// Token: 0x04000C4B RID: 3147
		private static readonly IntPtr NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchemaModel_0;

		// Token: 0x04000C4C RID: 3148
		private static readonly IntPtr NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchemaModel_0;

		// Token: 0x04000C4D RID: 3149
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchemaModel_0;

		// Token: 0x04000C4E RID: 3150
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchemaModel_0;

		// Token: 0x04000C4F RID: 3151
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchemaModel_0;

		// Token: 0x04000C50 RID: 3152
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchemaModel_0;

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0;

		// Token: 0x04000C57 RID: 3159
		private static readonly IntPtr NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0;

		// Token: 0x04000C58 RID: 3160
		private static readonly IntPtr NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0;

		// Token: 0x04000C59 RID: 3161
		private static readonly IntPtr NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0;

		// Token: 0x04000C5A RID: 3162
		private static readonly IntPtr NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0;

		// Token: 0x04000C5B RID: 3163
		private static readonly IntPtr NativeMethodInfoPtr_get_Disallow_Public_get_JsonSchemaType_0;

		// Token: 0x04000C5C RID: 3164
		private static readonly IntPtr NativeMethodInfoPtr_set_Disallow_Public_set_Void_JsonSchemaType_0;

		// Token: 0x04000C5D RID: 3165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C5E RID: 3166
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_JsonSchemaModel_IList_1_JsonSchema_0;

		// Token: 0x04000C5F RID: 3167
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Private_Static_Void_JsonSchemaModel_JsonSchema_0;
	}
}

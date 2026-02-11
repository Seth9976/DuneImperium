using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A3 RID: 163
	public class JsonSchema : Object
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x0005258C File Offset: 0x0005078C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchema()
		{
			Il2CppClassPointerStore<JsonSchema>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchema");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr);
			JsonSchema.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Id>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Title>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Required_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Required>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__ReadOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<ReadOnly>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Hidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Hidden>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Transient_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Transient>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Description>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Type>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Pattern>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__MinimumLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<MinimumLength>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__MaximumLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<MaximumLength>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__DivisibleBy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<DivisibleBy>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Minimum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Minimum>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Maximum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Maximum>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<ExclusiveMinimum>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<ExclusiveMaximum>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__MinimumItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<MinimumItems>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__MaximumItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<MaximumItems>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Items_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Items>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<PositionalItemsValidation>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__AdditionalItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<AdditionalItems>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<AllowAdditionalItems>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__UniqueItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<UniqueItems>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Properties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Properties>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__AdditionalProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<AdditionalProperties>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__PatternProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<PatternProperties>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<AllowAdditionalProperties>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Requires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Requires>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Enum_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Enum>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Disallow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Disallow>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Default>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Extends_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Extends>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Format>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<Location>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__internalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "_internalId");
			JsonSchema.NativeFieldInfoPtr__DeferredReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<DeferredReference>k__BackingField");
			JsonSchema.NativeFieldInfoPtr__ReferencesResolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, "<ReferencesResolved>k__BackingField");
			JsonSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665842);
			JsonSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665843);
			JsonSchema.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665844);
			JsonSchema.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665845);
			JsonSchema.NativeMethodInfoPtr_get_Required_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665846);
			JsonSchema.NativeMethodInfoPtr_set_Required_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665847);
			JsonSchema.NativeMethodInfoPtr_get_ReadOnly_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665848);
			JsonSchema.NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665849);
			JsonSchema.NativeMethodInfoPtr_get_Hidden_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665850);
			JsonSchema.NativeMethodInfoPtr_set_Hidden_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665851);
			JsonSchema.NativeMethodInfoPtr_get_Transient_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665852);
			JsonSchema.NativeMethodInfoPtr_set_Transient_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665853);
			JsonSchema.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665854);
			JsonSchema.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665855);
			JsonSchema.NativeMethodInfoPtr_get_Type_Public_get_Nullable_1_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665856);
			JsonSchema.NativeMethodInfoPtr_set_Type_Public_set_Void_Nullable_1_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665857);
			JsonSchema.NativeMethodInfoPtr_get_Pattern_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665858);
			JsonSchema.NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665859);
			JsonSchema.NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665860);
			JsonSchema.NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665861);
			JsonSchema.NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665862);
			JsonSchema.NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665863);
			JsonSchema.NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665864);
			JsonSchema.NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665865);
			JsonSchema.NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665866);
			JsonSchema.NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665867);
			JsonSchema.NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665868);
			JsonSchema.NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665869);
			JsonSchema.NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665870);
			JsonSchema.NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665871);
			JsonSchema.NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665872);
			JsonSchema.NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665873);
			JsonSchema.NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665874);
			JsonSchema.NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665875);
			JsonSchema.NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665876);
			JsonSchema.NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665877);
			JsonSchema.NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665878);
			JsonSchema.NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665879);
			JsonSchema.NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665880);
			JsonSchema.NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665881);
			JsonSchema.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665882);
			JsonSchema.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665883);
			JsonSchema.NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665884);
			JsonSchema.NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665885);
			JsonSchema.NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665886);
			JsonSchema.NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665887);
			JsonSchema.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665888);
			JsonSchema.NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665889);
			JsonSchema.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665890);
			JsonSchema.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665891);
			JsonSchema.NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665892);
			JsonSchema.NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665893);
			JsonSchema.NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665894);
			JsonSchema.NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665895);
			JsonSchema.NativeMethodInfoPtr_get_Requires_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665896);
			JsonSchema.NativeMethodInfoPtr_set_Requires_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665897);
			JsonSchema.NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665898);
			JsonSchema.NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665899);
			JsonSchema.NativeMethodInfoPtr_get_Disallow_Public_get_Nullable_1_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665900);
			JsonSchema.NativeMethodInfoPtr_set_Disallow_Public_set_Void_Nullable_1_JsonSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665901);
			JsonSchema.NativeMethodInfoPtr_get_Default_Public_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665902);
			JsonSchema.NativeMethodInfoPtr_set_Default_Public_set_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665903);
			JsonSchema.NativeMethodInfoPtr_get_Extends_Public_get_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665904);
			JsonSchema.NativeMethodInfoPtr_set_Extends_Public_set_Void_IList_1_JsonSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665905);
			JsonSchema.NativeMethodInfoPtr_get_Format_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665906);
			JsonSchema.NativeMethodInfoPtr_set_Format_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665907);
			JsonSchema.NativeMethodInfoPtr_get_Location_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665908);
			JsonSchema.NativeMethodInfoPtr_set_Location_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665909);
			JsonSchema.NativeMethodInfoPtr_get_InternalId_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665910);
			JsonSchema.NativeMethodInfoPtr_get_DeferredReference_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665911);
			JsonSchema.NativeMethodInfoPtr_set_DeferredReference_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665912);
			JsonSchema.NativeMethodInfoPtr_get_ReferencesResolved_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665913);
			JsonSchema.NativeMethodInfoPtr_set_ReferencesResolved_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665914);
			JsonSchema.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665915);
			JsonSchema.NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665916);
			JsonSchema.NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665917);
			JsonSchema.NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665918);
			JsonSchema.NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665919);
			JsonSchema.NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665920);
			JsonSchema.NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_JsonSchemaResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665921);
			JsonSchema.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr, 100665922);
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00052EF4 File Offset: 0x000510F4
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00052F2C File Offset: 0x0005112C
		public unsafe string Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00052F70 File Offset: 0x00051170
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x00052FA8 File Offset: 0x000511A8
		public unsafe string Title
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00052FEC File Offset: 0x000511EC
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x00053024 File Offset: 0x00051224
		public unsafe Nullable<bool> Required
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Required_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Required_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0005306C File Offset: 0x0005126C
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x000530A4 File Offset: 0x000512A4
		public unsafe Nullable<bool> ReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_ReadOnly_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x000530EC File Offset: 0x000512EC
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x00053124 File Offset: 0x00051324
		public unsafe Nullable<bool> Hidden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Hidden_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Hidden_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0005316C File Offset: 0x0005136C
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x000531A4 File Offset: 0x000513A4
		public unsafe Nullable<bool> Transient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Transient_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Transient_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x000531EC File Offset: 0x000513EC
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00053224 File Offset: 0x00051424
		public unsafe string Description
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00053268 File Offset: 0x00051468
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x000532A0 File Offset: 0x000514A0
		public unsafe Nullable<JsonSchemaType> Type
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Type_Public_get_Nullable_1_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<JsonSchemaType>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Type_Public_set_Void_Nullable_1_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000532E8 File Offset: 0x000514E8
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00053320 File Offset: 0x00051520
		public unsafe string Pattern
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Pattern_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x00053364 File Offset: 0x00051564
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x0005339C File Offset: 0x0005159C
		public unsafe Nullable<int> MinimumLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x000533E4 File Offset: 0x000515E4
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x0005341C File Offset: 0x0005161C
		public unsafe Nullable<int> MaximumLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x00053464 File Offset: 0x00051664
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x0005349C File Offset: 0x0005169C
		public unsafe Nullable<double> DivisibleBy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000534E4 File Offset: 0x000516E4
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x0005351C File Offset: 0x0005171C
		public unsafe Nullable<double> Minimum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00053564 File Offset: 0x00051764
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x0005359C File Offset: 0x0005179C
		public unsafe Nullable<double> Maximum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000535E4 File Offset: 0x000517E4
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x0005361C File Offset: 0x0005181C
		public unsafe Nullable<bool> ExclusiveMinimum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00053664 File Offset: 0x00051864
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x0005369C File Offset: 0x0005189C
		public unsafe Nullable<bool> ExclusiveMaximum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x000536E4 File Offset: 0x000518E4
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x0005371C File Offset: 0x0005191C
		public unsafe Nullable<int> MinimumItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00053764 File Offset: 0x00051964
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0005379C File Offset: 0x0005199C
		public unsafe Nullable<int> MaximumItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000537E4 File Offset: 0x000519E4
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00053824 File Offset: 0x00051A24
		public unsafe IList<JsonSchema> Items
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00053868 File Offset: 0x00051A68
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x000538A4 File Offset: 0x00051AA4
		public unsafe bool PositionalItemsValidation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x000538E4 File Offset: 0x00051AE4
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00053924 File Offset: 0x00051B24
		public unsafe JsonSchema AdditionalItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00053968 File Offset: 0x00051B68
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x000539A4 File Offset: 0x00051BA4
		public unsafe bool AllowAdditionalItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x000539E4 File Offset: 0x00051BE4
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00053A20 File Offset: 0x00051C20
		public unsafe bool UniqueItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00053A60 File Offset: 0x00051C60
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00053AA0 File Offset: 0x00051CA0
		public unsafe IDictionary<string, JsonSchema> Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00053AE4 File Offset: 0x00051CE4
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00053B24 File Offset: 0x00051D24
		public unsafe JsonSchema AdditionalProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00053B68 File Offset: 0x00051D68
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00053BA8 File Offset: 0x00051DA8
		public unsafe IDictionary<string, JsonSchema> PatternProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00053BEC File Offset: 0x00051DEC
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00053C28 File Offset: 0x00051E28
		public unsafe bool AllowAdditionalProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00053C68 File Offset: 0x00051E68
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00053CA0 File Offset: 0x00051EA0
		public unsafe string Requires
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Requires_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Requires_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00053CE4 File Offset: 0x00051EE4
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00053D24 File Offset: 0x00051F24
		public unsafe IList<JToken> Enum
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00053D68 File Offset: 0x00051F68
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x00053DA0 File Offset: 0x00051FA0
		public unsafe Nullable<JsonSchemaType> Disallow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Disallow_Public_get_Nullable_1_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<JsonSchemaType>(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Disallow_Public_set_Void_Nullable_1_JsonSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00053DE8 File Offset: 0x00051FE8
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00053E28 File Offset: 0x00052028
		public unsafe JToken Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Default_Public_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Default_Public_set_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00053E6C File Offset: 0x0005206C
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00053EAC File Offset: 0x000520AC
		public unsafe IList<JsonSchema> Extends
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Extends_Public_get_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Extends_Public_set_Void_IList_1_JsonSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00053EF0 File Offset: 0x000520F0
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00053F28 File Offset: 0x00052128
		public unsafe string Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Format_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Format_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00053F6C File Offset: 0x0005216C
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00053FA4 File Offset: 0x000521A4
		public unsafe string Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_Location_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_Location_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00053FE8 File Offset: 0x000521E8
		public unsafe string InternalId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_InternalId_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00054020 File Offset: 0x00052220
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x00054058 File Offset: 0x00052258
		public unsafe string DeferredReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_DeferredReference_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_DeferredReference_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x0005409C File Offset: 0x0005229C
		// (set) Token: 0x06000E36 RID: 3638 RVA: 0x000540D8 File Offset: 0x000522D8
		public unsafe bool ReferencesResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_get_ReferencesResolved_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_set_ReferencesResolved_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00054118 File Offset: 0x00052318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754076, RefRangeEnd = 754077, XrefRangeStart = 754070, XrefRangeEnd = 754076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonSchema()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonSchema>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00054154 File Offset: 0x00052354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754077, XrefRangeEnd = 754082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchema Read(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00054198 File Offset: 0x00052398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 754120, RefRangeEnd = 754122, XrefRangeStart = 754082, XrefRangeEnd = 754120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchema Read(JsonReader reader, JsonSchemaResolver resolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_JsonSchemaResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000541F0 File Offset: 0x000523F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754122, XrefRangeEnd = 754127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchema Parse(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00054234 File Offset: 0x00052434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 754145, RefRangeEnd = 754146, XrefRangeStart = 754127, XrefRangeEnd = 754145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JsonSchema Parse(string json, JsonSchemaResolver resolver)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_JsonSchemaResolver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr3) : null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0005428C File Offset: 0x0005248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754146, XrefRangeEnd = 754166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTo(JsonWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000542D0 File Offset: 0x000524D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754166, XrefRangeEnd = 754182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTo(JsonWriter writer, JsonSchemaResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonSchema.NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_JsonSchemaResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00054324 File Offset: 0x00052524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 754182, XrefRangeEnd = 754216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonSchema.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0000674A File Offset: 0x0000494A
		public JsonSchema(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00054368 File Offset: 0x00052568
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00006753 File Offset: 0x00004953
		public unsafe string _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00054390 File Offset: 0x00052590
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00006772 File Offset: 0x00004972
		public unsafe string _Title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000543B8 File Offset: 0x000525B8
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00006791 File Offset: 0x00004991
		public Nullable<bool> _Required_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Required_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Required_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000543E8 File Offset: 0x000525E8
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x000067BF File Offset: 0x000049BF
		public Nullable<bool> _ReadOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ReadOnly_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ReadOnly_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00054418 File Offset: 0x00052618
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x000067ED File Offset: 0x000049ED
		public Nullable<bool> _Hidden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Hidden_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Hidden_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00054448 File Offset: 0x00052648
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0000681B File Offset: 0x00004A1B
		public Nullable<bool> _Transient_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Transient_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Transient_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00054478 File Offset: 0x00052678
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00006849 File Offset: 0x00004A49
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x000544A0 File Offset: 0x000526A0
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00006868 File Offset: 0x00004A68
		public Nullable<JsonSchemaType> _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Type_k__BackingField);
				return new Nullable<JsonSchemaType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<JsonSchemaType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<JsonSchemaType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000544D0 File Offset: 0x000526D0
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00006896 File Offset: 0x00004A96
		public unsafe string _Pattern_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Pattern_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Pattern_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x000544F8 File Offset: 0x000526F8
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x000068B5 File Offset: 0x00004AB5
		public Nullable<int> _MinimumLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MinimumLength_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MinimumLength_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00054528 File Offset: 0x00052728
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000068E3 File Offset: 0x00004AE3
		public Nullable<int> _MaximumLength_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MaximumLength_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MaximumLength_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00054558 File Offset: 0x00052758
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00006911 File Offset: 0x00004B11
		public Nullable<double> _DivisibleBy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__DivisibleBy_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__DivisibleBy_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00054588 File Offset: 0x00052788
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x0000693F File Offset: 0x00004B3F
		public Nullable<double> _Minimum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Minimum_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Minimum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x000545B8 File Offset: 0x000527B8
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0000696D File Offset: 0x00004B6D
		public Nullable<double> _Maximum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Maximum_k__BackingField);
				return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Maximum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000545E8 File Offset: 0x000527E8
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0000699B File Offset: 0x00004B9B
		public Nullable<bool> _ExclusiveMinimum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00054618 File Offset: 0x00052818
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000069C9 File Offset: 0x00004BC9
		public Nullable<bool> _ExclusiveMaximum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00054648 File Offset: 0x00052848
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000069F7 File Offset: 0x00004BF7
		public Nullable<int> _MinimumItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MinimumItems_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MinimumItems_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00054678 File Offset: 0x00052878
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00006A25 File Offset: 0x00004C25
		public Nullable<int> _MaximumItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MaximumItems_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__MaximumItems_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x000546A8 File Offset: 0x000528A8
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00006A53 File Offset: 0x00004C53
		public unsafe IList<JsonSchema> _Items_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Items_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Items_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000546D8 File Offset: 0x000528D8
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00006A72 File Offset: 0x00004C72
		public unsafe bool _PositionalItemsValidation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00054700 File Offset: 0x00052900
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x00006A8D File Offset: 0x00004C8D
		public unsafe JsonSchema _AdditionalItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AdditionalItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AdditionalItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00054730 File Offset: 0x00052930
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x00006AAC File Offset: 0x00004CAC
		public unsafe bool _AllowAdditionalItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00054758 File Offset: 0x00052958
		// (set) Token: 0x06000E6D RID: 3693 RVA: 0x00006AC7 File Offset: 0x00004CC7
		public unsafe bool _UniqueItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__UniqueItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__UniqueItems_k__BackingField)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00054780 File Offset: 0x00052980
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00006AE2 File Offset: 0x00004CE2
		public unsafe IDictionary<string, JsonSchema> _Properties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Properties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Properties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000547B0 File Offset: 0x000529B0
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00006B01 File Offset: 0x00004D01
		public unsafe JsonSchema _AdditionalProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AdditionalProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AdditionalProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000547E0 File Offset: 0x000529E0
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00006B20 File Offset: 0x00004D20
		public unsafe IDictionary<string, JsonSchema> _PatternProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__PatternProperties_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__PatternProperties_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00054810 File Offset: 0x00052A10
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00006B3F File Offset: 0x00004D3F
		public unsafe bool _AllowAdditionalProperties_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00054838 File Offset: 0x00052A38
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00006B5A File Offset: 0x00004D5A
		public unsafe string _Requires_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Requires_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Requires_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00054860 File Offset: 0x00052A60
		// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00006B79 File Offset: 0x00004D79
		public unsafe IList<JToken> _Enum_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Enum_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Enum_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00054890 File Offset: 0x00052A90
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00006B98 File Offset: 0x00004D98
		public Nullable<JsonSchemaType> _Disallow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Disallow_k__BackingField);
				return new Nullable<JsonSchemaType>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<JsonSchemaType>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Disallow_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<JsonSchemaType>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000548C0 File Offset: 0x00052AC0
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x00006BC6 File Offset: 0x00004DC6
		public unsafe JToken _Default_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Default_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Default_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000548F0 File Offset: 0x00052AF0
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00006BE5 File Offset: 0x00004DE5
		public unsafe IList<JsonSchema> _Extends_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Extends_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<JsonSchema>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Extends_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00054920 File Offset: 0x00052B20
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00006C04 File Offset: 0x00004E04
		public unsafe string _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Format_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00054948 File Offset: 0x00052B48
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00006C23 File Offset: 0x00004E23
		public unsafe string _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Location_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00054970 File Offset: 0x00052B70
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00006C42 File Offset: 0x00004E42
		public unsafe string _internalId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__internalId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__internalId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00054998 File Offset: 0x00052B98
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00006C61 File Offset: 0x00004E61
		public unsafe string _DeferredReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__DeferredReference_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__DeferredReference_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000549C0 File Offset: 0x00052BC0
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00006C80 File Offset: 0x00004E80
		public unsafe bool _ReferencesResolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ReferencesResolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonSchema.NativeFieldInfoPtr__ReferencesResolved_k__BackingField)) = value;
			}
		}

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeFieldInfoPtr__Required_k__BackingField;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr__ReadOnly_k__BackingField;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr__Hidden_k__BackingField;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr__Transient_k__BackingField;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr__MinimumLength_k__BackingField;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr__MaximumLength_k__BackingField;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr__DivisibleBy_k__BackingField;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr__Minimum_k__BackingField;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr__Maximum_k__BackingField;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr__ExclusiveMinimum_k__BackingField;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr__ExclusiveMaximum_k__BackingField;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr__MinimumItems_k__BackingField;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr__MaximumItems_k__BackingField;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr__Items_k__BackingField;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr__PositionalItemsValidation_k__BackingField;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalItems_k__BackingField;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr__AllowAdditionalItems_k__BackingField;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr__UniqueItems_k__BackingField;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr__Properties_k__BackingField;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr__AdditionalProperties_k__BackingField;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr__PatternProperties_k__BackingField;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeFieldInfoPtr__AllowAdditionalProperties_k__BackingField;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeFieldInfoPtr__Requires_k__BackingField;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeFieldInfoPtr__Enum_k__BackingField;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeFieldInfoPtr__Disallow_k__BackingField;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeFieldInfoPtr__Default_k__BackingField;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeFieldInfoPtr__Extends_k__BackingField;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeFieldInfoPtr__internalId;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr__DeferredReference_k__BackingField;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr__ReferencesResolved_k__BackingField;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_set_Title_Public_set_Void_String_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_get_Required_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_set_Required_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadOnly_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadOnly_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_get_Hidden_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_set_Hidden_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_get_Transient_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_set_Transient_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Nullable_1_JsonSchemaType_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_Nullable_1_JsonSchemaType_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_get_String_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumLength_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumLength_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumLength_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumLength_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_get_DivisibleBy_Public_get_Nullable_1_Double_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_set_DivisibleBy_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_get_Minimum_Public_get_Nullable_1_Double_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_set_Minimum_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_get_Maximum_Public_get_Nullable_1_Double_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_set_Maximum_Public_set_Void_Nullable_1_Double_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_get_ExclusiveMinimum_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_set_ExclusiveMinimum_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_get_ExclusiveMaximum_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_set_ExclusiveMaximum_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumItems_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumItems_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumItems_Public_get_Nullable_1_Int32_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_set_MaximumItems_Public_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_get_Items_Public_get_IList_1_JsonSchema_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_set_Items_Public_set_Void_IList_1_JsonSchema_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionalItemsValidation_Public_get_Boolean_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionalItemsValidation_Public_set_Void_Boolean_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalItems_Public_get_JsonSchema_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalItems_Public_set_Void_JsonSchema_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowAdditionalItems_Public_get_Boolean_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAdditionalItems_Public_set_Void_Boolean_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_get_UniqueItems_Public_get_Boolean_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_set_UniqueItems_Public_set_Void_Boolean_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_2_String_JsonSchema_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_set_Void_IDictionary_2_String_JsonSchema_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalProperties_Public_get_JsonSchema_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_set_AdditionalProperties_Public_set_Void_JsonSchema_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_get_PatternProperties_Public_get_IDictionary_2_String_JsonSchema_0;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeMethodInfoPtr_set_PatternProperties_Public_set_Void_IDictionary_2_String_JsonSchema_0;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowAdditionalProperties_Public_get_Boolean_0;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowAdditionalProperties_Public_set_Void_Boolean_0;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeMethodInfoPtr_get_Requires_Public_get_String_0;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_set_Requires_Public_set_Void_String_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_get_Enum_Public_get_IList_1_JToken_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_set_Enum_Public_set_Void_IList_1_JToken_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_get_Disallow_Public_get_Nullable_1_JsonSchemaType_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_set_Disallow_Public_set_Void_Nullable_1_JsonSchemaType_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_get_JToken_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_set_Default_Public_set_Void_JToken_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_get_Extends_Public_get_IList_1_JsonSchema_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_set_Extends_Public_set_Void_IList_1_JsonSchema_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_String_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_set_Void_String_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Internal_get_String_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Internal_set_Void_String_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Internal_get_String_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_get_DeferredReference_Internal_get_String_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_set_DeferredReference_Internal_set_Void_String_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferencesResolved_Internal_get_Boolean_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_set_ReferencesResolved_Internal_set_Void_Boolean_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Static_JsonSchema_JsonReader_JsonSchemaResolver_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JsonSchema_String_JsonSchemaResolver_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Void_JsonWriter_JsonSchemaResolver_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

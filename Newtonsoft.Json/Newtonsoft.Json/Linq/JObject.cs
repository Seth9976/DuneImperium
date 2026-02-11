using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BA RID: 186
	public class JObject : JContainer
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x0005DE04 File Offset: 0x0005C004
		// Note: this type is marked as 'beforefieldinit'.
		static JObject()
		{
			Il2CppClassPointerStore<JObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject>.NativeClassPtr);
			JObject.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject>.NativeClassPtr, "_properties");
			JObject.NativeFieldInfoPtr_PropertyChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject>.NativeClassPtr, "PropertyChanged");
			JObject.NativeFieldInfoPtr_PropertyChanging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject>.NativeClassPtr, "PropertyChanging");
			JObject.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666328);
			JObject.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666329);
			JObject.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666330);
			JObject.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666331);
			JObject.NativeMethodInfoPtr_add_PropertyChanged_Public_Virtual_Final_New_add_Void_PropertyChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666332);
			JObject.NativeMethodInfoPtr_remove_PropertyChanged_Public_Virtual_Final_New_rem_Void_PropertyChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666333);
			JObject.NativeMethodInfoPtr_add_PropertyChanging_Public_Virtual_Final_New_add_Void_PropertyChangingEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666334);
			JObject.NativeMethodInfoPtr_remove_PropertyChanging_Public_Virtual_Final_New_rem_Void_PropertyChangingEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666335);
			JObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666336);
			JObject.NativeMethodInfoPtr__ctor_Public_Void_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666337);
			JObject.NativeMethodInfoPtr__ctor_Internal_Void_JObject_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666338);
			JObject.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666339);
			JObject.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666340);
			JObject.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666341);
			JObject.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666342);
			JObject.NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666343);
			JObject.NativeMethodInfoPtr_ValidateToken_Internal_Virtual_Void_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666344);
			JObject.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666345);
			JObject.NativeMethodInfoPtr_IsNull_Private_Static_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666346);
			JObject.NativeMethodInfoPtr_InternalPropertyChanged_Internal_Void_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666347);
			JObject.NativeMethodInfoPtr_InternalPropertyChanging_Internal_Void_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666348);
			JObject.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666349);
			JObject.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666350);
			JObject.NativeMethodInfoPtr_Properties_Public_IEnumerable_1_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666351);
			JObject.NativeMethodInfoPtr_Property_Public_JProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666352);
			JObject.NativeMethodInfoPtr_Property_Public_JProperty_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666353);
			JObject.NativeMethodInfoPtr_PropertyValues_Public_JEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666354);
			JObject.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666355);
			JObject.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666356);
			JObject.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666357);
			JObject.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666358);
			JObject.NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666359);
			JObject.NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666360);
			JObject.NativeMethodInfoPtr_Parse_Public_Static_JObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666361);
			JObject.NativeMethodInfoPtr_Parse_Public_Static_JObject_String_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666362);
			JObject.NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666363);
			JObject.NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666364);
			JObject.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666365);
			JObject.NativeMethodInfoPtr_GetValue_Public_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666366);
			JObject.NativeMethodInfoPtr_GetValue_Public_JToken_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666367);
			JObject.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_StringComparison_byref_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666368);
			JObject.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666369);
			JObject.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666370);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666371);
			JObject.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666372);
			JObject.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666373);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666374);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666375);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666376);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666377);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666378);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666379);
			JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666380);
			JObject.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666381);
			JObject.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666382);
			JObject.NativeMethodInfoPtr_OnPropertyChanged_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666383);
			JObject.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666384);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666385);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666386);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666387);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666388);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666389);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666390);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666391);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666392);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666393);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666394);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666395);
			JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666396);
			JObject.NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_DynamicMetaObject_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666397);
			JObject.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject>.NativeClassPtr, 100666398);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758118, XrefRangeEnd = 758133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005E490 File Offset: 0x0005C690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758133, XrefRangeEnd = 758134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JObject> LoadAsync(JsonReader reader, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JObject>>(intPtr3) : null;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0005E4EC File Offset: 0x0005C6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 758150, RefRangeEnd = 758152, XrefRangeStart = 758134, XrefRangeEnd = 758150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static Task<JObject> LoadAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_JsonLoadSettings_CancellationToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<JObject>>(intPtr3) : null;
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x0005E55C File Offset: 0x0005C75C
		public unsafe override IList<JToken> ChildrenTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0005E5A8 File Offset: 0x0005C7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758152, XrefRangeEnd = 758156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_PropertyChanged(PropertyChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_add_PropertyChanged_Public_Virtual_Final_New_add_Void_PropertyChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0005E5EC File Offset: 0x0005C7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758156, XrefRangeEnd = 758160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_PropertyChanged(PropertyChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_remove_PropertyChanged_Public_Virtual_Final_New_rem_Void_PropertyChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0005E630 File Offset: 0x0005C830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758160, XrefRangeEnd = 758164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_PropertyChanging(PropertyChangingEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_add_PropertyChanging_Public_Virtual_Final_New_add_Void_PropertyChangingEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0005E674 File Offset: 0x0005C874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758164, XrefRangeEnd = 758168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_PropertyChanging(PropertyChangingEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_remove_PropertyChanging_Public_Virtual_Final_New_rem_Void_PropertyChangingEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0005E6B8 File Offset: 0x0005C8B8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 758177, RefRangeEnd = 758187, XrefRangeStart = 758168, XrefRangeEnd = 758177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0005E6F4 File Offset: 0x0005C8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758187, XrefRangeEnd = 758193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JObject(JObject other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr__ctor_Public_Void_JObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0005E740 File Offset: 0x0005C940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758193, XrefRangeEnd = 758199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JObject(JObject other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr__ctor_Internal_Void_JObject_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0005E7A0 File Offset: 0x0005C9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758199, XrefRangeEnd = 758208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JObject([Optional] Il2CppReferenceArray<Object> content)
		{
			if (content == null)
			{
				content = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0005E7F8 File Offset: 0x0005C9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JObject(Object content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0005E844 File Offset: 0x0005CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758208, XrefRangeEnd = 758212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DeepEquals(JToken node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0005E89C File Offset: 0x0005CA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758212, XrefRangeEnd = 758218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOfItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0005E8F4 File Offset: 0x0005CAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758218, XrefRangeEnd = 758220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipParentCheck;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyAnnotations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0005E978 File Offset: 0x0005CB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758220, XrefRangeEnd = 758231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateToken(JToken o, JToken existing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(existing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_ValidateToken_Internal_Virtual_Void_JToken_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0005E9D8 File Offset: 0x0005CBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758231, XrefRangeEnd = 758266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MergeItem(Object content, JsonMergeSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0005EA38 File Offset: 0x0005CC38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758268, RefRangeEnd = 758269, XrefRangeStart = 758266, XrefRangeEnd = 758268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNull(JToken token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_IsNull_Private_Static_Boolean_JToken_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0005EA7C File Offset: 0x0005CC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758269, XrefRangeEnd = 758277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalPropertyChanged(JProperty childProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_InternalPropertyChanged_Internal_Void_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0005EAC0 File Offset: 0x0005CCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758277, XrefRangeEnd = 758278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalPropertyChanging(JProperty childProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(childProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_InternalPropertyChanging_Internal_Void_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x0005EB04 File Offset: 0x0005CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758278, XrefRangeEnd = 758287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JToken CloneToken(JsonCloneSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0005EB60 File Offset: 0x0005CD60
		public unsafe override JTokenType Type
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0005EBA8 File Offset: 0x0005CDA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758290, RefRangeEnd = 758291, XrefRangeStart = 758287, XrefRangeEnd = 758290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JProperty> Properties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Properties_Public_IEnumerable_1_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JProperty>>(intPtr3) : null;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0005EBE8 File Offset: 0x0005CDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758291, XrefRangeEnd = 758292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty Property(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Property_Public_JProperty_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr3) : null;
			}
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0005EC38 File Offset: 0x0005CE38
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 758309, RefRangeEnd = 758321, XrefRangeStart = 758292, XrefRangeEnd = 758309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JProperty Property(string name, StringComparison comparison)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparison;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Property_Public_JProperty_String_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr3) : null;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x0005EC98 File Offset: 0x0005CE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758321, XrefRangeEnd = 758345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JEnumerable<JToken> PropertyValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_PropertyValues_Public_JEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JEnumerable<JToken>(intPtr);
		}

		// Token: 0x1700048E RID: 1166
		public unsafe override JToken this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758345, XrefRangeEnd = 758362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758362, XrefRangeEnd = 758379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700048F RID: 1167
		public unsafe virtual JToken this[string propertyName]
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 758383, RefRangeEnd = 758388, XrefRangeStart = 758379, XrefRangeEnd = 758383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 758390, RefRangeEnd = 758393, XrefRangeStart = 758388, XrefRangeEnd = 758390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0005EE30 File Offset: 0x0005D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758393, XrefRangeEnd = 758394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject Load(JsonReader reader)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0005EE74 File Offset: 0x0005D074
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 758407, RefRangeEnd = 758410, XrefRangeStart = 758394, XrefRangeEnd = 758407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject Load(JsonReader reader, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0005EECC File Offset: 0x0005D0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758411, RefRangeEnd = 758412, XrefRangeStart = 758410, XrefRangeEnd = 758411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject Parse(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Parse_Public_Static_JObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x0005EF10 File Offset: 0x0005D110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758427, RefRangeEnd = 758428, XrefRangeStart = 758412, XrefRangeEnd = 758427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject Parse(string json, JsonLoadSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Parse_Public_Static_JObject_String_JsonLoadSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0005EF68 File Offset: 0x0005D168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758428, XrefRangeEnd = 758435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject FromObject(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0005EFAC File Offset: 0x0005D1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758435, XrefRangeEnd = 758441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static JObject FromObject(Object o, JsonSerializer jsonSerializer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(jsonSerializer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_JsonSerializer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr3) : null;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0005F004 File Offset: 0x0005D204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758441, XrefRangeEnd = 758449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(JsonWriter writer, [Optional] Il2CppReferenceArray<JsonConverter> converters)
		{
			if (converters == null)
			{
				converters = new Il2CppReferenceArray<JsonConverter>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0005F070 File Offset: 0x0005D270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758449, XrefRangeEnd = 758450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken GetValue(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_GetValue_Public_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x0005F0C0 File Offset: 0x0005D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758450, XrefRangeEnd = 758451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken GetValue(string propertyName, StringComparison comparison)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparison;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_GetValue_Public_JToken_String_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0005F120 File Offset: 0x0005D320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758451, XrefRangeEnd = 758454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string propertyName, StringComparison comparison, out JToken value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparison;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_StringComparison_byref_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new JToken(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 758458, RefRangeEnd = 758460, XrefRangeStart = 758454, XrefRangeEnd = 758458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string propertyName, JToken value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758460, XrefRangeEnd = 758464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0005F244 File Offset: 0x0005D444
		public unsafe virtual ICollection<string> prop_ICollection_1_String_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758464, XrefRangeEnd = 758469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x0005F284 File Offset: 0x0005D484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758470, RefRangeEnd = 758471, XrefRangeStart = 758469, XrefRangeEnd = 758470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0005F2D4 File Offset: 0x0005D4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758473, RefRangeEnd = 758474, XrefRangeStart = 758471, XrefRangeEnd = 758473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string propertyName, out JToken value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new JToken(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0005F344 File Offset: 0x0005D544
		public unsafe virtual ICollection<JToken> prop_ICollection_1_JToken_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758474, XrefRangeEnd = 758479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x0005F384 File Offset: 0x0005D584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758479, XrefRangeEnd = 758485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_0(KeyValuePair<string, JToken> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0005F3CC File Offset: 0x0005D5CC
		[CallerCount(0)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0005F400 File Offset: 0x0005D600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758485, XrefRangeEnd = 758488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_0(KeyValuePair<string, JToken> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0005F454 File Offset: 0x0005D654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758488, XrefRangeEnd = 758511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_JToken_Int32_0(Il2CppReferenceArray<KeyValuePair<string, JToken>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0005F4A4 File Offset: 0x0005D6A4
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0005F4E0 File Offset: 0x0005D6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758511, XrefRangeEnd = 758518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_1(KeyValuePair<string, JToken> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005F534 File Offset: 0x0005D734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetDeepHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005F57C File Offset: 0x0005D77C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 758523, RefRangeEnd = 758525, XrefRangeStart = 758518, XrefRangeEnd = 758523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, JToken>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, JToken>>>(intPtr3) : null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758525, XrefRangeEnd = 758529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPropertyChanged(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_OnPropertyChanged_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0005F60C File Offset: 0x0005D80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758529, XrefRangeEnd = 758533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPropertyChanging(string propertyName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0005F65C File Offset: 0x0005D85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758533, XrefRangeEnd = 758537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0005F69C File Offset: 0x0005D89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758537, XrefRangeEnd = 758574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetProperties(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0005F6EC File Offset: 0x0005D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758574, XrefRangeEnd = 758578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AttributeCollection System_ComponentModel_ICustomTypeDescriptor_GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0005F72C File Offset: 0x0005D92C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ICustomTypeDescriptor_GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0005F764 File Offset: 0x0005D964
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ICustomTypeDescriptor_GetComponentName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0005F79C File Offset: 0x0005D99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758578, XrefRangeEnd = 758582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeConverter System_ComponentModel_ICustomTypeDescriptor_GetConverter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeConverter>(intPtr3) : null;
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x0005F7DC File Offset: 0x0005D9DC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0005F81C File Offset: 0x0005DA1C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptor System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0005F85C File Offset: 0x0005DA5C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ComponentModel_ICustomTypeDescriptor_GetEditor(Type editorBaseType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(editorBaseType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0005F8AC File Offset: 0x0005DAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758582, XrefRangeEnd = 758586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents(Il2CppReferenceArray<Attribute> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0005F8FC File Offset: 0x0005DAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758586, XrefRangeEnd = 758590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptorCollection System_ComponentModel_ICustomTypeDescriptor_GetEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr3) : null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0005F93C File Offset: 0x0005DB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758590, XrefRangeEnd = 758592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner(PropertyDescriptor pd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0005F98C File Offset: 0x0005DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758592, XrefRangeEnd = 758604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject GetMetaObject(Expression parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_DynamicMetaObject_Expression_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0005F9E8 File Offset: 0x0005DBE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758618, RefRangeEnd = 758619, XrefRangeStart = 758604, XrefRangeEnd = 758618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task Method_Private_Task_Task_Int32_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0(Task task, int i, JsonWriter Writer, CancellationToken CancellationToken, Il2CppReferenceArray<JsonConverter> Converters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Writer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(CancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Converters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00007794 File Offset: 0x00005994
		public override Task WriteToAsync(JsonWriter writer, CancellationToken cancellationToken, params JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, cancellationToken, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000077A4 File Offset: 0x000059A4
		public JObject(params Object[] content)
			: this(new Il2CppReferenceArray<Object>(content))
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000077B2 File Offset: 0x000059B2
		public override void WriteTo(JsonWriter writer, params JsonConverter[] converters)
		{
			this.WriteTo(writer, new Il2CppReferenceArray<JsonConverter>(converters));
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000077C1 File Offset: 0x000059C1
		public JObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0005FA84 File Offset: 0x0005DC84
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x000077CA File Offset: 0x000059CA
		public unsafe JPropertyKeyedCollection _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JPropertyKeyedCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0005FAB4 File Offset: 0x0005DCB4
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x000077E9 File Offset: 0x000059E9
		public unsafe PropertyChangedEventHandler PropertyChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr_PropertyChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr_PropertyChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0005FAE4 File Offset: 0x0005DCE4
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x00007808 File Offset: 0x00005A08
		public unsafe PropertyChangingEventHandler PropertyChanging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr_PropertyChanging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyChangingEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.NativeFieldInfoPtr_PropertyChanging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanged;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeFieldInfoPtr_PropertyChanging;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_WriteToAsync_Public_Virtual_Task_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_CancellationToken_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_Task_1_JObject_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildrenTokens_Protected_Virtual_get_IList_1_JToken_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_add_PropertyChanged_Public_Virtual_Final_New_add_Void_PropertyChangedEventHandler_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_remove_PropertyChanged_Public_Virtual_Final_New_rem_Void_PropertyChangedEventHandler_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_add_PropertyChanging_Public_Virtual_Final_New_add_Void_PropertyChangingEventHandler_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_remove_PropertyChanging_Public_Virtual_Final_New_rem_Void_PropertyChangingEventHandler_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_JObject_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JObject_JsonCloneSettings_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_DeepEquals_Internal_Virtual_Boolean_JToken_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfItem_Internal_Virtual_Int32_JToken_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Internal_Virtual_Boolean_Int32_JToken_Boolean_Boolean_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToken_Internal_Virtual_Void_JToken_JToken_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_MergeItem_Internal_Virtual_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Private_Static_Boolean_JToken_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_InternalPropertyChanged_Internal_Void_JProperty_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_InternalPropertyChanging_Internal_Void_JProperty_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_CloneToken_Internal_Virtual_JToken_JsonCloneSettings_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_JTokenType_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_Properties_Public_IEnumerable_1_JProperty_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_Property_Public_JProperty_String_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_Property_Public_JProperty_String_StringComparison_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_PropertyValues_Public_JEnumerable_1_JToken_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_get_JToken_Object_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_set_Void_Object_JToken_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_JToken_String_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_JToken_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_JObject_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JObject_String_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_JObject_String_JsonLoadSettings_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_FromObject_Public_Static_JObject_Object_JsonSerializer_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_JsonWriter_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_JToken_String_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_JToken_String_StringComparison_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_StringComparison_byref_JToken_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_JToken_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_JToken_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_JToken_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_String_JToken_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_JToken_Int32_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_String_JToken_1;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_GetDeepHashCode_Internal_Virtual_Int32_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_JToken_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanged_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_OnPropertyChanging_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetAttributes_Private_Virtual_Final_New_AttributeCollection_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetClassName_Private_Virtual_Final_New_String_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetComponentName_Private_Virtual_Final_New_String_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetConverter_Private_Virtual_Final_New_TypeConverter_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultEvent_Private_Virtual_Final_New_EventDescriptor_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetDefaultProperty_Private_Virtual_Final_New_PropertyDescriptor_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEditor_Private_Virtual_Final_New_Object_Type_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetEvents_Private_Virtual_Final_New_EventDescriptorCollection_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ICustomTypeDescriptor_GetPropertyOwner_Private_Virtual_Final_New_Object_PropertyDescriptor_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaObject_Protected_Virtual_DynamicMetaObject_Expression_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Task_Task_Int32_JsonWriter_CancellationToken_Il2CppReferenceArray_1_JsonConverter_0;

		// Token: 0x02000200 RID: 512
		public class JObjectDynamicProxy : DynamicProxy<JObject>
		{
			// Token: 0x06002024 RID: 8228 RVA: 0x00091980 File Offset: 0x0008FB80
			// Note: this type is marked as 'beforefieldinit'.
			static JObjectDynamicProxy()
			{
				Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject>.NativeClassPtr, "JObjectDynamicProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr);
				JObject.JObjectDynamicProxy.NativeMethodInfoPtr_TryGetMember_Public_Virtual_Boolean_JObject_GetMemberBinder_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr, 100666399);
				JObject.JObjectDynamicProxy.NativeMethodInfoPtr_TrySetMember_Public_Virtual_Boolean_JObject_SetMemberBinder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr, 100666400);
				JObject.JObjectDynamicProxy.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_JObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr, 100666401);
				JObject.JObjectDynamicProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr, 100666402);
			}

			// Token: 0x06002025 RID: 8229 RVA: 0x000919FC File Offset: 0x0008FBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757948, XrefRangeEnd = 757950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool TryGetMember(JObject instance, GetMemberBinder binder, out Object result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.JObjectDynamicProxy.NativeMethodInfoPtr_TryGetMember_Public_Virtual_Boolean_JObject_GetMemberBinder_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				result = ((intPtr4 == 0) ? null : new Object(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06002026 RID: 8230 RVA: 0x00091A8C File Offset: 0x0008FC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757950, XrefRangeEnd = 757958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool TrySetMember(JObject instance, SetMemberBinder binder, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.JObjectDynamicProxy.NativeMethodInfoPtr_TrySetMember_Public_Virtual_Boolean_JObject_SetMemberBinder_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x00091B08 File Offset: 0x0008FD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757958, XrefRangeEnd = 757980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<string> GetDynamicMemberNames(JObject instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JObject.JObjectDynamicProxy.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_JObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x00091B64 File Offset: 0x0008FD64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757980, XrefRangeEnd = 757983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JObjectDynamicProxy()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.JObjectDynamicProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x000100A0 File Offset: 0x0000E2A0
			public JObjectDynamicProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001731 RID: 5937
			private static readonly IntPtr NativeMethodInfoPtr_TryGetMember_Public_Virtual_Boolean_JObject_GetMemberBinder_byref_Object_0;

			// Token: 0x04001732 RID: 5938
			private static readonly IntPtr NativeMethodInfoPtr_TrySetMember_Public_Virtual_Boolean_JObject_SetMemberBinder_Object_0;

			// Token: 0x04001733 RID: 5939
			private static readonly IntPtr NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_JObject_0;

			// Token: 0x04001734 RID: 5940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000235 RID: 565
			[ObfuscatedName("Newtonsoft.Json.Linq.JObject+JObjectDynamicProxy+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060022FC RID: 8956 RVA: 0x00099AA0 File Offset: 0x00097CA0
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject.JObjectDynamicProxy>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr);
					JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr, "<>9");
					JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr, "<>9__2_0");
					JObject.JObjectDynamicProxy.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr, 100666404);
					JObject.JObjectDynamicProxy.__c.NativeMethodInfoPtr__GetDynamicMemberNames_b__2_0_Internal_String_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr, 100666405);
				}

				// Token: 0x060022FD RID: 8957 RVA: 0x00099B1C File Offset: 0x00097D1C
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject.JObjectDynamicProxy.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.JObjectDynamicProxy.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022FE RID: 8958 RVA: 0x00099B58 File Offset: 0x00097D58
				[CallerCount(0)]
				public unsafe string _GetDynamicMemberNames_b__2_0(JProperty p)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.JObjectDynamicProxy.__c.NativeMethodInfoPtr__GetDynamicMemberNames_b__2_0_Internal_String_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
				}

				// Token: 0x060022FF RID: 8959 RVA: 0x00011E38 File Offset: 0x00010038
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000A0A RID: 2570
				// (get) Token: 0x06002300 RID: 8960 RVA: 0x00099BA0 File Offset: 0x00097DA0
				// (set) Token: 0x06002301 RID: 8961 RVA: 0x00011E41 File Offset: 0x00010041
				public unsafe static JObject.JObjectDynamicProxy.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject.JObjectDynamicProxy.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000A0B RID: 2571
				// (get) Token: 0x06002302 RID: 8962 RVA: 0x00099BC8 File Offset: 0x00097DC8
				// (set) Token: 0x06002303 RID: 8963 RVA: 0x00011E53 File Offset: 0x00010053
				public unsafe static Func<JProperty, string> __9__2_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JProperty, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(JObject.JObjectDynamicProxy.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040018DD RID: 6365
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x040018DE RID: 6366
				private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

				// Token: 0x040018DF RID: 6367
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040018E0 RID: 6368
				private static readonly IntPtr NativeMethodInfoPtr__GetDynamicMemberNames_b__2_0_Internal_String_JProperty_0;
			}
		}

		// Token: 0x02000201 RID: 513
		[ObfuscatedName("Newtonsoft.Json.Linq.JObject+<<WriteToAsync>g__AwaitProperties|0_0>d")]
		public sealed class ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique : ValueType
		{
			// Token: 0x0600202A RID: 8234 RVA: 0x00091BA0 File Offset: 0x0008FDA0
			// Note: this type is marked as 'beforefieldinit'.
			static ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique()
			{
				Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject>.NativeClassPtr, "<<WriteToAsync>g__AwaitProperties|0_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr);
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "<>1__state");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "<>t__builder");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "task");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "<>4__this");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "i");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Writer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "Writer");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "CancellationToken");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Converters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "Converters");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, "<>u__1");
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, 100666406);
				JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr, 100666407);
			}

			// Token: 0x0600202B RID: 8235 RVA: 0x00091CA8 File Offset: 0x0008FEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757983, XrefRangeEnd = 758018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600202C RID: 8236 RVA: 0x00091CE0 File Offset: 0x0008FEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758018, XrefRangeEnd = 758022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600202D RID: 8237 RVA: 0x000100A9 File Offset: 0x0000E2A9
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600202E RID: 8238 RVA: 0x000100B2 File Offset: 0x0000E2B2
			public ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique>.NativeClassPtr))
			{
			}

			// Token: 0x1700090F RID: 2319
			// (get) Token: 0x0600202F RID: 8239 RVA: 0x00091D28 File Offset: 0x0008FF28
			// (set) Token: 0x06002030 RID: 8240 RVA: 0x000100C4 File Offset: 0x0000E2C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000910 RID: 2320
			// (get) Token: 0x06002031 RID: 8241 RVA: 0x00091D50 File Offset: 0x0008FF50
			// (set) Token: 0x06002032 RID: 8242 RVA: 0x000100DF File Offset: 0x0000E2DF
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000911 RID: 2321
			// (get) Token: 0x06002033 RID: 8243 RVA: 0x00091D80 File Offset: 0x0008FF80
			// (set) Token: 0x06002034 RID: 8244 RVA: 0x0001010D File Offset: 0x0000E30D
			public unsafe Task task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06002035 RID: 8245 RVA: 0x00091DB0 File Offset: 0x0008FFB0
			// (set) Token: 0x06002036 RID: 8246 RVA: 0x0001012C File Offset: 0x0000E32C
			public unsafe JObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x06002037 RID: 8247 RVA: 0x00091DE0 File Offset: 0x0008FFE0
			// (set) Token: 0x06002038 RID: 8248 RVA: 0x0001014B File Offset: 0x0000E34B
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x06002039 RID: 8249 RVA: 0x00091E08 File Offset: 0x00090008
			// (set) Token: 0x0600203A RID: 8250 RVA: 0x00010166 File Offset: 0x0000E366
			public unsafe JsonWriter Writer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Writer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Writer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x0600203B RID: 8251 RVA: 0x00091E38 File Offset: 0x00090038
			// (set) Token: 0x0600203C RID: 8252 RVA: 0x00010185 File Offset: 0x0000E385
			public CancellationToken CancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_CancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x0600203D RID: 8253 RVA: 0x00091E68 File Offset: 0x00090068
			// (set) Token: 0x0600203E RID: 8254 RVA: 0x000101B3 File Offset: 0x0000E3B3
			public unsafe Il2CppReferenceArray<JsonConverter> Converters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Converters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<JsonConverter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr_Converters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x0600203F RID: 8255 RVA: 0x00091E98 File Offset: 0x00090098
			// (set) Token: 0x06002040 RID: 8256 RVA: 0x000101D2 File Offset: 0x0000E3D2
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject.ValueTypeCompilerGeneratedNPrivateSealedIAsyncStateMachineInAsTataJOiInJsWrCaUnique.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001735 RID: 5941
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001736 RID: 5942
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001737 RID: 5943
			private static readonly IntPtr NativeFieldInfoPtr_task;

			// Token: 0x04001738 RID: 5944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001739 RID: 5945
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400173A RID: 5946
			private static readonly IntPtr NativeFieldInfoPtr_Writer;

			// Token: 0x0400173B RID: 5947
			private static readonly IntPtr NativeFieldInfoPtr_CancellationToken;

			// Token: 0x0400173C RID: 5948
			private static readonly IntPtr NativeFieldInfoPtr_Converters;

			// Token: 0x0400173D RID: 5949
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400173E RID: 5950
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400173F RID: 5951
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000202 RID: 514
		[ObfuscatedName("Newtonsoft.Json.Linq.JObject+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002041 RID: 8257 RVA: 0x00091EC8 File Offset: 0x000900C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<JObject.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr);
				JObject.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr, "<>9");
				JObject.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr, "<>9__31_0");
				JObject.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr, 100666409);
				JObject.__c.NativeMethodInfoPtr__PropertyValues_b__31_0_Internal_JToken_JProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr, 100666410);
			}

			// Token: 0x06002042 RID: 8258 RVA: 0x00091F44 File Offset: 0x00090144
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002043 RID: 8259 RVA: 0x00091F80 File Offset: 0x00090180
			[CallerCount(0)]
			public unsafe JToken _PropertyValues_b__31_0(JProperty p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject.__c.NativeMethodInfoPtr__PropertyValues_b__31_0_Internal_JToken_JProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06002044 RID: 8260 RVA: 0x00010200 File Offset: 0x0000E400
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x06002045 RID: 8261 RVA: 0x00091FD0 File Offset: 0x000901D0
			// (set) Token: 0x06002046 RID: 8262 RVA: 0x00010209 File Offset: 0x0000E409
			public unsafe static JObject.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JObject.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JObject.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06002047 RID: 8263 RVA: 0x00091FF8 File Offset: 0x000901F8
			// (set) Token: 0x06002048 RID: 8264 RVA: 0x0001021B File Offset: 0x0000E41B
			public unsafe static Func<JProperty, JToken> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(JObject.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<JProperty, JToken>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(JObject.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001740 RID: 5952
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001741 RID: 5953
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x04001742 RID: 5954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeMethodInfoPtr__PropertyValues_b__31_0_Internal_JToken_JProperty_0;
		}

		// Token: 0x02000203 RID: 515
		[ObfuscatedName("Newtonsoft.Json.Linq.JObject+<GetEnumerator>d__64")]
		public sealed class _GetEnumerator_d__64 : Object
		{
			// Token: 0x06002049 RID: 8265 RVA: 0x00092020 File Offset: 0x00090220
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__64()
			{
				Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject>.NativeClassPtr, "<GetEnumerator>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr);
				JObject._GetEnumerator_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, "<>1__state");
				JObject._GetEnumerator_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, "<>2__current");
				JObject._GetEnumerator_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, "<>4__this");
				JObject._GetEnumerator_d__64.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, "<>7__wrap1");
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666411);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666412);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666413);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666414);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666415);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666416);
				JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr, 100666417);
			}

			// Token: 0x0600204A RID: 8266 RVA: 0x00092128 File Offset: 0x00090328
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__64(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject._GetEnumerator_d__64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600204B RID: 8267 RVA: 0x00092170 File Offset: 0x00090370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758022, XrefRangeEnd = 758027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600204C RID: 8268 RVA: 0x000921A4 File Offset: 0x000903A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758027, XrefRangeEnd = 758051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600204D RID: 8269 RVA: 0x000921E0 File Offset: 0x000903E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758051, XrefRangeEnd = 758054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700091E RID: 2334
			// (get) Token: 0x0600204E RID: 8270 RVA: 0x00092214 File Offset: 0x00090414
			public unsafe KeyValuePair<string, JToken> prop_KeyValuePair_2_String_JToken_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, JToken>(intPtr);
				}
			}

			// Token: 0x0600204F RID: 8271 RVA: 0x0009224C File Offset: 0x0009044C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758054, XrefRangeEnd = 758059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700091F RID: 2335
			// (get) Token: 0x06002050 RID: 8272 RVA: 0x00092280 File Offset: 0x00090480
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758059, XrefRangeEnd = 758062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._GetEnumerator_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002051 RID: 8273 RVA: 0x0001022D File Offset: 0x0000E42D
			public _GetEnumerator_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x06002052 RID: 8274 RVA: 0x000922C0 File Offset: 0x000904C0
			// (set) Token: 0x06002053 RID: 8275 RVA: 0x00010236 File Offset: 0x0000E436
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700091B RID: 2331
			// (get) Token: 0x06002054 RID: 8276 RVA: 0x000922E8 File Offset: 0x000904E8
			// (set) Token: 0x06002055 RID: 8277 RVA: 0x00010251 File Offset: 0x0000E451
			public KeyValuePair<string, JToken> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, JToken>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, JToken>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, JToken>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700091C RID: 2332
			// (get) Token: 0x06002056 RID: 8278 RVA: 0x00092318 File Offset: 0x00090518
			// (set) Token: 0x06002057 RID: 8279 RVA: 0x0001027F File Offset: 0x0000E47F
			public unsafe JObject __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700091D RID: 2333
			// (get) Token: 0x06002058 RID: 8280 RVA: 0x00092348 File Offset: 0x00090548
			// (set) Token: 0x06002059 RID: 8281 RVA: 0x0001029E File Offset: 0x0000E49E
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._GetEnumerator_d__64.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001748 RID: 5960
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001749 RID: 5961
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400174A RID: 5962
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400174B RID: 5963
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400174C RID: 5964
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_JToken_0;

			// Token: 0x0400174D RID: 5965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400174E RID: 5966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000204 RID: 516
		[ObfuscatedName("Newtonsoft.Json.Linq.JObject+<LoadAsync>d__2")]
		public sealed class _LoadAsync_d__2 : ValueType
		{
			// Token: 0x0600205A RID: 8282 RVA: 0x00092378 File Offset: 0x00090578
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAsync_d__2()
			{
				Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JObject>.NativeClassPtr, "<LoadAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr);
				JObject._LoadAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "<>1__state");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "<>t__builder");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "reader");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "cancellationToken");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "settings");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr__o_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "<o>5__2");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "<>u__1");
				JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, "<>u__2");
				JObject._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, 100666418);
				JObject._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr, 100666419);
			}

			// Token: 0x0600205B RID: 8283 RVA: 0x0009246C File Offset: 0x0009066C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758062, XrefRangeEnd = 758112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._LoadAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600205C RID: 8284 RVA: 0x000924A4 File Offset: 0x000906A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758112, XrefRangeEnd = 758118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JObject._LoadAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600205D RID: 8285 RVA: 0x000102BD File Offset: 0x0000E4BD
			public _LoadAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600205E RID: 8286 RVA: 0x000102C6 File Offset: 0x0000E4C6
			public _LoadAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JObject._LoadAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x17000920 RID: 2336
			// (get) Token: 0x0600205F RID: 8287 RVA: 0x000924EC File Offset: 0x000906EC
			// (set) Token: 0x06002060 RID: 8288 RVA: 0x000102D8 File Offset: 0x0000E4D8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000921 RID: 2337
			// (get) Token: 0x06002061 RID: 8289 RVA: 0x00092514 File Offset: 0x00090714
			// (set) Token: 0x06002062 RID: 8290 RVA: 0x000102F3 File Offset: 0x0000E4F3
			public AsyncTaskMethodBuilder<JObject> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<JObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JObject>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<JObject>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000922 RID: 2338
			// (get) Token: 0x06002063 RID: 8291 RVA: 0x00092544 File Offset: 0x00090744
			// (set) Token: 0x06002064 RID: 8292 RVA: 0x00010321 File Offset: 0x0000E521
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000923 RID: 2339
			// (get) Token: 0x06002065 RID: 8293 RVA: 0x00092574 File Offset: 0x00090774
			// (set) Token: 0x06002066 RID: 8294 RVA: 0x00010340 File Offset: 0x0000E540
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000924 RID: 2340
			// (get) Token: 0x06002067 RID: 8295 RVA: 0x000925A4 File Offset: 0x000907A4
			// (set) Token: 0x06002068 RID: 8296 RVA: 0x0001036E File Offset: 0x0000E56E
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000925 RID: 2341
			// (get) Token: 0x06002069 RID: 8297 RVA: 0x000925D4 File Offset: 0x000907D4
			// (set) Token: 0x0600206A RID: 8298 RVA: 0x0001038D File Offset: 0x0000E58D
			public unsafe JObject _o_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr__o_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr__o_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000926 RID: 2342
			// (get) Token: 0x0600206B RID: 8299 RVA: 0x00092604 File Offset: 0x00090804
			// (set) Token: 0x0600206C RID: 8300 RVA: 0x000103AC File Offset: 0x0000E5AC
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000927 RID: 2343
			// (get) Token: 0x0600206D RID: 8301 RVA: 0x00092634 File Offset: 0x00090834
			// (set) Token: 0x0600206E RID: 8302 RVA: 0x000103DA File Offset: 0x0000E5DA
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JObject._LoadAsync_d__2.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400174F RID: 5967
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001750 RID: 5968
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001751 RID: 5969
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x04001752 RID: 5970
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001753 RID: 5971
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04001754 RID: 5972
			private static readonly IntPtr NativeFieldInfoPtr__o_5__2;

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001757 RID: 5975
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001758 RID: 5976
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.Specialized;
using Il2CppSystem.ComponentModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B8 RID: 184
	public class JContainer : JToken
	{
		// Token: 0x06001039 RID: 4153 RVA: 0x0005B314 File Offset: 0x00059514
		// Note: this type is marked as 'beforefieldinit'.
		static JContainer()
		{
			Il2CppClassPointerStore<JContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JContainer>.NativeClassPtr);
			JContainer.NativeFieldInfoPtr__listChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "_listChanged");
			JContainer.NativeFieldInfoPtr__addingNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "_addingNew");
			JContainer.NativeFieldInfoPtr__collectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "_collectionChanged");
			JContainer.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "_syncRoot");
			JContainer.NativeFieldInfoPtr__busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "_busy");
			JContainer.NativeMethodInfoPtr_ReadTokenFromAsync_Internal_Task_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666205);
			JContainer.NativeMethodInfoPtr_ReadContentFromAsync_Private_Task_JsonReader_JsonLoadSettings_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666206);
			JContainer.NativeMethodInfoPtr_add_ListChanged_Public_Virtual_Final_New_add_Void_ListChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666207);
			JContainer.NativeMethodInfoPtr_remove_ListChanged_Public_Virtual_Final_New_rem_Void_ListChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666208);
			JContainer.NativeMethodInfoPtr_add_AddingNew_Public_add_Void_AddingNewEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666209);
			JContainer.NativeMethodInfoPtr_remove_AddingNew_Public_rem_Void_AddingNewEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666210);
			JContainer.NativeMethodInfoPtr_add_CollectionChanged_Public_Virtual_Final_New_add_Void_NotifyCollectionChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666211);
			JContainer.NativeMethodInfoPtr_remove_CollectionChanged_Public_Virtual_Final_New_rem_Void_NotifyCollectionChangedEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666212);
			JContainer.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Abstract_Virtual_New_get_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666213);
			JContainer.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666214);
			JContainer.NativeMethodInfoPtr__ctor_Internal_Void_JContainer_JsonCloneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666215);
			JContainer.NativeMethodInfoPtr_CheckReentrancy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666216);
			JContainer.NativeMethodInfoPtr_CreateChildrenCollection_Internal_Virtual_New_IList_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666217);
			JContainer.NativeMethodInfoPtr_OnAddingNew_Protected_Virtual_New_Void_AddingNewEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666218);
			JContainer.NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666219);
			JContainer.NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_NotifyCollectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666220);
			JContainer.NativeMethodInfoPtr_get_HasValues_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666221);
			JContainer.NativeMethodInfoPtr_ContentsEqual_Internal_Boolean_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666222);
			JContainer.NativeMethodInfoPtr_get_First_Public_Virtual_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666223);
			JContainer.NativeMethodInfoPtr_get_Last_Public_Virtual_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666224);
			JContainer.NativeMethodInfoPtr_Children_Public_Virtual_JEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666225);
			JContainer.NativeMethodInfoPtr_Values_Public_Virtual_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666226);
			JContainer.NativeMethodInfoPtr_Descendants_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666227);
			JContainer.NativeMethodInfoPtr_DescendantsAndSelf_Public_IEnumerable_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666228);
			JContainer.NativeMethodInfoPtr_GetDescendants_Internal_IEnumerable_1_JToken_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666229);
			JContainer.NativeMethodInfoPtr_IsMultiContent_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666230);
			JContainer.NativeMethodInfoPtr_EnsureParentToken_Internal_JToken_JToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666231);
			JContainer.NativeMethodInfoPtr_IndexOfItem_Internal_Abstract_Virtual_New_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666232);
			JContainer.NativeMethodInfoPtr_InsertItem_Internal_Virtual_New_Boolean_Int32_JToken_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666233);
			JContainer.NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666234);
			JContainer.NativeMethodInfoPtr_RemoveItem_Internal_Virtual_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666235);
			JContainer.NativeMethodInfoPtr_GetItem_Internal_Virtual_New_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666236);
			JContainer.NativeMethodInfoPtr_SetItem_Internal_Virtual_New_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666237);
			JContainer.NativeMethodInfoPtr_ClearItems_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666238);
			JContainer.NativeMethodInfoPtr_ReplaceItem_Internal_Virtual_New_Void_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666239);
			JContainer.NativeMethodInfoPtr_ContainsItem_Internal_Virtual_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666240);
			JContainer.NativeMethodInfoPtr_CopyItemsTo_Internal_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666241);
			JContainer.NativeMethodInfoPtr_IsTokenUnchanged_Internal_Static_Boolean_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666242);
			JContainer.NativeMethodInfoPtr_ValidateToken_Internal_Virtual_New_Void_JToken_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666243);
			JContainer.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666244);
			JContainer.NativeMethodInfoPtr_TryAdd_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666245);
			JContainer.NativeMethodInfoPtr_AddAndSkipParentCheck_Internal_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666246);
			JContainer.NativeMethodInfoPtr_AddFirst_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666247);
			JContainer.NativeMethodInfoPtr_TryAddInternal_Internal_Boolean_Int32_Object_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666248);
			JContainer.NativeMethodInfoPtr_CreateFromContent_Internal_Static_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666249);
			JContainer.NativeMethodInfoPtr_CreateWriter_Public_JsonWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666250);
			JContainer.NativeMethodInfoPtr_ReplaceAll_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666251);
			JContainer.NativeMethodInfoPtr_RemoveAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666252);
			JContainer.NativeMethodInfoPtr_MergeItem_Internal_Abstract_Virtual_New_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666253);
			JContainer.NativeMethodInfoPtr_Merge_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666254);
			JContainer.NativeMethodInfoPtr_Merge_Public_Void_Object_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666255);
			JContainer.NativeMethodInfoPtr_ValidateContent_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666256);
			JContainer.NativeMethodInfoPtr_ReadTokenFrom_Internal_Void_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666257);
			JContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_JsonReader_JsonLoadSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666258);
			JContainer.NativeMethodInfoPtr_ReadProperty_Private_Static_JProperty_JsonReader_JsonLoadSettings_IJsonLineInfo_JContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666259);
			JContainer.NativeMethodInfoPtr_ContentsHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666260);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666261);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666262);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__IndexOf_Private_Virtual_Final_New_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666263);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__Insert_Private_Virtual_Final_New_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666264);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666265);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666266);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__set_Item_Private_Virtual_Final_New_set_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666267);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Add_Private_Virtual_Final_New_Void_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666268);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666269);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Contains_Private_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666270);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__CopyTo_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666271);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666272);
			JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Remove_Private_Virtual_Final_New_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666273);
			JContainer.NativeMethodInfoPtr_EnsureValue_Private_JToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666274);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666275);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666276);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666277);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666278);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666279);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666280);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666281);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666282);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666283);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666284);
			JContainer.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666285);
			JContainer.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666286);
			JContainer.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666287);
			JContainer.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666288);
			JContainer.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666289);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666290);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666291);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666292);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666293);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666294);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666295);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666296);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666297);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666298);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666299);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666300);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666301);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666302);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666303);
			JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666304);
			JContainer.NativeMethodInfoPtr_MergeEnumerableContent_Internal_Static_Void_JContainer_IEnumerable_JsonMergeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer>.NativeClassPtr, 100666305);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0005BB8C File Offset: 0x00059D8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757159, RefRangeEnd = 757163, XrefRangeStart = 757146, XrefRangeEnd = 757159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadTokenFromAsync(JsonReader reader, JsonLoadSettings options, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReadTokenFromAsync_Internal_Task_JsonReader_JsonLoadSettings_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0005BC08 File Offset: 0x00059E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757163, XrefRangeEnd = 757176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task ReadContentFromAsync(JsonReader reader, JsonLoadSettings settings, CancellationToken cancellationToken = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReadContentFromAsync_Private_Task_JsonReader_JsonLoadSettings_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0005BC84 File Offset: 0x00059E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757176, XrefRangeEnd = 757184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_ListChanged(ListChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_add_ListChanged_Public_Virtual_Final_New_add_Void_ListChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0005BCC8 File Offset: 0x00059EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757184, XrefRangeEnd = 757192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_ListChanged(ListChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_remove_ListChanged_Public_Virtual_Final_New_rem_Void_ListChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0005BD0C File Offset: 0x00059F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757192, XrefRangeEnd = 757200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_AddingNew(AddingNewEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_add_AddingNew_Public_add_Void_AddingNewEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0005BD50 File Offset: 0x00059F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757200, XrefRangeEnd = 757208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_AddingNew(AddingNewEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_remove_AddingNew_Public_rem_Void_AddingNewEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0005BD94 File Offset: 0x00059F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757208, XrefRangeEnd = 757216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void add_CollectionChanged(NotifyCollectionChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_add_CollectionChanged_Public_Virtual_Final_New_add_Void_NotifyCollectionChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0005BDD8 File Offset: 0x00059FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757216, XrefRangeEnd = 757224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void remove_CollectionChanged(NotifyCollectionChangedEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_remove_CollectionChanged_Public_Virtual_Final_New_rem_Void_NotifyCollectionChangedEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005BE1C File Offset: 0x0005A01C
		public unsafe virtual IList<JToken> ChildrenTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_get_ChildrenTokens_Protected_Abstract_Virtual_New_get_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0005BE68 File Offset: 0x0005A068
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 757228, RefRangeEnd = 757231, XrefRangeStart = 757224, XrefRangeEnd = 757228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0005BEA4 File Offset: 0x0005A0A4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 757268, RefRangeEnd = 757280, XrefRangeStart = 757231, XrefRangeEnd = 757268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JContainer(JContainer other, JsonCloneSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JContainer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr__ctor_Internal_Void_JContainer_JsonCloneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0005BF04 File Offset: 0x0005A104
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 757280, RefRangeEnd = 757287, XrefRangeStart = 757280, XrefRangeEnd = 757280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckReentrancy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_CheckReentrancy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0005BF38 File Offset: 0x0005A138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757287, XrefRangeEnd = 757293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IList<JToken> CreateChildrenCollection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_CreateChildrenCollection_Internal_Virtual_New_IList_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0005BF84 File Offset: 0x0005A184
		[CallerCount(0)]
		public unsafe virtual void OnAddingNew(AddingNewEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_OnAddingNew_Protected_Virtual_New_Void_AddingNewEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757293, XrefRangeEnd = 757294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnListChanged(ListChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0005C024 File Offset: 0x0005A224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757294, XrefRangeEnd = 757295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_NotifyCollectionChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0005C074 File Offset: 0x0005A274
		public unsafe override bool HasValues
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757295, XrefRangeEnd = 757298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_get_HasValues_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0005C0BC File Offset: 0x0005A2BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 757312, RefRangeEnd = 757315, XrefRangeStart = 757298, XrefRangeEnd = 757312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContentsEqual(JContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ContentsEqual_Internal_Boolean_JContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x0005C10C File Offset: 0x0005A30C
		public unsafe override JToken First
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757315, XrefRangeEnd = 757321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_get_First_Public_Virtual_get_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x0005C158 File Offset: 0x0005A358
		public unsafe override JToken Last
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757321, XrefRangeEnd = 757327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_get_Last_Public_Virtual_get_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0005C1A4 File Offset: 0x0005A3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757327, XrefRangeEnd = 757330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JEnumerable<JToken> Children()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_Children_Public_Virtual_JEnumerable_1_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new JEnumerable<JToken>(intPtr);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0005C1E8 File Offset: 0x0005A3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757330, XrefRangeEnd = 757344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<T> Values<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.MethodInfoStoreGeneric_Values_Public_Virtual_IEnumerable_1_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0005C234 File Offset: 0x0005A434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 757345, RefRangeEnd = 757346, XrefRangeStart = 757344, XrefRangeEnd = 757345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> Descendants()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_Descendants_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0005C274 File Offset: 0x0005A474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 757347, RefRangeEnd = 757349, XrefRangeStart = 757346, XrefRangeEnd = 757347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> DescendantsAndSelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_DescendantsAndSelf_Public_IEnumerable_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 757355, RefRangeEnd = 757358, XrefRangeStart = 757349, XrefRangeEnd = 757355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<JToken> GetDescendants(bool self)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_GetDescendants_Internal_IEnumerable_1_JToken_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0005C300 File Offset: 0x0005A500
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757368, RefRangeEnd = 757372, XrefRangeStart = 757358, XrefRangeEnd = 757368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMultiContent(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_IsMultiContent_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0005C350 File Offset: 0x0005A550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 757380, RefRangeEnd = 757381, XrefRangeStart = 757372, XrefRangeEnd = 757380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipParentCheck;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyAnnotations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_EnsureParentToken_Internal_JToken_JToken_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0005C3BC File Offset: 0x0005A5BC
		[CallerCount(0)]
		public unsafe virtual int IndexOfItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_IndexOfItem_Internal_Abstract_Virtual_New_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0005C414 File Offset: 0x0005A614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 757410, RefRangeEnd = 757411, XrefRangeStart = 757381, XrefRangeEnd = 757410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_InsertItem_Internal_Virtual_New_Boolean_Int32_JToken_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0005C498 File Offset: 0x0005A698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757411, XrefRangeEnd = 757441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0005C4E4 File Offset: 0x0005A6E4
		[CallerCount(0)]
		public unsafe virtual bool RemoveItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_RemoveItem_Internal_Virtual_New_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0005C53C File Offset: 0x0005A73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757441, XrefRangeEnd = 757445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual JToken GetItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_GetItem_Internal_Virtual_New_JToken_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0005C594 File Offset: 0x0005A794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 757486, RefRangeEnd = 757487, XrefRangeStart = 757445, XrefRangeEnd = 757486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItem(int index, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_SetItem_Internal_Virtual_New_Void_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0005C5F0 File Offset: 0x0005A7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757487, XrefRangeEnd = 757519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_ClearItems_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0005C62C File Offset: 0x0005A82C
		[CallerCount(0)]
		public unsafe virtual void ReplaceItem(JToken existing, JToken replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existing);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_ReplaceItem_Internal_Virtual_New_Void_JToken_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0005C68C File Offset: 0x0005A88C
		[CallerCount(0)]
		public unsafe virtual bool ContainsItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_ContainsItem_Internal_Virtual_New_Boolean_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0005C6E4 File Offset: 0x0005A8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757519, XrefRangeEnd = 757539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyItemsTo(Array array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_CopyItemsTo_Internal_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0005C740 File Offset: 0x0005A940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757539, XrefRangeEnd = 757542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_IsTokenUnchanged_Internal_Static_Boolean_JToken_JToken_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0005C794 File Offset: 0x0005A994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757542, XrefRangeEnd = 757545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ValidateToken(JToken o, JToken existing)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_ValidateToken_Internal_Virtual_New_Void_JToken_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0005C7F4 File Offset: 0x0005A9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757545, XrefRangeEnd = 757549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0005C844 File Offset: 0x0005AA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757549, XrefRangeEnd = 757553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAdd(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_TryAdd_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0005C894 File Offset: 0x0005AA94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 757557, RefRangeEnd = 757562, XrefRangeStart = 757553, XrefRangeEnd = 757557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAndSkipParentCheck(JToken token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(token);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_AddAndSkipParentCheck_Internal_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0005C8D8 File Offset: 0x0005AAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757562, XrefRangeEnd = 757563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFirst(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_AddFirst_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x0005C91C File Offset: 0x0005AB1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 757568, RefRangeEnd = 757575, XrefRangeStart = 757563, XrefRangeEnd = 757568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryAddInternal(int index, Object content, bool skipParentCheck, bool copyAnnotations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipParentCheck;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyAnnotations;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_TryAddInternal_Internal_Boolean_Int32_Object_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0005C994 File Offset: 0x0005AB94
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 757582, RefRangeEnd = 757589, XrefRangeStart = 757575, XrefRangeEnd = 757582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JToken CreateFromContent(Object content)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_CreateFromContent_Internal_Static_JToken_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0005C9D8 File Offset: 0x0005ABD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757589, XrefRangeEnd = 757593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriter CreateWriter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_CreateWriter_Public_JsonWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonWriter>(intPtr3) : null;
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0005CA18 File Offset: 0x0005AC18
		[CallerCount(0)]
		public unsafe void ReplaceAll(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReplaceAll_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0005CA5C File Offset: 0x0005AC5C
		[CallerCount(0)]
		public unsafe void RemoveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_RemoveAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0005CA90 File Offset: 0x0005AC90
		[CallerCount(0)]
		public unsafe virtual void MergeItem(Object content, JsonMergeSettings settings)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JContainer.NativeMethodInfoPtr_MergeItem_Internal_Abstract_Virtual_New_Void_Object_JsonMergeSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0005CAF0 File Offset: 0x0005ACF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757593, XrefRangeEnd = 757594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_Merge_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0005CB34 File Offset: 0x0005AD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757594, XrefRangeEnd = 757595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Merge(Object content, JsonMergeSettings settings)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_Merge_Public_Void_Object_JsonMergeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x0005CB88 File Offset: 0x0005AD88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757603, RefRangeEnd = 757607, XrefRangeStart = 757595, XrefRangeEnd = 757603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateContent(Object content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ValidateContent_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005CBCC File Offset: 0x0005ADCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 757608, RefRangeEnd = 757612, XrefRangeStart = 757607, XrefRangeEnd = 757608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReadTokenFrom_Internal_Void_JsonReader_JsonLoadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0005CC20 File Offset: 0x0005AE20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 757666, RefRangeEnd = 757667, XrefRangeStart = 757612, XrefRangeEnd = 757666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReadContentFrom_Internal_Void_JsonReader_JsonLoadSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0005CC74 File Offset: 0x0005AE74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 757673, RefRangeEnd = 757675, XrefRangeStart = 757667, XrefRangeEnd = 757673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ReadProperty_Private_Static_JProperty_JsonReader_JsonLoadSettings_IJsonLineInfo_JContainer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<JProperty>(intPtr3) : null;
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0005CCF0 File Offset: 0x0005AEF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 757692, RefRangeEnd = 757695, XrefRangeStart = 757675, XrefRangeEnd = 757692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ContentsHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_ContentsHashCode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0005CD2C File Offset: 0x0005AF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757695, XrefRangeEnd = 757697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_ComponentModel_ITypedList_GetListName(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0005CD74 File Offset: 0x0005AF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757697, XrefRangeEnd = 757712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PropertyDescriptorCollection System_ComponentModel_ITypedList_GetItemProperties(Il2CppReferenceArray<PropertyDescriptor> listAccessors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listAccessors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005CDC4 File Offset: 0x0005AFC4
		[CallerCount(0)]
		public unsafe virtual int System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__IndexOf(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__IndexOf_Private_Virtual_Final_New_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0005CE14 File Offset: 0x0005B014
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__Insert(int index, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__Insert_Private_Virtual_Final_New_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005CE64 File Offset: 0x0005B064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756662, RefRangeEnd = 756663, XrefRangeStart = 756662, XrefRangeEnd = 756663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0005CEA4 File Offset: 0x0005B0A4
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0005CEF0 File Offset: 0x0005B0F0
		public unsafe virtual JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 756648, RefRangeEnd = 756651, XrefRangeStart = 756648, XrefRangeEnd = 756651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 756651, RefRangeEnd = 756652, XrefRangeStart = 756651, XrefRangeEnd = 756652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__set_Item_Private_Virtual_Final_New_set_Void_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0005CF40 File Offset: 0x0005B140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 756669, RefRangeEnd = 756671, XrefRangeStart = 756669, XrefRangeEnd = 756671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Add(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Add_Private_Virtual_Final_New_Void_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0005CF84 File Offset: 0x0005B184
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0005CFB8 File Offset: 0x0005B1B8
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Contains(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Contains_Private_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0005D008 File Offset: 0x0005B208
		[CallerCount(0)]
		public unsafe virtual void System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__CopyTo(Il2CppReferenceArray<JToken> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__CopyTo_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x0005D058 File Offset: 0x0005B258
		public unsafe virtual bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0005D094 File Offset: 0x0005B294
		[CallerCount(0)]
		public unsafe virtual bool System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Remove(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Remove_Private_Virtual_Final_New_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0005D0E4 File Offset: 0x0005B2E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 757714, RefRangeEnd = 757720, XrefRangeStart = 757712, XrefRangeEnd = 757714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JToken EnsureValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_EnsureValue_Private_JToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
			}
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0005D134 File Offset: 0x0005B334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757720, XrefRangeEnd = 757724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0005D184 File Offset: 0x0005B384
		[CallerCount(0)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0005D1B8 File Offset: 0x0005B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757724, XrefRangeEnd = 757725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0005D208 File Offset: 0x0005B408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757725, XrefRangeEnd = 757726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0005D258 File Offset: 0x0005B458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757726, XrefRangeEnd = 757727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0005D2A8 File Offset: 0x0005B4A8
		public unsafe virtual bool System.Collections.IList.IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0005D2E4 File Offset: 0x0005B4E4
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0005D320 File Offset: 0x0005B520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757727, XrefRangeEnd = 757728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0005D364 File Offset: 0x0005B564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 756662, RefRangeEnd = 756663, XrefRangeStart = 756662, XrefRangeEnd = 756663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x0005D3F0 File Offset: 0x0005B5F0
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 756648, RefRangeEnd = 756651, XrefRangeStart = 756648, XrefRangeEnd = 756651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757728, XrefRangeEnd = 757729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0005D440 File Offset: 0x0005B640
		[CallerCount(0)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x0005D490 File Offset: 0x0005B690
		public unsafe virtual int Count
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 757733, RefRangeEnd = 757751, XrefRangeStart = 757729, XrefRangeEnd = 757733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x0005D4CC File Offset: 0x0005B6CC
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005D508 File Offset: 0x0005B708
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757751, XrefRangeEnd = 757756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0005D548 File Offset: 0x0005B748
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_AddIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0005D58C File Offset: 0x0005B78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757756, XrefRangeEnd = 757763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ComponentModel_IBindingList_AddNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0005D5CC File Offset: 0x0005B7CC
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowEdit
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0005D608 File Offset: 0x0005B808
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowNew
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0005D644 File Offset: 0x0005B844
		public unsafe virtual bool System.ComponentModel.IBindingList.AllowRemove
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0005D680 File Offset: 0x0005B880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757763, XrefRangeEnd = 757768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0005D6D0 File Offset: 0x0005B8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757768, XrefRangeEnd = 757773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_ComponentModel_IBindingList_Find(PropertyDescriptor property, Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0005D730 File Offset: 0x0005B930
		public unsafe virtual bool System.ComponentModel.IBindingList.IsSorted
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0005D76C File Offset: 0x0005B96C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_RemoveIndex(PropertyDescriptor property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0005D7B0 File Offset: 0x0005B9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757773, XrefRangeEnd = 757778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_ComponentModel_IBindingList_RemoveSort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		public unsafe virtual ListSortDirection System.ComponentModel.IBindingList.SortDirection
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0005D820 File Offset: 0x0005BA20
		public unsafe virtual PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0005D860 File Offset: 0x0005BA60
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x0005D89C File Offset: 0x0005BA9C
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsSearching
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x0005D8D8 File Offset: 0x0005BAD8
		public unsafe virtual bool System.ComponentModel.IBindingList.SupportsSorting
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0005D914 File Offset: 0x0005BB14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 757879, RefRangeEnd = 757881, XrefRangeStart = 757778, XrefRangeEnd = 757879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(content);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer.NativeMethodInfoPtr_MergeEnumerableContent_Internal_Static_Void_JContainer_IEnumerable_JsonMergeSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000076A3 File Offset: 0x000058A3
		public JContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x0005D970 File Offset: 0x0005BB70
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x000076AC File Offset: 0x000058AC
		public unsafe ListChangedEventHandler _listChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__listChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__listChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x0005D9A0 File Offset: 0x0005BBA0
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x000076CB File Offset: 0x000058CB
		public unsafe AddingNewEventHandler _addingNew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__addingNew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddingNewEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__addingNew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x0005D9D0 File Offset: 0x0005BBD0
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x000076EA File Offset: 0x000058EA
		public unsafe NotifyCollectionChangedEventHandler _collectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__collectionChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotifyCollectionChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__collectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x0005DA00 File Offset: 0x0005BC00
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00007709 File Offset: 0x00005909
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0005DA30 File Offset: 0x0005BC30
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x00007728 File Offset: 0x00005928
		public unsafe bool _busy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__busy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer.NativeFieldInfoPtr__busy)) = value;
			}
		}

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeFieldInfoPtr__listChanged;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeFieldInfoPtr__addingNew;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeFieldInfoPtr__collectionChanged;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeFieldInfoPtr__busy;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_ReadTokenFromAsync_Internal_Task_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentFromAsync_Private_Task_JsonReader_JsonLoadSettings_CancellationToken_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_add_ListChanged_Public_Virtual_Final_New_add_Void_ListChangedEventHandler_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_remove_ListChanged_Public_Virtual_Final_New_rem_Void_ListChangedEventHandler_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_add_AddingNew_Public_add_Void_AddingNewEventHandler_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_remove_AddingNew_Public_rem_Void_AddingNewEventHandler_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_add_CollectionChanged_Public_Virtual_Final_New_add_Void_NotifyCollectionChangedEventHandler_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_remove_CollectionChanged_Public_Virtual_Final_New_rem_Void_NotifyCollectionChangedEventHandler_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildrenTokens_Protected_Abstract_Virtual_New_get_IList_1_JToken_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_JContainer_JsonCloneSettings_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_CheckReentrancy_Internal_Void_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_CreateChildrenCollection_Internal_Virtual_New_IList_1_JToken_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_OnAddingNew_Protected_Virtual_New_Void_AddingNewEventArgs_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_OnListChanged_Protected_Virtual_New_Void_ListChangedEventArgs_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_OnCollectionChanged_Protected_Virtual_New_Void_NotifyCollectionChangedEventArgs_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValues_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_ContentsEqual_Internal_Boolean_JContainer_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_Virtual_get_JToken_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_get_Last_Public_Virtual_get_JToken_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_Children_Public_Virtual_JEnumerable_1_JToken_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_Values_Public_Virtual_IEnumerable_1_T_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Descendants_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeMethodInfoPtr_DescendantsAndSelf_Public_IEnumerable_1_JToken_0;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeMethodInfoPtr_GetDescendants_Internal_IEnumerable_1_JToken_Boolean_0;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeMethodInfoPtr_IsMultiContent_Internal_Boolean_Object_0;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeMethodInfoPtr_EnsureParentToken_Internal_JToken_JToken_Boolean_Boolean_0;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfItem_Internal_Abstract_Virtual_New_Int32_JToken_0;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Internal_Virtual_New_Boolean_Int32_JToken_Boolean_Boolean_0;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItemAt_Internal_Virtual_New_Void_Int32_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Internal_Virtual_New_Boolean_JToken_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_GetItem_Internal_Virtual_New_JToken_Int32_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Internal_Virtual_New_Void_Int32_JToken_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Internal_Virtual_New_Void_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceItem_Internal_Virtual_New_Void_JToken_JToken_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_ContainsItem_Internal_Virtual_New_Boolean_JToken_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_CopyItemsTo_Internal_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_IsTokenUnchanged_Internal_Static_Boolean_JToken_JToken_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToken_Internal_Virtual_New_Void_JToken_JToken_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_Object_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_TryAdd_Internal_Boolean_Object_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr_AddAndSkipParentCheck_Internal_Void_JToken_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_AddFirst_Public_Void_Object_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_TryAddInternal_Internal_Boolean_Int32_Object_Boolean_Boolean_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromContent_Internal_Static_JToken_Object_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriter_Public_JsonWriter_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceAll_Public_Void_Object_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Void_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_MergeItem_Internal_Abstract_Virtual_New_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_Object_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Void_Object_JsonMergeSettings_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_ValidateContent_Private_Void_Object_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_ReadTokenFrom_Internal_Void_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_ReadContentFrom_Internal_Void_JsonReader_JsonLoadSettings_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_ReadProperty_Private_Static_JProperty_JsonReader_JsonLoadSettings_IJsonLineInfo_JContainer_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_ContentsHashCode_Internal_Int32_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetListName_Private_Virtual_Final_New_String_Il2CppReferenceArray_1_PropertyDescriptor_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_ITypedList_GetItemProperties_Private_Virtual_Final_New_PropertyDescriptorCollection_Il2CppReferenceArray_1_PropertyDescriptor_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__IndexOf_Private_Virtual_Final_New_Int32_JToken_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__Insert_Private_Virtual_Final_New_Void_Int32_JToken_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__get_Item_Private_Virtual_Final_New_get_JToken_Int32_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IList_Newtonsoft_Json_Linq_JToken__set_Item_Private_Virtual_Final_New_set_Void_Int32_JToken_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Add_Private_Virtual_Final_New_Void_JToken_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Contains_Private_Virtual_Final_New_Boolean_JToken_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__CopyTo_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_JToken_Int32_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_ICollection_Newtonsoft_Json_Linq_JToken__Remove_Private_Virtual_Final_New_Boolean_JToken_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValue_Private_JToken_Object_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_AddNew_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowEdit_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowNew_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_AllowRemove_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_ApplySort_Private_Virtual_Final_New_Void_PropertyDescriptor_ListSortDirection_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_Find_Private_Virtual_Final_New_Int32_PropertyDescriptor_Object_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_IsSorted_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveIndex_Private_Virtual_Final_New_Void_PropertyDescriptor_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_RemoveSort_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortDirection_Private_Virtual_Final_New_get_ListSortDirection_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SortProperty_Private_Virtual_Final_New_get_PropertyDescriptor_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsChangeNotification_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSearching_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_System_ComponentModel_IBindingList_get_SupportsSorting_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_MergeEnumerableContent_Internal_Static_Void_JContainer_IEnumerable_JsonMergeSettings_0;

		// Token: 0x020001FC RID: 508
		[ObfuscatedName("Newtonsoft.Json.Linq.JContainer+<GetDescendants>d__36")]
		public sealed class _GetDescendants_d__36 : Object
		{
			// Token: 0x06001FD5 RID: 8149 RVA: 0x00090D04 File Offset: 0x0008EF04
			// Note: this type is marked as 'beforefieldinit'.
			static _GetDescendants_d__36()
			{
				Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "<GetDescendants>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr);
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>1__state");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>2__current");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>l__initialThreadId");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr_self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "self");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___3__self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>3__self");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>4__this");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>7__wrap1");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr__o_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<o>5__3");
				JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, "<>7__wrap3");
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666306);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666307);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666308);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666309);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666310);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666311);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666312);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666313);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666314);
				JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr, 100666315);
			}

			// Token: 0x06001FD6 RID: 8150 RVA: 0x00090EAC File Offset: 0x0008F0AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetDescendants_d__36(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JContainer._GetDescendants_d__36>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x00090EF4 File Offset: 0x0008F0F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756944, XrefRangeEnd = 756954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD8 RID: 8152 RVA: 0x00090F28 File Offset: 0x0008F128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756954, XrefRangeEnd = 756996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x00090F64 File Offset: 0x0008F164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756996, XrefRangeEnd = 756999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FDA RID: 8154 RVA: 0x00090F98 File Offset: 0x0008F198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 756999, XrefRangeEnd = 757002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00090FCC File Offset: 0x0008F1CC
			public unsafe JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}

			// Token: 0x06001FDC RID: 8156 RVA: 0x0009100C File Offset: 0x0008F20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757002, XrefRangeEnd = 757007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00091040 File Offset: 0x0008F240
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FDE RID: 8158 RVA: 0x00091080 File Offset: 0x0008F280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757007, XrefRangeEnd = 757015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<JToken> System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr3) : null;
			}

			// Token: 0x06001FDF RID: 8159 RVA: 0x000910C0 File Offset: 0x0008F2C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._GetDescendants_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001FE0 RID: 8160 RVA: 0x0000FCA1 File Offset: 0x0000DEA1
			public _GetDescendants_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00091100 File Offset: 0x0008F300
			// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x0000FCAA File Offset: 0x0000DEAA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00091128 File Offset: 0x0008F328
			// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0000FCC5 File Offset: 0x0000DEC5
			public unsafe JToken __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00091158 File Offset: 0x0008F358
			// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00091180 File Offset: 0x0008F380
			// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0000FCFF File Offset: 0x0000DEFF
			public unsafe bool self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr_self);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr_self)) = value;
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x000911A8 File Offset: 0x0008F3A8
			// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0000FD1A File Offset: 0x0000DF1A
			public unsafe bool __3__self
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___3__self);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___3__self)) = value;
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000911D0 File Offset: 0x0008F3D0
			// (set) Token: 0x06001FEC RID: 8172 RVA: 0x0000FD35 File Offset: 0x0000DF35
			public unsafe JContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06001FED RID: 8173 RVA: 0x00091200 File Offset: 0x0008F400
			// (set) Token: 0x06001FEE RID: 8174 RVA: 0x0000FD54 File Offset: 0x0000DF54
			public unsafe IEnumerator<JToken> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F8 RID: 2296
			// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00091230 File Offset: 0x0008F430
			// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x0000FD73 File Offset: 0x0000DF73
			public unsafe JToken _o_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr__o_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr__o_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x00091260 File Offset: 0x0008F460
			// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x0000FD92 File Offset: 0x0000DF92
			public unsafe IEnumerator<JToken> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<JToken>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._GetDescendants_d__36.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001706 RID: 5894
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001707 RID: 5895
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001708 RID: 5896
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001709 RID: 5897
			private static readonly IntPtr NativeFieldInfoPtr_self;

			// Token: 0x0400170A RID: 5898
			private static readonly IntPtr NativeFieldInfoPtr___3__self;

			// Token: 0x0400170B RID: 5899
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400170C RID: 5900
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400170D RID: 5901
			private static readonly IntPtr NativeFieldInfoPtr__o_5__3;

			// Token: 0x0400170E RID: 5902
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400170F RID: 5903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001710 RID: 5904
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001711 RID: 5905
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001712 RID: 5906
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001713 RID: 5907
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001714 RID: 5908
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Newtonsoft_Json_Linq_JToken__get_Current_Private_Virtual_Final_New_get_JToken_0;

			// Token: 0x04001715 RID: 5909
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001716 RID: 5910
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001717 RID: 5911
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Newtonsoft_Json_Linq_JToken__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_JToken_0;

			// Token: 0x04001718 RID: 5912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020001FD RID: 509
		[ObfuscatedName("Newtonsoft.Json.Linq.JContainer+<ReadContentFromAsync>d__1")]
		public sealed class _ReadContentFromAsync_d__1 : ValueType
		{
			// Token: 0x06001FF3 RID: 8179 RVA: 0x00091290 File Offset: 0x0008F490
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadContentFromAsync_d__1()
			{
				Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "<ReadContentFromAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr);
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<>1__state");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<>t__builder");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "reader");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<>4__this");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "settings");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "cancellationToken");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__lineInfo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<lineInfo>5__2");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__parent_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<parent>5__3");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<>u__1");
				JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, "<>u__2");
				JContainer._ReadContentFromAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, 100666316);
				JContainer._ReadContentFromAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr, 100666317);
			}

			// Token: 0x06001FF4 RID: 8180 RVA: 0x000913AC File Offset: 0x0008F5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757015, XrefRangeEnd = 757101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._ReadContentFromAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF5 RID: 8181 RVA: 0x000913E4 File Offset: 0x0008F5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757101, XrefRangeEnd = 757105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._ReadContentFromAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FF6 RID: 8182 RVA: 0x0000FDB1 File Offset: 0x0000DFB1
			public _ReadContentFromAsync_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x0000FDBA File Offset: 0x0000DFBA
			public _ReadContentFromAsync_d__1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JContainer._ReadContentFromAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0009142C File Offset: 0x0008F62C
			// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x0000FDCC File Offset: 0x0000DFCC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00091454 File Offset: 0x0008F654
			// (set) Token: 0x06001FFB RID: 8187 RVA: 0x0000FDE7 File Offset: 0x0000DFE7
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00091484 File Offset: 0x0008F684
			// (set) Token: 0x06001FFD RID: 8189 RVA: 0x0000FE15 File Offset: 0x0000E015
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000914B4 File Offset: 0x0008F6B4
			// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0000FE34 File Offset: 0x0000E034
			public unsafe JContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x06002000 RID: 8192 RVA: 0x000914E4 File Offset: 0x0008F6E4
			// (set) Token: 0x06002001 RID: 8193 RVA: 0x0000FE53 File Offset: 0x0000E053
			public unsafe JsonLoadSettings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x06002002 RID: 8194 RVA: 0x00091514 File Offset: 0x0008F714
			// (set) Token: 0x06002003 RID: 8195 RVA: 0x0000FE72 File Offset: 0x0000E072
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x06002004 RID: 8196 RVA: 0x00091544 File Offset: 0x0008F744
			// (set) Token: 0x06002005 RID: 8197 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
			public unsafe IJsonLineInfo _lineInfo_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__lineInfo_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IJsonLineInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__lineInfo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x06002006 RID: 8198 RVA: 0x00091574 File Offset: 0x0008F774
			// (set) Token: 0x06002007 RID: 8199 RVA: 0x0000FEBF File Offset: 0x0000E0BF
			public unsafe JContainer _parent_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__parent_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr__parent_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x06002008 RID: 8200 RVA: 0x000915A4 File Offset: 0x0008F7A4
			// (set) Token: 0x06002009 RID: 8201 RVA: 0x0000FEDE File Offset: 0x0000E0DE
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x0600200A RID: 8202 RVA: 0x000915D4 File Offset: 0x0008F7D4
			// (set) Token: 0x0600200B RID: 8203 RVA: 0x0000FF0C File Offset: 0x0000E10C
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadContentFromAsync_d__1.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001719 RID: 5913
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400171A RID: 5914
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400171B RID: 5915
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x0400171C RID: 5916
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400171D RID: 5917
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x0400171E RID: 5918
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x0400171F RID: 5919
			private static readonly IntPtr NativeFieldInfoPtr__lineInfo_5__2;

			// Token: 0x04001720 RID: 5920
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__3;

			// Token: 0x04001721 RID: 5921
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04001722 RID: 5922
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04001723 RID: 5923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001724 RID: 5924
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FE RID: 510
		[ObfuscatedName("Newtonsoft.Json.Linq.JContainer+<ReadTokenFromAsync>d__0")]
		public sealed class _ReadTokenFromAsync_d__0 : ValueType
		{
			// Token: 0x0600200C RID: 8204 RVA: 0x00091604 File Offset: 0x0008F804
			// Note: this type is marked as 'beforefieldinit'.
			static _ReadTokenFromAsync_d__0()
			{
				Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JContainer>.NativeClassPtr, "<ReadTokenFromAsync>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr);
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<>1__state");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<>t__builder");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "reader");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "cancellationToken");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<>4__this");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "options");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr__startDepth_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<startDepth>5__2");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<>u__1");
				JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, "<>u__2");
				JContainer._ReadTokenFromAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, 100666318);
				JContainer._ReadTokenFromAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr, 100666319);
			}

			// Token: 0x0600200D RID: 8205 RVA: 0x0009170C File Offset: 0x0008F90C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757105, XrefRangeEnd = 757142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._ReadTokenFromAsync_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600200E RID: 8206 RVA: 0x00091744 File Offset: 0x0008F944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 757142, XrefRangeEnd = 757146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JContainer._ReadTokenFromAsync_d__0.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600200F RID: 8207 RVA: 0x0000FF3A File Offset: 0x0000E13A
			public _ReadTokenFromAsync_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002010 RID: 8208 RVA: 0x0000FF43 File Offset: 0x0000E143
			public _ReadTokenFromAsync_d__0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JContainer._ReadTokenFromAsync_d__0>.NativeClassPtr))
			{
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x0009178C File Offset: 0x0008F98C
			// (set) Token: 0x06002012 RID: 8210 RVA: 0x0000FF55 File Offset: 0x0000E155
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06002013 RID: 8211 RVA: 0x000917B4 File Offset: 0x0008F9B4
			// (set) Token: 0x06002014 RID: 8212 RVA: 0x0000FF70 File Offset: 0x0000E170
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06002015 RID: 8213 RVA: 0x000917E4 File Offset: 0x0008F9E4
			// (set) Token: 0x06002016 RID: 8214 RVA: 0x0000FF9E File Offset: 0x0000E19E
			public unsafe JsonReader reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x06002017 RID: 8215 RVA: 0x00091814 File Offset: 0x0008FA14
			// (set) Token: 0x06002018 RID: 8216 RVA: 0x0000FFBD File Offset: 0x0000E1BD
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090A RID: 2314
			// (get) Token: 0x06002019 RID: 8217 RVA: 0x00091844 File Offset: 0x0008FA44
			// (set) Token: 0x0600201A RID: 8218 RVA: 0x0000FFEB File Offset: 0x0000E1EB
			public unsafe JContainer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090B RID: 2315
			// (get) Token: 0x0600201B RID: 8219 RVA: 0x00091874 File Offset: 0x0008FA74
			// (set) Token: 0x0600201C RID: 8220 RVA: 0x0001000A File Offset: 0x0000E20A
			public unsafe JsonLoadSettings options
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_options);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonLoadSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x0600201D RID: 8221 RVA: 0x000918A4 File Offset: 0x0008FAA4
			// (set) Token: 0x0600201E RID: 8222 RVA: 0x00010029 File Offset: 0x0000E229
			public unsafe int _startDepth_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr__startDepth_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr__startDepth_5__2)) = value;
				}
			}

			// Token: 0x1700090D RID: 2317
			// (get) Token: 0x0600201F RID: 8223 RVA: 0x000918CC File Offset: 0x0008FACC
			// (set) Token: 0x06002020 RID: 8224 RVA: 0x00010044 File Offset: 0x0000E244
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700090E RID: 2318
			// (get) Token: 0x06002021 RID: 8225 RVA: 0x000918FC File Offset: 0x0008FAFC
			// (set) Token: 0x06002022 RID: 8226 RVA: 0x00010072 File Offset: 0x0000E272
			public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JContainer._ReadTokenFromAsync_d__0.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001725 RID: 5925
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001726 RID: 5926
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04001727 RID: 5927
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x04001728 RID: 5928
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x04001729 RID: 5929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400172A RID: 5930
			private static readonly IntPtr NativeFieldInfoPtr_options;

			// Token: 0x0400172B RID: 5931
			private static readonly IntPtr NativeFieldInfoPtr__startDepth_5__2;

			// Token: 0x0400172C RID: 5932
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400172D RID: 5933
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x0400172E RID: 5934
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400172F RID: 5935
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020001FF RID: 511
		private sealed class MethodInfoStoreGeneric_Values_Public_Virtual_IEnumerable_1_T_0<T>
		{
			// Token: 0x04001730 RID: 5936
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JContainer.NativeMethodInfoPtr_Values_Public_Virtual_IEnumerable_1_T_0, Il2CppClassPointerStore<JContainer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { global::Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

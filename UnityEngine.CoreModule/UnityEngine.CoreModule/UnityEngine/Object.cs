using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000158 RID: 344
	public class Object : Object
	{
		// Token: 0x0600195D RID: 6493 RVA: 0x00076CF8 File Offset: 0x00074EF8
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeFieldInfoPtr_m_CachedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "m_CachedPtr");
			Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "OffsetOfInstanceIDInCPlusPlusObject");
			Object.NativeFieldInfoPtr_objectIsNullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "objectIsNullMessage");
			Object.NativeFieldInfoPtr_cloneDestroyedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "cloneDestroyedMessage");
			Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666792);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666793);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666794);
			Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666795);
			Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666796);
			Object.NativeMethodInfoPtr_EnsureRunningOnMainThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666797);
			Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666798);
			Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666799);
			Object.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666800);
			Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666801);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666802);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666803);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666804);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666805);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666806);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666807);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666808);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666809);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666810);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666811);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666812);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666813);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666814);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666815);
			Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666816);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666817);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666818);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666819);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666820);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666821);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666822);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666823);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666824);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666825);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666826);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666827);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666828);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666829);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666830);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666831);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666832);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666833);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666834);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666835);
			Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666836);
			Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666837);
			Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666838);
			Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666839);
			Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666840);
			Object.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666841);
			Object.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666842);
			Object.NativeMethodInfoPtr_FindSceneObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666843);
			Object.NativeMethodInfoPtr_FindObjectsOfTypeIncludingAssets_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666844);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666845);
			Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666846);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666847);
			Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsInactive_FindObjectsSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666848);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666849);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666850);
			Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666851);
			Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666852);
			Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666853);
			Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666854);
			Object.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666855);
			Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666856);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666857);
			Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666858);
			Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666859);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666860);
			Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666861);
			Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666862);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666863);
			Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666864);
			Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666865);
			Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666866);
			Object.NativeMethodInfoPtr_CurrentThreadIsMainThread_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666867);
			Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666868);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithScene_Private_Static_Object_Object_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666869);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParams_Private_Static_Object_Object_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666870);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Private_Static_Object_Object_Vector3_Quaternion_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666871);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666872);
			Object.NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Private_Static_AsyncInstantiateOperation_Object_Int32_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666873);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666874);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666875);
			Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666876);
			Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666877);
			Object.NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666878);
			Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666879);
			Object.NativeMethodInfoPtr_DoesObjectWithInstanceIDExist_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666880);
			Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666881);
			Object.NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666882);
			Object.NativeMethodInfoPtr_MarkDirty_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666883);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666884);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithScene_Injected_Private_Static_Object_Object_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666886);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParams_Injected_Private_Static_Object_Object_byref_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666887);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_byref_InstantiateParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666888);
			Object.NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Injected_Private_Static_AsyncInstantiateOperation_Object_Int32_byref_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666889);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666890);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666891);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00077534 File Offset: 0x00075734
		[CallerCount(248)]
		[CachedScanResults(RefRangeStart = 667466, RefRangeEnd = 667714, XrefRangeStart = 667451, XrefRangeEnd = 667466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00077570 File Offset: 0x00075770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667714, XrefRangeEnd = 667715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x000775B8 File Offset: 0x000757B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667715, XrefRangeEnd = 667743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00077610 File Offset: 0x00075810
		[CallerCount(268)]
		[CachedScanResults(RefRangeStart = 667750, RefRangeEnd = 668018, XrefRangeStart = 667743, XrefRangeEnd = 667750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(Object exists)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00077654 File Offset: 0x00075854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668018, XrefRangeEnd = 668019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000776A8 File Offset: 0x000758A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668019, XrefRangeEnd = 668024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureRunningOnMainThread()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_EnsureRunningOnMainThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000776DC File Offset: 0x000758DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668024, XrefRangeEnd = 668026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNativeObjectAlive(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00077720 File Offset: 0x00075920
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetCachedPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x0007775C File Offset: 0x0007595C
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00077794 File Offset: 0x00075994
		public unsafe string name
		{
			[CallerCount(198)]
			[CachedScanResults(RefRangeStart = 668031, RefRangeEnd = 668229, XrefRangeStart = 668026, XrefRangeEnd = 668031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(63)]
			[CachedScanResults(RefRangeStart = 668234, RefRangeEnd = 668297, XrefRangeStart = 668229, XrefRangeEnd = 668234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000777D8 File Offset: 0x000759D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668297, XrefRangeEnd = 668306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
			}
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00077854 File Offset: 0x00075A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668306, XrefRangeEnd = 668316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000778E0 File Offset: 0x00075AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668316, XrefRangeEnd = 668321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00077978 File Offset: 0x00075B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668321, XrefRangeEnd = 668327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Transform parent, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00077A20 File Offset: 0x00075C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668327, XrefRangeEnd = 668332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00077AA8 File Offset: 0x00075CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668332, XrefRangeEnd = 668338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00077B44 File Offset: 0x00075D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668338, XrefRangeEnd = 668349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00077BE8 File Offset: 0x00075DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668349, XrefRangeEnd = 668354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotations));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00077CA0 File Offset: 0x00075EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668354, XrefRangeEnd = 668366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00077D58 File Offset: 0x00075F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668366, XrefRangeEnd = 668372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotations));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00077E24 File Offset: 0x00076024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668372, XrefRangeEnd = 668377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00077EB8 File Offset: 0x000760B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668377, XrefRangeEnd = 668388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00077F58 File Offset: 0x00076158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668388, XrefRangeEnd = 668399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00078008 File Offset: 0x00076208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668399, XrefRangeEnd = 668406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, Vector3 position, Quaternion rotation, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000780C4 File Offset: 0x000762C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 668429, RefRangeEnd = 668436, XrefRangeStart = 668406, XrefRangeEnd = 668429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(positions));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rotations));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation<T>>(intPtr4) : null;
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00078194 File Offset: 0x00076394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668457, RefRangeEnd = 668459, XrefRangeStart = 668436, XrefRangeEnd = 668457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000781F4 File Offset: 0x000763F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 668489, RefRangeEnd = 668490, XrefRangeStart = 668459, XrefRangeEnd = 668489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00078268 File Offset: 0x00076468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668504, RefRangeEnd = 668506, XrefRangeStart = 668490, XrefRangeEnd = 668504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x000782AC File Offset: 0x000764AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668506, XrefRangeEnd = 668523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, UnityEngine.SceneManagement.Scene scene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00078300 File Offset: 0x00076500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668523, XrefRangeEnd = 668535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0007838C File Offset: 0x0007658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668535, XrefRangeEnd = 668546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_InstantiateParameters_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00078434 File Offset: 0x00076634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668550, RefRangeEnd = 668552, XrefRangeStart = 668546, XrefRangeEnd = 668550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x0007848C File Offset: 0x0007668C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 668592, RefRangeEnd = 668595, XrefRangeStart = 668552, XrefRangeEnd = 668592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000784F0 File Offset: 0x000766F0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 668607, RefRangeEnd = 668626, XrefRangeStart = 668595, XrefRangeEnd = 668607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00078564 File Offset: 0x00076764
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 668632, RefRangeEnd = 668641, XrefRangeStart = 668626, XrefRangeEnd = 668632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000785F4 File Offset: 0x000767F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 668648, RefRangeEnd = 668649, XrefRangeStart = 668641, XrefRangeEnd = 668648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00078698 File Offset: 0x00076898
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 668659, RefRangeEnd = 668718, XrefRangeStart = 668649, XrefRangeEnd = 668659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00078720 File Offset: 0x00076920
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 668724, RefRangeEnd = 668739, XrefRangeStart = 668718, XrefRangeEnd = 668724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = original;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref original;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x000787B4 File Offset: 0x000769B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668741, RefRangeEnd = 668743, XrefRangeStart = 668739, XrefRangeEnd = 668741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000787F8 File Offset: 0x000769F8
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 668748, RefRangeEnd = 668831, XrefRangeStart = 668743, XrefRangeEnd = 668748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00078830 File Offset: 0x00076A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668833, RefRangeEnd = 668835, XrefRangeStart = 668831, XrefRangeEnd = 668833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj, bool allowDestroyingAssets)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDestroyingAssets;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00078874 File Offset: 0x00076A74
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 668840, RefRangeEnd = 668868, XrefRangeStart = 668835, XrefRangeEnd = 668840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000788AC File Offset: 0x00076AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 668873, RefRangeEnd = 668874, XrefRangeStart = 668868, XrefRangeEnd = 668873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000788F0 File Offset: 0x00076AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668876, RefRangeEnd = 668878, XrefRangeStart = 668874, XrefRangeEnd = 668876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00078944 File Offset: 0x00076B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668878, XrefRangeEnd = 668883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsSortMode sortMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsSortMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00078998 File Offset: 0x00076B98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 668885, RefRangeEnd = 668887, XrefRangeStart = 668883, XrefRangeEnd = 668885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref findObjectsInactive;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x000789F8 File Offset: 0x00076BF8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 668889, RefRangeEnd = 668905, XrefRangeStart = 668887, XrefRangeEnd = 668889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DontDestroyOnLoad(Object target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00078A30 File Offset: 0x00076C30
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00078A6C File Offset: 0x00076C6C
		public unsafe HideFlags hideFlags
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 668907, RefRangeEnd = 668921, XrefRangeStart = 668905, XrefRangeEnd = 668907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 668923, RefRangeEnd = 668984, XrefRangeStart = 668921, XrefRangeEnd = 668923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00078AAC File Offset: 0x00076CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668984, XrefRangeEnd = 668989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyObject(Object obj, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00078AF0 File Offset: 0x00076CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668989, XrefRangeEnd = 668994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00078B28 File Offset: 0x00076D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 668994, XrefRangeEnd = 669002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindSceneObjectsOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindSceneObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00078B6C File Offset: 0x00076D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669002, XrefRangeEnd = 669004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeIncludingAssets(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfTypeIncludingAssets_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00078BB0 File Offset: 0x00076DB0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 669014, RefRangeEnd = 669025, XrefRangeStart = 669004, XrefRangeEnd = 669014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00078BDC File Offset: 0x00076DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669025, XrefRangeEnd = 669035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sortMode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00078C14 File Offset: 0x00076E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669035, XrefRangeEnd = 669045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00078C4C File Offset: 0x00076E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669045, XrefRangeEnd = 669055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findObjectsInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsInactive_FindObjectsSortMode_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00078C94 File Offset: 0x00076E94
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 669065, RefRangeEnd = 669075, XrefRangeStart = 669055, XrefRangeEnd = 669065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00078CC4 File Offset: 0x00076EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669075, XrefRangeEnd = 669085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00078D00 File Offset: 0x00076F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669085, XrefRangeEnd = 669095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindFirstObjectByType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00078D30 File Offset: 0x00076F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669095, XrefRangeEnd = 669105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindAnyObjectByType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00078D60 File Offset: 0x00076F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669105, XrefRangeEnd = 669115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findObjectsInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00078D9C File Offset: 0x00076F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669115, XrefRangeEnd = 669125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref findObjectsInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_FindObjectsInactive_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00078DD8 File Offset: 0x00076FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00078E1C File Offset: 0x0007701C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 669130, RefRangeEnd = 669134, XrefRangeStart = 669125, XrefRangeEnd = 669130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckNullArgument(Object arg, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00078E64 File Offset: 0x00077064
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 669139, RefRangeEnd = 669142, XrefRangeStart = 669134, XrefRangeEnd = 669139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00078EA8 File Offset: 0x000770A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669142, XrefRangeEnd = 669147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindFirstObjectByType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00078EEC File Offset: 0x000770EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 669147, XrefRangeEnd = 669152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindAnyObjectByType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00078F30 File Offset: 0x00077130
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 669157, RefRangeEnd = 669159, XrefRangeStart = 669152, XrefRangeEnd = 669157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00078F84 File Offset: 0x00077184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 669164, RefRangeEnd = 669166, XrefRangeStart = 669159, XrefRangeEnd = 669164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref findObjectsInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00078FD8 File Offset: 0x000771D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 669171, RefRangeEnd = 669173, XrefRangeStart = 669166, XrefRangeEnd = 669171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref findObjectsInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0007902C File Offset: 0x0007722C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 669178, RefRangeEnd = 669179, XrefRangeStart = 669173, XrefRangeEnd = 669178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00079070 File Offset: 0x00077270
		[CallerCount(1577)]
		[CachedScanResults(RefRangeStart = 669185, RefRangeEnd = 670762, XrefRangeStart = 669179, XrefRangeEnd = 669185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000790C4 File Offset: 0x000772C4
		[CallerCount(2055)]
		[CachedScanResults(RefRangeStart = 670768, RefRangeEnd = 672823, XrefRangeStart = 670762, XrefRangeEnd = 670768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Object x, Object y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00079118 File Offset: 0x00077318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672823, XrefRangeEnd = 672825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00079148 File Offset: 0x00077348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672825, XrefRangeEnd = 672827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CurrentThreadIsMainThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CurrentThreadIsMainThread_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00079178 File Offset: 0x00077378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 672829, RefRangeEnd = 672830, XrefRangeStart = 672827, XrefRangeEnd = 672829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingle(Object data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x000791BC File Offset: 0x000773BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672830, XrefRangeEnd = 672835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithScene(Object data, UnityEngine.SceneManagement.Scene scene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithScene_Private_Static_Object_Object_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00079210 File Offset: 0x00077410
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 672840, RefRangeEnd = 672841, XrefRangeStart = 672835, XrefRangeEnd = 672840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParams(Object data, InstantiateParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParams_Private_Static_Object_Object_InstantiateParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x0007926C File Offset: 0x0007746C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 672846, RefRangeEnd = 672847, XrefRangeStart = 672841, XrefRangeEnd = 672846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParams(Object data, Vector3 position, Quaternion rotation, InstantiateParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Private_Static_Object_Object_Vector3_Quaternion_InstantiateParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000792E4 File Offset: 0x000774E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672847, XrefRangeEnd = 672849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00079348 File Offset: 0x00077548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 672854, RefRangeEnd = 672855, XrefRangeStart = 672849, XrefRangeEnd = 672854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation Internal_InstantiateAsyncWithParams(Object original, int count, InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotations;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Private_Static_AsyncInstantiateOperation_Object_Int32_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation>(intPtr3) : null;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000793EC File Offset: 0x000775EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672855, XrefRangeEnd = 672860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0007944C File Offset: 0x0007764C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672860, XrefRangeEnd = 672865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000794C0 File Offset: 0x000776C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672865, XrefRangeEnd = 672869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000794FC File Offset: 0x000776FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672869, XrefRangeEnd = 672871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x00079538 File Offset: 0x00077738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 672873, RefRangeEnd = 672874, XrefRangeStart = 672871, XrefRangeEnd = 672873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPersistent(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0007957C File Offset: 0x0007777C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672874, XrefRangeEnd = 672876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName(Object obj, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000795C4 File Offset: 0x000777C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672876, XrefRangeEnd = 672878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesObjectWithInstanceIDExist(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DoesObjectWithInstanceIDExist_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00079604 File Offset: 0x00077804
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 672880, RefRangeEnd = 672885, XrefRangeStart = 672878, XrefRangeEnd = 672880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectFromInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00079644 File Offset: 0x00077844
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 672887, RefRangeEnd = 672891, XrefRangeStart = 672885, XrefRangeEnd = 672887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ForceLoadFromInstanceID(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00079684 File Offset: 0x00077884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672891, XrefRangeEnd = 672893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_MarkDirty_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000796B8 File Offset: 0x000778B8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000796F4 File Offset: 0x000778F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672893, XrefRangeEnd = 672895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithScene_Injected(Object data, ref UnityEngine.SceneManagement.Scene scene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithScene_Injected_Private_Static_Object_Object_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x00079748 File Offset: 0x00077948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672895, XrefRangeEnd = 672897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParams_Injected(Object data, ref InstantiateParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParams_Injected_Private_Static_Object_Object_byref_InstantiateParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000797A0 File Offset: 0x000779A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672897, XrefRangeEnd = 672899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParams_Injected(Object data, ref Vector3 position, ref Quaternion rotation, ref InstantiateParameters parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_byref_InstantiateParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x00079814 File Offset: 0x00077A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672899, XrefRangeEnd = 672901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncInstantiateOperation Internal_InstantiateAsyncWithParams_Injected(Object original, int count, ref InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionsCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotations;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Injected_Private_Static_AsyncInstantiateOperation_Object_Int32_byref_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncInstantiateOperation>(intPtr3) : null;
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000798B4 File Offset: 0x00077AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672901, XrefRangeEnd = 672903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00079914 File Offset: 0x00077B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 672903, XrefRangeEnd = 672905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00009E5E File Offset: 0x0000805E
		public Object(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00079988 File Offset: 0x00077B88
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00009E67 File Offset: 0x00008067
		public unsafe IntPtr m_CachedPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x000799B0 File Offset: 0x00077BB0
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00009E82 File Offset: 0x00008082
		public unsafe static int OffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&value));
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x000799CC File Offset: 0x00077BCC
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00009E90 File Offset: 0x00008090
		public unsafe static string objectIsNullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_objectIsNullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_objectIsNullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000799EC File Offset: 0x00077BEC
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00009EA2 File Offset: 0x000080A2
		public unsafe static string cloneDestroyedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPtr;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_objectIsNullMessage;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_cloneDestroyedMessage;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_EnsureRunningOnMainThread_Private_Void_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_0;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_Vector3_Quaternion_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_Vector3_Quaternion_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_InstantiateParameters_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_InstantiateParameters_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_InstantiateParameters_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_InstantiateParameters_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_InstantiateParameters_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Scene_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_InstantiateParameters_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_InstantiateParameters_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsSortMode_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppReferenceArray_1_Object_Type_FindObjectsInactive_FindObjectsSortMode_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_Single_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_DestroyObject_Public_Static_Void_Object_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_FindSceneObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeIncludingAssets_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsInactive_FindObjectsSortMode_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_FindObjectsInactive_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_Object_Type_FindObjectsInactive_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_Object_Type_FindObjectsInactive_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_CurrentThreadIsMainThread_Private_Static_Boolean_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithScene_Private_Static_Object_Object_Scene_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParams_Private_Static_Object_Object_InstantiateParameters_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Private_Static_Object_Object_Vector3_Quaternion_InstantiateParameters_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Private_Static_AsyncInstantiateOperation_Object_Int32_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_Static_String_Object_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Object_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_IsPersistent_Internal_Static_Boolean_Object_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_DoesObjectWithInstanceIDExist_Internal_Static_Boolean_Int32_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Internal_Void_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithScene_Injected_Private_Static_Object_Object_byref_Scene_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParams_Injected_Private_Static_Object_Object_byref_InstantiateParameters_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParams_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_byref_InstantiateParameters_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateAsyncWithParams_Injected_Private_Static_AsyncInstantiateOperation_Object_Int32_byref_InstantiateParameters_IntPtr_Int32_IntPtr_Int32_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0;

		// Token: 0x02000762 RID: 1890
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_0<T>
		{
			// Token: 0x04002C7C RID: 11388
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000763 RID: 1891
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_0<T>
		{
			// Token: 0x04002C7D RID: 11389
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000764 RID: 1892
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002C7E RID: 11390
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000765 RID: 1893
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002C7F RID: 11391
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Transform_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000766 RID: 1894
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_0<T>
		{
			// Token: 0x04002C80 RID: 11392
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000767 RID: 1895
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_0<T>
		{
			// Token: 0x04002C81 RID: 11393
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000768 RID: 1896
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002C82 RID: 11394
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000769 RID: 1897
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0<T>
		{
			// Token: 0x04002C83 RID: 11395
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076A RID: 1898
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002C84 RID: 11396
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076B RID: 1899
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0<T>
		{
			// Token: 0x04002C85 RID: 11397
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Transform_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076C RID: 1900
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_InstantiateParameters_0<T>
		{
			// Token: 0x04002C86 RID: 11398
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076D RID: 1901
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_InstantiateParameters_0<T>
		{
			// Token: 0x04002C87 RID: 11399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076E RID: 1902
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_InstantiateParameters_0<T>
		{
			// Token: 0x04002C88 RID: 11400
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Vector3_Quaternion_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200076F RID: 1903
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_InstantiateParameters_0<T>
		{
			// Token: 0x04002C89 RID: 11401
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_Vector3_Quaternion_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000770 RID: 1904
		private sealed class MethodInfoStoreGeneric_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_InstantiateParameters_0<T>
		{
			// Token: 0x04002C8A RID: 11402
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_InstantiateAsync_Public_Static_AsyncInstantiateOperation_1_T_T_Int32_ReadOnlySpan_1_Vector3_ReadOnlySpan_1_Quaternion_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000771 RID: 1905
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_InstantiateParameters_0<T>
		{
			// Token: 0x04002C8B RID: 11403
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000772 RID: 1906
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_InstantiateParameters_0<T>
		{
			// Token: 0x04002C8C RID: 11404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_InstantiateParameters_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000773 RID: 1907
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
		{
			// Token: 0x04002C8D RID: 11405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000774 RID: 1908
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002C8E RID: 11406
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000775 RID: 1909
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0<T>
		{
			// Token: 0x04002C8F RID: 11407
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000776 RID: 1910
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>
		{
			// Token: 0x04002C90 RID: 11408
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000777 RID: 1911
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x04002C91 RID: 11409
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000778 RID: 1912
		private sealed class MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C92 RID: 11410
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000779 RID: 1913
		private sealed class MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0<T>
		{
			// Token: 0x04002C93 RID: 11411
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsSortMode_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077A RID: 1914
		private sealed class MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002C94 RID: 11412
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077B RID: 1915
		private sealed class MethodInfoStoreGeneric_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsInactive_FindObjectsSortMode_0<T>
		{
			// Token: 0x04002C95 RID: 11413
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsByType_Public_Static_Il2CppArrayBase_1_T_FindObjectsInactive_FindObjectsSortMode_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077C RID: 1916
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>
		{
			// Token: 0x04002C96 RID: 11414
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077D RID: 1917
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_Boolean_0<T>
		{
			// Token: 0x04002C97 RID: 11415
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077E RID: 1918
		private sealed class MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_0<T>
		{
			// Token: 0x04002C98 RID: 11416
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200077F RID: 1919
		private sealed class MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_0<T>
		{
			// Token: 0x04002C99 RID: 11417
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000780 RID: 1920
		private sealed class MethodInfoStoreGeneric_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0<T>
		{
			// Token: 0x04002C9A RID: 11418
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindFirstObjectByType_Public_Static_T_FindObjectsInactive_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000781 RID: 1921
		private sealed class MethodInfoStoreGeneric_FindAnyObjectByType_Public_Static_T_FindObjectsInactive_0<T>
		{
			// Token: 0x04002C9B RID: 11419
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindAnyObjectByType_Public_Static_T_FindObjectsInactive_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

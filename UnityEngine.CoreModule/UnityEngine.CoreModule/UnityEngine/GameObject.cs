using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200013E RID: 318
	public sealed class GameObject : Object
	{
		// Token: 0x06001853 RID: 6227 RVA: 0x000723C0 File Offset: 0x000705C0
		// Note: this type is marked as 'beforefieldinit'.
		static GameObject()
		{
			Il2CppClassPointerStore<GameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObject>.NativeClassPtr);
			GameObject.NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666606);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666607);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666608);
			GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666609);
			GameObject.NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666610);
			GameObject.NativeMethodInfoPtr_GetComponentByNameWithCase_Internal_Component_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666611);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666612);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666613);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666614);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666615);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666616);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666617);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666618);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666619);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666620);
			GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666621);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666622);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666623);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666624);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666625);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666626);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666627);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666628);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666629);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666630);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666631);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666632);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666633);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666634);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666635);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666636);
			GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666637);
			GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666638);
			GameObject.NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666639);
			GameObject.NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666640);
			GameObject.NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666641);
			GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666642);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666643);
			GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666644);
			GameObject.NativeMethodInfoPtr_AddComponentInternal_Internal_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666645);
			GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666646);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666647);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666648);
			GameObject.NativeMethodInfoPtr_GetComponentCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666649);
			GameObject.NativeMethodInfoPtr_QueryComponentAtIndex_Internal_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666650);
			GameObject.NativeMethodInfoPtr_GetComponentAtIndex_Public_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666651);
			GameObject.NativeMethodInfoPtr_GetComponentAtIndex_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666652);
			GameObject.NativeMethodInfoPtr_GetComponentIndex_Public_Int32_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666653);
			GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666654);
			GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666655);
			GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666656);
			GameObject.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666657);
			GameObject.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666658);
			GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666659);
			GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666660);
			GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666661);
			GameObject.NativeMethodInfoPtr_SetActiveRecursively_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666662);
			GameObject.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666663);
			GameObject.NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666664);
			GameObject.NativeMethodInfoPtr_get_isStaticBatchable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666665);
			GameObject.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666666);
			GameObject.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666667);
			GameObject.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666668);
			GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666669);
			GameObject.NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666670);
			GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666671);
			GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666672);
			GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666673);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666674);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666675);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666676);
			GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666677);
			GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666678);
			GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666679);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666680);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666681);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666682);
			GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666683);
			GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666684);
			GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Private_Static_Void_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666685);
			GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_NativeArray_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666686);
			GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_ReadOnlySpan_1_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666687);
			GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666688);
			GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Public_Static_Void_Int32_Int32_NativeArray_1_Int32_NativeArray_1_Int32_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666689);
			GameObject.NativeMethodInfoPtr_GetScene_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666690);
			GameObject.NativeMethodInfoPtr_get_scene_Public_get_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666691);
			GameObject.NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666692);
			GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666693);
			GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Injected_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666694);
			GameObject.NativeMethodInfoPtr_GetScene_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666695);
			GameObject.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100666696);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00072B0C File Offset: 0x00070D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664765, XrefRangeEnd = 664767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreatePrimitive(PrimitiveType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00072B4C File Offset: 0x00070D4C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 664773, RefRangeEnd = 664974, XrefRangeStart = 664767, XrefRangeEnd = 664773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00072B88 File Offset: 0x00070D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664974, XrefRangeEnd = 664976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00072BD8 File Offset: 0x00070DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664978, RefRangeEnd = 664979, XrefRangeStart = 664976, XrefRangeEnd = 664978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00072C28 File Offset: 0x00070E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664979, XrefRangeEnd = 664981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentByName(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00072C78 File Offset: 0x00070E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664981, XrefRangeEnd = 664983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentByNameWithCase(string type, bool caseSensitive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseSensitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentByNameWithCase_Internal_Component_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00072CD8 File Offset: 0x00070ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00072D28 File Offset: 0x00070F28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 664985, RefRangeEnd = 664988, XrefRangeStart = 664983, XrefRangeEnd = 664985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00072D88 File Offset: 0x00070F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664988, XrefRangeEnd = 664990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00072DD8 File Offset: 0x00070FD8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 664998, RefRangeEnd = 665019, XrefRangeStart = 664990, XrefRangeEnd = 664998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00072E14 File Offset: 0x00071014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665019, XrefRangeEnd = 665026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00072E5C File Offset: 0x0007105C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665028, RefRangeEnd = 665030, XrefRangeStart = 665026, XrefRangeEnd = 665028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00072EBC File Offset: 0x000710BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665030, XrefRangeEnd = 665032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00072F0C File Offset: 0x0007110C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 665040, RefRangeEnd = 665054, XrefRangeStart = 665032, XrefRangeEnd = 665040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00072F48 File Offset: 0x00071148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665054, XrefRangeEnd = 665061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00072F90 File Offset: 0x00071190
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 665063, RefRangeEnd = 665070, XrefRangeStart = 665061, XrefRangeEnd = 665063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSearchTypeAsArrayReturnType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0007302C File Offset: 0x0007122C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 665075, RefRangeEnd = 665076, XrefRangeStart = 665070, XrefRangeEnd = 665075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0007307C File Offset: 0x0007127C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 665084, RefRangeEnd = 665090, XrefRangeStart = 665076, XrefRangeEnd = 665084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000730B4 File Offset: 0x000712B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665092, RefRangeEnd = 665094, XrefRangeStart = 665090, XrefRangeEnd = 665092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents(Type type, List<Component> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00073108 File Offset: 0x00071308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665100, RefRangeEnd = 665102, XrefRangeStart = 665094, XrefRangeEnd = 665100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0007314C File Offset: 0x0007134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665102, XrefRangeEnd = 665107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Component> GetComponentsInChildren(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0007319C File Offset: 0x0007139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665107, XrefRangeEnd = 665112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Component> GetComponentsInChildren(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000731FC File Offset: 0x000713FC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 665120, RefRangeEnd = 665130, XrefRangeStart = 665112, XrefRangeEnd = 665120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00073240 File Offset: 0x00071440
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665136, RefRangeEnd = 665138, XrefRangeStart = 665130, XrefRangeEnd = 665136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00073290 File Offset: 0x00071490
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 665147, RefRangeEnd = 665154, XrefRangeStart = 665138, XrefRangeEnd = 665147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x000732C8 File Offset: 0x000714C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665154, XrefRangeEnd = 665155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0007330C File Offset: 0x0007150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665155, XrefRangeEnd = 665160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Component> GetComponentsInParent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0007335C File Offset: 0x0007155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665160, XrefRangeEnd = 665165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Component> GetComponentsInParent(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x000733BC File Offset: 0x000715BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 665171, RefRangeEnd = 665180, XrefRangeStart = 665165, XrefRangeEnd = 665171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0007340C File Offset: 0x0007160C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665188, RefRangeEnd = 665190, XrefRangeStart = 665180, XrefRangeEnd = 665188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeInactive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00073450 File Offset: 0x00071650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665190, XrefRangeEnd = 665197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00073488 File Offset: 0x00071688
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 665204, RefRangeEnd = 665223, XrefRangeStart = 665197, XrefRangeEnd = 665204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent<T>(out T component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref component;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00073514 File Offset: 0x00071714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665223, XrefRangeEnd = 665236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent(Type type, out Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			component = ((intPtr4 == 0) ? null : new Component(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00073584 File Offset: 0x00071784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665236, XrefRangeEnd = 665238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component TryGetComponentInternal(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000735D4 File Offset: 0x000717D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 665240, RefRangeEnd = 665241, XrefRangeStart = 665238, XrefRangeEnd = 665240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00073624 File Offset: 0x00071824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665243, RefRangeEnd = 665245, XrefRangeStart = 665241, XrefRangeEnd = 665243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindWithTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00073668 File Offset: 0x00071868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665245, XrefRangeEnd = 665247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x000736B8 File Offset: 0x000718B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665247, XrefRangeEnd = 665249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00073708 File Offset: 0x00071908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 665251, RefRangeEnd = 665252, XrefRangeStart = 665249, XrefRangeEnd = 665251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00073758 File Offset: 0x00071958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665252, XrefRangeEnd = 665254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component AddComponentInternal(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_AddComponentInternal_Internal_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x000737A8 File Offset: 0x000719A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 665256, RefRangeEnd = 665259, XrefRangeStart = 665254, XrefRangeEnd = 665256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component Internal_AddComponentWithType(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x000737F8 File Offset: 0x000719F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 665256, RefRangeEnd = 665259, XrefRangeStart = 665256, XrefRangeEnd = 665259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component AddComponent(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00073848 File Offset: 0x00071A48
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 665268, RefRangeEnd = 665364, XrefRangeStart = 665259, XrefRangeEnd = 665268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddComponent<T>() where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_AddComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00073884 File Offset: 0x00071A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665364, XrefRangeEnd = 665366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComponentCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000738C0 File Offset: 0x00071AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665366, XrefRangeEnd = 665368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component QueryComponentAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_QueryComponentAtIndex_Internal_Component_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0007390C File Offset: 0x00071B0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 665379, RefRangeEnd = 665380, XrefRangeStart = 665368, XrefRangeEnd = 665379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentAtIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentAtIndex_Public_Component_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00073958 File Offset: 0x00071B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665380, XrefRangeEnd = 665389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentAtIndex<T>(int index) where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentAtIndex_Public_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000739A0 File Offset: 0x00071BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665389, XrefRangeEnd = 665391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComponentIndex(Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentIndex_Public_Int32_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000739F0 File Offset: 0x00071BF0
		public unsafe Transform transform
		{
			[CallerCount(144)]
			[CachedScanResults(RefRangeStart = 665393, RefRangeEnd = 665537, XrefRangeStart = 665391, XrefRangeEnd = 665393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00073A30 File Offset: 0x00071C30
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00073A6C File Offset: 0x00071C6C
		public unsafe int layer
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 665539, RefRangeEnd = 665561, XrefRangeStart = 665537, XrefRangeEnd = 665539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 665563, RefRangeEnd = 665573, XrefRangeStart = 665561, XrefRangeEnd = 665563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00073AAC File Offset: 0x00071CAC
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00073AE8 File Offset: 0x00071CE8
		public unsafe bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665573, XrefRangeEnd = 665575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 665575, XrefRangeEnd = 665577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00073B28 File Offset: 0x00071D28
		[CallerCount(528)]
		[CachedScanResults(RefRangeStart = 665579, RefRangeEnd = 666107, XrefRangeStart = 665577, XrefRangeEnd = 665579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00073B68 File Offset: 0x00071D68
		public unsafe bool activeSelf
		{
			[CallerCount(69)]
			[CachedScanResults(RefRangeStart = 666109, RefRangeEnd = 666178, XrefRangeStart = 666107, XrefRangeEnd = 666109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00073BA4 File Offset: 0x00071DA4
		public unsafe bool activeInHierarchy
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 666180, RefRangeEnd = 666235, XrefRangeStart = 666178, XrefRangeEnd = 666180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00073BE0 File Offset: 0x00071DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666235, XrefRangeEnd = 666237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveRecursively(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetActiveRecursively_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00073C20 File Offset: 0x00071E20
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x00073C5C File Offset: 0x00071E5C
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666237, XrefRangeEnd = 666239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666239, XrefRangeEnd = 666241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00073C9C File Offset: 0x00071E9C
		public unsafe bool isStaticBatchable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666241, XrefRangeEnd = 666243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_isStaticBatchable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00073CD8 File Offset: 0x00071ED8
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x00073D10 File Offset: 0x00071F10
		public unsafe string tag
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 666245, RefRangeEnd = 666247, XrefRangeStart = 666243, XrefRangeEnd = 666245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 666249, RefRangeEnd = 666251, XrefRangeStart = 666247, XrefRangeEnd = 666249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00073D54 File Offset: 0x00071F54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 666253, RefRangeEnd = 666254, XrefRangeStart = 666251, XrefRangeEnd = 666253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00073DA4 File Offset: 0x00071FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 665243, RefRangeEnd = 665245, XrefRangeStart = 665243, XrefRangeEnd = 665245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindGameObjectWithTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00073DE8 File Offset: 0x00071FE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 666256, RefRangeEnd = 666261, XrefRangeStart = 666254, XrefRangeEnd = 666256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GameObject> FindGameObjectsWithTag(string tag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00073E2C File Offset: 0x0007202C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666261, XrefRangeEnd = 666263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00073E90 File Offset: 0x00072090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666263, XrefRangeEnd = 666265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageUpwards(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00073EE4 File Offset: 0x000720E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666265, XrefRangeEnd = 666267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageUpwards(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00073F28 File Offset: 0x00072128
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 666269, RefRangeEnd = 666278, XrefRangeStart = 666267, XrefRangeEnd = 666269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00073F8C File Offset: 0x0007218C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666278, XrefRangeEnd = 666280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00073FE0 File Offset: 0x000721E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666280, XrefRangeEnd = 666282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00074024 File Offset: 0x00072224
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 666284, RefRangeEnd = 666290, XrefRangeStart = 666282, XrefRangeEnd = 666284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00074088 File Offset: 0x00072288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666290, XrefRangeEnd = 666292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string methodName, Object parameter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000740DC File Offset: 0x000722DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666292, XrefRangeEnd = 666294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string methodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00074120 File Offset: 0x00072320
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 666300, RefRangeEnd = 666318, XrefRangeStart = 666294, XrefRangeEnd = 666300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007416C File Offset: 0x0007236C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 666324, RefRangeEnd = 666329, XrefRangeStart = 666318, XrefRangeEnd = 666324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x000741A8 File Offset: 0x000723A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 666338, RefRangeEnd = 666345, XrefRangeStart = 666329, XrefRangeEnd = 666338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00074214 File Offset: 0x00072414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666345, XrefRangeEnd = 666347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateGameObject(GameObject self, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0007425C File Offset: 0x0007245C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 666349, RefRangeEnd = 666351, XrefRangeStart = 666347, XrefRangeEnd = 666349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Find(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000742A0 File Offset: 0x000724A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666351, XrefRangeEnd = 666353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceIds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instanceCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Private_Static_Void_IntPtr_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000742F0 File Offset: 0x000724F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666353, XrefRangeEnd = 666360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameObjectsActive(Unity.Collections.NativeArray<int> instanceIDs, bool active)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instanceIDs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_NativeArray_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0007433C File Offset: 0x0007253C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666360, XrefRangeEnd = 666367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetGameObjectsActive(ReadOnlySpan<int> instanceIDs, bool active)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(instanceIDs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_ReadOnlySpan_1_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00074388 File Offset: 0x00072588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666367, XrefRangeEnd = 666369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstantiateGameObjects(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, UnityEngine.SceneManagement.Scene destinationScene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceInstanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInstanceIDs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTransformInstanceIDs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000743F4 File Offset: 0x000725F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666369, XrefRangeEnd = 666379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstantiateGameObjects(int sourceInstanceID, int count, Unity.Collections.NativeArray<int> newInstanceIDs, Unity.Collections.NativeArray<int> newTransformInstanceIDs, UnityEngine.SceneManagement.Scene destinationScene = default(UnityEngine.SceneManagement.Scene))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceInstanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newInstanceIDs));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newTransformInstanceIDs));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Public_Static_Void_Int32_Int32_NativeArray_1_Int32_NativeArray_1_Int32_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00074470 File Offset: 0x00072670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666379, XrefRangeEnd = 666381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.SceneManagement.Scene GetScene(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetScene_Public_Static_Scene_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060018A9 RID: 6313 RVA: 0x000744B0 File Offset: 0x000726B0
		public unsafe UnityEngine.SceneManagement.Scene scene
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 666383, RefRangeEnd = 666387, XrefRangeStart = 666381, XrefRangeEnd = 666383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_scene_Public_get_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x000744EC File Offset: 0x000726EC
		public unsafe ulong sceneCullingMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 666389, RefRangeEnd = 666390, XrefRangeStart = 666387, XrefRangeEnd = 666389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060018AB RID: 6315 RVA: 0x00074528 File Offset: 0x00072728
		public unsafe GameObject gameObject
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 330146, RefRangeEnd = 330194, XrefRangeStart = 330146, XrefRangeEnd = 330194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00074568 File Offset: 0x00072768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666390, XrefRangeEnd = 666392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstantiateGameObjects_Injected(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, ref UnityEngine.SceneManagement.Scene destinationScene)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceInstanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newInstanceIDs;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTransformInstanceIDs;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destinationScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_InstantiateGameObjects_Injected_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000745D4 File Offset: 0x000727D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666392, XrefRangeEnd = 666394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetScene_Injected(int instanceID, out UnityEngine.SceneManagement.Scene ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetScene_Injected_Private_Static_Void_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00074614 File Offset: 0x00072814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666394, XrefRangeEnd = 666396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00009ADB File Offset: 0x00007CDB
		public GameObject(string name, params Type[] components)
			: this(name, new Il2CppReferenceArray<Type>(components))
		{
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00009AEA File Offset: 0x00007CEA
		public GameObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x040015B7 RID: 5559
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentByName_Internal_Component_String_0;

		// Token: 0x040015B8 RID: 5560
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentByNameWithCase_Internal_Component_String_Boolean_0;

		// Token: 0x040015B9 RID: 5561
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_String_0;

		// Token: 0x040015BA RID: 5562
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x040015BB RID: 5563
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_0;

		// Token: 0x040015BC RID: 5564
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x040015BD RID: 5565
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

		// Token: 0x040015BE RID: 5566
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

		// Token: 0x040015BF RID: 5567
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_0;

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0;

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppReferenceArray_1_Component_Type_0;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_0;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppReferenceArray_1_Component_Type_Boolean_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_FindWithTag_Public_Static_GameObject_String_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_SendMessageOptions_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_SendMessageOptions_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_SendMessageOptions_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_AddComponentInternal_Internal_Component_String_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Component_Type_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_T_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentCount_Public_Int32_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_QueryComponentAtIndex_Internal_Component_Int32_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentAtIndex_Public_Component_Int32_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentAtIndex_Public_T_Int32_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentIndex_Public_Int32_Component_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_get_layer_Public_get_Int32_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveRecursively_Public_Void_Boolean_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_get_isStaticBatchable_Internal_get_Boolean_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_Object_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageUpwards_Public_Void_String_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_SetGameObjectsActive_Private_Static_Void_IntPtr_Int32_Boolean_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_NativeArray_1_Int32_Boolean_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_SetGameObjectsActive_Public_Static_Void_ReadOnlySpan_1_Int32_Boolean_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGameObjects_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_Scene_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGameObjects_Public_Static_Void_Int32_Int32_NativeArray_1_Int32_NativeArray_1_Int32_Scene_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_GetScene_Public_Static_Scene_Int32_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Public_get_Scene_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateGameObjects_Injected_Private_Static_Void_Int32_IntPtr_IntPtr_Int32_byref_Scene_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_GetScene_Injected_Private_Static_Void_Int32_byref_Scene_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0;

		// Token: 0x02000741 RID: 1857
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04002C5A RID: 11354
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000742 RID: 1858
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04002C5B RID: 11355
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000743 RID: 1859
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
		{
			// Token: 0x04002C5C RID: 11356
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000744 RID: 1860
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04002C5D RID: 11357
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000745 RID: 1861
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>
		{
			// Token: 0x04002C5E RID: 11358
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000746 RID: 1862
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C5F RID: 11359
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000747 RID: 1863
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002C60 RID: 11360
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000748 RID: 1864
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002C61 RID: 11361
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000749 RID: 1865
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002C62 RID: 11362
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074A RID: 1866
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C63 RID: 11363
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074B RID: 1867
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002C64 RID: 11364
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074C RID: 1868
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002C65 RID: 11365
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074D RID: 1869
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002C66 RID: 11366
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074E RID: 1870
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002C67 RID: 11367
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200074F RID: 1871
		private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04002C68 RID: 11368
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000750 RID: 1872
		private sealed class MethodInfoStoreGeneric_AddComponent_Public_T_0<T>
		{
			// Token: 0x04002C69 RID: 11369
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000751 RID: 1873
		private sealed class MethodInfoStoreGeneric_GetComponentAtIndex_Public_T_Int32_0<T>
		{
			// Token: 0x04002C6A RID: 11370
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentAtIndex_Public_T_Int32_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x0200004F RID: 79
public static class GameObjectUtil : global::Il2CppSystem.Object
{
	// Token: 0x060005CB RID: 1483 RVA: 0x0002AB24 File Offset: 0x00028D24
	// Note: this type is marked as 'beforefieldinit'.
	static GameObjectUtil()
	{
		Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GameObjectUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr);
		GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceOrSilence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedGetMonoInterfaceOrSilence");
		GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceInChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedGetMonoInterfaceInChildren");
		GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedGetMonoInterfaces");
		GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfacesInChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedGetMonoInterfacesInChildren");
		GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedGetMonoInterface");
		GameObjectUtil.NativeFieldInfoPtr_cachedTransformHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, "cachedTransformHierarchy");
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664163);
		GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPath_Public_Static_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664164);
		GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPathOrThrow_Public_Static_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664165);
		GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPathOrSilence_Public_Static_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664166);
		GameObjectUtil.NativeMethodInfoPtr_FindOrThrow_Public_Static_Transform_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664167);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentByPath_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664168);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentByPathOrThrow_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664169);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentByPathOrSilence_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664170);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrSilence_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664171);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664172);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664173);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_List_1_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664174);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_Void_Transform_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664175);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInScene_Public_Static_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664176);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_List_1_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664177);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_Void_Transform_Boolean_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664178);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664179);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664180);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664181);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664182);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPath_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664183);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPathOrThrow_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664184);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPathOrSilence_Public_Static_T_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664185);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664186);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664187);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_Void_Component_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664188);
		GameObjectUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664189);
		GameObjectUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664190);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateAndZero_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664191);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateResource_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664192);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceOrThrow_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664193);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664194);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664195);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664196);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664197);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664198);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_Void_Component_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664199);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664200);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_Component_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664201);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentWithLogging_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664202);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664203);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664204);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_Component_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664205);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_GameObject_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664206);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentInChildrenOrThrow_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664207);
		GameObjectUtil.NativeMethodInfoPtr_HasAncestor_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664208);
		GameObjectUtil.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664209);
		GameObjectUtil.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664210);
		GameObjectUtil.NativeMethodInfoPtr_FindOrCreateComponentObject_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664211);
		GameObjectUtil.NativeMethodInfoPtr_ToIdentityTransform_Public_Static_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664212);
		GameObjectUtil.NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664213);
		GameObjectUtil.NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664214);
		GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_GameObject_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664215);
		GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Transform_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664216);
		GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Component_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664217);
		GameObjectUtil.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664218);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664219);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664220);
		GameObjectUtil.NativeMethodInfoPtr_GetInterfaceInVisualAncestry_Public_Static_T_IList_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664221);
		GameObjectUtil.NativeMethodInfoPtr_IsVisualChildOf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664222);
		GameObjectUtil.NativeMethodInfoPtr_IsVisualParentOf_Public_Static_Boolean_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664223);
		GameObjectUtil.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664224);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestor_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664225);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664226);
		GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Component_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664227);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnAncestor_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664228);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnAncestorOrThrow_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664229);
		GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnParent_Public_Static_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664230);
		GameObjectUtil.NativeMethodInfoPtr_ToPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664231);
		GameObjectUtil.NativeMethodInfoPtr_TransformHierarchy_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664232);
		GameObjectUtil.NativeMethodInfoPtr_InstantiateWithDataComposition_Public_Static_SubscriptionProvider_SubscriptionProvider_Transform_DataComposition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664233);
		GameObjectUtil.NativeMethodInfoPtr_DestroyAllChildren_Public_Static_Void_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr, 100664234);
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0002B16C File Offset: 0x0002936C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 858198, RefRangeEnd = 858203, XrefRangeStart = 858192, XrefRangeEnd = 858198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOrThrow<T>(this Transform root) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0002B1AC File Offset: 0x000293AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858203, XrefRangeEnd = 858238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetGameObjectByPath(this Transform root, string path)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPath_Public_Static_GameObject_Transform_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0002B204 File Offset: 0x00029404
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858238, XrefRangeEnd = 858252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetGameObjectByPathOrThrow(this Transform root, string path)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPathOrThrow_Public_Static_GameObject_Transform_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060005CF RID: 1487 RVA: 0x0002B25C File Offset: 0x0002945C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858252, XrefRangeEnd = 858258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject GetGameObjectByPathOrSilence(this Transform root, string path)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_GetGameObjectByPathOrSilence_Public_Static_GameObject_Transform_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0002B2B4 File Offset: 0x000294B4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 858266, RefRangeEnd = 858269, XrefRangeStart = 858258, XrefRangeEnd = 858266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Transform FindOrThrow(this Transform root, string path)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_FindOrThrow_Public_Static_Transform_Transform_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0002B30C File Offset: 0x0002950C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858269, XrefRangeEnd = 858293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentByPath<T>(this Transform root, string path) where T : Component
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentByPath_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0002B35C File Offset: 0x0002955C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858293, XrefRangeEnd = 858299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentByPathOrThrow<T>(this Transform root, string path) where T : Component
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentByPathOrThrow_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005D3 RID: 1491 RVA: 0x0002B3AC File Offset: 0x000295AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858299, XrefRangeEnd = 858306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentByPathOrSilence<T>(this Transform root, string path) where T : Component
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentByPathOrSilence_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005D4 RID: 1492 RVA: 0x0002B3FC File Offset: 0x000295FC
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 858333, RefRangeEnd = 858341, XrefRangeStart = 858306, XrefRangeEnd = 858333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOrSilence<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOrSilence_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005D5 RID: 1493 RVA: 0x0002B43C File Offset: 0x0002963C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858341, XrefRangeEnd = 858346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceInChildren<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceInChildren_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005D6 RID: 1494 RVA: 0x0002B47C File Offset: 0x0002967C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858386, RefRangeEnd = 858387, XrefRangeStart = 858346, XrefRangeEnd = 858386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceInChildren<T>(this Transform root, bool includeSelf) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeSelf;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceInChildren_Public_Static_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005D7 RID: 1495 RVA: 0x0002B4C8 File Offset: 0x000296C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858387, XrefRangeEnd = 858395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> GetMonoInterfaces<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaces_Public_Static_List_1_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}
	}

	// Token: 0x060005D8 RID: 1496 RVA: 0x0002B50C File Offset: 0x0002970C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858428, RefRangeEnd = 858429, XrefRangeStart = 858395, XrefRangeEnd = 858428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMonoInterfaces<T>(this Transform root, List<T> results) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaces_Public_Static_Void_Transform_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005D9 RID: 1497 RVA: 0x0002B554 File Offset: 0x00029754
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858445, RefRangeEnd = 858447, XrefRangeStart = 858429, XrefRangeEnd = 858445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> GetMonoInterfacesInScene<T>() where T : class
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfacesInScene_Public_Static_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
	}

	// Token: 0x060005DA RID: 1498 RVA: 0x0002B588 File Offset: 0x00029788
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858447, XrefRangeEnd = 858455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> GetMonoInterfacesInChildren<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfacesInChildren_Public_Static_List_1_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}
	}

	// Token: 0x060005DB RID: 1499 RVA: 0x0002B5CC File Offset: 0x000297CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858493, RefRangeEnd = 858494, XrefRangeStart = 858455, XrefRangeEnd = 858493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMonoInterfacesInChildren<T>(this Transform root, bool includeSelf, bool includeInactive, List<T> results) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeSelf;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfacesInChildren_Public_Static_Void_Transform_Boolean_Boolean_List_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0002B630 File Offset: 0x00029830
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 858521, RefRangeEnd = 858529, XrefRangeStart = 858494, XrefRangeEnd = 858521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterface<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0002B670 File Offset: 0x00029870
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 858536, RefRangeEnd = 858539, XrefRangeStart = 858529, XrefRangeEnd = 858536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterface<T>(this GameObject root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0002B6B0 File Offset: 0x000298B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858546, RefRangeEnd = 858547, XrefRangeStart = 858539, XrefRangeEnd = 858546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterface<T>(this Component root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005DF RID: 1503 RVA: 0x0002B6F0 File Offset: 0x000298F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858552, RefRangeEnd = 858553, XrefRangeStart = 858547, XrefRangeEnd = 858552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOrThrow<T>(this Transform root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005E0 RID: 1504 RVA: 0x0002B730 File Offset: 0x00029930
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858553, XrefRangeEnd = 858573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceByPath<T>(this Transform transform, string path) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceByPath_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005E1 RID: 1505 RVA: 0x0002B780 File Offset: 0x00029980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858573, XrefRangeEnd = 858586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceByPathOrThrow<T>(this Transform transform, string path) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceByPathOrThrow_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x0002B7D0 File Offset: 0x000299D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858586, XrefRangeEnd = 858596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceByPathOrSilence<T>(this Transform transform, string path) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceByPathOrSilence_Public_Static_T_Transform_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x0002B820 File Offset: 0x00029A20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858596, XrefRangeEnd = 858603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOrThrow<T>(this GameObject root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x0002B860 File Offset: 0x00029A60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858603, XrefRangeEnd = 858610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOrThrow<T>(this Component root) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005E5 RID: 1509 RVA: 0x0002B8A0 File Offset: 0x00029AA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858610, XrefRangeEnd = 858618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMonoInterfaceOrThrow<T>(this Component root, out T component) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_Void_Component_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
	}

	// Token: 0x060005E6 RID: 1510 RVA: 0x0002B924 File Offset: 0x00029B24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858618, XrefRangeEnd = 858632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Instantiate<T>(T prototype) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = prototype;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref prototype;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x0002B998 File Offset: 0x00029B98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858632, XrefRangeEnd = 858637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Instantiate<T>(T prototype, Transform parent) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = prototype;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref prototype;
			}
			ptr2 = intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x0002BA20 File Offset: 0x00029C20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 858692, RefRangeEnd = 858695, XrefRangeStart = 858637, XrefRangeEnd = 858692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T InstantiateAndZero<T>(T prototype, Transform parent, bool autoMatchRectSizeDeltas = true) where T : class
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = prototype;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref prototype;
			}
			ptr2 = intPtr;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoMatchRectSizeDeltas;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_InstantiateAndZero_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x0002BAB4 File Offset: 0x00029CB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858695, XrefRangeEnd = 858714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateResource(string path)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_InstantiateResource_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x0002BAF8 File Offset: 0x00029CF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858714, XrefRangeEnd = 858740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject InstantiateResourceOrThrow(string path)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceOrThrow_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x0002BB3C File Offset: 0x00029D3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858740, XrefRangeEnd = 858749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T InstantiateResourceAs<T>(string resourceName) where T : MonoBehaviour
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x0002BB7C File Offset: 0x00029D7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858749, XrefRangeEnd = 858756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T InstantiateResourceAs<T>(string resourceName, Vector3 pos) where T : MonoBehaviour
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_Vector3_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x0002BBC8 File Offset: 0x00029DC8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858775, RefRangeEnd = 858777, XrefRangeStart = 858756, XrefRangeEnd = 858775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T InstantiateResourceAs<T>(string resourceName, Vector3 pos, Quaternion rot) where T : MonoBehaviour
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x0002BC24 File Offset: 0x00029E24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858777, XrefRangeEnd = 858789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentForced<T>(this Transform transform) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x0002BC64 File Offset: 0x00029E64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentForced<T>(this Component component) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x0002BCA4 File Offset: 0x00029EA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858789, XrefRangeEnd = 858807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetComponentForced<T>(this Component component, out T retval) where T : Component
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		IntPtr intPtr2;
		if (!typeof(T).IsValueType)
		{
			intPtr = 0;
			intPtr2 = &intPtr;
		}
		else
		{
			intPtr2 = ref retval;
		}
		ptr2 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentForced_Public_Static_Void_Component_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			retval = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0002BD28 File Offset: 0x00029F28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858814, RefRangeEnd = 858815, XrefRangeStart = 858807, XrefRangeEnd = 858814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentForced<T>(this GameObject go) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x0002BD68 File Offset: 0x00029F68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858815, XrefRangeEnd = 858822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Component GetComponentForced(this Component obj, Type type)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_Component_Component_Type_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0002BDC0 File Offset: 0x00029FC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858822, XrefRangeEnd = 858840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentWithLogging<T>(this GameObject go) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentWithLogging_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0002BE00 File Offset: 0x0002A000
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 858845, RefRangeEnd = 858852, XrefRangeStart = 858840, XrefRangeEnd = 858845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOrThrow<T>(this GameObject go)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0002BE40 File Offset: 0x0002A040
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 858866, RefRangeEnd = 858879, XrefRangeStart = 858852, XrefRangeEnd = 858866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOrThrow<T>(this Component root)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_Component_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0002BE80 File Offset: 0x0002A080
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858895, RefRangeEnd = 858896, XrefRangeStart = 858879, XrefRangeEnd = 858895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetComponentOrThrow<T>(this Component root, out T component)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_Void_Component_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x0002BF04 File Offset: 0x0002A104
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858896, XrefRangeEnd = 858903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetComponentOrThrow<T>(this GameObject go, out T component)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_Void_GameObject_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0002BF88 File Offset: 0x0002A188
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858903, XrefRangeEnd = 858921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentInChildrenOrThrow<T>(this GameObject go) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentInChildrenOrThrow_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858921, XrefRangeEnd = 858929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasAncestor(this Transform transform, Transform ancestor)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_HasAncestor_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0002C01C File Offset: 0x0002A21C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858929, XrefRangeEnd = 858935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(this Transform obj, int layer)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_Transform_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0002C060 File Offset: 0x0002A260
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858960, RefRangeEnd = 858962, XrefRangeStart = 858935, XrefRangeEnd = 858960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively(this GameObject obj, int layer)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858962, XrefRangeEnd = 859007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T FindOrCreateComponentObject<T>(string objectPath) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_FindOrCreateComponentObject_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0002C0E4 File Offset: 0x0002A2E4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 859016, RefRangeEnd = 859022, XrefRangeStart = 859007, XrefRangeEnd = 859016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ToIdentityTransform(this Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ToIdentityTransform_Public_Static_Void_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x0002C11C File Offset: 0x0002A31C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859022, XrefRangeEnd = 859033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentToAndZeroPosition(this GameObject gameObject, Transform newParent)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_GameObject_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x0002C164 File Offset: 0x0002A364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859033, XrefRangeEnd = 859040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentToAndZeroPosition(this Transform transform, Transform newParent)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0002C1AC File Offset: 0x0002A3AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859040, XrefRangeEnd = 859046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentToAndZero(this GameObject gameObject, Transform newParent, bool autoMatchRectSizeDeltas = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoMatchRectSizeDeltas;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_GameObject_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0002C204 File Offset: 0x0002A404
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859062, RefRangeEnd = 859064, XrefRangeStart = 859046, XrefRangeEnd = 859062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentToAndZero(this Transform transform, Transform newParent, bool autoMatchRectSizeDeltas = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoMatchRectSizeDeltas;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Transform_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0002C25C File Offset: 0x0002A45C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859064, XrefRangeEnd = 859070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParentToAndZero(this Component component, Transform newParent, bool autoMatchRectSizeDeltas = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoMatchRectSizeDeltas;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Component_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0002C2B4 File Offset: 0x0002A4B4
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 859075, RefRangeEnd = 859089, XrefRangeStart = 859070, XrefRangeEnd = 859075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Exists(this global::Il2CppSystem.Object obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_Exists_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859089, XrefRangeEnd = 859118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentInVisualAncestry<T>(Transform transform) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentInVisualAncestry_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0002C338 File Offset: 0x0002A538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859118, XrefRangeEnd = 859134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentInVisualAncestry<T>(IList<Transform> hierarchy) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hierarchy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentInVisualAncestry_Public_Static_T_IList_1_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x0002C378 File Offset: 0x0002A578
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859134, XrefRangeEnd = 859146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetInterfaceInVisualAncestry<T>(IList<Transform> hierarchy) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hierarchy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetInterfaceInVisualAncestry_Public_Static_T_IList_1_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859186, RefRangeEnd = 859187, XrefRangeStart = 859146, XrefRangeEnd = 859186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisualChildOf(this Transform child, Transform parent)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_IsVisualChildOf_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x0002C40C File Offset: 0x0002A60C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859187, XrefRangeEnd = 859191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisualParentOf(this Transform parent, Transform child)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(child);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_IsVisualParentOf_Public_Static_Boolean_Transform_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0002C460 File Offset: 0x0002A660
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859201, RefRangeEnd = 859202, XrefRangeStart = 859191, XrefRangeEnd = 859201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy(global::UnityEngine.Object gameObject)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0002C498 File Offset: 0x0002A698
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859216, RefRangeEnd = 859218, XrefRangeStart = 859202, XrefRangeEnd = 859216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOnAncestor<T>(Transform transform) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOnAncestor_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859218, XrefRangeEnd = 859227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOnAncestorOrThrow<T>(Transform transform) where T : Component
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOnAncestorOrThrow_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0002C518 File Offset: 0x0002A718
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859241, RefRangeEnd = 859243, XrefRangeStart = 859227, XrefRangeEnd = 859241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetComponentOnAncestorOrThrow<T>(Component root, out T retval) where T : Component
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		IntPtr intPtr2;
		if (!typeof(T).IsValueType)
		{
			intPtr = 0;
			intPtr2 = &intPtr;
		}
		else
		{
			intPtr2 = ref retval;
		}
		ptr2 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetComponentOnAncestorOrThrow_Public_Static_T_Component_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr5 = intPtr;
			retval = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		}
		return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859256, RefRangeEnd = 859257, XrefRangeStart = 859243, XrefRangeEnd = 859256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOnAncestor<T>(Transform transform) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOnAncestor_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0002C5E8 File Offset: 0x0002A7E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859257, XrefRangeEnd = 859262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOnAncestorOrThrow<T>(Transform transform) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOnAncestorOrThrow_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0002C628 File Offset: 0x0002A828
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859262, XrefRangeEnd = 859267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetMonoInterfaceOnParent<T>(Transform transform) where T : class
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.MethodInfoStoreGeneric_GetMonoInterfaceOnParent_Public_Static_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0002C668 File Offset: 0x0002A868
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 859283, RefRangeEnd = 859285, XrefRangeStart = 859267, XrefRangeEnd = 859283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToPath(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_ToPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0002C6A4 File Offset: 0x0002A8A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859300, RefRangeEnd = 859301, XrefRangeStart = 859285, XrefRangeEnd = 859300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TransformHierarchy(Transform transform)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_TransformHierarchy_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0002C6E0 File Offset: 0x0002A8E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859301, XrefRangeEnd = 859325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SubscriptionProvider InstantiateWithDataComposition(this SubscriptionProvider prefab, Transform parent, DataComposition data, bool autoMatchRectSizeDeltas = true)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoMatchRectSizeDeltas;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_InstantiateWithDataComposition_Public_Static_SubscriptionProvider_SubscriptionProvider_Transform_DataComposition_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr3) : null;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0002C758 File Offset: 0x0002A958
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 859335, RefRangeEnd = 859340, XrefRangeStart = 859325, XrefRangeEnd = 859335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyAllChildren(this Transform parentTransform, List<Transform> exceptions = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentTransform);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectUtil.NativeMethodInfoPtr_DestroyAllChildren_Public_Static_Void_Transform_List_1_Transform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x00003FD7 File Offset: 0x000021D7
	public GameObjectUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000615 RID: 1557 RVA: 0x0002C7A0 File Offset: 0x0002A9A0
	// (set) Token: 0x06000616 RID: 1558 RVA: 0x00003FE0 File Offset: 0x000021E0
	public unsafe static List<MonoBehaviour> cachedGetMonoInterfaceOrSilence
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceOrSilence, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBehaviour>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceOrSilence, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000617 RID: 1559 RVA: 0x0002C7C8 File Offset: 0x0002A9C8
	// (set) Token: 0x06000618 RID: 1560 RVA: 0x00003FF2 File Offset: 0x000021F2
	public unsafe static List<MonoBehaviour> cachedGetMonoInterfaceInChildren
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceInChildren, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBehaviour>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaceInChildren, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000619 RID: 1561 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
	// (set) Token: 0x0600061A RID: 1562 RVA: 0x00004004 File Offset: 0x00002204
	public unsafe static List<MonoBehaviour> cachedGetMonoInterfaces
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaces, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBehaviour>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfaces, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600061B RID: 1563 RVA: 0x0002C818 File Offset: 0x0002AA18
	// (set) Token: 0x0600061C RID: 1564 RVA: 0x00004016 File Offset: 0x00002216
	public unsafe static List<MonoBehaviour> cachedGetMonoInterfacesInChildren
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfacesInChildren, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBehaviour>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterfacesInChildren, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A7 RID: 423
	// (get) Token: 0x0600061D RID: 1565 RVA: 0x0002C840 File Offset: 0x0002AA40
	// (set) Token: 0x0600061E RID: 1566 RVA: 0x00004028 File Offset: 0x00002228
	public unsafe static List<MonoBehaviour> cachedGetMonoInterface
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterface, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBehaviour>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedGetMonoInterface, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600061F RID: 1567 RVA: 0x0002C868 File Offset: 0x0002AA68
	// (set) Token: 0x06000620 RID: 1568 RVA: 0x0000403A File Offset: 0x0000223A
	public unsafe static List<Transform> cachedTransformHierarchy
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GameObjectUtil.NativeFieldInfoPtr_cachedTransformHierarchy, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GameObjectUtil.NativeFieldInfoPtr_cachedTransformHierarchy, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000457 RID: 1111
	private static readonly IntPtr NativeFieldInfoPtr_cachedGetMonoInterfaceOrSilence;

	// Token: 0x04000458 RID: 1112
	private static readonly IntPtr NativeFieldInfoPtr_cachedGetMonoInterfaceInChildren;

	// Token: 0x04000459 RID: 1113
	private static readonly IntPtr NativeFieldInfoPtr_cachedGetMonoInterfaces;

	// Token: 0x0400045A RID: 1114
	private static readonly IntPtr NativeFieldInfoPtr_cachedGetMonoInterfacesInChildren;

	// Token: 0x0400045B RID: 1115
	private static readonly IntPtr NativeFieldInfoPtr_cachedGetMonoInterface;

	// Token: 0x0400045C RID: 1116
	private static readonly IntPtr NativeFieldInfoPtr_cachedTransformHierarchy;

	// Token: 0x0400045D RID: 1117
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Transform_0;

	// Token: 0x0400045E RID: 1118
	private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectByPath_Public_Static_GameObject_Transform_String_0;

	// Token: 0x0400045F RID: 1119
	private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectByPathOrThrow_Public_Static_GameObject_Transform_String_0;

	// Token: 0x04000460 RID: 1120
	private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectByPathOrSilence_Public_Static_GameObject_Transform_String_0;

	// Token: 0x04000461 RID: 1121
	private static readonly IntPtr NativeMethodInfoPtr_FindOrThrow_Public_Static_Transform_Transform_String_0;

	// Token: 0x04000462 RID: 1122
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentByPath_Public_Static_T_Transform_String_0;

	// Token: 0x04000463 RID: 1123
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentByPathOrThrow_Public_Static_T_Transform_String_0;

	// Token: 0x04000464 RID: 1124
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentByPathOrSilence_Public_Static_T_Transform_String_0;

	// Token: 0x04000465 RID: 1125
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOrSilence_Public_Static_T_Transform_0;

	// Token: 0x04000466 RID: 1126
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_0;

	// Token: 0x04000467 RID: 1127
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_Boolean_0;

	// Token: 0x04000468 RID: 1128
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_List_1_T_Transform_0;

	// Token: 0x04000469 RID: 1129
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_Void_Transform_List_1_T_0;

	// Token: 0x0400046A RID: 1130
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfacesInScene_Public_Static_List_1_T_0;

	// Token: 0x0400046B RID: 1131
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_List_1_T_Transform_0;

	// Token: 0x0400046C RID: 1132
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_Void_Transform_Boolean_Boolean_List_1_T_0;

	// Token: 0x0400046D RID: 1133
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Transform_0;

	// Token: 0x0400046E RID: 1134
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_GameObject_0;

	// Token: 0x0400046F RID: 1135
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Component_0;

	// Token: 0x04000470 RID: 1136
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Transform_0;

	// Token: 0x04000471 RID: 1137
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceByPath_Public_Static_T_Transform_String_0;

	// Token: 0x04000472 RID: 1138
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceByPathOrThrow_Public_Static_T_Transform_String_0;

	// Token: 0x04000473 RID: 1139
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceByPathOrSilence_Public_Static_T_Transform_String_0;

	// Token: 0x04000474 RID: 1140
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_GameObject_0;

	// Token: 0x04000475 RID: 1141
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Component_0;

	// Token: 0x04000476 RID: 1142
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_Void_Component_byref_T_0;

	// Token: 0x04000477 RID: 1143
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

	// Token: 0x04000478 RID: 1144
	private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0;

	// Token: 0x04000479 RID: 1145
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateAndZero_Public_Static_T_T_Transform_Boolean_0;

	// Token: 0x0400047A RID: 1146
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateResource_Public_Static_GameObject_String_0;

	// Token: 0x0400047B RID: 1147
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateResourceOrThrow_Public_Static_GameObject_String_0;

	// Token: 0x0400047C RID: 1148
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_0;

	// Token: 0x0400047D RID: 1149
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_0;

	// Token: 0x0400047E RID: 1150
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_Quaternion_0;

	// Token: 0x0400047F RID: 1151
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Transform_0;

	// Token: 0x04000480 RID: 1152
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Component_0;

	// Token: 0x04000481 RID: 1153
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentForced_Public_Static_Void_Component_byref_T_0;

	// Token: 0x04000482 RID: 1154
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentForced_Public_Static_T_GameObject_0;

	// Token: 0x04000483 RID: 1155
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentForced_Public_Static_Component_Component_Type_0;

	// Token: 0x04000484 RID: 1156
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentWithLogging_Public_Static_T_GameObject_0;

	// Token: 0x04000485 RID: 1157
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_GameObject_0;

	// Token: 0x04000486 RID: 1158
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Component_0;

	// Token: 0x04000487 RID: 1159
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_Component_byref_T_0;

	// Token: 0x04000488 RID: 1160
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_GameObject_byref_T_0;

	// Token: 0x04000489 RID: 1161
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildrenOrThrow_Public_Static_T_GameObject_0;

	// Token: 0x0400048A RID: 1162
	private static readonly IntPtr NativeMethodInfoPtr_HasAncestor_Public_Static_Boolean_Transform_Transform_0;

	// Token: 0x0400048B RID: 1163
	private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_Transform_Int32_0;

	// Token: 0x0400048C RID: 1164
	private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

	// Token: 0x0400048D RID: 1165
	private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateComponentObject_Public_Static_T_String_0;

	// Token: 0x0400048E RID: 1166
	private static readonly IntPtr NativeMethodInfoPtr_ToIdentityTransform_Public_Static_Void_Transform_0;

	// Token: 0x0400048F RID: 1167
	private static readonly IntPtr NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_GameObject_Transform_0;

	// Token: 0x04000490 RID: 1168
	private static readonly IntPtr NativeMethodInfoPtr_ParentToAndZeroPosition_Public_Static_Void_Transform_Transform_0;

	// Token: 0x04000491 RID: 1169
	private static readonly IntPtr NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_GameObject_Transform_Boolean_0;

	// Token: 0x04000492 RID: 1170
	private static readonly IntPtr NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Transform_Transform_Boolean_0;

	// Token: 0x04000493 RID: 1171
	private static readonly IntPtr NativeMethodInfoPtr_ParentToAndZero_Public_Static_Void_Component_Transform_Boolean_0;

	// Token: 0x04000494 RID: 1172
	private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_Object_0;

	// Token: 0x04000495 RID: 1173
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_Transform_0;

	// Token: 0x04000496 RID: 1174
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_IList_1_Transform_0;

	// Token: 0x04000497 RID: 1175
	private static readonly IntPtr NativeMethodInfoPtr_GetInterfaceInVisualAncestry_Public_Static_T_IList_1_Transform_0;

	// Token: 0x04000498 RID: 1176
	private static readonly IntPtr NativeMethodInfoPtr_IsVisualChildOf_Public_Static_Boolean_Transform_Transform_0;

	// Token: 0x04000499 RID: 1177
	private static readonly IntPtr NativeMethodInfoPtr_IsVisualParentOf_Public_Static_Boolean_Transform_Transform_0;

	// Token: 0x0400049A RID: 1178
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

	// Token: 0x0400049B RID: 1179
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOnAncestor_Public_Static_T_Transform_0;

	// Token: 0x0400049C RID: 1180
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Transform_0;

	// Token: 0x0400049D RID: 1181
	private static readonly IntPtr NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Component_byref_T_0;

	// Token: 0x0400049E RID: 1182
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOnAncestor_Public_Static_T_Transform_0;

	// Token: 0x0400049F RID: 1183
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOnAncestorOrThrow_Public_Static_T_Transform_0;

	// Token: 0x040004A0 RID: 1184
	private static readonly IntPtr NativeMethodInfoPtr_GetMonoInterfaceOnParent_Public_Static_T_Transform_0;

	// Token: 0x040004A1 RID: 1185
	private static readonly IntPtr NativeMethodInfoPtr_ToPath_Public_Static_String_Transform_0;

	// Token: 0x040004A2 RID: 1186
	private static readonly IntPtr NativeMethodInfoPtr_TransformHierarchy_Public_Static_String_Transform_0;

	// Token: 0x040004A3 RID: 1187
	private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithDataComposition_Public_Static_SubscriptionProvider_SubscriptionProvider_Transform_DataComposition_Boolean_0;

	// Token: 0x040004A4 RID: 1188
	private static readonly IntPtr NativeMethodInfoPtr_DestroyAllChildren_Public_Static_Void_Transform_List_1_Transform_0;

	// Token: 0x02000248 RID: 584
	private sealed class MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001561 RID: 5473
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000249 RID: 585
	private sealed class MethodInfoStoreGeneric_GetComponentByPath_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001562 RID: 5474
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentByPath_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024A RID: 586
	private sealed class MethodInfoStoreGeneric_GetComponentByPathOrThrow_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001563 RID: 5475
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentByPathOrThrow_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024B RID: 587
	private sealed class MethodInfoStoreGeneric_GetComponentByPathOrSilence_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001564 RID: 5476
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentByPathOrSilence_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024C RID: 588
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOrSilence_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001565 RID: 5477
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrSilence_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024D RID: 589
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceInChildren_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001566 RID: 5478
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024E RID: 590
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceInChildren_Public_Static_T_Transform_Boolean_0<T>
	{
		// Token: 0x04001567 RID: 5479
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceInChildren_Public_Static_T_Transform_Boolean_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200024F RID: 591
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaces_Public_Static_List_1_T_Transform_0<T>
	{
		// Token: 0x04001568 RID: 5480
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_List_1_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000250 RID: 592
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaces_Public_Static_Void_Transform_List_1_T_0<T>
	{
		// Token: 0x04001569 RID: 5481
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaces_Public_Static_Void_Transform_List_1_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000251 RID: 593
	private sealed class MethodInfoStoreGeneric_GetMonoInterfacesInScene_Public_Static_List_1_T_0<T>
	{
		// Token: 0x0400156A RID: 5482
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInScene_Public_Static_List_1_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000252 RID: 594
	private sealed class MethodInfoStoreGeneric_GetMonoInterfacesInChildren_Public_Static_List_1_T_Transform_0<T>
	{
		// Token: 0x0400156B RID: 5483
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_List_1_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000253 RID: 595
	private sealed class MethodInfoStoreGeneric_GetMonoInterfacesInChildren_Public_Static_Void_Transform_Boolean_Boolean_List_1_T_0<T>
	{
		// Token: 0x0400156C RID: 5484
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfacesInChildren_Public_Static_Void_Transform_Boolean_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000254 RID: 596
	private sealed class MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400156D RID: 5485
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000255 RID: 597
	private sealed class MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x0400156E RID: 5486
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000256 RID: 598
	private sealed class MethodInfoStoreGeneric_GetMonoInterface_Public_Static_T_Component_0<T>
	{
		// Token: 0x0400156F RID: 5487
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterface_Public_Static_T_Component_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000257 RID: 599
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001570 RID: 5488
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000258 RID: 600
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceByPath_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001571 RID: 5489
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPath_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000259 RID: 601
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceByPathOrThrow_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001572 RID: 5490
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPathOrThrow_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025A RID: 602
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceByPathOrSilence_Public_Static_T_Transform_String_0<T>
	{
		// Token: 0x04001573 RID: 5491
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceByPathOrSilence_Public_Static_T_Transform_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025B RID: 603
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001574 RID: 5492
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025C RID: 604
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_T_Component_0<T>
	{
		// Token: 0x04001575 RID: 5493
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_T_Component_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025D RID: 605
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOrThrow_Public_Static_Void_Component_byref_T_0<T>
	{
		// Token: 0x04001576 RID: 5494
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOrThrow_Public_Static_Void_Component_byref_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025E RID: 606
	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
	{
		// Token: 0x04001577 RID: 5495
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200025F RID: 607
	private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>
	{
		// Token: 0x04001578 RID: 5496
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000260 RID: 608
	private sealed class MethodInfoStoreGeneric_InstantiateAndZero_Public_Static_T_T_Transform_Boolean_0<T>
	{
		// Token: 0x04001579 RID: 5497
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_InstantiateAndZero_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000261 RID: 609
	private sealed class MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_0<T>
	{
		// Token: 0x0400157A RID: 5498
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000262 RID: 610
	private sealed class MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_Vector3_0<T>
	{
		// Token: 0x0400157B RID: 5499
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000263 RID: 611
	private sealed class MethodInfoStoreGeneric_InstantiateResourceAs_Public_Static_T_String_Vector3_Quaternion_0<T>
	{
		// Token: 0x0400157C RID: 5500
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_InstantiateResourceAs_Public_Static_T_String_Vector3_Quaternion_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000264 RID: 612
	private sealed class MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400157D RID: 5501
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000265 RID: 613
	private sealed class MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_Component_0<T>
	{
		// Token: 0x0400157E RID: 5502
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_Component_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000266 RID: 614
	private sealed class MethodInfoStoreGeneric_GetComponentForced_Public_Static_Void_Component_byref_T_0<T>
	{
		// Token: 0x0400157F RID: 5503
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_Void_Component_byref_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000267 RID: 615
	private sealed class MethodInfoStoreGeneric_GetComponentForced_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001580 RID: 5504
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentForced_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000268 RID: 616
	private sealed class MethodInfoStoreGeneric_GetComponentWithLogging_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001581 RID: 5505
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentWithLogging_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000269 RID: 617
	private sealed class MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001582 RID: 5506
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026A RID: 618
	private sealed class MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_T_Component_0<T>
	{
		// Token: 0x04001583 RID: 5507
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_T_Component_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026B RID: 619
	private sealed class MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_Void_Component_byref_T_0<T>
	{
		// Token: 0x04001584 RID: 5508
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_Component_byref_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026C RID: 620
	private sealed class MethodInfoStoreGeneric_GetComponentOrThrow_Public_Static_Void_GameObject_byref_T_0<T>
	{
		// Token: 0x04001585 RID: 5509
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOrThrow_Public_Static_Void_GameObject_byref_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026D RID: 621
	private sealed class MethodInfoStoreGeneric_GetComponentInChildrenOrThrow_Public_Static_T_GameObject_0<T>
	{
		// Token: 0x04001586 RID: 5510
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentInChildrenOrThrow_Public_Static_T_GameObject_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026E RID: 622
	private sealed class MethodInfoStoreGeneric_FindOrCreateComponentObject_Public_Static_T_String_0<T>
	{
		// Token: 0x04001587 RID: 5511
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_FindOrCreateComponentObject_Public_Static_T_String_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x0200026F RID: 623
	private sealed class MethodInfoStoreGeneric_GetComponentInVisualAncestry_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001588 RID: 5512
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000270 RID: 624
	private sealed class MethodInfoStoreGeneric_GetComponentInVisualAncestry_Public_Static_T_IList_1_Transform_0<T>
	{
		// Token: 0x04001589 RID: 5513
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentInVisualAncestry_Public_Static_T_IList_1_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000271 RID: 625
	private sealed class MethodInfoStoreGeneric_GetInterfaceInVisualAncestry_Public_Static_T_IList_1_Transform_0<T>
	{
		// Token: 0x0400158A RID: 5514
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetInterfaceInVisualAncestry_Public_Static_T_IList_1_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000272 RID: 626
	private sealed class MethodInfoStoreGeneric_GetComponentOnAncestor_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400158B RID: 5515
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestor_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000273 RID: 627
	private sealed class MethodInfoStoreGeneric_GetComponentOnAncestorOrThrow_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400158C RID: 5516
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000274 RID: 628
	private sealed class MethodInfoStoreGeneric_GetComponentOnAncestorOrThrow_Public_Static_T_Component_byref_T_0<T>
	{
		// Token: 0x0400158D RID: 5517
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetComponentOnAncestorOrThrow_Public_Static_T_Component_byref_T_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000275 RID: 629
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOnAncestor_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400158E RID: 5518
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnAncestor_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000276 RID: 630
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOnAncestorOrThrow_Public_Static_T_Transform_0<T>
	{
		// Token: 0x0400158F RID: 5519
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnAncestorOrThrow_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	// Token: 0x02000277 RID: 631
	private sealed class MethodInfoStoreGeneric_GetMonoInterfaceOnParent_Public_Static_T_Transform_0<T>
	{
		// Token: 0x04001590 RID: 5520
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectUtil.NativeMethodInfoPtr_GetMonoInterfaceOnParent_Public_Static_T_Transform_0, Il2CppClassPointerStore<GameObjectUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}

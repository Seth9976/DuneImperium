using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001BD RID: 445
	[Serializable]
	[StructLayout(2)]
	public struct Scene
	{
		// Token: 0x06002043 RID: 8259 RVA: 0x0008F98C File Offset: 0x0008DB8C
		// Note: this type is marked as 'beforefieldinit'.
		static Scene()
		{
			Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "Scene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
			Scene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, "m_Handle");
			Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667681);
			Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667682);
			Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667683);
			Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667684);
			Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667685);
			Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667686);
			Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667687);
			Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667688);
			Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667689);
			Scene.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667690);
			Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667691);
			Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667692);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667693);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667694);
			Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667695);
			Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667696);
			Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667697);
			Scene.GetPathInternalDelegateField = IL2CPP.ResolveICall<Scene.GetPathInternalDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal");
			Scene.SetPathAndGUIDInternalDelegateField = IL2CPP.ResolveICall<Scene.SetPathAndGUIDInternalDelegate>("UnityEngine.SceneManagement.Scene::SetPathAndGUIDInternal");
			Scene.SetNameInternalDelegateField = IL2CPP.ResolveICall<Scene.SetNameInternalDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal");
			Scene.IsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
			Scene.SetIsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
			Scene.GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<Scene.GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
			Scene.GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<Scene.GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
			Scene.GetDirtyIDDelegateField = IL2CPP.ResolveICall<Scene.GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
			Scene.GetBuildIndexInternalDelegateField = IL2CPP.ResolveICall<Scene.GetBuildIndexInternalDelegate>("UnityEngine.SceneManagement.Scene::GetBuildIndexInternal");
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0008FBAC File Offset: 0x0008DDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680060, XrefRangeEnd = 680062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0008FBEC File Offset: 0x0008DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680062, XrefRangeEnd = 680064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0008FC24 File Offset: 0x0008DE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680064, XrefRangeEnd = 680066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGUIDInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x0008FC5C File Offset: 0x0008DE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680066, XrefRangeEnd = 680068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsLoadedInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0008FC9C File Offset: 0x0008DE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680068, XrefRangeEnd = 680070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootCountInternal(int sceneHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680070, XrefRangeEnd = 680072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootGameObjectsInternal(int sceneHandle, Object resultRootList)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sceneHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultRootList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x0008FD20 File Offset: 0x0008DF20
		public unsafe int handle
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0008FD50 File Offset: 0x0008DF50
		public unsafe string guid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680072, XrefRangeEnd = 680074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0008FD7C File Offset: 0x0008DF7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680076, RefRangeEnd = 680077, XrefRangeStart = 680074, XrefRangeEnd = 680076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0008FDAC File Offset: 0x0008DFAC
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x0000C4E3 File Offset: 0x0000A6E3
		public unsafe string name
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 680079, RefRangeEnd = 680091, XrefRangeStart = 680077, XrefRangeEnd = 680079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
		public unsafe bool isLoaded
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 680093, RefRangeEnd = 680096, XrefRangeStart = 680091, XrefRangeEnd = 680093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0008FE08 File Offset: 0x0008E008
		public unsafe int rootCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680096, XrefRangeEnd = 680098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0008FE38 File Offset: 0x0008E038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680098, XrefRangeEnd = 680111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<GameObject> GetRootGameObjects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0008FE6C File Offset: 0x0008E06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680135, RefRangeEnd = 680136, XrefRangeStart = 680111, XrefRangeEnd = 680135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootGameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0008FEA4 File Offset: 0x0008E0A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 323148, RefRangeEnd = 323154, XrefRangeStart = 323148, XrefRangeEnd = 323154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Scene lhs, Scene rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0008FEF0 File Offset: 0x0008E0F0
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0008FF20 File Offset: 0x0008E120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 680139, RefRangeEnd = 680140, XrefRangeStart = 680136, XrefRangeEnd = 680139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0000C456 File Offset: 0x0000A656
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, ref this));
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0008FF64 File Offset: 0x0008E164
		public static string GetPathInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetPathInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0000C468 File Offset: 0x0000A668
		public static void SetPathAndGUIDInternal(int sceneHandle, string path, string guid)
		{
			Scene.SetPathAndGUIDInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(path), IL2CPP.ManagedStringToIl2Cpp(guid));
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0000C481 File Offset: 0x0000A681
		public static void SetNameInternal(int sceneHandle, string name)
		{
			Scene.SetNameInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0000C494 File Offset: 0x0000A694
		public static bool IsSubScene(int sceneHandle)
		{
			return Scene.IsSubSceneDelegateField(sceneHandle);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
		public static void SetIsSubScene(int sceneHandle, bool value)
		{
			Scene.SetIsSubSceneDelegateField(sceneHandle, value);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0000C4AF File Offset: 0x0000A6AF
		public static Scene.LoadingState GetLoadingStateInternal(int sceneHandle)
		{
			return Scene.GetLoadingStateInternalDelegateField(sceneHandle);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0000C4BC File Offset: 0x0000A6BC
		public static bool GetIsDirtyInternal(int sceneHandle)
		{
			return Scene.GetIsDirtyInternalDelegateField(sceneHandle);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0000C4C9 File Offset: 0x0000A6C9
		public static int GetDirtyID(int sceneHandle)
		{
			return Scene.GetDirtyIDDelegateField(sceneHandle);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0000C4D6 File Offset: 0x0000A6D6
		public static int GetBuildIndexInternal(int sceneHandle)
		{
			return Scene.GetBuildIndexInternalDelegateField(sceneHandle);
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0008FF84 File Offset: 0x0008E184
		public Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0008FFA4 File Offset: 0x0008E1A4
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0008FFC4 File Offset: 0x0008E1C4
		public int buildIndex
		{
			get
			{
				return Scene.GetBuildIndexInternal(this.handle);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0008FFE4 File Offset: 0x0008E1E4
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x00090004 File Offset: 0x0008E204
		public int dirtyID
		{
			get
			{
				return Scene.GetDirtyID(this.handle);
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x00090024 File Offset: 0x0008E224
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x0000C4F3 File Offset: 0x0000A6F3
		public bool isSubScene
		{
			get
			{
				return Scene.IsSubScene(this.handle);
			}
			set
			{
				Scene.SetIsSubScene(this.handle, value);
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00090044 File Offset: 0x0008E244
		public static bool operator !=(Scene lhs, Scene rhs)
		{
			return lhs.handle != rhs.handle;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0000C503 File Offset: 0x0000A703
		public void SetPathAndGuid(string path, string guid)
		{
			Scene.SetPathAndGUIDInternal(this.m_Handle, path, guid);
		}

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0;

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeMethodInfoPtr_get_guid_Internal_get_String_0;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001BDA RID: 7130
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x04001BDB RID: 7131
		private static readonly Scene.GetPathInternalDelegate GetPathInternalDelegateField;

		// Token: 0x04001BDC RID: 7132
		private static readonly Scene.SetPathAndGUIDInternalDelegate SetPathAndGUIDInternalDelegateField;

		// Token: 0x04001BDD RID: 7133
		private static readonly Scene.SetNameInternalDelegate SetNameInternalDelegateField;

		// Token: 0x04001BDE RID: 7134
		private static readonly Scene.IsSubSceneDelegate IsSubSceneDelegateField;

		// Token: 0x04001BDF RID: 7135
		private static readonly Scene.SetIsSubSceneDelegate SetIsSubSceneDelegateField;

		// Token: 0x04001BE0 RID: 7136
		private static readonly Scene.GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;

		// Token: 0x04001BE1 RID: 7137
		private static readonly Scene.GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;

		// Token: 0x04001BE2 RID: 7138
		private static readonly Scene.GetDirtyIDDelegate GetDirtyIDDelegateField;

		// Token: 0x04001BE3 RID: 7139
		private static readonly Scene.GetBuildIndexInternalDelegate GetBuildIndexInternalDelegateField;

		// Token: 0x0200087E RID: 2174
		public enum LoadingState
		{
			// Token: 0x04002CF5 RID: 11509
			NotLoaded,
			// Token: 0x04002CF6 RID: 11510
			Loading,
			// Token: 0x04002CF7 RID: 11511
			Loaded,
			// Token: 0x04002CF8 RID: 11512
			Unloading
		}

		// Token: 0x0200087F RID: 2175
		// (Invoke) Token: 0x060039FD RID: 14845
		private delegate IntPtr GetPathInternalDelegate(int sceneHandle);

		// Token: 0x02000880 RID: 2176
		// (Invoke) Token: 0x060039FF RID: 14847
		private delegate void SetPathAndGUIDInternalDelegate(int sceneHandle, IntPtr path, IntPtr guid);

		// Token: 0x02000881 RID: 2177
		// (Invoke) Token: 0x06003A01 RID: 14849
		private delegate void SetNameInternalDelegate(int sceneHandle, IntPtr name);

		// Token: 0x02000882 RID: 2178
		// (Invoke) Token: 0x06003A03 RID: 14851
		private delegate bool IsSubSceneDelegate(int sceneHandle);

		// Token: 0x02000883 RID: 2179
		// (Invoke) Token: 0x06003A05 RID: 14853
		private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

		// Token: 0x02000884 RID: 2180
		// (Invoke) Token: 0x06003A07 RID: 14855
		private delegate Scene.LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

		// Token: 0x02000885 RID: 2181
		// (Invoke) Token: 0x06003A09 RID: 14857
		private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

		// Token: 0x02000886 RID: 2182
		// (Invoke) Token: 0x06003A0B RID: 14859
		private delegate int GetDirtyIDDelegate(int sceneHandle);

		// Token: 0x02000887 RID: 2183
		// (Invoke) Token: 0x06003A0D RID: 14861
		private delegate int GetBuildIndexInternalDelegate(int sceneHandle);
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace boardgames.menus.prompts
{
	// Token: 0x02000006 RID: 6
	public class IVignetteScenePrompt : Il2CppObjectBase
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000042EC File Offset: 0x000024EC
		// Note: this type is marked as 'beforefieldinit'.
		static IVignetteScenePrompt()
		{
			Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "boardgames.menus.prompts", "IVignetteScenePrompt");
			IVignetteScenePrompt.NativeMethodInfoPtr_get_SceneName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663303);
			IVignetteScenePrompt.NativeMethodInfoPtr_get_UnloadOnResolve_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663304);
			IVignetteScenePrompt.NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663305);
			IVignetteScenePrompt.NativeMethodInfoPtr_get_CameraAnimName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663306);
			IVignetteScenePrompt.NativeMethodInfoPtr_get_SceneLoaded_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663307);
			IVignetteScenePrompt.NativeMethodInfoPtr_set_SceneLoaded_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IVignetteScenePrompt>.NativeClassPtr, 100663308);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000438C File Offset: 0x0000258C
		public unsafe virtual string SceneName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_get_SceneName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000043D0 File Offset: 0x000025D0
		public unsafe virtual bool UnloadOnResolve
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_get_UnloadOnResolve_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00004418 File Offset: 0x00002618
		public unsafe virtual bool LoadAsActiveScene
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00004460 File Offset: 0x00002660
		public unsafe virtual string CameraAnimName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_get_CameraAnimName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000044A4 File Offset: 0x000026A4
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000044EC File Offset: 0x000026EC
		public unsafe virtual bool SceneLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_get_SceneLoaded_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IVignetteScenePrompt.NativeMethodInfoPtr_set_SceneLoaded_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E7 File Offset: 0x000002E7
		public IVignetteScenePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_UnloadOnResolve_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadAsActiveScene_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraAnimName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneLoaded_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneLoaded_Public_Abstract_Virtual_New_set_Void_Boolean_0;
	}
}

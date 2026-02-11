using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000280 RID: 640
	public static class ScriptableRuntimeReflectionSystemSettings : Object
	{
		// Token: 0x06002B7D RID: 11133 RVA: 0x000AFF64 File Offset: 0x000AE164
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemSettings()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, "s_Instance");
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668635);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668636);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668637);
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000B00B8 File Offset: 0x000AE2B8
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x000AFFE4 File Offset: 0x000AE1E4
		public unsafe static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.s_Instance.implementation;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686213, XrefRangeEnd = 686230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000B001C File Offset: 0x000AE21C
		public unsafe static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686230, XrefRangeEnd = 686234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr3) : null;
			}
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000B0050 File Offset: 0x000AE250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686234, XrefRangeEnd = 686244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScriptingDirtyReflectionSystemInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00010F9B File Offset: 0x0000F19B
		public ScriptableRuntimeReflectionSystemSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000B0078 File Offset: 0x000AE278
		// (set) Token: 0x06002B83 RID: 11139 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		public unsafe static ScriptableRuntimeReflectionSystemWrapper s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x000B00A0 File Offset: 0x000AE2A0
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00010FB6 File Offset: 0x0000F1B6
		public static IScriptableRuntimeReflectionSystem system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.Internal_ScriptableRuntimeReflectionSystemSettings_system;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0;
	}
}

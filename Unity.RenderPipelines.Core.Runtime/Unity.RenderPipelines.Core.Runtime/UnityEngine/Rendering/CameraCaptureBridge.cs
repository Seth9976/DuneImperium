using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x020000D0 RID: 208
	public static class CameraCaptureBridge : Object
	{
		// Token: 0x06000F2A RID: 3882 RVA: 0x00046284 File Offset: 0x00044484
		// Note: this type is marked as 'beforefieldinit'.
		static CameraCaptureBridge()
		{
			Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CameraCaptureBridge");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr);
			CameraCaptureBridge.NativeFieldInfoPtr_actionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, "actionDict");
			CameraCaptureBridge.NativeFieldInfoPtr__enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, "_enabled");
			CameraCaptureBridge.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100665526);
			CameraCaptureBridge.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100665527);
			CameraCaptureBridge.NativeMethodInfoPtr_GetCaptureActions_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100665528);
			CameraCaptureBridge.NativeMethodInfoPtr_AddCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100665529);
			CameraCaptureBridge.NativeMethodInfoPtr_RemoveCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraCaptureBridge>.NativeClassPtr, 100665530);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x00046340 File Offset: 0x00044540
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00046370 File Offset: 0x00044570
		public unsafe static bool enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975989, XrefRangeEnd = 975993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureBridge.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 975993, XrefRangeEnd = 975997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureBridge.NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000463A4 File Offset: 0x000445A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976011, RefRangeEnd = 976012, XrefRangeStart = 975997, XrefRangeEnd = 976011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> GetCaptureActions(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureBridge.NativeMethodInfoPtr_GetCaptureActions_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000463E8 File Offset: 0x000445E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976012, XrefRangeEnd = 976034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureBridge.NativeMethodInfoPtr_AddCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00046430 File Offset: 0x00044630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976034, XrefRangeEnd = 976048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveCaptureAction(Camera camera, Action<RenderTargetIdentifier, CommandBuffer> action)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraCaptureBridge.NativeMethodInfoPtr_RemoveCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00008505 File Offset: 0x00006705
		public CameraCaptureBridge(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00046478 File Offset: 0x00044678
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x0000850E File Offset: 0x0000670E
		public unsafe static Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>> actionDict
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraCaptureBridge.NativeFieldInfoPtr_actionDict, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Camera, HashSet<Action<RenderTargetIdentifier, CommandBuffer>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraCaptureBridge.NativeFieldInfoPtr_actionDict, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000464A0 File Offset: 0x000446A0
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00008520 File Offset: 0x00006720
		public unsafe static bool _enabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CameraCaptureBridge.NativeFieldInfoPtr__enabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraCaptureBridge.NativeFieldInfoPtr__enabled, (void*)(&value));
			}
		}

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeFieldInfoPtr_actionDict;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeFieldInfoPtr__enabled;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000B99 RID: 2969
		private static readonly IntPtr NativeMethodInfoPtr_GetCaptureActions_Public_Static_IEnumerator_1_Action_2_RenderTargetIdentifier_CommandBuffer_Camera_0;

		// Token: 0x04000B9A RID: 2970
		private static readonly IntPtr NativeMethodInfoPtr_AddCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0;

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCaptureAction_Public_Static_Void_Camera_Action_2_RenderTargetIdentifier_CommandBuffer_0;
	}
}

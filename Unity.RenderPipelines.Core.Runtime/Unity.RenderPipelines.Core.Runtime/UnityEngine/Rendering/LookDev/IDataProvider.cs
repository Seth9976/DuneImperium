using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.LookDev
{
	// Token: 0x0200011A RID: 282
	public class IDataProvider : Il2CppObjectBase
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x00053270 File Offset: 0x00051470
		// Note: this type is marked as 'beforefieldinit'.
		static IDataProvider()
		{
			Il2CppClassPointerStore<IDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.LookDev", "IDataProvider");
			IDataProvider.NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665984);
			IDataProvider.NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665985);
			IDataProvider.NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665986);
			IDataProvider.NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665987);
			IDataProvider.NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665988);
			IDataProvider.NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665989);
			IDataProvider.NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665990);
			IDataProvider.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDataProvider>.NativeClassPtr, 100665991);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00053338 File Offset: 0x00051538
		[CallerCount(0)]
		public unsafe virtual void FirstInitScene(StageRuntimeInterface stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00053388 File Offset: 0x00051588
		[CallerCount(0)]
		public unsafe virtual void UpdateSky(Camera camera, Sky sky, StageRuntimeInterface stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(sky));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00053400 File Offset: 0x00051600
		public unsafe virtual IEnumerable<string> supportedDebugModes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0005344C File Offset: 0x0005164C
		[CallerCount(0)]
		public unsafe virtual void UpdateDebugMode(int debugIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref debugIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00053498 File Offset: 0x00051698
		[CallerCount(0)]
		public unsafe virtual void GetShadowMask(ref RenderTexture output, StageRuntimeInterface stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(output);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stage);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			output = ((intPtr4 == 0) ? null : new RenderTexture(intPtr4));
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0005350C File Offset: 0x0005170C
		[CallerCount(0)]
		public unsafe virtual void OnBeginRendering(StageRuntimeInterface stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0005355C File Offset: 0x0005175C
		[CallerCount(0)]
		public unsafe virtual void OnEndRendering(StageRuntimeInterface stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x000535AC File Offset: 0x000517AC
		[CallerCount(0)]
		public unsafe virtual void Cleanup(StageRuntimeInterface SRI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(SRI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDataProvider.NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00009638 File Offset: 0x00007838
		public IDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_FirstInitScene_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSky_Public_Abstract_Virtual_New_Void_Camera_Sky_StageRuntimeInterface_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedDebugModes_Public_Abstract_Virtual_New_get_IEnumerable_1_String_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDebugMode_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowMask_Public_Abstract_Virtual_New_Void_byref_RenderTexture_StageRuntimeInterface_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_OnEndRendering_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Public_Abstract_Virtual_New_Void_StageRuntimeInterface_0;
	}
}

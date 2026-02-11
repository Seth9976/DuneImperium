using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.VFX
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class VFXSpawnerCallbacks : ScriptableObject
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00004498 File Offset: 0x00002698
		// Note: this type is marked as 'beforefieldinit'.
		static VFXSpawnerCallbacks()
		{
			Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXSpawnerCallbacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663313);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663314);
			VFXSpawnerCallbacks.NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663315);
			VFXSpawnerCallbacks.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr, 100663316);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004518 File Offset: 0x00002718
		[CallerCount(0)]
		public unsafe virtual void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000458C File Offset: 0x0000278C
		[CallerCount(0)]
		public unsafe virtual void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004600 File Offset: 0x00002800
		[CallerCount(0)]
		public unsafe virtual void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vfxComponent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXSpawnerCallbacks.NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004674 File Offset: 0x00002874
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXSpawnerCallbacks()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerCallbacks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerCallbacks.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000026EB File Offset: 0x000008EB
		public VFXSpawnerCallbacks(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_OnPlay_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_OnStop_Public_Abstract_Virtual_New_Void_VFXSpawnerState_VFXExpressionValues_VisualEffect_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

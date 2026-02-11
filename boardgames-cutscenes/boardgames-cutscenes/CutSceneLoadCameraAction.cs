using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x0200000B RID: 11
	public class CutSceneLoadCameraAction : CutSceneAction
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00003F6C File Offset: 0x0000216C
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneLoadCameraAction()
		{
			Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneLoadCameraAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr);
			CutSceneLoadCameraAction.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr, 100663365);
			CutSceneLoadCameraAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr, 100663366);
			CutSceneLoadCameraAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003FD8 File Offset: 0x000021D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258220, XrefRangeEnd = 1258225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneLoadCameraAction.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004024 File Offset: 0x00002224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258225, XrefRangeEnd = 1258227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneLoadCameraAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004068 File Offset: 0x00002268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneLoadCameraAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneLoadCameraAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneLoadCameraAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000224D File Offset: 0x0000044D
		public CutSceneLoadCameraAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

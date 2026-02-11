using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000005 RID: 5
	public class CutSceneCameraAction : CutSceneAction
	{
		// Token: 0x0600001D RID: 29 RVA: 0x0000330C File Offset: 0x0000150C
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneCameraAction()
		{
			Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneCameraAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr);
			CutSceneCameraAction.NativeFieldInfoPtr_cameraID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr, "cameraID");
			CutSceneCameraAction.NativeMethodInfoPtr_Play_Public_Virtual_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr, 100663309);
			CutSceneCameraAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr, 100663310);
			CutSceneCameraAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr, 100663311);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000338C File Offset: 0x0000158C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258062, XrefRangeEnd = 1258068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Command Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneCameraAction.NativeMethodInfoPtr_Play_Public_Virtual_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000033D8 File Offset: 0x000015D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258068, XrefRangeEnd = 1258071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CutSceneCameraAction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000341C File Offset: 0x0000161C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneCameraAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneCameraAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneCameraAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020FA File Offset: 0x000002FA
		public CutSceneCameraAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003458 File Offset: 0x00001658
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002103 File Offset: 0x00000303
		public unsafe string cameraID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCameraAction.NativeFieldInfoPtr_cameraID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneCameraAction.NativeFieldInfoPtr_cameraID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_cameraID;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Command_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

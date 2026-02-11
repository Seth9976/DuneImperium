using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.compositeModule.activation
{
	// Token: 0x0200009F RID: 159
	public sealed class ActivateModuleOnGamepadInput : ModuleActivator
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x0001EB34 File Offset: 0x0001CD34
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateModuleOnGamepadInput()
		{
			Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.activation", "ActivateModuleOnGamepadInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr);
			ActivateModuleOnGamepadInput.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr, 100664202);
			ActivateModuleOnGamepadInput.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr, 100664203);
			ActivateModuleOnGamepadInput.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr, 100664204);
			ActivateModuleOnGamepadInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr, 100664205);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
		[CallerCount(0)]
		public unsafe override bool shouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnGamepadInput.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001EC04 File Offset: 0x0001CE04
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnGamepadInput.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001EC38 File Offset: 0x0001CE38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnGamepadInput.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001EC6C File Offset: 0x0001CE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126492, RefRangeEnd = 1126493, XrefRangeStart = 1126487, XrefRangeEnd = 1126492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateModuleOnGamepadInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateModuleOnGamepadInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnGamepadInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00005D88 File Offset: 0x00003F88
		public ActivateModuleOnGamepadInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_Activated_Public_Virtual_Void_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

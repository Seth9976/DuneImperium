using System;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.compositeModule.activation
{
	// Token: 0x020000A0 RID: 160
	public sealed class ActivateModuleOnMouseOrTouchInput : ModuleActivator
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateModuleOnMouseOrTouchInput()
		{
			Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule.activation", "ActivateModuleOnMouseOrTouchInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr);
			ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr, 100664206);
			ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr, 100664207);
			ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr, 100664208);
			ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr, 100664209);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001ED28 File Offset: 0x0001CF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126493, XrefRangeEnd = 1126502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool shouldModuleActivate(InputDetector inputDetector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDetector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0001ED78 File Offset: 0x0001CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126502, XrefRangeEnd = 1126504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_Activated_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001EDAC File Offset: 0x0001CFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1126504, XrefRangeEnd = 1126509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1126492, RefRangeEnd = 1126493, XrefRangeStart = 1126492, XrefRangeEnd = 1126493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateModuleOnMouseOrTouchInput()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateModuleOnMouseOrTouchInput>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateModuleOnMouseOrTouchInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00005D91 File Offset: 0x00003F91
		public ActivateModuleOnMouseOrTouchInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_shouldModuleActivate_Protected_Virtual_Boolean_InputDetector_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_Activated_Public_Virtual_Void_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_Deactivated_Public_Virtual_Void_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

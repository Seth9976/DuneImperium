using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008F RID: 143
	public class SetInteractableOnInputModuleType : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x0001A5D0 File Offset: 0x000187D0
		// Note: this type is marked as 'beforefieldinit'.
		static SetInteractableOnInputModuleType()
		{
			Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "SetInteractableOnInputModuleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr);
			SetInteractableOnInputModuleType.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, "inputModuleType");
			SetInteractableOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, 100664058);
			SetInteractableOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, 100664059);
			SetInteractableOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, 100664060);
			SetInteractableOnInputModuleType.NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, 100664061);
			SetInteractableOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr, 100664062);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0001A678 File Offset: 0x00018878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125194, XrefRangeEnd = 1125207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetInteractableOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0001A6B4 File Offset: 0x000188B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125207, XrefRangeEnd = 1125216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetInteractableOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0001A6F0 File Offset: 0x000188F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125216, XrefRangeEnd = 1125222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetInteractableOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001A72C File Offset: 0x0001892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125222, XrefRangeEnd = 1125227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interactable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetInteractableOnInputModuleType.NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0001A76C File Offset: 0x0001896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125227, XrefRangeEnd = 1125233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetInteractableOnInputModuleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetInteractableOnInputModuleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetInteractableOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x000055B6 File Offset: 0x000037B6
		public SetInteractableOnInputModuleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001A7A8 File Offset: 0x000189A8
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x000055BF File Offset: 0x000037BF
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetInteractableOnInputModuleType.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetInteractableOnInputModuleType.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

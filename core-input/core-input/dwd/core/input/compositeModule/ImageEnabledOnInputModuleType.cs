using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input.compositeModule
{
	// Token: 0x0200008C RID: 140
	public class ImageEnabledOnInputModuleType : VersionedView<CurrentInputModuleType>
	{
		// Token: 0x06000617 RID: 1559 RVA: 0x0001A350 File Offset: 0x00018550
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEnabledOnInputModuleType()
		{
			Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.compositeModule", "ImageEnabledOnInputModuleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr);
			ImageEnabledOnInputModuleType.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, "inputModuleType");
			ImageEnabledOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, 100664051);
			ImageEnabledOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, 100664052);
			ImageEnabledOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, 100664053);
			ImageEnabledOnInputModuleType.NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, 100664054);
			ImageEnabledOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr, 100664055);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001A3F8 File Offset: 0x000185F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125130, XrefRangeEnd = 1125143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageEnabledOnInputModuleType.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001A434 File Offset: 0x00018634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125143, XrefRangeEnd = 1125152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageEnabledOnInputModuleType.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001A470 File Offset: 0x00018670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125152, XrefRangeEnd = 1125158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageEnabledOnInputModuleType.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0001A4AC File Offset: 0x000186AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125158, XrefRangeEnd = 1125172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref interactable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEnabledOnInputModuleType.NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0001A4EC File Offset: 0x000186EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125172, XrefRangeEnd = 1125178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageEnabledOnInputModuleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageEnabledOnInputModuleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEnabledOnInputModuleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00005514 File Offset: 0x00003714
		public ImageEnabledOnInputModuleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001A528 File Offset: 0x00018728
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x0000551D File Offset: 0x0000371D
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageEnabledOnInputModuleType.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageEnabledOnInputModuleType.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_setInteractable_Private_Void_Boolean_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

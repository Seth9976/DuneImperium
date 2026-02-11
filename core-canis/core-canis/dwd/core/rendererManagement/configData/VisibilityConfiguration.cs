using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.rendererManagement.configData
{
	// Token: 0x02000100 RID: 256
	public class VisibilityConfiguration : DataComponent
	{
		// Token: 0x06000F06 RID: 3846 RVA: 0x0004F5FC File Offset: 0x0004D7FC
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityConfiguration()
		{
			Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.rendererManagement.configData", "VisibilityConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr);
			VisibilityConfiguration.NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr, "Show");
			VisibilityConfiguration.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr, "Transform");
			VisibilityConfiguration.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr, 100665478);
			VisibilityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr, 100665479);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0004F67C File Offset: 0x0004D87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867958, XrefRangeEnd = 867962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisibilityConfiguration.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0004F6C8 File Offset: 0x0004D8C8
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityConfiguration()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00007166 File Offset: 0x00005366
		public VisibilityConfiguration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x0004F704 File Offset: 0x0004D904
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x0000716F File Offset: 0x0000536F
		public unsafe bool Show
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityConfiguration.NativeFieldInfoPtr_Show);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityConfiguration.NativeFieldInfoPtr_Show)) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0004F72C File Offset: 0x0004D92C
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x0000718A File Offset: 0x0000538A
		public unsafe GlobalTransform Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityConfiguration.NativeFieldInfoPtr_Transform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityConfiguration.NativeFieldInfoPtr_Transform)) = value;
			}
		}

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_Show;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_Transform;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

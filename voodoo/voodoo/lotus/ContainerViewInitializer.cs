using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace lotus
{
	// Token: 0x02000044 RID: 68
	public class ContainerViewInitializer : EntityViewInitializer
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x000173D0 File Offset: 0x000155D0
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerViewInitializer()
		{
			Il2CppClassPointerStore<ContainerViewInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ContainerViewInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerViewInitializer>.NativeClassPtr);
			ContainerViewInitializer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewInitializer>.NativeClassPtr, 100663809);
			ContainerViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewInitializer>.NativeClassPtr, 100663810);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00017428 File Offset: 0x00015628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110247, XrefRangeEnd = 1110265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewInitializer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001745C File Offset: 0x0001565C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerViewInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerViewInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004419 File Offset: 0x00002619
		public ContainerViewInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000045 RID: 69
	public class ContainerViewObserver : DirtyBehaviour
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x00017498 File Offset: 0x00015698
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerViewObserver()
		{
			Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ContainerViewObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr);
			ContainerViewObserver.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr, "parent");
			ContainerViewObserver.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr, 100663811);
			ContainerViewObserver.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr, 100663812);
			ContainerViewObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr, 100663813);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00017518 File Offset: 0x00015718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110265, XrefRangeEnd = 1110273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewObserver.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001754C File Offset: 0x0001574C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110273, XrefRangeEnd = 1110278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewObserver.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00017580 File Offset: 0x00015780
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerViewObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContainerViewObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContainerViewObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00004422 File Offset: 0x00002622
		public ContainerViewObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000175BC File Offset: 0x000157BC
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0000442B File Offset: 0x0000262B
		public unsafe ContainerView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewObserver.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContainerViewObserver.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

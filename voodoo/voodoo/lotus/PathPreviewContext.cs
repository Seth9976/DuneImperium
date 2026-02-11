using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus
{
	// Token: 0x0200006C RID: 108
	public class PathPreviewContext : Object
	{
		// Token: 0x06000647 RID: 1607 RVA: 0x0001E2E8 File Offset: 0x0001C4E8
		// Note: this type is marked as 'beforefieldinit'.
		static PathPreviewContext()
		{
			Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "PathPreviewContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr);
			PathPreviewContext.NativeFieldInfoPtr_destinationPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "destinationPath");
			PathPreviewContext.NativeFieldInfoPtr_startView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "startView");
			PathPreviewContext.NativeFieldInfoPtr_sequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "sequenceName");
			PathPreviewContext.NativeFieldInfoPtr_dataSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "dataSource");
			PathPreviewContext.NativeFieldInfoPtr_dataSourcePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "dataSourcePath");
			PathPreviewContext.NativeFieldInfoPtr_childIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "childIndices");
			PathPreviewContext.NativeFieldInfoPtr_postDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "postDelay");
			PathPreviewContext.NativeFieldInfoPtr_pauseAfterCreatingChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "pauseAfterCreatingChild");
			PathPreviewContext.NativeFieldInfoPtr_hidePile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, "hidePile");
			PathPreviewContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr, 100664160);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112881, XrefRangeEnd = 1112886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathPreviewContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathPreviewContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathPreviewContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000515F File Offset: 0x0000335F
		public PathPreviewContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0001E41C File Offset: 0x0001C61C
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00005168 File Offset: 0x00003368
		public unsafe string destinationPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_destinationPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_destinationPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0001E444 File Offset: 0x0001C644
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00005187 File Offset: 0x00003387
		public unsafe ContainerView startView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_startView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_startView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001E474 File Offset: 0x0001C674
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x000051A6 File Offset: 0x000033A6
		public unsafe string sequenceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_sequenceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_sequenceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001E49C File Offset: 0x0001C69C
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x000051C5 File Offset: 0x000033C5
		public unsafe EntityComponent dataSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_dataSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_dataSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001E4CC File Offset: 0x0001C6CC
		// (set) Token: 0x06000653 RID: 1619 RVA: 0x000051E4 File Offset: 0x000033E4
		public unsafe string dataSourcePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_dataSourcePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_dataSourcePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001E4F4 File Offset: 0x0001C6F4
		// (set) Token: 0x06000655 RID: 1621 RVA: 0x00005203 File Offset: 0x00003403
		public unsafe Il2CppStructArray<int> childIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_childIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_childIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001E524 File Offset: 0x0001C724
		// (set) Token: 0x06000657 RID: 1623 RVA: 0x00005222 File Offset: 0x00003422
		public unsafe float postDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_postDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_postDelay)) = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001E54C File Offset: 0x0001C74C
		// (set) Token: 0x06000659 RID: 1625 RVA: 0x0000523D File Offset: 0x0000343D
		public unsafe bool pauseAfterCreatingChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_pauseAfterCreatingChild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_pauseAfterCreatingChild)) = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x0001E574 File Offset: 0x0001C774
		// (set) Token: 0x0600065B RID: 1627 RVA: 0x00005258 File Offset: 0x00003458
		public unsafe bool hidePile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_hidePile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathPreviewContext.NativeFieldInfoPtr_hidePile)) = value;
			}
		}

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_destinationPath;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_startView;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_sequenceName;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_dataSource;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_dataSourcePath;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_childIndices;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_postDelay;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_pauseAfterCreatingChild;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_hidePile;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

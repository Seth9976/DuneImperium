using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.views
{
	// Token: 0x020000B1 RID: 177
	public class WormUndoNodeViewInitStrategy : EntityViewInitializationStrategy
	{
		// Token: 0x060006E0 RID: 1760 RVA: 0x0002D96C File Offset: 0x0002BB6C
		// Note: this type is marked as 'beforefieldinit'.
		static WormUndoNodeViewInitStrategy()
		{
			Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormUndoNodeViewInitStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr);
			WormUndoNodeViewInitStrategy.NativeFieldInfoPtr_containerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr, "containerView");
			WormUndoNodeViewInitStrategy.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr, 100664254);
			WormUndoNodeViewInitStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr, 100664255);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696829, XrefRangeEnd = 696831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityView ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUndoNodeViewInitStrategy.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0002DA28 File Offset: 0x0002BC28
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUndoNodeViewInitStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUndoNodeViewInitStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoNodeViewInitStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000578D File Offset: 0x0000398D
		public WormUndoNodeViewInitStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0002DA64 File Offset: 0x0002BC64
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00005796 File Offset: 0x00003996
		public unsafe ContainerView containerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoNodeViewInitStrategy.NativeFieldInfoPtr_containerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoNodeViewInitStrategy.NativeFieldInfoPtr_containerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_containerView;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000157 RID: 343
	public class WormProvidePlayerConflictRewardRenderer : Subscriber<WormConflictPlayerRewardData>
	{
		// Token: 0x06000F5C RID: 3932 RVA: 0x00046374 File Offset: 0x00044574
		// Note: this type is marked as 'beforefieldinit'.
		static WormProvidePlayerConflictRewardRenderer()
		{
			Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormProvidePlayerConflictRewardRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr);
			WormProvidePlayerConflictRewardRenderer.NativeFieldInfoPtr_playerEntityComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr, "playerEntityComponent");
			WormProvidePlayerConflictRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr, 100665375);
			WormProvidePlayerConflictRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr, 100665376);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x000463E0 File Offset: 0x000445E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707709, XrefRangeEnd = 707711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormProvidePlayerConflictRewardRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0004641C File Offset: 0x0004461C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707711, XrefRangeEnd = 707714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormProvidePlayerConflictRewardRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormProvidePlayerConflictRewardRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormProvidePlayerConflictRewardRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0000A1AD File Offset: 0x000083AD
		public WormProvidePlayerConflictRewardRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00046458 File Offset: 0x00044658
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x0000A1B6 File Offset: 0x000083B6
		public unsafe EntityView playerEntityComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvidePlayerConflictRewardRenderer.NativeFieldInfoPtr_playerEntityComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormProvidePlayerConflictRewardRenderer.NativeFieldInfoPtr_playerEntityComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_playerEntityComponent;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

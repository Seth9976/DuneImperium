using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x0200022D RID: 557
	public class WormStingerLeaderInitializer : MonoBehaviour
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x00061E68 File Offset: 0x00060068
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerLeaderInitializer()
		{
			Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerLeaderInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr);
			WormStingerLeaderInitializer.NativeFieldInfoPtr_leaderProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr, "leaderProvider");
			WormStingerLeaderInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr, 100666661);
			WormStingerLeaderInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr, 100666662);
			WormStingerLeaderInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr, 100666663);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00061EE8 File Offset: 0x000600E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718246, XrefRangeEnd = 718288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerLeaderInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00061F2C File Offset: 0x0006012C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetViews()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerLeaderInitializer.NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00061F60 File Offset: 0x00060160
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerLeaderInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerLeaderInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerLeaderInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		public WormStingerLeaderInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00061F9C File Offset: 0x0006019C
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000E6F1 File Offset: 0x0000C8F1
		public unsafe SubscriptionProvider leaderProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderInitializer.NativeFieldInfoPtr_leaderProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerLeaderInitializer.NativeFieldInfoPtr_leaderProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeFieldInfoPtr_leaderProvider;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_ResetViews_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

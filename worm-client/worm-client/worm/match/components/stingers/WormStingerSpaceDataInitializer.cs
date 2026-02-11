using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x02000230 RID: 560
	public class WormStingerSpaceDataInitializer : MonoBehaviour
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x000622B8 File Offset: 0x000604B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerSpaceDataInitializer()
		{
			Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerSpaceDataInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr);
			WormStingerSpaceDataInitializer.NativeFieldInfoPtr_spaceProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr, "spaceProvider");
			WormStingerSpaceDataInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr, 100666672);
			WormStingerSpaceDataInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr, 100666673);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00062324 File Offset: 0x00060524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718365, XrefRangeEnd = 718383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSpaceDataInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00062368 File Offset: 0x00060568
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerSpaceDataInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerSpaceDataInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerSpaceDataInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0000E77F File Offset: 0x0000C97F
		public WormStingerSpaceDataInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x000623A4 File Offset: 0x000605A4
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x0000E788 File Offset: 0x0000C988
		public unsafe SubscriptionProvider spaceProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSpaceDataInitializer.NativeFieldInfoPtr_spaceProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerSpaceDataInitializer.NativeFieldInfoPtr_spaceProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr_spaceProvider;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

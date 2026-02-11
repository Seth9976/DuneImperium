using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace worm.match.components.stingers
{
	// Token: 0x0200022B RID: 555
	public class WormStingerHagalConversionInitializer : MonoBehaviour
	{
		// Token: 0x0600183D RID: 6205 RVA: 0x00061B28 File Offset: 0x0005FD28
		// Note: this type is marked as 'beforefieldinit'.
		static WormStingerHagalConversionInitializer()
		{
			Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormStingerHagalConversionInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr);
			WormStingerHagalConversionInitializer.NativeFieldInfoPtr_solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, "solari");
			WormStingerHagalConversionInitializer.NativeFieldInfoPtr_water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, "water");
			WormStingerHagalConversionInitializer.NativeFieldInfoPtr_spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, "spice");
			WormStingerHagalConversionInitializer.NativeFieldInfoPtr_intrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, "intrigue");
			WormStingerHagalConversionInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, 100666657);
			WormStingerHagalConversionInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr, 100666658);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00061BD0 File Offset: 0x0005FDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718174, XrefRangeEnd = 718205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitViews(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerHagalConversionInitializer.NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00061C14 File Offset: 0x0005FE14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormStingerHagalConversionInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormStingerHagalConversionInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormStingerHagalConversionInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0000E61C File Offset: 0x0000C81C
		public WormStingerHagalConversionInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x00061C50 File Offset: 0x0005FE50
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x0000E625 File Offset: 0x0000C825
		public unsafe GameObject solari
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_solari);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_solari), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00061C80 File Offset: 0x0005FE80
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000E644 File Offset: 0x0000C844
		public unsafe GameObject water
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_water);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_water), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000E663 File Offset: 0x0000C863
		public unsafe GameObject spice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_spice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_spice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00061CE0 File Offset: 0x0005FEE0
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000E682 File Offset: 0x0000C882
		public unsafe GameObject intrigue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_intrigue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormStingerHagalConversionInitializer.NativeFieldInfoPtr_intrigue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeFieldInfoPtr_solari;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeFieldInfoPtr_water;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeFieldInfoPtr_spice;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeFieldInfoPtr_intrigue;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr_InitViews_Public_Virtual_Final_New_Void_IHasAttributes_0;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

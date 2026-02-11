using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.UI;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F8 RID: 248
	public class WormAtlasImageObserver : Observer
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x0003945C File Offset: 0x0003765C
		// Note: this type is marked as 'beforefieldinit'.
		static WormAtlasImageObserver()
		{
			Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormAtlasImageObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr);
			WormAtlasImageObserver.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, "atlasName");
			WormAtlasImageObserver.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, "spriteNameFormat");
			WormAtlasImageObserver.NativeFieldInfoPtr_warnIfNotFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, "warnIfNotFound");
			WormAtlasImageObserver.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, "image");
			WormAtlasImageObserver.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, 100664798);
			WormAtlasImageObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, 100664799);
			WormAtlasImageObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr, 100664800);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00039518 File Offset: 0x00037718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702234, XrefRangeEnd = 702239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAtlasImageObserver.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00039554 File Offset: 0x00037754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702239, XrefRangeEnd = 702268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAtlasImageObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00039590 File Offset: 0x00037790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 702268, XrefRangeEnd = 702274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAtlasImageObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAtlasImageObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAtlasImageObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public WormAtlasImageObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x000395CC File Offset: 0x000377CC
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00007BA9 File Offset: 0x00005DA9
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x000395F4 File Offset: 0x000377F4
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00007BC8 File Offset: 0x00005DC8
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0003961C File Offset: 0x0003781C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00007BE7 File Offset: 0x00005DE7
		public unsafe bool warnIfNotFound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_warnIfNotFound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_warnIfNotFound)) = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00039644 File Offset: 0x00037844
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00007C02 File Offset: 0x00005E02
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAtlasImageObserver.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_warnIfNotFound;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

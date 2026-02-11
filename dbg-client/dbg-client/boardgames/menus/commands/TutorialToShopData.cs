using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.menus.commands
{
	// Token: 0x02000239 RID: 569
	public class TutorialToShopData : DataComponent
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x0000E20A File Offset: 0x0000C40A
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialToShopData()
		{
			Il2CppClassPointerStore<TutorialToShopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "TutorialToShopData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialToShopData>.NativeClassPtr);
			TutorialToShopData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialToShopData>.NativeClassPtr, 100667367);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00071738 File Offset: 0x0006F938
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialToShopData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialToShopData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialToShopData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0000E243 File Offset: 0x0000C443
		public TutorialToShopData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

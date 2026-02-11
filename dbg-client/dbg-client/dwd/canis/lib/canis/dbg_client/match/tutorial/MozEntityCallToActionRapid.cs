using System;
using boardgames.match.tutorial;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.canis.lib.canis.dbg_client.match.tutorial
{
	// Token: 0x02000055 RID: 85
	public class MozEntityCallToActionRapid : MozEntityCallToAction
	{
		// Token: 0x0600034E RID: 846 RVA: 0x000280C0 File Offset: 0x000262C0
		// Note: this type is marked as 'beforefieldinit'.
		static MozEntityCallToActionRapid()
		{
			Il2CppClassPointerStore<MozEntityCallToActionRapid>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.match.tutorial", "MozEntityCallToActionRapid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozEntityCallToActionRapid>.NativeClassPtr);
			MozEntityCallToActionRapid.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToActionRapid>.NativeClassPtr, 100663816);
			MozEntityCallToActionRapid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozEntityCallToActionRapid>.NativeClassPtr, 100663817);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00028118 File Offset: 0x00026318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499668, XrefRangeEnd = 499687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void addListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MozEntityCallToActionRapid.NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00028154 File Offset: 0x00026354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499687, XrefRangeEnd = 499688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozEntityCallToActionRapid()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozEntityCallToActionRapid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozEntityCallToActionRapid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000375A File Offset: 0x0000195A
		public MozEntityCallToActionRapid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_addListener_Protected_Virtual_Void_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

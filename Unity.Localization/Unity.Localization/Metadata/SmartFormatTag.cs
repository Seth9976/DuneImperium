using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000DE RID: 222
	[Serializable]
	public class SmartFormatTag : SharedTableEntryMetadata
	{
		// Token: 0x06000B41 RID: 2881 RVA: 0x00006AC3 File Offset: 0x00004CC3
		// Note: this type is marked as 'beforefieldinit'.
		static SmartFormatTag()
		{
			Il2CppClassPointerStore<SmartFormatTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "SmartFormatTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmartFormatTag>.NativeClassPtr);
			SmartFormatTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmartFormatTag>.NativeClassPtr, 100665166);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00033B5C File Offset: 0x00031D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmartFormatTag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmartFormatTag>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmartFormatTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00006AFC File Offset: 0x00004CFC
		public SmartFormatTag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

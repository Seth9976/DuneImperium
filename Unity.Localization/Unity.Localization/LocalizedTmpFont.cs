using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using TMPro;

namespace UnityEngine.Localization
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class LocalizedTmpFont : LocalizedAsset<TMP_FontAsset>
	{
		// Token: 0x06000084 RID: 132 RVA: 0x000023CB File Offset: 0x000005CB
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedTmpFont()
		{
			Il2CppClassPointerStore<LocalizedTmpFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedTmpFont");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedTmpFont>.NativeClassPtr);
			LocalizedTmpFont.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTmpFont>.NativeClassPtr, 100663388);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000AE38 File Offset: 0x00009038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065420, XrefRangeEnd = 1065423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedTmpFont()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedTmpFont>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedTmpFont.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002404 File Offset: 0x00000604
		public LocalizedTmpFont(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

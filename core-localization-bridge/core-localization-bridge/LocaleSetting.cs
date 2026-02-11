using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace localization.bridge
{
	// Token: 0x02000003 RID: 3
	public class LocaleSetting : MonoBehaviour
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000022AC File Offset: 0x000004AC
		// Note: this type is marked as 'beforefieldinit'.
		static LocaleSetting()
		{
			Il2CppClassPointerStore<LocaleSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization-bridge.dll", "localization.bridge", "LocaleSetting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocaleSetting>.NativeClassPtr);
			LocaleSetting.NativeMethodInfoPtr_Event_ChangeLocale_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleSetting>.NativeClassPtr, 100663299);
			LocaleSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocaleSetting>.NativeClassPtr, 100663300);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002304 File Offset: 0x00000504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275118, XrefRangeEnd = 1275137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ChangeLocale(int localeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localeIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleSetting.NativeMethodInfoPtr_Event_ChangeLocale_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002344 File Offset: 0x00000544
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocaleSetting()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocaleSetting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocaleSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002059 File Offset: 0x00000259
		public LocaleSetting(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_Event_ChangeLocale_Public_Void_Int32_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

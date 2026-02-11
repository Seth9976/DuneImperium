using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	// Token: 0x02000042 RID: 66
	public static class CommonLanguagesTimeTextInfo : Object
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x00019320 File Offset: 0x00017520
		// Note: this type is marked as 'beforefieldinit'.
		static CommonLanguagesTimeTextInfo()
		{
			Il2CppClassPointerStore<CommonLanguagesTimeTextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Utilities", "CommonLanguagesTimeTextInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonLanguagesTimeTextInfo>.NativeClassPtr);
			CommonLanguagesTimeTextInfo.NativeMethodInfoPtr_get_English_Public_Static_get_TimeTextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonLanguagesTimeTextInfo>.NativeClassPtr, 100664069);
			CommonLanguagesTimeTextInfo.NativeMethodInfoPtr_GetTimeTextInfo_Public_Static_TimeTextInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonLanguagesTimeTextInfo>.NativeClassPtr, 100664070);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00019378 File Offset: 0x00017578
		public unsafe static TimeTextInfo English
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1070941, RefRangeEnd = 1070943, XrefRangeStart = 1070850, XrefRangeEnd = 1070941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonLanguagesTimeTextInfo.NativeMethodInfoPtr_get_English_Public_Static_get_TimeTextInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeTextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000193AC File Offset: 0x000175AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1070946, RefRangeEnd = 1070950, XrefRangeStart = 1070943, XrefRangeEnd = 1070946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeTextInfo GetTimeTextInfo(string twoLetterIsoLanguageName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(twoLetterIsoLanguageName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonLanguagesTimeTextInfo.NativeMethodInfoPtr_GetTimeTextInfo_Public_Static_TimeTextInfo_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeTextInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000036CB File Offset: 0x000018CB
		public CommonLanguagesTimeTextInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_English_Public_Static_get_TimeTextInfo_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeTextInfo_Public_Static_TimeTextInfo_String_0;
	}
}

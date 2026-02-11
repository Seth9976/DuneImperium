using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm
{
	// Token: 0x0200001C RID: 28
	public static class NtlmSettings : Object
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0000B51C File Offset: 0x0000971C
		// Note: this type is marked as 'beforefieldinit'.
		static NtlmSettings()
		{
			Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr);
			NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, "defaultAuthLevel");
			NtlmSettings.NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, 100663592);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000B574 File Offset: 0x00009774
		public unsafe static NtlmAuthLevel DefaultAuthLevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149118, XrefRangeEnd = 1149122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NtlmSettings.NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002BFC File Offset: 0x00000DFC
		public NtlmSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000B5A4 File Offset: 0x000097A4
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002C05 File Offset: 0x00000E05
		public unsafe static NtlmAuthLevel defaultAuthLevel
		{
			get
			{
				NtlmAuthLevel ntlmAuthLevel;
				IL2CPP.il2cpp_field_static_get_value(NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel, (void*)(&ntlmAuthLevel));
				return ntlmAuthLevel;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NtlmSettings.NativeFieldInfoPtr_defaultAuthLevel, (void*)(&value));
			}
		}

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_defaultAuthLevel;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0;
	}
}

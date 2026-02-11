using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Networking.selection;
using Networking.selection.targetinformation;

namespace dwd.core.match.selection.messages
{
	// Token: 0x0200015D RID: 349
	public static class TargetPreferenceConversion : Object
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x000090F8 File Offset: 0x000072F8
		// Note: this type is marked as 'beforefieldinit'.
		static TargetPreferenceConversion()
		{
			Il2CppClassPointerStore<TargetPreferenceConversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.selection.messages", "TargetPreferenceConversion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPreferenceConversion>.NativeClassPtr);
			TargetPreferenceConversion.NativeMethodInfoPtr_PreferenceToStrength_Public_Static_TargetStrength_TargetPreference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPreferenceConversion>.NativeClassPtr, 100666406);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00066C84 File Offset: 0x00064E84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 874978, RefRangeEnd = 874982, XrefRangeStart = 874978, XrefRangeEnd = 874978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TargetStrength PreferenceToStrength(TargetPreference preference)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preference;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetPreferenceConversion.NativeMethodInfoPtr_PreferenceToStrength_Public_Static_TargetStrength_TargetPreference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00009131 File Offset: 0x00007331
		public TargetPreferenceConversion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_PreferenceToStrength_Public_Static_TargetStrength_TargetPreference_0;
	}
}

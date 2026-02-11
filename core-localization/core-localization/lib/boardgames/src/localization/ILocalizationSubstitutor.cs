using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace lib.boardgames.src.localization
{
	// Token: 0x0200000C RID: 12
	public class ILocalizationSubstitutor : Il2CppObjectBase
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003744 File Offset: 0x00001944
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalizationSubstitutor()
		{
			Il2CppClassPointerStore<ILocalizationSubstitutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "lib.boardgames.src.localization", "ILocalizationSubstitutor");
			ILocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizationSubstitutor>.NativeClassPtr, 100663359);
			ILocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_New_LocalizableText_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizationSubstitutor>.NativeClassPtr, 100663360);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003794 File Offset: 0x00001994
		[CallerCount(0)]
		public unsafe virtual string Substitute(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000037E8 File Offset: 0x000019E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266710, XrefRangeEnd = 1266722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual LocalizableText Substitute(LocalizableText text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_New_LocalizableText_LocalizableText_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000022BC File Offset: 0x000004BC
		public ILocalizationSubstitutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Abstract_Virtual_New_String_String_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Virtual_New_LocalizableText_LocalizableText_0;
	}
}

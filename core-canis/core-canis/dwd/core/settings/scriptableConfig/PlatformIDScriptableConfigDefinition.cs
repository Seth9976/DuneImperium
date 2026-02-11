using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.settings.scriptableConfig
{
	// Token: 0x020000C5 RID: 197
	public class PlatformIDScriptableConfigDefinition : ScriptableConfigDefinition<PlatformIDScriptableConfig>
	{
		// Token: 0x06000C5C RID: 3164 RVA: 0x000065BB File Offset: 0x000047BB
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformIDScriptableConfigDefinition()
		{
			Il2CppClassPointerStore<PlatformIDScriptableConfigDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.scriptableConfig", "PlatformIDScriptableConfigDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformIDScriptableConfigDefinition>.NativeClassPtr);
			PlatformIDScriptableConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformIDScriptableConfigDefinition>.NativeClassPtr, 100665043);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00042F88 File Offset: 0x00041188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864427, XrefRangeEnd = 864430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformIDScriptableConfigDefinition(string key, string defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformIDScriptableConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformIDScriptableConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000065F4 File Offset: 0x000047F4
		public PlatformIDScriptableConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}

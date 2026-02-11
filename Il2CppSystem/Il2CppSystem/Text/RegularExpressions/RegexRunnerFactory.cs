using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200008A RID: 138
	public class RegexRunnerFactory : Object
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x00044220 File Offset: 0x00042420
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunnerFactory()
		{
			Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunnerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr);
			RegexRunnerFactory.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr, 100664888);
			RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr, 100664889);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00044278 File Offset: 0x00042478
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexRunnerFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexRunnerFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunnerFactory.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000442B4 File Offset: 0x000424B4
		[CallerCount(0)]
		public unsafe virtual RegexRunner CreateInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunnerFactory.NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr3) : null;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00005984 File Offset: 0x00003B84
		public RegexRunnerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_FamOrAssem_Abstract_Virtual_New_RegexRunner_0;
	}
}

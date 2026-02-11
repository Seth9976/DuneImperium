using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class UnityEngineModuleAssembly : Attribute
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000217C File Offset: 0x0000037C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEngineModuleAssembly()
		{
			Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "UnityEngineModuleAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr);
			UnityEngineModuleAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002A30 File Offset: 0x00000C30
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngineModuleAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngineModuleAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEngineModuleAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021B5 File Offset: 0x000003B5
		public UnityEngineModuleAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

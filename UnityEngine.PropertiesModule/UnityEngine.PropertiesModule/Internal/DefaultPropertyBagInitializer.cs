using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Properties.Internal
{
	// Token: 0x02000024 RID: 36
	public static class DefaultPropertyBagInitializer : Object
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000028F6 File Offset: 0x00000AF6
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultPropertyBagInitializer()
		{
			Il2CppClassPointerStore<DefaultPropertyBagInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "DefaultPropertyBagInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultPropertyBagInitializer>.NativeClassPtr);
			DefaultPropertyBagInitializer.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultPropertyBagInitializer>.NativeClassPtr, 100663447);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00007318 File Offset: 0x00005518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231634, XrefRangeEnd = 1232011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultPropertyBagInitializer.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000292F File Offset: 0x00000B2F
		public DefaultPropertyBagInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;
	}
}

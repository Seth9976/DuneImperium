using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200026F RID: 623
	[DefaultMember("Item")]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06002959 RID: 10585 RVA: 0x00011C30 File Offset: 0x0000FE30
		// Note: this type is marked as 'beforefieldinit'.
		static BypassElementCollection()
		{
			Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "BypassElementCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr);
			BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr, 100669445);
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x000BB9F4 File Offset: 0x000B9BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494192, XrefRangeEnd = 494195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BypassElementCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BypassElementCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BypassElementCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00011C69 File Offset: 0x0000FE69
		public BypassElementCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

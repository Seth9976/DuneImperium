using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200027B RID: 635
	public sealed class SocketElement : ConfigurationElement
	{
		// Token: 0x06002985 RID: 10629 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
		// Note: this type is marked as 'beforefieldinit'.
		static SocketElement()
		{
			Il2CppClassPointerStore<SocketElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SocketElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketElement>.NativeClassPtr);
			SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100669465);
			SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketElement>.NativeClassPtr, 100669466);
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494252, XrefRangeEnd = 494255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SocketElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x000BC234 File Offset: 0x000BA434
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494255, XrefRangeEnd = 494258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00011D6C File Offset: 0x0000FF6C
		public SocketElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

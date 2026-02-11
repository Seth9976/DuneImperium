using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x02000275 RID: 629
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x000BBD40 File Offset: 0x000B9F40
		// Note: this type is marked as 'beforefieldinit'.
		static HttpWebRequestElement()
		{
			Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "HttpWebRequestElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr);
			HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100669454);
			HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr, 100669455);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000BBD98 File Offset: 0x000B9F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494219, XrefRangeEnd = 494222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpWebRequestElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpWebRequestElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x000BBDD4 File Offset: 0x000B9FD4
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494222, XrefRangeEnd = 494225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpWebRequestElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00011CFD File Offset: 0x0000FEFD
		public HttpWebRequestElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

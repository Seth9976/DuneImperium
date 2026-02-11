using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Configuration;

namespace Il2CppSystem.Net.Configuration
{
	// Token: 0x0200027A RID: 634
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x06002981 RID: 10625 RVA: 0x000BC0CC File Offset: 0x000BA2CC
		// Note: this type is marked as 'beforefieldinit'.
		static ServicePointManagerElement()
		{
			Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "ServicePointManagerElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr);
			ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100669463);
			ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr, 100669464);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000BC124 File Offset: 0x000BA324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494246, XrefRangeEnd = 494249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServicePointManagerElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServicePointManagerElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x000BC160 File Offset: 0x000BA360
		public unsafe override ConfigurationPropertyCollection Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494249, XrefRangeEnd = 494252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServicePointManagerElement.NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationPropertyCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00011D63 File Offset: 0x0000FF63
		public ServicePointManagerElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020E2 RID: 8418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Protected_Virtual_get_ConfigurationPropertyCollection_0;
	}
}

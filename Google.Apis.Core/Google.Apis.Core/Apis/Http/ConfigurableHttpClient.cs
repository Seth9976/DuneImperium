using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Http;

namespace Google.Apis.Http
{
	// Token: 0x02000026 RID: 38
	public class ConfigurableHttpClient : HttpClient
	{
		// Token: 0x0600018B RID: 395 RVA: 0x0000A028 File Offset: 0x00008228
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurableHttpClient()
		{
			Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Http", "ConfigurableHttpClient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr);
			ConfigurableHttpClient.NativeFieldInfoPtr__MessageHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr, "<MessageHandler>k__BackingField");
			ConfigurableHttpClient.NativeMethodInfoPtr_get_MessageHandler_Public_get_ConfigurableMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr, 100663559);
			ConfigurableHttpClient.NativeMethodInfoPtr_set_MessageHandler_Private_set_Void_ConfigurableMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr, 100663560);
			ConfigurableHttpClient.NativeMethodInfoPtr__ctor_Public_Void_ConfigurableMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr, 100663561);
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0000A0A8 File Offset: 0x000082A8
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0000A0E8 File Offset: 0x000082E8
		public unsafe ConfigurableMessageHandler MessageHandler
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableHttpClient.NativeMethodInfoPtr_get_MessageHandler_Public_get_ConfigurableMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurableMessageHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableHttpClient.NativeMethodInfoPtr_set_MessageHandler_Private_set_Void_ConfigurableMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A12C File Offset: 0x0000832C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211562, XrefRangeEnd = 1211572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurableHttpClient(ConfigurableMessageHandler handler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurableHttpClient>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableHttpClient.NativeMethodInfoPtr__ctor_Public_Void_ConfigurableMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000293D File Offset: 0x00000B3D
		public ConfigurableHttpClient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000A178 File Offset: 0x00008378
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002946 File Offset: 0x00000B46
		public unsafe ConfigurableMessageHandler _MessageHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableHttpClient.NativeFieldInfoPtr__MessageHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableMessageHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurableHttpClient.NativeFieldInfoPtr__MessageHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr__MessageHandler_k__BackingField;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageHandler_Public_get_ConfigurableMessageHandler_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_set_MessageHandler_Private_set_Void_ConfigurableMessageHandler_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurableMessageHandler_0;
	}
}

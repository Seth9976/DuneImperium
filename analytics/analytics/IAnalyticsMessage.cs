using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace analytics
{
	// Token: 0x0200000B RID: 11
	public class IAnalyticsMessage : Object
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002EE8 File Offset: 0x000010E8
		// Note: this type is marked as 'beforefieldinit'.
		static IAnalyticsMessage()
		{
			Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("analytics.dll", "analytics", "IAnalyticsMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr);
			IAnalyticsMessage.NativeMethodInfoPtr_url_Public_Abstract_Virtual_New_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr, 100663328);
			IAnalyticsMessage.NativeMethodInfoPtr_body_Public_Abstract_Virtual_New_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr, 100663329);
			IAnalyticsMessage.NativeMethodInfoPtr_EncodeTo64_Protected_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr, 100663330);
			IAnalyticsMessage.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr, 100663331);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002F68 File Offset: 0x00001168
		[CallerCount(0)]
		public unsafe virtual string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsMessage.NativeMethodInfoPtr_url_Public_Abstract_Virtual_New_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002FBC File Offset: 0x000011BC
		[CallerCount(0)]
		public unsafe virtual string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAnalyticsMessage.NativeMethodInfoPtr_body_Public_Abstract_Virtual_New_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003010 File Offset: 0x00001210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273451, XrefRangeEnd = 1273457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EncodeTo64(string toEncode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toEncode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAnalyticsMessage.NativeMethodInfoPtr_EncodeTo64_Protected_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003058 File Offset: 0x00001258
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAnalyticsMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAnalyticsMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAnalyticsMessage.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002164 File Offset: 0x00000364
		public IAnalyticsMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Abstract_Virtual_New_String_IAnalyticsManager_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Abstract_Virtual_New_String_IAnalyticsManager_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_EncodeTo64_Protected_String_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

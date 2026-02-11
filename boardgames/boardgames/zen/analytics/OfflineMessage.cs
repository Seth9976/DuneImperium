using System;
using analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics
{
	// Token: 0x0200008B RID: 139
	public class OfflineMessage : IAnalyticsMessage
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00026628 File Offset: 0x00024828
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMessage()
		{
			Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics", "OfflineMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr);
			OfflineMessage.NativeFieldInfoPtr_OFFLINE_FILENAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "OFFLINE_FILENAME");
			OfflineMessage.NativeFieldInfoPtr_DELIMETER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "DELIMETER");
			OfflineMessage.NativeFieldInfoPtr_cachedUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "cachedUrl");
			OfflineMessage.NativeFieldInfoPtr_cachedBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, "cachedBody");
			OfflineMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, 100664407);
			OfflineMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, 100664408);
			OfflineMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr, 100664409);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000266E4 File Offset: 0x000248E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfflineMessage(string url, string body)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfflineMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00026744 File Offset: 0x00024944
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string url(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMessage.NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00026798 File Offset: 0x00024998
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string body(IAnalyticsManager mgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OfflineMessage.NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000050FA File Offset: 0x000032FA
		public OfflineMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000267EC File Offset: 0x000249EC
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00005103 File Offset: 0x00003303
		public unsafe static string OFFLINE_FILENAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfflineMessage.NativeFieldInfoPtr_OFFLINE_FILENAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineMessage.NativeFieldInfoPtr_OFFLINE_FILENAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002680C File Offset: 0x00024A0C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x00005115 File Offset: 0x00003315
		public unsafe static char DELIMETER
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(OfflineMessage.NativeFieldInfoPtr_DELIMETER, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfflineMessage.NativeFieldInfoPtr_DELIMETER, (void*)(&value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00026828 File Offset: 0x00024A28
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00005123 File Offset: 0x00003323
		public unsafe string cachedUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_cachedUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_cachedUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00026850 File Offset: 0x00024A50
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00005142 File Offset: 0x00003342
		public unsafe string cachedBody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_cachedBody);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfflineMessage.NativeFieldInfoPtr_cachedBody), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_OFFLINE_FILENAME;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_DELIMETER;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_cachedUrl;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_cachedBody;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_url_Public_Virtual_String_IAnalyticsManager_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_body_Public_Virtual_String_IAnalyticsManager_0;
	}
}

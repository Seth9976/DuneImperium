using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008C RID: 140
	public static class XmlComplianceUtil : Object
	{
		// Token: 0x06001062 RID: 4194 RVA: 0x0005DB3C File Offset: 0x0005BD3C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlComplianceUtil()
		{
			Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlComplianceUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr);
			XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100665992);
			XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlComplianceUtil>.NativeClassPtr, 100665993);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0005DB94 File Offset: 0x0005BD94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 380232, RefRangeEnd = 380237, XrefRangeStart = 380204, XrefRangeEnd = 380232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NonCDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0005DBD0 File Offset: 0x0005BDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380237, XrefRangeEnd = 380248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CDataNormalize(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlComplianceUtil.NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000074E4 File Offset: 0x000056E4
		public XmlComplianceUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_NonCDataNormalize_Public_Static_String_String_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_CDataNormalize_Public_Static_String_String_0;
	}
}

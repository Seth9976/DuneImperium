using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EF RID: 239
	public class XmlDocumentTypeWrapper : XmlNodeWrapper
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x0006F60C File Offset: 0x0006D80C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocumentTypeWrapper()
		{
			Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XmlDocumentTypeWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr);
			XmlDocumentTypeWrapper.NativeFieldInfoPtr__documentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, "_documentType");
			XmlDocumentTypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667163);
			XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667164);
			XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667165);
			XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667166);
			XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667167);
			XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr, 100667168);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0006F6C8 File Offset: 0x0006D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentTypeWrapper(XmlDocumentType documentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocumentTypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(documentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentTypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0006F714 File Offset: 0x0006D914
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765149, XrefRangeEnd = 765150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0006F74C File Offset: 0x0006D94C
		public unsafe virtual string System
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0006F784 File Offset: 0x0006D984
		public unsafe virtual string Public
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0006F7BC File Offset: 0x0006D9BC
		public unsafe virtual string InternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0006F7F4 File Offset: 0x0006D9F4
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765150, XrefRangeEnd = 765152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentTypeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00008348 File Offset: 0x00006548
		public XmlDocumentTypeWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0006F838 File Offset: 0x0006DA38
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x00008351 File Offset: 0x00006551
		public unsafe XmlDocumentType _documentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentTypeWrapper.NativeFieldInfoPtr__documentType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentTypeWrapper.NativeFieldInfoPtr__documentType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeFieldInfoPtr__documentType;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlDocumentType_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001079 RID: 4217
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400107A RID: 4218
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;
	}
}

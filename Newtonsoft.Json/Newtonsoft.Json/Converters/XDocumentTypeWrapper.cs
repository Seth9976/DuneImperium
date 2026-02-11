using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Linq;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000F7 RID: 247
	public class XDocumentTypeWrapper : XObjectWrapper
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x00071060 File Offset: 0x0006F260
		// Note: this type is marked as 'beforefieldinit'.
		static XDocumentTypeWrapper()
		{
			Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Converters", "XDocumentTypeWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr);
			XDocumentTypeWrapper.NativeFieldInfoPtr__documentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, "_documentType");
			XDocumentTypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667226);
			XDocumentTypeWrapper.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667227);
			XDocumentTypeWrapper.NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667228);
			XDocumentTypeWrapper.NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667229);
			XDocumentTypeWrapper.NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667230);
			XDocumentTypeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr, 100667231);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0007111C File Offset: 0x0006F31C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 765266, RefRangeEnd = 765267, XrefRangeStart = 765263, XrefRangeEnd = 765266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocumentTypeWrapper(XDocumentType documentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocumentTypeWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(documentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentTypeWrapper.NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x00071168 File Offset: 0x0006F368
		public unsafe virtual string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565625, RefRangeEnd = 565626, XrefRangeStart = 565625, XrefRangeEnd = 565626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentTypeWrapper.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000711A0 File Offset: 0x0006F3A0
		public unsafe virtual string System
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentTypeWrapper.NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x000711D8 File Offset: 0x0006F3D8
		public unsafe virtual string Public
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentTypeWrapper.NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00071210 File Offset: 0x0006F410
		public unsafe virtual string InternalSubset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 565624, RefRangeEnd = 565625, XrefRangeStart = 565624, XrefRangeEnd = 565625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentTypeWrapper.NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x00071248 File Offset: 0x0006F448
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765267, XrefRangeEnd = 765269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentTypeWrapper.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0000842B File Offset: 0x0000662B
		public XDocumentTypeWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0007128C File Offset: 0x0006F48C
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00008434 File Offset: 0x00006634
		public unsafe XDocumentType _documentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentTypeWrapper.NativeFieldInfoPtr__documentType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XDocumentType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentTypeWrapper.NativeFieldInfoPtr__documentType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeFieldInfoPtr__documentType;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_get_System_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;
	}
}

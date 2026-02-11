using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000044 RID: 68
	public class XmlParserContext : Object
	{
		// Token: 0x0600050B RID: 1291 RVA: 0x0002B8BC File Offset: 0x00029ABC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlParserContext()
		{
			Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlParserContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr);
			XmlParserContext.NativeFieldInfoPtr__nt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nt");
			XmlParserContext.NativeFieldInfoPtr__nsMgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_nsMgr");
			XmlParserContext.NativeFieldInfoPtr__docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_docTypeName");
			XmlParserContext.NativeFieldInfoPtr__pubId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_pubId");
			XmlParserContext.NativeFieldInfoPtr__sysId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_sysId");
			XmlParserContext.NativeFieldInfoPtr__internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_internalSubset");
			XmlParserContext.NativeFieldInfoPtr__xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlLang");
			XmlParserContext.NativeFieldInfoPtr__xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_xmlSpace");
			XmlParserContext.NativeFieldInfoPtr__baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_baseURI");
			XmlParserContext.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, "_encoding");
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664064);
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664065);
			XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664066);
			XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664067);
			XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664068);
			XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664069);
			XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664070);
			XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664071);
			XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664072);
			XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664073);
			XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664074);
			XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664075);
			XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664076);
			XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr, 100664077);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0002BACC File Offset: 0x00029CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 366260, RefRangeEnd = 366261, XrefRangeStart = 366257, XrefRangeEnd = 366260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002BB4C File Offset: 0x00029D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366262, RefRangeEnd = 366264, XrefRangeStart = 366261, XrefRangeEnd = 366262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002BC2C File Offset: 0x00029E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 366303, RefRangeEnd = 366305, XrefRangeStart = 366264, XrefRangeEnd = 366303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlParserContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsMgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pubId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sysId);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseURI);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlLang);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmlSpace;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0002BD20 File Offset: 0x00029F20
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0002BD60 File Offset: 0x00029F60
		public unsafe XmlNamespaceManager NamespaceManager
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		public unsafe string DocTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0002BDD8 File Offset: 0x00029FD8
		public unsafe string PublicId
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0002BE10 File Offset: 0x0002A010
		public unsafe string SystemId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0002BE48 File Offset: 0x0002A048
		public unsafe string BaseURI
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_BaseURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0002BE80 File Offset: 0x0002A080
		public unsafe string InternalSubset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		public unsafe string XmlLang
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlLang_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
		public unsafe XmlSpace XmlSpace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0002BF2C File Offset: 0x0002A12C
		public unsafe Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0002BF6C File Offset: 0x0002A16C
		public unsafe bool HasDtdInfo
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 366315, RefRangeEnd = 366319, XrefRangeStart = 366308, XrefRangeEnd = 366315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlParserContext.NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00003AD3 File Offset: 0x00001CD3
		public XmlParserContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0002BFA8 File Offset: 0x0002A1A8
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00003ADC File Offset: 0x00001CDC
		public unsafe XmlNameTable _nt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0002BFD8 File Offset: 0x0002A1D8
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00003AFB File Offset: 0x00001CFB
		public unsafe XmlNamespaceManager _nsMgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__nsMgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0002C008 File Offset: 0x0002A208
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00003B1A File Offset: 0x00001D1A
		public unsafe string _docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__docTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0002C030 File Offset: 0x0002A230
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00003B39 File Offset: 0x00001D39
		public unsafe string _pubId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__pubId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0002C058 File Offset: 0x0002A258
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00003B58 File Offset: 0x00001D58
		public unsafe string _sysId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__sysId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0002C080 File Offset: 0x0002A280
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003B77 File Offset: 0x00001D77
		public unsafe string _internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003B96 File Offset: 0x00001D96
		public unsafe string _xmlLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public unsafe XmlSpace _xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__xmlSpace)) = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public unsafe string _baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0002C120 File Offset: 0x0002A320
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003BEF File Offset: 0x00001DEF
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlParserContext.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr__nt;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr__nsMgr;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__docTypeName;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr__pubId;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr__sysId;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr__internalSubset;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr__xmlLang;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr__xmlSpace;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr__baseURI;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_XmlSpace_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_XmlNamespaceManager_String_String_String_String_String_String_XmlSpace_Encoding_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceManager_Public_get_XmlNamespaceManager_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeName_Public_get_String_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_get_String_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlLang_Public_get_String_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlSpace_Public_get_XmlSpace_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDtdInfo_Internal_get_Boolean_0;
	}
}

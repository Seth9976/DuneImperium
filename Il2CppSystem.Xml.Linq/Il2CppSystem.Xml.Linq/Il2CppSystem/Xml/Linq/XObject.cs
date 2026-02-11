using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000018 RID: 24
	public class XObject : Object
	{
		// Token: 0x0600011D RID: 285 RVA: 0x000076CC File Offset: 0x000058CC
		// Note: this type is marked as 'beforefieldinit'.
		static XObject()
		{
			Il2CppClassPointerStore<XObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XObject>.NativeClassPtr);
			XObject.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObject>.NativeClassPtr, "parent");
			XObject.NativeFieldInfoPtr_annotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XObject>.NativeClassPtr, "annotations");
			XObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663503);
			XObject.NativeMethodInfoPtr_get_BaseUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663504);
			XObject.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663505);
			XObject.NativeMethodInfoPtr_get_Parent_Public_get_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663506);
			XObject.NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663507);
			XObject.NativeMethodInfoPtr_AnnotationForSealedType_Private_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663508);
			XObject.NativeMethodInfoPtr_Annotation_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663509);
			XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663510);
			XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663511);
			XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663512);
			XObject.NativeMethodInfoPtr_get_HasBaseUri_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663513);
			XObject.NativeMethodInfoPtr_NotifyChanged_Internal_Boolean_Object_XObjectChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663514);
			XObject.NativeMethodInfoPtr_NotifyChanging_Internal_Boolean_Object_XObjectChangeEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663515);
			XObject.NativeMethodInfoPtr_SetBaseUri_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663516);
			XObject.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663517);
			XObject.NativeMethodInfoPtr_SkipNotify_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663518);
			XObject.NativeMethodInfoPtr_GetSaveOptionsFromAnnotations_Internal_SaveOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XObject>.NativeClassPtr, 100663519);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00007878 File Offset: 0x00005A78
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000078B4 File Offset: 0x00005AB4
		public unsafe string BaseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238376, XrefRangeEnd = 1238382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_get_BaseUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000078EC File Offset: 0x00005AEC
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XObject.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00007934 File Offset: 0x00005B34
		public unsafe XElement Parent
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1238383, RefRangeEnd = 1238391, XrefRangeStart = 1238382, XrefRangeEnd = 1238383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_get_Parent_Public_get_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr3) : null;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00007974 File Offset: 0x00005B74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238415, RefRangeEnd = 1238418, XrefRangeStart = 1238391, XrefRangeEnd = 1238415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAnnotation(Object annotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(annotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000079B8 File Offset: 0x00005BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238418, XrefRangeEnd = 1238433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object AnnotationForSealedType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_AnnotationForSealedType_Private_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00007A08 File Offset: 0x00005C08
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1238449, RefRangeEnd = 1238459, XrefRangeStart = 1238433, XrefRangeEnd = 1238449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Annotation<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.MethodInfoStoreGeneric_Annotation_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007A44 File Offset: 0x00005C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238459, XrefRangeEnd = 1238462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Xml_IXmlLineInfo_HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00007A80 File Offset: 0x00005C80
		public unsafe virtual int System.Xml.IXmlLineInfo.LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238462, XrefRangeEnd = 1238465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00007ABC File Offset: 0x00005CBC
		public unsafe virtual int System.Xml.IXmlLineInfo.LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238465, XrefRangeEnd = 1238468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00007AF8 File Offset: 0x00005CF8
		public unsafe bool HasBaseUri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238468, XrefRangeEnd = 1238471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_get_HasBaseUri_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007B34 File Offset: 0x00005D34
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1238476, RefRangeEnd = 1238487, XrefRangeStart = 1238471, XrefRangeEnd = 1238476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotifyChanged(Object sender, XObjectChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_NotifyChanged_Internal_Boolean_Object_XObjectChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00007B94 File Offset: 0x00005D94
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1238492, RefRangeEnd = 1238503, XrefRangeStart = 1238487, XrefRangeEnd = 1238492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotifyChanging(Object sender, XObjectChangeEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_NotifyChanging_Internal_Boolean_Object_XObjectChangeEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00007BF4 File Offset: 0x00005DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238509, RefRangeEnd = 1238511, XrefRangeStart = 1238503, XrefRangeEnd = 1238509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBaseUri(string baseUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_SetBaseUri_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00007C38 File Offset: 0x00005E38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238516, RefRangeEnd = 1238520, XrefRangeStart = 1238511, XrefRangeEnd = 1238516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(int lineNumber, int linePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00007C84 File Offset: 0x00005E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238520, XrefRangeEnd = 1238525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SkipNotify()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_SkipNotify_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007CC0 File Offset: 0x00005EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238550, RefRangeEnd = 1238551, XrefRangeStart = 1238525, XrefRangeEnd = 1238550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveOptions GetSaveOptionsFromAnnotations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XObject.NativeMethodInfoPtr_GetSaveOptionsFromAnnotations_Internal_SaveOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000025AC File Offset: 0x000007AC
		public XObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00007CFC File Offset: 0x00005EFC
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000025B5 File Offset: 0x000007B5
		public unsafe XContainer parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObject.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObject.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00007D2C File Offset: 0x00005F2C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000025D4 File Offset: 0x000007D4
		public unsafe Object annotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObject.NativeFieldInfoPtr_annotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XObject.NativeFieldInfoPtr_annotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_annotations;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUri_Public_get_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_XElement_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_AddAnnotation_Public_Void_Object_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_AnnotationForSealedType_Private_Object_Type_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Annotation_Public_T_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_HasLineInfo_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlLineInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBaseUri_Internal_get_Boolean_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_NotifyChanged_Internal_Boolean_Object_XObjectChangeEventArgs_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_NotifyChanging_Internal_Boolean_Object_XObjectChangeEventArgs_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseUri_Internal_Void_String_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_SkipNotify_Internal_Boolean_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveOptionsFromAnnotations_Internal_SaveOptions_0;

		// Token: 0x02000028 RID: 40
		private sealed class MethodInfoStoreGeneric_Annotation_Public_T_0<T>
		{
			// Token: 0x04000159 RID: 345
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(XObject.NativeMethodInfoPtr_Annotation_Public_T_0, Il2CppClassPointerStore<XObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

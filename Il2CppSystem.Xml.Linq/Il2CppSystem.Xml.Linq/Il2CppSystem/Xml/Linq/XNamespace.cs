using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000016 RID: 22
	public sealed class XNamespace : Object
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00006B8C File Offset: 0x00004D8C
		// Note: this type is marked as 'beforefieldinit'.
		static XNamespace()
		{
			Il2CppClassPointerStore<XNamespace>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XNamespace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XNamespace>.NativeClassPtr);
			XNamespace.NativeFieldInfoPtr_s_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "s_namespaces");
			XNamespace.NativeFieldInfoPtr_s_refNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "s_refNone");
			XNamespace.NativeFieldInfoPtr_s_refXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "s_refXml");
			XNamespace.NativeFieldInfoPtr_s_refXmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "s_refXmlns");
			XNamespace.NativeFieldInfoPtr__namespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "_namespaceName");
			XNamespace.NativeFieldInfoPtr__hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "_hashCode");
			XNamespace.NativeFieldInfoPtr__names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, "_names");
			XNamespace.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663478);
			XNamespace.NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663479);
			XNamespace.NativeMethodInfoPtr_GetName_Public_XName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663480);
			XNamespace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663481);
			XNamespace.NativeMethodInfoPtr_get_None_Public_Static_get_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663482);
			XNamespace.NativeMethodInfoPtr_get_Xml_Public_Static_get_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663483);
			XNamespace.NativeMethodInfoPtr_get_Xmlns_Public_Static_get_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663484);
			XNamespace.NativeMethodInfoPtr_Get_Public_Static_XNamespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663485);
			XNamespace.NativeMethodInfoPtr_op_Implicit_Public_Static_XNamespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663486);
			XNamespace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663487);
			XNamespace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663488);
			XNamespace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XNamespace_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663489);
			XNamespace.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XNamespace_XNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663490);
			XNamespace.NativeMethodInfoPtr_GetName_Internal_XName_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663491);
			XNamespace.NativeMethodInfoPtr_Get_Internal_Static_XNamespace_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663492);
			XNamespace.NativeMethodInfoPtr_ExtractLocalName_Private_Static_String_XName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663493);
			XNamespace.NativeMethodInfoPtr_ExtractNamespace_Private_Static_String_WeakReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663494);
			XNamespace.NativeMethodInfoPtr_EnsureNamespace_Private_Static_XNamespace_byref_WeakReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XNamespace>.NativeClassPtr, 100663495);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238170, RefRangeEnd = 1238171, XrefRangeStart = 1238154, XrefRangeEnd = 1238170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XNamespace(string namespaceName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XNamespace>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00006DFC File Offset: 0x00004FFC
		public unsafe string NamespaceName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00006E34 File Offset: 0x00005034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238171, XrefRangeEnd = 1238172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XName GetName(string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_GetName_Public_XName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00006E84 File Offset: 0x00005084
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00006EBC File Offset: 0x000050BC
		public unsafe static XNamespace None
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238177, RefRangeEnd = 1238178, XrefRangeStart = 1238172, XrefRangeEnd = 1238177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_get_None_Public_Static_get_XNamespace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00006EF0 File Offset: 0x000050F0
		public unsafe static XNamespace Xml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238178, XrefRangeEnd = 1238183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_get_Xml_Public_Static_get_XNamespace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006F24 File Offset: 0x00005124
		public unsafe static XNamespace Xmlns
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238183, XrefRangeEnd = 1238188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_get_Xmlns_Public_Static_get_XNamespace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006F58 File Offset: 0x00005158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238188, XrefRangeEnd = 1238195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XNamespace Get(string namespaceName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_Get_Public_Static_XNamespace_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006F9C File Offset: 0x0000519C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1238196, RefRangeEnd = 1238199, XrefRangeStart = 1238195, XrefRangeEnd = 1238196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator XNamespace(string namespaceName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_op_Implicit_Public_Static_XNamespace_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006FE0 File Offset: 0x000051E0
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007030 File Offset: 0x00005230
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000706C File Offset: 0x0000526C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 378270, XrefRangeStart = 376359, XrefRangeEnd = 378270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(XNamespace left, XNamespace right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XNamespace_XNamespace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000070C0 File Offset: 0x000052C0
		[CallerCount(736)]
		[CachedScanResults(RefRangeStart = 974210, RefRangeEnd = 974946, XrefRangeStart = 974210, XrefRangeEnd = 974946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(XNamespace left, XNamespace right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XNamespace_XNamespace_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007114 File Offset: 0x00005314
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1238216, RefRangeEnd = 1238225, XrefRangeStart = 1238199, XrefRangeEnd = 1238216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XName GetName(string localName, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_GetName_Internal_XName_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XName>(intPtr3) : null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007180 File Offset: 0x00005380
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1238271, RefRangeEnd = 1238283, XrefRangeStart = 1238225, XrefRangeEnd = 1238271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XNamespace Get(string namespaceName, int index, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_Get_Internal_Static_XNamespace_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr3) : null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000071E0 File Offset: 0x000053E0
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 393222, RefRangeEnd = 393273, XrefRangeStart = 393222, XrefRangeEnd = 393273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractLocalName(XName n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_ExtractLocalName_Private_Static_String_XName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000721C File Offset: 0x0000541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238283, XrefRangeEnd = 1238285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractNamespace(WeakReference r)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_ExtractNamespace_Private_Static_String_WeakReference_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00007258 File Offset: 0x00005458
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238288, RefRangeEnd = 1238292, XrefRangeStart = 1238285, XrefRangeEnd = 1238288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(refNmsp);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XNamespace.NativeMethodInfoPtr_EnsureNamespace_Private_Static_XNamespace_byref_WeakReference_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			refNmsp = ((intPtr4 == 0) ? null : new WeakReference(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<XNamespace>(intPtr5) : null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000024DA File Offset: 0x000006DA
		public XNamespace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000072C8 File Offset: 0x000054C8
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000024E3 File Offset: 0x000006E3
		public unsafe static XHashtable<WeakReference> s_namespaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XNamespace.NativeFieldInfoPtr_s_namespaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XHashtable<WeakReference>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XNamespace.NativeFieldInfoPtr_s_namespaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000072F0 File Offset: 0x000054F0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000024F5 File Offset: 0x000006F5
		public unsafe static WeakReference s_refNone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XNamespace.NativeFieldInfoPtr_s_refNone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XNamespace.NativeFieldInfoPtr_s_refNone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00007318 File Offset: 0x00005518
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002507 File Offset: 0x00000707
		public unsafe static WeakReference s_refXml
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XNamespace.NativeFieldInfoPtr_s_refXml, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XNamespace.NativeFieldInfoPtr_s_refXml, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00007340 File Offset: 0x00005540
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002519 File Offset: 0x00000719
		public unsafe static WeakReference s_refXmlns
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XNamespace.NativeFieldInfoPtr_s_refXmlns, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XNamespace.NativeFieldInfoPtr_s_refXmlns, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00007368 File Offset: 0x00005568
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000252B File Offset: 0x0000072B
		public unsafe string _namespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__namespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__namespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00007390 File Offset: 0x00005590
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000254A File Offset: 0x0000074A
		public unsafe int _hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__hashCode)) = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000073B8 File Offset: 0x000055B8
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002565 File Offset: 0x00000765
		public unsafe XHashtable<XName> _names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XHashtable<XName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XNamespace.NativeFieldInfoPtr__names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_s_namespaces;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_s_refNone;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_s_refXml;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_s_refXmlns;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr__namespaceName;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr__hashCode;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr__names;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceName_Public_get_String_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_XName_String_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_get_None_Public_Static_get_XNamespace_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_get_Xml_Public_Static_get_XNamespace_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_get_Xmlns_Public_Static_get_XNamespace_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_XNamespace_String_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_XNamespace_String_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_XNamespace_XNamespace_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_XNamespace_XNamespace_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Internal_XName_String_Int32_Int32_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_XNamespace_String_Int32_Int32_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_ExtractLocalName_Private_Static_String_XName_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_ExtractNamespace_Private_Static_String_WeakReference_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNamespace_Private_Static_XNamespace_byref_WeakReference_String_0;
	}
}

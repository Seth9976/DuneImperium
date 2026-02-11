using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200000B RID: 11
	public class XDocument : XContainer
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00004690 File Offset: 0x00002890
		// Note: this type is marked as 'beforefieldinit'.
		static XDocument()
		{
			Il2CppClassPointerStore<XDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDocument>.NativeClassPtr);
			XDocument.NativeFieldInfoPtr__declaration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocument>.NativeClassPtr, "_declaration");
			XDocument.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663379);
			XDocument.NativeMethodInfoPtr__ctor_Public_Void_XDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663380);
			XDocument.NativeMethodInfoPtr_get_Declaration_Public_get_XDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663381);
			XDocument.NativeMethodInfoPtr_set_Declaration_Public_set_Void_XDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663382);
			XDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663383);
			XDocument.NativeMethodInfoPtr_get_Root_Public_get_XElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663384);
			XDocument.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663385);
			XDocument.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663386);
			XDocument.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663387);
			XDocument.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663388);
			XDocument.NativeMethodInfoPtr_GetFirstNode_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663389);
			XDocument.NativeMethodInfoPtr_IsWhitespace_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663390);
			XDocument.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663391);
			XDocument.NativeMethodInfoPtr_ValidateDocument_Private_Void_XNode_XmlNodeType_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663392);
			XDocument.NativeMethodInfoPtr_ValidateString_Internal_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocument>.NativeClassPtr, 100663393);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00004800 File Offset: 0x00002A00
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocument()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocument>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000483C File Offset: 0x00002A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237568, XrefRangeEnd = 1237577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocument(XDocument other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr__ctor_Public_Void_XDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004888 File Offset: 0x00002A88
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000048C8 File Offset: 0x00002AC8
		public unsafe XDeclaration Declaration
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr_get_Declaration_Public_get_XDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XDeclaration>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr_set_Declaration_Public_set_Void_XDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000490C File Offset: 0x00002B0C
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004954 File Offset: 0x00002B54
		public unsafe XElement Root
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1237580, RefRangeEnd = 1237582, XrefRangeStart = 1237577, XrefRangeEnd = 1237580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr_get_Root_Public_get_XElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004994 File Offset: 0x00002B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237582, XrefRangeEnd = 1237597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000049E4 File Offset: 0x00002BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237597, XrefRangeEnd = 1237603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAttribute(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00004A34 File Offset: 0x00002C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237603, XrefRangeEnd = 1237609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddAttributeSkipNotify(XAttribute a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004A84 File Offset: 0x00002C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237609, XrefRangeEnd = 1237621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XNode CloneNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237628, RefRangeEnd = 1237629, XrefRangeStart = 1237621, XrefRangeEnd = 1237628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetFirstNode<T>() where T : XNode
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.MethodInfoStoreGeneric_GetFirstNode_Private_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004B0C File Offset: 0x00002D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237629, XrefRangeEnd = 1237631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWhitespace(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr_IsWhitespace_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004B50 File Offset: 0x00002D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237631, XrefRangeEnd = 1237633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateNode(XNode node, XNode previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004BB0 File Offset: 0x00002DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237636, RefRangeEnd = 1237637, XrefRangeStart = 1237633, XrefRangeEnd = 1237636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowBefore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowAfter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocument.NativeMethodInfoPtr_ValidateDocument_Private_Void_XNode_XmlNodeType_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004C10 File Offset: 0x00002E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237637, XrefRangeEnd = 1237639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateString(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocument.NativeMethodInfoPtr_ValidateString_Internal_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002227 File Offset: 0x00000427
		public XDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004C60 File Offset: 0x00002E60
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002230 File Offset: 0x00000430
		public unsafe XDeclaration _declaration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocument.NativeFieldInfoPtr__declaration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XDeclaration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocument.NativeFieldInfoPtr__declaration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__declaration;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XDocument_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_Declaration_Public_get_XDeclaration_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_set_Declaration_Public_set_Void_XDeclaration_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_Root_Public_get_XElement_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Internal_Virtual_Void_XAttribute_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeSkipNotify_Internal_Virtual_Void_XAttribute_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstNode_Private_T_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_IsWhitespace_Internal_Static_Boolean_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_ValidateNode_Internal_Virtual_Void_XNode_XNode_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDocument_Private_Void_XNode_XmlNodeType_XmlNodeType_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ValidateString_Internal_Virtual_Void_String_0;

		// Token: 0x02000023 RID: 35
		private sealed class MethodInfoStoreGeneric_GetFirstNode_Private_T_0<T>
		{
			// Token: 0x04000138 RID: 312
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(XDocument.NativeMethodInfoPtr_GetFirstNode_Private_T_0, Il2CppClassPointerStore<XDocument>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

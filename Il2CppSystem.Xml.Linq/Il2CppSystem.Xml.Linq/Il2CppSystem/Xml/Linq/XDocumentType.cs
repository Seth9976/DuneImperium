using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200000C RID: 12
	public class XDocumentType : XNode
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00004C90 File Offset: 0x00002E90
		// Note: this type is marked as 'beforefieldinit'.
		static XDocumentType()
		{
			Il2CppClassPointerStore<XDocumentType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XDocumentType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr);
			XDocumentType.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, "_name");
			XDocumentType.NativeFieldInfoPtr__publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, "_publicId");
			XDocumentType.NativeFieldInfoPtr__systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, "_systemId");
			XDocumentType.NativeFieldInfoPtr__internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, "_internalSubset");
			XDocumentType.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663394);
			XDocumentType.NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663395);
			XDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663396);
			XDocumentType.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663397);
			XDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663398);
			XDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663399);
			XDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663400);
			XDocumentType.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663401);
			XDocumentType.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr, 100663402);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004DC4 File Offset: 0x00002FC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1237648, RefRangeEnd = 1237649, XrefRangeStart = 1237639, XrefRangeEnd = 1237648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocumentType(string name, string publicId, string systemId, string internalSubset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004E48 File Offset: 0x00003048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237649, XrefRangeEnd = 1237660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XDocumentType(XDocumentType other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XDocumentType>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004E94 File Offset: 0x00003094
		public unsafe string InternalSubset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004ECC File Offset: 0x000030CC
		public unsafe string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004F04 File Offset: 0x00003104
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004F4C File Offset: 0x0000314C
		public unsafe string PublicId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004F84 File Offset: 0x00003184
		public unsafe string SystemId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004FBC File Offset: 0x000031BC
		[CallerCount(0)]
		public unsafe override void WriteTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentType.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000500C File Offset: 0x0000320C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237660, XrefRangeEnd = 1237668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XNode CloneNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XDocumentType.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000224F File Offset: 0x0000044F
		public XDocumentType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00002258 File Offset: 0x00000458
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005080 File Offset: 0x00003280
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002277 File Offset: 0x00000477
		public unsafe string _publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000050A8 File Offset: 0x000032A8
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002296 File Offset: 0x00000496
		public unsafe string _systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000050D0 File Offset: 0x000032D0
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000022B5 File Offset: 0x000004B5
		public unsafe string _internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XDocumentType.NativeFieldInfoPtr__internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr__publicId;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__systemId;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__internalSubset;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XDocumentType_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0;
	}
}

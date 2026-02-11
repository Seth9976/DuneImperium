using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001AF RID: 431
	public class XmlSchemaDocumentation : XmlSchemaObject
	{
		// Token: 0x06002545 RID: 9541 RVA: 0x000B01B4 File Offset: 0x000AE3B4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaDocumentation()
		{
			Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDocumentation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr);
			XmlSchemaDocumentation.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "source");
			XmlSchemaDocumentation.NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "language");
			XmlSchemaDocumentation.NativeFieldInfoPtr_markup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "markup");
			XmlSchemaDocumentation.NativeFieldInfoPtr_languageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, "languageType");
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668704);
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Language_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668705);
			XmlSchemaDocumentation.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668706);
			XmlSchemaDocumentation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr, 100668707);
		}

		// Token: 0x17000CAD RID: 3245
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000B0284 File Offset: 0x000AE484
		public unsafe string Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Source_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (set) Token: 0x06002547 RID: 9543 RVA: 0x000B02C8 File Offset: 0x000AE4C8
		public unsafe string Language
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411882, RefRangeEnd = 411883, XrefRangeStart = 411870, XrefRangeEnd = 411882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Language_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000B030C File Offset: 0x000AE50C
		public unsafe Il2CppReferenceArray<XmlNode> Markup
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000B0350 File Offset: 0x000AE550
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDocumentation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaDocumentation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDocumentation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0000FB3D File Offset: 0x0000DD3D
		public XmlSchemaDocumentation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000B038C File Offset: 0x000AE58C
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x0000FB46 File Offset: 0x0000DD46
		public unsafe string source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000B03B4 File Offset: 0x000AE5B4
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x0000FB65 File Offset: 0x0000DD65
		public unsafe string language
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_language);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_language), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x000B03DC File Offset: 0x000AE5DC
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0000FB84 File Offset: 0x0000DD84
		public unsafe Il2CppReferenceArray<XmlNode> markup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_markup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaDocumentation.NativeFieldInfoPtr_markup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000B040C File Offset: 0x000AE60C
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x0000FBA3 File Offset: 0x0000DDA3
		public unsafe static XmlSchemaSimpleType languageType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSchemaDocumentation.NativeFieldInfoPtr_languageType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSchemaDocumentation.NativeFieldInfoPtr_languageType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeFieldInfoPtr_language;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_markup;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_languageType;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Public_set_Void_String_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_set_Language_Public_set_Void_String_0;

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr_set_Markup_Public_set_Void_Il2CppReferenceArray_1_XmlNode_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

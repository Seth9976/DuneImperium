using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005B RID: 91
	public class AttributePSVIInfo : Object
	{
		// Token: 0x06000ABB RID: 2747 RVA: 0x000447B8 File Offset: 0x000429B8
		// Note: this type is marked as 'beforefieldinit'.
		static AttributePSVIInfo()
		{
			Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "AttributePSVIInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr);
			AttributePSVIInfo.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "localName");
			AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "namespaceUri");
			AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "typedAttributeValue");
			AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, "attributeSchemaInfo");
			AttributePSVIInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, 100665083);
			AttributePSVIInfo.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr, 100665084);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00044860 File Offset: 0x00042A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372878, RefRangeEnd = 372879, XrefRangeStart = 372872, XrefRangeEnd = 372878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePSVIInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributePSVIInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributePSVIInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0004489C File Offset: 0x00042A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 372887, RefRangeEnd = 372888, XrefRangeStart = 372879, XrefRangeEnd = 372887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributePSVIInfo.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0000586C File Offset: 0x00003A6C
		public AttributePSVIInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x000448D0 File Offset: 0x00042AD0
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00005875 File Offset: 0x00003A75
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x000448F8 File Offset: 0x00042AF8
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x00005894 File Offset: 0x00003A94
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x00044920 File Offset: 0x00042B20
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x000058B3 File Offset: 0x00003AB3
		public unsafe Object typedAttributeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_typedAttributeValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x00044950 File Offset: 0x00042B50
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x000058D2 File Offset: 0x00003AD2
		public unsafe XmlSchemaInfo attributeSchemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePSVIInfo.NativeFieldInfoPtr_attributeSchemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_typedAttributeValue;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_attributeSchemaInfo;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200006D RID: 109
	public class XmlImplementation : Object
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x0005030C File Offset: 0x0004E50C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlImplementation()
		{
			Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlImplementation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr);
			XmlImplementation.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, "nameTable");
			XmlImplementation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100665481);
			XmlImplementation.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100665482);
			XmlImplementation.NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100665483);
			XmlImplementation.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr, 100665484);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x000503A0 File Offset: 0x0004E5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374627, XrefRangeEnd = 374633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlImplementation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlImplementation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x000503DC File Offset: 0x0004E5DC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlImplementation(XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlImplementation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlImplementation.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00050428 File Offset: 0x0004E628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 374633, XrefRangeEnd = 374637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocument CreateDocument()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlImplementation.NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00050474 File Offset: 0x0004E674
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlImplementation.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00006787 File Offset: 0x00004987
		public XmlImplementation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x000504B4 File Offset: 0x0004E6B4
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00006790 File Offset: 0x00004990
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlImplementation.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlImplementation.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocument_Public_Virtual_New_XmlDocument_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0;
	}
}

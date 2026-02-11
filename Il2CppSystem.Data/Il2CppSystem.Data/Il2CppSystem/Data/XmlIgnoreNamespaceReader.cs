using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007F RID: 127
	public sealed class XmlIgnoreNamespaceReader : XmlNodeReader
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlIgnoreNamespaceReader()
		{
			Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "XmlIgnoreNamespaceReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr);
			XmlIgnoreNamespaceReader.NativeFieldInfoPtr__namespacesToIgnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr, "_namespacesToIgnore");
			XmlIgnoreNamespaceReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr, 100665290);
			XmlIgnoreNamespaceReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr, 100665291);
			XmlIgnoreNamespaceReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr, 100665292);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0003D878 File Offset: 0x0003BA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 911123, RefRangeEnd = 911124, XrefRangeStart = 911115, XrefRangeEnd = 911123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlIgnoreNamespaceReader(XmlDocument xdoc, Il2CppStringArray namespacesToIgnore)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlIgnoreNamespaceReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xdoc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(namespacesToIgnore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreNamespaceReader.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0003D8D8 File Offset: 0x0003BAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911124, XrefRangeEnd = 911128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreNamespaceReader.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003D914 File Offset: 0x0003BB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 911128, XrefRangeEnd = 911139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlIgnoreNamespaceReader.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00005BD3 File Offset: 0x00003DD3
		public XmlIgnoreNamespaceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0003D950 File Offset: 0x0003BB50
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00005BDC File Offset: 0x00003DDC
		public unsafe List<string> _namespacesToIgnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIgnoreNamespaceReader.NativeFieldInfoPtr__namespacesToIgnore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlIgnoreNamespaceReader.NativeFieldInfoPtr__namespacesToIgnore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeFieldInfoPtr__namespacesToIgnore;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_Il2CppStringArray_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;
	}
}

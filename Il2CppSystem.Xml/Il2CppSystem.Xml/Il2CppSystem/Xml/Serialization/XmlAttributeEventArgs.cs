using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B5 RID: 181
	public class XmlAttributeEventArgs : EventArgs
	{
		// Token: 0x06001267 RID: 4711 RVA: 0x000675F4 File Offset: 0x000657F4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttributeEventArgs()
		{
			Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr);
			XmlAttributeEventArgs.NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, "o");
			XmlAttributeEventArgs.NativeFieldInfoPtr_attr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, "attr");
			XmlAttributeEventArgs.NativeFieldInfoPtr_qnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, "qnames");
			XmlAttributeEventArgs.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, "lineNumber");
			XmlAttributeEventArgs.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, "linePosition");
			XmlAttributeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlAttribute_Int32_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr, 100666340);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0006769C File Offset: 0x0006589C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383776, RefRangeEnd = 383778, XrefRangeStart = 383769, XrefRangeEnd = 383776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, Object o, string qnames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(qnames);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttributeEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlAttribute_Int32_Int32_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00007C3B File Offset: 0x00005E3B
		public XmlAttributeEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0006772C File Offset: 0x0006592C
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x00007C44 File Offset: 0x00005E44
		public unsafe Object o
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_o);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_o), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0006775C File Offset: 0x0006595C
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x00007C63 File Offset: 0x00005E63
		public unsafe XmlAttribute attr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_attr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_attr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0006778C File Offset: 0x0006598C
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00007C82 File Offset: 0x00005E82
		public unsafe string qnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_qnames);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_qnames), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000677B4 File Offset: 0x000659B4
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00007CA1 File Offset: 0x00005EA1
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x000677DC File Offset: 0x000659DC
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00007CBC File Offset: 0x00005EBC
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttributeEventArgs.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr_o;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr_attr;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr_qnames;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlAttribute_Int32_Int32_Object_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C3 RID: 195
	public class XmlTypeConvertorAttribute : Attribute
	{
		// Token: 0x060012DC RID: 4828 RVA: 0x00068CA8 File Offset: 0x00066EA8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeConvertorAttribute()
		{
			Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeConvertorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr);
			XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, "<Method>k__BackingField");
			XmlTypeConvertorAttribute.NativeMethodInfoPtr_get_Method_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, 100666373);
			XmlTypeConvertorAttribute.NativeMethodInfoPtr_set_Method_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, 100666374);
			XmlTypeConvertorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr, 100666375);
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00068D28 File Offset: 0x00066F28
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x00068D60 File Offset: 0x00066F60
		public unsafe string Method
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeConvertorAttribute.NativeMethodInfoPtr_get_Method_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeConvertorAttribute.NativeMethodInfoPtr_set_Method_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00068DA4 File Offset: 0x00066FA4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeConvertorAttribute(string method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeConvertorAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeConvertorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00008003 File Offset: 0x00006203
		public XmlTypeConvertorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x00068DF0 File Offset: 0x00066FF0
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000800C File Offset: 0x0000620C
		public unsafe string _Method_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeConvertorAttribute.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_String_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_set_Method_Private_set_Void_String_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

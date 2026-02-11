using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200018F RID: 399
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x000A372C File Offset: 0x000A192C
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventArgs()
		{
			Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr);
			ValidationEventArgs.NativeFieldInfoPtr_ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "ex");
			ValidationEventArgs.NativeFieldInfoPtr_severity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "severity");
			ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100668254);
			ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100668255);
			ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100668256);
			ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100668257);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000A37D4 File Offset: 0x000A19D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 408025, RefRangeEnd = 408029, XrefRangeStart = 408020, XrefRangeEnd = 408025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventArgs(XmlSchemaException ex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000A3820 File Offset: 0x000A1A20
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 408034, RefRangeEnd = 408049, XrefRangeStart = 408029, XrefRangeEnd = 408034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidationEventArgs(XmlSchemaException ex, XmlSeverityType severity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000A387C File Offset: 0x000A1A7C
		public unsafe XmlSeverityType Severity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000A38B8 File Offset: 0x000A1AB8
		public unsafe XmlSchemaException Exception
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr3) : null;
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x0000E643 File Offset: 0x0000C843
		public ValidationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000A38F8 File Offset: 0x000A1AF8
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x0000E64C File Offset: 0x0000C84C
		public unsafe XmlSchemaException ex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x000A3928 File Offset: 0x000A1B28
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x0000E66B File Offset: 0x0000C86B
		public unsafe XmlSeverityType severity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity)) = value;
			}
		}

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr_ex;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeFieldInfoPtr_severity;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaException_XmlSeverityType_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0;
	}
}

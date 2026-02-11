using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001CE RID: 462
	public class XmlSchemaNotation : XmlSchemaAnnotated
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x000B53BC File Offset: 0x000B35BC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaNotation()
		{
			Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaNotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr);
			XmlSchemaNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, "name");
			XmlSchemaNotation.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, "publicId");
			XmlSchemaNotation.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, "systemId");
			XmlSchemaNotation.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, "qname");
			XmlSchemaNotation.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668889);
			XmlSchemaNotation.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668890);
			XmlSchemaNotation.NativeMethodInfoPtr_get_Public_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668891);
			XmlSchemaNotation.NativeMethodInfoPtr_set_Public_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668892);
			XmlSchemaNotation.NativeMethodInfoPtr_get_System_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668893);
			XmlSchemaNotation.NativeMethodInfoPtr_set_System_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668894);
			XmlSchemaNotation.NativeMethodInfoPtr_get_QualifiedName_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668895);
			XmlSchemaNotation.NativeMethodInfoPtr_set_QualifiedName_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668896);
			XmlSchemaNotation.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668897);
			XmlSchemaNotation.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668898);
			XmlSchemaNotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr, 100668899);
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000B5518 File Offset: 0x000B3718
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x000B5550 File Offset: 0x000B3750
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x000B5594 File Offset: 0x000B3794
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x000B55CC File Offset: 0x000B37CC
		public unsafe string Public
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_get_Public_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_set_Public_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x000B5610 File Offset: 0x000B3810
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x000B5648 File Offset: 0x000B3848
		public unsafe string System
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_get_System_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_set_System_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000B568C File Offset: 0x000B388C
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x000B56CC File Offset: 0x000B38CC
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_get_QualifiedName_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr_set_QualifiedName_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x000B5710 File Offset: 0x000B3910
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x000B5754 File Offset: 0x000B3954
		public unsafe override string NameAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaNotation.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaNotation.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000B57A4 File Offset: 0x000B39A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412449, RefRangeEnd = 412450, XrefRangeStart = 412443, XrefRangeEnd = 412449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaNotation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaNotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaNotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00010778 File Offset: 0x0000E978
		public XmlSchemaNotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x000B57E0 File Offset: 0x000B39E0
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x00010781 File Offset: 0x0000E981
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x000B5808 File Offset: 0x000B3A08
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000B5830 File Offset: 0x000B3A30
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x000107BF File Offset: 0x0000E9BF
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x000B5858 File Offset: 0x000B3A58
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x000107DE File Offset: 0x0000E9DE
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaNotation.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_get_String_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_set_Public_Public_set_Void_String_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_get_System_Public_get_String_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_set_System_Public_set_Void_String_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_set_QualifiedName_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020002E0 RID: 736
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06002DAB RID: 11691 RVA: 0x000ED6B0 File Offset: 0x000EB8B0
		// Note: this type is marked as 'beforefieldinit'.
		static SoapMethodAttribute()
		{
			Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr);
			SoapMethodAttribute.NativeFieldInfoPtr__responseElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseElement");
			SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseNamespace");
			SoapMethodAttribute.NativeFieldInfoPtr__returnElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_returnElement");
			SoapMethodAttribute.NativeFieldInfoPtr__soapAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_soapAction");
			SoapMethodAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_useAttribute");
			SoapMethodAttribute.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_namespace");
			SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100670615);
			SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100670616);
			SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100670617);
			SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100670618);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x000ED7A8 File Offset: 0x000EB9A8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x000ED7E4 File Offset: 0x000EB9E4
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x000ED820 File Offset: 0x000EBA20
		public unsafe override string XmlNamespace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000ED858 File Offset: 0x000EBA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382142, XrefRangeEnd = 1382168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public SoapMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x000ED89C File Offset: 0x000EBA9C
		// (set) Token: 0x06002DB2 RID: 11698 RVA: 0x0000F5CD File Offset: 0x0000D7CD
		public unsafe string _responseElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x000ED8C4 File Offset: 0x000EBAC4
		// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		public unsafe string _responseNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000ED8EC File Offset: 0x000EBAEC
		// (set) Token: 0x06002DB6 RID: 11702 RVA: 0x0000F60B File Offset: 0x0000D80B
		public unsafe string _returnElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000ED914 File Offset: 0x000EBB14
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x0000F62A File Offset: 0x0000D82A
		public unsafe string _soapAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x000ED93C File Offset: 0x000EBB3C
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x0000F649 File Offset: 0x0000D849
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000ED964 File Offset: 0x000EBB64
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x0000F664 File Offset: 0x0000D864
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeFieldInfoPtr__responseElement;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeFieldInfoPtr__responseNamespace;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeFieldInfoPtr__returnElement;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeFieldInfoPtr__soapAction;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}

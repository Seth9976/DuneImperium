using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EE RID: 238
	public class XmlTypeAttribute : Attribute
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x00075124 File Offset: 0x00073324
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeAttribute()
		{
			Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr);
			XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "includeInSchema");
			XmlTypeAttribute.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "ns");
			XmlTypeAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, "typeName");
			XmlTypeAttribute.NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666791);
			XmlTypeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666792);
			XmlTypeAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666793);
			XmlTypeAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeAttribute>.NativeClassPtr, 100666794);
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000751E0 File Offset: 0x000733E0
		public unsafe bool IncludeInSchema
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x0007521C File Offset: 0x0007341C
		public unsafe string Namespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00075254 File Offset: 0x00073454
		public unsafe string TypeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 389586, RefRangeEnd = 389589, XrefRangeStart = 389585, XrefRangeEnd = 389586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0007528C File Offset: 0x0007348C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389597, RefRangeEnd = 389598, XrefRangeStart = 389589, XrefRangeEnd = 389597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyHash(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeAttribute.NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0000945E File Offset: 0x0000765E
		public XmlTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x000752D0 File Offset: 0x000734D0
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x00009467 File Offset: 0x00007667
		public unsafe bool includeInSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_includeInSchema)) = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x000752F8 File Offset: 0x000734F8
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x00009482 File Offset: 0x00007682
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x00075320 File Offset: 0x00073520
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x000094A1 File Offset: 0x000076A1
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeFieldInfoPtr_includeInSchema;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeInSchema_Public_get_Boolean_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyHash_Internal_Void_StringBuilder_0;
	}
}

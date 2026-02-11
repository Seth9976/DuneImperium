using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C2 RID: 194
	public class XmlTypeSerializationSource : SerializationSource
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x00068A48 File Offset: 0x00066C48
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeSerializationSource()
		{
			Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeSerializationSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr);
			XmlTypeSerializationSource.NativeFieldInfoPtr_attributeOverridesHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, "attributeOverridesHash");
			XmlTypeSerializationSource.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, "type");
			XmlTypeSerializationSource.NativeFieldInfoPtr_rootHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, "rootHash");
			XmlTypeSerializationSource.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlRootAttribute_XmlAttributeOverrides_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, 100666370);
			XmlTypeSerializationSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, 100666371);
			XmlTypeSerializationSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr, 100666372);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00068AF0 File Offset: 0x00066CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384022, RefRangeEnd = 384023, XrefRangeStart = 384006, XrefRangeEnd = 384022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Il2CppReferenceArray<Type> includedTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeSerializationSource>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeOverrides);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namspace);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includedTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeSerializationSource.NativeMethodInfoPtr__ctor_Public_Void_Type_XmlRootAttribute_XmlAttributeOverrides_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00068B88 File Offset: 0x00066D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384023, XrefRangeEnd = 384032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeSerializationSource.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00068BE0 File Offset: 0x00066DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384032, XrefRangeEnd = 384033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeSerializationSource.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00007F9D File Offset: 0x0000619D
		public XmlTypeSerializationSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00068C28 File Offset: 0x00066E28
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x00007FA6 File Offset: 0x000061A6
		public unsafe string attributeOverridesHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_attributeOverridesHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_attributeOverridesHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x00068C50 File Offset: 0x00066E50
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x00007FC5 File Offset: 0x000061C5
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x00068C80 File Offset: 0x00066E80
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x00007FE4 File Offset: 0x000061E4
		public unsafe string rootHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_rootHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeSerializationSource.NativeFieldInfoPtr_rootHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeFieldInfoPtr_attributeOverridesHash;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeFieldInfoPtr_rootHash;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_XmlRootAttribute_XmlAttributeOverrides_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

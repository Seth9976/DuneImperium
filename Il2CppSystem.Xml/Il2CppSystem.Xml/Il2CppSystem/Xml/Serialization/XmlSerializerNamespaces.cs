using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000B3 RID: 179
	public class XmlSerializerNamespaces : Object
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x000671BC File Offset: 0x000653BC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializerNamespaces()
		{
			Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializerNamespaces");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr);
			XmlSerializerNamespaces.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, "namespaces");
			XmlSerializerNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666330);
			XmlSerializerNamespaces.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666331);
			XmlSerializerNamespaces.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666332);
			XmlSerializerNamespaces.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666333);
			XmlSerializerNamespaces.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666334);
			XmlSerializerNamespaces.NativeMethodInfoPtr_get_NamespaceList_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666335);
			XmlSerializerNamespaces.NativeMethodInfoPtr_get_Namespaces_Internal_get_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666336);
			XmlSerializerNamespaces.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr, 100666337);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x000672A0 File Offset: 0x000654A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializerNamespaces()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializerNamespaces>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x000672DC File Offset: 0x000654DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 383687, RefRangeEnd = 383693, XrefRangeStart = 383674, XrefRangeEnd = 383687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string prefix, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00067330 File Offset: 0x00065530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383693, XrefRangeEnd = 383699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddInternal(string prefix, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00067384 File Offset: 0x00065584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 383709, RefRangeEnd = 383712, XrefRangeStart = 383699, XrefRangeEnd = 383709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<XmlQualifiedName> ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlQualifiedName>>(intPtr3) : null;
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000673C4 File Offset: 0x000655C4
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 383718, RefRangeEnd = 383719, XrefRangeStart = 383712, XrefRangeEnd = 383718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00067400 File Offset: 0x00065600
		public unsafe ArrayList NamespaceList
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 383758, RefRangeEnd = 383760, XrefRangeStart = 383719, XrefRangeEnd = 383758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_get_NamespaceList_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00067440 File Offset: 0x00065640
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00067480 File Offset: 0x00065680
		public unsafe Hashtable Namespaces
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 383765, RefRangeEnd = 383769, XrefRangeStart = 383760, XrefRangeEnd = 383765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_get_Namespaces_Internal_get_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerNamespaces.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Hashtable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00007BE3 File Offset: 0x00005DE3
		public XmlSerializerNamespaces(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x000674C4 File Offset: 0x000656C4
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x00007BEC File Offset: 0x00005DEC
		public unsafe Hashtable namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializerNamespaces.NativeFieldInfoPtr_namespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSerializerNamespaces.NativeFieldInfoPtr_namespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeMethodInfoPtr_AddInternal_Internal_Void_String_String_0;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Il2CppReferenceArray_1_XmlQualifiedName_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceList_Internal_get_ArrayList_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespaces_Internal_get_Hashtable_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Hashtable_0;
	}
}

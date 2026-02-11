using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EB RID: 235
	public class XmlSerializerFactory : Object
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x00074C98 File Offset: 0x00072E98
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSerializerFactory()
		{
			Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlSerializerFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr);
			XmlSerializerFactory.NativeFieldInfoPtr_serializersBySource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr, "serializersBySource");
			XmlSerializerFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr, 100666781);
			XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr, 100666782);
			XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlRootAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr, 100666783);
			XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr, 100666784);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00074D2C File Offset: 0x00072F2C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializerFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSerializerFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00074D68 File Offset: 0x00072F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389530, RefRangeEnd = 389531, XrefRangeStart = 389529, XrefRangeEnd = 389530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer CreateSerializer(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr3) : null;
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00074DB8 File Offset: 0x00072FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389532, RefRangeEnd = 389533, XrefRangeStart = 389531, XrefRangeEnd = 389532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer CreateSerializer(Type type, XmlRootAttribute root)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlRootAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr3) : null;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00074E1C File Offset: 0x0007301C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389568, RefRangeEnd = 389570, XrefRangeStart = 389533, XrefRangeEnd = 389568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Il2CppReferenceArray<Type> extraTypes, XmlRootAttribute root, string defaultNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrides);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSerializerFactory.NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSerializer>(intPtr3) : null;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x000093BA File Offset: 0x000075BA
		public XmlSerializerFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00074EB8 File Offset: 0x000730B8
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x000093C3 File Offset: 0x000075C3
		public unsafe static Hashtable serializersBySource
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlSerializerFactory.NativeFieldInfoPtr_serializersBySource, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlSerializerFactory.NativeFieldInfoPtr_serializersBySource, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr_serializersBySource;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlRootAttribute_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializer_Public_XmlSerializer_Type_XmlAttributeOverrides_Il2CppReferenceArray_1_Type_XmlRootAttribute_String_0;
	}
}

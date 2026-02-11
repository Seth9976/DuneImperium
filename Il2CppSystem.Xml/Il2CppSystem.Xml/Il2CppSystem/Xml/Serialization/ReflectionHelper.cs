using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BF RID: 191
	public class ReflectionHelper : Object
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x00068500 File Offset: 0x00066700
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionHelper()
		{
			Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "ReflectionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr);
			ReflectionHelper.NativeFieldInfoPtr__clrTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "_clrTypes");
			ReflectionHelper.NativeFieldInfoPtr__schemaTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "_schemaTypes");
			ReflectionHelper.NativeFieldInfoPtr_empty_modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, "empty_modifiers");
			ReflectionHelper.NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666361);
			ReflectionHelper.NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666362);
			ReflectionHelper.NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666363);
			ReflectionHelper.NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666364);
			ReflectionHelper.NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666365);
			ReflectionHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr, 100666366);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000685E4 File Offset: 0x000667E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383909, RefRangeEnd = 383910, XrefRangeStart = 383906, XrefRangeEnd = 383909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0006864C File Offset: 0x0006684C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 383914, RefRangeEnd = 383915, XrefRangeStart = 383910, XrefRangeEnd = 383914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000686B0 File Offset: 0x000668B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 383927, RefRangeEnd = 383933, XrefRangeStart = 383915, XrefRangeEnd = 383927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterClrType(XmlTypeMapping map, Type type, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(map);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00068718 File Offset: 0x00066918
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 383946, RefRangeEnd = 383953, XrefRangeStart = 383933, XrefRangeEnd = 383946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRegisteredClrType(Type type, string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0006877C File Offset: 0x0006697C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 383985, RefRangeEnd = 383990, XrefRangeStart = 383953, XrefRangeEnd = 383985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckSerializableType(Type type, bool allowPrivateConstructors)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowPrivateConstructors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000687C0 File Offset: 0x000669C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384000, RefRangeEnd = 384001, XrefRangeStart = 383990, XrefRangeEnd = 384000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00007EE2 File Offset: 0x000060E2
		public ReflectionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000687FC File Offset: 0x000669FC
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00007EEB File Offset: 0x000060EB
		public unsafe Hashtable _clrTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__clrTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__clrTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0006882C File Offset: 0x00066A2C
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00007F0A File Offset: 0x0000610A
		public unsafe Hashtable _schemaTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__schemaTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionHelper.NativeFieldInfoPtr__schemaTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0006885C File Offset: 0x00066A5C
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00007F29 File Offset: 0x00006129
		public unsafe static Il2CppReferenceArray<ParameterModifier> empty_modifiers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionHelper.NativeFieldInfoPtr_empty_modifiers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterModifier>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionHelper.NativeFieldInfoPtr_empty_modifiers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr__clrTypes;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr__schemaTypes;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr_empty_modifiers;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_RegisterSchemaType_Public_Void_XmlTypeMapping_String_String_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredSchemaType_Public_XmlTypeMapping_String_String_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_RegisterClrType_Public_Void_XmlTypeMapping_Type_String_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredClrType_Public_XmlTypeMapping_Type_String_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializableType_Public_Static_Void_Type_Boolean_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

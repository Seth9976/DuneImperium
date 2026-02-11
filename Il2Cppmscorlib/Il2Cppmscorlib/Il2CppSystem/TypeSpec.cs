using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x02000172 RID: 370
	public class TypeSpec : Object
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x0009B1C0 File Offset: 0x000993C0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeSpec()
		{
			Il2CppClassPointerStore<TypeSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr);
			TypeSpec.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "name");
			TypeSpec.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "assembly_name");
			TypeSpec.NativeFieldInfoPtr_nested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "nested");
			TypeSpec.NativeFieldInfoPtr_generic_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "generic_params");
			TypeSpec.NativeFieldInfoPtr_modifier_spec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "modifier_spec");
			TypeSpec.NativeFieldInfoPtr_is_byref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "is_byref");
			TypeSpec.NativeFieldInfoPtr_display_fullname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "display_fullname");
			TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667601);
			TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667602);
			TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667603);
			TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667604);
			TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667605);
			TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667606);
			TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667607);
			TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667608);
			TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667609);
			TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667610);
			TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667611);
			TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667612);
			TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667613);
			TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667614);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x0009B394 File Offset: 0x00099594
		public unsafe bool HasModifiers
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 480628, RefRangeEnd = 480631, XrefRangeStart = 480628, XrefRangeEnd = 480631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x0009B3D0 File Offset: 0x000995D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349682, RefRangeEnd = 1349684, XrefRangeStart = 1349631, XrefRangeEnd = 1349682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x0009B414 File Offset: 0x00099614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349703, RefRangeEnd = 1349704, XrefRangeStart = 1349684, XrefRangeEnd = 1349703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder GetModifierString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0009B464 File Offset: 0x00099664
		public unsafe string DisplayFullName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1349706, RefRangeEnd = 1349708, XrefRangeStart = 1349704, XrefRangeEnd = 1349706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x0009B49C File Offset: 0x0009969C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349709, RefRangeEnd = 1349710, XrefRangeStart = 1349708, XrefRangeEnd = 1349709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x0009B4E0 File Offset: 0x000996E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349710, XrefRangeEnd = 1349719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeInternalName(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0009B51C File Offset: 0x0009971C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349740, RefRangeEnd = 1349741, XrefRangeStart = 1349719, XrefRangeEnd = 1349740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0009B5AC File Offset: 0x000997AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1349757, RefRangeEnd = 1349761, XrefRangeStart = 1349741, XrefRangeEnd = 1349757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(string type_name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type_name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0009B5F0 File Offset: 0x000997F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349774, RefRangeEnd = 1349776, XrefRangeStart = 1349761, XrefRangeEnd = 1349774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(ModifierSpec md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0009B634 File Offset: 0x00099834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349776, XrefRangeEnd = 1349782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SkipSpace(string name, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0009B678 File Offset: 0x00099878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349782, RefRangeEnd = 1349784, XrefRangeStart = 1349782, XrefRangeEnd = 1349782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BoundCheck(int idx, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0009B6BC File Offset: 0x000998BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1349599, RefRangeEnd = 1349602, XrefRangeStart = 1349599, XrefRangeEnd = 1349602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0009B700 File Offset: 0x00099900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349883, RefRangeEnd = 1349885, XrefRangeStart = 1349784, XrefRangeEnd = 1349883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_recurse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allow_aqn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0009B770 File Offset: 0x00099970
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00008032 File Offset: 0x00006232
		public TypeSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0009B7AC File Offset: 0x000999AC
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000803B File Offset: 0x0000623B
		public unsafe TypeIdentifier name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0009B7DC File Offset: 0x000999DC
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000805A File Offset: 0x0000625A
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0009B804 File Offset: 0x00099A04
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00008079 File Offset: 0x00006279
		public unsafe List<TypeIdentifier> nested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0009B834 File Offset: 0x00099A34
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00008098 File Offset: 0x00006298
		public unsafe List<TypeSpec> generic_params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x0009B864 File Offset: 0x00099A64
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x000080B7 File Offset: 0x000062B7
		public unsafe List<ModifierSpec> modifier_spec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModifierSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x0009B894 File Offset: 0x00099A94
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x000080D6 File Offset: 0x000062D6
		public unsafe bool is_byref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref)) = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0009B8BC File Offset: 0x00099ABC
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x000080F1 File Offset: 0x000062F1
		public unsafe string display_fullname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_nested;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_generic_params;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_modifier_spec;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_is_byref;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_display_fullname;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_byref_StackCrawlMark_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_String_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005FA RID: 1530
		[Flags]
		public enum DisplayNameFormat
		{
			// Token: 0x04004849 RID: 18505
			Default = 0,
			// Token: 0x0400484A RID: 18506
			WANT_ASSEMBLY = 1,
			// Token: 0x0400484B RID: 18507
			NO_MODIFIERS = 2
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005B RID: 91
	public static class ImmutableCollectionsUtils : Object
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x00038C4C File Offset: 0x00036E4C
		// Note: this type is marked as 'beforefieldinit'.
		static ImmutableCollectionsUtils()
		{
			Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ImmutableCollectionsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr);
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericInterfaceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableListGenericInterfaceTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericInterfaceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableQueueGenericInterfaceTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericInterfaceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableStackGenericInterfaceTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSetGenericInterfaceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableSetGenericInterfaceTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableArrayTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableArrayGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableListTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableListGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableQueueTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableQueueGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableStackTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableStackGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableSortedSetTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableSortedSetGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableHashSetTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableHashSetGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ArrayContractImmutableCollectionDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ArrayContractImmutableCollectionDefinitions");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericInterfaceTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableDictionaryGenericInterfaceTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableDictionaryTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableDictionaryGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableSortedDictionaryTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryGenericTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableSortedDictionaryGenericTypeName");
			ImmutableCollectionsUtils.NativeFieldInfoPtr_DictionaryContractImmutableCollectionDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "DictionaryContractImmutableCollectionDefinitions");
			ImmutableCollectionsUtils.NativeMethodInfoPtr_TryBuildImmutableForArrayContract_Internal_Static_Boolean_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, 100664882);
			ImmutableCollectionsUtils.NativeMethodInfoPtr_TryBuildImmutableForDictionaryContract_Internal_Static_Boolean_Type_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, 100664883);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00038E70 File Offset: 0x00037070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743778, RefRangeEnd = 743779, XrefRangeStart = 743712, XrefRangeEnd = 743778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<Object> parameterizedCreator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collectionItemType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.NativeMethodInfoPtr_TryBuildImmutableForArrayContract_Internal_Static_Boolean_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			createdType = ((intPtr5 == 0) ? null : new Type(intPtr5));
			IntPtr intPtr6 = intPtr2;
			parameterizedCreator = ((intPtr6 == 0) ? null : new ObjectConstructor<Object>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00038F0C File Offset: 0x0003710C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743849, RefRangeEnd = 743850, XrefRangeStart = 743779, XrefRangeEnd = 743849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<Object> parameterizedCreator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyItemType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueItemType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.NativeMethodInfoPtr_TryBuildImmutableForDictionaryContract_Internal_Static_Boolean_Type_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			createdType = ((intPtr5 == 0) ? null : new Type(intPtr5));
			IntPtr intPtr6 = intPtr2;
			parameterizedCreator = ((intPtr6 == 0) ? null : new ObjectConstructor<Object>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00004984 File Offset: 0x00002B84
		public ImmutableCollectionsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00038FB8 File Offset: 0x000371B8
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0000498D File Offset: 0x00002B8D
		public unsafe static string ImmutableListGenericInterfaceTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericInterfaceTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericInterfaceTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00038FD8 File Offset: 0x000371D8
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0000499F File Offset: 0x00002B9F
		public unsafe static string ImmutableQueueGenericInterfaceTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericInterfaceTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericInterfaceTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00038FF8 File Offset: 0x000371F8
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x000049B1 File Offset: 0x00002BB1
		public unsafe static string ImmutableStackGenericInterfaceTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericInterfaceTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericInterfaceTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00039018 File Offset: 0x00037218
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x000049C3 File Offset: 0x00002BC3
		public unsafe static string ImmutableSetGenericInterfaceTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSetGenericInterfaceTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSetGenericInterfaceTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00039038 File Offset: 0x00037238
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x000049D5 File Offset: 0x00002BD5
		public unsafe static string ImmutableArrayTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00039058 File Offset: 0x00037258
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x000049E7 File Offset: 0x00002BE7
		public unsafe static string ImmutableArrayGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableArrayGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00039078 File Offset: 0x00037278
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x000049F9 File Offset: 0x00002BF9
		public unsafe static string ImmutableListTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00039098 File Offset: 0x00037298
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x00004A0B File Offset: 0x00002C0B
		public unsafe static string ImmutableListGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableListGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x000390B8 File Offset: 0x000372B8
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x00004A1D File Offset: 0x00002C1D
		public unsafe static string ImmutableQueueTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000390D8 File Offset: 0x000372D8
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00004A2F File Offset: 0x00002C2F
		public unsafe static string ImmutableQueueGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableQueueGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x000390F8 File Offset: 0x000372F8
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00004A41 File Offset: 0x00002C41
		public unsafe static string ImmutableStackTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00039118 File Offset: 0x00037318
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00004A53 File Offset: 0x00002C53
		public unsafe static string ImmutableStackGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableStackGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00039138 File Offset: 0x00037338
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00004A65 File Offset: 0x00002C65
		public unsafe static string ImmutableSortedSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00039158 File Offset: 0x00037358
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00004A77 File Offset: 0x00002C77
		public unsafe static string ImmutableSortedSetGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedSetGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00039178 File Offset: 0x00037378
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00004A89 File Offset: 0x00002C89
		public unsafe static string ImmutableHashSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00039198 File Offset: 0x00037398
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00004A9B File Offset: 0x00002C9B
		public unsafe static string ImmutableHashSetGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableHashSetGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000391B8 File Offset: 0x000373B8
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00004AAD File Offset: 0x00002CAD
		public unsafe static IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ArrayContractImmutableCollectionDefinitions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ArrayContractImmutableCollectionDefinitions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000391E0 File Offset: 0x000373E0
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00004ABF File Offset: 0x00002CBF
		public unsafe static string ImmutableDictionaryGenericInterfaceTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericInterfaceTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericInterfaceTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00039200 File Offset: 0x00037400
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public unsafe static string ImmutableDictionaryTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00039220 File Offset: 0x00037420
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00004AE3 File Offset: 0x00002CE3
		public unsafe static string ImmutableDictionaryGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableDictionaryGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00039240 File Offset: 0x00037440
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00004AF5 File Offset: 0x00002CF5
		public unsafe static string ImmutableSortedDictionaryTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00039260 File Offset: 0x00037460
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00004B07 File Offset: 0x00002D07
		public unsafe static string ImmutableSortedDictionaryGenericTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryGenericTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_ImmutableSortedDictionaryGenericTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00039280 File Offset: 0x00037480
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00004B19 File Offset: 0x00002D19
		public unsafe static IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_DictionaryContractImmutableCollectionDefinitions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.NativeFieldInfoPtr_DictionaryContractImmutableCollectionDefinitions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableListGenericInterfaceTypeName;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableQueueGenericInterfaceTypeName;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableStackGenericInterfaceTypeName;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableSetGenericInterfaceTypeName;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableArrayTypeName;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableArrayGenericTypeName;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableListTypeName;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableListGenericTypeName;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableQueueTypeName;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableQueueGenericTypeName;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableStackTypeName;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableStackGenericTypeName;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableSortedSetTypeName;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableSortedSetGenericTypeName;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableHashSetTypeName;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableHashSetGenericTypeName;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_ArrayContractImmutableCollectionDefinitions;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableDictionaryGenericInterfaceTypeName;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableDictionaryTypeName;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableDictionaryGenericTypeName;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableSortedDictionaryTypeName;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeFieldInfoPtr_ImmutableSortedDictionaryGenericTypeName;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeFieldInfoPtr_DictionaryContractImmutableCollectionDefinitions;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_TryBuildImmutableForArrayContract_Internal_Static_Boolean_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_TryBuildImmutableForDictionaryContract_Internal_Static_Boolean_Type_Type_Type_byref_Type_byref_ObjectConstructor_1_Object_0;

		// Token: 0x02000198 RID: 408
		public class ImmutableCollectionTypeInfo : Object
		{
			// Token: 0x06001D2A RID: 7466 RVA: 0x00088888 File Offset: 0x00086A88
			// Note: this type is marked as 'beforefieldinit'.
			static ImmutableCollectionTypeInfo()
			{
				Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "ImmutableCollectionTypeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__ContractTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, "<ContractTypeName>k__BackingField");
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__CreatedTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, "<CreatedTypeName>k__BackingField");
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__BuilderTypeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, "<BuilderTypeName>k__BackingField");
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664885);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_ContractTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664886);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_ContractTypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664887);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_CreatedTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664888);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_CreatedTypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664889);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_BuilderTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664890);
				ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_BuilderTypeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr, 100664891);
			}

			// Token: 0x06001D2B RID: 7467 RVA: 0x0008897C File Offset: 0x00086B7C
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImmutableCollectionTypeInfo(string contractTypeName, string createdTypeName, string builderTypeName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(contractTypeName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(createdTypeName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(builderTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000889EC File Offset: 0x00086BEC
			// (set) Token: 0x06001D2D RID: 7469 RVA: 0x00088A24 File Offset: 0x00086C24
			public unsafe string ContractTypeName
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_ContractTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_ContractTypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00088A68 File Offset: 0x00086C68
			// (set) Token: 0x06001D2F RID: 7471 RVA: 0x00088AA0 File Offset: 0x00086CA0
			public unsafe string CreatedTypeName
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_CreatedTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_CreatedTypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00088AE4 File Offset: 0x00086CE4
			// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00088B1C File Offset: 0x00086D1C
			public unsafe string BuilderTypeName
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_get_BuilderTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeMethodInfoPtr_set_BuilderTypeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001D32 RID: 7474 RVA: 0x0000E5BC File Offset: 0x0000C7BC
			public ImmutableCollectionTypeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00088B60 File Offset: 0x00086D60
			// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0000E5C5 File Offset: 0x0000C7C5
			public unsafe string _ContractTypeName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__ContractTypeName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__ContractTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00088B88 File Offset: 0x00086D88
			// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
			public unsafe string _CreatedTypeName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__CreatedTypeName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__CreatedTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00088BB0 File Offset: 0x00086DB0
			// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0000E603 File Offset: 0x0000C803
			public unsafe string _BuilderTypeName_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__BuilderTypeName_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo.NativeFieldInfoPtr__BuilderTypeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeFieldInfoPtr__ContractTypeName_k__BackingField;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeFieldInfoPtr__CreatedTypeName_k__BackingField;

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr__BuilderTypeName_k__BackingField;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeMethodInfoPtr_get_ContractTypeName_Public_get_String_0;

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeMethodInfoPtr_set_ContractTypeName_Public_set_Void_String_0;

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeMethodInfoPtr_get_CreatedTypeName_Public_get_String_0;

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeMethodInfoPtr_set_CreatedTypeName_Public_set_Void_String_0;

			// Token: 0x0400158C RID: 5516
			private static readonly IntPtr NativeMethodInfoPtr_get_BuilderTypeName_Public_get_String_0;

			// Token: 0x0400158D RID: 5517
			private static readonly IntPtr NativeMethodInfoPtr_set_BuilderTypeName_Public_set_Void_String_0;
		}

		// Token: 0x02000199 RID: 409
		[ObfuscatedName("Newtonsoft.Json.Utilities.ImmutableCollectionsUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D39 RID: 7481 RVA: 0x00088BD8 File Offset: 0x00086DD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr);
				ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, "<>9");
				ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, "<>9__24_1");
				ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, "<>9__25_1");
				ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, 100664893);
				ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__24_1_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, 100664894);
				ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__25_1_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr, 100664895);
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x00088C7C File Offset: 0x00086E7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D3B RID: 7483 RVA: 0x00088CB8 File Offset: 0x00086EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743698, XrefRangeEnd = 743701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryBuildImmutableForArrayContract_b__24_1(MethodInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__24_1_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D3C RID: 7484 RVA: 0x00088D08 File Offset: 0x00086F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743701, XrefRangeEnd = 743712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryBuildImmutableForDictionaryContract_b__25_1(MethodInfo m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c.NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__25_1_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D3D RID: 7485 RVA: 0x0000E622 File Offset: 0x0000C822
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00088D58 File Offset: 0x00086F58
			// (set) Token: 0x06001D3F RID: 7487 RVA: 0x0000E62B File Offset: 0x0000C82B
			public unsafe static ImmutableCollectionsUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImmutableCollectionsUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00088D80 File Offset: 0x00086F80
			// (set) Token: 0x06001D41 RID: 7489 RVA: 0x0000E63D File Offset: 0x0000C83D
			public unsafe static Func<MethodInfo, bool> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00088DA8 File Offset: 0x00086FA8
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x0000E64F File Offset: 0x0000C84F
			public unsafe static Func<MethodInfo, bool> __9__25_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MethodInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImmutableCollectionsUtils.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400158E RID: 5518
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400158F RID: 5519
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04001590 RID: 5520
			private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

			// Token: 0x04001591 RID: 5521
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001592 RID: 5522
			private static readonly IntPtr NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__24_1_Internal_Boolean_MethodInfo_0;

			// Token: 0x04001593 RID: 5523
			private static readonly IntPtr NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__25_1_Internal_Boolean_MethodInfo_0;
		}

		// Token: 0x0200019A RID: 410
		[ObfuscatedName("Newtonsoft.Json.Utilities.ImmutableCollectionsUtils+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06001D44 RID: 7492 RVA: 0x00088DD0 File Offset: 0x00086FD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr);
				ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr, "name");
				ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr, 100664896);
				ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr, 100664897);
			}

			// Token: 0x06001D45 RID: 7493 RVA: 0x00088E38 File Offset: 0x00087038
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D46 RID: 7494 RVA: 0x00088E74 File Offset: 0x00087074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryBuildImmutableForArrayContract_b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D47 RID: 7495 RVA: 0x0000E661 File Offset: 0x0000C861
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00088EC4 File Offset: 0x000870C4
			// (set) Token: 0x06001D49 RID: 7497 RVA: 0x0000E66A File Offset: 0x0000C86A
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.__c__DisplayClass24_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001594 RID: 5524
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001595 RID: 5525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001596 RID: 5526
			private static readonly IntPtr NativeMethodInfoPtr__TryBuildImmutableForArrayContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0;
		}

		// Token: 0x0200019B RID: 411
		[ObfuscatedName("Newtonsoft.Json.Utilities.ImmutableCollectionsUtils+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06001D4A RID: 7498 RVA: 0x00088EEC File Offset: 0x000870EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImmutableCollectionsUtils>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr);
				ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr, "name");
				ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr, 100664898);
				ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr, 100664899);
			}

			// Token: 0x06001D4B RID: 7499 RVA: 0x00088F54 File Offset: 0x00087154
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImmutableCollectionsUtils.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x00088F90 File Offset: 0x00087190
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryBuildImmutableForDictionaryContract_b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x0000E689 File Offset: 0x0000C889
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00088FE0 File Offset: 0x000871E0
			// (set) Token: 0x06001D4F RID: 7503 RVA: 0x0000E692 File Offset: 0x0000C892
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImmutableCollectionsUtils.__c__DisplayClass25_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001597 RID: 5527
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04001598 RID: 5528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001599 RID: 5529
			private static readonly IntPtr NativeMethodInfoPtr__TryBuildImmutableForDictionaryContract_b__0_Internal_Boolean_ImmutableCollectionTypeInfo_0;
		}
	}
}

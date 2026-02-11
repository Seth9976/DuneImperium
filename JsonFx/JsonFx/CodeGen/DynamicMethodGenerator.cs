using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace JsonFx.CodeGen
{
	// Token: 0x02000035 RID: 53
	public static class DynamicMethodGenerator : Object
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicMethodGenerator()
		{
			Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.CodeGen", "DynamicMethodGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetGetter_Public_Static_GetterDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663743);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetSetter_Public_Static_SetterDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663744);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetPropertyGetter_Public_Static_GetterDelegate_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663745);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetPropertySetter_Public_Static_SetterDelegate_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663746);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetFieldGetter_Public_Static_GetterDelegate_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663747);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetFieldSetter_Public_Static_SetterDelegate_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663748);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663749);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663750);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663751);
			DynamicMethodGenerator.NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, 100663752);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193261, XrefRangeEnd = 1193271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GetterDelegate GetGetter(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetGetter_Public_Static_GetterDelegate_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000EA2C File Offset: 0x0000CC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193271, XrefRangeEnd = 1193281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SetterDelegate GetSetter(MemberInfo memberInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetSetter_Public_Static_SetterDelegate_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000EA70 File Offset: 0x0000CC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193294, RefRangeEnd = 1193296, XrefRangeStart = 1193281, XrefRangeEnd = 1193294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GetterDelegate GetPropertyGetter(PropertyInfo propertyInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetPropertyGetter_Public_Static_GetterDelegate_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000EAB4 File Offset: 0x0000CCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193309, RefRangeEnd = 1193310, XrefRangeStart = 1193296, XrefRangeEnd = 1193309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SetterDelegate GetPropertySetter(PropertyInfo propertyInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetPropertySetter_Public_Static_SetterDelegate_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193315, RefRangeEnd = 1193317, XrefRangeStart = 1193310, XrefRangeEnd = 1193315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GetterDelegate GetFieldGetter(FieldInfo fieldInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetFieldGetter_Public_Static_GetterDelegate_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193323, RefRangeEnd = 1193325, XrefRangeStart = 1193317, XrefRangeEnd = 1193323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SetterDelegate GetFieldSetter(FieldInfo fieldInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetFieldSetter_Public_Static_SetterDelegate_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SetterDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193325, XrefRangeEnd = 1193334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProxyDelegate GetMethodProxy(Type declaringType, string methodName, [Optional] Il2CppReferenceArray<Type> argTypes)
		{
			if (argTypes == null)
			{
				argTypes = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProxyDelegate>(intPtr3) : null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193349, RefRangeEnd = 1193351, XrefRangeStart = 1193334, XrefRangeEnd = 1193349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProxyDelegate GetMethodProxy(MethodInfo methodInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProxyDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1193363, RefRangeEnd = 1193365, XrefRangeStart = 1193351, XrefRangeEnd = 1193363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FactoryDelegate GetTypeFactory(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FactoryDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000EC80 File Offset: 0x0000CE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1193384, RefRangeEnd = 1193385, XrefRangeStart = 1193365, XrefRangeEnd = 1193384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FactoryDelegate GetTypeFactory(ConstructorInfo ctor)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FactoryDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003187 File Offset: 0x00001387
		public static ProxyDelegate GetMethodProxy(Type declaringType, string methodName, params Type[] argTypes)
		{
			return DynamicMethodGenerator.GetMethodProxy(declaringType, methodName, new Il2CppReferenceArray<Type>(argTypes));
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00003196 File Offset: 0x00001396
		public DynamicMethodGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_GetGetter_Public_Static_GetterDelegate_MemberInfo_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GetSetter_Public_Static_SetterDelegate_MemberInfo_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyGetter_Public_Static_GetterDelegate_PropertyInfo_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertySetter_Public_Static_SetterDelegate_PropertyInfo_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldGetter_Public_Static_GetterDelegate_FieldInfo_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldSetter_Public_Static_SetterDelegate_FieldInfo_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProxy_Public_Static_ProxyDelegate_MethodInfo_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_Type_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFactory_Public_Static_FactoryDelegate_ConstructorInfo_0;

		// Token: 0x02000052 RID: 82
		[ObfuscatedName("JsonFx.CodeGen.DynamicMethodGenerator+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600045D RID: 1117 RVA: 0x00013704 File Offset: 0x00011904
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr);
				DynamicMethodGenerator.__c__DisplayClass2_0.NativeFieldInfoPtr_methodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr, "methodInfo");
				DynamicMethodGenerator.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr, 100663753);
				DynamicMethodGenerator.__c__DisplayClass2_0.NativeMethodInfoPtr__GetPropertyGetter_b__0_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr, 100663754);
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0001376C File Offset: 0x0001196C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x000137A8 File Offset: 0x000119A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193249, XrefRangeEnd = 1193251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _GetPropertyGetter_b__0(Object instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.__c__DisplayClass2_0.NativeMethodInfoPtr__GetPropertyGetter_b__0_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000460 RID: 1120 RVA: 0x00003C38 File Offset: 0x00001E38
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000461 RID: 1121 RVA: 0x000137F8 File Offset: 0x000119F8
			// (set) Token: 0x06000462 RID: 1122 RVA: 0x00003C41 File Offset: 0x00001E41
			public unsafe MethodInfo methodInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMethodGenerator.__c__DisplayClass2_0.NativeFieldInfoPtr_methodInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMethodGenerator.__c__DisplayClass2_0.NativeFieldInfoPtr_methodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeFieldInfoPtr_methodInfo;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertyGetter_b__0_Internal_Object_Object_0;
		}

		// Token: 0x02000053 RID: 83
		[ObfuscatedName("JsonFx.CodeGen.DynamicMethodGenerator+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06000463 RID: 1123 RVA: 0x00013828 File Offset: 0x00011A28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicMethodGenerator>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr);
				DynamicMethodGenerator.__c__DisplayClass3_0.NativeFieldInfoPtr_methodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr, "methodInfo");
				DynamicMethodGenerator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr, 100663755);
				DynamicMethodGenerator.__c__DisplayClass3_0.NativeMethodInfoPtr__GetPropertySetter_b__0_Internal_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr, 100663756);
			}

			// Token: 0x06000464 RID: 1124 RVA: 0x00013890 File Offset: 0x00011A90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicMethodGenerator.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x000138CC File Offset: 0x00011ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193251, XrefRangeEnd = 1193261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetPropertySetter_b__0(Object instance, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMethodGenerator.__c__DisplayClass3_0.NativeMethodInfoPtr__GetPropertySetter_b__0_Internal_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00003C60 File Offset: 0x00001E60
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x00013920 File Offset: 0x00011B20
			// (set) Token: 0x06000468 RID: 1128 RVA: 0x00003C69 File Offset: 0x00001E69
			public unsafe MethodInfo methodInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMethodGenerator.__c__DisplayClass3_0.NativeFieldInfoPtr_methodInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMethodGenerator.__c__DisplayClass3_0.NativeFieldInfoPtr_methodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr_methodInfo;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeMethodInfoPtr__GetPropertySetter_b__0_Internal_Void_Object_Object_0;
		}
	}
}

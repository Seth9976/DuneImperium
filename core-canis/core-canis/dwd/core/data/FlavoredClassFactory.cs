using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace dwd.core.data
{
	// Token: 0x020001C5 RID: 453
	public class FlavoredClassFactory : Object
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x00078454 File Offset: 0x00076654
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredClassFactory()
		{
			Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "FlavoredClassFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr);
			FlavoredClassFactory.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, "Instance");
			FlavoredClassFactory.NativeFieldInfoPtr_flavoredClasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, "flavoredClasses");
			FlavoredClassFactory.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667304);
			FlavoredClassFactory.NativeMethodInfoPtr_get_AllFlavoredClassTypes_Private_get_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667305);
			FlavoredClassFactory.NativeMethodInfoPtr_GetAttribute_Private_FlavoredClassAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667306);
			FlavoredClassFactory.NativeMethodInfoPtr_Create_Public_Static_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667307);
			FlavoredClassFactory.NativeMethodInfoPtr_create_Private_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667308);
			FlavoredClassFactory.NativeMethodInfoPtr___ctor_b__2_0_Private_KeyValuePair_2_Type_Il2CppStringArray_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, 100667310);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00078524 File Offset: 0x00076724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881049, XrefRangeEnd = 881087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredClassFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x00078560 File Offset: 0x00076760
		public unsafe IEnumerable<Type> AllFlavoredClassTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881087, XrefRangeEnd = 881092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.NativeMethodInfoPtr_get_AllFlavoredClassTypes_Private_get_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000785A0 File Offset: 0x000767A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881092, XrefRangeEnd = 881099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredClassAttribute GetAttribute(Type selectableMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectableMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.NativeMethodInfoPtr_GetAttribute_Private_FlavoredClassAttribute_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FlavoredClassAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000785F0 File Offset: 0x000767F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 881106, RefRangeEnd = 881110, XrefRangeStart = 881099, XrefRangeEnd = 881106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Create<T>(IReadOnlyCollection<string> flavors, [Optional] Il2CppReferenceArray<Object> constructorArguments) where T : class
		{
			if (constructorArguments == null)
			{
				constructorArguments = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructorArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.MethodInfoStoreGeneric_Create_Public_Static_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00078650 File Offset: 0x00076850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881160, RefRangeEnd = 881161, XrefRangeStart = 881110, XrefRangeEnd = 881160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T create<T>(IReadOnlyCollection<string> flavors, [Optional] Il2CppReferenceArray<Object> constructorArguments) where T : class
		{
			if (constructorArguments == null)
			{
				constructorArguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructorArguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.MethodInfoStoreGeneric_create_Private_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000786BC File Offset: 0x000768BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881161, XrefRangeEnd = 881179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePair<Type, Il2CppStringArray> __ctor_b__2_0(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.NativeMethodInfoPtr___ctor_b__2_0_Private_KeyValuePair_2_Type_Il2CppStringArray_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<Type, Il2CppStringArray>(intPtr);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0000B197 File Offset: 0x00009397
		public static T Create<T>(IReadOnlyCollection<string> flavors, params Object[] constructorArguments) where T : class
		{
			return FlavoredClassFactory.Create(flavors, new Il2CppReferenceArray<Object>(constructorArguments));
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0000B1A5 File Offset: 0x000093A5
		public T create<T>(IReadOnlyCollection<string> flavors, params Object[] constructorArguments) where T : class
		{
			return this.create(flavors, new Il2CppReferenceArray<Object>(constructorArguments));
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public FlavoredClassFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x00078704 File Offset: 0x00076904
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000B1BD File Offset: 0x000093BD
		public unsafe static FlavoredClassFactory Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredClassFactory>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x0007872C File Offset: 0x0007692C
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000B1CF File Offset: 0x000093CF
		public unsafe List<KeyValuePair<Type, Il2CppStringArray>> flavoredClasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory.NativeFieldInfoPtr_flavoredClasses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<Type, Il2CppStringArray>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory.NativeFieldInfoPtr_flavoredClasses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeFieldInfoPtr_flavoredClasses;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_get_AllFlavoredClassTypes_Private_get_IEnumerable_1_Type_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Private_FlavoredClassAttribute_Type_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_create_Private_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_0_Private_KeyValuePair_2_Type_Il2CppStringArray_Type_0;

		// Token: 0x0200035F RID: 863
		[ObfuscatedName("dwd.core.data.FlavoredClassFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002773 RID: 10099 RVA: 0x000A7724 File Offset: 0x000A5924
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr);
				FlavoredClassFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr, "<>9");
				FlavoredClassFactory.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr, "<>9__2_1");
				FlavoredClassFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr, 100667312);
				FlavoredClassFactory.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_Int32_KeyValuePair_2_Type_Il2CppStringArray_KeyValuePair_2_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr, 100667313);
			}

			// Token: 0x06002774 RID: 10100 RVA: 0x000A77A0 File Offset: 0x000A59A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredClassFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002775 RID: 10101 RVA: 0x000A77DC File Offset: 0x000A59DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881016, XrefRangeEnd = 881018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int __ctor_b__2_1(KeyValuePair<Type, Il2CppStringArray> a, KeyValuePair<Type, Il2CppStringArray> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_Int32_KeyValuePair_2_Type_Il2CppStringArray_KeyValuePair_2_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002776 RID: 10102 RVA: 0x00011EC7 File Offset: 0x000100C7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06002777 RID: 10103 RVA: 0x000A7848 File Offset: 0x000A5A48
			// (set) Token: 0x06002778 RID: 10104 RVA: 0x00011ED0 File Offset: 0x000100D0
			public unsafe static FlavoredClassFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredClassFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06002779 RID: 10105 RVA: 0x000A7870 File Offset: 0x000A5A70
			// (set) Token: 0x0600277A RID: 10106 RVA: 0x00011EE2 File Offset: 0x000100E2
			public unsafe static Comparison<KeyValuePair<Type, Il2CppStringArray>> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<KeyValuePair<Type, Il2CppStringArray>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001ACE RID: 6862
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001ACF RID: 6863
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001AD0 RID: 6864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AD1 RID: 6865
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_Int32_KeyValuePair_2_Type_Il2CppStringArray_KeyValuePair_2_Type_Il2CppStringArray_0;
		}

		// Token: 0x02000360 RID: 864
		[ObfuscatedName("dwd.core.data.FlavoredClassFactory+<>c__7`1")]
		[Serializable]
		public sealed class __c__7<T> : Object where T : class
		{
			// Token: 0x0600277B RID: 10107 RVA: 0x000A7898 File Offset: 0x000A5A98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__7()
			{
				Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, "<>c__7`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr);
				FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, "<>9");
				FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, "<>9__7_0");
				FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, "<>9__7_1");
				FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, 100667315);
				FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__create_b__7_0_Internal_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, 100667316);
				FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__create_b__7_1_Internal_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr, 100667317);
			}

			// Token: 0x0600277C RID: 10108 RVA: 0x000A7978 File Offset: 0x000A5B78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__7()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredClassFactory.__c__7<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600277D RID: 10109 RVA: 0x000A79B4 File Offset: 0x000A5BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881018, XrefRangeEnd = 881020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type _create_b__7_0(Object a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__create_b__7_0_Internal_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x0600277E RID: 10110 RVA: 0x000A7A04 File Offset: 0x000A5C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _create_b__7_1(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory.__c__7<T>.NativeMethodInfoPtr__create_b__7_1_Internal_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600277F RID: 10111 RVA: 0x00011EF4 File Offset: 0x000100F4
			public __c__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06002780 RID: 10112 RVA: 0x000A7A4C File Offset: 0x000A5C4C
			// (set) Token: 0x06002781 RID: 10113 RVA: 0x00011EFD File Offset: 0x000100FD
			public unsafe static FlavoredClassFactory.__c__7<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredClassFactory.__c__7<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06002782 RID: 10114 RVA: 0x000A7A74 File Offset: 0x000A5C74
			// (set) Token: 0x06002783 RID: 10115 RVA: 0x00011F0F File Offset: 0x0001010F
			public unsafe static Func<Object, Type> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Type>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06002784 RID: 10116 RVA: 0x000A7A9C File Offset: 0x000A5C9C
			// (set) Token: 0x06002785 RID: 10117 RVA: 0x00011F21 File Offset: 0x00010121
			public unsafe static Func<Type, string> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FlavoredClassFactory.__c__7<T>.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AD2 RID: 6866
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001AD3 RID: 6867
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04001AD4 RID: 6868
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04001AD5 RID: 6869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AD6 RID: 6870
			private static readonly IntPtr NativeMethodInfoPtr__create_b__7_0_Internal_Type_Object_0;

			// Token: 0x04001AD7 RID: 6871
			private static readonly IntPtr NativeMethodInfoPtr__create_b__7_1_Internal_String_Type_0;
		}

		// Token: 0x02000361 RID: 865
		[ObfuscatedName("dwd.core.data.FlavoredClassFactory+<get_AllFlavoredClassTypes>d__4")]
		public sealed class _get_AllFlavoredClassTypes_d__4 : Object
		{
			// Token: 0x06002786 RID: 10118 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
			// Note: this type is marked as 'beforefieldinit'.
			static _get_AllFlavoredClassTypes_d__4()
			{
				Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr, "<get_AllFlavoredClassTypes>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>1__state");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>2__current");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>l__initialThreadId");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>7__wrap1");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>7__wrap2");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>7__wrap3");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, "<>7__wrap4");
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667318);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667319);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667320);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667321);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667322);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667323);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667324);
				FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr, 100667325);
			}

			// Token: 0x06002787 RID: 10119 RVA: 0x000A7C1C File Offset: 0x000A5E1C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_AllFlavoredClassTypes_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredClassFactory._get_AllFlavoredClassTypes_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002788 RID: 10120 RVA: 0x000A7C64 File Offset: 0x000A5E64
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002789 RID: 10121 RVA: 0x000A7C98 File Offset: 0x000A5E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881020, XrefRangeEnd = 881042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x0600278A RID: 10122 RVA: 0x000A7CD4 File Offset: 0x000A5ED4
			public unsafe Type System.Collections.Generic.IEnumerator<System.Type>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x0600278B RID: 10123 RVA: 0x000A7D14 File Offset: 0x000A5F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881042, XrefRangeEnd = 881047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x0600278C RID: 10124 RVA: 0x000A7D48 File Offset: 0x000A5F48
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600278D RID: 10125 RVA: 0x000A7D88 File Offset: 0x000A5F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881047, XrefRangeEnd = 881049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Type> System_Collections_Generic_IEnumerable_System_Type__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Type>>(intPtr3) : null;
			}

			// Token: 0x0600278E RID: 10126 RVA: 0x000A7DC8 File Offset: 0x000A5FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600278F RID: 10127 RVA: 0x00011F33 File Offset: 0x00010133
			public _get_AllFlavoredClassTypes_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06002790 RID: 10128 RVA: 0x000A7E08 File Offset: 0x000A6008
			// (set) Token: 0x06002791 RID: 10129 RVA: 0x00011F3C File Offset: 0x0001013C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06002792 RID: 10130 RVA: 0x000A7E30 File Offset: 0x000A6030
			// (set) Token: 0x06002793 RID: 10131 RVA: 0x00011F57 File Offset: 0x00010157
			public unsafe Type __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06002794 RID: 10132 RVA: 0x000A7E60 File Offset: 0x000A6060
			// (set) Token: 0x06002795 RID: 10133 RVA: 0x00011F76 File Offset: 0x00010176
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06002796 RID: 10134 RVA: 0x000A7E88 File Offset: 0x000A6088
			// (set) Token: 0x06002797 RID: 10135 RVA: 0x00011F91 File Offset: 0x00010191
			public unsafe Il2CppReferenceArray<Assembly> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06002798 RID: 10136 RVA: 0x000A7EB8 File Offset: 0x000A60B8
			// (set) Token: 0x06002799 RID: 10137 RVA: 0x00011FB0 File Offset: 0x000101B0
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x0600279A RID: 10138 RVA: 0x000A7EE0 File Offset: 0x000A60E0
			// (set) Token: 0x0600279B RID: 10139 RVA: 0x00011FCB File Offset: 0x000101CB
			public unsafe Il2CppReferenceArray<Type> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x0600279C RID: 10140 RVA: 0x000A7F10 File Offset: 0x000A6110
			// (set) Token: 0x0600279D RID: 10141 RVA: 0x00011FEA File Offset: 0x000101EA
			public unsafe int __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassFactory._get_AllFlavoredClassTypes_d__4.NativeFieldInfoPtr___7__wrap4)) = value;
				}
			}

			// Token: 0x04001AD8 RID: 6872
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AD9 RID: 6873
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001ADA RID: 6874
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001ADB RID: 6875
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001ADC RID: 6876
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001ADD RID: 6877
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001ADE RID: 6878
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04001ADF RID: 6879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AE0 RID: 6880
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AE1 RID: 6881
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AE2 RID: 6882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Type__get_Current_Private_Virtual_Final_New_get_Type_0;

			// Token: 0x04001AE3 RID: 6883
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AE4 RID: 6884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AE5 RID: 6885
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Type__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Type_0;

			// Token: 0x04001AE6 RID: 6886
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000362 RID: 866
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04001AE7 RID: 6887
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FlavoredClassFactory.NativeMethodInfoPtr_Create_Public_Static_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000363 RID: 867
		private sealed class MethodInfoStoreGeneric_create_Private_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04001AE8 RID: 6888
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FlavoredClassFactory.NativeMethodInfoPtr_create_Private_T_IReadOnlyCollection_1_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<FlavoredClassFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}

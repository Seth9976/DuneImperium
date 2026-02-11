using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Unity.Properties.Internal
{
	// Token: 0x02000031 RID: 49
	public static class PropertyBagStore : Object
	{
		// Token: 0x06000170 RID: 368 RVA: 0x00007610 File Offset: 0x00005810
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyBagStore()
		{
			Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties.Internal", "PropertyBagStore");
			PropertyBagStore.NativeFieldInfoPtr_s_PropertyBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, "s_PropertyBags");
			PropertyBagStore.NativeFieldInfoPtr_s_RegisteredTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, "s_RegisteredTypes");
			PropertyBagStore.NativeFieldInfoPtr_NewTypeRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, "NewTypeRegistered");
			PropertyBagStore.NativeFieldInfoPtr_s_PropertyBagProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, "s_PropertyBagProvider");
			PropertyBagStore.NativeMethodInfoPtr_AddPropertyBag_Internal_Static_Void_IPropertyBag_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, 100663529);
			PropertyBagStore.NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, 100663530);
			PropertyBagStore.NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, 100663531);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000076C4 File Offset: 0x000058C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1232657, RefRangeEnd = 1232666, XrefRangeStart = 1232587, XrefRangeEnd = 1232657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyBag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBagStore.MethodInfoStoreGeneric_AddPropertyBag_Internal_Static_Void_IPropertyBag_1_TContainer_0<TContainer>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000076FC File Offset: 0x000058FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1232679, RefRangeEnd = 1232686, XrefRangeStart = 1232666, XrefRangeEnd = 1232679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBagStore.MethodInfoStoreGeneric_GetPropertyBag_Internal_Static_IPropertyBag_1_TContainer_0<TContainer>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TContainer>>(intPtr3) : null;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00007730 File Offset: 0x00005930
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1232736, RefRangeEnd = 1232739, XrefRangeStart = 1232686, XrefRangeEnd = 1232736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPropertyBag GetPropertyBag(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBagStore.NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPropertyBag>(intPtr3) : null;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002C46 File Offset: 0x00000E46
		public PropertyBagStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00007774 File Offset: 0x00005974
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00002C4F File Offset: 0x00000E4F
		public unsafe static ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropertyBagStore.NativeFieldInfoPtr_s_PropertyBags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, IPropertyBag>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyBagStore.NativeFieldInfoPtr_s_PropertyBags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000779C File Offset: 0x0000599C
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00002C61 File Offset: 0x00000E61
		public unsafe static List<Type> s_RegisteredTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropertyBagStore.NativeFieldInfoPtr_s_RegisteredTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyBagStore.NativeFieldInfoPtr_s_RegisteredTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000077C4 File Offset: 0x000059C4
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002C73 File Offset: 0x00000E73
		public unsafe static Action<Type, IPropertyBag> NewTypeRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropertyBagStore.NativeFieldInfoPtr_NewTypeRegistered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Type, IPropertyBag>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyBagStore.NativeFieldInfoPtr_NewTypeRegistered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000077EC File Offset: 0x000059EC
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002C85 File Offset: 0x00000E85
		public unsafe static ReflectedPropertyBagProvider s_PropertyBagProvider
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PropertyBagStore.NativeFieldInfoPtr_s_PropertyBagProvider, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectedPropertyBagProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PropertyBagStore.NativeFieldInfoPtr_s_PropertyBagProvider, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002C97 File Offset: 0x00000E97
		public static void add_NewTypeRegistered(Action<Type, IPropertyBag> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public static void remove_NewTypeRegistered(Action<Type, IPropertyBag> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002CB1 File Offset: 0x00000EB1
		public static bool HasProvider
		{
			get
			{
				return PropertyBagStore.s_PropertyBagProvider != null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00002CBB File Offset: 0x00000EBB
		public static List<Type> AllTypes
		{
			get
			{
				return PropertyBagStore.s_RegisteredTypes;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007814 File Offset: 0x00005A14
		public static bool Exists<TContainer>()
		{
			return PropertyBagStore.TypedStore.PropertyBag != null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00007830 File Offset: 0x00005A30
		public static bool Exists(Type type)
		{
			return PropertyBagStore.s_PropertyBags.ContainsKey(type);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00007850 File Offset: 0x00005A50
		public static bool Exists<TContainer>(ref TContainer value)
		{
			bool flag = !TypeTraits<TContainer>.CanBeNull;
			bool flag2;
			if (flag)
			{
				flag2 = PropertyBagStore.GetPropertyBag<TContainer>() != null;
			}
			else
			{
				bool flag3 = EqualityComparer<TContainer>.Default.Equals(value, default(TContainer));
				flag2 = !flag3 && PropertyBagStore.GetPropertyBag(value.GetType()) != null;
			}
			return flag2;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000078B0 File Offset: 0x00005AB0
		public static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
		{
			bool flag = !TypeTraits<TValue>.IsContainer;
			bool flag2;
			if (flag)
			{
				propertyBag = null;
				flag2 = false;
			}
			else
			{
				bool canBeNull = TypeTraits<TValue>.CanBeNull;
				if (canBeNull)
				{
					bool flag3 = EqualityComparer<TValue>.Default.Equals(value, default(TValue));
					if (flag3)
					{
						propertyBag = PropertyBagStore.GetPropertyBag<TValue>();
						return propertyBag != null;
					}
				}
				bool isValueType = TypeTraits<TValue>.IsValueType;
				if (isValueType)
				{
					propertyBag = PropertyBagStore.GetPropertyBag<TValue>();
					flag2 = propertyBag != null;
				}
				else
				{
					propertyBag = PropertyBagStore.GetPropertyBag(value.GetType());
					flag2 = propertyBag != null;
				}
			}
			return flag2;
		}

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_s_PropertyBags;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr_s_RegisteredTypes;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr_NewTypeRegistered;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_s_PropertyBagProvider;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_AddPropertyBag_Internal_Static_Void_IPropertyBag_1_TContainer_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_1_TContainer_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_Type_0;

		// Token: 0x0200009D RID: 157
		public sealed class TypedStore<TContainer> : ValueType
		{
			// Token: 0x060002E3 RID: 739 RVA: 0x0000BE38 File Offset: 0x0000A038
			// Note: this type is marked as 'beforefieldinit'.
			static TypedStore()
			{
				Il2CppClassPointerStore<PropertyBagStore.TypedStore<TContainer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr, "TypedStore`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyBagStore.TypedStore<TContainer>>.NativeClassPtr);
				PropertyBagStore.TypedStore<TContainer>.NativeFieldInfoPtr_PropertyBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyBagStore.TypedStore<TContainer>>.NativeClassPtr, "PropertyBag");
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x000033EA File Offset: 0x000015EA
			public TypedStore(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x000033F3 File Offset: 0x000015F3
			public TypedStore()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyBagStore.TypedStore<TContainer>>.NativeClassPtr))
			{
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x00003405 File Offset: 0x00001605
			public unsafe static IPropertyBag<TContainer> PropertyBag
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PropertyBagStore.TypedStore<TContainer>.NativeFieldInfoPtr_PropertyBag, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPropertyBag<TContainer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PropertyBagStore.TypedStore<TContainer>.NativeFieldInfoPtr_PropertyBag, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400016D RID: 365
			private static readonly IntPtr NativeFieldInfoPtr_PropertyBag;
		}

		// Token: 0x0200009E RID: 158
		private sealed class MethodInfoStoreGeneric_AddPropertyBag_Internal_Static_Void_IPropertyBag_1_TContainer_0<TContainer>
		{
			// Token: 0x0400016E RID: 366
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyBagStore.NativeMethodInfoPtr_AddPropertyBag_Internal_Static_Void_IPropertyBag_1_TContainer_0, Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
		}

		// Token: 0x0200009F RID: 159
		private sealed class MethodInfoStoreGeneric_GetPropertyBag_Internal_Static_IPropertyBag_1_TContainer_0<TContainer>
		{
			// Token: 0x0400016F RID: 367
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyBagStore.NativeMethodInfoPtr_GetPropertyBag_Internal_Static_IPropertyBag_1_TContainer_0, Il2CppClassPointerStore<PropertyBagStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
		}
	}
}

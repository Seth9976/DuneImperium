using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000015 RID: 21
	public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>
	{
		// Token: 0x06000097 RID: 151 RVA: 0x000054C8 File Offset: 0x000036C8
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValueCollectionPropertyBag()
		{
			Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "KeyValueCollectionPropertyBag`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDictionary>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr);
			KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.NativeFieldInfoPtr_m_KeyValuePairProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr, "m_KeyValuePairProperty");
			KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr, 100663357);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005580 File Offset: 0x00003780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230832, XrefRangeEnd = 1230838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValueCollectionPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000024E4 File Offset: 0x000006E4
		public KeyValueCollectionPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000055BC File Offset: 0x000037BC
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000024ED File Offset: 0x000006ED
		public unsafe KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty m_KeyValuePairProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.NativeFieldInfoPtr_m_KeyValuePairProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.NativeFieldInfoPtr_m_KeyValuePairProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000250C File Offset: 0x0000070C
		public void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(ICollectionPropertyBagVisitor visitor, ref TDictionary container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002519 File Offset: 0x00000719
		public void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002526 File Offset: 0x00000726
		public void Unity.Properties.IDictionaryPropertyAccept<TDictionary>.Accept<TContainer>(IDictionaryPropertyVisitor visitor, Property<TContainer, TDictionary> property, ref TContainer container, ref TDictionary dictionary)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000055EC File Offset: 0x000037EC
		public bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, Object key, out IProperty<TDictionary> property)
		{
			bool flag = container.ContainsKey(key.Cast<TKey>());
			bool flag2;
			if (flag)
			{
				property = new KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty
				{
					Key = key.Cast<TKey>()
				};
				flag2 = true;
			}
			else
			{
				property = null;
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_KeyValuePairProperty;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000062 RID: 98
		public class KeyValuePairProperty : Property<TDictionary, KeyValuePair<TKey, TValue>>
		{
			// Token: 0x06000208 RID: 520 RVA: 0x00008D3C File Offset: 0x00006F3C
			// Note: this type is marked as 'beforefieldinit'.
			static KeyValuePairProperty()
			{
				Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>>.NativeClassPtr, "KeyValuePairProperty"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDictionary>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr);
				KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr, "<Key>k__BackingField");
				KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr, 100663358);
				KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr, 100663359);
				KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr, 100663360);
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000209 RID: 521 RVA: 0x00008E18 File Offset: 0x00007018
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230820, XrefRangeEnd = 1230828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x0600020A RID: 522 RVA: 0x00008E5C File Offset: 0x0000705C
			public unsafe virtual TKey Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230828, XrefRangeEnd = 1230832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
				}
			}

			// Token: 0x0600020B RID: 523 RVA: 0x00008E98 File Offset: 0x00007098
			[CallerCount(0)]
			public unsafe KeyValuePairProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x0000315C File Offset: 0x0000135C
			public KeyValuePairProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600020D RID: 525 RVA: 0x00008ED4 File Offset: 0x000070D4
			// (set) Token: 0x0600020E RID: 526 RVA: 0x00008EFC File Offset: 0x000070FC
			public unsafe TKey _Key_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeFieldInfoPtr__Key_k__BackingField);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>.KeyValuePairProperty.NativeFieldInfoPtr__Key_k__BackingField);
					Type typeFromHandle = typeof(TKey);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040000F4 RID: 244
			private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

			// Token: 0x040000F5 RID: 245
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x040000F6 RID: 246
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_TKey_0;

			// Token: 0x040000F7 RID: 247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x02000016 RID: 22
	public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00005634 File Offset: 0x00003834
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairPropertyBag()
		{
			Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "KeyValuePairPropertyBag`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr);
			KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_KeyProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr, "s_KeyProperty");
			KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_ValueProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr, "s_ValueProperty");
			KeyValuePairPropertyBag<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr, 100663361);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000056F0 File Offset: 0x000038F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230842, XrefRangeEnd = 1230844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyValuePairPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairPropertyBag<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002533 File Offset: 0x00000733
		public KeyValuePairPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000572C File Offset: 0x0000392C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000253C File Offset: 0x0000073C
		public unsafe static DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_KeyProperty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateProperty<KeyValuePair<TKey, TValue>, TKey>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_KeyProperty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005754 File Offset: 0x00003954
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000254E File Offset: 0x0000074E
		public unsafe static DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_ValueProperty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateProperty<KeyValuePair<TKey, TValue>, TValue>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyValuePairPropertyBag<TKey, TValue>.NativeFieldInfoPtr_s_ValueProperty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002560 File Offset: 0x00000760
		public static IEnumerable<IProperty<KeyValuePair<TKey, TValue>>> GetPropertiesEnumerable()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000577C File Offset: 0x0000397C
		public bool TryGetProperty(ref KeyValuePair<TKey, TValue> container, string name, out IProperty<KeyValuePair<TKey, TValue>> property)
		{
			bool flag = name == "Key";
			bool flag2;
			if (flag)
			{
				property = KeyValuePairPropertyBag.s_KeyProperty;
				flag2 = true;
			}
			else
			{
				bool flag3 = name == "Value";
				if (flag3)
				{
					property = KeyValuePairPropertyBag.s_ValueProperty;
					flag2 = true;
				}
				else
				{
					property = null;
					flag2 = false;
				}
			}
			return flag2;
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_s_KeyProperty;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_s_ValueProperty;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000063 RID: 99
		[ObfuscatedName("Unity.Properties.KeyValuePairPropertyBag`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600020F RID: 527 RVA: 0x00008FA4 File Offset: 0x000071A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr);
				KeyValuePairPropertyBag<TKey, TValue>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr, "<>9");
				KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr, 100663364);
				KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_TKey_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr, 100663365);
				KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__7_1_Internal_TValue_byref_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr, 100663366);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x0000906C File Offset: 0x0000726C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyValuePairPropertyBag<TKey, TValue>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000090A8 File Offset: 0x000072A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230838, XrefRangeEnd = 1230840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TKey __cctor_b__7_0(ref KeyValuePair<TKey, TValue> container)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(container);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__7_0_Internal_TKey_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TKey>(intPtr, false, true);
				}
			}

			// Token: 0x06000212 RID: 530 RVA: 0x000090F4 File Offset: 0x000072F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230840, XrefRangeEnd = 1230842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TValue __cctor_b__7_1(ref KeyValuePair<TKey, TValue> container)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(container);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyValuePairPropertyBag<TKey, TValue>.__c.NativeMethodInfoPtr___cctor_b__7_1_Internal_TValue_byref_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
				}
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00003165 File Offset: 0x00001365
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000214 RID: 532 RVA: 0x00009140 File Offset: 0x00007340
			// (set) Token: 0x06000215 RID: 533 RVA: 0x0000316E File Offset: 0x0000136E
			public unsafe static KeyValuePairPropertyBag<TKey, TValue>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeyValuePairPropertyBag<TKey, TValue>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeyValuePairPropertyBag<TKey, TValue>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeyValuePairPropertyBag<TKey, TValue>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000F8 RID: 248
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000F9 RID: 249
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000FA RID: 250
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_0_Internal_TKey_byref_KeyValuePair_2_TKey_TValue_0;

			// Token: 0x040000FB RID: 251
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__7_1_Internal_TValue_byref_KeyValuePair_2_TKey_TValue_0;
		}
	}
}

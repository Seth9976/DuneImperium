using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000201 RID: 513
	public class UxmlHash128AttributeDescription : TypedUxmlAttributeDescription<Hash128>
	{
		// Token: 0x060027E6 RID: 10214 RVA: 0x000AFA24 File Offset: 0x000ADC24
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlHash128AttributeDescription()
		{
			Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlHash128AttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr);
			UxmlHash128AttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr, 100669309);
			UxmlHash128AttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Hash128_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr, 100669310);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000AFA7C File Offset: 0x000ADC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343973, XrefRangeEnd = 343983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlHash128AttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlHash128AttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000AFAB8 File Offset: 0x000ADCB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343983, XrefRangeEnd = 344002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlHash128AttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Hash128_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0001024B File Offset: 0x0000E44B
		public UxmlHash128AttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000AFB28 File Offset: 0x000ADD28
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString();
			}
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x00010254 File Offset: 0x0000E454
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Hash128 value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Hash128_IUxmlAttributes_CreationContext_0;

		// Token: 0x02000515 RID: 1301
		[ObfuscatedName("UnityEngine.UIElements.UxmlHash128AttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FFA RID: 16378 RVA: 0x000FE7EC File Offset: 0x000FC9EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlHash128AttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr);
				UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlHash128AttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr, 100669312);
				UxmlHash128AttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Hash128_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr, 100669313);
			}

			// Token: 0x06003FFB RID: 16379 RVA: 0x000FE868 File Offset: 0x000FCA68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlHash128AttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlHash128AttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FFC RID: 16380 RVA: 0x000FE8A4 File Offset: 0x000FCAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343972, XrefRangeEnd = 343973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hash128 _GetValueFromBag_b__3_0(string s, Hash128 i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlHash128AttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Hash128_String_Hash128_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FFD RID: 16381 RVA: 0x0001AD02 File Offset: 0x00018F02
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001327 RID: 4903
			// (get) Token: 0x06003FFE RID: 16382 RVA: 0x000FE900 File Offset: 0x000FCB00
			// (set) Token: 0x06003FFF RID: 16383 RVA: 0x0001AD0B File Offset: 0x00018F0B
			public unsafe static UxmlHash128AttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlHash128AttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001328 RID: 4904
			// (get) Token: 0x06004000 RID: 16384 RVA: 0x000FE928 File Offset: 0x000FCB28
			// (set) Token: 0x06004001 RID: 16385 RVA: 0x0001AD1D File Offset: 0x00018F1D
			public unsafe static Func<string, Hash128, Hash128> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Hash128, Hash128>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlHash128AttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D22 RID: 11554
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D23 RID: 11555
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D24 RID: 11556
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D25 RID: 11557
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Hash128_String_Hash128_0;
		}

		// Token: 0x02000516 RID: 1302
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

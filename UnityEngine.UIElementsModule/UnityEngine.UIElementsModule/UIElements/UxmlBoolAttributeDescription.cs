using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FE RID: 510
	public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool>
	{
		// Token: 0x060027CD RID: 10189 RVA: 0x000AF288 File Offset: 0x000AD488
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlBoolAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlBoolAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr);
			UxmlBoolAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr, 100669289);
			UxmlBoolAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Boolean_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr, 100669290);
			UxmlBoolAttributeDescription.NativeMethodInfoPtr_ConvertValueToBool_Private_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr, 100669291);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000AF2F4 File Offset: 0x000AD4F4
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 343662, RefRangeEnd = 343700, XrefRangeStart = 343652, XrefRangeEnd = 343662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlBoolAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlBoolAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000AF330 File Offset: 0x000AD530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343700, XrefRangeEnd = 343719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlBoolAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Boolean_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000AF3A0 File Offset: 0x000AD5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343719, XrefRangeEnd = 343723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ConvertValueToBool(string v, bool defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlBoolAttributeDescription.NativeMethodInfoPtr_ConvertValueToBool_Private_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00010219 File Offset: 0x0000E419
		public UxmlBoolAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x000AF3F0 File Offset: 0x000AD5F0
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString().ToLowerInvariant();
			}
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00010222 File Offset: 0x0000E422
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Boolean_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToBool_Private_Static_Boolean_String_Boolean_0;

		// Token: 0x02000511 RID: 1297
		[ObfuscatedName("UnityEngine.UIElements.UxmlBoolAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FE6 RID: 16358 RVA: 0x000FE378 File Offset: 0x000FC578
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlBoolAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr);
				UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlBoolAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr, 100669293);
				UxmlBoolAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr, 100669294);
			}

			// Token: 0x06003FE7 RID: 16359 RVA: 0x000FE3F4 File Offset: 0x000FC5F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlBoolAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlBoolAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FE8 RID: 16360 RVA: 0x000FE430 File Offset: 0x000FC630
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343648, XrefRangeEnd = 343652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValueFromBag_b__3_0(string s, bool b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlBoolAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FE9 RID: 16361 RVA: 0x0001AC96 File Offset: 0x00018E96
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001322 RID: 4898
			// (get) Token: 0x06003FEA RID: 16362 RVA: 0x000FE48C File Offset: 0x000FC68C
			// (set) Token: 0x06003FEB RID: 16363 RVA: 0x0001AC9F File Offset: 0x00018E9F
			public unsafe static UxmlBoolAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001323 RID: 4899
			// (get) Token: 0x06003FEC RID: 16364 RVA: 0x000FE4B4 File Offset: 0x000FC6B4
			// (set) Token: 0x06003FED RID: 16365 RVA: 0x0001ACB1 File Offset: 0x00018EB1
			public unsafe static Func<string, bool, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlBoolAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D17 RID: 11543
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D18 RID: 11544
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D19 RID: 11545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D1A RID: 11546
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Boolean_String_Boolean_0;
		}

		// Token: 0x02000512 RID: 1298
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

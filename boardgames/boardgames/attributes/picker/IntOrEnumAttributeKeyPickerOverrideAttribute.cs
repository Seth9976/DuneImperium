using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.attributes.picker
{
	// Token: 0x02000179 RID: 377
	public class IntOrEnumAttributeKeyPickerOverrideAttribute : AttributeKeyPickerOverrideAttribute
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		// Note: this type is marked as 'beforefieldinit'.
		static IntOrEnumAttributeKeyPickerOverrideAttribute()
		{
			Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "IntOrEnumAttributeKeyPickerOverrideAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute>.NativeClassPtr);
			IntOrEnumAttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute>.NativeClassPtr, 100666075);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x0004B454 File Offset: 0x00049654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001395, XrefRangeEnd = 1001417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntOrEnumAttributeKeyPickerOverrideAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOrEnumAttributeKeyPickerOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0000ACF9 File Offset: 0x00008EF9
		public IntOrEnumAttributeKeyPickerOverrideAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000294 RID: 660
		[ObfuscatedName("boardgames.attributes.picker.IntOrEnumAttributeKeyPickerOverrideAttribute+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E3D RID: 7741 RVA: 0x0006E26C File Offset: 0x0006C46C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr);
				IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr, "<>9");
				IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr, "<>9__0_0");
				IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr, 100666077);
				IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr, 100666078);
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E3F RID: 7743 RVA: 0x0006E324 File Offset: 0x0006C524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001379, XrefRangeEnd = 1001395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x00010395 File Offset: 0x0000E595
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000905 RID: 2309
			// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0006E374 File Offset: 0x0006C574
			// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0001039E File Offset: 0x0000E59E
			public unsafe static IntOrEnumAttributeKeyPickerOverrideAttribute.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntOrEnumAttributeKeyPickerOverrideAttribute.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000906 RID: 2310
			// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0006E39C File Offset: 0x0006C59C
			// (set) Token: 0x06001E44 RID: 7748 RVA: 0x000103B0 File Offset: 0x0000E5B0
			public unsafe static Func<Type, bool> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntOrEnumAttributeKeyPickerOverrideAttribute.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001265 RID: 4709
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001266 RID: 4710
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_Boolean_Type_0;
		}
	}
}

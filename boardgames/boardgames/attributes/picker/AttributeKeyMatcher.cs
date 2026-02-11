using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.attributes.picker
{
	// Token: 0x02000173 RID: 371
	public class AttributeKeyMatcher : Object
	{
		// Token: 0x060012BE RID: 4798 RVA: 0x0004AD1C File Offset: 0x00048F1C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeKeyMatcher()
		{
			Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.picker", "AttributeKeyMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr);
			AttributeKeyMatcher.NativeFieldInfoPtr_matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, "matcher");
			AttributeKeyMatcher.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, 100666047);
			AttributeKeyMatcher.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, 100666048);
			AttributeKeyMatcher.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, 100666049);
			AttributeKeyMatcher.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, 100666050);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0004ADB0 File Offset: 0x00048FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1001266, RefRangeEnd = 1001268, XrefRangeStart = 1001251, XrefRangeEnd = 1001266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyMatcher(Il2CppReferenceArray<Type> valueTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0004ADFC File Offset: 0x00048FFC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeKeyMatcher(Func<Type, bool> matcher)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0004AE48 File Offset: 0x00049048
		public unsafe virtual bool HasMatcher
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 322834, RefRangeEnd = 322836, XrefRangeStart = 322834, XrefRangeEnd = 322836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0004AE84 File Offset: 0x00049084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Matches(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0000AB9F File Offset: 0x00008D9F
		public AttributeKeyMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0004AED4 File Offset: 0x000490D4
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		public unsafe Func<Type, bool> matcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.NativeFieldInfoPtr_matcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.NativeFieldInfoPtr_matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_matcher;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Type_Boolean_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_get_HasMatcher_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Final_New_Boolean_Type_0;

		// Token: 0x02000290 RID: 656
		[ObfuscatedName("boardgames.attributes.picker.AttributeKeyMatcher+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001E1B RID: 7707 RVA: 0x0006DC34 File Offset: 0x0006BE34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr);
				AttributeKeyMatcher.__c__DisplayClass1_0.NativeFieldInfoPtr_valueTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr, "valueTypes");
				AttributeKeyMatcher.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr, 100666051);
				AttributeKeyMatcher.__c__DisplayClass1_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr, 100666052);
			}

			// Token: 0x06001E1C RID: 7708 RVA: 0x0006DC9C File Offset: 0x0006BE9C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E1D RID: 7709 RVA: 0x0006DCD8 File Offset: 0x0006BED8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001235, XrefRangeEnd = 1001250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__0(Type type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.__c__DisplayClass1_0.NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E1E RID: 7710 RVA: 0x000102C7 File Offset: 0x0000E4C7
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FD RID: 2301
			// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0006DD28 File Offset: 0x0006BF28
			// (set) Token: 0x06001E20 RID: 7712 RVA: 0x000102D0 File Offset: 0x0000E4D0
			public unsafe Il2CppReferenceArray<Type> valueTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.__c__DisplayClass1_0.NativeFieldInfoPtr_valueTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.__c__DisplayClass1_0.NativeFieldInfoPtr_valueTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001251 RID: 4689
			private static readonly IntPtr NativeFieldInfoPtr_valueTypes;

			// Token: 0x04001252 RID: 4690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001253 RID: 4691
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_Boolean_Type_0;
		}

		// Token: 0x02000291 RID: 657
		[ObfuscatedName("boardgames.attributes.picker.AttributeKeyMatcher+<>c__DisplayClass1_1")]
		public sealed class __c__DisplayClass1_1 : Object
		{
			// Token: 0x06001E21 RID: 7713 RVA: 0x0006DD58 File Offset: 0x0006BF58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_1()
			{
				Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeKeyMatcher>.NativeClassPtr, "<>c__DisplayClass1_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr);
				AttributeKeyMatcher.__c__DisplayClass1_1.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr, "type");
				AttributeKeyMatcher.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr, 100666053);
				AttributeKeyMatcher.__c__DisplayClass1_1.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr, 100666054);
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x0006DDC0 File Offset: 0x0006BFC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeyMatcher.__c__DisplayClass1_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E23 RID: 7715 RVA: 0x0006DDFC File Offset: 0x0006BFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001250, XrefRangeEnd = 1001251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __ctor_b__1(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeKeyMatcher.__c__DisplayClass1_1.NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x000102EF File Offset: 0x0000E4EF
			public __c__DisplayClass1_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FE RID: 2302
			// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0006DE4C File Offset: 0x0006C04C
			// (set) Token: 0x06001E26 RID: 7718 RVA: 0x000102F8 File Offset: 0x0000E4F8
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.__c__DisplayClass1_1.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeKeyMatcher.__c__DisplayClass1_1.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001254 RID: 4692
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04001255 RID: 4693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001256 RID: 4694
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_Internal_Boolean_Type_0;
		}
	}
}

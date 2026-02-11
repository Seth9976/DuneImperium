using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.attributes.meta
{
	// Token: 0x02000025 RID: 37
	public static class AttributeExtensions : Object
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0000C21C File Offset: 0x0000A41C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeExtensions()
		{
			Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "AttributeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr);
			AttributeExtensions.NativeMethodInfoPtr_ComputeAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663582);
			AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663583);
			AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_IAttribute_1_T_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663584);
			AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_IAttribute_T_IAttribute_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663585);
			AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TSourceValue_IHasAttributes_AttributeDefinition_1_TSourceValue_Func_2_TSourceValue_TSourceValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663586);
			AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663587);
			AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_3_TSourceValue1_TSourceValue2_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue1_AttributeDefinition_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663588);
			AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_TransformAttribute_IAttribute_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, 100663589);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1219117, RefRangeEnd = 1219120, XrefRangeStart = 1219113, XrefRangeEnd = 1219117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ComputedAttribute<TSourceValue, TTargetValue> ComputeAttribute<TSourceValue, TTargetValue>(this TSourceValue source, AttributeDefinition<TTargetValue> definition, Func<TSourceValue, TTargetValue> compute)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TSourceValue).IsValueType)
				{
					TSourceValue tsourceValue = source;
					intPtr = ((tsourceValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tsourceValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tsourceValue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref source;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compute);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_ComputeAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0<TSourceValue, TTargetValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ComputedAttribute<TSourceValue, TTargetValue>>(intPtr4) : null;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000C38C File Offset: 0x0000A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219120, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ComputedAttribute<TSourceValue, TTargetValue> AsAttribute<TSourceValue, TTargetValue>(this TSourceValue source, AttributeDefinition<TTargetValue> definition) where TSourceValue : TTargetValue
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TSourceValue).IsValueType)
				{
					TSourceValue tsourceValue = source;
					intPtr = ((tsourceValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tsourceValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tsourceValue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref source;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_AsAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_0<TSourceValue, TTargetValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ComputedAttribute<TSourceValue, TTargetValue>>(intPtr4) : null;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000C418 File Offset: 0x0000A618
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1219167, RefRangeEnd = 1219170, XrefRangeStart = 1219142, XrefRangeEnd = 1219167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAttribute<T> AsAttribute<T>(this IAttribute source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_AsAttribute_Public_Static_IAttribute_1_T_IAttribute_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000C45C File Offset: 0x0000A65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219170, XrefRangeEnd = 1219184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ComputedAttribute<IAttribute, T> AsAttribute<T>(this IAttribute source, AttributeDefinition<T> definition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_AsAttribute_Public_Static_ComputedAttribute_2_IAttribute_T_IAttribute_AttributeDefinition_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ComputedAttribute<IAttribute, T>>(intPtr3) : null;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219184, XrefRangeEnd = 1219188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformAttribute<TSourceValue, TSourceValue> Transform<TSourceValue>(this IHasAttributes attributes, AttributeDefinition<TSourceValue> sourceDefinition, Func<TSourceValue, TSourceValue> transformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceDefinition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_2_TSourceValue_TSourceValue_IHasAttributes_AttributeDefinition_1_TSourceValue_Func_2_TSourceValue_TSourceValue_0<TSourceValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAttribute<TSourceValue, TSourceValue>>(intPtr3) : null;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000C51C File Offset: 0x0000A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219188, XrefRangeEnd = 1219192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformAttribute<TSourceValue, TTargetValue> Transform<TSourceValue, TTargetValue>(this IHasAttributes attributes, AttributeDefinition<TSourceValue> sourceDefinition, AttributeDefinition<TTargetValue> targetDefinition, Func<TSourceValue, TTargetValue> transformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceDefinition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetDefinition);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_2_TSourceValue_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0<TSourceValue, TTargetValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAttribute<TSourceValue, TTargetValue>>(intPtr3) : null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000C598 File Offset: 0x0000A798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219192, XrefRangeEnd = 1219197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue> Transform<TSourceValue1, TSourceValue2, TTargetValue>(this IHasAttributes attributes, AttributeDefinition<TSourceValue1> sourceDefinition1, AttributeDefinition<TSourceValue2> sourceDefinition2, AttributeDefinition<TTargetValue> targetDefinition, Func<TSourceValue1, TSourceValue2, TTargetValue> transformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceDefinition1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceDefinition2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetDefinition);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_3_TSourceValue1_TSourceValue2_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue1_AttributeDefinition_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0<TSourceValue1, TSourceValue2, TTargetValue>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>(intPtr3) : null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000C628 File Offset: 0x0000A828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219219, RefRangeEnd = 1219220, XrefRangeStart = 1219197, XrefRangeEnd = 1219219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransformAttribute AsAttribute(this IAttribute source, IAttributeDefinition definition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_TransformAttribute_IAttribute_IAttributeDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransformAttribute>(intPtr3) : null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002EB7 File Offset: 0x000010B7
		public AttributeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_ComputeAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_AsAttribute_Public_Static_IAttribute_1_T_IAttribute_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_IAttribute_T_IAttribute_AttributeDefinition_1_T_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TSourceValue_IHasAttributes_AttributeDefinition_1_TSourceValue_Func_2_TSourceValue_TSourceValue_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_3_TSourceValue1_TSourceValue2_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue1_AttributeDefinition_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_AsAttribute_Public_Static_TransformAttribute_IAttribute_IAttributeDefinition_0;

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("Canis.attributes.meta.AttributeExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000371 RID: 881 RVA: 0x0000FC68 File Offset: 0x0000DE68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr);
				AttributeExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr, "<>9");
				AttributeExtensions.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr, "<>9__7_0");
				AttributeExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr, 100663591);
				AttributeExtensions.__c.NativeMethodInfoPtr__AsAttribute_b__7_0_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr, 100663592);
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000FCE4 File Offset: 0x0000DEE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000FD20 File Offset: 0x0000DF20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _AsAttribute_b__7_0(Object v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c.NativeMethodInfoPtr__AsAttribute_b__7_0_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000374 RID: 884 RVA: 0x0000357E File Offset: 0x0000177E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000375 RID: 885 RVA: 0x0000FD70 File Offset: 0x0000DF70
			// (set) Token: 0x06000376 RID: 886 RVA: 0x00003587 File Offset: 0x00001787
			public unsafe static AttributeExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000377 RID: 887 RVA: 0x0000FD98 File Offset: 0x0000DF98
			// (set) Token: 0x06000378 RID: 888 RVA: 0x00003599 File Offset: 0x00001799
			public unsafe static Func<Object, Object> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000236 RID: 566
			private static readonly IntPtr NativeMethodInfoPtr__AsAttribute_b__7_0_Internal_Object_Object_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("Canis.attributes.meta.AttributeExtensions+<>c__1`2")]
		[Serializable]
		public sealed class __c__1<TSourceValue, TTargetValue> : Object where TSourceValue : TTargetValue
		{
			// Token: 0x06000379 RID: 889 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__1()
			{
				Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, "<>c__1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr);
				AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr, "<>9");
				AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr, "<>9__1_0");
				AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr, 100663594);
				AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeMethodInfoPtr__AsAttribute_b__1_0_Internal_TTargetValue_TSourceValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr, 100663595);
			}

			// Token: 0x0600037A RID: 890 RVA: 0x0000FE88 File Offset: 0x0000E088
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600037B RID: 891 RVA: 0x0000FEC4 File Offset: 0x0000E0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219094, XrefRangeEnd = 1219101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TTargetValue _AsAttribute_b__1_0(TSourceValue v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TSourceValue).IsValueType)
					{
						TSourceValue tsourceValue = v;
						intPtr = ((tsourceValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tsourceValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tsourceValue as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref v;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeMethodInfoPtr__AsAttribute_b__1_0_Internal_TTargetValue_TSourceValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr2, false, true);
				}
			}

			// Token: 0x0600037C RID: 892 RVA: 0x000035AB File Offset: 0x000017AB
			public __c__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x0600037D RID: 893 RVA: 0x0000FF44 File Offset: 0x0000E144
			// (set) Token: 0x0600037E RID: 894 RVA: 0x000035B4 File Offset: 0x000017B4
			public unsafe static AttributeExtensions.__c__1<TSourceValue, TTargetValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeExtensions.__c__1<TSourceValue, TTargetValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600037F RID: 895 RVA: 0x0000FF6C File Offset: 0x0000E16C
			// (set) Token: 0x06000380 RID: 896 RVA: 0x000035C6 File Offset: 0x000017C6
			public unsafe static Func<TSourceValue, TTargetValue> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSourceValue, TTargetValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__1<TSourceValue, TTargetValue>.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000237 RID: 567
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000238 RID: 568
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04000239 RID: 569
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400023A RID: 570
			private static readonly IntPtr NativeMethodInfoPtr__AsAttribute_b__1_0_Internal_TTargetValue_TSourceValue_0;
		}

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("Canis.attributes.meta.AttributeExtensions+<>c__2`1")]
		[Serializable]
		public sealed class __c__2<T> : Object
		{
			// Token: 0x06000381 RID: 897 RVA: 0x0000FF94 File Offset: 0x0000E194
			// Note: this type is marked as 'beforefieldinit'.
			static __c__2()
			{
				Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, "<>c__2`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr);
				AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr, "<>9");
				AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr, "<>9__2_0");
				AttributeExtensions.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr, 100663597);
				AttributeExtensions.__c__2<T>.NativeMethodInfoPtr__AsAttribute_b__2_0_Internal_T_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr, 100663598);
			}

			// Token: 0x06000382 RID: 898 RVA: 0x0001004C File Offset: 0x0000E24C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeExtensions.__c__2<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__2<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00010088 File Offset: 0x0000E288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219101, XrefRangeEnd = 1219106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _AsAttribute_b__2_0(IAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__2<T>.NativeMethodInfoPtr__AsAttribute_b__2_0_Internal_T_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06000384 RID: 900 RVA: 0x000035D8 File Offset: 0x000017D8
			public __c__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000385 RID: 901 RVA: 0x000100D4 File Offset: 0x0000E2D4
			// (set) Token: 0x06000386 RID: 902 RVA: 0x000035E1 File Offset: 0x000017E1
			public unsafe static AttributeExtensions.__c__2<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeExtensions.__c__2<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x06000387 RID: 903 RVA: 0x000100FC File Offset: 0x0000E2FC
			// (set) Token: 0x06000388 RID: 904 RVA: 0x000035F3 File Offset: 0x000017F3
			public unsafe static Func<IAttribute, T> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__2<T>.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400023B RID: 571
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400023C RID: 572
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400023D RID: 573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400023E RID: 574
			private static readonly IntPtr NativeMethodInfoPtr__AsAttribute_b__2_0_Internal_T_IAttribute_0;
		}

		// Token: 0x02000052 RID: 82
		[ObfuscatedName("Canis.attributes.meta.AttributeExtensions+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<T> : Object
		{
			// Token: 0x06000389 RID: 905 RVA: 0x00010124 File Offset: 0x0000E324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr);
				AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr, "<>9");
				AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr, "<>9__3_0");
				AttributeExtensions.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr, 100663600);
				AttributeExtensions.__c__3<T>.NativeMethodInfoPtr__AsAttribute_b__3_0_Internal_T_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr, 100663601);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x000101DC File Offset: 0x0000E3DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeExtensions.__c__3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__3<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00010218 File Offset: 0x0000E418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219106, XrefRangeEnd = 1219113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _AsAttribute_b__3_0(IAttribute v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeExtensions.__c__3<T>.NativeMethodInfoPtr__AsAttribute_b__3_0_Internal_T_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600038C RID: 908 RVA: 0x00003605 File Offset: 0x00001805
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600038D RID: 909 RVA: 0x00010264 File Offset: 0x0000E464
			// (set) Token: 0x0600038E RID: 910 RVA: 0x0000360E File Offset: 0x0000180E
			public unsafe static AttributeExtensions.__c__3<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeExtensions.__c__3<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x0600038F RID: 911 RVA: 0x0001028C File Offset: 0x0000E48C
			// (set) Token: 0x06000390 RID: 912 RVA: 0x00003620 File Offset: 0x00001820
			public unsafe static Func<IAttribute, T> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute, T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeExtensions.__c__3<T>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400023F RID: 575
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000240 RID: 576
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000241 RID: 577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000242 RID: 578
			private static readonly IntPtr NativeMethodInfoPtr__AsAttribute_b__3_0_Internal_T_IAttribute_0;
		}

		// Token: 0x02000053 RID: 83
		private sealed class MethodInfoStoreGeneric_ComputeAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0<TSourceValue, TTargetValue>
		{
			// Token: 0x04000243 RID: 579
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_ComputeAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000054 RID: 84
		private sealed class MethodInfoStoreGeneric_AsAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_0<TSourceValue, TTargetValue>
		{
			// Token: 0x04000244 RID: 580
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_TSourceValue_TTargetValue_TSourceValue_AttributeDefinition_1_TTargetValue_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000055 RID: 85
		private sealed class MethodInfoStoreGeneric_AsAttribute_Public_Static_IAttribute_1_T_IAttribute_0<T>
		{
			// Token: 0x04000245 RID: 581
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_IAttribute_1_T_IAttribute_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000056 RID: 86
		private sealed class MethodInfoStoreGeneric_AsAttribute_Public_Static_ComputedAttribute_2_IAttribute_T_IAttribute_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x04000246 RID: 582
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_AsAttribute_Public_Static_ComputedAttribute_2_IAttribute_T_IAttribute_AttributeDefinition_1_T_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000057 RID: 87
		private sealed class MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_2_TSourceValue_TSourceValue_IHasAttributes_AttributeDefinition_1_TSourceValue_Func_2_TSourceValue_TSourceValue_0<TSourceValue>
		{
			// Token: 0x04000247 RID: 583
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TSourceValue_IHasAttributes_AttributeDefinition_1_TSourceValue_Func_2_TSourceValue_TSourceValue_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)) }))));
		}

		// Token: 0x02000058 RID: 88
		private sealed class MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_2_TSourceValue_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0<TSourceValue, TTargetValue>
		{
			// Token: 0x04000248 RID: 584
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_2_TSourceValue_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000059 RID: 89
		private sealed class MethodInfoStoreGeneric_Transform_Public_Static_TransformAttribute_3_TSourceValue1_TSourceValue2_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue1_AttributeDefinition_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0<TSourceValue1, TSourceValue2, TTargetValue>
		{
			// Token: 0x04000249 RID: 585
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeExtensions.NativeMethodInfoPtr_Transform_Public_Static_TransformAttribute_3_TSourceValue1_TSourceValue2_TTargetValue_IHasAttributes_AttributeDefinition_1_TSourceValue1_AttributeDefinition_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0, Il2CppClassPointerStore<AttributeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			}))));
		}
	}
}

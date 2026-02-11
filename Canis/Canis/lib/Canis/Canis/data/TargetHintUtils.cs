using System;
using Canis.attributes;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace lib.canis.Canis.data
{
	// Token: 0x0200001E RID: 30
	public class TargetHintUtils : Object
	{
		// Token: 0x06000115 RID: 277 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		// Note: this type is marked as 'beforefieldinit'.
		static TargetHintUtils()
		{
			Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis.data", "TargetHintUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr);
			TargetHintUtils.NativeMethodInfoPtr_HintAttributesFrom_Public_Static_ReadOnlyAttributes_Dictionary_2_EntityID_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, 100663464);
			TargetHintUtils.NativeMethodInfoPtr_HintAttributesFor_Public_Static_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, 100663465);
			TargetHintUtils.NativeMethodInfoPtr_HintAttributeFor_Public_Static_MutableAttribute_1_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, 100663466);
			TargetHintUtils.NativeMethodInfoPtr_HintValuesFor_Public_Static_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, 100663467);
			TargetHintUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, 100663468);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001D654 File Offset: 0x0001B854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544200, XrefRangeEnd = 544217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyAttributes HintAttributesFrom<TEnt>(Dictionary<EntityID, ReadOnlyAttributes> value) where TEnt : Entity
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.MethodInfoStoreGeneric_HintAttributesFrom_Public_Static_ReadOnlyAttributes_Dictionary_2_EntityID_ReadOnlyAttributes_0<TEnt>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0001D698 File Offset: 0x0001B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544217, XrefRangeEnd = 544237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyAttributes HintAttributesFor<TEnt>(IEnumerable<TEnt> entities, Func<TEnt, IEnumerable<IAttribute>> hintsGen) where TEnt : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintsGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.MethodInfoStoreGeneric_HintAttributesFor_Public_Static_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 544247, RefRangeEnd = 544248, XrefRangeStart = 544237, XrefRangeEnd = 544247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MutableAttribute<Dictionary<EntityID, ReadOnlyAttributes>> HintAttributeFor<TEnt>(IEnumerable<TEnt> entities, Func<TEnt, IEnumerable<IAttribute>> hintsGen) where TEnt : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintsGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.MethodInfoStoreGeneric_HintAttributeFor_Public_Static_MutableAttribute_1_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<Dictionary<EntityID, ReadOnlyAttributes>>>(intPtr3) : null;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001D748 File Offset: 0x0001B948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 544270, RefRangeEnd = 544272, XrefRangeStart = 544248, XrefRangeEnd = 544270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<EntityID, ReadOnlyAttributes> HintValuesFor<TEnt>(IEnumerable<TEnt> entities, Func<TEnt, IEnumerable<IAttribute>> hintsGen) where TEnt : Entity
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintsGen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.MethodInfoStoreGeneric_HintValuesFor_Public_Static_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, ReadOnlyAttributes>>(intPtr3) : null;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetHintUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002892 File Offset: 0x00000A92
		public TargetHintUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_HintAttributesFrom_Public_Static_ReadOnlyAttributes_Dictionary_2_EntityID_ReadOnlyAttributes_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_HintAttributesFor_Public_Static_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_HintAttributeFor_Public_Static_MutableAttribute_1_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_HintValuesFor_Public_Static_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000245 RID: 581
		[ObfuscatedName("lib.canis.Canis.data.TargetHintUtils+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<TEnt> : Object where TEnt : Entity
		{
			// Token: 0x06001871 RID: 6257 RVA: 0x0007A7B8 File Offset: 0x000789B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr);
				TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr, "<>9");
				TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr, "<>9__3_0");
				TargetHintUtils.__c__3<TEnt>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr, 100663470);
				TargetHintUtils.__c__3<TEnt>.NativeMethodInfoPtr__HintValuesFor_b__3_0_Internal_EntityID_TEnt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr, 100663471);
			}

			// Token: 0x06001872 RID: 6258 RVA: 0x0007A870 File Offset: 0x00078A70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetHintUtils.__c__3<TEnt>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.__c__3<TEnt>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001873 RID: 6259 RVA: 0x0007A8AC File Offset: 0x00078AAC
			[CallerCount(0)]
			public unsafe EntityID _HintValuesFor_b__3_0(TEnt ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TEnt).IsValueType)
					{
						TEnt tent = ent;
						intPtr = ((tent is string) ? IL2CPP.ManagedStringToIl2Cpp(tent as string) : IL2CPP.Il2CppObjectBaseToPtr(tent as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref ent;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.__c__3<TEnt>.NativeMethodInfoPtr__HintValuesFor_b__3_0_Internal_EntityID_TEnt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr4) : null;
				}
			}

			// Token: 0x06001874 RID: 6260 RVA: 0x0000BB22 File Offset: 0x00009D22
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700055B RID: 1371
			// (get) Token: 0x06001875 RID: 6261 RVA: 0x0007A934 File Offset: 0x00078B34
			// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000BB2B File Offset: 0x00009D2B
			public unsafe static TargetHintUtils.__c__3<TEnt> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetHintUtils.__c__3<TEnt>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700055C RID: 1372
			// (get) Token: 0x06001877 RID: 6263 RVA: 0x0007A95C File Offset: 0x00078B5C
			// (set) Token: 0x06001878 RID: 6264 RVA: 0x0000BB3D File Offset: 0x00009D3D
			public unsafe static Func<TEnt, EntityID> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TEnt, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TargetHintUtils.__c__3<TEnt>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FA4 RID: 4004
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FA5 RID: 4005
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000FA6 RID: 4006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FA7 RID: 4007
			private static readonly IntPtr NativeMethodInfoPtr__HintValuesFor_b__3_0_Internal_EntityID_TEnt_0;
		}

		// Token: 0x02000246 RID: 582
		[ObfuscatedName("lib.canis.Canis.data.TargetHintUtils+<>c__DisplayClass3_0`1")]
		public sealed class __c__DisplayClass3_0<TEnt> : Object where TEnt : Entity
		{
			// Token: 0x06001879 RID: 6265 RVA: 0x0007A984 File Offset: 0x00078B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr, "<>c__DisplayClass3_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr);
				TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeFieldInfoPtr_hintsGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr, "hintsGen");
				TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr, 100663472);
				TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeMethodInfoPtr__HintValuesFor_b__1_Internal_ReadOnlyAttributes_TEnt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr, 100663473);
			}

			// Token: 0x0600187A RID: 6266 RVA: 0x0007AA28 File Offset: 0x00078C28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetHintUtils.__c__DisplayClass3_0<TEnt>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600187B RID: 6267 RVA: 0x0007AA64 File Offset: 0x00078C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544196, XrefRangeEnd = 544200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _HintValuesFor_b__1(TEnt ent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TEnt).IsValueType)
					{
						TEnt tent = ent;
						intPtr = ((tent is string) ? IL2CPP.ManagedStringToIl2Cpp(tent as string) : IL2CPP.Il2CppObjectBaseToPtr(tent as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref ent;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeMethodInfoPtr__HintValuesFor_b__1_Internal_ReadOnlyAttributes_TEnt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr4) : null;
				}
			}

			// Token: 0x0600187C RID: 6268 RVA: 0x0000BB4F File Offset: 0x00009D4F
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700055D RID: 1373
			// (get) Token: 0x0600187D RID: 6269 RVA: 0x0007AAEC File Offset: 0x00078CEC
			// (set) Token: 0x0600187E RID: 6270 RVA: 0x0000BB58 File Offset: 0x00009D58
			public unsafe Func<TEnt, IEnumerable<IAttribute>> hintsGen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeFieldInfoPtr_hintsGen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TEnt, IEnumerable<IAttribute>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TargetHintUtils.__c__DisplayClass3_0<TEnt>.NativeFieldInfoPtr_hintsGen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FA8 RID: 4008
			private static readonly IntPtr NativeFieldInfoPtr_hintsGen;

			// Token: 0x04000FA9 RID: 4009
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FAA RID: 4010
			private static readonly IntPtr NativeMethodInfoPtr__HintValuesFor_b__1_Internal_ReadOnlyAttributes_TEnt_0;
		}

		// Token: 0x02000247 RID: 583
		private sealed class MethodInfoStoreGeneric_HintAttributesFrom_Public_Static_ReadOnlyAttributes_Dictionary_2_EntityID_ReadOnlyAttributes_0<TEnt>
		{
			// Token: 0x04000FAB RID: 4011
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetHintUtils.NativeMethodInfoPtr_HintAttributesFrom_Public_Static_ReadOnlyAttributes_Dictionary_2_EntityID_ReadOnlyAttributes_0, Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) }))));
		}

		// Token: 0x02000248 RID: 584
		private sealed class MethodInfoStoreGeneric_HintAttributesFor_Public_Static_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>
		{
			// Token: 0x04000FAC RID: 4012
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetHintUtils.NativeMethodInfoPtr_HintAttributesFor_Public_Static_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0, Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) }))));
		}

		// Token: 0x02000249 RID: 585
		private sealed class MethodInfoStoreGeneric_HintAttributeFor_Public_Static_MutableAttribute_1_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>
		{
			// Token: 0x04000FAD RID: 4013
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetHintUtils.NativeMethodInfoPtr_HintAttributeFor_Public_Static_MutableAttribute_1_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0, Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) }))));
		}

		// Token: 0x0200024A RID: 586
		private sealed class MethodInfoStoreGeneric_HintValuesFor_Public_Static_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0<TEnt>
		{
			// Token: 0x04000FAE RID: 4014
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TargetHintUtils.NativeMethodInfoPtr_HintValuesFor_Public_Static_Dictionary_2_EntityID_ReadOnlyAttributes_IEnumerable_1_TEnt_Func_2_TEnt_IEnumerable_1_IAttribute_0, Il2CppClassPointerStore<TargetHintUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnt>.NativeClassPtr)) }))));
		}
	}
}

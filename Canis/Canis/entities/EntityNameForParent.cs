using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000D7 RID: 215
	public class EntityNameForParent<TParentEntity> : Object where TParentEntity : Entity
	{
		// Token: 0x060009FC RID: 2556 RVA: 0x00043DDC File Offset: 0x00041FDC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityNameForParent()
		{
			Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntityNameForParent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TParentEntity>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr);
			EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, "_name");
			EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__entityGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, "_entityGen");
			EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__assignEntToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, "_assignEntToParent");
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665408);
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_TParentEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665409);
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_op_Implicit_Public_Static_String_EntityNameForParent_1_TParentEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665410);
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665411);
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Final_New_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665412);
			EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_ParentEntity_Public_Virtual_Final_New_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, 100665413);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00043EFC File Offset: 0x000420FC
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00043F34 File Offset: 0x00042134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565426, RefRangeEnd = 565427, XrefRangeStart = 565397, XrefRangeEnd = 565426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityNameForParent(string name, Func<SerializedEntity, Match, Entity, Entity> entityGen = null, Action<Entity, TParentEntity> assignEntToParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityGen);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignEntToParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_TParentEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00043FA4 File Offset: 0x000421A4
		[CallerCount(0)]
		public unsafe static implicit operator string(EntityNameForParent<TParentEntity> en)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(en);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_op_Implicit_Public_Static_String_EntityNameForParent_1_TParentEntity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00043FE0 File Offset: 0x000421E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00044024 File Offset: 0x00042224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565427, XrefRangeEnd = 565428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Entity DeserializeEntity(SerializedEntity se, Match m, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Final_New_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00044098 File Offset: 0x00042298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565428, XrefRangeEnd = 565433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ParentEntity(Entity child)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.NativeMethodInfoPtr_ParentEntity_Public_Virtual_Final_New_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00005B54 File Offset: 0x00003D54
		public EntityNameForParent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000440DC File Offset: 0x000422DC
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00005B5D File Offset: 0x00003D5D
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00044104 File Offset: 0x00042304
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00005B7C File Offset: 0x00003D7C
		public unsafe Func<SerializedEntity, Match, Entity, Entity> _entityGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__entityGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, Match, Entity, Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__entityGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00044134 File Offset: 0x00042334
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00005B9B File Offset: 0x00003D9B
		public unsafe Action<Entity, TParentEntity> _assignEntToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__assignEntToParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Entity, TParentEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityNameForParent<TParentEntity>.NativeFieldInfoPtr__assignEntToParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr__entityGen;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr__assignEntToParent;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_TParentEntity_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_EntityNameForParent_1_TParentEntity_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeEntity_Public_Virtual_Final_New_Entity_SerializedEntity_Match_Entity_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_ParentEntity_Public_Virtual_Final_New_Void_Entity_0;

		// Token: 0x02000319 RID: 793
		[ObfuscatedName("Canis.entities.EntityNameForParent`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002126 RID: 8486 RVA: 0x00096BC8 File Offset: 0x00094DC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TParentEntity>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr);
				EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, "<>9");
				EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, "<>9__5_0");
				EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, "<>9__5_1");
				EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, 100665415);
				EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, 100665416);
				EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_Void_Entity_TParentEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr, 100665417);
			}

			// Token: 0x06002127 RID: 8487 RVA: 0x00096CA8 File Offset: 0x00094EA8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNameForParent<TParentEntity>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002128 RID: 8488 RVA: 0x00096CE4 File Offset: 0x00094EE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565369, XrefRangeEnd = 565397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __ctor_b__5_0(SerializedEntity se, Match m, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr___ctor_b__5_0_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06002129 RID: 8489 RVA: 0x00096D58 File Offset: 0x00094F58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__5_1(Entity ent, TParentEntity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(TParentEntity).IsValueType)
				{
					TParentEntity tparentEntity = parent;
					intPtr = ((tparentEntity is string) ? IL2CPP.ManagedStringToIl2Cpp(tparentEntity as string) : IL2CPP.Il2CppObjectBaseToPtr(tparentEntity as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref parent;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EntityNameForParent<TParentEntity>.__c.NativeMethodInfoPtr___ctor_b__5_1_Internal_Void_Entity_TParentEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x0600212A RID: 8490 RVA: 0x0000FE84 File Offset: 0x0000E084
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F6 RID: 2038
			// (get) Token: 0x0600212B RID: 8491 RVA: 0x00096DE4 File Offset: 0x00094FE4
			// (set) Token: 0x0600212C RID: 8492 RVA: 0x0000FE8D File Offset: 0x0000E08D
			public unsafe static EntityNameForParent<TParentEntity>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameForParent<TParentEntity>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x0600212D RID: 8493 RVA: 0x00096E0C File Offset: 0x0009500C
			// (set) Token: 0x0600212E RID: 8494 RVA: 0x0000FE9F File Offset: 0x0000E09F
			public unsafe static Func<SerializedEntity, Match, Entity, Entity> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, Match, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x0600212F RID: 8495 RVA: 0x00096E34 File Offset: 0x00095034
			// (set) Token: 0x06002130 RID: 8496 RVA: 0x0000FEB1 File Offset: 0x0000E0B1
			public unsafe static Action<Entity, TParentEntity> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Entity, TParentEntity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNameForParent<TParentEntity>.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014E0 RID: 5344
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014E1 RID: 5345
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040014E2 RID: 5346
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x040014E3 RID: 5347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014E4 RID: 5348
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_0_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x040014E5 RID: 5349
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__5_1_Internal_Void_Entity_TParentEntity_0;
		}
	}
}

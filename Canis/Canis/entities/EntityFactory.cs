using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.entities
{
	// Token: 0x020000D4 RID: 212
	public class EntityFactory<T, D> : Object where D : Entity
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x0004376C File Offset: 0x0004196C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityFactory()
		{
			Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntityFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<D>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr);
			EntityFactory<T, D>.NativeFieldInfoPtr_entityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, "entityMap");
			EntityFactory<T, D>.NativeFieldInfoPtr_deserializeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, "deserializeMap");
			EntityFactory<T, D>.NativeMethodInfoPtr_initializeEntities_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665398);
			EntityFactory<T, D>.NativeMethodInfoPtr_AddEntry_Public_Void_T_Func_2_Match_D_Func_4_SerializedEntity_Match_Entity_D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665399);
			EntityFactory<T, D>.NativeMethodInfoPtr_HasEntry_Public_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665400);
			EntityFactory<T, D>.NativeMethodInfoPtr_CreateEntity_Public_D_T_Match_PlayerEntity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665401);
			EntityFactory<T, D>.NativeMethodInfoPtr_CreateDeserializedEntity_Public_D_T_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665402);
			EntityFactory<T, D>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr, 100665403);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0004388C File Offset: 0x00041A8C
		[CallerCount(0)]
		public unsafe virtual void initializeEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityFactory<T, D>.NativeMethodInfoPtr_initializeEntities_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000438C8 File Offset: 0x00041AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 565300, RefRangeEnd = 565302, XrefRangeStart = 565293, XrefRangeEnd = 565300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEntry(T id, Func<Match, D> factoryMethod, Func<SerializedEntity, Match, Entity, D> deserializeMethod)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = id;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factoryMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deserializeMethod);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EntityFactory<T, D>.NativeMethodInfoPtr_AddEntry_Public_Void_T_Func_2_Match_D_Func_4_SerializedEntity_Match_Entity_D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00043964 File Offset: 0x00041B64
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 565304, RefRangeEnd = 565309, XrefRangeStart = 565302, XrefRangeEnd = 565304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEntry(T id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = id;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EntityFactory<T, D>.NativeMethodInfoPtr_HasEntry_Public_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000439E8 File Offset: 0x00041BE8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 565311, RefRangeEnd = 565332, XrefRangeStart = 565309, XrefRangeEnd = 565311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe D CreateEntity(T id, Match m, PlayerEntity player, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = id;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EntityFactory<T, D>.NativeMethodInfoPtr_CreateEntity_Public_D_T_Match_PlayerEntity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<D>(intPtr2, false, true);
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00043AA0 File Offset: 0x00041CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565341, RefRangeEnd = 565342, XrefRangeStart = 565332, XrefRangeEnd = 565341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe D CreateDeserializedEntity(T id, SerializedEntity se, Match m, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = id;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref id;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(se);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EntityFactory<T, D>.NativeMethodInfoPtr_CreateDeserializedEntity_Public_D_T_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<D>(intPtr2, false, true);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00043B58 File Offset: 0x00041D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 565358, RefRangeEnd = 565359, XrefRangeStart = 565342, XrefRangeEnd = 565358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityFactory<T, D>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityFactory<T, D>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00005AC2 File Offset: 0x00003CC2
		public EntityFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00043B94 File Offset: 0x00041D94
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00005ACB File Offset: 0x00003CCB
		public unsafe Dictionary<T, Func<Match, D>> entityMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFactory<T, D>.NativeFieldInfoPtr_entityMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, Func<Match, D>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFactory<T, D>.NativeFieldInfoPtr_entityMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00043BC4 File Offset: 0x00041DC4
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00005AEA File Offset: 0x00003CEA
		public unsafe Dictionary<T, Func<SerializedEntity, Match, Entity, D>> deserializeMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFactory<T, D>.NativeFieldInfoPtr_deserializeMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, Func<SerializedEntity, Match, Entity, D>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityFactory<T, D>.NativeFieldInfoPtr_deserializeMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeFieldInfoPtr_entityMap;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeFieldInfoPtr_deserializeMap;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_initializeEntities_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_Void_T_Func_2_Match_D_Func_4_SerializedEntity_Match_Entity_D_0;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeMethodInfoPtr_HasEntry_Public_Boolean_T_0;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_D_T_Match_PlayerEntity_Entity_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeserializedEntity_Public_D_T_SerializedEntity_Match_Entity_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

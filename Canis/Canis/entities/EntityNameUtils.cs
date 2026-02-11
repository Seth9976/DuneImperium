using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000D8 RID: 216
	public static class EntityNameUtils : Object
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00005BBA File Offset: 0x00003DBA
		// Note: this type is marked as 'beforefieldinit'.
		static EntityNameUtils()
		{
			Il2CppClassPointerStore<EntityNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntityNameUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameUtils>.NativeClassPtr);
			EntityNameUtils.NativeMethodInfoPtr_get_PlainEntityDeser_Public_Static_get_Func_4_SerializedEntity_Match_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameUtils>.NativeClassPtr, 100665418);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00044164 File Offset: 0x00042364
		public unsafe static Func<SerializedEntity, Match, Entity, Entity> PlainEntityDeser
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 565452, RefRangeEnd = 565454, XrefRangeStart = 565437, XrefRangeEnd = 565452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameUtils.NativeMethodInfoPtr_get_PlainEntityDeser_Public_Static_get_Func_4_SerializedEntity_Match_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, Match, Entity, Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00005BF3 File Offset: 0x00003DF3
		public EntityNameUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_get_PlainEntityDeser_Public_Static_get_Func_4_SerializedEntity_Match_Entity_Entity_0;

		// Token: 0x0200031A RID: 794
		[ObfuscatedName("Canis.entities.EntityNameUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002131 RID: 8497 RVA: 0x00096E5C File Offset: 0x0009505C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityNameUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr);
				EntityNameUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr, "<>9");
				EntityNameUtils.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr, "<>9__1_0");
				EntityNameUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr, 100665420);
				EntityNameUtils.__c.NativeMethodInfoPtr__get_PlainEntityDeser_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr, 100665421);
			}

			// Token: 0x06002132 RID: 8498 RVA: 0x00096ED8 File Offset: 0x000950D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityNameUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002133 RID: 8499 RVA: 0x00096F14 File Offset: 0x00095114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 565433, XrefRangeEnd = 565437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity _get_PlainEntityDeser_b__1_0(SerializedEntity se, Match m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityNameUtils.__c.NativeMethodInfoPtr__get_PlainEntityDeser_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06002134 RID: 8500 RVA: 0x0000FEC3 File Offset: 0x0000E0C3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x06002135 RID: 8501 RVA: 0x00096F88 File Offset: 0x00095188
			// (set) Token: 0x06002136 RID: 8502 RVA: 0x0000FECC File Offset: 0x0000E0CC
			public unsafe static EntityNameUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNameUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityNameUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNameUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x00096FB0 File Offset: 0x000951B0
			// (set) Token: 0x06002138 RID: 8504 RVA: 0x0000FEDE File Offset: 0x0000E0DE
			public unsafe static Func<SerializedEntity, Match, Entity, Entity> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityNameUtils.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedEntity, Match, Entity, Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityNameUtils.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014E6 RID: 5350
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeMethodInfoPtr__get_PlainEntityDeser_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0;
		}
	}
}

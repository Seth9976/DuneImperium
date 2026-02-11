using System;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x02000150 RID: 336
	public static class DBGAbilityEntityNames : Object
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x00007741 File Offset: 0x00005941
		// Note: this type is marked as 'beforefieldinit'.
		static DBGAbilityEntityNames()
		{
			Il2CppClassPointerStore<DBGAbilityEntityNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGAbilityEntityNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGAbilityEntityNames>.NativeClassPtr);
			DBGAbilityEntityNames.NativeFieldInfoPtr_Abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAbilityEntityNames>.NativeClassPtr, "Abilities");
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0000777A File Offset: 0x0000597A
		public DBGAbilityEntityNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0005802C File Offset: 0x0005622C
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00007783 File Offset: 0x00005983
		public unsafe static EntityName Abilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGAbilityEntityNames.NativeFieldInfoPtr_Abilities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGAbilityEntityNames.NativeFieldInfoPtr_Abilities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_Abilities;

		// Token: 0x0200039F RID: 927
		[ObfuscatedName("Canis.data.DBGAbilityEntityNames+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002686 RID: 9862 RVA: 0x000A9B38 File Offset: 0x000A7D38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGAbilityEntityNames>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr);
				DBGAbilityEntityNames.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr, "<>9");
				DBGAbilityEntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr, 100666521);
				DBGAbilityEntityNames.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr, 100666522);
				DBGAbilityEntityNames.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr, 100666523);
			}

			// Token: 0x06002687 RID: 9863 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGAbilityEntityNames.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAbilityEntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002688 RID: 9864 RVA: 0x000A9BF0 File Offset: 0x000A7DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577901, XrefRangeEnd = 577905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__1_0(SerializedEntity se, Match m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAbilityEntityNames.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06002689 RID: 9865 RVA: 0x000A9C64 File Offset: 0x000A7E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577905, XrefRangeEnd = 577910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_1(Entity ent, Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGAbilityEntityNames.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600268A RID: 9866 RVA: 0x000125B2 File Offset: 0x000107B2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x0600268B RID: 9867 RVA: 0x000A9CB8 File Offset: 0x000A7EB8
			// (set) Token: 0x0600268C RID: 9868 RVA: 0x000125BB File Offset: 0x000107BB
			public unsafe static DBGAbilityEntityNames.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGAbilityEntityNames.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGAbilityEntityNames.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGAbilityEntityNames.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Entity_SerializedEntity_Match_Entity_0;

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_Entity_Entity_0;
		}
	}
}

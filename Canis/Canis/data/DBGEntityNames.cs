using System;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.data
{
	// Token: 0x0200014F RID: 335
	public static class DBGEntityNames : Object
	{
		// Token: 0x06000ED1 RID: 3793 RVA: 0x00057EF0 File Offset: 0x000560F0
		// Note: this type is marked as 'beforefieldinit'.
		static DBGEntityNames()
		{
			Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.data", "DBGEntityNames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr);
			DBGEntityNames.NativeFieldInfoPtr_Playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr, "Playmat");
			DBGEntityNames.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr, "Player");
			DBGEntityNames.NativeFieldInfoPtr_Playable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr, "Playable");
			DBGEntityNames.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr, 100666514);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00057F70 File Offset: 0x00056170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76111, RefRangeEnd = 76112, XrefRangeStart = 76111, XrefRangeEnd = 76112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEntityName Get(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityNames.NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEntityName>(intPtr3) : null;
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00007702 File Offset: 0x00005902
		public DBGEntityNames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00057FB4 File Offset: 0x000561B4
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x0000770B File Offset: 0x0000590B
		public unsafe static EntityName Playmat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGEntityNames.NativeFieldInfoPtr_Playmat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGEntityNames.NativeFieldInfoPtr_Playmat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00057FDC File Offset: 0x000561DC
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0000771D File Offset: 0x0000591D
		public unsafe static EntityName Player
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGEntityNames.NativeFieldInfoPtr_Player, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGEntityNames.NativeFieldInfoPtr_Player, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00058004 File Offset: 0x00056204
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x0000772F File Offset: 0x0000592F
		public unsafe static EntityName Playable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGEntityNames.NativeFieldInfoPtr_Playable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityName>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGEntityNames.NativeFieldInfoPtr_Playable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr_Playmat;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_Playable;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_IEntityName_String_0;

		// Token: 0x0200039E RID: 926
		[ObfuscatedName("Canis.data.DBGEntityNames+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002680 RID: 9856 RVA: 0x000A99F8 File Offset: 0x000A7BF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGEntityNames>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr);
				DBGEntityNames.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr, "<>9");
				DBGEntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr, 100666517);
				DBGEntityNames.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr, 100666518);
			}

			// Token: 0x06002681 RID: 9857 RVA: 0x000A9A60 File Offset: 0x000A7C60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGEntityNames.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002682 RID: 9858 RVA: 0x000A9A9C File Offset: 0x000A7C9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577897, XrefRangeEnd = 577901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entity __cctor_b__4_0(SerializedEntity se, Match m, Entity parent)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGEntityNames.__c.NativeMethodInfoPtr___cctor_b__4_0_Internal_Entity_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}

			// Token: 0x06002683 RID: 9859 RVA: 0x00012597 File Offset: 0x00010797
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06002684 RID: 9860 RVA: 0x000A9B10 File Offset: 0x000A7D10
			// (set) Token: 0x06002685 RID: 9861 RVA: 0x000125A0 File Offset: 0x000107A0
			public unsafe static DBGEntityNames.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGEntityNames.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntityNames.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGEntityNames.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400180A RID: 6154
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__4_0_Internal_Entity_SerializedEntity_Match_Entity_0;
		}
	}
}

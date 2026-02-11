using System;
using boardgames.match.behaviours;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.match.data;

namespace worm.match.components
{
	// Token: 0x020001BA RID: 442
	public class PlaySoundOnPlayerStinger : VersionedSubscriber<WormLeaderData>
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x00053660 File Offset: 0x00051860
		// Note: this type is marked as 'beforefieldinit'.
		static PlaySoundOnPlayerStinger()
		{
			Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "PlaySoundOnPlayerStinger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr);
			PlaySoundOnPlayerStinger.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, "entities");
			PlaySoundOnPlayerStinger.NativeFieldInfoPtr_playOnPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, "playOnPlayer");
			PlaySoundOnPlayerStinger.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, 100665969);
			PlaySoundOnPlayerStinger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, 100665970);
			PlaySoundOnPlayerStinger.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, 100665971);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000536F4 File Offset: 0x000518F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713113, XrefRangeEnd = 713169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaySoundOnPlayerStinger.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00053730 File Offset: 0x00051930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713169, XrefRangeEnd = 713175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaySoundOnPlayerStinger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundOnPlayerStinger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0005376C File Offset: 0x0005196C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713175, XrefRangeEnd = 713181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__2_0(EntityComponent p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundOnPlayerStinger.NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0000C0D6 File Offset: 0x0000A2D6
		public PlaySoundOnPlayerStinger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000537BC File Offset: 0x000519BC
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x0000C0DF File Offset: 0x0000A2DF
		public unsafe DBGEntitiesProvider entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundOnPlayerStinger.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundOnPlayerStinger.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000537EC File Offset: 0x000519EC
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x0000C0FE File Offset: 0x0000A2FE
		public unsafe string playOnPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundOnPlayerStinger.NativeFieldInfoPtr_playOnPlayer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundOnPlayerStinger.NativeFieldInfoPtr_playOnPlayer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_playOnPlayer;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__2_0_Private_Boolean_EntityComponent_0;

		// Token: 0x020003C9 RID: 969
		[ObfuscatedName("worm.match.components.PlaySoundOnPlayerStinger+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002737 RID: 10039 RVA: 0x0008F200 File Offset: 0x0008D400
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaySoundOnPlayerStinger>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr);
				PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr, "<>9");
				PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr, "<>9__2_1");
				PlaySoundOnPlayerStinger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr, 100665973);
				PlaySoundOnPlayerStinger.__c.NativeMethodInfoPtr__dirtyUpdate_b__2_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr, 100665974);
			}

			// Token: 0x06002738 RID: 10040 RVA: 0x0008F27C File Offset: 0x0008D47C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundOnPlayerStinger.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundOnPlayerStinger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002739 RID: 10041 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 713106, XrefRangeEnd = 713113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__2_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundOnPlayerStinger.__c.NativeMethodInfoPtr__dirtyUpdate_b__2_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600273A RID: 10042 RVA: 0x00015952 File Offset: 0x00013B52
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x0600273B RID: 10043 RVA: 0x0008F308 File Offset: 0x0008D508
			// (set) Token: 0x0600273C RID: 10044 RVA: 0x0001595B File Offset: 0x00013B5B
			public unsafe static PlaySoundOnPlayerStinger.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaySoundOnPlayerStinger.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x0600273D RID: 10045 RVA: 0x0008F330 File Offset: 0x0008D530
			// (set) Token: 0x0600273E RID: 10046 RVA: 0x0001596D File Offset: 0x00013B6D
			public unsafe static Func<EntityComponent, bool> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlaySoundOnPlayerStinger.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001696 RID: 5782
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001697 RID: 5783
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001698 RID: 5784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001699 RID: 5785
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__2_1_Internal_Boolean_EntityComponent_0;
		}
	}
}

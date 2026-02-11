using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions;

namespace worm.canis.entities
{
	// Token: 0x0200003B RID: 59
	public class WormTrack : WormEntity
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x0007E400 File Offset: 0x0007C600
		// Note: this type is marked as 'beforefieldinit'.
		static WormTrack()
		{
			Il2CppClassPointerStore<WormTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrack>.NativeClassPtr);
			WormTrack.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, "wormMatch");
			WormTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664697);
			WormTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664698);
			WormTrack.NativeMethodInfoPtr_get_TrackSpaces_Public_get_IEnumerable_1_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664699);
			WormTrack.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664700);
			WormTrack.NativeMethodInfoPtr_GetPlayerMarker_Protected_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664701);
			WormTrack.NativeMethodInfoPtr_CurrentRank_Public_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664702);
			WormTrack.NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_New_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664703);
			WormTrack.NativeMethodInfoPtr_GetSpaceAt_Public_WormSpace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664704);
			WormTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664705);
			WormTrack.NativeMethodInfoPtr_ChangeRank_Public_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, 100664706);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0007E50C File Offset: 0x0007C70C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 48903, RefRangeEnd = 48908, XrefRangeStart = 48885, XrefRangeEnd = 48903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTrack(WormMatch m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0007E56C File Offset: 0x0007C76C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 48916, RefRangeEnd = 48920, XrefRangeStart = 48908, XrefRangeEnd = 48916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTrack(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrack>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0007E5DC File Offset: 0x0007C7DC
		public unsafe IEnumerable<WormSpace> TrackSpaces
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 48923, RefRangeEnd = 48939, XrefRangeStart = 48920, XrefRangeEnd = 48923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr_get_TrackSpaces_Public_get_IEnumerable_1_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0007E61C File Offset: 0x0007C81C
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrack.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0007E658 File Offset: 0x0007C858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 48955, RefRangeEnd = 48959, XrefRangeStart = 48939, XrefRangeEnd = 48955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity GetPlayerMarker(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr_GetPlayerMarker_Protected_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0007E6A8 File Offset: 0x0007C8A8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 48995, RefRangeEnd = 49019, XrefRangeStart = 48959, XrefRangeEnd = 48995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurrentRank(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr_CurrentRank_Public_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0007E6F8 File Offset: 0x0007C8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49019, XrefRangeEnd = 49044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int HighestOpponentRank(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrack.NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_New_Int32_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0007E750 File Offset: 0x0007C950
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 49053, RefRangeEnd = 49073, XrefRangeStart = 49044, XrefRangeEnd = 49053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSpace GetSpaceAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.NativeMethodInfoPtr_GetSpaceAt_Public_WormSpace_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0007E79C File Offset: 0x0007C99C
		[CallerCount(0)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> ChangeRankBonuses(WormPlayer player, int currentRank, int newRank, ActionLogModes logMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrack.NativeMethodInfoPtr_ChangeRankBonuses_Protected_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0007E824 File Offset: 0x0007CA24
		[CallerCount(0)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> ChangeRank(WormPlayer player, global::Canis.actions.Action triggeringAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeringAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTrack.NativeMethodInfoPtr_ChangeRank_Public_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00003D75 File Offset: 0x00001F75
		public WormTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0007E894 File Offset: 0x0007CA94
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00003D7E File Offset: 0x00001F7E
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackSpaces_Public_get_IEnumerable_1_WormSpace_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerMarker_Protected_Entity_WormPlayer_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_CurrentRank_Public_Int32_WormPlayer_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_HighestOpponentRank_Public_Virtual_New_Int32_WormPlayer_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_GetSpaceAt_Public_WormSpace_Int32_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRankBonuses_Protected_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Int32_Int32_ActionLogModes_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRank_Public_Abstract_Virtual_New_IEnumerable_1_Action_WormPlayer_Action_0;

		// Token: 0x020005DA RID: 1498
		[ObfuscatedName("worm.canis.entities.WormTrack+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x0600490E RID: 18702 RVA: 0x001904FC File Offset: 0x0018E6FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr);
				WormTrack.__c__DisplayClass6_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr, "player");
				WormTrack.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr, 100664707);
				WormTrack.__c__DisplayClass6_0.NativeMethodInfoPtr__GetPlayerMarker_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr, 100664708);
			}

			// Token: 0x0600490F RID: 18703 RVA: 0x00190564 File Offset: 0x0018E764
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrack.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004910 RID: 18704 RVA: 0x001905A0 File Offset: 0x0018E7A0
			[CallerCount(0)]
			public unsafe bool _GetPlayerMarker_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass6_0.NativeMethodInfoPtr__GetPlayerMarker_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004911 RID: 18705 RVA: 0x00018E64 File Offset: 0x00017064
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C0 RID: 4544
			// (get) Token: 0x06004912 RID: 18706 RVA: 0x001905F0 File Offset: 0x0018E7F0
			// (set) Token: 0x06004913 RID: 18707 RVA: 0x00018E6D File Offset: 0x0001706D
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass6_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass6_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FFB RID: 12283
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002FFC RID: 12284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002FFD RID: 12285
			private static readonly IntPtr NativeMethodInfoPtr__GetPlayerMarker_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005DB RID: 1499
		[ObfuscatedName("worm.canis.entities.WormTrack+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06004914 RID: 18708 RVA: 0x00190620 File Offset: 0x0018E820
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr);
				WormTrack.__c__DisplayClass7_0.NativeFieldInfoPtr_parentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr, "parentTrack");
				WormTrack.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr, 100664709);
				WormTrack.__c__DisplayClass7_0.NativeMethodInfoPtr__CurrentRank_b__0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr, 100664710);
			}

			// Token: 0x06004915 RID: 18709 RVA: 0x00190688 File Offset: 0x0018E888
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrack.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004916 RID: 18710 RVA: 0x001906C4 File Offset: 0x0018E8C4
			[CallerCount(0)]
			public unsafe bool _CurrentRank_b__0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass7_0.NativeMethodInfoPtr__CurrentRank_b__0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004917 RID: 18711 RVA: 0x00018E8C File Offset: 0x0001708C
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C1 RID: 4545
			// (get) Token: 0x06004918 RID: 18712 RVA: 0x00190714 File Offset: 0x0018E914
			// (set) Token: 0x06004919 RID: 18713 RVA: 0x00018E95 File Offset: 0x00017095
			public unsafe Entity parentTrack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass7_0.NativeFieldInfoPtr_parentTrack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass7_0.NativeFieldInfoPtr_parentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002FFE RID: 12286
			private static readonly IntPtr NativeFieldInfoPtr_parentTrack;

			// Token: 0x04002FFF RID: 12287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003000 RID: 12288
			private static readonly IntPtr NativeMethodInfoPtr__CurrentRank_b__0_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x020005DC RID: 1500
		[ObfuscatedName("worm.canis.entities.WormTrack+<>c__DisplayClass8_0")]
		public new sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600491A RID: 18714 RVA: 0x00190744 File Offset: 0x0018E944
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormTrack>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr);
				WormTrack.__c__DisplayClass8_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr, "player");
				WormTrack.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr, 100664711);
				WormTrack.__c__DisplayClass8_0.NativeMethodInfoPtr__HighestOpponentRank_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr, 100664712);
			}

			// Token: 0x0600491B RID: 18715 RVA: 0x001907AC File Offset: 0x0018E9AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTrack.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600491C RID: 18716 RVA: 0x001907E8 File Offset: 0x0018E9E8
			[CallerCount(0)]
			public unsafe bool _HighestOpponentRank_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTrack.__c__DisplayClass8_0.NativeMethodInfoPtr__HighestOpponentRank_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600491D RID: 18717 RVA: 0x00018EB4 File Offset: 0x000170B4
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170011C2 RID: 4546
			// (get) Token: 0x0600491E RID: 18718 RVA: 0x00190838 File Offset: 0x0018EA38
			// (set) Token: 0x0600491F RID: 18719 RVA: 0x00018EBD File Offset: 0x000170BD
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass8_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormTrack.__c__DisplayClass8_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003001 RID: 12289
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003002 RID: 12290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003003 RID: 12291
			private static readonly IntPtr NativeMethodInfoPtr__HighestOpponentRank_b__0_Internal_Boolean_WormPlayer_0;
		}
	}
}

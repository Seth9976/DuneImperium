using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using offlineChallenges;

namespace zen.src.challenges.events
{
	// Token: 0x02000085 RID: 133
	public class TurnEnded : OfflineChallenges.Event
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x00025BD4 File Offset: 0x00023DD4
		// Note: this type is marked as 'beforefieldinit'.
		static TurnEnded()
		{
			Il2CppClassPointerStore<TurnEnded>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.challenges.events", "TurnEnded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TurnEnded>.NativeClassPtr);
			TurnEnded.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnEnded>.NativeClassPtr, "player");
			TurnEnded.NativeFieldInfoPtr_yourTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TurnEnded>.NativeClassPtr, "yourTurn");
			TurnEnded.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TurnEnded>.NativeClassPtr, 100664391);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00025C40 File Offset: 0x00023E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TurnEnded(EntityComponent player, bool yourTurn)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TurnEnded>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yourTurn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TurnEnded.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00004FD8 File Offset: 0x000031D8
		public TurnEnded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x00025C9C File Offset: 0x00023E9C
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00004FE1 File Offset: 0x000031E1
		public unsafe EntityComponent player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnEnded.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnEnded.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00025CCC File Offset: 0x00023ECC
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00005000 File Offset: 0x00003200
		public unsafe bool yourTurn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnEnded.NativeFieldInfoPtr_yourTurn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TurnEnded.NativeFieldInfoPtr_yourTurn)) = value;
			}
		}

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_yourTurn;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_Boolean_0;
	}
}

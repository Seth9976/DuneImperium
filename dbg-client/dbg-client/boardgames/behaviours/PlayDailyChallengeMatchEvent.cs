using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.behaviours
{
	// Token: 0x020002A9 RID: 681
	public class PlayDailyChallengeMatchEvent : MonoBehaviour
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x00089724 File Offset: 0x00087924
		// Note: this type is marked as 'beforefieldinit'.
		static PlayDailyChallengeMatchEvent()
		{
			Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "PlayDailyChallengeMatchEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr);
			PlayDailyChallengeMatchEvent.NativeFieldInfoPtr_playCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr, "playCoroutine");
			PlayDailyChallengeMatchEvent.NativeMethodInfoPtr_Event_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr, 100668679);
			PlayDailyChallengeMatchEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr, 100668680);
			PlayDailyChallengeMatchEvent.NativeMethodInfoPtr__Event_Play_b__1_0_Private_Void_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr, 100668681);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000897A4 File Offset: 0x000879A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542381, XrefRangeEnd = 542397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatchEvent.NativeMethodInfoPtr_Event_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000897D8 File Offset: 0x000879D8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayDailyChallengeMatchEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeMatchEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatchEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00089814 File Offset: 0x00087A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542397, XrefRangeEnd = 542398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_Play_b__1_0(IFailable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatchEvent.NativeMethodInfoPtr__Event_Play_b__1_0_Private_Void_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00010F85 File Offset: 0x0000F185
		public PlayDailyChallengeMatchEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00089858 File Offset: 0x00087A58
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x00010F8E File Offset: 0x0000F18E
		public unsafe Coroutine playCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatchEvent.NativeFieldInfoPtr_playCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatchEvent.NativeFieldInfoPtr_playCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeFieldInfoPtr_playCoroutine;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr__Event_Play_b__1_0_Private_Void_IFailable_0;
	}
}

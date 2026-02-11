using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.providers;
using dwd.core.matchmaking.messages.incoming;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus.match.selectionUnblocking
{
	// Token: 0x020000E5 RID: 229
	public class GameMessageQueueBase : DataProvider
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x00034F08 File Offset: 0x00033108
		// Note: this type is marked as 'beforefieldinit'.
		static GameMessageQueueBase()
		{
			Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.match.selectionUnblocking", "GameMessageQueueBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr);
			GameMessageQueueBase.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, "<GameID>k__BackingField");
			GameMessageQueueBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665095);
			GameMessageQueueBase.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665096);
			GameMessageQueueBase.NativeMethodInfoPtr_set_GameID_Protected_set_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665097);
			GameMessageQueueBase.NativeMethodInfoPtr_Observe_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665098);
			GameMessageQueueBase.NativeMethodInfoPtr_MatchFound_Public_Void_MatchFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665099);
			GameMessageQueueBase.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665100);
			GameMessageQueueBase.NativeMethodInfoPtr_Dequeue_Public_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665101);
			GameMessageQueueBase.NativeMethodInfoPtr_enqueue_Protected_Abstract_Virtual_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665102);
			GameMessageQueueBase.NativeMethodInfoPtr_dequeue_Protected_Abstract_Virtual_New_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665103);
			GameMessageQueueBase.NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665104);
			GameMessageQueueBase.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665105);
			GameMessageQueueBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr, 100665106);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0003503C File Offset: 0x0003323C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameMessageQueueBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00035078 File Offset: 0x00033278
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x000350B8 File Offset: 0x000332B8
		public unsafe GameID GameID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_set_GameID_Protected_set_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000350FC File Offset: 0x000332FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994560, XrefRangeEnd = 994561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Observe(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_Observe_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00035140 File Offset: 0x00033340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994572, RefRangeEnd = 994574, XrefRangeStart = 994561, XrefRangeEnd = 994572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MatchFound(MatchFound message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_MatchFound_Public_Void_MatchFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00035184 File Offset: 0x00033384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994574, XrefRangeEnd = 994610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000351C8 File Offset: 0x000333C8
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 868124, RefRangeEnd = 868148, XrefRangeStart = 868124, XrefRangeEnd = 868148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGameMessage Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr_Dequeue_Public_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr3) : null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00035208 File Offset: 0x00033408
		[CallerCount(0)]
		public unsafe virtual void enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameMessageQueueBase.NativeMethodInfoPtr_enqueue_Protected_Abstract_Virtual_New_Void_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00035258 File Offset: 0x00033458
		[CallerCount(0)]
		public unsafe virtual IGameMessage dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameMessageQueueBase.NativeMethodInfoPtr_dequeue_Protected_Abstract_Virtual_New_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr3) : null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000352A4 File Offset: 0x000334A4
		[CallerCount(0)]
		public unsafe virtual void clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameMessageQueueBase.NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000352E0 File Offset: 0x000334E0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameMessageQueueBase.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00035328 File Offset: 0x00033528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 875404, RefRangeEnd = 875407, XrefRangeStart = 875404, XrefRangeEnd = 875407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameMessageQueueBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMessageQueueBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueueBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0000721E File Offset: 0x0000541E
		public GameMessageQueueBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00035364 File Offset: 0x00033564
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00007227 File Offset: 0x00005427
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMessageQueueBase.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMessageQueueBase.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_set_GameID_Protected_set_Void_GameID_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_Observe_Public_Void_GameID_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_MatchFound_Public_Void_MatchFound_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_IGameMessage_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_enqueue_Protected_Abstract_Virtual_New_Void_IGameMessage_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_dequeue_Protected_Abstract_Virtual_New_IGameMessage_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_clear_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

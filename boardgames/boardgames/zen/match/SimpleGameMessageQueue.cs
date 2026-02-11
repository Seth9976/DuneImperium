using System;
using Canis.boardgames;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using lotus.match.selectionUnblocking;
using lotus.matchMaking;

namespace zen.match
{
	// Token: 0x02000045 RID: 69
	public class SimpleGameMessageQueue : GameMessageQueueBase
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x00019C4C File Offset: 0x00017E4C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleGameMessageQueue()
		{
			Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.match", "SimpleGameMessageQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr);
			SimpleGameMessageQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, "queue");
			SimpleGameMessageQueue.NativeFieldInfoPtr__GameCompletedRcvd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, "<GameCompletedRcvd>k__BackingField");
			SimpleGameMessageQueue.NativeFieldInfoPtr_onlineMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, "onlineMatch");
			SimpleGameMessageQueue.NativeFieldInfoPtr_playQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, "playQueue");
			SimpleGameMessageQueue.NativeMethodInfoPtr_get_GameCompletedRcvd_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663780);
			SimpleGameMessageQueue.NativeMethodInfoPtr_set_GameCompletedRcvd_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663781);
			SimpleGameMessageQueue.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663782);
			SimpleGameMessageQueue.NativeMethodInfoPtr_enqueue_Protected_Virtual_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663783);
			SimpleGameMessageQueue.NativeMethodInfoPtr_dequeue_Protected_Virtual_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663784);
			SimpleGameMessageQueue.NativeMethodInfoPtr_clear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663785);
			SimpleGameMessageQueue.NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_IGameMessage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663786);
			SimpleGameMessageQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663787);
			SimpleGameMessageQueue.NativeMethodInfoPtr_checkForGameEndConditions_Protected_Virtual_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663788);
			SimpleGameMessageQueue.NativeMethodInfoPtr_isGameEndMessage_Protected_Virtual_New_Boolean_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663789);
			SimpleGameMessageQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr, 100663790);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00019DA8 File Offset: 0x00017FA8
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00019DE4 File Offset: 0x00017FE4
		public unsafe bool GameCompletedRcvd
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleGameMessageQueue.NativeMethodInfoPtr_get_GameCompletedRcvd_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleGameMessageQueue.NativeMethodInfoPtr_set_GameCompletedRcvd_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00019E24 File Offset: 0x00018024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985331, XrefRangeEnd = 985336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00019E60 File Offset: 0x00018060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985336, XrefRangeEnd = 985348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_enqueue_Protected_Virtual_Void_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00019EB0 File Offset: 0x000180B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985348, XrefRangeEnd = 985358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IGameMessage dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_dequeue_Protected_Virtual_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr3) : null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00019EFC File Offset: 0x000180FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985358, XrefRangeEnd = 985361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_clear_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00019F38 File Offset: 0x00018138
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985387, RefRangeEnd = 985388, XrefRangeStart = 985361, XrefRangeEnd = 985387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveWhere(Func<IGameMessage, bool> filterPredicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filterPredicate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleGameMessageQueue.NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_IGameMessage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00019F7C File Offset: 0x0001817C
		public unsafe override int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985388, XrefRangeEnd = 985392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00019FC4 File Offset: 0x000181C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985392, XrefRangeEnd = 985415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void checkForGameEndConditions(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_checkForGameEndConditions_Protected_Virtual_New_Void_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001A014 File Offset: 0x00018214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985415, XrefRangeEnd = 985416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool isGameEndMessage(IGameMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SimpleGameMessageQueue.NativeMethodInfoPtr_isGameEndMessage_Protected_Virtual_New_Boolean_IGameMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001A06C File Offset: 0x0001826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985416, XrefRangeEnd = 985424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleGameMessageQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleGameMessageQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleGameMessageQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000032E6 File Offset: 0x000014E6
		public SimpleGameMessageQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0001A0A8 File Offset: 0x000182A8
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000032EF File Offset: 0x000014EF
		public unsafe ConcurrentQueue<IGameMessage> queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<IGameMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0001A0D8 File Offset: 0x000182D8
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000330E File Offset: 0x0000150E
		public unsafe bool _GameCompletedRcvd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr__GameCompletedRcvd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr__GameCompletedRcvd_k__BackingField)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0001A100 File Offset: 0x00018300
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003329 File Offset: 0x00001529
		public unsafe CanisOnlineMatch onlineMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_onlineMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisOnlineMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_onlineMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001A130 File Offset: 0x00018330
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00003348 File Offset: 0x00001548
		public unsafe PlayQueue playQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_playQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleGameMessageQueue.NativeFieldInfoPtr_playQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_queue;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__GameCompletedRcvd_k__BackingField;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_onlineMatch;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_playQueue;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_GameCompletedRcvd_Public_get_Boolean_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_set_GameCompletedRcvd_Protected_set_Void_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_enqueue_Protected_Virtual_Void_IGameMessage_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_dequeue_Protected_Virtual_IGameMessage_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_clear_Protected_Virtual_Void_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_RemoveWhere_Public_Void_Func_2_IGameMessage_Boolean_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_get_Int32_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_checkForGameEndConditions_Protected_Virtual_New_Void_IGameMessage_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_isGameEndMessage_Protected_Virtual_New_Boolean_IGameMessage_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

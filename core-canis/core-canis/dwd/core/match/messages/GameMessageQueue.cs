using System;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.match.messages
{
	// Token: 0x02000161 RID: 353
	public class GameMessageQueue : DataProvider
	{
		// Token: 0x060014B6 RID: 5302 RVA: 0x00067370 File Offset: 0x00065570
		// Note: this type is marked as 'beforefieldinit'.
		static GameMessageQueue()
		{
			Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.messages", "GameMessageQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr);
			GameMessageQueue.NativeFieldInfoPtr_queues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, "queues");
			GameMessageQueue.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666418);
			GameMessageQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666419);
			GameMessageQueue.NativeMethodInfoPtr_Dequeue_Public_IGameMessage_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666420);
			GameMessageQueue.NativeMethodInfoPtr_GetCount_Public_Int32_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666421);
			GameMessageQueue.NativeMethodInfoPtr_Find_Public_Static_GameMessageQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666422);
			GameMessageQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr, 100666423);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0006742C File Offset: 0x0006562C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00067460 File Offset: 0x00065660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875041, XrefRangeEnd = 875061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(IGameMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000674A4 File Offset: 0x000656A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875061, XrefRangeEnd = 875068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGameMessage Dequeue(GameID game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr_Dequeue_Public_IGameMessage_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr3) : null;
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000674F4 File Offset: 0x000656F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875068, XrefRangeEnd = 875072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCount(GameID game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr_GetCount_Public_Int32_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00067544 File Offset: 0x00065744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875072, XrefRangeEnd = 875075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameMessageQueue Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr_Find_Public_Static_GameMessageQueue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameMessageQueue>(intPtr3) : null;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00067578 File Offset: 0x00065778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875075, XrefRangeEnd = 875083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameMessageQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMessageQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameMessageQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00009283 File Offset: 0x00007483
		public GameMessageQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000675B4 File Offset: 0x000657B4
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000928C File Offset: 0x0000748C
		public unsafe Dictionary<GameID, Queue<IGameMessage>> queues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMessageQueue.NativeFieldInfoPtr_queues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, Queue<IGameMessage>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameMessageQueue.NativeFieldInfoPtr_queues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeFieldInfoPtr_queues;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IGameMessage_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_IGameMessage_GameID_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_GetCount_Public_Int32_GameID_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_GameMessageQueue_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

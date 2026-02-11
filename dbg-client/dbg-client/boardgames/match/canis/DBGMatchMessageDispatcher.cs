using System;
using Canis.json.events;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus.match.selectionUnblocking;
using UnityEngine;

namespace boardgames.match.canis
{
	// Token: 0x0200027F RID: 639
	public class DBGMatchMessageDispatcher : MonoBehaviour
	{
		// Token: 0x06001DFB RID: 7675 RVA: 0x00081924 File Offset: 0x0007FB24
		// Note: this type is marked as 'beforefieldinit'.
		static DBGMatchMessageDispatcher()
		{
			Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.canis", "DBGMatchMessageDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr);
			DBGMatchMessageDispatcher.NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, "session");
			DBGMatchMessageDispatcher.NativeFieldInfoPtr_gameQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, "gameQueue");
			DBGMatchMessageDispatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, 100668215);
			DBGMatchMessageDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, 100668216);
			DBGMatchMessageDispatcher.NativeMethodInfoPtr_handle_Private_Void_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, 100668217);
			DBGMatchMessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr, 100668218);
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000819CC File Offset: 0x0007FBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538086, XrefRangeEnd = 538102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageDispatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00081A00 File Offset: 0x0007FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538102, XrefRangeEnd = 538112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageDispatcher.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00081A34 File Offset: 0x0007FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 538112, XrefRangeEnd = 538128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handle(NetworkMessageEvent message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageDispatcher.NativeMethodInfoPtr_handle_Private_Void_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00081A78 File Offset: 0x0007FC78
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGMatchMessageDispatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchMessageDispatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchMessageDispatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0000FD2D File Offset: 0x0000DF2D
		public DBGMatchMessageDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x00081AB4 File Offset: 0x0007FCB4
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0000FD36 File Offset: 0x0000DF36
		public unsafe SessionProvider session
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageDispatcher.NativeFieldInfoPtr_session);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageDispatcher.NativeFieldInfoPtr_session), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x00081AE4 File Offset: 0x0007FCE4
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0000FD55 File Offset: 0x0000DF55
		public unsafe GameMessageQueueBase gameQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageDispatcher.NativeFieldInfoPtr_gameQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameMessageQueueBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchMessageDispatcher.NativeFieldInfoPtr_gameQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_session;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_gameQueue;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_handle_Private_Void_NetworkMessageEvent_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

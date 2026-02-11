using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.service
{
	// Token: 0x02000056 RID: 86
	public class JoinGameSessionAsObserver : NetworkMessageEvent
	{
		// Token: 0x060002CA RID: 714 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		// Note: this type is marked as 'beforefieldinit'.
		static JoinGameSessionAsObserver()
		{
			Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "JoinGameSessionAsObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr);
			JoinGameSessionAsObserver.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr, "GameID");
			JoinGameSessionAsObserver.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr, "Token");
			JoinGameSessionAsObserver.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr, "Metadata");
			JoinGameSessionAsObserver.NativeFieldInfoPtr_observePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr, "observePlayer");
			JoinGameSessionAsObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr, 100663437);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000D080 File Offset: 0x0000B280
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinGameSessionAsObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinGameSessionAsObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinGameSessionAsObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003D04 File Offset: 0x00001F04
		public JoinGameSessionAsObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00003D0D File Offset: 0x00001F0D
		public unsafe string GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_GameID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_GameID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00003D2C File Offset: 0x00001F2C
		public unsafe string Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_Token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000D10C File Offset: 0x0000B30C
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00003D4B File Offset: 0x00001F4B
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000D13C File Offset: 0x0000B33C
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00003D6A File Offset: 0x00001F6A
		public unsafe AccountID observePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_observePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSessionAsObserver.NativeFieldInfoPtr_observePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_observePlayer;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

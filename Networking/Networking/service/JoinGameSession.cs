using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.service
{
	// Token: 0x02000055 RID: 85
	public class JoinGameSession : NetworkMessageEvent
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0000CE38 File Offset: 0x0000B038
		// Note: this type is marked as 'beforefieldinit'.
		static JoinGameSession()
		{
			Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "JoinGameSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr);
			JoinGameSession.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, "GameSessionID");
			JoinGameSession.NativeFieldInfoPtr_PlayerSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, "PlayerSessionID");
			JoinGameSession.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, "Token");
			JoinGameSession.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, "Metadata");
			JoinGameSession.NativeFieldInfoPtr_AckClientMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, "AckClientMessages");
			JoinGameSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr, 100663436);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JoinGameSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinGameSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JoinGameSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003C64 File Offset: 0x00001E64
		public JoinGameSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000CF1C File Offset: 0x0000B11C
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00003C6D File Offset: 0x00001E6D
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000CF44 File Offset: 0x0000B144
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00003C8C File Offset: 0x00001E8C
		public unsafe string PlayerSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_PlayerSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_PlayerSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000CF6C File Offset: 0x0000B16C
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00003CAB File Offset: 0x00001EAB
		public unsafe string Token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_Token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_Token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000CF94 File Offset: 0x0000B194
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00003CCA File Offset: 0x00001ECA
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000CFC4 File Offset: 0x0000B1C4
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00003CE9 File Offset: 0x00001EE9
		public unsafe bool AckClientMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_AckClientMessages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JoinGameSession.NativeFieldInfoPtr_AckClientMessages)) = value;
			}
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSessionID;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_Token;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_AckClientMessages;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

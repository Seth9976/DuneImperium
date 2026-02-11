using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.messages
{
	// Token: 0x0200002F RID: 47
	public class SerializedGameState : GameMessage
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000A074 File Offset: 0x00008274
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGameState()
		{
			Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "SerializedGameState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr);
			SerializedGameState.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr, "Entities");
			SerializedGameState.NativeFieldInfoPtr_PlayerAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr, "PlayerAccounts");
			SerializedGameState.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr, "GameOptions");
			SerializedGameState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr, 100663378);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00003133 File Offset: 0x00001333
		public SerializedGameState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000A130 File Offset: 0x00008330
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0000313C File Offset: 0x0000133C
		public unsafe SerializedEntity Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0000A160 File Offset: 0x00008360
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe Il2CppReferenceArray<AccountID> PlayerAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_PlayerAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_PlayerAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000A190 File Offset: 0x00008390
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0000317A File Offset: 0x0000137A
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameState.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccounts;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

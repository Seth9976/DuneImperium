using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.sequence
{
	// Token: 0x0200003D RID: 61
	public class SequenceMessage : NetworkMessageEvent
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000B1C4 File Offset: 0x000093C4
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceMessage()
		{
			Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.sequence", "SequenceMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr);
			SequenceMessage.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr, "SequenceID");
			SequenceMessage.NativeFieldInfoPtr_Msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr, "Msg");
			SequenceMessage.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr, 100663397);
			SequenceMessage.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr, 100663398);
			SequenceMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr, 100663399);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B258 File Offset: 0x00009458
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 504845, RefRangeEnd = 504850, XrefRangeStart = 504845, XrefRangeEnd = 504850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceMessage(SequenceID sequenceID, IGameMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequenceID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceMessage.NativeMethodInfoPtr__ctor_Public_Void_SequenceID_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public unsafe virtual GameID GameID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1193721, RefRangeEnd = 1193722, XrefRangeStart = 1193717, XrefRangeEnd = 1193721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceMessage.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193722, XrefRangeEnd = 1193726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequenceMessage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000364B File Offset: 0x0000184B
		public SequenceMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000B33C File Offset: 0x0000953C
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00003654 File Offset: 0x00001854
		public unsafe SequenceID SequenceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceMessage.NativeFieldInfoPtr_SequenceID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceMessage.NativeFieldInfoPtr_SequenceID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000B36C File Offset: 0x0000956C
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00003673 File Offset: 0x00001873
		public unsafe IGameMessage Msg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceMessage.NativeFieldInfoPtr_Msg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceMessage.NativeFieldInfoPtr_Msg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeFieldInfoPtr_Msg;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceID_IGameMessage_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

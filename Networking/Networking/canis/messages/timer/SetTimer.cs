using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.selection.messages;

namespace Canis.messages.timer
{
	// Token: 0x0200003B RID: 59
	public class SetTimer : NetworkMessageEvent
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0000AE10 File Offset: 0x00009010
		// Note: this type is marked as 'beforefieldinit'.
		static SetTimer()
		{
			Il2CppClassPointerStore<SetTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "SetTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTimer>.NativeClassPtr);
			SetTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, "TimerID");
			SetTimer.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, "AccountID");
			SetTimer.NativeFieldInfoPtr_Wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, "Wait");
			SetTimer.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, "Padding");
			SetTimer.NativeFieldInfoPtr_SelectionMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, "SelectionMessage");
			SetTimer.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, 100663393);
			SetTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTimer>.NativeClassPtr, 100663394);
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000AECC File Offset: 0x000090CC
		public unsafe virtual GameID GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimer.NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000AF0C File Offset: 0x0000910C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00003549 File Offset: 0x00001749
		public SetTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000AF48 File Offset: 0x00009148
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00003552 File Offset: 0x00001752
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000AF78 File Offset: 0x00009178
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00003571 File Offset: 0x00001771
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000AFA8 File Offset: 0x000091A8
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00003590 File Offset: 0x00001790
		public unsafe int Wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_Wait);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_Wait)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000AFD0 File Offset: 0x000091D0
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000035AB File Offset: 0x000017AB
		public unsafe float Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000AFF8 File Offset: 0x000091F8
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000035C6 File Offset: 0x000017C6
		public unsafe SelectionMessage SelectionMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_SelectionMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTimer.NativeFieldInfoPtr_SelectionMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_Wait;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_SelectionMessage;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Virtual_Final_New_get_GameID_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

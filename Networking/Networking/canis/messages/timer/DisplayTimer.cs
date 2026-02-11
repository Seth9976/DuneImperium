using System;
using Canis.attributes;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000036 RID: 54
	public class DisplayTimer : NetworkMessageEvent
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0000A704 File Offset: 0x00008904
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayTimer()
		{
			Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "DisplayTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr);
			DisplayTimer.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "AccountID");
			DisplayTimer.NativeFieldInfoPtr_WaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "WaitTime");
			DisplayTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "TimerID");
			DisplayTimer.NativeFieldInfoPtr_TotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "TotalTime");
			DisplayTimer.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "Attributes");
			DisplayTimer.NativeFieldInfoPtr_StartedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "StartedAt");
			DisplayTimer.NativeFieldInfoPtr_EndsAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, "EndsAt");
			DisplayTimer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, 100663385);
			DisplayTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr, 100663386);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193657, XrefRangeEnd = 1193702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisplayTimer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000A82C File Offset: 0x00008A2C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplayTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplayTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000332E File Offset: 0x0000152E
		public DisplayTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000A868 File Offset: 0x00008A68
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00003337 File Offset: 0x00001537
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000A898 File Offset: 0x00008A98
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00003356 File Offset: 0x00001556
		public unsafe int WaitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_WaitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_WaitTime)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00003371 File Offset: 0x00001571
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00003390 File Offset: 0x00001590
		public unsafe int TotalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_TotalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_TotalTime)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000A918 File Offset: 0x00008B18
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000033AB File Offset: 0x000015AB
		public unsafe ReadOnlyAttributes Attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_Attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_Attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000A948 File Offset: 0x00008B48
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x000033CA File Offset: 0x000015CA
		public unsafe long StartedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_StartedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_StartedAt)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000A970 File Offset: 0x00008B70
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x000033E5 File Offset: 0x000015E5
		public unsafe long EndsAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_EndsAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisplayTimer.NativeFieldInfoPtr_EndsAt)) = value;
			}
		}

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_WaitTime;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_TotalTime;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_StartedAt;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_EndsAt;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

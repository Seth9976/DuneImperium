using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000034 RID: 52
	public class ClearSimultaneousTimer : GameMessage
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x0000A4C0 File Offset: 0x000086C0
		// Note: this type is marked as 'beforefieldinit'.
		static ClearSimultaneousTimer()
		{
			Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "ClearSimultaneousTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr);
			ClearSimultaneousTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr, "TimerID");
			ClearSimultaneousTimer.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr, "AccountID");
			ClearSimultaneousTimer.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr, "Counter");
			ClearSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr, 100663383);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000A540 File Offset: 0x00008740
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearSimultaneousTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearSimultaneousTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00003289 File Offset: 0x00001489
		public ClearSimultaneousTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000A57C File Offset: 0x0000877C
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00003292 File Offset: 0x00001492
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000A5AC File Offset: 0x000087AC
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000032B1 File Offset: 0x000014B1
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000A5DC File Offset: 0x000087DC
		// (set) Token: 0x060001BC RID: 444 RVA: 0x000032D0 File Offset: 0x000014D0
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearSimultaneousTimer.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

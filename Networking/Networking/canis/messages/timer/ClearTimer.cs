using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000035 RID: 53
	public class ClearTimer : GameMessage
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0000A604 File Offset: 0x00008804
		// Note: this type is marked as 'beforefieldinit'.
		static ClearTimer()
		{
			Il2CppClassPointerStore<ClearTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "ClearTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearTimer>.NativeClassPtr);
			ClearTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTimer>.NativeClassPtr, "TimerID");
			ClearTimer.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTimer>.NativeClassPtr, "Counter");
			ClearTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTimer>.NativeClassPtr, 100663384);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A670 File Offset: 0x00008870
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000032EB File Offset: 0x000014EB
		public ClearTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000A6AC File Offset: 0x000088AC
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000032F4 File Offset: 0x000014F4
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000A6DC File Offset: 0x000088DC
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00003313 File Offset: 0x00001513
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTimer.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTimer.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

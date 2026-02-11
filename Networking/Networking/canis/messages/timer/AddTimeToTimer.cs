using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000033 RID: 51
	public class AddTimeToTimer : GameMessage
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0000A3C0 File Offset: 0x000085C0
		// Note: this type is marked as 'beforefieldinit'.
		static AddTimeToTimer()
		{
			Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "AddTimeToTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr);
			AddTimeToTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr, "TimerID");
			AddTimeToTimer.NativeFieldInfoPtr_AdditionalTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr, "AdditionalTimeSeconds");
			AddTimeToTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr, 100663382);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000A42C File Offset: 0x0000862C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTimeToTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00003246 File Offset: 0x00001446
		public AddTimeToTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000A468 File Offset: 0x00008668
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000324F File Offset: 0x0000144F
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000A498 File Offset: 0x00008698
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000326E File Offset: 0x0000146E
		public unsafe int AdditionalTimeSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimer.NativeFieldInfoPtr_AdditionalTimeSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToTimer.NativeFieldInfoPtr_AdditionalTimeSeconds)) = value;
			}
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalTimeSeconds;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

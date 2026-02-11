using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000032 RID: 50
	public class AddTimeToSimultaneousTimer : GameMessage
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// Note: this type is marked as 'beforefieldinit'.
		static AddTimeToSimultaneousTimer()
		{
			Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "AddTimeToSimultaneousTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr);
			AddTimeToSimultaneousTimer.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr, "TimerID");
			AddTimeToSimultaneousTimer.NativeFieldInfoPtr_AdditionalTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr, "AdditionalTimeSeconds");
			AddTimeToSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr, 100663381);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A32C File Offset: 0x0000852C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddTimeToSimultaneousTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddTimeToSimultaneousTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddTimeToSimultaneousTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003203 File Offset: 0x00001403
		public AddTimeToSimultaneousTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A368 File Offset: 0x00008568
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000320C File Offset: 0x0000140C
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimer.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimer.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000322B File Offset: 0x0000142B
		public unsafe int AdditionalTimeSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimer.NativeFieldInfoPtr_AdditionalTimeSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AddTimeToSimultaneousTimer.NativeFieldInfoPtr_AdditionalTimeSeconds)) = value;
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalTimeSeconds;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

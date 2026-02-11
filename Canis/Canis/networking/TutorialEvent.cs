using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.eventtriggers.clientactions;

namespace Canis.networking
{
	// Token: 0x02000068 RID: 104
	public class TutorialEvent : ClientAction
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x0002FC64 File Offset: 0x0002DE64
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialEvent()
		{
			Il2CppClassPointerStore<TutorialEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.networking", "TutorialEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialEvent>.NativeClassPtr);
			TutorialEvent.NativeFieldInfoPtr_tutorialActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialEvent>.NativeClassPtr, "tutorialActions");
			TutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialEvent>.NativeClassPtr, 100664469);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000474E File Offset: 0x0000294E
		public TutorialEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004757 File Offset: 0x00002957
		public unsafe List<MutableAttributes> tutorialActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEvent.NativeFieldInfoPtr_tutorialActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MutableAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialEvent.NativeFieldInfoPtr_tutorialActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_tutorialActions;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

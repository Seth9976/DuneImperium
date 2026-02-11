using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x0200009E RID: 158
	[Serializable]
	public class ActiveGameLog : Object
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x00038F74 File Offset: 0x00037174
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveGameLog()
		{
			Il2CppClassPointerStore<ActiveGameLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "ActiveGameLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveGameLog>.NativeClassPtr);
			ActiveGameLog.NativeFieldInfoPtr_ActiveBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveGameLog>.NativeClassPtr, "ActiveBuilder");
			ActiveGameLog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveGameLog>.NativeClassPtr, 100664883);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00038FCC File Offset: 0x000371CC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveGameLog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveGameLog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveGameLog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000505C File Offset: 0x0000325C
		public ActiveGameLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00039008 File Offset: 0x00037208
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x00005065 File Offset: 0x00003265
		public unsafe GameLogBuilder ActiveBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameLog.NativeFieldInfoPtr_ActiveBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveGameLog.NativeFieldInfoPtr_ActiveBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_ActiveBuilder;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

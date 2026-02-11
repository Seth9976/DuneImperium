using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using TMPro;

namespace boardgames.ui
{
	// Token: 0x0200011D RID: 285
	public class PileCountObserver : Observer
	{
		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003DE14 File Offset: 0x0003C014
		// Note: this type is marked as 'beforefieldinit'.
		static PileCountObserver()
		{
			Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.ui", "PileCountObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr);
			PileCountObserver.NativeFieldInfoPtr_numberField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr, "numberField");
			PileCountObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr, 100665404);
			PileCountObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr, 100665405);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003DE80 File Offset: 0x0003C080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996755, XrefRangeEnd = 996779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PileCountObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0003DEBC File Offset: 0x0003C0BC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PileCountObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PileCountObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PileCountObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00008EA1 File Offset: 0x000070A1
		public PileCountObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0003DEF8 File Offset: 0x0003C0F8
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00008EAA File Offset: 0x000070AA
		public unsafe TextMeshProUGUI numberField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountObserver.NativeFieldInfoPtr_numberField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PileCountObserver.NativeFieldInfoPtr_numberField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_numberField;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

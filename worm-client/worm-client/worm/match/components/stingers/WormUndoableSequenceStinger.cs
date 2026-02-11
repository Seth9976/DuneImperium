using System;
using Canis.attributes;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace worm.match.components.stingers
{
	// Token: 0x02000232 RID: 562
	public class WormUndoableSequenceStinger : WormSequenceStinger
	{
		// Token: 0x06001871 RID: 6257 RVA: 0x000624B8 File Offset: 0x000606B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormUndoableSequenceStinger()
		{
			Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components.stingers", "WormUndoableSequenceStinger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr);
			WormUndoableSequenceStinger.NativeFieldInfoPtr_undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr, "undo");
			WormUndoableSequenceStinger.NativeMethodInfoPtr_GetAnimation_Protected_Virtual_IEnumerator_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr, 100666676);
			WormUndoableSequenceStinger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr, 100666677);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00062524 File Offset: 0x00060724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718416, XrefRangeEnd = 718432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator GetAnimation(IHasAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUndoableSequenceStinger.NativeMethodInfoPtr_GetAnimation_Protected_Virtual_IEnumerator_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00062580 File Offset: 0x00060780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 718432, XrefRangeEnd = 718433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUndoableSequenceStinger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUndoableSequenceStinger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUndoableSequenceStinger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public WormUndoableSequenceStinger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x000625BC File Offset: 0x000607BC
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000E7B9 File Offset: 0x0000C9B9
		public unsafe TriggeredBlockingAnimation undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoableSequenceStinger.NativeFieldInfoPtr_undo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormUndoableSequenceStinger.NativeFieldInfoPtr_undo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_undo;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimation_Protected_Virtual_IEnumerator_IHasAttributes_0;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

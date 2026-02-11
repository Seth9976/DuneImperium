using System;
using dwd.core.match.sequence;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace lotus.match.delorean
{
	// Token: 0x020000E9 RID: 233
	public class DeloreanRules : Object
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x000354CC File Offset: 0x000336CC
		// Note: this type is marked as 'beforefieldinit'.
		static DeloreanRules()
		{
			Il2CppClassPointerStore<DeloreanRules>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.match.delorean", "DeloreanRules");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeloreanRules>.NativeClassPtr);
			DeloreanRules.NativeMethodInfoPtr_dwd_core_match_delorean_ISequenceBlockage_IsBlocker_Private_Virtual_Final_New_Boolean_SequenceElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanRules>.NativeClassPtr, 100665112);
			DeloreanRules.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeloreanRules>.NativeClassPtr, 100665113);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00035524 File Offset: 0x00033724
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool dwd_core_match_delorean_ISequenceBlockage_IsBlocker(SequenceElement sequence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sequence);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanRules.NativeMethodInfoPtr_dwd_core_match_delorean_ISequenceBlockage_IsBlocker_Private_Virtual_Final_New_Boolean_SequenceElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00035574 File Offset: 0x00033774
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeloreanRules()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeloreanRules>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeloreanRules.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000072B0 File Offset: 0x000054B0
		public DeloreanRules(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_match_delorean_ISequenceBlockage_IsBlocker_Private_Virtual_Final_New_Boolean_SequenceElement_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using DG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000D4 RID: 212
	public class FXFollow : MonoBehaviour
	{
		// Token: 0x06000AAC RID: 2732 RVA: 0x000331E0 File Offset: 0x000313E0
		// Note: this type is marked as 'beforefieldinit'.
		static FXFollow()
		{
			Il2CppClassPointerStore<FXFollow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "FXFollow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXFollow>.NativeClassPtr);
			FXFollow.NativeFieldInfoPtr_easing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXFollow>.NativeClassPtr, "easing");
			FXFollow.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXFollow>.NativeClassPtr, "duration");
			FXFollow.NativeFieldInfoPtr_transitionOutOnArrival = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXFollow>.NativeClassPtr, "transitionOutOnArrival");
			FXFollow.NativeMethodInfoPtr_Init_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXFollow>.NativeClassPtr, 100665027);
			FXFollow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXFollow>.NativeClassPtr, 100665028);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00033274 File Offset: 0x00031474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994170, XrefRangeEnd = 994191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Transform destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXFollow.NativeMethodInfoPtr_Init_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000332B8 File Offset: 0x000314B8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXFollow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXFollow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXFollow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00006E56 File Offset: 0x00005056
		public FXFollow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x000332F4 File Offset: 0x000314F4
		// (set) Token: 0x06000AB1 RID: 2737 RVA: 0x00006E5F File Offset: 0x0000505F
		public unsafe Ease easing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_easing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_easing)) = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0003331C File Offset: 0x0003151C
		// (set) Token: 0x06000AB3 RID: 2739 RVA: 0x00006E7A File Offset: 0x0000507A
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00033344 File Offset: 0x00031544
		// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x00006E95 File Offset: 0x00005095
		public unsafe bool transitionOutOnArrival
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_transitionOutOnArrival);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXFollow.NativeFieldInfoPtr_transitionOutOnArrival)) = value;
			}
		}

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeFieldInfoPtr_easing;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeFieldInfoPtr_transitionOutOnArrival;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Transform_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022B RID: 555
	public class VisualElementFocusChangeDirection : FocusChangeDirection
	{
		// Token: 0x0600293E RID: 10558 RVA: 0x000B47A4 File Offset: 0x000B29A4
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementFocusChangeDirection()
		{
			Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementFocusChangeDirection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr);
			VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, "s_Left");
			VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, "s_Right");
			VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100669491);
			VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100669492);
			VisualElementFocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100669493);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x000B4838 File Offset: 0x000B2A38
		public unsafe static FocusChangeDirection left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346361, XrefRangeEnd = 346365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000B486C File Offset: 0x000B2A6C
		public unsafe static FocusChangeDirection right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346365, XrefRangeEnd = 346369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x000B48A0 File Offset: 0x000B2AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346369, XrefRangeEnd = 346373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementFocusChangeDirection(int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00010A46 File Offset: 0x0000EC46
		public VisualElementFocusChangeDirection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000B48E8 File Offset: 0x000B2AE8
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x00010A4F File Offset: 0x0000EC4F
		public unsafe static VisualElementFocusChangeDirection s_Left
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x000B4910 File Offset: 0x000B2B10
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00010A61 File Offset: 0x0000EC61
		public unsafe static VisualElementFocusChangeDirection s_Right
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x000B4938 File Offset: 0x000B2B38
		public new static VisualElementFocusChangeDirection lastValue
		{
			get
			{
				return VisualElementFocusChangeDirection.s_Right;
			}
		}

		// Token: 0x04001D65 RID: 7525
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04001D66 RID: 7526
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04001D67 RID: 7527
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x04001D68 RID: 7528
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;
	}
}

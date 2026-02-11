using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus.src.ui
{
	// Token: 0x020000EB RID: 235
	public class AutoFocus : MonoBehaviour
	{
		// Token: 0x06000B60 RID: 2912 RVA: 0x00035678 File Offset: 0x00033878
		// Note: this type is marked as 'beforefieldinit'.
		static AutoFocus()
		{
			Il2CppClassPointerStore<AutoFocus>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.ui", "AutoFocus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoFocus>.NativeClassPtr);
			AutoFocus.NativeFieldInfoPtr_onMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoFocus>.NativeClassPtr, "onMobile");
			AutoFocus.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoFocus>.NativeClassPtr, 100665116);
			AutoFocus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoFocus>.NativeClassPtr, 100665117);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x000356E4 File Offset: 0x000338E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994672, XrefRangeEnd = 994680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoFocus.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00035718 File Offset: 0x00033918
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoFocus()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoFocus>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoFocus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x000072C2 File Offset: 0x000054C2
		public AutoFocus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00035754 File Offset: 0x00033954
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x000072CB File Offset: 0x000054CB
		public unsafe bool onMobile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoFocus.NativeFieldInfoPtr_onMobile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoFocus.NativeFieldInfoPtr_onMobile)) = value;
			}
		}

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr_onMobile;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo.kabbage;

namespace boardgames.kabbage
{
	// Token: 0x02000093 RID: 147
	public class HideVFXKabbage : MonoBehaviour
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0002659C File Offset: 0x0002479C
		// Note: this type is marked as 'beforefieldinit'.
		static HideVFXKabbage()
		{
			Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.kabbage", "HideVFXKabbage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr);
			HideVFXKabbage.NativeFieldInfoPtr_Hide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, "Hide");
			HideVFXKabbage.NativeFieldInfoPtr_kabbage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, "kabbage");
			HideVFXKabbage.NativeFieldInfoPtr_renderAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, "renderAnimator");
			HideVFXKabbage.NativeMethodInfoPtr_Setup_Public_Void_RunVFXKabbage_VoodooRenderAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, 100664555);
			HideVFXKabbage.NativeMethodInfoPtr_PlayHideAnimation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, 100664556);
			HideVFXKabbage.NativeMethodInfoPtr_Event_HideComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, 100664557);
			HideVFXKabbage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr, 100664558);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00026658 File Offset: 0x00024858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116587, XrefRangeEnd = 1116594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(RunVFXKabbage kabbage, VoodooRenderAnimator renderAnimator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(kabbage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderAnimator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVFXKabbage.NativeMethodInfoPtr_Setup_Public_Void_RunVFXKabbage_VoodooRenderAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000266AC File Offset: 0x000248AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1116610, RefRangeEnd = 1116611, XrefRangeStart = 1116594, XrefRangeEnd = 1116610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PlayHideAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVFXKabbage.NativeMethodInfoPtr_PlayHideAnimation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000266E8 File Offset: 0x000248E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116611, XrefRangeEnd = 1116613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HideComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVFXKabbage.NativeMethodInfoPtr_Event_HideComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0002671C File Offset: 0x0002491C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideVFXKabbage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideVFXKabbage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVFXKabbage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000063E7 File Offset: 0x000045E7
		public HideVFXKabbage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00026758 File Offset: 0x00024958
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000063F0 File Offset: 0x000045F0
		public unsafe static int Hide
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HideVFXKabbage.NativeFieldInfoPtr_Hide, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HideVFXKabbage.NativeFieldInfoPtr_Hide, (void*)(&value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00026774 File Offset: 0x00024974
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x000063FE File Offset: 0x000045FE
		public unsafe RunVFXKabbage kabbage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVFXKabbage.NativeFieldInfoPtr_kabbage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunVFXKabbage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVFXKabbage.NativeFieldInfoPtr_kabbage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000267A4 File Offset: 0x000249A4
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000641D File Offset: 0x0000461D
		public unsafe VoodooRenderAnimator renderAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVFXKabbage.NativeFieldInfoPtr_renderAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoodooRenderAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVFXKabbage.NativeFieldInfoPtr_renderAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_Hide;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_kabbage;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_renderAnimator;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_RunVFXKabbage_VoodooRenderAnimator_0;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeMethodInfoPtr_PlayHideAnimation_Public_Boolean_0;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_Event_HideComplete_Public_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

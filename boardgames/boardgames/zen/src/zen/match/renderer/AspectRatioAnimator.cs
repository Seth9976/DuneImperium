using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.zen.match.renderer
{
	// Token: 0x02000049 RID: 73
	public class AspectRatioAnimator : MonoBehaviour
	{
		// Token: 0x060002DF RID: 735 RVA: 0x0001A618 File Offset: 0x00018818
		// Note: this type is marked as 'beforefieldinit'.
		static AspectRatioAnimator()
		{
			Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.zen.match.renderer", "AspectRatioAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr);
			AspectRatioAnimator.NativeFieldInfoPtr_AspectRatioParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, "AspectRatioParam");
			AspectRatioAnimator.NativeFieldInfoPtr_lastSeenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, "lastSeenWidth");
			AspectRatioAnimator.NativeFieldInfoPtr_lastSeenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, "lastSeenHeight");
			AspectRatioAnimator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, "animator");
			AspectRatioAnimator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, 100663807);
			AspectRatioAnimator.NativeMethodInfoPtr_updateAnimator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, 100663808);
			AspectRatioAnimator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, 100663809);
			AspectRatioAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr, 100663810);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001A6E8 File Offset: 0x000188E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985466, XrefRangeEnd = 985471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioAnimator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001A71C File Offset: 0x0001891C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 985479, RefRangeEnd = 985481, XrefRangeStart = 985471, XrefRangeEnd = 985479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateAnimator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioAnimator.NativeMethodInfoPtr_updateAnimator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001A750 File Offset: 0x00018950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985481, XrefRangeEnd = 985484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioAnimator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001A784 File Offset: 0x00018984
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AspectRatioAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AspectRatioAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AspectRatioAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000033B3 File Offset: 0x000015B3
		public AspectRatioAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0001A7C0 File Offset: 0x000189C0
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x000033BC File Offset: 0x000015BC
		public unsafe static int AspectRatioParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(AspectRatioAnimator.NativeFieldInfoPtr_AspectRatioParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AspectRatioAnimator.NativeFieldInfoPtr_AspectRatioParam, (void*)(&value));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0001A7DC File Offset: 0x000189DC
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x000033CA File Offset: 0x000015CA
		public unsafe int lastSeenWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_lastSeenWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_lastSeenWidth)) = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x0001A804 File Offset: 0x00018A04
		// (set) Token: 0x060002EA RID: 746 RVA: 0x000033E5 File Offset: 0x000015E5
		public unsafe int lastSeenHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_lastSeenHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_lastSeenHeight)) = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0001A82C File Offset: 0x00018A2C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00003400 File Offset: 0x00001600
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AspectRatioAnimator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeFieldInfoPtr_AspectRatioParam;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_lastSeenWidth;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_lastSeenHeight;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_updateAnimator_Private_Void_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

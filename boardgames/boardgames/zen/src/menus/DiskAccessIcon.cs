using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.menus
{
	// Token: 0x02000059 RID: 89
	public class DiskAccessIcon : MonoBehaviour
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x0001EC60 File Offset: 0x0001CE60
		// Note: this type is marked as 'beforefieldinit'.
		static DiskAccessIcon()
		{
			Il2CppClassPointerStore<DiskAccessIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "DiskAccessIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiskAccessIcon>.NativeClassPtr);
			DiskAccessIcon.NativeFieldInfoPtr_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiskAccessIcon>.NativeClassPtr, "Animator");
			DiskAccessIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiskAccessIcon>.NativeClassPtr, 100663941);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001ECB8 File Offset: 0x0001CEB8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiskAccessIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiskAccessIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiskAccessIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000421D File Offset: 0x0000241D
		public DiskAccessIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00004226 File Offset: 0x00002426
		public unsafe Animator Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiskAccessIcon.NativeFieldInfoPtr_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiskAccessIcon.NativeFieldInfoPtr_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_Animator;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

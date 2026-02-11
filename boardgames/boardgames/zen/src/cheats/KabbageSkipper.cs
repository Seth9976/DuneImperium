using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace zen.src.cheats
{
	// Token: 0x02000080 RID: 128
	public class KabbageSkipper : MonoBehaviour
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x00024F28 File Offset: 0x00023128
		// Note: this type is marked as 'beforefieldinit'.
		static KabbageSkipper()
		{
			Il2CppClassPointerStore<KabbageSkipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.cheats", "KabbageSkipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KabbageSkipper>.NativeClassPtr);
			KabbageSkipper.NativeFieldInfoPtr_SkipKabbages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KabbageSkipper>.NativeClassPtr, "SkipKabbages");
			KabbageSkipper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KabbageSkipper>.NativeClassPtr, 100664319);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00024F80 File Offset: 0x00023180
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KabbageSkipper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KabbageSkipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KabbageSkipper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00004F01 File Offset: 0x00003101
		public KabbageSkipper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00024FBC File Offset: 0x000231BC
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00004F0A File Offset: 0x0000310A
		public unsafe bool SkipKabbages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageSkipper.NativeFieldInfoPtr_SkipKabbages);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KabbageSkipper.NativeFieldInfoPtr_SkipKabbages)) = value;
			}
		}

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_SkipKabbages;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

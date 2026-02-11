using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace voodoo.kabbage
{
	// Token: 0x0200002B RID: 43
	public class VoodooStaticPath : MonoBehaviour
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000E5DC File Offset: 0x0000C7DC
		// Note: this type is marked as 'beforefieldinit'.
		static VoodooStaticPath()
		{
			Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo.kabbage", "VoodooStaticPath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr);
			VoodooStaticPath.NativeFieldInfoPtr_animationEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr, "animationEndPoint");
			VoodooStaticPath.NativeMethodInfoPtr_get_AnimationEndPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr, 100663488);
			VoodooStaticPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr, 100663489);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000E648 File Offset: 0x0000C848
		public unsafe Vector3 AnimationEndPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooStaticPath.NativeMethodInfoPtr_get_AnimationEndPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E684 File Offset: 0x0000C884
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoodooStaticPath()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoodooStaticPath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VoodooStaticPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002F1F File Offset: 0x0000111F
		public VoodooStaticPath(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000E6C0 File Offset: 0x0000C8C0
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002F28 File Offset: 0x00001128
		public unsafe Vector3 animationEndPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooStaticPath.NativeFieldInfoPtr_animationEndPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VoodooStaticPath.NativeFieldInfoPtr_animationEndPoint)) = value;
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_animationEndPoint;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_AnimationEndPoint_Public_get_Vector3_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

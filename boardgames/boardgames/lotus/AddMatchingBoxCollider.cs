using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000C9 RID: 201
	public class AddMatchingBoxCollider : MonoBehaviour
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00030958 File Offset: 0x0002EB58
		// Note: this type is marked as 'beforefieldinit'.
		static AddMatchingBoxCollider()
		{
			Il2CppClassPointerStore<AddMatchingBoxCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "AddMatchingBoxCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddMatchingBoxCollider>.NativeClassPtr);
			AddMatchingBoxCollider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddMatchingBoxCollider>.NativeClassPtr, 100664907);
			AddMatchingBoxCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddMatchingBoxCollider>.NativeClassPtr, 100664908);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000309B0 File Offset: 0x0002EBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993361, XrefRangeEnd = 993369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddMatchingBoxCollider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000309E4 File Offset: 0x0002EBE4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AddMatchingBoxCollider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddMatchingBoxCollider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AddMatchingBoxCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00006780 File Offset: 0x00004980
		public AddMatchingBoxCollider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

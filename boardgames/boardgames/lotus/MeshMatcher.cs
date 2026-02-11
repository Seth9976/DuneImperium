using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000CA RID: 202
	public class MeshMatcher : MonoBehaviour
	{
		// Token: 0x060009DF RID: 2527 RVA: 0x00030A20 File Offset: 0x0002EC20
		// Note: this type is marked as 'beforefieldinit'.
		static MeshMatcher()
		{
			Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "MeshMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr);
			MeshMatcher.NativeFieldInfoPtr_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr, "meshFilter");
			MeshMatcher.NativeFieldInfoPtr_meshCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr, "meshCollider");
			MeshMatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr, 100664909);
			MeshMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr, 100664910);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00030AA0 File Offset: 0x0002ECA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993369, XrefRangeEnd = 993387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshMatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeshMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00006789 File Offset: 0x00004989
		public MeshMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00030B10 File Offset: 0x0002ED10
		// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00006792 File Offset: 0x00004992
		public unsafe MeshFilter meshFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshMatcher.NativeFieldInfoPtr_meshFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshMatcher.NativeFieldInfoPtr_meshFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00030B40 File Offset: 0x0002ED40
		// (set) Token: 0x060009E6 RID: 2534 RVA: 0x000067B1 File Offset: 0x000049B1
		public unsafe MeshCollider meshCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshMatcher.NativeFieldInfoPtr_meshCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshMatcher.NativeFieldInfoPtr_meshCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_meshFilter;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_meshCollider;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

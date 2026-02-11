using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000271 RID: 625
	public class VectorImageRenderInfo : LinkedPoolItem<VectorImageRenderInfo>
	{
		// Token: 0x06002E4D RID: 11853 RVA: 0x000C5410 File Offset: 0x000C3610
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImageRenderInfo()
		{
			Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "VectorImageRenderInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr);
			VectorImageRenderInfo.NativeFieldInfoPtr_useCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr, "useCount");
			VectorImageRenderInfo.NativeFieldInfoPtr_firstGradientRemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr, "firstGradientRemap");
			VectorImageRenderInfo.NativeFieldInfoPtr_gradientSettingsAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr, "gradientSettingsAlloc");
			VectorImageRenderInfo.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr, 100670034);
			VectorImageRenderInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr, 100670035);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x000C54A4 File Offset: 0x000C36A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352038, XrefRangeEnd = 352039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfo.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x000C54D8 File Offset: 0x000C36D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352039, XrefRangeEnd = 352042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImageRenderInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImageRenderInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00013127 File Offset: 0x00011327
		public VectorImageRenderInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x000C5514 File Offset: 0x000C3714
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00013130 File Offset: 0x00011330
		public unsafe int useCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_useCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_useCount)) = value;
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000C553C File Offset: 0x000C373C
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x0001314B File Offset: 0x0001134B
		public unsafe GradientRemap firstGradientRemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_firstGradientRemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientRemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_firstGradientRemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000C556C File Offset: 0x000C376C
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0001316A File Offset: 0x0001136A
		public Alloc gradientSettingsAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_gradientSettingsAlloc);
				return new Alloc(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Alloc>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VectorImageRenderInfo.NativeFieldInfoPtr_gradientSettingsAlloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Alloc>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400214D RID: 8525
		private static readonly IntPtr NativeFieldInfoPtr_useCount;

		// Token: 0x0400214E RID: 8526
		private static readonly IntPtr NativeFieldInfoPtr_firstGradientRemap;

		// Token: 0x0400214F RID: 8527
		private static readonly IntPtr NativeFieldInfoPtr_gradientSettingsAlloc;

		// Token: 0x04002150 RID: 8528
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002151 RID: 8529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

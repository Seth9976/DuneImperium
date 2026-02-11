using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000273 RID: 627
	public class GradientRemap : LinkedPoolItem<GradientRemap>
	{
		// Token: 0x06002E5A RID: 11866 RVA: 0x000C55D8 File Offset: 0x000C37D8
		// Note: this type is marked as 'beforefieldinit'.
		static GradientRemap()
		{
			Il2CppClassPointerStore<GradientRemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GradientRemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr);
			GradientRemap.NativeFieldInfoPtr_origIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, "origIndex");
			GradientRemap.NativeFieldInfoPtr_destIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, "destIndex");
			GradientRemap.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, "location");
			GradientRemap.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, "next");
			GradientRemap.NativeFieldInfoPtr_atlas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, "atlas");
			GradientRemap.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, 100670041);
			GradientRemap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr, 100670042);
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000C5694 File Offset: 0x000C3894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352084, XrefRangeEnd = 352088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemap.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000C56C8 File Offset: 0x000C38C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352088, XrefRangeEnd = 352091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientRemap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientRemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000131DA File Offset: 0x000113DA
		public GradientRemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000C5704 File Offset: 0x000C3904
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x000131E3 File Offset: 0x000113E3
		public unsafe int origIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_origIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_origIndex)) = value;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x000C572C File Offset: 0x000C392C
		// (set) Token: 0x06002E61 RID: 11873 RVA: 0x000131FE File Offset: 0x000113FE
		public unsafe int destIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_destIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_destIndex)) = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x000C5754 File Offset: 0x000C3954
		// (set) Token: 0x06002E63 RID: 11875 RVA: 0x00013219 File Offset: 0x00011419
		public unsafe RectInt location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_location);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_location)) = value;
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000C577C File Offset: 0x000C397C
		// (set) Token: 0x06002E65 RID: 11877 RVA: 0x00013234 File Offset: 0x00011434
		public unsafe GradientRemap next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientRemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000C57AC File Offset: 0x000C39AC
		// (set) Token: 0x06002E67 RID: 11879 RVA: 0x00013253 File Offset: 0x00011453
		public unsafe TextureId atlas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_atlas);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientRemap.NativeFieldInfoPtr_atlas)) = value;
			}
		}

		// Token: 0x04002153 RID: 8531
		private static readonly IntPtr NativeFieldInfoPtr_origIndex;

		// Token: 0x04002154 RID: 8532
		private static readonly IntPtr NativeFieldInfoPtr_destIndex;

		// Token: 0x04002155 RID: 8533
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x04002156 RID: 8534
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04002157 RID: 8535
		private static readonly IntPtr NativeFieldInfoPtr_atlas;

		// Token: 0x04002158 RID: 8536
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002159 RID: 8537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

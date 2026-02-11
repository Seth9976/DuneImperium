using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.platformdependent
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class PlatformDependentLayoutAdjustment : PlatformDependentAdjustment
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00004D6C File Offset: 0x00002F6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDependentLayoutAdjustment()
		{
			Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "dwd.core.platformdependent", "PlatformDependentLayoutAdjustment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr);
			PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr, "spacing");
			PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr, "padding");
			PlatformDependentLayoutAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr, 100663373);
			PlatformDependentLayoutAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_HorizontalOrVerticalLayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr, 100663374);
			PlatformDependentLayoutAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr, 100663375);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004E00 File Offset: 0x00003000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239114, XrefRangeEnd = 1239120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyAdjustment(GameObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDependentLayoutAdjustment.NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004E50 File Offset: 0x00003050
		[CallerCount(0)]
		public unsafe bool Approximately(HorizontalOrVerticalLayoutGroup layout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutAdjustment.NativeMethodInfoPtr_Approximately_Public_Boolean_HorizontalOrVerticalLayoutGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004EA0 File Offset: 0x000030A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDependentLayoutAdjustment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDependentLayoutAdjustment>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDependentLayoutAdjustment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000023C3 File Offset: 0x000005C3
		public PlatformDependentLayoutAdjustment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004EDC File Offset: 0x000030DC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000023CC File Offset: 0x000005CC
		public unsafe float spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004F04 File Offset: 0x00003104
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023E7 File Offset: 0x000005E7
		public unsafe RectOffset padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_padding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDependentLayoutAdjustment.NativeFieldInfoPtr_padding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_padding;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdjustment_Public_Virtual_Void_GameObject_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_HorizontalOrVerticalLayoutGroup_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

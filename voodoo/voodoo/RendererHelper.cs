using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace voodoo
{
	// Token: 0x02000019 RID: 25
	public class RendererHelper : NamedGroupHelper<Renderer>
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000B4D0 File Offset: 0x000096D0
		// Note: this type is marked as 'beforefieldinit'.
		static RendererHelper()
		{
			Il2CppClassPointerStore<RendererHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "RendererHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr);
			RendererHelper.NativeFieldInfoPtr_renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr, "renderers");
			RendererHelper.NativeMethodInfoPtr_initializeData_Protected_Virtual_Il2CppReferenceArray_1_NamedGroup_1_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr, 100663385);
			RendererHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr, 100663386);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B53C File Offset: 0x0000973C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<NamedGroup<Renderer>> initializeData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RendererHelper.NativeMethodInfoPtr_initializeData_Protected_Virtual_Il2CppReferenceArray_1_NamedGroup_1_Renderer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NamedGroup<Renderer>>>(intPtr3) : null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B588 File Offset: 0x00009788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106909, XrefRangeEnd = 1106912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RendererHelper()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000026E2 File Offset: 0x000008E2
		public RendererHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000B5C4 File Offset: 0x000097C4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000026EB File Offset: 0x000008EB
		public unsafe Il2CppReferenceArray<RendererHelper.RendererGroup> renderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererHelper.NativeFieldInfoPtr_renderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RendererHelper.RendererGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererHelper.NativeFieldInfoPtr_renderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_renderers;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_initializeData_Protected_Virtual_Il2CppReferenceArray_1_NamedGroup_1_Renderer_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000B5 RID: 181
		[Serializable]
		public class RendererGroup : NamedGroup<Renderer>
		{
			// Token: 0x06000A2C RID: 2604 RVA: 0x00006F62 File Offset: 0x00005162
			// Note: this type is marked as 'beforefieldinit'.
			static RendererGroup()
			{
				Il2CppClassPointerStore<RendererHelper.RendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RendererHelper>.NativeClassPtr, "RendererGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererHelper.RendererGroup>.NativeClassPtr);
				RendererHelper.RendererGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererHelper.RendererGroup>.NativeClassPtr, 100663387);
			}

			// Token: 0x06000A2D RID: 2605 RVA: 0x0002B13C File Offset: 0x0002933C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106906, XrefRangeEnd = 1106909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RendererGroup()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererHelper.RendererGroup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererHelper.RendererGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000A2E RID: 2606 RVA: 0x00006F96 File Offset: 0x00005196
			public RendererGroup(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000651 RID: 1617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

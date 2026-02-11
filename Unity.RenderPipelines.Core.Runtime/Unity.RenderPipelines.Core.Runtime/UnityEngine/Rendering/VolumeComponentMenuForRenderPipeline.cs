using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E9 RID: 233
	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
	{
		// Token: 0x060010B9 RID: 4281 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeComponentMenuForRenderPipeline()
		{
			Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "VolumeComponentMenuForRenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr);
			VolumeComponentMenuForRenderPipeline.NativeFieldInfoPtr__pipelineTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr, "<pipelineTypes>k__BackingField");
			VolumeComponentMenuForRenderPipeline.NativeMethodInfoPtr_get_pipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr, 100665763);
			VolumeComponentMenuForRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr, 100665764);
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0004CD5C File Offset: 0x0004AF5C
		public unsafe Il2CppReferenceArray<Type> pipelineTypes
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponentMenuForRenderPipeline.NativeMethodInfoPtr_get_pipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978041, XrefRangeEnd = 978070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeComponentMenuForRenderPipeline(string menu, [Optional] Il2CppReferenceArray<Type> pipelineTypes)
		{
			if (pipelineTypes == null)
			{
				pipelineTypes = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeComponentMenuForRenderPipeline>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(menu);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pipelineTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeComponentMenuForRenderPipeline.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00008CEF File Offset: 0x00006EEF
		public VolumeComponentMenuForRenderPipeline(string menu, params Type[] pipelineTypes)
			: this(menu, new Il2CppReferenceArray<Type>(pipelineTypes))
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00008CFE File Offset: 0x00006EFE
		public VolumeComponentMenuForRenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0004CE08 File Offset: 0x0004B008
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00008D07 File Offset: 0x00006F07
		public unsafe Il2CppReferenceArray<Type> _pipelineTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponentMenuForRenderPipeline.NativeFieldInfoPtr__pipelineTypes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeComponentMenuForRenderPipeline.NativeFieldInfoPtr__pipelineTypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeFieldInfoPtr__pipelineTypes_k__BackingField;

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr_get_pipelineTypes_Public_get_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;
	}
}

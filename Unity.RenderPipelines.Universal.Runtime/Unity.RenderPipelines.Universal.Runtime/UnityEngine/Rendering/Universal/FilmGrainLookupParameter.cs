using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000098 RID: 152
	[Serializable]
	public sealed class FilmGrainLookupParameter : VolumeParameter<FilmGrainLookup>
	{
		// Token: 0x06000D02 RID: 3330 RVA: 0x0000802E File Offset: 0x0000622E
		// Note: this type is marked as 'beforefieldinit'.
		static FilmGrainLookupParameter()
		{
			Il2CppClassPointerStore<FilmGrainLookupParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "FilmGrainLookupParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilmGrainLookupParameter>.NativeClassPtr);
			FilmGrainLookupParameter.NativeMethodInfoPtr__ctor_Public_Void_FilmGrainLookup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrainLookupParameter>.NativeClassPtr, 100665024);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00042D40 File Offset: 0x00040F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 612157, XrefRangeEnd = 612160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilmGrainLookupParameter(FilmGrainLookup value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilmGrainLookupParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilmGrainLookupParameter.NativeMethodInfoPtr__ctor_Public_Void_FilmGrainLookup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00008067 File Offset: 0x00006267
		public FilmGrainLookupParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FilmGrainLookup_Boolean_0;
	}
}

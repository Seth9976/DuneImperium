using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000082 RID: 130
	public class URPHelpURLAttribute : CoreRPHelpURLAttribute
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x00007581 File Offset: 0x00005781
		// Note: this type is marked as 'beforefieldinit'.
		static URPHelpURLAttribute()
		{
			Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "URPHelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr);
			URPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr, 100664875);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0003EECC File Offset: 0x0003D0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611085, XrefRangeEnd = 611088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe URPHelpURLAttribute(string pageName, string pageHash = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URPHelpURLAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageHash);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000075BA File Offset: 0x000057BA
		public URPHelpURLAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}

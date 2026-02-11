using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007F RID: 127
	public class CoreRPHelpURLAttribute : HelpURLAttribute
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x0002D790 File Offset: 0x0002B990
		// Note: this type is marked as 'beforefieldinit'.
		static CoreRPHelpURLAttribute()
		{
			Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "CoreRPHelpURLAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr);
			CoreRPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr, 100664645);
			CoreRPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr, 100664646);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0002D7E8 File Offset: 0x0002B9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965902, XrefRangeEnd = 965906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreRPHelpURLAttribute(string pageName, string packageName = "com.unity.render-pipelines.core")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreRPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002D848 File Offset: 0x0002BA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965908, RefRangeEnd = 965909, XrefRangeStart = 965906, XrefRangeEnd = 965908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreRPHelpURLAttribute(string pageName, string pageHash, string packageName = "com.unity.render-pipelines.core")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreRPHelpURLAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pageHash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreRPHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000055EF File Offset: 0x000037EF
		public CoreRPHelpURLAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}

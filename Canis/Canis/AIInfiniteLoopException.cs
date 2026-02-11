using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public class AIInfiniteLoopException : Exception
{
	// Token: 0x0600000F RID: 15 RVA: 0x00019FC4 File Offset: 0x000181C4
	// Note: this type is marked as 'beforefieldinit'.
	static AIInfiniteLoopException()
	{
		Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "AIInfiniteLoopException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr);
		AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr, 100663301);
		AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr, 100663302);
		AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr, 100663303);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0001A030 File Offset: 0x00018230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542945, XrefRangeEnd = 542949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIInfiniteLoopException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0001A06C File Offset: 0x0001826C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542949, XrefRangeEnd = 542953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIInfiniteLoopException(string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0001A0B8 File Offset: 0x000182B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542953, XrefRangeEnd = 542957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AIInfiniteLoopException(string message, Exception inner)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AIInfiniteLoopException>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AIInfiniteLoopException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020DE File Offset: 0x000002DE
	public AIInfiniteLoopException(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;
}

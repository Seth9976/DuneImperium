using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000052 RID: 82
public class MessageDeserializationException : Exception
{
	// Token: 0x06000642 RID: 1602 RVA: 0x0002D120 File Offset: 0x0002B320
	// Note: this type is marked as 'beforefieldinit'.
	static MessageDeserializationException()
	{
		Il2CppClassPointerStore<MessageDeserializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MessageDeserializationException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDeserializationException>.NativeClassPtr);
		MessageDeserializationException.NativeFieldInfoPtr_OriginalJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDeserializationException>.NativeClassPtr, "OriginalJSON");
		MessageDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDeserializationException>.NativeClassPtr, 100664255);
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x0002D178 File Offset: 0x0002B378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859521, XrefRangeEnd = 859526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MessageDeserializationException(string message, Dictionary<string, Object> json)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDeserializationException>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(json);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDeserializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x000040E0 File Offset: 0x000022E0
	public MessageDeserializationException(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000645 RID: 1605 RVA: 0x0002D1D8 File Offset: 0x0002B3D8
	// (set) Token: 0x06000646 RID: 1606 RVA: 0x000040E9 File Offset: 0x000022E9
	public unsafe Dictionary<string, Object> OriginalJSON
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDeserializationException.NativeFieldInfoPtr_OriginalJSON);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDeserializationException.NativeFieldInfoPtr_OriginalJSON), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004BD RID: 1213
	private static readonly IntPtr NativeFieldInfoPtr_OriginalJSON;

	// Token: 0x040004BE RID: 1214
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_String_Object_0;
}

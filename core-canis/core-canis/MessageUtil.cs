using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000053 RID: 83
public static class MessageUtil : Object
{
	// Token: 0x06000647 RID: 1607 RVA: 0x0002D208 File Offset: 0x0002B408
	// Note: this type is marked as 'beforefieldinit'.
	static MessageUtil()
	{
		Il2CppClassPointerStore<MessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MessageUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageUtil>.NativeClassPtr);
		MessageUtil.NativeFieldInfoPtr_DwdJsonMessageAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageUtil>.NativeClassPtr, "DwdJsonMessageAttributeType");
		MessageUtil.NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageUtil>.NativeClassPtr, 100664256);
		MessageUtil.NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageUtil>.NativeClassPtr, 100664257);
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x0002D274 File Offset: 0x0002B474
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859526, XrefRangeEnd = 859530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MessageNameFromType(this Type messageType)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageUtil.NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859530, XrefRangeEnd = 859538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string MessageName(this Object message)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageUtil.NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x00004108 File Offset: 0x00002308
	public MessageUtil(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x0600064B RID: 1611 RVA: 0x0002D2EC File Offset: 0x0002B4EC
	// (set) Token: 0x0600064C RID: 1612 RVA: 0x00004111 File Offset: 0x00002311
	public unsafe static Type DwdJsonMessageAttributeType
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(MessageUtil.NativeFieldInfoPtr_DwdJsonMessageAttributeType, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(MessageUtil.NativeFieldInfoPtr_DwdJsonMessageAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004BF RID: 1215
	private static readonly IntPtr NativeFieldInfoPtr_DwdJsonMessageAttributeType;

	// Token: 0x040004C0 RID: 1216
	private static readonly IntPtr NativeMethodInfoPtr_MessageNameFromType_Public_Static_String_Type_0;

	// Token: 0x040004C1 RID: 1217
	private static readonly IntPtr NativeMethodInfoPtr_MessageName_Public_Static_String_Object_0;
}

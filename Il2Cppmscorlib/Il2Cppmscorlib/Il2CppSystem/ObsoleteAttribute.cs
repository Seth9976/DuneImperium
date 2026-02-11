using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D2 RID: 210
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		// Token: 0x06000DAF RID: 3503 RVA: 0x000660DC File Offset: 0x000642DC
		// Note: this type is marked as 'beforefieldinit'.
		static ObsoleteAttribute()
		{
			Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ObsoleteAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr);
			ObsoleteAttribute.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_message");
			ObsoleteAttribute.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_error");
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665709);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665710);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665711);
			ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665712);
			ObsoleteAttribute.NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665713);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00066198 File Offset: 0x00064398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318174, XrefRangeEnd = 1318176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000661D4 File Offset: 0x000643D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318176, XrefRangeEnd = 1318178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00066220 File Offset: 0x00064420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute(string message, bool error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0006627C File Offset: 0x0006447C
		public unsafe string Message
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x000662B4 File Offset: 0x000644B4
		public unsafe bool IsError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0000545E File Offset: 0x0000365E
		public ObsoleteAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000662F0 File Offset: 0x000644F0
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00005467 File Offset: 0x00003667
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00066318 File Offset: 0x00064518
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00005486 File Offset: 0x00003686
		public unsafe bool _error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error)) = value;
			}
		}

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr__error;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0;
	}
}

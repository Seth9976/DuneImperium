using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class CheckoutException : ExternalException
	{
		// Token: 0x06001467 RID: 5223 RVA: 0x0006B440 File Offset: 0x00069640
		// Note: this type is marked as 'beforefieldinit'.
		static CheckoutException()
		{
			Il2CppClassPointerStore<CheckoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "CheckoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr);
			CheckoutException.NativeFieldInfoPtr_Canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr, "Canceled");
			CheckoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr, 100666343);
			CheckoutException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr, 100666344);
			CheckoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr, 100666345);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466002, XrefRangeEnd = 466003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0006B4FC File Offset: 0x000696FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466003, XrefRangeEnd = 466004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckoutException(string message, int errorCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckoutException.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0006B558 File Offset: 0x00069758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0000913C File Offset: 0x0000733C
		public CheckoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0006B5BC File Offset: 0x000697BC
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x00009145 File Offset: 0x00007345
		public unsafe static CheckoutException Canceled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CheckoutException.NativeFieldInfoPtr_Canceled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckoutException>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CheckoutException.NativeFieldInfoPtr_Canceled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_Canceled;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}

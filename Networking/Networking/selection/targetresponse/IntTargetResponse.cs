using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.targetresponse
{
	// Token: 0x02000062 RID: 98
	public class IntTargetResponse : TargetResponse
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		// Note: this type is marked as 'beforefieldinit'.
		static IntTargetResponse()
		{
			Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "IntTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr);
			IntTargetResponse.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, "Amount");
			IntTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, "name");
			IntTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, 100663463);
			IntTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, 100663464);
			IntTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, 100663465);
			IntTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, 100663466);
			IntTargetResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr, 100663467);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000E16C File Offset: 0x0000C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194059, XrefRangeEnd = 1194064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1194069, RefRangeEnd = 1194115, XrefRangeStart = 1194064, XrefRangeEnd = 1194069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntTargetResponse(int a)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntTargetResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194115, XrefRangeEnd = 1194117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000E248 File Offset: 0x0000C448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194117, XrefRangeEnd = 1194118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000E290 File Offset: 0x0000C490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194118, XrefRangeEnd = 1194124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntTargetResponse.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000410B File Offset: 0x0000230B
		public IntTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000E2D4 File Offset: 0x0000C4D4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00004114 File Offset: 0x00002314
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTargetResponse.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTargetResponse.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000412F File Offset: 0x0000232F
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}

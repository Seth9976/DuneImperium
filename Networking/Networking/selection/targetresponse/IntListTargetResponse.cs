using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Networking.selection.targetresponse
{
	// Token: 0x02000061 RID: 97
	public class IntListTargetResponse : TargetResponse
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000DE2C File Offset: 0x0000C02C
		// Note: this type is marked as 'beforefieldinit'.
		static IntListTargetResponse()
		{
			Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetresponse", "IntListTargetResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr);
			IntListTargetResponse.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, "Choices");
			IntListTargetResponse.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, "name");
			IntListTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, 100663458);
			IntListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, 100663459);
			IntListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, 100663460);
			IntListTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, 100663461);
			IntListTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr, 100663462);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193990, XrefRangeEnd = 1193995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntListTargetResponse()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntListTargetResponse.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000DF24 File Offset: 0x0000C124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1194013, RefRangeEnd = 1194014, XrefRangeStart = 1193995, XrefRangeEnd = 1194013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntListTargetResponse(int singleChoice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref singleChoice;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000DF6C File Offset: 0x0000C16C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1194020, RefRangeEnd = 1194034, XrefRangeStart = 1194014, XrefRangeEnd = 1194020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntListTargetResponse(List<int> choices)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntListTargetResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntListTargetResponse.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194034, XrefRangeEnd = 1194044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntListTargetResponse.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000E010 File Offset: 0x0000C210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194044, XrefRangeEnd = 1194059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntListTargetResponse.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000040C4 File Offset: 0x000022C4
		public IntListTargetResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000E058 File Offset: 0x0000C258
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000040CD File Offset: 0x000022CD
		public unsafe List<int> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntListTargetResponse.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntListTargetResponse.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0000E088 File Offset: 0x0000C288
		// (set) Token: 0x0600032C RID: 812 RVA: 0x000040EC File Offset: 0x000022EC
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntListTargetResponse.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntListTargetResponse.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C7 RID: 455
	[StructLayout(2)]
	public struct RTime32
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x000710F8 File Offset: 0x0006F2F8
		// Note: this type is marked as 'beforefieldinit'.
		static RTime32()
		{
			Il2CppClassPointerStore<RTime32>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RTime32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTime32>.NativeClassPtr);
			RTime32.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTime32>.NativeClassPtr, "Value");
			RTime32.NativeMethodInfoPtr_op_Implicit_Public_Static_RTime32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667494);
			RTime32.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667495);
			RTime32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667496);
			RTime32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667497);
			RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667498);
			RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667499);
			RTime32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667500);
			RTime32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667501);
			RTime32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTime32>.NativeClassPtr, 100667502);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000711F0 File Offset: 0x0006F3F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RTime32(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Implicit_Public_Static_RTime32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00071230 File Offset: 0x0006F430
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(RTime32 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RTime32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00071270 File Offset: 0x0006F470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0007129C File Offset: 0x0006F49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000712CC File Offset: 0x0006F4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951427, XrefRangeEnd = 951430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00071310 File Offset: 0x0006F510
		[CallerCount(0)]
		public unsafe bool Equals(RTime32 p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00071350 File Offset: 0x0006F550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RTime32 a, RTime32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0007139C File Offset: 0x0006F59C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RTime32 a, RTime32 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000713E8 File Offset: 0x0006F5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RTime32 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTime32.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00007BAB File Offset: 0x00005DAB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTime32>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RTime32_UInt32_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RTime32_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RTime32_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RTime32_RTime32_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RTime32_RTime32_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RTime32_0;

		// Token: 0x04001C7C RID: 7292
		[FieldOffset(0)]
		public uint Value;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D9 RID: 473
	[StructLayout(2)]
	public struct ScreenshotHandle
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x00074A58 File Offset: 0x00072C58
		// Note: this type is marked as 'beforefieldinit'.
		static ScreenshotHandle()
		{
			Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ScreenshotHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr);
			ScreenshotHandle.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, "Value");
			ScreenshotHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenshotHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667656);
			ScreenshotHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667657);
			ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667658);
			ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667659);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667660);
			ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667661);
			ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667662);
			ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667663);
			ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, 100667664);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00074B50 File Offset: 0x00072D50
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ScreenshotHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenshotHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x00074B90 File Offset: 0x00072D90
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(ScreenshotHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00074BD0 File Offset: 0x00072DD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00074BFC File Offset: 0x00072DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00074C2C File Offset: 0x00072E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951508, XrefRangeEnd = 951511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00074C70 File Offset: 0x00072E70
		[CallerCount(0)]
		public unsafe bool Equals(ScreenshotHandle p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00074CB0 File Offset: 0x00072EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ScreenshotHandle a, ScreenshotHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00074CFC File Offset: 0x00072EFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ScreenshotHandle a, ScreenshotHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00074D48 File Offset: 0x00072F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ScreenshotHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScreenshotHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00007CEF File Offset: 0x00005EEF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenshotHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScreenshotHandle_UInt32_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScreenshotHandle_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScreenshotHandle_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScreenshotHandle_ScreenshotHandle_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScreenshotHandle_0;

		// Token: 0x04001D42 RID: 7490
		[FieldOffset(0)]
		public uint Value;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001DA RID: 474
	[StructLayout(2)]
	public struct HTTPRequestHandle
	{
		// Token: 0x060017D3 RID: 6099 RVA: 0x00074D88 File Offset: 0x00072F88
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPRequestHandle()
		{
			Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTTPRequestHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr);
			HTTPRequestHandle.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, "Value");
			HTTPRequestHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPRequestHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667665);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667666);
			HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667667);
			HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667668);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667669);
			HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667670);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667671);
			HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667672);
			HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, 100667673);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00074E80 File Offset: 0x00073080
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HTTPRequestHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPRequestHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00074EC0 File Offset: 0x000730C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(HTTPRequestHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00074F00 File Offset: 0x00073100
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00074F2C File Offset: 0x0007312C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00074F5C File Offset: 0x0007315C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951511, XrefRangeEnd = 951514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00074FA0 File Offset: 0x000731A0
		[CallerCount(0)]
		public unsafe bool Equals(HTTPRequestHandle p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00074FE0 File Offset: 0x000731E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HTTPRequestHandle a, HTTPRequestHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0007502C File Offset: 0x0007322C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPRequestHandle a, HTTPRequestHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00075078 File Offset: 0x00073278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HTTPRequestHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPRequestHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00007D01 File Offset: 0x00005F01
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPRequestHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPRequestHandle_UInt32_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPRequestHandle_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D49 RID: 7497
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPRequestHandle_0;

		// Token: 0x04001D4A RID: 7498
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x04001D4B RID: 7499
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPRequestHandle_HTTPRequestHandle_0;

		// Token: 0x04001D4C RID: 7500
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPRequestHandle_0;

		// Token: 0x04001D4D RID: 7501
		[FieldOffset(0)]
		public uint Value;
	}
}

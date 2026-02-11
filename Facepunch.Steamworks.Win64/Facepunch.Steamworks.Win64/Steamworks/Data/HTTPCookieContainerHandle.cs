using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001DB RID: 475
	[StructLayout(2)]
	public struct HTTPCookieContainerHandle
	{
		// Token: 0x060017DE RID: 6110 RVA: 0x000750B8 File Offset: 0x000732B8
		// Note: this type is marked as 'beforefieldinit'.
		static HTTPCookieContainerHandle()
		{
			Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HTTPCookieContainerHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr);
			HTTPCookieContainerHandle.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, "Value");
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPCookieContainerHandle_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667674);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667675);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667676);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667677);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667678);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667679);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667680);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667681);
			HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, 100667682);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000751B0 File Offset: 0x000733B0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HTTPCookieContainerHandle(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPCookieContainerHandle_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000751F0 File Offset: 0x000733F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(HTTPCookieContainerHandle value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00075230 File Offset: 0x00073430
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0007525C File Offset: 0x0007345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0007528C File Offset: 0x0007348C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951514, XrefRangeEnd = 951517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000752D0 File Offset: 0x000734D0
		[CallerCount(0)]
		public unsafe bool Equals(HTTPCookieContainerHandle p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00075310 File Offset: 0x00073510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x0007535C File Offset: 0x0007355C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HTTPCookieContainerHandle a, HTTPCookieContainerHandle b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x000753A8 File Offset: 0x000735A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HTTPCookieContainerHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HTTPCookieContainerHandle.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00007D13 File Offset: 0x00005F13
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HTTPCookieContainerHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D4E RID: 7502
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D4F RID: 7503
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HTTPCookieContainerHandle_UInt32_0;

		// Token: 0x04001D50 RID: 7504
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_HTTPCookieContainerHandle_0;

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HTTPCookieContainerHandle_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HTTPCookieContainerHandle_HTTPCookieContainerHandle_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HTTPCookieContainerHandle_0;

		// Token: 0x04001D58 RID: 7512
		[FieldOffset(0)]
		public uint Value;
	}
}

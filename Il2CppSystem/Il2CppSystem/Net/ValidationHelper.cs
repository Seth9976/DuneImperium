using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020001B7 RID: 439
	public static class ValidationHelper : Object
	{
		// Token: 0x06001B10 RID: 6928 RVA: 0x00086254 File Offset: 0x00084454
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationHelper()
		{
			Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ValidationHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr);
			ValidationHelper.NativeFieldInfoPtr_EmptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "EmptyArray");
			ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidMethodChars");
			ValidationHelper.NativeFieldInfoPtr_InvalidParamChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidParamChars");
			ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100667490);
			ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100667491);
			ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100667492);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x000862FC File Offset: 0x000844FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 474522, RefRangeEnd = 474524, XrefRangeStart = 474522, XrefRangeEnd = 474522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeStringNull(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00086338 File Offset: 0x00084538
		[CallerCount(0)]
		public unsafe static bool IsBlankString(string stringValue)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0008637C File Offset: 0x0008457C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 471202, RefRangeEnd = 471205, XrefRangeStart = 471202, XrefRangeEnd = 471205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidateTcpPort(int port)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref port;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationHelper.NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0000B9E3 File Offset: 0x00009BE3
		public ValidationHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x000863BC File Offset: 0x000845BC
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000B9EC File Offset: 0x00009BEC
		public unsafe static Il2CppStringArray EmptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_EmptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x000863E4 File Offset: 0x000845E4
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000B9FE File Offset: 0x00009BFE
		public unsafe static Il2CppStructArray<char> InvalidMethodChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidMethodChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0008640C File Offset: 0x0008460C
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000BA10 File Offset: 0x00009C10
		public unsafe static Il2CppStructArray<char> InvalidParamChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValidationHelper.NativeFieldInfoPtr_InvalidParamChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400158E RID: 5518
		private static readonly IntPtr NativeFieldInfoPtr_EmptyArray;

		// Token: 0x0400158F RID: 5519
		private static readonly IntPtr NativeFieldInfoPtr_InvalidMethodChars;

		// Token: 0x04001590 RID: 5520
		private static readonly IntPtr NativeFieldInfoPtr_InvalidParamChars;

		// Token: 0x04001591 RID: 5521
		private static readonly IntPtr NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0;

		// Token: 0x04001592 RID: 5522
		private static readonly IntPtr NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0;

		// Token: 0x04001593 RID: 5523
		private static readonly IntPtr NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0;
	}
}

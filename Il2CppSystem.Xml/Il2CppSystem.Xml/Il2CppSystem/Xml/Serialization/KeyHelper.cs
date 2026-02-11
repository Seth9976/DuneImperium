using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000BE RID: 190
	public class KeyHelper : Object
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x0006822C File Offset: 0x0006642C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyHelper()
		{
			Il2CppClassPointerStore<KeyHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "KeyHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666355);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666356);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666357);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666358);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666359);
			KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyHelper>.NativeClassPtr, 100666360);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000682D4 File Offset: 0x000664D4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 383809, RefRangeEnd = 383844, XrefRangeStart = 383799, XrefRangeEnd = 383809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, string val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0006832C File Offset: 0x0006652C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 383854, RefRangeEnd = 383862, XrefRangeStart = 383844, XrefRangeEnd = 383854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, string val, string def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(val);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00068394 File Offset: 0x00066594
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 383864, RefRangeEnd = 383874, XrefRangeStart = 383862, XrefRangeEnd = 383864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, bool val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000683E8 File Offset: 0x000665E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383876, RefRangeEnd = 383878, XrefRangeStart = 383874, XrefRangeEnd = 383876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, bool val, bool def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref def;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00068448 File Offset: 0x00066648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 383886, RefRangeEnd = 383888, XrefRangeStart = 383878, XrefRangeEnd = 383886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, int val, int def)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref def;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000684A8 File Offset: 0x000666A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 383899, RefRangeEnd = 383906, XrefRangeStart = 383888, XrefRangeEnd = 383899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddField(StringBuilder sb, int n, Type val)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyHelper.NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00007ED9 File Offset: 0x000060D9
		public KeyHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_String_String_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Boolean_Boolean_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Int32_Int32_0;

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_Static_Void_StringBuilder_Int32_Type_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200034D RID: 845
	public static class IOUtil : Object
	{
		// Token: 0x060032A8 RID: 12968 RVA: 0x000FFDB8 File Offset: 0x000FDFB8
		// Note: this type is marked as 'beforefieldinit'.
		static IOUtil()
		{
			Il2CppClassPointerStore<IOUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "IOUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOUtil>.NativeClassPtr);
			IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671223);
			IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671224);
			IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOUtil>.NativeClassPtr, 100671225);
		}

		// Token: 0x060032A9 RID: 12969 RVA: 0x000FFE24 File Offset: 0x000FE024
		[CallerCount(0)]
		public unsafe static bool FlagTest(MessageEnum flag, MessageEnum target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032AA RID: 12970 RVA: 0x000FFE70 File Offset: 0x000FE070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387180, XrefRangeEnd = 1387181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStringWithCode(string value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000FFEB8 File Offset: 0x000FE0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387181, XrefRangeEnd = 1387192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWithCode(Type type, Object value, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOUtil.NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x0001190F File Offset: 0x0000FB0F
		public IOUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_FlagTest_Internal_Static_Boolean_MessageEnum_MessageEnum_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_WriteStringWithCode_Internal_Static_Void_String___BinaryWriter_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_WriteWithCode_Internal_Static_Void_Type_Object___BinaryWriter_0;
	}
}

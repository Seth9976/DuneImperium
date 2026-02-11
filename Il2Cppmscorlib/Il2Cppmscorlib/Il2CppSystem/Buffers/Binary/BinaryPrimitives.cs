using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Buffers.Binary
{
	// Token: 0x02000518 RID: 1304
	public static class BinaryPrimitives : Object
	{
		// Token: 0x06004FB5 RID: 20405 RVA: 0x00172E34 File Offset: 0x00171034
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryPrimitives()
		{
			Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers.Binary", "BinaryPrimitives");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr);
			BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100675322);
			BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100675323);
			BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryPrimitives>.NativeClassPtr, 100675324);
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00172EA0 File Offset: 0x001710A0
		[CallerCount(0)]
		public unsafe static int ReverseEndianness(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00172EE0 File Offset: 0x001710E0
		[CallerCount(0)]
		public unsafe static ushort ReverseEndianness(ushort value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00172F20 File Offset: 0x00171120
		[CallerCount(0)]
		public unsafe static uint ReverseEndianness(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryPrimitives.NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x0001C9BF File Offset: 0x0001ABBF
		public BinaryPrimitives(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040F2 RID: 16626
		private static readonly IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_Int32_Int32_0;

		// Token: 0x040040F3 RID: 16627
		private static readonly IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt16_UInt16_0;

		// Token: 0x040040F4 RID: 16628
		private static readonly IntPtr NativeMethodInfoPtr_ReverseEndianness_Public_Static_UInt32_UInt32_0;
	}
}

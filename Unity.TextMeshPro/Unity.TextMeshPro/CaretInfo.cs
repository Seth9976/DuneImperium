using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x02000070 RID: 112
	[StructLayout(2)]
	public struct CaretInfo
	{
		// Token: 0x06000E13 RID: 3603 RVA: 0x00039174 File Offset: 0x00037374
		// Note: this type is marked as 'beforefieldinit'.
		static CaretInfo()
		{
			Il2CppClassPointerStore<CaretInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "CaretInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr);
			CaretInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "index");
			CaretInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "position");
			CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, 100664857);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x000391E0 File Offset: 0x000373E0
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaretInfo(int index, CaretPosition position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00008A85 File Offset: 0x00006C85
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0;

		// Token: 0x04000B2D RID: 2861
		[FieldOffset(0)]
		public int index;

		// Token: 0x04000B2E RID: 2862
		[FieldOffset(4)]
		public CaretPosition position;
	}
}

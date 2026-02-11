using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000147 RID: 327
	[StructLayout(2)]
	public struct RangeInt
	{
		// Token: 0x06001905 RID: 6405 RVA: 0x00075B4C File Offset: 0x00073D4C
		// Note: this type is marked as 'beforefieldinit'.
		static RangeInt()
		{
			Il2CppClassPointerStore<RangeInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeInt>.NativeClassPtr);
			RangeInt.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "start");
			RangeInt.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "length");
			RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100666748);
			RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100666749);
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00075BCC File Offset: 0x00073DCC
		public unsafe int end
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 667011, RefRangeEnd = 667014, XrefRangeStart = 667011, XrefRangeEnd = 667011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00075BFC File Offset: 0x00073DFC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeInt(int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00009C21 File Offset: 0x00007E21
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, ref this));
		}

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Int32_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001653 RID: 5715
		[FieldOffset(0)]
		public int start;

		// Token: 0x04001654 RID: 5716
		[FieldOffset(4)]
		public int length;
	}
}

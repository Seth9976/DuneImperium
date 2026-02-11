using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013B RID: 315
	[StructLayout(2)]
	public struct TessEdgeCompare
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x0000F158 File Offset: 0x0000D358
		// Note: this type is marked as 'beforefieldinit'.
		static TessEdgeCompare()
		{
			Il2CppClassPointerStore<TessEdgeCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "TessEdgeCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessEdgeCompare>.NativeClassPtr);
			TessEdgeCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessEdgeCompare>.NativeClassPtr, 100666417);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0006F8CC File Offset: 0x0006DACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 629875, RefRangeEnd = 629878, XrefRangeStart = 629875, XrefRangeEnd = 629875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(int2 a, int2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessEdgeCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0000F191 File Offset: 0x0000D391
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TessEdgeCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int2_int2_0;
	}
}

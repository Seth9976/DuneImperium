using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess
{
	// Token: 0x0200013C RID: 316
	[StructLayout(2)]
	public struct TessCellCompare
	{
		// Token: 0x06001AA7 RID: 6823 RVA: 0x0000F1A3 File Offset: 0x0000D3A3
		// Note: this type is marked as 'beforefieldinit'.
		static TessCellCompare()
		{
			Il2CppClassPointerStore<TessCellCompare>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.UTess", "TessCellCompare");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TessCellCompare>.NativeClassPtr);
			TessCellCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int3_int3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TessCellCompare>.NativeClassPtr, 100666418);
		}

		// Token: 0x06001AA8 RID: 6824 RVA: 0x0006F918 File Offset: 0x0006DB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 629878, RefRangeEnd = 629879, XrefRangeStart = 629878, XrefRangeEnd = 629878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(int3 a, int3 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TessCellCompare.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int3_int3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TessCellCompare>.NativeClassPtr, ref this));
		}

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_int3_int3_0;
	}
}

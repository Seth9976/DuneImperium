using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct DoublePoint
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00017420 File Offset: 0x00015620
		// Note: this type is marked as 'beforefieldinit'.
		static DoublePoint()
		{
			Il2CppClassPointerStore<DoublePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DoublePoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr);
			DoublePoint.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, "X");
			DoublePoint.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, "Y");
			DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, 100663384);
			DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, 100663385);
			DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, 100663386);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000174B4 File Offset: 0x000156B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 596903, RefRangeEnd = 596910, XrefRangeStart = 596903, XrefRangeEnd = 596903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoublePoint(double x = 0.0, double y = 0.0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000174F4 File Offset: 0x000156F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596910, RefRangeEnd = 596911, XrefRangeStart = 596910, XrefRangeEnd = 596910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoublePoint(DoublePoint dp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00017528 File Offset: 0x00015728
		[CallerCount(0)]
		public unsafe DoublePoint(IntPoint ip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ip;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000247F File Offset: 0x0000067F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DoublePoint>.NativeClassPtr, ref this));
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0;

		// Token: 0x0400006E RID: 110
		[FieldOffset(0)]
		public double X;

		// Token: 0x0400006F RID: 111
		[FieldOffset(8)]
		public double Y;
	}
}

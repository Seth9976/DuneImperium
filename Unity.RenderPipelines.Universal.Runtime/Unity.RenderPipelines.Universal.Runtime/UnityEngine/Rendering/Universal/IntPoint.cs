using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct IntPoint
	{
		// Token: 0x060000CF RID: 207 RVA: 0x0001823C File Offset: 0x0001643C
		// Note: this type is marked as 'beforefieldinit'.
		static IntPoint()
		{
			Il2CppClassPointerStore<IntPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "IntPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntPoint>.NativeClassPtr);
			IntPoint.NativeFieldInfoPtr_N = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "N");
			IntPoint.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "X");
			IntPoint.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "Y");
			IntPoint.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "D");
			IntPoint.NativeFieldInfoPtr_NX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "NX");
			IntPoint.NativeFieldInfoPtr_NY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, "NY");
			IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663418);
			IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663419);
			IntPoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663420);
			IntPoint.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663421);
			IntPoint.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663422);
			IntPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663423);
			IntPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, 100663424);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00018370 File Offset: 0x00016570
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 597018, RefRangeEnd = 597038, XrefRangeStart = 597018, XrefRangeEnd = 597018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPoint(long X, long Y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref X;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000183B0 File Offset: 0x000165B0
		[CallerCount(0)]
		public unsafe IntPoint(double x, double y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000183F0 File Offset: 0x000165F0
		[CallerCount(0)]
		public unsafe IntPoint(IntPoint pt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00018424 File Offset: 0x00016624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597038, RefRangeEnd = 597039, XrefRangeStart = 597038, XrefRangeEnd = 597038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(IntPoint a, IntPoint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00018470 File Offset: 0x00016670
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 597039, RefRangeEnd = 597040, XrefRangeStart = 597039, XrefRangeEnd = 597039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(IntPoint a, IntPoint b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000184BC File Offset: 0x000166BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597040, XrefRangeEnd = 597043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00018500 File Offset: 0x00016700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597043, XrefRangeEnd = 597047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000259D File Offset: 0x0000079D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntPoint>.NativeClassPtr, ref this));
		}

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_N;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_D;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_NX;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_NY;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000A8 RID: 168
		[FieldOffset(0)]
		public long N;

		// Token: 0x040000A9 RID: 169
		[FieldOffset(8)]
		public long X;

		// Token: 0x040000AA RID: 170
		[FieldOffset(16)]
		public long Y;

		// Token: 0x040000AB RID: 171
		[FieldOffset(24)]
		public long D;

		// Token: 0x040000AC RID: 172
		[FieldOffset(32)]
		public double NX;

		// Token: 0x040000AD RID: 173
		[FieldOffset(40)]
		public double NY;
	}
}

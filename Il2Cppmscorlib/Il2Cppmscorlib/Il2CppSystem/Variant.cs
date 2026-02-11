using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000175 RID: 373
	[StructLayout(2)]
	public struct Variant
	{
		// Token: 0x0600191C RID: 6428 RVA: 0x0009C07C File Offset: 0x0009A27C
		// Note: this type is marked as 'beforefieldinit'.
		static Variant()
		{
			Il2CppClassPointerStore<Variant>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Variant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variant>.NativeClassPtr);
			Variant.NativeFieldInfoPtr_vt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "vt");
			Variant.NativeFieldInfoPtr_wReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved1");
			Variant.NativeFieldInfoPtr_wReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved2");
			Variant.NativeFieldInfoPtr_wReserved3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved3");
			Variant.NativeFieldInfoPtr_llVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "llVal");
			Variant.NativeFieldInfoPtr_lVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "lVal");
			Variant.NativeFieldInfoPtr_bVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bVal");
			Variant.NativeFieldInfoPtr_iVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "iVal");
			Variant.NativeFieldInfoPtr_fltVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "fltVal");
			Variant.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "dblVal");
			Variant.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "boolVal");
			Variant.NativeFieldInfoPtr_bstrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bstrVal");
			Variant.NativeFieldInfoPtr_cVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "cVal");
			Variant.NativeFieldInfoPtr_uiVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uiVal");
			Variant.NativeFieldInfoPtr_ulVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ulVal");
			Variant.NativeFieldInfoPtr_ullVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ullVal");
			Variant.NativeFieldInfoPtr_intVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "intVal");
			Variant.NativeFieldInfoPtr_uintVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uintVal");
			Variant.NativeFieldInfoPtr_pdispVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "pdispVal");
			Variant.NativeFieldInfoPtr_bRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bRecord");
			Variant.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variant>.NativeClassPtr, 100667636);
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0009C250 File Offset: 0x0009A450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349943, XrefRangeEnd = 1349951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variant.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00008139 File Offset: 0x00006339
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Variant>.NativeClassPtr, ref this));
		}

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeFieldInfoPtr_vt;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeFieldInfoPtr_wReserved1;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeFieldInfoPtr_wReserved2;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeFieldInfoPtr_wReserved3;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeFieldInfoPtr_llVal;

		// Token: 0x0400170B RID: 5899
		private static readonly IntPtr NativeFieldInfoPtr_lVal;

		// Token: 0x0400170C RID: 5900
		private static readonly IntPtr NativeFieldInfoPtr_bVal;

		// Token: 0x0400170D RID: 5901
		private static readonly IntPtr NativeFieldInfoPtr_iVal;

		// Token: 0x0400170E RID: 5902
		private static readonly IntPtr NativeFieldInfoPtr_fltVal;

		// Token: 0x0400170F RID: 5903
		private static readonly IntPtr NativeFieldInfoPtr_dblVal;

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_boolVal;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_bstrVal;

		// Token: 0x04001712 RID: 5906
		private static readonly IntPtr NativeFieldInfoPtr_cVal;

		// Token: 0x04001713 RID: 5907
		private static readonly IntPtr NativeFieldInfoPtr_uiVal;

		// Token: 0x04001714 RID: 5908
		private static readonly IntPtr NativeFieldInfoPtr_ulVal;

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeFieldInfoPtr_ullVal;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeFieldInfoPtr_intVal;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeFieldInfoPtr_uintVal;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_pdispVal;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_bRecord;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400171B RID: 5915
		[FieldOffset(0)]
		public short vt;

		// Token: 0x0400171C RID: 5916
		[FieldOffset(2)]
		public ushort wReserved1;

		// Token: 0x0400171D RID: 5917
		[FieldOffset(4)]
		public ushort wReserved2;

		// Token: 0x0400171E RID: 5918
		[FieldOffset(6)]
		public ushort wReserved3;

		// Token: 0x0400171F RID: 5919
		[FieldOffset(8)]
		public long llVal;

		// Token: 0x04001720 RID: 5920
		[FieldOffset(8)]
		public int lVal;

		// Token: 0x04001721 RID: 5921
		[FieldOffset(8)]
		public byte bVal;

		// Token: 0x04001722 RID: 5922
		[FieldOffset(8)]
		public short iVal;

		// Token: 0x04001723 RID: 5923
		[FieldOffset(8)]
		public float fltVal;

		// Token: 0x04001724 RID: 5924
		[FieldOffset(8)]
		public double dblVal;

		// Token: 0x04001725 RID: 5925
		[FieldOffset(8)]
		public short boolVal;

		// Token: 0x04001726 RID: 5926
		[FieldOffset(8)]
		public IntPtr bstrVal;

		// Token: 0x04001727 RID: 5927
		[FieldOffset(8)]
		public sbyte cVal;

		// Token: 0x04001728 RID: 5928
		[FieldOffset(8)]
		public ushort uiVal;

		// Token: 0x04001729 RID: 5929
		[FieldOffset(8)]
		public uint ulVal;

		// Token: 0x0400172A RID: 5930
		[FieldOffset(8)]
		public ulong ullVal;

		// Token: 0x0400172B RID: 5931
		[FieldOffset(8)]
		public int intVal;

		// Token: 0x0400172C RID: 5932
		[FieldOffset(8)]
		public uint uintVal;

		// Token: 0x0400172D RID: 5933
		[FieldOffset(8)]
		public IntPtr pdispVal;

		// Token: 0x0400172E RID: 5934
		[FieldOffset(8)]
		public BRECORD bRecord;
	}
}

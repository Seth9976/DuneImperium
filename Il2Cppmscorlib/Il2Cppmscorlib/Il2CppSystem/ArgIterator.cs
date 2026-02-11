using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000146 RID: 326
	[StructLayout(2)]
	public struct ArgIterator
	{
		// Token: 0x060016B9 RID: 5817 RVA: 0x00092C6C File Offset: 0x00090E6C
		// Note: this type is marked as 'beforefieldinit'.
		static ArgIterator()
		{
			Il2CppClassPointerStore<ArgIterator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgIterator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr);
			ArgIterator.NativeFieldInfoPtr_sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "sig");
			ArgIterator.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "args");
			ArgIterator.NativeFieldInfoPtr_next_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "next_arg");
			ArgIterator.NativeFieldInfoPtr_num_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "num_args");
			ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100667285);
			ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100667286);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x00092D14 File Offset: 0x00090F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344835, XrefRangeEnd = 1344841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x00092D58 File Offset: 0x00090F58
		[CallerCount(200)]
		[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x00007349 File Offset: 0x00005549
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, ref this));
		}

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeFieldInfoPtr_sig;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeFieldInfoPtr_next_arg;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeFieldInfoPtr_num_args;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001399 RID: 5017
		[FieldOffset(0)]
		public IntPtr sig;

		// Token: 0x0400139A RID: 5018
		[FieldOffset(8)]
		public IntPtr args;

		// Token: 0x0400139B RID: 5019
		[FieldOffset(16)]
		public int next_arg;

		// Token: 0x0400139C RID: 5020
		[FieldOffset(20)]
		public int num_args;
	}
}

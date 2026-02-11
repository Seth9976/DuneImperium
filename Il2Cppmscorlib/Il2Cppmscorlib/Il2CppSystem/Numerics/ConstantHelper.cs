using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000464 RID: 1124
	public class ConstantHelper : Object
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x0013CB3C File Offset: 0x0013AD3C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantHelper()
		{
			Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics", "ConstantHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr);
			ConstantHelper.NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673225);
			ConstantHelper.NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673226);
			ConstantHelper.NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673227);
			ConstantHelper.NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673228);
			ConstantHelper.NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673229);
			ConstantHelper.NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673230);
			ConstantHelper.NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673231);
			ConstantHelper.NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673232);
			ConstantHelper.NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673233);
			ConstantHelper.NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantHelper>.NativeClassPtr, 100673234);
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x0013CC34 File Offset: 0x0013AE34
		[CallerCount(0)]
		public unsafe static byte GetByteWithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x0013CC64 File Offset: 0x0013AE64
		[CallerCount(0)]
		public unsafe static sbyte GetSByteWithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x0013CC94 File Offset: 0x0013AE94
		[CallerCount(0)]
		public unsafe static ushort GetUInt16WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0013CCC4 File Offset: 0x0013AEC4
		[CallerCount(0)]
		public unsafe static short GetInt16WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		[CallerCount(0)]
		public unsafe static uint GetUInt32WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0013CD24 File Offset: 0x0013AF24
		[CallerCount(0)]
		public unsafe static int GetInt32WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x0013CD54 File Offset: 0x0013AF54
		[CallerCount(0)]
		public unsafe static ulong GetUInt64WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0013CD84 File Offset: 0x0013AF84
		[CallerCount(0)]
		public unsafe static long GetInt64WithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x0013CDB4 File Offset: 0x0013AFB4
		[CallerCount(0)]
		public unsafe static float GetSingleWithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0013CDE4 File Offset: 0x0013AFE4
		[CallerCount(0)]
		public unsafe static double GetDoubleWithAllBitsSet()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantHelper.NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0001866D File Offset: 0x0001686D
		public ConstantHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036D6 RID: 14038
		private static readonly IntPtr NativeMethodInfoPtr_GetByteWithAllBitsSet_Public_Static_Byte_0;

		// Token: 0x040036D7 RID: 14039
		private static readonly IntPtr NativeMethodInfoPtr_GetSByteWithAllBitsSet_Public_Static_SByte_0;

		// Token: 0x040036D8 RID: 14040
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt16WithAllBitsSet_Public_Static_UInt16_0;

		// Token: 0x040036D9 RID: 14041
		private static readonly IntPtr NativeMethodInfoPtr_GetInt16WithAllBitsSet_Public_Static_Int16_0;

		// Token: 0x040036DA RID: 14042
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt32WithAllBitsSet_Public_Static_UInt32_0;

		// Token: 0x040036DB RID: 14043
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32WithAllBitsSet_Public_Static_Int32_0;

		// Token: 0x040036DC RID: 14044
		private static readonly IntPtr NativeMethodInfoPtr_GetUInt64WithAllBitsSet_Public_Static_UInt64_0;

		// Token: 0x040036DD RID: 14045
		private static readonly IntPtr NativeMethodInfoPtr_GetInt64WithAllBitsSet_Public_Static_Int64_0;

		// Token: 0x040036DE RID: 14046
		private static readonly IntPtr NativeMethodInfoPtr_GetSingleWithAllBitsSet_Public_Static_Single_0;

		// Token: 0x040036DF RID: 14047
		private static readonly IntPtr NativeMethodInfoPtr_GetDoubleWithAllBitsSet_Public_Static_Double_0;
	}
}

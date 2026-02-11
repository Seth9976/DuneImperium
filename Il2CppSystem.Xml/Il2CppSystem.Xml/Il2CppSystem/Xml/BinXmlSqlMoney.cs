using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct BinXmlSqlMoney
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00017700 File Offset: 0x00015900
		// Note: this type is marked as 'beforefieldinit'.
		static BinXmlSqlMoney()
		{
			Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinXmlSqlMoney");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr);
			BinXmlSqlMoney.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, "data");
			BinXmlSqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, 100663328);
			BinXmlSqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, 100663329);
			BinXmlSqlMoney.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, 100663330);
			BinXmlSqlMoney.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, 100663331);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00017794 File Offset: 0x00015994
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 362307, RefRangeEnd = 362318, XrefRangeStart = 362307, XrefRangeEnd = 362307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlSqlMoney(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000177C8 File Offset: 0x000159C8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinXmlSqlMoney(long v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlMoney.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000177FC File Offset: 0x000159FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362318, XrefRangeEnd = 362319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ToDecimal()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlMoney.NativeMethodInfoPtr_ToDecimal_Public_Decimal_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0001782C File Offset: 0x00015A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 362330, RefRangeEnd = 362332, XrefRangeStart = 362319, XrefRangeEnd = 362330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinXmlSqlMoney.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000023D1 File Offset: 0x000005D1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinXmlSqlMoney>.NativeClassPtr, ref this));
		}

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ToDecimal_Public_Decimal_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000093 RID: 147
		[FieldOffset(0)]
		public long data;
	}
}

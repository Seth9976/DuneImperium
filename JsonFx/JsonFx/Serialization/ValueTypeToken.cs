using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Serialization
{
	// Token: 0x02000013 RID: 19
	[StructLayout(2)]
	public struct ValueTypeToken
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00007064 File Offset: 0x00005264
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeToken()
		{
			Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "ValueTypeToken");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr);
			ValueTypeToken.NativeFieldInfoPtr_IntValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, "IntValue");
			ValueTypeToken.NativeFieldInfoPtr_LongValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, "LongValue");
			ValueTypeToken.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, "FloatValue");
			ValueTypeToken.NativeFieldInfoPtr_DoubleValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, "DoubleValue");
			ValueTypeToken.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTypeToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, 100663398);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000070F8 File Offset: 0x000052F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 555566, RefRangeEnd = 555578, XrefRangeStart = 555566, XrefRangeEnd = 555578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ValueTypeToken other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeToken.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTypeToken_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000254F File Offset: 0x0000074F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTypeToken>.NativeClassPtr, ref this));
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_IntValue;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_LongValue;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_FloatValue;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_DoubleValue;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTypeToken_0;

		// Token: 0x04000096 RID: 150
		[FieldOffset(0)]
		public int IntValue;

		// Token: 0x04000097 RID: 151
		[FieldOffset(0)]
		public long LongValue;

		// Token: 0x04000098 RID: 152
		[FieldOffset(0)]
		public float FloatValue;

		// Token: 0x04000099 RID: 153
		[FieldOffset(0)]
		public double DoubleValue;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F2 RID: 498
	[StructLayout(2)]
	public struct NetErrorMessage
	{
		// Token: 0x06001921 RID: 6433 RVA: 0x00008221 File Offset: 0x00006421
		// Note: this type is marked as 'beforefieldinit'.
		static NetErrorMessage()
		{
			Il2CppClassPointerStore<NetErrorMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetErrorMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetErrorMessage>.NativeClassPtr);
			NetErrorMessage.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetErrorMessage>.NativeClassPtr, "Value");
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0000825A File Offset: 0x0000645A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetErrorMessage>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001E6A RID: 7786
		[FieldOffset(0)]
		public NetErrorMessage._Value_e__FixedBuffer Value;

		// Token: 0x0200029F RID: 671
		[ObfuscatedName("Steamworks.Data.NetErrorMessage+<Value>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _Value_e__FixedBuffer
		{
			// Token: 0x060021FB RID: 8699 RVA: 0x0000DAB5 File Offset: 0x0000BCB5
			// Note: this type is marked as 'beforefieldinit'.
			static _Value_e__FixedBuffer()
			{
				Il2CppClassPointerStore<NetErrorMessage._Value_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetErrorMessage>.NativeClassPtr, "<Value>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetErrorMessage._Value_e__FixedBuffer>.NativeClassPtr);
				NetErrorMessage._Value_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetErrorMessage._Value_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x0000DAE9 File Offset: 0x0000BCE9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetErrorMessage._Value_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x040023A6 RID: 9126
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x040023A7 RID: 9127
			[FieldOffset(0)]
			public char FixedElementField;
		}
	}
}

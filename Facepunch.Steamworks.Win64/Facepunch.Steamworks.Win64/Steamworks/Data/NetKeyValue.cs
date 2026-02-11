using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B9 RID: 441
	[StructLayout(2)]
	public struct NetKeyValue
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x0006E70C File Offset: 0x0006C90C
		// Note: this type is marked as 'beforefieldinit'.
		static NetKeyValue()
		{
			Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "NetKeyValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr);
			NetKeyValue.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "Value");
			NetKeyValue.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "DataType");
			NetKeyValue.NativeFieldInfoPtr_Int64Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "Int64Value");
			NetKeyValue.NativeFieldInfoPtr_Int32Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "Int32Value");
			NetKeyValue.NativeFieldInfoPtr_FloatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "FloatValue");
			NetKeyValue.NativeFieldInfoPtr_PointerValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, "PointerValue");
			NetKeyValue.NativeMethodInfoPtr_InternalSetInt32_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, 100667411);
			NetKeyValue.NativeMethodInfoPtr_InternalSetInt64_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, 100667412);
			NetKeyValue.NativeMethodInfoPtr_InternalSetFloat_Internal_Static_Void_byref_NetKeyValue_NetConfig_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, 100667413);
			NetKeyValue.NativeMethodInfoPtr_InternalSetPtr_Internal_Static_Void_byref_NetKeyValue_NetConfig_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, 100667414);
			NetKeyValue.NativeMethodInfoPtr_InternalSetString_Internal_Static_Void_byref_NetKeyValue_NetConfig_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, 100667415);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0006E818 File Offset: 0x0006CA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951185, XrefRangeEnd = 951187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetInt32(ref NetKeyValue self, NetConfig eVal, int data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetKeyValue.NativeMethodInfoPtr_InternalSetInt32_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0006E868 File Offset: 0x0006CA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951187, XrefRangeEnd = 951189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetInt64(ref NetKeyValue self, NetConfig eVal, long data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetKeyValue.NativeMethodInfoPtr_InternalSetInt64_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0006E8B8 File Offset: 0x0006CAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951189, XrefRangeEnd = 951191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetFloat(ref NetKeyValue self, NetConfig eVal, float data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetKeyValue.NativeMethodInfoPtr_InternalSetFloat_Internal_Static_Void_byref_NetKeyValue_NetConfig_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x0006E908 File Offset: 0x0006CB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951191, XrefRangeEnd = 951193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetPtr(ref NetKeyValue self, NetConfig eVal, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetKeyValue.NativeMethodInfoPtr_InternalSetPtr_Internal_Static_Void_byref_NetKeyValue_NetConfig_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0006E958 File Offset: 0x0006CB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951193, XrefRangeEnd = 951196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetString(ref NetKeyValue self, NetConfig eVal, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eVal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetKeyValue.NativeMethodInfoPtr_InternalSetString_Internal_Static_Void_byref_NetKeyValue_NetConfig_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00007712 File Offset: 0x00005912
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetKeyValue>.NativeClassPtr, ref this));
		}

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_Int64Value;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_Int32Value;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_FloatValue;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeFieldInfoPtr_PointerValue;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetInt32_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int32_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetInt64_Internal_Static_Void_byref_NetKeyValue_NetConfig_Int64_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetFloat_Internal_Static_Void_byref_NetKeyValue_NetConfig_Single_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetPtr_Internal_Static_Void_byref_NetKeyValue_NetConfig_IntPtr_0;

		// Token: 0x04001B9B RID: 7067
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetString_Internal_Static_Void_byref_NetKeyValue_NetConfig_String_0;

		// Token: 0x04001B9C RID: 7068
		[FieldOffset(0)]
		public NetConfig Value;

		// Token: 0x04001B9D RID: 7069
		[FieldOffset(4)]
		public NetConfigType DataType;

		// Token: 0x04001B9E RID: 7070
		[FieldOffset(8)]
		public long Int64Value;

		// Token: 0x04001B9F RID: 7071
		[FieldOffset(8)]
		public int Int32Value;

		// Token: 0x04001BA0 RID: 7072
		[FieldOffset(8)]
		public float FloatValue;

		// Token: 0x04001BA1 RID: 7073
		[FieldOffset(8)]
		public IntPtr PointerValue;
	}
}

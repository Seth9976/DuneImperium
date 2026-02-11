using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000B4 RID: 180
	[StructLayout(2)]
	public struct AppId
	{
		// Token: 0x06000BB8 RID: 3000 RVA: 0x0004FB14 File Offset: 0x0004DD14
		// Note: this type is marked as 'beforefieldinit'.
		static AppId()
		{
			Il2CppClassPointerStore<AppId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "AppId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppId>.NativeClassPtr);
			AppId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppId>.NativeClassPtr, "Value");
			AppId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId>.NativeClassPtr, 100666180);
			AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId>.NativeClassPtr, 100666181);
			AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId>.NativeClassPtr, 100666182);
			AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AppId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppId>.NativeClassPtr, 100666183);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004FBA8 File Offset: 0x0004DDA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946094, XrefRangeEnd = 946095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0004FBD4 File Offset: 0x0004DDD4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AppId(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004FC14 File Offset: 0x0004DE14
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AppId(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0004FC54 File Offset: 0x0004DE54
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(AppId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AppId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00002E87 File Offset: 0x00001087
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AppId>.NativeClassPtr, ref this));
		}

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_UInt32_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AppId_Int32_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AppId_0;

		// Token: 0x04001252 RID: 4690
		[FieldOffset(0)]
		public uint Value;
	}
}
